<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YoutubeList
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
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        CType(Me.TrackBar1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'WebBrowser1
        '
        Me.WebBrowser1.AllowWebBrowserDrop = false
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScrollBarsEnabled = false
        Me.WebBrowser1.Size = New System.Drawing.Size(559, 360)
        Me.WebBrowser1.TabIndex = 4
        Me.WebBrowser1.Url = New System.Uri("https://www.youtube.com/", System.UriKind.Absolute)
        '
        'TrackBar1
        '
        Me.TrackBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBar1.AutoSize = False
        Me.TrackBar1.Location = New System.Drawing.Point(406, 333)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(153, 27)
        Me.TrackBar1.TabIndex = 5
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TrackBar1.Value = 7
        '
        'YoutubeList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(559, 360)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Name = "YoutubeList"
        Me.Opacity = 0.75R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Youtube Desktop Player"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar

End Class
