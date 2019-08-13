Option Explicit On
Option Strict On
Option Infer Off
Public Class SpriteCreator
    Inherits ImageStorable
    Private LastBitmap as Drawing.Bitmap
    
    Public Function GetLastBitmap() As Drawing.Bitmap
        return LastBitmap
    End Function
    
        Public Function CreateSpriteSheet(columns as UInteger, width as Integer) As  Drawing.Bitmap
            Dim i As Integer
            Dim numofframes as Integer = GetImageStore().GetCollection().Count
            Dim rows As UInteger = Convert.ToUInt32(numofframes \ columns) + Convert.ToUInt32(If(numofframes Mod columns <> 0, 1, 0))
            Dim x As UInteger = 0
            Dim y As UInteger = 0
            Dim sheet as Drawing.Bitmap = New Drawing.Bitmap(Convert.ToInt32(columns * width), Convert.ToInt32(rows * width))
            Dim graphicsobject As Drawing.Graphics = Drawing.Graphics.FromImage(sheet)
            
            If numofframes = 0 Then
                Throw New Exception("There are no images to be compiled into a sprite sheet. Please add images!")
            End If
            
            For Each bitmap as Drawing.Bitmap in GetImageStore().GetCollection()
                graphicsobject.DrawImage(bitmap, x, y)
                x = x + Convert.ToUInt32(width)
                If x = Convert.ToUInt32(columns * Convert.ToDouble(width)) Then
                    y = y + Convert.ToUInt32(width)
                    x = 0
                End If
            Next bitmap
            
            LastBitmap = sheet
            return sheet
        End Function
    
End Class