<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.btnGO = New System.Windows.Forms.Button()
        Me.rtbLogBox = New System.Windows.Forms.RichTextBox()
        Me.txtConsoleBox = New System.Windows.Forms.TextBox()
        Me.picMainLogo = New System.Windows.Forms.PictureBox()
        Me.LoggerTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picMainLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGO
        '
        Me.btnGO.Location = New System.Drawing.Point(436, 422)
        Me.btnGO.Name = "btnGO"
        Me.btnGO.Size = New System.Drawing.Size(54, 20)
        Me.btnGO.TabIndex = 11
        Me.btnGO.Text = "GO!"
        Me.btnGO.UseVisualStyleBackColor = True
        '
        'rtbLogBox
        '
        Me.rtbLogBox.BackColor = System.Drawing.Color.Black
        Me.rtbLogBox.ForeColor = System.Drawing.Color.White
        Me.rtbLogBox.Location = New System.Drawing.Point(11, 114)
        Me.rtbLogBox.Name = "rtbLogBox"
        Me.rtbLogBox.Size = New System.Drawing.Size(479, 302)
        Me.rtbLogBox.TabIndex = 10
        Me.rtbLogBox.Text = ""
        '
        'txtConsoleBox
        '
        Me.txtConsoleBox.Location = New System.Drawing.Point(11, 422)
        Me.txtConsoleBox.Name = "txtConsoleBox"
        Me.txtConsoleBox.Size = New System.Drawing.Size(419, 20)
        Me.txtConsoleBox.TabIndex = 9
        '
        'picMainLogo
        '
        Me.picMainLogo.Image = CType(resources.GetObject("picMainLogo.Image"), System.Drawing.Image)
        Me.picMainLogo.Location = New System.Drawing.Point(11, 12)
        Me.picMainLogo.Name = "picMainLogo"
        Me.picMainLogo.Size = New System.Drawing.Size(482, 95)
        Me.picMainLogo.TabIndex = 8
        Me.picMainLogo.TabStop = False
        '
        'LoggerTimer
        '
        Me.LoggerTimer.Enabled = True
        Me.LoggerTimer.Interval = 1
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 455)
        Me.Controls.Add(Me.btnGO)
        Me.Controls.Add(Me.rtbLogBox)
        Me.Controls.Add(Me.txtConsoleBox)
        Me.Controls.Add(Me.picMainLogo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Server"
        CType(Me.picMainLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnGO As System.Windows.Forms.Button
    Private WithEvents rtbLogBox As System.Windows.Forms.RichTextBox
    Private WithEvents txtConsoleBox As System.Windows.Forms.TextBox
    Private WithEvents picMainLogo As System.Windows.Forms.PictureBox
    Friend WithEvents LoggerTimer As System.Windows.Forms.Timer

End Class
