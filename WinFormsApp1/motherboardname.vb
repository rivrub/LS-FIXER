Imports System.Management
Imports System.Net

Class mothername

    Public Shared Function GetMotherboardName() As String

        Dim searcher As New ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard")
        Dim queryResult As ManagementObjectCollection = searcher.Get()
        Dim form1 As New Form1

        For Each obj As ManagementObject In queryResult
            Return obj("Product").ToString()
        Next

        Return Nothing

    End Function

    Public Shared Sub OpenWebBrowser(searchmo As String)
        Try
            Process.Start(searchmo)
        Catch ex As Exception
            MessageBox.Show("Unable to open the web browser.")
        End Try

    End Sub

    Public Shared Function GetMicrosoftEdgePath() As String

        Dim edgeKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\msedge.exe")
        If edgeKey IsNot Nothing Then
            Dim edgePath As String = edgeKey.GetValue("")
            If Not String.IsNullOrEmpty(edgePath) Then
                Return edgePath
            End If
        End If
        Return Nothing
    End Function


End Class
