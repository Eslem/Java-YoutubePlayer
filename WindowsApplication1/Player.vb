Public Class YoutubeList

    Private metalPlaylist = "http://www.youtube.com/embed/videoseries?list=PLjO7Bux5L_yP-K0ZiL3h9nUzeWK-Ps-CD"
    Private clasiclaPlaylist = "http://www.youtube.com/embed/videoseries?list=PL8FABEAD8F2BDF0E7"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height

        WebBrowser1.Navigate(New Uri(clasiclaPlaylist))


        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            x = x - 1
            Me.Location = New Point(x, y)
        Loop

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim url As New System.Uri(metalPlaylist)
        WebBrowser1.Navigate(url)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim url As New System.Uri(clasiclaPlaylist)
        WebBrowser1.Url = url
        WebBrowser1.Navigate(url)

    End Sub
End Class
