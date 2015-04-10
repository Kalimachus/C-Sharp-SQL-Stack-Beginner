<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMidiController
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMidiController))
        Me.btnBPMSet = New System.Windows.Forms.Button()
        Me.btnBPMStop = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.picTopLabel = New System.Windows.Forms.PictureBox()
        Me.btnD4 = New System.Windows.Forms.Button()
        Me.btnD3 = New System.Windows.Forms.Button()
        Me.btnD2 = New System.Windows.Forms.Button()
        Me.btnD1 = New System.Windows.Forms.Button()
        Me.btnC4 = New System.Windows.Forms.Button()
        Me.btnC3 = New System.Windows.Forms.Button()
        Me.btnC2 = New System.Windows.Forms.Button()
        Me.btnC1 = New System.Windows.Forms.Button()
        Me.btnB4 = New System.Windows.Forms.Button()
        Me.btnB3 = New System.Windows.Forms.Button()
        Me.btnB2 = New System.Windows.Forms.Button()
        Me.btnB1 = New System.Windows.Forms.Button()
        Me.btnA4 = New System.Windows.Forms.Button()
        Me.btnA3 = New System.Windows.Forms.Button()
        Me.btnA2 = New System.Windows.Forms.Button()
        Me.btnA1 = New System.Windows.Forms.Button()
        Me.picBeat = New System.Windows.Forms.PictureBox()
        Me.AxWindowsMediaPlayer2 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayer3 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayer4 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayer5 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayer6 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayer7 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayer8 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.lblHeadsUp = New System.Windows.Forms.Label()
        Me.lblTimeDisplay = New System.Windows.Forms.Label()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblShift = New System.Windows.Forms.Label()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTopLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBeat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBPMSet
        '
        Me.btnBPMSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBPMSet.ForeColor = System.Drawing.Color.White
        Me.btnBPMSet.Location = New System.Drawing.Point(394, 227)
        Me.btnBPMSet.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBPMSet.Name = "btnBPMSet"
        Me.btnBPMSet.Size = New System.Drawing.Size(68, 28)
        Me.btnBPMSet.TabIndex = 26
        Me.btnBPMSet.Text = "Star&t"
        Me.btnBPMSet.UseVisualStyleBackColor = True
        '
        'btnBPMStop
        '
        Me.btnBPMStop.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBPMStop.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBPMStop.FlatAppearance.BorderSize = 2
        Me.btnBPMStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBPMStop.ForeColor = System.Drawing.Color.White
        Me.btnBPMStop.Location = New System.Drawing.Point(394, 194)
        Me.btnBPMStop.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBPMStop.Name = "btnBPMStop"
        Me.btnBPMStop.Size = New System.Drawing.Size(68, 28)
        Me.btnBPMStop.TabIndex = 27
        Me.btnBPMStop.Text = "Sto&p"
        Me.btnBPMStop.UseVisualStyleBackColor = True
        Me.btnBPMStop.Visible = False
        '
        'Timer1
        '
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(5, 686)
        Me.AxWindowsMediaPlayer1.Margin = New System.Windows.Forms.Padding(2)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(251, 52)
        Me.AxWindowsMediaPlayer1.TabIndex = 30
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'picTopLabel
        '
        Me.picTopLabel.BackColor = System.Drawing.Color.Transparent
        Me.picTopLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picTopLabel.Image = Global.frmMidiControllerPlayer.My.Resources.Resources.Dlabel0
        Me.picTopLabel.Location = New System.Drawing.Point(5, 0)
        Me.picTopLabel.Margin = New System.Windows.Forms.Padding(2)
        Me.picTopLabel.Name = "picTopLabel"
        Me.picTopLabel.Size = New System.Drawing.Size(412, 122)
        Me.picTopLabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTopLabel.TabIndex = 32
        Me.picTopLabel.TabStop = False
        '
        'btnD4
        '
        Me.btnD4.BackColor = System.Drawing.Color.Transparent
        Me.btnD4.BackgroundImage = Global.frmMidiControllerPlayer.My.Resources.Resources.Over
        Me.btnD4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnD4.FlatAppearance.BorderSize = 0
        Me.btnD4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnD4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnD4.ForeColor = System.Drawing.Color.White
        Me.btnD4.Location = New System.Drawing.Point(292, 561)
        Me.btnD4.Margin = New System.Windows.Forms.Padding(2)
        Me.btnD4.Name = "btnD4"
        Me.btnD4.Size = New System.Drawing.Size(75, 81)
        Me.btnD4.TabIndex = 21
        Me.btnD4.Text = "V" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnD4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnD4.UseVisualStyleBackColor = False
        '
        'btnD3
        '
        Me.btnD3.BackColor = System.Drawing.Color.Transparent
        Me.btnD3.BackgroundImage = Global.frmMidiControllerPlayer.My.Resources.Resources.WorkIs
        Me.btnD3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnD3.FlatAppearance.BorderSize = 0
        Me.btnD3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnD3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnD3.ForeColor = System.Drawing.Color.White
        Me.btnD3.Location = New System.Drawing.Point(205, 561)
        Me.btnD3.Margin = New System.Windows.Forms.Padding(2)
        Me.btnD3.Name = "btnD3"
        Me.btnD3.Size = New System.Drawing.Size(75, 81)
        Me.btnD3.TabIndex = 20
        Me.btnD3.Text = "C" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnD3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnD3.UseVisualStyleBackColor = False
        '
        'btnD2
        '
        Me.btnD2.BackColor = System.Drawing.Color.Transparent
        Me.btnD2.BackgroundImage = Global.frmMidiControllerPlayer.My.Resources.Resources.After
        Me.btnD2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnD2.FlatAppearance.BorderSize = 0
        Me.btnD2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnD2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnD2.ForeColor = System.Drawing.Color.White
        Me.btnD2.Location = New System.Drawing.Point(114, 561)
        Me.btnD2.Margin = New System.Windows.Forms.Padding(2)
        Me.btnD2.Name = "btnD2"
        Me.btnD2.Size = New System.Drawing.Size(75, 81)
        Me.btnD2.TabIndex = 19
        Me.btnD2.Text = "X" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnD2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnD2.UseVisualStyleBackColor = False
        '
        'btnD1
        '
        Me.btnD1.BackColor = System.Drawing.Color.Transparent
        Me.btnD1.BackgroundImage = Global.frmMidiControllerPlayer.My.Resources.Resources.Ever
        Me.btnD1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnD1.FlatAppearance.BorderSize = 0
        Me.btnD1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnD1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnD1.ForeColor = System.Drawing.Color.White
        Me.btnD1.Location = New System.Drawing.Point(25, 561)
        Me.btnD1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnD1.Name = "btnD1"
        Me.btnD1.Size = New System.Drawing.Size(75, 81)
        Me.btnD1.TabIndex = 18
        Me.btnD1.Text = "Z" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnD1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnD1.UseVisualStyleBackColor = False
        '
        'btnC4
        '
        Me.btnC4.BackColor = System.Drawing.Color.Transparent
        Me.btnC4.BackgroundImage = Global.frmMidiControllerPlayer.My.Resources.Resources.Never
        Me.btnC4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnC4.FlatAppearance.BorderSize = 0
        Me.btnC4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnC4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC4.ForeColor = System.Drawing.Color.White
        Me.btnC4.Location = New System.Drawing.Point(292, 464)
        Me.btnC4.Margin = New System.Windows.Forms.Padding(2)
        Me.btnC4.Name = "btnC4"
        Me.btnC4.Size = New System.Drawing.Size(75, 81)
        Me.btnC4.TabIndex = 17
        Me.btnC4.Text = "F" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        Me.btnC4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnC4.UseVisualStyleBackColor = False
        '
        'btnC3
        '
        Me.btnC3.BackColor = System.Drawing.Color.Transparent
        Me.btnC3.BackgroundImage = Global.frmMidiControllerPlayer.My.Resources.Resources.Our
        Me.btnC3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnC3.FlatAppearance.BorderSize = 0
        Me.btnC3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnC3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC3.ForeColor = System.Drawing.Color.White
        Me.btnC3.Location = New System.Drawing.Point(205, 464)
        Me.btnC3.Margin = New System.Windows.Forms.Padding(2)
        Me.btnC3.Name = "btnC3"
        Me.btnC3.Size = New System.Drawing.Size(75, 81)
        Me.btnC3.TabIndex = 16
        Me.btnC3.Text = "D" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnC3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnC3.UseVisualStyleBackColor = False
        '
        'btnC2
        '
        Me.btnC2.BackColor = System.Drawing.Color.Transparent
        Me.btnC2.BackgroundImage = Global.frmMidiControllerPlayer.My.Resources.Resources.Hour
        Me.btnC2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnC2.FlatAppearance.BorderSize = 0
        Me.btnC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC2.ForeColor = System.Drawing.Color.White
        Me.btnC2.Location = New System.Drawing.Point(114, 464)
        Me.btnC2.Margin = New System.Windows.Forms.Padding(2)
        Me.btnC2.Name = "btnC2"
        Me.btnC2.Size = New System.Drawing.Size(75, 81)
        Me.btnC2.TabIndex = 15
        Me.btnC2.Text = "S" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnC2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnC2.UseVisualStyleBackColor = False
        '
        'btnC1
        '
        Me.btnC1.BackColor = System.Drawing.Color.Transparent
        Me.btnC1.BackgroundImage = Global.frmMidiControllerPlayer.My.Resources.Resources.MoreThan
        Me.btnC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnC1.FlatAppearance.BorderSize = 0
        Me.btnC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC1.ForeColor = System.Drawing.Color.White
        Me.btnC1.Location = New System.Drawing.Point(25, 464)
        Me.btnC1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnC1.Name = "btnC1"
        Me.btnC1.Size = New System.Drawing.Size(75, 81)
        Me.btnC1.TabIndex = 14
        Me.btnC1.Text = "A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        Me.btnC1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnC1.UseVisualStyleBackColor = False
        '
        'btnB4
        '
        Me.btnB4.BackColor = System.Drawing.Color.Transparent
        Me.btnB4.BackgroundImage = Global.frmMidiControllerPlayer.My.Resources.Resources.Stronger
        Me.btnB4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnB4.FlatAppearance.BorderSize = 0
        Me.btnB4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnB4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnB4.ForeColor = System.Drawing.Color.White
        Me.btnB4.Location = New System.Drawing.Point(292, 366)
        Me.btnB4.Margin = New System.Windows.Forms.Padding(2)
        Me.btnB4.Name = "btnB4"
        Me.btnB4.Size = New System.Drawing.Size(75, 81)
        Me.btnB4.TabIndex = 13
        Me.btnB4.Text = "R" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        Me.btnB4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnB4.UseVisualStyleBackColor = False
        '
        'btnB3
        '
        Me.btnB3.BackColor = System.Drawing.Color.Transparent
        Me.btnB3.BackgroundImage = Global.frmMidiControllerPlayer.My.Resources.Resources.Faster
        Me.btnB3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnB3.FlatAppearance.BorderSize = 0
        Me.btnB3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnB3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnB3.ForeColor = System.Drawing.Color.White
        Me.btnB3.Location = New System.Drawing.Point(205, 366)
        Me.btnB3.Margin = New System.Windows.Forms.Padding(2)
        Me.btnB3.Name = "btnB3"
        Me.btnB3.Size = New System.Drawing.Size(75, 81)
        Me.btnB3.TabIndex = 12
        Me.btnB3.Text = "E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        Me.btnB3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnB3.UseVisualStyleBackColor = False
        '
        'btnB2
        '
        Me.btnB2.BackColor = System.Drawing.Color.Transparent
        Me.btnB2.BackgroundImage = Global.frmMidiControllerPlayer.My.Resources.Resources.Better
        Me.btnB2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnB2.FlatAppearance.BorderSize = 0
        Me.btnB2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnB2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnB2.ForeColor = System.Drawing.Color.White
        Me.btnB2.Location = New System.Drawing.Point(114, 366)
        Me.btnB2.Margin = New System.Windows.Forms.Padding(2)
        Me.btnB2.Name = "btnB2"
        Me.btnB2.Size = New System.Drawing.Size(75, 81)
        Me.btnB2.TabIndex = 11
        Me.btnB2.Text = "W" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        Me.btnB2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnB2.UseVisualStyleBackColor = False
        '
        'btnB1
        '
        Me.btnB1.BackColor = System.Drawing.Color.Transparent
        Me.btnB1.BackgroundImage = Global.frmMidiControllerPlayer.My.Resources.Resources.Harder
        Me.btnB1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnB1.FlatAppearance.BorderSize = 0
        Me.btnB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnB1.ForeColor = System.Drawing.Color.White
        Me.btnB1.Location = New System.Drawing.Point(25, 366)
        Me.btnB1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnB1.Name = "btnB1"
        Me.btnB1.Size = New System.Drawing.Size(75, 81)
        Me.btnB1.TabIndex = 10
        Me.btnB1.Text = "Q" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        Me.btnB1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnB1.UseVisualStyleBackColor = False
        '
        'btnA4
        '
        Me.btnA4.BackColor = System.Drawing.Color.Transparent
        Me.btnA4.BackgroundImage = Global.frmMidiControllerPlayer.My.Resources.Resources.MakesUs
        Me.btnA4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnA4.FlatAppearance.BorderSize = 0
        Me.btnA4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnA4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnA4.ForeColor = System.Drawing.Color.White
        Me.btnA4.Location = New System.Drawing.Point(292, 270)
        Me.btnA4.Margin = New System.Windows.Forms.Padding(2)
        Me.btnA4.Name = "btnA4"
        Me.btnA4.Size = New System.Drawing.Size(75, 81)
        Me.btnA4.TabIndex = 9
        Me.btnA4.Text = "4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        Me.btnA4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnA4.UseVisualStyleBackColor = False
        '
        'btnA3
        '
        Me.btnA3.BackColor = System.Drawing.Color.Transparent
        Me.btnA3.BackgroundImage = Global.frmMidiControllerPlayer.My.Resources.Resources.DoIt
        Me.btnA3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnA3.FlatAppearance.BorderSize = 0
        Me.btnA3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnA3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnA3.ForeColor = System.Drawing.Color.White
        Me.btnA3.Location = New System.Drawing.Point(205, 270)
        Me.btnA3.Margin = New System.Windows.Forms.Padding(2)
        Me.btnA3.Name = "btnA3"
        Me.btnA3.Size = New System.Drawing.Size(75, 81)
        Me.btnA3.TabIndex = 8
        Me.btnA3.Text = "3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        Me.btnA3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnA3.UseVisualStyleBackColor = False
        '
        'btnA2
        '
        Me.btnA2.BackColor = System.Drawing.Color.Transparent
        Me.btnA2.BackgroundImage = Global.frmMidiControllerPlayer.My.Resources.Resources.MakeIt
        Me.btnA2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnA2.FlatAppearance.BorderSize = 0
        Me.btnA2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnA2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnA2.ForeColor = System.Drawing.Color.White
        Me.btnA2.Location = New System.Drawing.Point(114, 270)
        Me.btnA2.Margin = New System.Windows.Forms.Padding(2)
        Me.btnA2.Name = "btnA2"
        Me.btnA2.Size = New System.Drawing.Size(75, 81)
        Me.btnA2.TabIndex = 7
        Me.btnA2.Text = "2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        Me.btnA2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnA2.UseVisualStyleBackColor = False
        '
        'btnA1
        '
        Me.btnA1.BackColor = System.Drawing.Color.Transparent
        Me.btnA1.BackgroundImage = Global.frmMidiControllerPlayer.My.Resources.Resources.WorkIt
        Me.btnA1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnA1.FlatAppearance.BorderSize = 0
        Me.btnA1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnA1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnA1.ForeColor = System.Drawing.Color.White
        Me.btnA1.Location = New System.Drawing.Point(25, 270)
        Me.btnA1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnA1.Name = "btnA1"
        Me.btnA1.Size = New System.Drawing.Size(75, 81)
        Me.btnA1.TabIndex = 6
        Me.btnA1.Text = "1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        Me.btnA1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnA1.UseVisualStyleBackColor = False
        '
        'picBeat
        '
        Me.picBeat.BackColor = System.Drawing.Color.Transparent
        Me.picBeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picBeat.Image = CType(resources.GetObject("picBeat.Image"), System.Drawing.Image)
        Me.picBeat.Location = New System.Drawing.Point(5, 159)
        Me.picBeat.Margin = New System.Windows.Forms.Padding(2)
        Me.picBeat.Name = "picBeat"
        Me.picBeat.Size = New System.Drawing.Size(385, 96)
        Me.picBeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBeat.TabIndex = 29
        Me.picBeat.TabStop = False
        '
        'AxWindowsMediaPlayer2
        '
        Me.AxWindowsMediaPlayer2.Enabled = True
        Me.AxWindowsMediaPlayer2.Location = New System.Drawing.Point(5, 723)
        Me.AxWindowsMediaPlayer2.Margin = New System.Windows.Forms.Padding(2)
        Me.AxWindowsMediaPlayer2.Name = "AxWindowsMediaPlayer2"
        Me.AxWindowsMediaPlayer2.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer2.Size = New System.Drawing.Size(251, 52)
        Me.AxWindowsMediaPlayer2.TabIndex = 33
        Me.AxWindowsMediaPlayer2.Visible = False
        '
        'AxWindowsMediaPlayer3
        '
        Me.AxWindowsMediaPlayer3.Enabled = True
        Me.AxWindowsMediaPlayer3.Location = New System.Drawing.Point(262, 686)
        Me.AxWindowsMediaPlayer3.Margin = New System.Windows.Forms.Padding(2)
        Me.AxWindowsMediaPlayer3.Name = "AxWindowsMediaPlayer3"
        Me.AxWindowsMediaPlayer3.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer3.Size = New System.Drawing.Size(251, 52)
        Me.AxWindowsMediaPlayer3.TabIndex = 34
        Me.AxWindowsMediaPlayer3.Visible = False
        '
        'AxWindowsMediaPlayer4
        '
        Me.AxWindowsMediaPlayer4.Enabled = True
        Me.AxWindowsMediaPlayer4.Location = New System.Drawing.Point(262, 723)
        Me.AxWindowsMediaPlayer4.Margin = New System.Windows.Forms.Padding(2)
        Me.AxWindowsMediaPlayer4.Name = "AxWindowsMediaPlayer4"
        Me.AxWindowsMediaPlayer4.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer4.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer4.Size = New System.Drawing.Size(251, 52)
        Me.AxWindowsMediaPlayer4.TabIndex = 35
        Me.AxWindowsMediaPlayer4.Visible = False
        '
        'AxWindowsMediaPlayer5
        '
        Me.AxWindowsMediaPlayer5.Enabled = True
        Me.AxWindowsMediaPlayer5.Location = New System.Drawing.Point(5, 762)
        Me.AxWindowsMediaPlayer5.Margin = New System.Windows.Forms.Padding(2)
        Me.AxWindowsMediaPlayer5.Name = "AxWindowsMediaPlayer5"
        Me.AxWindowsMediaPlayer5.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer5.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer5.Size = New System.Drawing.Size(251, 52)
        Me.AxWindowsMediaPlayer5.TabIndex = 36
        Me.AxWindowsMediaPlayer5.Visible = False
        '
        'AxWindowsMediaPlayer6
        '
        Me.AxWindowsMediaPlayer6.Enabled = True
        Me.AxWindowsMediaPlayer6.Location = New System.Drawing.Point(262, 762)
        Me.AxWindowsMediaPlayer6.Margin = New System.Windows.Forms.Padding(2)
        Me.AxWindowsMediaPlayer6.Name = "AxWindowsMediaPlayer6"
        Me.AxWindowsMediaPlayer6.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer6.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer6.Size = New System.Drawing.Size(251, 52)
        Me.AxWindowsMediaPlayer6.TabIndex = 37
        Me.AxWindowsMediaPlayer6.Visible = False
        '
        'AxWindowsMediaPlayer7
        '
        Me.AxWindowsMediaPlayer7.Enabled = True
        Me.AxWindowsMediaPlayer7.Location = New System.Drawing.Point(5, 793)
        Me.AxWindowsMediaPlayer7.Margin = New System.Windows.Forms.Padding(2)
        Me.AxWindowsMediaPlayer7.Name = "AxWindowsMediaPlayer7"
        Me.AxWindowsMediaPlayer7.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer7.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer7.Size = New System.Drawing.Size(251, 52)
        Me.AxWindowsMediaPlayer7.TabIndex = 38
        Me.AxWindowsMediaPlayer7.Visible = False
        '
        'AxWindowsMediaPlayer8
        '
        Me.AxWindowsMediaPlayer8.Enabled = True
        Me.AxWindowsMediaPlayer8.Location = New System.Drawing.Point(262, 793)
        Me.AxWindowsMediaPlayer8.Margin = New System.Windows.Forms.Padding(2)
        Me.AxWindowsMediaPlayer8.Name = "AxWindowsMediaPlayer8"
        Me.AxWindowsMediaPlayer8.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer8.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer8.Size = New System.Drawing.Size(251, 52)
        Me.AxWindowsMediaPlayer8.TabIndex = 39
        Me.AxWindowsMediaPlayer8.Visible = False
        '
        'lblHeadsUp
        '
        Me.lblHeadsUp.AutoSize = True
        Me.lblHeadsUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeadsUp.ForeColor = System.Drawing.Color.White
        Me.lblHeadsUp.Location = New System.Drawing.Point(118, 139)
        Me.lblHeadsUp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHeadsUp.Name = "lblHeadsUp"
        Me.lblHeadsUp.Size = New System.Drawing.Size(0, 18)
        Me.lblHeadsUp.TabIndex = 40
        '
        'lblTimeDisplay
        '
        Me.lblTimeDisplay.AutoSize = True
        Me.lblTimeDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeDisplay.ForeColor = System.Drawing.Color.White
        Me.lblTimeDisplay.Location = New System.Drawing.Point(22, 655)
        Me.lblTimeDisplay.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTimeDisplay.Name = "lblTimeDisplay"
        Me.lblTimeDisplay.Size = New System.Drawing.Size(0, 18)
        Me.lblTimeDisplay.TabIndex = 41
        '
        'btnAbout
        '
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.ForeColor = System.Drawing.Color.White
        Me.btnAbout.Location = New System.Drawing.Point(394, 323)
        Me.btnAbout.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(68, 28)
        Me.btnAbout.TabIndex = 42
        Me.btnAbout.Text = "Abo&ut"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(394, 356)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(68, 28)
        Me.btnExit.TabIndex = 43
        Me.btnExit.Text = "Ex&it"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblShift
        '
        Me.lblShift.BackColor = System.Drawing.Color.Transparent
        Me.lblShift.ForeColor = System.Drawing.Color.White
        Me.lblShift.Location = New System.Drawing.Point(392, 159)
        Me.lblShift.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblShift.Name = "lblShift"
        Me.lblShift.Size = New System.Drawing.Size(86, 32)
        Me.lblShift.TabIndex = 45
        Me.lblShift.Text = "SHIFT ON"
        Me.lblShift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblShift.Visible = False
        '
        'frmMidiController
        '
        Me.AcceptButton = Me.btnBPMSet
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CancelButton = Me.btnBPMStop
        Me.ClientSize = New System.Drawing.Size(488, 663)
        Me.Controls.Add(Me.lblShift)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.lblTimeDisplay)
        Me.Controls.Add(Me.lblHeadsUp)
        Me.Controls.Add(Me.AxWindowsMediaPlayer8)
        Me.Controls.Add(Me.AxWindowsMediaPlayer7)
        Me.Controls.Add(Me.AxWindowsMediaPlayer6)
        Me.Controls.Add(Me.AxWindowsMediaPlayer5)
        Me.Controls.Add(Me.AxWindowsMediaPlayer4)
        Me.Controls.Add(Me.AxWindowsMediaPlayer3)
        Me.Controls.Add(Me.AxWindowsMediaPlayer2)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.btnBPMStop)
        Me.Controls.Add(Me.btnBPMSet)
        Me.Controls.Add(Me.btnD4)
        Me.Controls.Add(Me.btnD3)
        Me.Controls.Add(Me.btnD2)
        Me.Controls.Add(Me.btnD1)
        Me.Controls.Add(Me.btnC4)
        Me.Controls.Add(Me.btnC3)
        Me.Controls.Add(Me.btnC2)
        Me.Controls.Add(Me.btnC1)
        Me.Controls.Add(Me.btnB4)
        Me.Controls.Add(Me.btnB3)
        Me.Controls.Add(Me.btnB2)
        Me.Controls.Add(Me.btnB1)
        Me.Controls.Add(Me.btnA4)
        Me.Controls.Add(Me.btnA3)
        Me.Controls.Add(Me.btnA2)
        Me.Controls.Add(Me.btnA1)
        Me.Controls.Add(Me.picBeat)
        Me.Controls.Add(Me.picTopLabel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMidiController"
        Me.Text = "MIDI Player Controller"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTopLabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBeat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnA1 As System.Windows.Forms.Button
    Friend WithEvents btnA2 As System.Windows.Forms.Button
    Friend WithEvents btnA3 As System.Windows.Forms.Button
    Friend WithEvents btnA4 As System.Windows.Forms.Button
    Friend WithEvents btnB4 As System.Windows.Forms.Button
    Friend WithEvents btnB3 As System.Windows.Forms.Button
    Friend WithEvents btnB2 As System.Windows.Forms.Button
    Friend WithEvents btnB1 As System.Windows.Forms.Button
    Friend WithEvents btnD4 As System.Windows.Forms.Button
    Friend WithEvents btnD3 As System.Windows.Forms.Button
    Friend WithEvents btnD2 As System.Windows.Forms.Button
    Friend WithEvents btnD1 As System.Windows.Forms.Button
    Friend WithEvents btnC4 As System.Windows.Forms.Button
    Friend WithEvents btnC3 As System.Windows.Forms.Button
    Friend WithEvents btnC2 As System.Windows.Forms.Button
    Friend WithEvents btnC1 As System.Windows.Forms.Button
    Friend WithEvents btnBPMSet As System.Windows.Forms.Button
    Friend WithEvents btnBPMStop As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents picBeat As System.Windows.Forms.PictureBox
    Public WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents picTopLabel As System.Windows.Forms.PictureBox
    Public WithEvents AxWindowsMediaPlayer2 As AxWMPLib.AxWindowsMediaPlayer
    Public WithEvents AxWindowsMediaPlayer3 As AxWMPLib.AxWindowsMediaPlayer
    Public WithEvents AxWindowsMediaPlayer4 As AxWMPLib.AxWindowsMediaPlayer
    Public WithEvents AxWindowsMediaPlayer5 As AxWMPLib.AxWindowsMediaPlayer
    Public WithEvents AxWindowsMediaPlayer6 As AxWMPLib.AxWindowsMediaPlayer
    Public WithEvents AxWindowsMediaPlayer7 As AxWMPLib.AxWindowsMediaPlayer
    Public WithEvents AxWindowsMediaPlayer8 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents lblHeadsUp As System.Windows.Forms.Label
    Friend WithEvents lblTimeDisplay As System.Windows.Forms.Label
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblShift As System.Windows.Forms.Label

End Class
