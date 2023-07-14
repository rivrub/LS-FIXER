<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        VisualBasic = New Button()
        ProgressBar1 = New ProgressBar()
        clearfiles = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        vanguardlabel = New Label()
        driverlabel = New Label()
        mbname = New Label()
        adivse = New TextBox()
        TextBox1 = New TextBox()
        SDK_BUTTON = New Button()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' VisualBasic
        ' 
        VisualBasic.Location = New Point(12, 62)
        VisualBasic.Name = "VisualBasic"
        VisualBasic.Size = New Size(169, 23)
        VisualBasic.TabIndex = 0
        VisualBasic.Text = "Visual C++ Installation"
        VisualBasic.UseVisualStyleBackColor = True
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(12, 415)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(146, 23)
        ProgressBar1.TabIndex = 1
        ' 
        ' clearfiles
        ' 
        clearfiles.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        clearfiles.ForeColor = Color.Red
        clearfiles.Location = New Point(232, 415)
        clearfiles.Name = "clearfiles"
        clearfiles.Size = New Size(130, 30)
        clearfiles.TabIndex = 2
        clearfiles.Text = "Clear Temp Files"
        clearfiles.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 397)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 15)
        Label1.TabIndex = 3
        Label1.Text = "Download Progress"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(265, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 4
        Label2.Text = "Label2"
        ' 
        ' Button1
        ' 
        Button1.Enabled = False
        Button1.Location = New Point(12, 91)
        Button1.Name = "Button1"
        Button1.Size = New Size(169, 23)
        Button1.TabIndex = 5
        Button1.Text = "Windows Defender Disable"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' vanguardlabel
        ' 
        vanguardlabel.AutoSize = True
        vanguardlabel.Location = New Point(265, 95)
        vanguardlabel.Name = "vanguardlabel"
        vanguardlabel.Size = New Size(41, 15)
        vanguardlabel.TabIndex = 6
        vanguardlabel.Text = "Label3"
        ' 
        ' driverlabel
        ' 
        driverlabel.AutoSize = True
        driverlabel.Location = New Point(265, 124)
        driverlabel.Name = "driverlabel"
        driverlabel.Size = New Size(41, 15)
        driverlabel.TabIndex = 7
        driverlabel.Text = "Label3"
        ' 
        ' mbname
        ' 
        mbname.AutoSize = True
        mbname.Location = New Point(12, 373)
        mbname.Name = "mbname"
        mbname.Size = New Size(55, 15)
        mbname.TabIndex = 8
        mbname.Text = "mbname"
        ' 
        ' adivse
        ' 
        adivse.BackColor = Color.White
        adivse.BorderStyle = BorderStyle.None
        adivse.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        adivse.ForeColor = Color.Red
        adivse.Location = New Point(12, 303)
        adivse.Multiline = True
        adivse.Name = "adivse"
        adivse.ReadOnly = True
        adivse.Size = New Size(402, 67)
        adivse.TabIndex = 9
        adivse.Text = resources.GetString("adivse.Text")
        adivse.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Cursor = Cursors.No
        TextBox1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        TextBox1.Location = New Point(12, 12)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.RightToLeft = RightToLeft.No
        TextBox1.Size = New Size(402, 44)
        TextBox1.TabIndex = 10
        TextBox1.Text = "LEAGUESENSE IS NOT SUPPORTED ON JAPAN SERVERS." & vbCrLf & "YOU WILL GET BANNED"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' SDK_BUTTON
        ' 
        SDK_BUTTON.Location = New Point(12, 120)
        SDK_BUTTON.Name = "SDK_BUTTON"
        SDK_BUTTON.Size = New Size(169, 23)
        SDK_BUTTON.TabIndex = 11
        SDK_BUTTON.Text = "Install SDK"
        SDK_BUTTON.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(177, 397)
        Label3.Name = "Label3"
        Label3.Size = New Size(242, 15)
        Label3.TabIndex = 12
        Label3.Text = "PLEASE CLEAR FILES BEFORE CLOSING APP"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 149)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(402, 148)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AccessibleName = "League Sense Fixer"
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(426, 450)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(SDK_BUTTON)
        Controls.Add(TextBox1)
        Controls.Add(adivse)
        Controls.Add(mbname)
        Controls.Add(driverlabel)
        Controls.Add(vanguardlabel)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(clearfiles)
        Controls.Add(ProgressBar1)
        Controls.Add(VisualBasic)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Opacity = 0.9R
        Text = "LS FIXER 2.0"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents VisualBasic As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents clearfiles As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents vanguardlabel As Label
    Friend WithEvents driverlabel As Label
    Friend WithEvents mbname As Label
    Friend WithEvents adivse As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents SDK_BUTTON As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
