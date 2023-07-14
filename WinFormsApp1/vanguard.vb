Public Class VanguardChecker
    Public Shared Function IsVanguardRunning() As Boolean
        Dim processes() As Process = Process.GetProcessesByName("vgtray")
        Return processes.Length > 0
    End Function
End Class