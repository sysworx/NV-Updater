Option Strict On
Imports System.Environment
Imports System.Globalization
Imports System.IO

Module LogHelper

    Public logMode As Boolean
    Public updateTimer As New Windows.Forms.Timer
    ' Set path
    Private ReadOnly logFolder As String = Path.Combine(GetFolderPath(SpecialFolder.ApplicationData), $"{Application.ProductName}\Logs\")

    Public Function Log(entry As String) As Boolean
        If logMode Then
            ' Set log file name
            Dim logFile = Path.Combine(logFolder, $"{Application.ProductName}log_{Now:ddMMyyyy}.log")

            ' Write log file header + entry
            If Not File.Exists(logFile) Then
                ' Check if 64-bit operating system
                Dim architecture = If(Environment.Is64BitOperatingSystem, "64 Bit", "32 Bit")
                File.Create(logFile).Dispose()

                Using file = New StreamWriter(logFile, True)
                    file.WriteLine($"---- {Application.ProductName} {Application.ProductVersion} Logfile -----------------------------------")
                    file.WriteLine($"Created on {Now}")
                    file.WriteLine($"OS: {My.Computer.Info.OSFullName} {architecture} | Language: {CultureInfo.CurrentCulture}")
                    file.WriteLine($"Graphics-Card: {GraphicsInfo(3)} | Installed Driver: {GraphicsInfo(7)}")
                    file.WriteLine("-------------------------------------------------------------------")
                    file.WriteLine($"{Now} - {entry}")
                End Using
            Else
                ' Write entry
                Using file = New StreamWriter(logFile, True)
                    file.WriteLine($"{Now} - {entry}")
                End Using
            End If
        End If

        Return True
    End Function

    Public Function ErrorLog(entry As String) As Boolean
        ' Set log file name
        Dim logFile = Path.Combine(logFolder, $"{Application.ProductName}log_error{Now:ddMMyyyy}.log")

        ' Write entry
        Using file = New StreamWriter(logFile, True)
            file.WriteLine($"{Now} - {entry}")
        End Using

        Return True
    End Function

End Module