Public Class YoutubeList

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height

        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            x = x - 1
            Me.Location = New Point(x, y)
        Loop

    End Sub
End Class
