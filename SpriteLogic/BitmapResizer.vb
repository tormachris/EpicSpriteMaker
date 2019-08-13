Option Explicit On
Option Strict On
Option Infer Off

Public Class BitmapResizer
    Inherits ImageStorable
    
#Region "Logic"
    Public Sub ResizeAll(ByVal targetWidth As Int32, ByVal targetHeight As Int32)
        Dim bitmap As Drawing.Bitmap
        Dim indexOfCurrentBitmap As Integer
        Dim modifiedBitmap As Drawing.Bitmap
        Dim _listOfBitmaps As List(Of Drawing.Bitmap) = GetImageStore().GetCollection()
        For Each bitmap In _listOfBitmaps
            indexOfCurrentBitmap = _listOfBitmaps.IndexOf(bitmap)
            modifiedBitmap = ResizeImage(bitmap, targetWidth, targetHeight)
            _listOfBitmaps.RemoveAt(indexOfCurrentBitmap)
            _listOfBitmaps.Insert(indexOfCurrentBitmap, modifiedBitmap)
        Next bitmap
    End Sub

    Public Overloads Shared Function ResizeImage(ByVal sourceImage As Drawing.Image, ByVal targetWidth As Int32, ByVal targetHeight As Int32) As Drawing.Bitmap
        Dim bmSource As Drawing.Bitmap = New Drawing.Bitmap(sourceImage)

        Return ResizeImage(bmSource, targetWidth, targetHeight)
    End Function

    Public Overloads Shared Function ResizeImage(ByVal bmSource As Drawing.Bitmap, ByVal targetWidth As Int32, ByVal targetHeight As Int32) As Drawing.Bitmap
        Dim bmDest As New Drawing.Bitmap(targetWidth, targetHeight, Drawing.Imaging.PixelFormat.Format32bppArgb)

        Dim sourceAspectRatio As Double = bmSource.Width / bmSource.Height
        Dim destAspectRatio As Double = bmDest.Width / bmDest.Height

        Dim newX As Int32 = 0
        Dim newY As Int32 = 0
        Dim newWidth As Int32 = bmDest.Width
        Dim newHeight As Int32 = bmDest.Height

        If Equals(destAspectRatio, sourceAspectRatio) Then
            'same ratio
        ElseIf destAspectRatio > sourceAspectRatio Then
            'Source is taller
            newWidth = Convert.ToInt32(Math.Floor(sourceAspectRatio * newHeight))
            newX = Convert.ToInt32(Math.Floor((bmDest.Width - newWidth) / 2))
        Else
            'Source is wider
            newHeight = Convert.ToInt32(Math.Floor((1 / destAspectRatio) * newWidth))
            newY = Convert.ToInt32(Math.Floor((bmDest.Height - newHeight) / 2))
        End If

        Using grDest As Drawing.Graphics = Drawing.Graphics.FromImage(bmDest)
            With grDest
                .CompositingQuality = Drawing.Drawing2D.CompositingQuality.HighQuality
                .InterpolationMode = Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
                .PixelOffsetMode = Drawing.Drawing2D.PixelOffsetMode.HighQuality
                .SmoothingMode = Drawing.Drawing2D.SmoothingMode.AntiAlias
                .CompositingMode = Drawing.Drawing2D.CompositingMode.SourceOver

                .DrawImage(bmSource, newX, newY, newHeight, newHeight)
            End With
        End Using

        Return bmDest
    End Function
#End Region

#Region "Async Logic"
    Public Function ResizeAllAsync(ByVal targetWidth As Int32, ByVal targetHeight As Int32) As Task
        Return Task.Run(Sub() ResizeAll(targetWidth, targetHeight))
    End Function
    Public Overloads Shared Function ResizeImageAsync(ByVal sourceImage As Drawing.Image, ByVal targetWidth As Int32, ByVal targetHeight As Int32) As Task(Of Drawing.Bitmap)
        Return Task.Run(Function() ResizeImage(sourceImage, targetWidth, targetHeight))
    End Function
    Public Overloads Shared Function ResizeImageAsync(ByVal bmSource As Drawing.Bitmap, ByVal targetWidth As Int32, ByVal targetHeight As Int32) As Task(Of Drawing.Bitmap)
        Return Task.Run(Function() ResizeImage(bmSource, targetWidth, targetHeight))
    End Function
#End Region
End Class
