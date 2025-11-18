using Microsoft.Win32;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace pdf2word
{
    public partial class MainWindow : Window
    {
        private string _currentPdf = string.Empty;

        public MainWindow()
        {
            InitializeComponent();

            BtnOpen.Click += BtnOpen_Click;
            BtnConvert.Click += BtnConvert_Click;

            TxtDrop.PreviewDragOver += TxtDrop_PreviewDragOver;
            TxtDrop.Drop += TxtDrop_Drop;
        }

        private void TxtDrop_PreviewDragOver(object sender, DragEventArgs e)
        {
            e.Handled = true;
        }

        private void TxtDrop_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0 && Path.GetExtension(files[0]).Equals(".pdf", StringComparison.OrdinalIgnoreCase))
                {
                    _currentPdf = files[0];
                    TxtDrop.Text = _currentPdf;
                    StatusText.Text = "PDF loaded";
                }
            }
        }

        private void BtnOpen_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "PDF Files (*.pdf)|*.pdf";
            if (dlg.ShowDialog() == true)
            {
                _currentPdf = dlg.FileName;
                TxtDrop.Text = _currentPdf;
                StatusText.Text = "PDF loaded";
            }
        }

        private async void BtnConvert_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_currentPdf) || !File.Exists(_currentPdf))
            {
                MessageBox.Show("Please select a PDF file first.", "No file", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            BtnConvert.IsEnabled = false;
            StatusText.Text = "Converting...";

            try
            {
                var output = Path.ChangeExtension(_currentPdf, ".docx");
                await Task.Run(() => Converter.ConvertPdfToDocx(_currentPdf, output));
                StatusText.Text = "Conversion finished: " + output;
                MessageBox.Show("Conversion finished:\n" + output, "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                StatusText.Text = "Error";
            }
            finally
            {
                BtnConvert.IsEnabled = true;
            }
        }
    }
}
