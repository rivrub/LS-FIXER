Imports System.Net
Imports System.IO.Compression
Imports System.IO

Public Class Extract

    Public Shared Sub Zipex(zipFilePath As String, extractPath As String)
        Try
            Dim pathc As String = "C:/Temp/install_all.bat"
            ZipFile.ExtractToDirectory(zipFilePath, extractPath)
            Dim processInfo As New ProcessStartInfo(pathc)

            MessageBox.Show("Download completed! Instalation will begin!")
            MessageBox.Show("If any error messages are given means you already have some of it installed, just press 'OK'")
            Dim processstart As Process = Process.Start(processInfo)
            processstart.WaitForExit()
            MessageBox.Show("Installation completed.")





        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")


        End Try
    End Sub

End Class
