Imports System.Threading 'to create a mutex which will ensure that only one application is running

Module modMain

    Enum ButtonAction
        DocumentDataEntry
        DocumentDataEdit
        DocumentDataSearch
    End Enum

    Public objMutex As Mutex 'mutex object

    Public AppName As String = "Document Case"
    Public RegistrySettingsPath As String = "HKEY_CURRENT_USER\Software\BXSofts\Document Cases"
    Public AppPath As String = My.Application.Info.DirectoryPath
    Public DatabaseFile As String = AppPath & "\DocumentCase.mdb"
    Public ConString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DatabaseFile
    Public CancelImport As Boolean = False
End Module
