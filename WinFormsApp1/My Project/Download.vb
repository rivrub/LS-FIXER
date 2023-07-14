Imports System.Net
Imports System.IO.Compression

Public Class Download


    Public Shared Sub DownloadFile()

        Dim url As String = "https://nl2-dl.techpowerup.com/files/k9y-BVski5POY7a7M5a1Ow/1689088752/Visual-C-Runtimes-All-in-One-May-2023.zip" ' DOWNLOAD URL
        Dim savePath As String = "C:/Temp/VISUALCRUNTIMES.zip" ' PATH
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

    Private Shared Sub DownloadCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs)
        ' Handle completion of the download
        If e.Error IsNot Nothing Then
            ' Handle any error that occurred during the download
            MessageBox.Show($"Error: {e.Error.Message}")
        Else
            ' Download completed successfully

            Try
                Dim zipfilepath As String = "C:/Temp/VISUALCRUNTIMES.zip"
                Dim extractpath As String = "C:/Temp"
                Extract.Zipex(zipfilepath, extractpath)
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}")
            End Try
        End If

        ' Reset the progress bar value
        Form1.ProgressBar1.Value = 0

    End Sub

End Class