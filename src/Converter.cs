using System;
using System.IO;

namespace pdf2word
{
    public static class Converter
    {
        // This is a wrapper. Use Aspose.PDF, Apryse(PDFTron), or another SDK here.
        public static void ConvertPdfToDocx(string pdfPath, string docxPath)
        {
            // Example using Aspose.PDF (you must add Aspose.PDF NuGet package):
            // var pdfDocument = new Aspose.Pdf.Document(pdfPath);
            // pdfDocument.Save(docxPath, Aspose.Pdf.SaveFormat.DocX);

            // For demo, we will throw if Aspose is not present to remind developer to install it.
            throw new InvalidOperationException("Add a PDF conversion SDK (e.g., Aspose.PDF) and uncomment the conversion code in Converter.cs");
        }
    }
}
