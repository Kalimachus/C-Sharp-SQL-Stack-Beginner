Imports WMPLib
'AxMediaPlayer = dedicated player for playing sounds
Public Class frmMidiController
    Public intOutputBPM As Integer 'set the beat at in which light and color effects change
    Public dblTimeHelper As Double 'counts in double time remaining
    Dim intLightSwitchCount As Integer = 1 ' light effect counter
    'CHANGE ALL STRING PATHS WHEN ON OTHER COMPS!
    Dim strInstrumentalPath As String = "E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\Harder, Better, Faster, Stronger (Instrumental).wav"
    'these are my toned string paths for wmp : 
    '0-workit,      1-makeit,  2-doit,    3-makesus,
    '4-harder,      5-better,  6-faster,  7-stronger,
    '8-morethan,    9-hour,   10-our,     11-never,
    '12-ever,      13-after,  14-workis,  15-over
    'low tone wavs
    Dim strLowWAVArray() As String =
        {"E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\WorkItLow.wav",
        "E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\MakeItLow.wav",
        "E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\DoItLow.wav",
        "E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\MakesUsLow.wav",
        "E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\HarderLow.wav",
        "E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\BetterLow.wav",
        "E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\FasterLow.wav",
        "E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\StrongerLow.wav",
        "E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\MoreThanLow.wav",
        "E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\HourLow.wav",
        "E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\OurLow.wav",
        "E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\NeverLow.wav",
        "E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\EverLow.wav",
        "E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\AfterLow.wav",
        "E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\WorkIsLow.wav",
        "E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\OverLow.wav"
        }

    'mid tone wavs
    Dim strMidWAVArray() As String =
    {"E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\WorkItMid.wav",
    "E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\MakeItMid.wav",
    "E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\DoItMid.wav",
    "E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\MakesUsMid.wav",
    "E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\HarderMid.wav",
    "E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\BetterMid.wav",
    "E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\FasterMid.wav",
    "E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\StrongerMid.wav",
    "E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\MoreThanMid.wav",
    "E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\HourMid.wav",
    "E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\OurMid.wav",
    "E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\NeverMid.wav",
    "E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\EverMid.wav",
    "E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\AfterMid.wav",
    "E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\WorkIsMid.wav",
    "E:\MIDIControllerPlayer\frmMidiControllerPlayer\frmMidiControllerPlayer\Resources\OverMid.wav"
    }

    'timer with intervals
    Public Sub runtimer1()
        intOutputBPM = (60000 / 125) 'bpm the song is at approximately. edit in FL Studio to stabilize bpm.
        Timer1.Interval = intOutputBPM 'every 60000 milliseconds (60 seconds) / beats per (60/sec)
        Timer1.Enabled = True 'turn on time when procedure is called

    End Sub
    'timer tick actions
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Select Case intLightSwitchCount
            Case Is = 1
                picBeat.Image = My.Resources.picBeat1

                btnExit.ForeColor = Color.Turquoise
                btnAbout.ForeColor = Color.Red
                btnBPMStop.ForeColor = Color.White

                intLightSwitchCount += 1
            Case Is = 2
                picBeat.Image = My.Resources.picBeat2

                btnExit.ForeColor = Color.White
                btnAbout.ForeColor = Color.Turquoise
                btnBPMStop.ForeColor = Color.Red

                intLightSwitchCount += 1
            Case Is = 3
                picBeat.Image = My.Resources.picBeat3

                btnExit.ForeColor = Color.Red
                btnAbout.ForeColor = Color.White
                btnBPMStop.ForeColor = Color.Turquoise

                intLightSwitchCount += 1
            Case Is = 4
                picBeat.Image = My.Resources.picBeat4

                btnExit.ForeColor = Color.Red
                btnAbout.ForeColor = Color.Turquoise
                btnBPMStop.ForeColor = Color.White

                intLightSwitchCount = 1
        End Select
        dblTimeHelper = AxWindowsMediaPlayer1.currentMedia.duration - AxWindowsMediaPlayer1.Ctlcontrols.currentPosition
        lblTimeDisplay.Text = SecondsToTime(dblTimeHelper)

        Select Case dblTimeHelper
            Case 186 To 250
                lblHeadsUp.Text = "Use Shift + Key for High Pitch"
            Case 171 To 185
                lblHeadsUp.Text = "GET READY!"
            Case 170 To 0
                lblHeadsUp.Text = ""
        End Select
    End Sub
    'convert double number to time format
    Private Function SecondsToTime(ByVal dSeconds As Double) As String
        SecondsToTime = Format(DateAdd("s", dSeconds, "00:00:00"), "HH:mm:ss")
        Return SecondsToTime
    End Function


    'start metronome
    Private Sub btnBPMSet_Click(sender As Object, e As EventArgs) Handles btnBPMSet.Click
        btnBPMSet.Visible = False
        btnBPMStop.Visible = True
        runtimer1()
        AxWindowsMediaPlayer1.URL = strInstrumentalPath
        picTopLabel.Image = My.Resources.DLabel
    End Sub
    'stop metronome
    Private Sub btnBPMStop_Click(sender As Object, e As EventArgs) Handles btnBPMStop.Click
        btnBPMSet.Visible = True
        btnBPMStop.Visible = False
        Timer1.Enabled = False
        intLightSwitchCount = 1
        dblTimeHelper = 0
        picBeat.Image = My.Resources.picBeat1
        AxWindowsMediaPlayer1.URL = Nothing
        picTopLabel.Image = My.Resources.Dlabel0
        btnBPMSet.Focus()
        btnExit.ForeColor = Color.White
        btnAbout.ForeColor = Color.White
        btnBPMStop.ForeColor = Color.White


    End Sub


    Private Sub frmMidiController_KeyDown(sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        ' If (Keys.D1 AndAlso e.Modifiers = Keys.Shift) Then
        'nA1.BackgroundImage = My.Resources.WorkItToggle
        '  AxWindowsMediaPlayer2.URL = strMidWAVArray(1)
        'End If
        ' If e.Shift = e.Shift Then
        '    lblShift.Visible = True
        ' End If
        If e.Modifiers = Keys.Shift Then
            lblShift.Visible = True
        End If

        Select Case e.KeyCode
            Case Is = (Keys.D1 And e.Shift) 'Shift + 1
                btnA1.BackgroundImage = My.Resources.WorkItToggle
                AxWindowsMediaPlayer2.URL = strMidWAVArray(0)
            Case Is = Keys.D1
                btnA1.BackgroundImage = My.Resources.WorkItToggle
                AxWindowsMediaPlayer2.URL = strLowWAVArray(0)
            Case Is = (Keys.D2 And e.Shift)
                btnA2.BackgroundImage = My.Resources.MakeItToggle
                AxWindowsMediaPlayer4.URL = strMidWAVArray(1)
            Case Is = Keys.D2
                btnA2.BackgroundImage = My.Resources.MakeItToggle
                AxWindowsMediaPlayer4.URL = strLowWAVArray(1)
            Case Is = (Keys.D3 And e.Shift)
                btnA3.BackgroundImage = My.Resources.DoItToggle
                AxWindowsMediaPlayer2.URL = strMidWAVArray(2)
            Case Is = Keys.D3
                btnA3.BackgroundImage = My.Resources.DoItToggle
                AxWindowsMediaPlayer2.URL = strLowWAVArray(2)
            Case Is = (Keys.D4 And e.Shift)
                btnA4.BackgroundImage = My.Resources.MakesUsToggle
                AxWindowsMediaPlayer4.URL = strMidWAVArray(3)
            Case Is = Keys.D4
                btnA4.BackgroundImage = My.Resources.MakesUsToggle
                AxWindowsMediaPlayer4.URL = strLowWAVArray(3)
            Case Is = (Keys.Q And e.Shift)
                btnB1.BackgroundImage = My.Resources.HarderToggle
                AxWindowsMediaPlayer3.URL = strMidWAVArray(4)
            Case Is = Keys.Q
                btnB1.BackgroundImage = My.Resources.HarderToggle
                AxWindowsMediaPlayer3.URL = strLowWAVArray(4)
            Case Is = (Keys.W And e.Shift)
                btnB2.BackgroundImage = My.Resources.BetterToggle
                AxWindowsMediaPlayer5.URL = strMidWAVArray(5)
            Case Is = Keys.W
                btnB2.BackgroundImage = My.Resources.BetterToggle
                AxWindowsMediaPlayer5.URL = strLowWAVArray(5)
            Case Is = (Keys.E And e.Shift)
                btnB3.BackgroundImage = My.Resources.FasterToggle
                AxWindowsMediaPlayer3.URL = strMidWAVArray(6)
            Case Is = Keys.E
                btnB3.BackgroundImage = My.Resources.FasterToggle
                AxWindowsMediaPlayer3.URL = strLowWAVArray(6)
            Case Is = (Keys.R And e.Shift)
                btnB4.BackgroundImage = My.Resources.StrongerToggle
                AxWindowsMediaPlayer5.URL = strMidWAVArray(7)
            Case Is = Keys.R
                btnB4.BackgroundImage = My.Resources.StrongerToggle
                AxWindowsMediaPlayer5.URL = strLowWAVArray(7)
            Case Is = (Keys.A And e.Shift)
                btnC1.BackgroundImage = My.Resources.MoreThanToggle
                AxWindowsMediaPlayer2.URL = strMidWAVArray(8)
            Case Is = Keys.A
                btnC1.BackgroundImage = My.Resources.MoreThanToggle
                AxWindowsMediaPlayer2.URL = strLowWAVArray(8)
            Case Is = (Keys.S And e.Shift)
                btnC2.BackgroundImage = My.Resources.HourToggle
                AxWindowsMediaPlayer4.URL = strMidWAVArray(9)
            Case Is = Keys.S
                btnC2.BackgroundImage = My.Resources.HourToggle
                AxWindowsMediaPlayer4.URL = strLowWAVArray(9)
            Case Is = (Keys.D And e.Shift)
                btnC3.BackgroundImage = My.Resources.OurToggle
                AxWindowsMediaPlayer2.URL = strMidWAVArray(10)
            Case Is = Keys.D
                btnC3.BackgroundImage = My.Resources.OurToggle
                AxWindowsMediaPlayer2.URL = strLowWAVArray(10)
            Case Is = (Keys.F And e.Shift)
                btnC4.BackgroundImage = My.Resources.NeverToggle
                AxWindowsMediaPlayer4.URL = strMidWAVArray(11)
            Case Is = Keys.F
                btnC4.BackgroundImage = My.Resources.NeverToggle
                AxWindowsMediaPlayer4.URL = strLowWAVArray(11)
            Case Is = (Keys.Z And e.Shift)
                btnD1.BackgroundImage = My.Resources.EverToggle
                AxWindowsMediaPlayer3.URL = strMidWAVArray(12)
            Case Is = Keys.Z
                btnD1.BackgroundImage = My.Resources.EverToggle
                AxWindowsMediaPlayer3.URL = strLowWAVArray(12)
            Case Is = (Keys.X And e.Shift)
                btnD2.BackgroundImage = My.Resources.AfterToggle
                AxWindowsMediaPlayer5.URL = strMidWAVArray(13)
            Case Is = Keys.X
                btnD2.BackgroundImage = My.Resources.AfterToggle
                AxWindowsMediaPlayer5.URL = strLowWAVArray(13)
            Case Is = (Keys.C And e.Shift)
                btnD3.BackgroundImage = My.Resources.WorkIsToggle
                AxWindowsMediaPlayer3.URL = strMidWAVArray(14)
            Case Is = Keys.C
                btnD3.BackgroundImage = My.Resources.WorkIsToggle
                AxWindowsMediaPlayer3.URL = strLowWAVArray(14)
            Case Is = (Keys.V And e.Shift)
                btnD4.BackgroundImage = My.Resources.OverToggle
                AxWindowsMediaPlayer5.URL = strMidWAVArray(15)
            Case Is = Keys.V
                btnD4.BackgroundImage = My.Resources.OverToggle
                AxWindowsMediaPlayer5.URL = strLowWAVArray(15)
        End Select



    End Sub
    'mouse up and down toggle/reset
    Private Sub btnA1_MouseDown(sender As Object, e As EventArgs) Handles btnA1.MouseDown
        btnA1.BackgroundImage = My.Resources.WorkItToggle
        AxWindowsMediaPlayer2.URL = strLowWAVArray(0)
    End Sub
    Private Sub btnA1_MouseUP(sender As Object, e As EventArgs) Handles btnA1.MouseUp
        btnA1.BackgroundImage = My.Resources.WorkIt
    End Sub

    Private Sub btnA2_MouseDown(sender As Object, e As EventArgs) Handles btnA2.MouseDown
        btnA2.BackgroundImage = My.Resources.MakeItToggle
        AxWindowsMediaPlayer4.URL = strLowWAVArray(1)
    End Sub
    Private Sub btnA2_MouseUP(sender As Object, e As EventArgs) Handles btnA2.MouseUp
        btnA2.BackgroundImage = My.Resources.MakeIt
    End Sub
    Private Sub btnA3_MouseDown(sender As Object, e As EventArgs) Handles btnA3.MouseDown
        btnA3.BackgroundImage = My.Resources.DoItToggle
        AxWindowsMediaPlayer2.URL = strLowWAVArray(2)
    End Sub
    Private Sub btnA3_MouseUP(sender As Object, e As EventArgs) Handles btnA3.MouseUp
        btnA3.BackgroundImage = My.Resources.DoIt
    End Sub
    Private Sub btnA4_MouseDown(sender As Object, e As EventArgs) Handles btnA4.MouseDown
        btnA4.BackgroundImage = My.Resources.MakesUsToggle
        AxWindowsMediaPlayer4.URL = strLowWAVArray(3)
    End Sub
    Private Sub btnA4_MouseUP(sender As Object, e As EventArgs) Handles btnA4.MouseUp
        btnA4.BackgroundImage = My.Resources.MakesUs
    End Sub
    Private Sub btnB1_MouseDown(sender As Object, e As EventArgs) Handles btnB1.MouseDown
        btnB1.BackgroundImage = My.Resources.HarderToggle
        AxWindowsMediaPlayer3.URL = strLowWAVArray(4)
    End Sub
    Private Sub btnB1_MouseUP(sender As Object, e As EventArgs) Handles btnB1.MouseUp
        btnB1.BackgroundImage = My.Resources.Harder
    End Sub
    Private Sub btnB2_MouseDown(sender As Object, e As EventArgs) Handles btnB2.MouseDown
        btnB2.BackgroundImage = My.Resources.BetterToggle
        AxWindowsMediaPlayer5.URL = strLowWAVArray(5)
    End Sub
    Private Sub btnB2_MouseUP(sender As Object, e As EventArgs) Handles btnB2.MouseUp
        btnB2.BackgroundImage = My.Resources.Better
    End Sub
    Private Sub btnB3_MouseDown(sender As Object, e As EventArgs) Handles btnB3.MouseDown
        btnB3.BackgroundImage = My.Resources.FasterToggle
        AxWindowsMediaPlayer3.URL = strLowWAVArray(6)
    End Sub
    Private Sub btnB3_MouseUP(sender As Object, e As EventArgs) Handles btnB3.MouseUp
        btnB3.BackgroundImage = My.Resources.Faster
    End Sub
    Private Sub btnB4_MouseDown(sender As Object, e As EventArgs) Handles btnB4.MouseDown
        btnB4.BackgroundImage = My.Resources.StrongerToggle
        AxWindowsMediaPlayer5.URL = strLowWAVArray(7)
    End Sub
    Private Sub btnB4_MouseUP(sender As Object, e As EventArgs) Handles btnB4.MouseUp
        btnB4.BackgroundImage = My.Resources.Stronger
    End Sub
    Private Sub btnC1_MouseDown(sender As Object, e As EventArgs) Handles btnC1.MouseDown
        btnC1.BackgroundImage = My.Resources.MoreThanToggle
        AxWindowsMediaPlayer2.URL = strLowWAVArray(8)
    End Sub
    Private Sub btnC1_MouseUP(sender As Object, e As EventArgs) Handles btnC1.MouseUp
        btnC1.BackgroundImage = My.Resources.MoreThan
    End Sub
    Private Sub btnC2_MouseDown(sender As Object, e As EventArgs) Handles btnC2.MouseDown
        btnC2.BackgroundImage = My.Resources.HourToggle
        AxWindowsMediaPlayer4.URL = strLowWAVArray(9)
    End Sub
    Private Sub btnC2_MouseUP(sender As Object, e As EventArgs) Handles btnC2.MouseUp
        btnC2.BackgroundImage = My.Resources.Hour
    End Sub
    Private Sub btnC3_MouseDown(sender As Object, e As EventArgs) Handles btnC3.MouseDown
        btnC3.BackgroundImage = My.Resources.OurToggle
        AxWindowsMediaPlayer2.URL = strLowWAVArray(10)
    End Sub
    Private Sub btnC3_MouseUP(sender As Object, e As EventArgs) Handles btnC3.MouseUp
        btnC3.BackgroundImage = My.Resources.Our
    End Sub
    Private Sub btnC4_MouseDown(sender As Object, e As EventArgs) Handles btnC4.MouseDown
        btnC4.BackgroundImage = My.Resources.NeverToggle
        AxWindowsMediaPlayer4.URL = strLowWAVArray(11)
    End Sub
    Private Sub btnC4_MouseUP(sender As Object, e As EventArgs) Handles btnC4.MouseUp
        btnC4.BackgroundImage = My.Resources.Never
    End Sub
    Private Sub btnD1_MouseDown(sender As Object, e As EventArgs) Handles btnD1.MouseDown
        btnD1.BackgroundImage = My.Resources.EverToggle
        AxWindowsMediaPlayer3.URL = strLowWAVArray(12)
    End Sub
    Private Sub btnD1_MouseUP(sender As Object, e As EventArgs) Handles btnD1.MouseUp
        btnD1.BackgroundImage = My.Resources.Ever
    End Sub
    Private Sub btnD2_MouseDown(sender As Object, e As EventArgs) Handles btnD2.MouseDown
        btnD2.BackgroundImage = My.Resources.AfterToggle
        AxWindowsMediaPlayer5.URL = strLowWAVArray(13)
    End Sub
    Private Sub btnD2_MouseUP(sender As Object, e As EventArgs) Handles btnD2.MouseUp
        btnD2.BackgroundImage = My.Resources.After
    End Sub
    Private Sub btnD3_MouseDown(sender As Object, e As EventArgs) Handles btnD3.MouseDown
        btnD3.BackgroundImage = My.Resources.WorkIsToggle
        AxWindowsMediaPlayer3.URL = strLowWAVArray(14)
    End Sub
    Private Sub btnD3_MouseUP(sender As Object, e As EventArgs) Handles btnD3.MouseUp
        btnD3.BackgroundImage = My.Resources.WorkIs
    End Sub
    Private Sub btnD4_MouseDown(sender As Object, e As EventArgs) Handles btnD4.MouseDown
        btnD4.BackgroundImage = My.Resources.OverToggle
        AxWindowsMediaPlayer5.URL = strLowWAVArray(15)
    End Sub
    Private Sub btnD4_MouseUP(sender As Object, e As EventArgs) Handles btnD4.MouseUp
        btnD4.BackgroundImage = My.Resources.Over
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMidiController_KeyUp(sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

        If e.Modifiers <> Keys.Shift Then
            lblShift.Visible = False
        End If

        Select Case e.KeyCode
            Case Is = (Keys.D1 And e.Shift) 'Shift + 1
                btnA1.BackgroundImage = My.Resources.WorkIt
            Case Is = Keys.D1
                btnA1.BackgroundImage = My.Resources.WorkIt
            Case Is = (Keys.D2 And e.Shift)
                btnA2.BackgroundImage = My.Resources.MakeIt
            Case Is = Keys.D2
                btnA2.BackgroundImage = My.Resources.MakeIt
            Case Is = (Keys.D3 And e.Shift)
                btnA3.BackgroundImage = My.Resources.DoIt
            Case Is = Keys.D3
                btnA3.BackgroundImage = My.Resources.DoIt
            Case Is = (Keys.D4 And e.Shift)
                btnA4.BackgroundImage = My.Resources.MakesUs
            Case Is = Keys.D4
                btnA4.BackgroundImage = My.Resources.MakesUs
            Case Is = (Keys.Q And e.Shift)
                btnB1.BackgroundImage = My.Resources.Harder
            Case Is = Keys.Q
                btnB1.BackgroundImage = My.Resources.Harder
            Case Is = (Keys.W And e.Shift)
                btnB2.BackgroundImage = My.Resources.Better
            Case Is = Keys.W
                btnB2.BackgroundImage = My.Resources.Better
            Case Is = (Keys.E And e.Shift)
                btnB3.BackgroundImage = My.Resources.Faster
            Case Is = Keys.E
                btnB3.BackgroundImage = My.Resources.Faster
            Case Is = (Keys.R And e.Shift)
                btnB4.BackgroundImage = My.Resources.Stronger
            Case Is = Keys.R
                btnB4.BackgroundImage = My.Resources.Stronger
            Case Is = (Keys.A And e.Shift)
                btnC1.BackgroundImage = My.Resources.MoreThan
            Case Is = Keys.A
                btnC1.BackgroundImage = My.Resources.MoreThan
            Case Is = (Keys.S And e.Shift)
                btnC2.BackgroundImage = My.Resources.Hour
            Case Is = Keys.S
                btnC2.BackgroundImage = My.Resources.Hour
            Case Is = (Keys.D And e.Shift)
                btnC3.BackgroundImage = My.Resources.Our
            Case Is = Keys.D
                btnC3.BackgroundImage = My.Resources.Our
            Case Is = (Keys.F And e.Shift)
                btnC4.BackgroundImage = My.Resources.Never
            Case Is = Keys.F
                btnC4.BackgroundImage = My.Resources.Never
            Case Is = (Keys.Z And e.Shift)
                btnD1.BackgroundImage = My.Resources.Ever
            Case Is = Keys.Z
                btnD1.BackgroundImage = My.Resources.Ever
            Case Is = (Keys.X And e.Shift)
                btnD2.BackgroundImage = My.Resources.After
            Case Is = Keys.X
                btnD2.BackgroundImage = My.Resources.After
            Case Is = (Keys.C And e.Shift)
                btnD3.BackgroundImage = My.Resources.WorkIs
            Case Is = Keys.C
                btnD3.BackgroundImage = My.Resources.WorkIs
            Case Is = (Keys.V And e.Shift)
                btnD4.BackgroundImage = My.Resources.Over
            Case Is = Keys.V
                btnD4.BackgroundImage = My.Resources.Over
        End Select


    End Sub

    Private Sub frmMidiController_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        btnBPMSet.Focus()

    End Sub
    'about
    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        MessageBox.Show("Made by Kyle. Inspired by www.najle.com/")
    End Sub


End Class
