#define MyAppName "ContactApp"
#define MyAppVersion "1.0"
#define MyAppPublisher "https://github.com/Gonenti"
#define MyAppURL "https://github.com/Gonenti/ContactsApp"
#define MyAppExeName "ContactsApp.View.exe"
#define MyAppAssocName MyAppName + " File"

[Setup]
AppId={{F1E79B90-13A6-4881-998F-95FBF015AFC6}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\Olimov/ContactApp
ChangesAssociations=yes
DisableProgramGroupPage=yes
LicenseFile=..\LICENSE

OutputDir=Output
OutputBaseFilename=mysetup
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "..\src\ContactsApp\ContactsApp.View\bin\Debug\net6.0-windows\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\src\ContactsApp\ContactsApp.View\bin\Debug\net6.0-windows\*dll*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "..\src\ContactsApp\ContactsApp.View\bin\Debug\net6.0-windows\*.json*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
