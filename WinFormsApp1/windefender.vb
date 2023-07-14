Imports System.Diagnostics
Imports System.Security.Cryptography.X509Certificates
Imports Microsoft.Win32
Imports System.Threading
Imports System.Management.Automation

Public Class WinDef

    Public Shared Sub disWindef()

        Try

            Dim powerShellProcess As New Process()
            Dim pauseEvent As New ManualResetEvent(False)

            powerShellProcess.StartInfo.FileName = "powershell.exe"
            powerShellProcess.StartInfo.Arguments = """Set-MpPreference -DisableRealtimeMonitoring $true Stop-Service -Name WdNisDrv Set-Service -Name WinDefend -StartupType Disabled; Set-Service -Name WdNisSvc -StartupType Disabled; Set-Service -Name WdNisDrv -StartupType Disabled"""
            powerShellProcess.StartInfo.UseShellExecute = False
            powerShellProcess.StartInfo.CreateNoWindow = True
            powerShellProcess.Start()

            powerShellProcess.WaitForExit()
            MessageBox.Show("Windows Defender services disabled.")
        Catch ex As Exception
            MessageBox.Show("Error occurred while disabling Windows Defender services.")

        End Try



    End Sub

End Class
