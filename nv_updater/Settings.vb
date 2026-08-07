Option Strict On
Imports System.Environment
Imports Newtonsoft.Json

Public Class Settings
    Public Class ApplicationSettings
        Public run As Boolean
        Public runPath As String
        Public runOptions As String
        Public Property autorun As Boolean
        Public Property logmode As Boolean
        Public Property autoupdate As Boolean
        Public Property updatetimer As Integer
    End Class

    Public Class InfoSettings
        Public Property installed As String
    End Class

    Public Class UpdateSettings
        Public Property DisplayNView As Boolean
        Public Property NvCamera As Boolean
        Public Property NvContainer As Boolean
        Public Property ShieldWirelessController As Boolean
        Public Property MSVCRT As Boolean
        Public Property PPC As Boolean
        Public Property hotfix As Boolean
        Public Property rgbtoggle As String
        Public Property NvBackend As Boolean
        Public Property studio As Boolean
        Public Property HDAudio As Boolean
        Public Property PhysX As Boolean
        Public Property rgbfix As Boolean
        Public Property dchdriver As Boolean
        Public Property GFExperience As Boolean
        Public Property clean As Boolean
        Public Property telemetry As Boolean
        Public Property DisplayUpdate As Boolean
        Public Property ignore As Boolean
        Public Property NvvHCI As Boolean
        Public Property nodejs As Boolean
        Public Property NvVAD As Boolean
        Public Property DisplayOptimus As Boolean
        Public Property UpdateCore As Boolean
        Public Property NvAbHub As Boolean
        Public Property silent As Boolean
        Public Property NGXCore As Boolean
        Public Property NVWMI As Boolean
        Public Property ShadowPlay As Boolean
        Public Property Version As String
        Public Property FrameViewSDK As Boolean
        Public Property NVModuleTracker As Boolean
        Public Property NVPCF As Boolean
    End Class

    Public Property application As ApplicationSettings
    Public Property info As InfoSettings
    Public Property update As UpdateSettings


    'set ini file and path
    Public Shared AppConfigFolder As String = GetFolderPath(SpecialFolder.ApplicationData) + "\nv_updater\"
    Public Shared AppConfigJson As String = AppConfigFolder + "nvu_config.json"
    Public Shared Config As Settings

    Public Shared Function Read() As Settings
        If System.IO.File.Exists(AppConfigJson) Then
            Dim json As String = System.IO.File.ReadAllText(AppConfigJson)
            Return JsonConvert.DeserializeObject(Of Settings)(json)
        Else
            Return New Settings() With {
                .application = New Settings.ApplicationSettings(),
                .info = New Settings.InfoSettings(),
                .update = New Settings.UpdateSettings()
            }
        End If
    End Function

    Public Shared Sub Save(settings As Settings)
        Dim json As String = JsonConvert.SerializeObject(settings, Formatting.Indented)
        System.IO.File.WriteAllText(AppConfigJson, json)
    End Sub

    Public Shared Sub ConvertIniJson()
        Dim settings As New Settings() With {
            .application = New Settings.ApplicationSettings(),
            .info = New Settings.InfoSettings(),
            .update = New Settings.UpdateSettings()
        }

        settings.application.autorun = Boolean.Parse(iniRead("application", "autorun", "", AppConfig))
        settings.application.logmode = Boolean.Parse(iniRead("application", "logmode", "", AppConfig))
        settings.application.autoupdate = Boolean.Parse(iniRead("application", "autoupdate", "", AppConfig))
        settings.application.updatetimer = Integer.Parse(iniRead("application", "updatetimer", "", AppConfig))

        settings.info.installed = iniRead("info", "installed", "", AppConfig)

        settings.update.DisplayNView = Boolean.Parse(iniRead("update", "Display.NView", "", AppConfig))
        settings.update.NvCamera = Boolean.Parse(iniRead("update", "NvCamera", "", AppConfig))
        settings.update.NvContainer = Boolean.Parse(iniRead("update", "NvContainer", "", AppConfig))
        settings.update.ShieldWirelessController = Boolean.Parse(iniRead("update", "ShieldWirelessController", "", AppConfig))
        settings.update.MSVCRT = Boolean.Parse(iniRead("update", "MSVCRT", "", AppConfig))
        settings.update.PPC = Boolean.Parse(iniRead("update", "PPC", "", AppConfig))
        settings.update.hotfix = Boolean.Parse(iniRead("update", "hotfix", "", AppConfig))
        settings.update.rgbtoggle = iniRead("update", "rgbtoggle", "", AppConfig)
        settings.update.NvBackend = Boolean.Parse(iniRead("update", "NvBackend", "", AppConfig))
        settings.update.studio = Boolean.Parse(iniRead("update", "studio", "", AppConfig))
        settings.update.HDAudio = Boolean.Parse(iniRead("update", "HDAudio", "", AppConfig))
        settings.update.PhysX = Boolean.Parse(iniRead("update", "PhysX", "", AppConfig))
        settings.update.rgbfix = Boolean.Parse(iniRead("update", "rgbfix", "", AppConfig))
        settings.update.dchdriver = Boolean.Parse(iniRead("update", "dchdriver", "", AppConfig))
        settings.update.GFExperience = Boolean.Parse(iniRead("update", "GFExperience", "", AppConfig))
        settings.update.clean = Boolean.Parse(iniRead("update", "clean", "", AppConfig))
        settings.update.telemetry = Boolean.Parse(iniRead("update", "telemetry", "", AppConfig))
        settings.update.DisplayUpdate = Boolean.Parse(iniRead("update", "Display.Update", "", AppConfig))
        settings.update.ignore = Boolean.Parse(iniRead("update", "ignore", "", AppConfig))
        settings.update.NvvHCI = Boolean.Parse(iniRead("update", "NvvHCI", "", AppConfig))
        settings.update.nodejs = Boolean.Parse(iniRead("update", "nodejs", "", AppConfig))
        settings.update.NvVAD = Boolean.Parse(iniRead("update", "NvVAD", "", AppConfig))
        settings.update.DisplayOptimus = Boolean.Parse(iniRead("update", "DisplayOptimus", "", AppConfig))
        settings.update.UpdateCore = Boolean.Parse(iniRead("update", "Update.Core", "", AppConfig))
        settings.update.NvAbHub = Boolean.Parse(iniRead("update", "NvAbHub", "", AppConfig))
        settings.update.silent = Boolean.Parse(iniRead("update", "silent", "", AppConfig))
        settings.update.NGXCore = Boolean.Parse(iniRead("update", "NGXCore", "", AppConfig))
        settings.update.NVWMI = Boolean.Parse(iniRead("update", "NVWMI", "", AppConfig))
        settings.update.ShadowPlay = Boolean.Parse(iniRead("update", "ShadowPlay", "", AppConfig))
        settings.update.Version = iniRead("update", "Version", "", AppConfig)
        settings.update.FrameViewSDK = Boolean.Parse(iniRead("update", "FrameViewSDK", "", AppConfig))
        settings.update.NVModuleTracker = Boolean.Parse(iniRead("update", "NVModuleTracker", "", AppConfig))

        settings.Save(settings)

    End Sub

End Class

