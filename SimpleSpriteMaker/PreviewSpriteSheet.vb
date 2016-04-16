Public Class PreviewSpriteSheet

    Private Sub PreviewSpriteSheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.ikon_kicsi
        pb_preview.Image = SpriteSheetEditor.sheet
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        pb_preview.Image = Nothing
        Me.Close()
    End Sub
End Class