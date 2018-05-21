
[Setup]
AppName=Document Case
AppVerName=Document Case V 1.0.0.0
VersionInfoVersion=1.0.0.0
VersionInfoCompany=BXSofts
VersionInfoProductName= Document Case
VersionInfoProductVersion=1.0.0.0
VersionInfoDescription=Manage Document Case. C@P Baiju Xavior, Fingerprint Expert.
VersionInfoTextVersion=1.0.0.0
VersionInfoCopyright=C@P BXSofts
MinVersion=0,5
AppComments=Manage Document Case. C@P Baiju Xavior, Fingerprint Expert.
AppCopyright=Copyright © 2007-2012 BXSofts, Inc
AppPublisher=BXSofts, Inc.
AppMutex=Document_Case_APPMUTEX
AppID={{EAEB9BC9-9DE7-4758-AB71-400D3032EA73}
DefaultDirName={pf}\BXSofts\Document Case
DefaultGroupName=BXSofts\Document Case
OutputDir=.
UsePreviousAppDir=yes
UsePreviousGroup=yes
UsePreviousSetupType=yes
OutputBaseFilename=Document Case V1.0
SolidCompression=true
PrivilegesRequired=admin
ChangesAssociations=true
TerminalServicesAware=yes
AllowNoIcons=yes
AllowRootDirectory=No
AlwaysShowDirOnReadyPage=yes
AlwaysShowGroupOnReadyPage=yes
AlwaysUsePersonalGroup=yes
Uninstallable=yes
UninstallDisplayIcon={app}\Document Case.exe
UninstallFilesDir={app}
WizardImageBackColor=clRed
WindowVisible=false
WizardImageFile=.\Icons\WizardImage.bmp
WizardSmallImageFile=.\Icons\WizardImageSmall.bmp
SetupIconFile=.\Icons\Setup Icon.ico


[Icons]
Name: {commonprograms}\BXSofts\Document Case\Document Case; Filename: {app}\Document Case.exe
Name: {commonprograms}\BXSofts\Document Case\{cm:UninstallProgram,Document Case}; Filename: {uninstallexe}
Name: {commondesktop}\Document Case; Filename: {app}\Document Case.exe; Tasks: desktopicon; Comment: "Document Case. Designed and programmed by Baiju Xavior, Fingerprint Expert."; HotKey: "ctrl+alt+d"
Name: {userappdata}\Microsoft\Internet Explorer\Quick Launch\Document Case; Filename: {app}\Document Case.exe; Tasks: quicklaunchicon ; Comment: "Document Case. Designed and programmed by Baiju Xavior, Fingerprint Expert."; OnlyBelowVersion: 6.1



[Files]

Source: .\Fonts\segoeui.ttf; DestDir: {fonts}; Flags: onlyifdoesntexist uninsneveruninstall; FontInstall: Segoe UI
Source: .\Fonts\segoeuib.ttf; DestDir: {fonts}; Flags: onlyifdoesntexist uninsneveruninstall; FontInstall: Segoe UI Bold
Source: .\Fonts\SEGOEUII.TTF; DestDir: {fonts}; Flags: onlyifdoesntexist uninsneveruninstall; FontInstall: Sego UI Italic
Source: .\Fonts\SEGOEUIZ.TTF; DestDir: {fonts}; Flags: onlyifdoesntexist uninsneveruninstall; FontInstall: Sego UI BoldItalic
Source: .\Fonts\Rupee_Foradian.ttf; DestDir: {fonts}; Flags: onlyifdoesntexist uninsneveruninstall; FontInstall: Rupee Foradian

Source: ..\Document Case\bin\Release\DevComponents.DotNetBar2.dll; DestDir: {app}\; Flags: ignoreversion
Source: ..\Document Case\bin\Release\Document Case.pdb; DestDir: {app}\; Flags: ignoreversion
Source: ..\Document Case\bin\Release\Document Case.xml; DestDir: {app}\; Flags: ignoreversion
Source: ..\Document Case\bin\Release\Document Case.exe.config; DestDir: {app}\; Flags: ignoreversion
Source: ..\Document Case\bin\Release\Document Case.exe; DestDir: {app}\; Flags: ignoreversion


Source: .\Database\DocumentCase.mdb; DestDir: {app}\; Flags: onlyifdoesntexist uninsneveruninstall
Source: .\Scripts\PinToTaskbar.exe; DestDir: {app}\; Flags: ignoreversion; Tasks: Pintotaskbar

[Run]
Filename: {app}\PinToTaskbar.exe; Tasks: Pintotaskbar 
Filename: {app}\Document Case.exe; Description: {cm:LaunchProgram,Document Case}; Flags: nowait postinstall skipifsilent runascurrentuser; WorkingDir: {app}


[Tasks]
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: {cm:AdditionalIcons}
Name: quicklaunchicon; Description: {cm:CreateQuickLaunchIcon}; GroupDescription: {cm:AdditionalIcons}; OnlyBelowVersion: 6.1
Name: pintotaskbar; Description: Add shortcut to Windows 7 Taskbar and Start Menu ; GroupDescription: {cm:AdditionalIcons}; MinVersion: 6.1



