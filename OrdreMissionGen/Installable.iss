; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "OMG_OrdreMissionGenerator"
#define MyAppVersion "1.0"
#define MyAppPublisher "REMACHE AMINE RIAD"
#define MyAppURL "https://www.linkedin.com/in/remache-amine/"
#define MyAppExeName "OrdreMissionGen.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{59FBAE88-E3BA-4283-A6FA-DC3B7EED93EE}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\OrdreMissionGenerator
DisableProgramGroupPage=yes
InfoBeforeFile=D:\AMINE\Developpement\GitHub\VisualStudio\OrdreMissionGen\OrdreMissionGen\bin\Debug\About.txt
OutputDir=C:\Users\amine\Desktop\Setup
OutputBaseFilename=OrdreMissionGenerator
SetupIconFile=D:\AMINE\Developpement\GitHub\VisualStudio\OrdreMissionGen\OrdreMissionGen\bin\Debug\logo.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "french"; MessagesFile: "compiler:Languages\French.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
Source: "D:\AMINE\Developpement\GitHub\VisualStudio\OrdreMissionGen\OrdreMissionGen\bin\Debug\OrdreMissionGen.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\AMINE\Developpement\GitHub\VisualStudio\OrdreMissionGen\OrdreMissionGen\bin\Debug\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{commonprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
