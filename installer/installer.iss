; Inno Setup Script for pdf2word Installer
[Setup]
AppName=pdf2word
AppVersion=1.0.0
AppPublisher=bx211
DefaultDirName={pf}\pdf2word
DefaultGroupName=pdf2word
OutputDir=.
OutputBaseFilename=pdf2word-installer
Compression=lzma
SolidCompression=yes

[Files]
Source: "bin\\pdf2word.exe"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{group}\\pdf2word"; Filename: "{app}\\pdf2word.exe"
Name: "{commondesktop}\\pdf2word"; Filename: "{app}\\pdf2word.exe"; Tasks: desktopicon

[Tasks]
Name: "desktopicon"; Description: "Create a desktop shortcut"; GroupDescription: "Additional icons:"
