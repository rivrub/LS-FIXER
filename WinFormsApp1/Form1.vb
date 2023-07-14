Imports System.Diagnostics.Eventing.Reader
Imports System.IO
Imports System.Management
Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Diagnostics
Imports System.Security.Policy

Public Class Form1
    Dim direxists As String = "C:/Temp/"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.DirectoryExists(direxists) = True Then

            Try
                Directory.Delete(direxists, True)
                Directory.CreateDirectory(direxists)

            Catch ex As Exception
                MessageBox.Show($"error{ex.Message}")
            End Try

        Else


        End If

        Securebootsetlabel()
        CheckVanguardAndSetLabel()
        checkdriversvb()
        mbmodename()

    End Sub

    Private Sub VisualBasic_Click(sender As Object, e As EventArgs) Handles VisualBasic.Click
        If My.Computer.FileSystem.DirectoryExists(direxists) = False Then

            Try
                Directory.CreateDirectory(direxists)

            Catch ex As Exception
                MessageBox.Show($"error{ex.Message}")
            End Try

        Else


        End If

        Download.DownloadFile()
    End Sub

    Private Sub clearfiles_Click(sender As Object, e As EventArgs) Handles clearfiles.Click
        Try
            Directory.Delete(direxists, True)

        Catch ex As Exception

            MessageBox.Show("Error, path doesn't exist")

        End Try

    End Sub

    Public Shared Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WinDef.disWindef()

    End Sub

    Private Sub CheckVanguardAndSetLabel()
        Dim isRunning As Boolean = VanguardChecker.IsVanguardRunning()

        If isRunning Then
            vanguardlabel.ForeColor = Color.Red
            vanguardlabel.Text = "Vanguard is running."
        Else
            vanguardlabel.ForeColor = Color.Green
            vanguardlabel.Text = "Vanguard is not running."
        End If
    End Sub

    Private Sub Securebootsetlabel()
        Dim secureBootStatus As Boolean = Secureboot.CheckSecureBoot()

        If secureBootStatus Then
            Label2.ForeColor = Color.Red

            Label2.Text = "Secure Boot is enabled."

        Else
            Label2.ForeColor = Color.Green
            Label2.Text = "Secure Boot is disabled."
        End If

        Try
            Directory.Delete(direxists, False)
        Catch ex As Exception
            Directory.CreateDirectory(direxists)
        End Try
    End Sub

    Private Sub checkdriversvb()
        Dim allDriversInstalled As Boolean = chekdriv.CheckAllDriversInstalled

        If allDriversInstalled Then
            driverlabel.ForeColor = Color.Green

            driverlabel.Text = ("All drivers are installed.")
        Else
            driverlabel.ForeColor = Color.Red
            driverlabel.Text = ("Some drivers are missing.")
        End If
    End Sub


    Public Sub mbmodename()

        Dim moname As String = mothername.GetMotherboardName

        If Not String.IsNullOrEmpty(moname) Then
            mbname.ForeColor = Color.DarkBlue
            mbname.Text = ("Motherboard Name: " & moname)
        Else
            mbname.Text = ("Unable to retrieve motherboard name.")
        End If

    End Sub

    Public Sub mbname_Click(sender As Object, e As EventArgs) Handles mbname.Click
        Dim searchQuery As String = mbname.Text & " Drivers"
        Dim searchUrl As String = "https://www.google.com/search?q=" + Uri.EscapeDataString(searchQuery)

        Try
            Dim edgePath As String = mothername.GetMicrosoftEdgePath
            If Not String.IsNullOrEmpty(edgePath) Then
                Process.Start(edgePath, searchUrl)
            Else
                MessageBox.Show("Unable to locate Microsoft Edge executable.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error occurred while starting Microsoft Edge.")
        End Try
    End Sub

    Private Sub SDK_BUTTON_Click(sender As Object, e As EventArgs) Handles SDK_BUTTON.Click

        If My.Computer.FileSystem.DirectoryExists(direxists) = False Then

            Try
                Directory.CreateDirectory(direxists)

            Catch ex As Exception
                MessageBox.Show($"error{ex.Message}")
            End Try

        Else



        End If

        DownloadSDK.DownloadFile()

    End Sub
End Class


