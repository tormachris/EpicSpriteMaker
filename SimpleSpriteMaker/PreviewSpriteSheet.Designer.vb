<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreviewSpriteSheet
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
        Me.pb_preview = New System.Windows.Forms.PictureBox()
        Me.btn_ok = New System.Windows.Forms.Button()
        CType(Me.pb_preview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_preview
        '
        Me.pb_preview.BackColor = System.Drawing.Color.Black
        Me.pb_preview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_preview.Location = New System.Drawing.Point(12, 12)
        Me.pb_preview.Name = "pb_preview"
        Me.pb_preview.Size = New System.Drawing.Size(577, 542)
        Me.pb_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_preview.TabIndex = 4
        Me.pb_preview.TabStop = False
        '
        'btn_ok
        '
        Me.btn_ok.Location = New System.Drawing.Point(264, 560)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_ok.TabIndex = 5
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'PreviewSpriteSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 595)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.pb_preview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "PreviewSpriteSheet"
        Me.Text = "Preview"
        CType(Me.pb_preview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pb_preview As System.Windows.Forms.PictureBox
    Friend WithEvents btn_ok As System.Windows.Forms.Button
End Class
