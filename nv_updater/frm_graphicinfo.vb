Imports System.IO
Imports System.Management
Imports System.Text

Public Class frm_graphicinfo
    Dim CsvLine1 As String = "NVU Version"
    Dim CsvLine2 As String = String.Format("Version: {0}", My.Application.Info.Version.ToString)
    Private Sub frm_graphicinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim GraphicObject As ManagementObjectSearcher = New ManagementObjectSearcher("select * from Win32_VideoController where Description like '%nvidia%' or AdapterCompatibility like '%nvidia%'")

            If GraphicObject.Get().Count = 0 Then
                MsgBox("Your PC does not seem to have an NVIDIA graphics card installed, NV Updater will now exit!", MsgBoxStyle.Information)
                LogHelper.ErrorLog("Your PC does not seem to have an NVIDIA graphics card installed, NV Updater will now exit!")
                End
            End If

            For Each obj As ManagementObject In GraphicObject.[Get]()
                For Each item As PropertyData In obj.Properties()
                    Try
                        lv_info.Items.Add(item.Name).SubItems.Add(item.Value)
                        CsvLine1 = CsvLine1 + ";" + item.Name.ToString
                        CsvLine2 = CsvLine2 + ";" + item.Value.ToString
                    Catch ex As Exception
                    End Try
                Next
                Exit For
            Next

        Catch ex As Exception
            MsgBox("There was an error at GraphicsInfo! Error was saved to Logfile" & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
            LogHelper.ErrorLog("There was an Error at GraphicsInfo" & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
        End Try

    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Me.Close()
    End Sub

    Private Sub btn_export_Click(sender As Object, e As EventArgs) Handles btn_export.Click

        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "csv files (*.csv)|*.csv"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        saveFileDialog1.FileName = "nv_updater_graphic_export"
        Try
            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim FileName As String = saveFileDialog1.FileName
                File.Create(FileName).Close()

                If File.Exists(FileName) = True Then
                    Dim objWriter As New System.IO.StreamWriter(FileName)
                    objWriter.Write(CsvLine1)
                    objWriter.Write(vbNewLine)
                    objWriter.Write(CsvLine2)
                    objWriter.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox("There was an error! " & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
        End Try

    End Sub
End Class