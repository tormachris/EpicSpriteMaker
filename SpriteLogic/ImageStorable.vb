Public Class ImageStorable
    Private imagestore as ImageStore

    Public Sub SetImageStore(imgstore As ImageStore)
        imagestore=imgstore
    End Sub
    
    Protected Function GetImageStore() As ImageStore
        return imagestore
    End Function
    
End Class