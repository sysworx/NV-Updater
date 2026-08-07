Imports System.Text

Module ProcessAsyncHelper
    Async Function RunProcessAsync(ByVal command As String, ByVal arguments As String, ByVal timeout As Integer, ByVal path As String, ByVal shellex As Boolean, ByVal creatwin As Boolean) As Task(Of ProcessResult)
        Dim result = New ProcessResult()

        Using process = New Process()
            process.StartInfo.FileName = command
            process.StartInfo.Arguments = arguments

            process.StartInfo.CreateNoWindow = creatwin
            process.StartInfo.WorkingDirectory = path
            If shellex = True Then
                process.StartInfo.Verb = "runas"
                process.StartInfo.UseShellExecute = False
                process.StartInfo.RedirectStandardOutput = True
                process.StartInfo.RedirectStandardError = False
            Else
                process.StartInfo.UseShellExecute = False
                process.StartInfo.RedirectStandardOutput = True
                process.StartInfo.RedirectStandardError = True
            End If
            Dim outputBuilder = New StringBuilder()
            Dim outputCloseEvent = New TaskCompletionSource(Of Boolean)()
            AddHandler process.OutputDataReceived, Sub(s, e)

                                                       If e.Data Is Nothing Then
                                                           outputCloseEvent.SetResult(True)
                                                       Else
                                                           outputBuilder.Append(e.Data)
                                                       End If
                                                   End Sub

            Dim errorBuilder = New StringBuilder()
            Dim errorCloseEvent = New TaskCompletionSource(Of Boolean)()
            AddHandler process.ErrorDataReceived, Sub(s, e)

                                                      If e.Data Is Nothing Then
                                                          errorCloseEvent.SetResult(True)
                                                      Else
                                                          errorBuilder.Append(e.Data)
                                                      End If
                                                  End Sub

            Dim isStarted = process.Start()

            If Not isStarted Then
                result.ExitCode = process.ExitCode
                Return result
            End If

            process.BeginOutputReadLine()
            process.BeginErrorReadLine()
            Dim waitForExit = WaitForExitAsync(process, timeout)
            Dim processTask = Task.WhenAll(waitForExit, outputCloseEvent.Task, errorCloseEvent.Task)

            If Await Task.WhenAny(Task.Delay(timeout), processTask) Is processTask AndAlso waitForExit.Result Then
                result.ExitCode = process.ExitCode
                result.Output = outputBuilder.ToString()
                result.[Error] = errorBuilder.ToString()
            Else

                Try
                    process.Kill()
                Catch
                End Try
            End If
        End Using

        Return result
    End Function

    Private Function WaitForExitAsync(ByVal process As Process, ByVal timeout As Integer) As Task(Of Boolean)
        Return Task.Run(Function() process.WaitForExit(timeout))
    End Function

    Public Structure ProcessResult
        Public ExitCode As Integer?
        Public Output As String
        Public [Error] As String
    End Structure
End Module
