Option Strict On
Imports System.Management
Imports HtmlAgilityPack
Imports System.Globalization
Imports System.Net
Imports System.IO
Imports System.Collections
Imports System.Text.RegularExpressions
Imports System.Net.Http
Imports System.Xml.Linq

Module nvidia_helper
    Public OSVer As String
    Public nvOS As String
    Public nvLang As String
    Public nvPFID As String
    Public nvPSID As String
    Public Lightmode As Boolean
    Public OnlineInfo As ArrayList = Nothing

    Public Function GetOnlineVersion(ByVal link As String) As ArrayList

        Dim infoList As New ArrayList

        Try
            ' Lade die Webseite mit dem Treiberlink
            Dim web As New HtmlWeb()
            Dim doc As HtmlDocument = web.Load(link)

            ' Extrahiere die benötigten Informationen aus dem HTML
            Dim onlineVersion As String = doc.GetElementbyId("tdVersion")?.InnerText?.Trim()?.Substring(0, 6)
            Dim releaseDate As String = doc.GetElementbyId("tdReleaseDate")?.InnerText?.Trim()
            Dim releaseDesc As String = doc.GetElementbyId("tab1_content")?.InnerHtml?.Trim()

            Dim confirmLink As String = doc.GetElementbyId("lnkDwnldBtn")?.GetAttributeValue("href", "")

            ' Erstelle die vollständige Bestätigungs-URL
            Dim confirmUrl As String = $"https://www.nvidia.com{confirmLink}"

            ' Suche nach dem Download-Link
            Dim confirmDoc As HtmlDocument = web.Load(confirmUrl)
            Dim downloadLink As String = confirmDoc.DocumentNode.Descendants("a").FirstOrDefault(Function(x) x.GetAttributeValue("href", "").Contains("download.nvidia"))?.GetAttributeValue("href", "")

            ' Korrigiere den Download-Link, wenn er mit "//" beginnt
            If Not String.IsNullOrEmpty(downloadLink) AndAlso Not downloadLink.StartsWith("http://") AndAlso Not downloadLink.StartsWith("https://") Then
                downloadLink = $"https:{downloadLink}"
            End If

            ' Überprüfe, ob der Download-Link gültig ist
            If Not Uri.TryCreate(downloadLink, UriKind.Absolute, Nothing) Then
                LogHelper.Log($"GetOnlineVersion: no valid NVIDIA URL detected, see error log")
                MessageBox.Show($"There was an error with GetOnlineVersion! The URL ({downloadLink}) from NVIDIA seems to be invalid! The error was saved in the error log file.")
                LogHelper.ErrorLog($"There was an error with GetOnlineVersion. The URL ({downloadLink}) from NVIDIA appears to be invalid!")
                Return infoList
            End If

            ' Berechne die Größe der herunterzuladenden Datei
            Dim downloadSize As Double = 0
            Dim request As HttpWebRequest = CType(HttpWebRequest.Create(downloadLink), HttpWebRequest)
            request.Method = "HEAD"
            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                downloadSize = (response.ContentLength / 1024) / 1024
            End Using

            ' Füge die Informationen zur Rückgabe-Liste hinzu
            infoList.Add(onlineVersion)
            infoList.Add(releaseDate)
            infoList.Add(releaseDesc)
            infoList.Add(downloadLink)
            infoList.Add(downloadSize.ToString("###,###,##0.00"))

        Catch ex As Exception
            MessageBox.Show($"There was an error with GetOnlineVersion! The error was saved in the logfile.{vbCrLf}{ex.Message}{vbCrLf}{ex.StackTrace}", "NV-Updater", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LogHelper.ErrorLog($"There was an error with GraphicsInfo.{vbCrLf}{ex.Message}{vbCrLf}{ex.StackTrace}")
        End Try

        Return infoList
    End Function


    Public Function GraphicsInfo() As ArrayList
        Dim gInfo As New ArrayList
        Try
            'Optimus Fix 3 in 0.3.0.4 added
            Dim GraphicObject As ManagementObjectSearcher = New ManagementObjectSearcher("select * from Win32_VideoController where Description like '%nvidia%' or Caption like '%nvidia%'")

            If GraphicObject.Get().Count = 0 Then
                MessageBox.Show("Your PC does not seem to have an NVIDIA graphics card installed, NV Updater will now exit!", "NV-Updater", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LogHelper.ErrorLog("Your PC does not seem to have an NVIDIA graphics card installed, NV Updater will now exit!")
                End
            End If

            For Each obj As ManagementObject In GraphicObject.[Get]()
                'convert the driver version to web format
                Dim DriverVersion As String = obj("DriverVersion").ToString().Replace(".", String.Empty)
                DriverVersion = DriverVersion.Substring(DriverVersion.Length - 5, 5)
                DriverVersion = DriverVersion.Substring(0, 3) & "." + DriverVersion.Substring(3)

                gInfo.Add(obj("Name"))              '0
                gInfo.Add(obj("Status"))            '1
                gInfo.Add(obj("Caption"))           '2
                gInfo.Add(obj("Description"))       '3
                gInfo.Add(obj("DeviceID"))          '4
                gInfo.Add(obj("AdapterRAM"))        '5
                gInfo.Add(obj("AdapterDACType"))    '6
                gInfo.Add(DriverVersion)            '7
                gInfo.Add(obj("VideoProcessor"))    '8
                gInfo.Add(obj("VideoArchitecture")) '9
                gInfo.Add(obj("PNPDeviceID"))       '10
                gInfo.Add(obj("VideoMemoryType"))   '11
                gInfo.Add(obj("PNPDeviceID"))       '12
            Next

        Catch ex As Exception
            MessageBox.Show($"There was an error at GraphicsInfo! Error was saved to Logfile. {vbCrLf}{ex.Message}{vbCrLf}{ex.StackTrace}", "NV-Updater", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LogHelper.ErrorLog("There was an Error at GraphicsInfo" & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
        End Try
        Return gInfo
    End Function

    Public Function OSInfos() As ArrayList
        '0 = OSCult / 1 = OSVersion / 2 = is64bit
        Dim OSlist As New ArrayList

        'language check nvLang
        Dim OSCulture As String = CultureInfo.CurrentCulture.ToString()
        LogHelper.Log("Detected Culture: " + OSCulture)

        Select Case OSCulture
            Case "en-US", "en-GB"
                OSlist.Add("1")
            Case "zh-CHS"
                OSlist.Add("5")
            Case "zh-CHT"
                OSlist.Add("6")
            Case "ja-JP"
                OSlist.Add("7")
            Case "ko-KR"
                OSlist.Add("8")
            Case "de-DE", "de-CH"
                OSlist.Add("9")
            Case "es-ES"
                OSlist.Add("10")
            Case "fr-FR"
                OSlist.Add("12")
            Case "it-IT"
                OSlist.Add("13")
            Case "pl-PL"
                OSlist.Add("14")
            Case "pt-BR"
                OSlist.Add("15")
            Case "ru-RU"
                OSlist.Add("16")
            Case Else
                OSlist.Add("17")
        End Select

        'check windows version and 64 bit
        Dim WinVer As String = My.Computer.Info.OSFullName.ToString
        Dim OS64 As Boolean = Environment.Is64BitOperatingSystem

        'set the nvidia link IDs for the os version OSVer and nvOS 
        Dim OSCode As Integer

        Select Case True
            Case WinVer.Contains("11")
                OSCode = If(OS64, 57, 56)
            Case WinVer.Contains("10")
                OSCode = If(OS64, 57, 56)
            Case WinVer.Contains("8.1")
                OSCode = If(OS64, 41, 40)
            Case WinVer.Contains("8")
                OSCode = If(OS64, 28, 27)
            Case WinVer.Contains("7")
                OSCode = If(OS64, 19, 18)
            Case Else
                MsgBox("Your Windows System is not supported!")
                LogHelper.ErrorLog($"Your Windows System ({WinVer}) is not supported!")
                End
        End Select

        OSlist.AddRange({"11", OSCode.ToString()})


        'Set Product Series and Family
        Dim IDs As ArrayList = nApiGetIds(GraphicsInfo(3).ToString)
        nvPSID = CType(IDs(0), String)
        nvPFID = CType(IDs(1), String)
        Return OSlist
    End Function

    Public Function ProcessDriverLink() As String
        Try

            Dim DriverURL As String
            Dim studio As Boolean = CBool(Settings.Config.update.studio)
            Dim dch As Boolean = CBool(Settings.Config.update.dchdriver)

            Dim dtcid As Integer = If(dch, 1, If(studio, 18, 0))
            Dim urlFormat As String = "https://www.nvidia.com/Download/processDriver.aspx?psid={0}&pfid={1}&rpf=1&osid={2}&lid={3}&dtcid={4}"
            Dim url As String = String.Format(urlFormat, nvPSID, nvPFID, nvOS, nvLang, dtcid)

            Log("ProcessDriverLink: " + URL)

            Dim client As WebClient = New WebClient()
            Dim stream As Stream = client.OpenRead(URL)
            Dim reader As StreamReader = New StreamReader(stream)

            DriverURL = reader.ReadToEnd()
            reader.Close()
            stream.Close()

            If DriverURL.Contains("No certified downloads were found for this configuration") Then
                MessageBox.Show("There was no driver found for your configuration! Maybe your device configuration is not supported by NVIDIA anymore, or you are trying to use studio drivers. Settings will be resetted to DCH!", "NV-Updater", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LogHelper.Log($"ProcessDriverLink: No certified downloads were found for this configuration")
                If Settings.Config.update.studio = True Then
                    Settings.Config.update.studio = False
                    Settings.Config.update.dchdriver = True
                    Settings.Save(Settings.Config)
                End If
                End
            End If

            'go to https
            If DriverURL.Contains("http://") Then
                DriverURL = DriverURL.Replace("http://", "https://")
            End If

            'Link check integrated on 0.6.6.3 cause somehow there comes a bad link back
            If DriverURL.StartsWith("//") Then
                DriverURL = DriverURL.Replace("//", "https://")
            End If

            'Link check integrated on 0.7.6.2 cause somehow there comes a bad link back (reported by chickendipper)
            If DriverURL.StartsWith("driverResults.aspx") Then
                DriverURL = DriverURL.Replace("driverResults.aspx", "https://www.nvidia.com/download/driverResults.aspx")
            End If

            'Url valid check
            Dim urlPattern As String = "http(s)?://([\w+?\.\w+])+([a-zA-Z0-9\~\!\@\#\$\%\^\&\*\(\)_\-\=\+\\\/\?\.\:\;\'\,]*)?"
            If Regex.IsMatch(DriverURL, urlPattern) Then
                LogHelper.Log($"ProcessDriverLink: Valid NVIDIA URL detected")
            Else
                LogHelper.Log($"ProcessDriverLink: no valid NVIDIA URL detected, see error log")
                MessageBox.Show($"There was an error at ProcessDriverLink! The URL ({DriverURL}) from NVIDIA seems to be broken! Error was saved to Error-Logfile.", "NV-Updater", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LogHelper.ErrorLog($"There was an Error at ProcessDriverLink The URL ({DriverURL}) from NVIDIA seems to be broken!")
                End
            End If

            Return DriverURL
        Catch ex As Exception
            MessageBox.Show($"There was an error at ProcessDriverLink! Error was saved to Logfile. {vbCrLf}{ex.Message}{vbCrLf}{ex.StackTrace}", "NV-Updater", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LogHelper.ErrorLog("There was an Error at ProcessDriverLink" & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Function

    Public Function CheckForInternetConnection() As Boolean
        Try
            Using webClient = New WebClient()
                Using stream = webClient.OpenRead("http://www.google.com")
                    Return True
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function nApiGetIds(ByVal graphicscard As String) As ArrayList

        If CheckForInternetConnection() = True Then

            'set variables
            Dim psid As String = Nothing
            Dim pfid As String = Nothing
            Dim result As New ArrayList

            'format graphiccard name and delete the
            graphicscard = graphicscard.ToLower
            graphicscard = Regex.Replace(graphicscard, "nvidia ", "")
            graphicscard = Regex.Replace(graphicscard, " \\d+gb", "")

            Log($"Searched graphiccard name in the api: {graphicscard}")

            'load the remote xml file from nvidia
            Dim httpClient = New Http.HttpClient()
            Dim url = "https://www.nvidia.com/Download/API/lookupValueSearch.aspx?TypeID=3"
            Dim XML As XDocument

            Try
                Dim xresult = httpClient.GetAsync(url).Result
                Dim stream = xresult.Content.ReadAsStreamAsync().Result
                XML = XDocument.Load(stream)
            Catch ex As Exception
                MessageBox.Show($"There was an error at nApiGetIds! Error was saved to Logfile: {vbCrLf} {ex.Message} {vbCrLf} {ex.StackTrace}", "NV-Updater", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LogHelper.ErrorLog($"There was an error at nApiGetIds: {vbCrLf} {ex.Message} {vbCrLf} {ex.StackTrace}")
                End
            End Try

            'set xml node
            Dim cards = XML.Descendants("Name")

            'search in xml for card name and get psid and pfid
            Dim Notebook As Boolean = IsLaptop()
            For Each card In cards
                Dim cardname As String = card.Value.ToString().ToLower()
                If Notebook = False Then
                    If cardname.Contains(graphicscard) And Not cardname.Contains("laptop") Then
                        psid = card.Parent.FirstAttribute.Value
                        Dim LookupValue As String = card.Parent.Value.ToLower()
                        Dim index As Integer = LookupValue.IndexOf(cardname)
                        pfid = If((index < 0), LookupValue, LookupValue.Remove(index, cardname.Length))
                    End If
                Else
                    If cardname.Contains(graphicscard) And cardname.Contains("laptop") Then
                        psid = card.Parent.FirstAttribute.Value
                        Dim LookupValue As String = card.Parent.Value.ToLower()
                        Dim index As Integer = LookupValue.IndexOf(cardname)
                        pfid = If((index < 0), LookupValue, LookupValue.Remove(index, cardname.Length))
                    End If
                End If
            Next

            'fallback notebook not found, try again with desktop
            If pfid = "" Then
                For Each card In cards
                    Dim cardname As String = card.Value.ToString().ToLower()
                    If cardname.Contains(graphicscard) And Not cardname.Contains("laptop") Then
                        psid = card.Parent.FirstAttribute.Value
                        Dim LookupValue As String = card.Parent.Value.ToLower()
                        Dim index As Integer = LookupValue.IndexOf(cardname)
                        pfid = If((index < 0), LookupValue, LookupValue.Remove(index, cardname.Length))
                    End If
                Next
            End If

            'set default if no card is found
            If psid = "" Then
                psid = "127"
            End If

            If pfid = "" Then
                pfid = "995"
            End If

            'set default if no card is found
            If psid = "" Then
                psid = "120"
                Log($"Detected PsID: Not found in web api, fallback to {psid}")
            End If

            If pfid = "" Then
                pfid = "934"
                Log($"Detected PfID: Not found in web api, fallback to {pfid}")
            End If

            'set array
            result.Add(psid)
            result.Add(pfid)

            'write to logfile
            Log($"Detected PsID: {result(0)}")
            Log($"Detected PfID: {result(1)}")

            Return result
        Else
            Log("No Internet-Connection found, nApiGetIds set to default IDs...")
            Dim result As New ArrayList
            result.Add("120")
            result.Add("934")
            Return result
        End If
    End Function

    Public Function getHotfix() As ArrayList
        'set urls and variables
        Dim BaseUrl As String = "https://nvidia.custhelp.com"
        Dim Link As String = "https://nvidia.custhelp.com/app/answers/list/st/5/kw/hotfix/sort/2%2C2/page/1/search/1"
        Dim Result As New ArrayList

        Try
            'ask CustomerHelp for hotfixes and select the first (newest) to create the URL
            Dim doc As HtmlDocument = New HtmlWeb().Load(Link)
            Dim CustHelpLink As IEnumerable(Of String) = If(doc.DocumentNode.SelectNodes("(//a[contains(@href,'kw/hotfix')])[1]") IsNot Nothing, doc.DocumentNode.SelectNodes("(//a[contains(@href,'kw/hotfix')])[1]").Select(Function(x) x.GetAttributeValue("href", "")), Enumerable.Empty(Of String)())
            Dim HotFixUrlPart = String.Join(Environment.NewLine, CustHelpLink).Trim
            Dim HotfixUrl = $"{BaseUrl}{HotFixUrlPart}".Trim

            ' Ensure HotfixUrl is valid before proceeding
            If String.IsNullOrWhiteSpace(HotFixUrlPart) Then
                LogHelper.ErrorLog($"There was an error at getHotfix: HotFixUrlPart is empty or invalid.")
                Result.Add(False)
                LogHelper.Log($"Hotfix found: False (E1)")
                Return Result
            End If

            'search for the version number
            Dim HotfixDoc As HtmlDocument = New HtmlWeb().Load(HotfixUrl)
            Dim NavTitle As IEnumerable(Of String) = If(HotfixDoc.DocumentNode.Descendants("span").Any(Function(d) d.Attributes.Contains("class") AndAlso d.Attributes("class").Value.Contains("breadcrumbs-knbase")), HotfixDoc.DocumentNode.Descendants("span").Where(Function(d) d.Attributes.Contains("class") AndAlso d.Attributes("class").Value.Contains("breadcrumbs-knbase")).Select(Function(x) x.InnerHtml), Enumerable.Empty(Of String)())
            Dim HotfixVersion = String.Join(Environment.NewLine, NavTitle).Trim
            HotfixVersion = Regex.Replace(HotfixVersion, "[^\r\n0-9.]", "")

            'get release text
            Dim ReleaseNotes As String = Nothing
            For Each li As HtmlNode In If(HotfixDoc.DocumentNode.SelectNodes("//li") IsNot Nothing, HotfixDoc.DocumentNode.SelectNodes("//li"), Enumerable.Empty(Of HtmlNode)())
                If Not li.InnerText.Contains("Hotfix Driver Version") Then
                    ReleaseNotes = $"{ReleaseNotes} - {li.InnerText.Trim}<br>{vbCrLf}"
                End If
            Next

            'get download link
            Dim DLink As IEnumerable(Of String) = Enumerable.Empty(Of String)()
            Dim DownLoadLink As String = String.Empty
            Dim nodes = HotfixDoc.DocumentNode.SelectNodes("(//a[contains(@href,'download.nvidia.com/Windows')])[1]")
            If nodes IsNot Nothing Then
                DLink = nodes.Select(Function(x) x.GetAttributeValue("href", ""))
                DownLoadLink = String.Join(Environment.NewLine, DLink).Trim
            Else
                Result.Add(False)
                LogHelper.Log($"Hotfix found: False (E2)")
                Return Result
            End If

            Console.WriteLine("-----------------------------------------------")
            Console.WriteLine($"Hotfix URL: {HotfixUrl}")
            Console.WriteLine($"Hotfix Version: {HotfixVersion}")
            Console.WriteLine($"Download URL: {DownLoadLink}")
            Console.WriteLine("-----------------------------------------------")

            'add infos to result
            Result.Add(True)            '0
            Result.Add(HotfixVersion)   '1
            Result.Add(HotfixUrl)       '2
            Result.Add(ReleaseNotes)    '3
            Result.Add(DownLoadLink)    '4

        Catch ex As Exception
            LogHelper.ErrorLog($"There was an error at getHotfix: {vbCrLf} {ex.Message} {vbCrLf} {ex.StackTrace}")
            LogHelper.Log($"Hotfix found: False (Exception in ErrorLog)")
            Result.Add(False)    '0
        End Try

        Return Result
    End Function

    Public Function IsLaptop() As Boolean
        Dim query = New SelectQuery("Win32_Battery")
        Dim searcher = New ManagementObjectSearcher(query)

        For Each managementObject In searcher.Get()
            If managementObject("BatteryStatus") IsNot Nothing Then
                LogHelper.Log($"Laptop Check: True")
                Return True
            End If
        Next
        LogHelper.Log($"Laptop Check: False")
        Return False
    End Function

End Module