; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{D591669C-3C49-4DAB-973E-B9E3AD238CCA}
AppName=ImageResize
AppVerName=ImageResize 1.0.0.0
AppPublisher=Damian Kozlowski
DefaultDirName={pf}\ImageResize
DefaultGroupName=ImageResize
AllowNoIcons=yes
LicenseFile=C:\Users\Damian\Documents\GNU.rtf
OutputBaseFilename=ImageResize
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\Damian\Documents\Visual Studio 2008\Projects\ImageResize\ImageResize\obj\Release\ImageResize.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Damian\Documents\Visual Studio 2008\Projects\ImageResize\ImageResize\obj\Release\ImageResize.exe.manifest"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\ImageResize"; Filename: "{app}\ImageResize.exe"
Name: "{group}\{cm:UninstallProgram,ImageResize}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\ImageResize"; Filename: "{app}\ImageResize.exe"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\ImageResize"; Filename: "{app}\ImageResize.exe"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\ImageResize.exe"; Description: "{cm:LaunchProgram,ImageResize}"; Flags: nowait postinstall skipifsilent



