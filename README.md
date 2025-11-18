# PDF to Word Converter (Windows) — Starter (C# WPF)

Project name: pdf2word
Publisher: bx211
GitHub: https://github.com/Bx211

## Overview
This is a starter C# WPF (.NET 7+) project template that converts PDF -> DOCX using a commercial PDF conversion library (recommended: Aspose.PDF or Apryse/PDFTron).

**Why C# WPF?** For a polished native Windows UI (closest to Adobe Reader) and good integration with Windows features.

## Recommendation (conversion engine)
- **Best quality (recommended):** Aspose.PDF for .NET or Apryse (PDFTron) — commercial, very accurate PDF->DOCX conversion. See Aspose docs: https://products.aspose.com/pdf/net/conversion/pdf-to-docx/ .
- **Alternative (self-hosted open source):** Use a Python backend (pdf2docx) if you need a free option but expect lower fidelity for complex PDFs.

## How to use this starter
1. Open the `pdf2word.sln` in Visual Studio 2022/2023 (or `dotnet` CLI for building). The project targets .NET 7/WPF.

2. Add a NuGet package for Aspose.PDF (or your chosen library). Example (Package Manager Console):

   Install-Package Aspose.PDF

3. Build and run. The UI is a simple WPF window with Drag & Drop and a "Convert" button.

4. Packaging to EXE: publish with `dotnet publish -c Release -r win-x64` or use Visual Studio Publish to produce a single-folder app or single-file EXE.

## Files included in this starter
- pdf2word.sln
- src/ (WPF project)
  - pdf2word.csproj
  - App.xaml, App.xaml.cs
  - MainWindow.xaml, MainWindow.xaml.cs
  - Converter.cs (wrapper to call Aspose.PDF or other SDK)
- installer/installer.iss (Inno Setup script)

## Notes on licensing
Aspose and Apryse are commercial products. You can use trial licenses during development. For production deployment, obtain proper licensing.
