Imports DirectShowLib

Public Class SplashForm
    Private mediaControl As IMediaControl
    Private videoWindow As IVideoWindow
    Private closeTimer As Timer ' Make timer a class-level variable

    Private Sub SplashForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Construct the video path dynamically
        Dim videoPath As String = System.IO.Path.Combine(Application.StartupPath, "Resources", "splash.avi")

        ' Debug: Show the actual path
        ' MessageBox.Show("Checking video path: " & videoPath)

        ' Check if the file exists before playing
        If Not System.IO.File.Exists(videoPath) Then
            MessageBox.Show("Video file not found at: " & videoPath)
            Return
        End If

        ' Play the video
        PlayVideo(videoPath)
    End Sub


    Private Sub PlayVideo(videoPath As String)
        Try
            ' Create the Filter Graph Manager
            Dim graphBuilder As IGraphBuilder = CType(New FilterGraph(), IGraphBuilder)
            mediaControl = CType(graphBuilder, IMediaControl)
            videoWindow = CType(graphBuilder, IVideoWindow)

            ' Load the video file
            Dim hr As Integer = graphBuilder.RenderFile(videoPath, Nothing)
            If hr < 0 Then
                MessageBox.Show("Failed to load video. HRESULT: " & hr)
                Return
            End If

            ' Ensure videoPanel exists
            If videoPanel Is Nothing Then
                MessageBox.Show("Error: videoPanel is missing. Add a Panel control to the form.")
                Return
            End If

            ' Attach the video to the panel
            videoWindow.put_Owner(videoPanel.Handle) ' Attach to the panel
            videoWindow.put_WindowStyle(&H40000000 Or &H10000000) ' WS_CHILD | WS_CLIPSIBLINGS
            videoWindow.SetWindowPosition(0, 0, videoPanel.Width, videoPanel.Height)

            ' Start playing the video
            mediaControl.Run()

            ' Set a timer to close the splash screen when the video ends
            closeTimer = New Timer()
            AddHandler closeTimer.Tick, AddressOf CloseSplash
            closeTimer.Interval = 7000 ' Adjust to match your video duration (in milliseconds)
            closeTimer.Start()

        Catch ex As Exception
            MessageBox.Show("Error playing video: " & ex.Message)
        End Try
    End Sub

    Private Sub CloseSplash(sender As Object, e As EventArgs)
        ' Stop and dispose of the timer
        closeTimer.Stop()
        closeTimer.Dispose()

        ' Stop video playback
        If mediaControl IsNot Nothing Then
            mediaControl.Stop()
        End If

        ' Hide the splash screen and show the main form
        Me.Hide()
        Dim mainForm As New MainForm()
        mainForm.Show()
    End Sub

    ' Handle resizing so the video stays inside the panel
    Private Sub SplashForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If videoWindow IsNot Nothing Then
            videoWindow.SetWindowPosition(0, 0, videoPanel.Width, videoPanel.Height)
        End If
    End Sub

    Private Sub videoPanel_Paint(sender As Object, e As PaintEventArgs) Handles videoPanel.Paint

    End Sub
End Class
