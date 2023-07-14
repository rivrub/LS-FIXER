Imports System.Management
Imports Microsoft.Win32

Public Class Secureboot

    Public Shared Function CheckSecureBoot() As Boolean
        Dim secureBootStatus As Integer = 0

        Using regKey As RegistryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Control\SecureBoot\State")
            If regKey IsNot Nothing Then
                secureBootStatus = CInt(regKey.GetValue("UEFISecureBootEnabled", 0))
            End If
        End Using

        Return secureBootStatus = 1
    End Function

End Class