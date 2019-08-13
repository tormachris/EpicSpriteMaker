Option Explicit On
Option Strict On
Option Infer Off
Public Class ImageStore
    Private ReadOnly _listOfBitmaps As List(Of Drawing.Bitmap)

    Public Sub New()
        _listOfBitmaps = New List(Of Drawing.Bitmap)
    End Sub

    Public Sub AddBitmap(bitmap As Drawing.Bitmap)
        _listOfBitmaps.Append(bitmap)
    End Sub

    Public Sub AddImage(image As Drawing.Image)
        Dim bitmap As Drawing.Bitmap = New Drawing.Bitmap(image)
        'We want to store bitmaps because they are easier to work with.
        _listOfBitmaps.Append(bitmap)
    End Sub

    Public Sub ClearBitmaps()
        _listOfBitmaps.Clear()
    End Sub

    Public Sub RemoveBitmap(bitmap As Drawing.Bitmap)
        If _listOfBitmaps.Contains(bitmap) Then
            _listOfBitmaps.Remove(bitmap)
        End If
    End Sub

    Public Sub RemoveBitmapAt(index As Integer)
        If index > 0 AndAlso index <= _listOfBitmaps.Count() - 1 Then
            _listOfBitmaps.RemoveAt(index)
        Else
            Throw New IndexOutOfRangeException("Range must be within the bounds of the list of images.")
        End If
    End Sub
    
    Public Sub AddAllImages(images as IEnumerable(Of Drawing.Image))
        For Each image As Drawing.Image in images
            AddImage(image)
        Next image
    End Sub
    
    Public Sub AddAllBitmaps(bitmaps as IEnumerable(Of Drawing.Bitmap))
        _listOfBitmaps.AddRange(bitmaps)
    End Sub
    
    Public Function GetCollection() As List(Of Drawing.Bitmap)
        return _listOfBitmaps
    End Function
    
End Class