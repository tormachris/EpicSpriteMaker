﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpriteSheetEditor
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
        Me.lb_filelist = New System.Windows.Forms.ListBox()
        Me.pb_preview = New System.Windows.Forms.PictureBox()
        Me.btn_addfiles = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_moveup = New System.Windows.Forms.Button()
        Me.btn_movedown = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_create = New System.Windows.Forms.Button()
        Me.txt_numofcolumns = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_startpreview = New System.Windows.Forms.Button()
        Me.btn_stoppreview = New System.Windows.Forms.Button()
        Me.delay = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.SavePNGDialog = New System.Windows.Forms.SaveFileDialog()
        Me.OpenPNGDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PreviewPlayerTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_picheight = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_picwidth = New System.Windows.Forms.TextBox()
        Me.btn_resizeimages = New System.Windows.Forms.Button()
        Me.cb_origsize = New System.Windows.Forms.CheckBox()
        CType(Me.pb_preview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.delay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lb_filelist
        '
        Me.lb_filelist.FormattingEnabled = True
        Me.lb_filelist.HorizontalScrollbar = True
        Me.lb_filelist.ItemHeight = 20
        Me.lb_filelist.Location = New System.Drawing.Point(12, 46)
        Me.lb_filelist.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lb_filelist.Name = "lb_filelist"
        Me.lb_filelist.ScrollAlwaysVisible = True
        Me.lb_filelist.Size = New System.Drawing.Size(388, 364)
        Me.lb_filelist.TabIndex = 0
        '
        'pb_preview
        '
        Me.pb_preview.BackColor = System.Drawing.Color.Black
        Me.pb_preview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_preview.Location = New System.Drawing.Point(412, 48)
        Me.pb_preview.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pb_preview.Name = "pb_preview"
        Me.pb_preview.Size = New System.Drawing.Size(365, 353)
        Me.pb_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_preview.TabIndex = 3
        Me.pb_preview.TabStop = False
        '
        'btn_addfiles
        '
        Me.btn_addfiles.Location = New System.Drawing.Point(24, 458)
        Me.btn_addfiles.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_addfiles.Name = "btn_addfiles"
        Me.btn_addfiles.Size = New System.Drawing.Size(112, 35)
        Me.btn_addfiles.TabIndex = 4
        Me.btn_addfiles.Text = "Add"
        Me.btn_addfiles.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(22, 505)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(112, 35)
        Me.btn_delete.TabIndex = 5
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(22, 551)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(112, 35)
        Me.btn_clear.TabIndex = 6
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_moveup
        '
        Me.btn_moveup.Location = New System.Drawing.Point(146, 458)
        Me.btn_moveup.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_moveup.Name = "btn_moveup"
        Me.btn_moveup.Size = New System.Drawing.Size(112, 35)
        Me.btn_moveup.TabIndex = 7
        Me.btn_moveup.Text = "Move Up"
        Me.btn_moveup.UseVisualStyleBackColor = True
        '
        'btn_movedown
        '
        Me.btn_movedown.Location = New System.Drawing.Point(146, 505)
        Me.btn_movedown.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_movedown.Name = "btn_movedown"
        Me.btn_movedown.Size = New System.Drawing.Size(112, 35)
        Me.btn_movedown.TabIndex = 8
        Me.btn_movedown.Text = "Move Down"
        Me.btn_movedown.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 423)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Files"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 17)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Files"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(412, 17)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Preview"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(318, 423)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Create Sprite Sheet"
        '
        'btn_create
        '
        Me.btn_create.Location = New System.Drawing.Point(322, 458)
        Me.btn_create.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(144, 82)
        Me.btn_create.TabIndex = 13
        Me.btn_create.Text = "Create"
        Me.btn_create.UseVisualStyleBackColor = True
        '
        'txt_numofcolumns
        '
        Me.txt_numofcolumns.Location = New System.Drawing.Point(322, 583)
        Me.txt_numofcolumns.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_numofcolumns.MaxLength = 9
        Me.txt_numofcolumns.Name = "txt_numofcolumns"
        Me.txt_numofcolumns.Size = New System.Drawing.Size(142, 26)
        Me.txt_numofcolumns.TabIndex = 14
        Me.txt_numofcolumns.Text = "5"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(318, 558)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Number of Columns"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(510, 423)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Preview"
        '
        'btn_startpreview
        '
        Me.btn_startpreview.Location = New System.Drawing.Point(514, 449)
        Me.btn_startpreview.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_startpreview.Name = "btn_startpreview"
        Me.btn_startpreview.Size = New System.Drawing.Size(111, 35)
        Me.btn_startpreview.TabIndex = 17
        Me.btn_startpreview.Text = "Start"
        Me.btn_startpreview.UseVisualStyleBackColor = True
        '
        'btn_stoppreview
        '
        Me.btn_stoppreview.Location = New System.Drawing.Point(514, 494)
        Me.btn_stoppreview.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_stoppreview.Name = "btn_stoppreview"
        Me.btn_stoppreview.Size = New System.Drawing.Size(111, 35)
        Me.btn_stoppreview.TabIndex = 18
        Me.btn_stoppreview.Text = "Stop"
        Me.btn_stoppreview.UseVisualStyleBackColor = True
        '
        'delay
        '
        Me.delay.Location = New System.Drawing.Point(514, 583)
        Me.delay.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.delay.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.delay.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.delay.Name = "delay"
        Me.delay.Size = New System.Drawing.Size(111, 26)
        Me.delay.TabIndex = 19
        Me.delay.Value = New Decimal(New Integer() {16, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(510, 551)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 20)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Delay Milisec"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(650, 423)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 20)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Save and Exit"
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(654, 449)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(124, 82)
        Me.btn_save.TabIndex = 22
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(654, 551)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(124, 35)
        Me.btn_exit.TabIndex = 23
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'SavePNGDialog
        '
        Me.SavePNGDialog.Filter = "PNG (*.png)|*.png"
        '
        'OpenPNGDialog
        '
        Me.OpenPNGDialog.Filter = "PNG (*.png)|*.png"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'PreviewPlayerTimer
        '
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 612)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 20)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Image Size"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 692)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 20)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Height (Y)"
        '
        'txt_picheight
        '
        Me.txt_picheight.Location = New System.Drawing.Point(114, 688)
        Me.txt_picheight.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_picheight.MaxLength = 9
        Me.txt_picheight.Name = "txt_picheight"
        Me.txt_picheight.Size = New System.Drawing.Size(142, 26)
        Me.txt_picheight.TabIndex = 25
        Me.txt_picheight.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 652)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 20)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Width (X)"
        '
        'txt_picwidth
        '
        Me.txt_picwidth.Location = New System.Drawing.Point(114, 648)
        Me.txt_picwidth.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_picwidth.MaxLength = 9
        Me.txt_picwidth.Name = "txt_picwidth"
        Me.txt_picwidth.Size = New System.Drawing.Size(142, 26)
        Me.txt_picwidth.TabIndex = 27
        Me.txt_picwidth.Text = "0"
        '
        'btn_resizeimages
        '
        Me.btn_resizeimages.Location = New System.Drawing.Point(267, 648)
        Me.btn_resizeimages.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_resizeimages.Name = "btn_resizeimages"
        Me.btn_resizeimages.Size = New System.Drawing.Size(81, 71)
        Me.btn_resizeimages.TabIndex = 29
        Me.btn_resizeimages.Text = "Resize Images"
        Me.btn_resizeimages.UseVisualStyleBackColor = True
        '
        'cb_origsize
        '
        Me.cb_origsize.AutoSize = True
        Me.cb_origsize.Enabled = False
        Me.cb_origsize.Location = New System.Drawing.Point(356, 687)
        Me.cb_origsize.Name = "cb_origsize"
        Me.cb_origsize.Size = New System.Drawing.Size(126, 24)
        Me.cb_origsize.TabIndex = 30
        Me.cb_origsize.Text = "Original Sizie"
        Me.cb_origsize.UseVisualStyleBackColor = True
        '
        'SpriteSheetEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 751)
        Me.Controls.Add(Me.cb_origsize)
        Me.Controls.Add(Me.btn_resizeimages)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_picwidth)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_picheight)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.delay)
        Me.Controls.Add(Me.btn_stoppreview)
        Me.Controls.Add(Me.btn_startpreview)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_numofcolumns)
        Me.Controls.Add(Me.btn_create)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_movedown)
        Me.Controls.Add(Me.btn_moveup)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_addfiles)
        Me.Controls.Add(Me.pb_preview)
        Me.Controls.Add(Me.lb_filelist)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "SpriteSheetEditor"
        Me.Text = "Sprite Sheet Editor"
        CType(Me.pb_preview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.delay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_filelist As System.Windows.Forms.ListBox
    Friend WithEvents pb_preview As System.Windows.Forms.PictureBox
    Friend WithEvents btn_addfiles As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btn_moveup As System.Windows.Forms.Button
    Friend WithEvents btn_movedown As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_create As System.Windows.Forms.Button
    Friend WithEvents txt_numofcolumns As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_startpreview As System.Windows.Forms.Button
    Friend WithEvents btn_stoppreview As System.Windows.Forms.Button
    Friend WithEvents delay As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents SavePNGDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenPNGDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents PreviewPlayerTimer As System.Windows.Forms.Timer
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_picheight As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_picwidth As System.Windows.Forms.TextBox
    Friend WithEvents btn_resizeimages As System.Windows.Forms.Button
    Friend WithEvents cb_origsize As CheckBox
End Class
