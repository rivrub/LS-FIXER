Imports System.Net
Imports System.IO.Compression

Public Class DownloadSDK


    Public Shared Sub DownloadFile()

        Dim url As String = "https://download.microsoft.com/download/A/E/7/AE743F1F-632B-4809-87A9-AA1BB3458E31/DXSDK_Jun10.exe" ' DOWNLOAD URL
        Dim savePath As String = "C:/Temp/SDK.exe" ' PATH
        Dim webClient As New WebClient()

        ' Subscribe to the DownloadProgressChanged event
        AddHandler webClient.DownloadProgressChanged, AddressOf DownloadProgressChanged

        ' Subscribe to the DownloadFileCompleted event
        AddHandler webClient.DownloadFileCompleted, AddressOf DownloadCompleted

        ' Start the download asynchronously
        webClient.DownloadFileAsync(New Uri(url), savePath)
    End Sub

    Private Shared Sub DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs)
        ' Update the progress bar with the current progress percentage
        Form1.ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Public Shared Sub DownloadCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs)
        Dim execpath As String = "C:/Temp/SDK.exe"
        ' Handle completion of the download
        If e.Error IsNot Nothing Then
            ' Handle any error that occurred during the download
            MessageBox.Show($"Error: {e.Error.Message}")
        Else
            ' Download completed successfully
            MessageBox.Show("Download completed! Setup will now start, continue instalation manually.")
            Try

                Dim processInfo As New ProcessStartInfo(execpath)
                Dim processinf As Process = Process.Start(processInfo)
                processinf.WaitForExit()
                MessageBox.Show("SDK installation completed.")
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}")
            End Try
        End If

        ' Reset the progress bar value
        Form1.ProgressBar1.Value = 0

    End Sub

End Class