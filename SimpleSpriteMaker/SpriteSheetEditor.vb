Option Explicit On
Option Strict On
Option Infer Off

Public Class SpriteSheetEditor
    Dim frames() As Image
    Dim currframe As UInteger = 0
    Dim numofframes As UInteger = 0
    Dim resized As Boolean = False
    Public Shared sheet As Bitmap

#Region "Form Load"
    Private Sub SpriteSheetEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.ikon_kicsi
        numofframes = 0
        currframe = 0
        OpenPNGDialog.Multiselect = True
        ReDim frames(1) 'Clear the array
        lb_filelist.Items.Clear()
        txt_picheight.Text = System.Convert.ToString(32)
        txt_picwidth.Text = System.Convert.ToString(32)
    End Sub
#End Region

#Region "ResizeImage"
    Public Overloads Shared Function ResizeImage(SourceImage As Drawing.Image, TargetWidth As Int32, TargetHeight As Int32) As Drawing.Bitmap
        Dim bmSource As Bitmap = New Drawing.Bitmap(SourceImage)

        Return ResizeImage(bmSource, TargetWidth, TargetHeight)
    End Function

    Public Overloads Shared Function ResizeImage(bmSource As Drawing.Bitmap, TargetWidth As Int32, TargetHeight As Int32) As Drawing.Bitmap
        Dim bmDest As New Drawing.Bitmap(TargetWidth, TargetHeight, Drawing.Imaging.PixelFormat.Format32bppArgb)

        Dim nSourceAspectRatio As Double = bmSource.Width / bmSource.Height
        Dim nDestAspectRatio As Double = bmDest.Width / bmDest.Height

        Dim NewX As Long = 0
        Dim NewY As Long = 0
        Dim NewWidth As Long = bmDest.Width
        Dim NewHeight As Long = bmDest.Height

        If nDestAspectRatio = nSourceAspectRatio Then
            'same ratio
        ElseIf nDestAspectRatio > nSourceAspectRatio Then
            'Source is taller
            NewWidth = Convert.ToInt32(Math.Floor(nSourceAspectRatio * NewHeight))
            NewX = Convert.ToInt32(Math.Floor((bmDest.Width - NewWidth) / 2))
        Else
            'Source is wider
            NewHeight = Convert.ToInt32(Math.Floor((1 / nSourceAspectRatio) * NewWidth))
            NewY = Convert.ToInt32(Math.Floor((bmDest.Height - NewHeight) / 2))
        End If

        Using grDest As Graphics = Drawing.Graphics.FromImage(bmDest)
            With grDest
                .CompositingQuality = Drawing.Drawing2D.CompositingQuality.HighQuality
                .InterpolationMode = Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
                .PixelOffsetMode = Drawing.Drawing2D.PixelOffsetMode.HighQuality
                .SmoothingMode = Drawing.Drawing2D.SmoothingMode.AntiAlias
                .CompositingMode = Drawing.Drawing2D.CompositingMode.SourceOver

                .DrawImage(bmSource, NewX, NewY, NewWidth, NewHeight)
            End With
        End Using

        Return bmDest
    End Function
#End Region

#Region "Buttons"
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        PreviewPlayerTimer.Enabled = False
        lb_filelist.Items.Clear()
        ReDim frames(1) 'Clear the array to save memory
        Me.Close()
    End Sub
    Private Sub btn_addfiles_Click(sender As Object, e As EventArgs) Handles btn_addfiles.Click
        Try
            If OpenPNGDialog.ShowDialog = Windows.Forms.DialogResult.OK And System.IO.Path.GetExtension(OpenPNGDialog.FileName) = ".png" Then
                Dim file As String
                Dim i As Integer = -1
                For Each file In OpenPNGDialog.FileNames
                    Try
                        i += 1
                        ReDim Preserve frames(i)
                        frames(i) = System.Drawing.Image.FromFile(OpenPNGDialog.FileNames(i))
                        lb_filelist.Items.Add(OpenPNGDialog.SafeFileNames(i))
                        numofframes = System.Convert.ToUInt32(numofframes + 1)
                        sheet = Nothing
                        resized = False
                    Catch ex As System.Security.SecurityException
                        ' The user lacks appropriate permissions to read files, discover paths, etc.
                        MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                            "Error message: " + ex.Message + "\n\n" +
                            "Details (send to Support):\n\n" + ex.StackTrace)
                    End Try
                Next file
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        lb_filelist.Items.Clear()
        ReDim frames(1)
        numofframes = 0
        currframe = 0
        sheet = Nothing
    End Sub
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim i As ULong = 0
        Dim index As UInteger = System.Convert.ToUInt32(lb_filelist.SelectedIndex)
        If lb_filelist.SelectedIndex <> numofframes Then
            For i = System.Convert.ToUInt64(index + 1) To System.Convert.ToUInt64(frames.Length - 1) Step 1
                frames(System.Convert.ToInt32(i - 1)) = frames(System.Convert.ToInt32(i))
                lb_filelist.Items(System.Convert.ToInt32(i - 1)) = lb_filelist.Items(System.Convert.ToInt32(i))
            Next i
        End If
        ReDim Preserve frames(System.Convert.ToInt32(numofframes - 1))
        lb_filelist.Items.RemoveAt(System.Convert.ToInt32(numofframes - 1))
        numofframes = System.Convert.ToUInt32(numofframes - 1)
    End Sub

    Private Sub btn_moveup_Click(sender As Object, e As EventArgs) Handles btn_moveup.Click
        Dim i As ULong = 0
        For i = 0 To System.Convert.ToUInt64(frames.Length) Step 1
            If lb_filelist.SelectedIndex > 0 Then
                If System.Convert.ToInt32(lb_filelist.SelectedIndex + 1) = i Then
                    Dim temp As String
                    Dim tempimg As Image
                    tempimg = frames(System.Convert.ToInt32(i - 1))
                    temp = lb_filelist.Items(System.Convert.ToInt32(i - 1)).ToString
                    frames(System.Convert.ToInt32(i - 1)) = frames(System.Convert.ToInt32(i))
                    lb_filelist.Items(System.Convert.ToInt32(i - 1)) = lb_filelist.Items(System.Convert.ToInt32(i))
                    frames(System.Convert.ToInt32(i)) = tempimg
                    lb_filelist.Items(System.Convert.ToInt32(i)) = temp
                    Dim listboxindex As UInteger = System.Convert.ToUInt32(lb_filelist.SelectedIndex - 1)
                    lb_filelist.Items.Insert(System.Convert.ToInt32(listboxindex), lb_filelist.SelectedItem)
                    lb_filelist.Items.RemoveAt(lb_filelist.SelectedIndex)
                    lb_filelist.SelectedIndex = System.Convert.ToInt32(listboxindex)
                    Exit Sub
                End If
            End If
        Next i
    End Sub
    Private Sub btn_movedown_Click(sender As Object, e As EventArgs) Handles btn_movedown.Click
        Dim i As ULong = 0
        For i = 0 To System.Convert.ToUInt64(frames.Length) Step 1
            If lb_filelist.SelectedIndex > 0 Then
                If System.Convert.ToInt32(lb_filelist.SelectedIndex + 1) = i Then
                    Dim temp As String
                    Dim tempimg As Image
                    tempimg = frames(System.Convert.ToInt32(i - 1))
                    temp = lb_filelist.Items(System.Convert.ToInt32(i - 1)).ToString
                    frames(System.Convert.ToInt32(i - 1)) = frames(System.Convert.ToInt32(i))
                    lb_filelist.Items(System.Convert.ToInt32(i - 1)) = lb_filelist.Items(System.Convert.ToInt32(i))
                    frames(System.Convert.ToInt32(i)) = tempimg
                    lb_filelist.Items(System.Convert.ToInt32(i)) = temp
                    Dim listboxindex As UInteger = System.Convert.ToUInt32(lb_filelist.SelectedIndex - 1)
                    lb_filelist.Items.Insert(System.Convert.ToInt32(listboxindex), lb_filelist.SelectedItem)
                    lb_filelist.Items.RemoveAt(lb_filelist.SelectedIndex)
                    lb_filelist.SelectedIndex = System.Convert.ToInt32(listboxindex)
                    Exit Sub
                End If
            End If
        Next i
    End Sub

    Private Sub btn_startpreview_Click(sender As Object, e As EventArgs) Handles btn_startpreview.Click
        PreviewPlayerTimer.Enabled = True
    End Sub
    Private Sub btn_stoppreview_Click(sender As Object, e As EventArgs) Handles btn_stoppreview.Click
        PreviewPlayerTimer.Enabled = False
    End Sub
    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        Try
            Dim i As Integer

            If Not resized Then
                If MsgBox("The images have not been resized. Do you want to continue?", MsgBoxStyle.OkCancel) <> MsgBoxResult.Ok Then
                    Exit Sub
                End If
            End If

            If lb_filelist.Items.Count = 0 Then
                MessageBox.Show("There are no images to be compiled into a sprite sheet. Please add images!", "ERROR!")
                Exit Sub
            End If

            Dim culomns As UInteger = System.Convert.ToUInt32(txt_numofcolumns.Text)
            Dim rows As UInteger = System.Convert.ToUInt32(numofframes \ culomns) + System.Convert.ToUInt32(IIf(numofframes Mod culomns <> 0, 1, 0))
            Dim x As UInteger = 0
            Dim y As UInteger = 0

            If System.Convert.ToInt32(culomns * System.Convert.ToInt32(txt_picwidth.Text)) > 2048 Then
                MessageBox.Show("The sprite sheet's vertical resolution cannot be greater than 2048!", "ERROR!")
                Exit Sub
            End If

            If System.Convert.ToInt32(rows * System.Convert.ToInt32(txt_picwidth.Text)) > 2048 Then
                MessageBox.Show("The sprite sheet's horizontal resolution cannot be greater than 2048!", "ERROR!")
                Exit Sub
            End If

            sheet = New Bitmap(System.Convert.ToInt32(culomns * System.Convert.ToInt32(txt_picwidth.Text)), System.Convert.ToInt32(rows * System.Convert.ToInt32(txt_picwidth.Text)))
            Dim graphicsobject As Graphics = Graphics.FromImage(sheet)

            For i = 0 To System.Convert.ToInt32(numofframes - 1) Step 1
                graphicsobject.DrawImage(frames(System.Convert.ToInt32(i)), x, y)
                x = x + System.Convert.ToUInt32(txt_picwidth.Text)
                If x = System.Convert.ToUInt32(culomns * System.Convert.ToDouble(txt_picwidth.Text)) Then
                    y = y + System.Convert.ToUInt32(txt_picwidth.Text)
                    x = 0
                End If
            Next i
            PreviewSpriteSheet.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btn_resizeimages_Click(sender As Object, e As EventArgs) Handles btn_resizeimages.Click
        Dim i As Integer
        For i = 0 To System.Convert.ToInt32(numofframes - 1) Step 1
            If Not (frames(i).Height = System.Convert.ToInt32(txt_picheight.Text) AndAlso frames(i).Width = System.Convert.ToInt32(txt_picwidth.Text)) Then
                frames(i) = ResizeImage(frames(i), System.Convert.ToInt32(txt_picwidth.Text), System.Convert.ToInt32(txt_picheight.Text))
            End If
        Next i
        resized = True
        MessageBox.Show("The images have been successfully resized!", "SUCCESS!")
    End Sub
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            If SavePNGDialog.ShowDialog = Windows.Forms.DialogResult.OK And System.IO.Path.GetExtension(SavePNGDialog.FileName) = ".png" Then
                If Not My.Computer.FileSystem.FileExists(SavePNGDialog.FileName) Then sheet.Save(SavePNGDialog.FileName)
                sheet = Nothing
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Play Animation"
    Private Sub PreviewPlayerTimer_Tick(sender As Object, e As EventArgs) Handles PreviewPlayerTimer.Tick
        Try
            currframe = System.Convert.ToUInt32(currframe + 1)

            If (numofframes > 0 AndAlso currframe <= numofframes) Then
                If (Not frames(System.Convert.ToInt32(currframe - 1)) Is Nothing) Then _
                    pb_preview.Image = frames(System.Convert.ToInt32(currframe - 1))
            Else
                currframe = 0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub delay_ValueChanged(sender As Object, e As EventArgs) Handles delay.ValueChanged
        PreviewPlayerTimer.Interval = System.Convert.ToInt32(delay.Value)
    End Sub
#End Region

#Region "Number Checker"
    Private Sub txt_nums_TextChanged(sender As Object, e As EventArgs) Handles txt_numofcolumns.TextChanged, txt_picheight.TextChanged, txt_picwidth.TextChanged
        Dim i As Integer = 0    'Variable of the For cycle.
        Dim value As String = String.Empty  'Numeric value of the textbox's text.
        Dim enteredvalue As String = CType(sender, TextBox).Text   'Entered value of the textbox.

        'Check to see if the textbox only contains numbers to see if there is a problem.
        If Not Integer.TryParse(enteredvalue, Nothing) Or enteredvalue = String.Empty Then
            ErrorProvider.SetError(CType(sender, TextBox), "This field can only contain numbers.")
            For i = 0 To enteredvalue.Length - 1 Step 1
                If Integer.TryParse(enteredvalue.Substring(i, 1), Nothing) Then
                    value += enteredvalue.Substring(i, 1)
                End If
            Next i
            CType(sender, TextBox).Text = value
        Else
            ErrorProvider.SetError(CType(sender, TextBox), Nothing)
        End If
    End Sub
#End Region

End Class