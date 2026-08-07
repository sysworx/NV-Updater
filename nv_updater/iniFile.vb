Option Strict On
Imports System.Environment
Friend Module iniFile

#Region "API"

    Private Declare Ansi Function GetPrivateProfileString Lib "kernel32.dll" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Ansi Function WritePrivateProfileString Lib "kernel32.dll" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer

    Public Function iniRead(ByVal strSection As String, ByVal strKey As String, ByVal strDefault As String, ByVal strFile As String) As String
        Try
            Dim strTemp As String = Space(1024), lLength As Integer
            lLength = GetPrivateProfileString(strSection, strKey, strDefault, strTemp, strTemp.Length, strFile)
            Return strTemp.Substring(0, lLength)
        Catch ex As Exception
            MsgBox("There was an error at the config file! Error was saved to Logfile" & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
            LogHelper.Errorlog("There was an error at the config file" & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Function

    Public Function iniWrite(ByVal strSection As String, ByVal strKey As String, ByVal strValue As String, ByVal strFile As String) As Boolean
        Try
            Return Not (WritePrivateProfileString(strSection, strKey, strValue, strFile) = 0)
        Catch ex As Exception
            MsgBox("There was an error at the config file! Error was saved to Logfile" & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
            LogHelper.Errorlog("There was an error at the config file" & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Function
#End Region

    'set ini file and path
    Public AppConfig As String = Settings.AppConfigFolder + "nvu_config.ini"
End Module
