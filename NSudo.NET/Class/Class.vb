Public Class ClassMain
    Private Sub New()
    End Sub
    Shared Sub Copy()
        If TypeOf FormMain.ActiveControl Is TextBox Then
            CType(FormMain.ActiveControl, TextBox).Copy()
        End If
    End Sub
    Shared Sub Paste()
        If TypeOf FormMain.ActiveControl Is TextBox Then
            CType(FormMain.ActiveControl, TextBox).Paste()
        End If
    End Sub
    Shared Sub Cut()
        If TypeOf FormMain.ActiveControl Is TextBox Then
            CType(FormMain.ActiveControl, TextBox).Cut()
        End If
    End Sub
    Shared Sub Undo()
        If TypeOf FormMain.ActiveControl Is TextBox Then
            CType(FormMain.ActiveControl, TextBox).Undo()
        End If
    End Sub
    Shared Sub SelectAll()
        If TypeOf FormMain.ActiveControl Is TextBox Then
            CType(FormMain.ActiveControl, TextBox).SelectAll()
        End If
    End Sub
    Shared Sub Delete()
        If TypeOf FormMain.ActiveControl Is TextBox Then
            CType(FormMain.ActiveControl, TextBox).Clear()
        End If
    End Sub
End Class
