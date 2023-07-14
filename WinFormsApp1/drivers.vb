Imports System.Management
Public Class chekdriv

    Public Shared Function CheckAllDriversInstalled() As Boolean
        Dim searcher As New ManagementObjectSearcher("SELECT * FROM Win32_PnPSignedDriver WHERE DeviceClass='DISPLAY' OR DeviceClass='MEDIA'")
        Dim queryResult As ManagementObjectCollection = searcher.Get()

        Dim missingDrivers As Integer = 0

        For Each obj As ManagementObject In queryResult
            Dim driverDescription As String = obj("Description").ToString()

            If driverDescription = "" Then
                missingDrivers += 1
                Console.WriteLine("Missing Driver: " & obj("DeviceID"))
            End If
        Next

        Return missingDrivers = 0
    End Function

End Class

