Imports Updater
Public Class FormSettings
    Private Sub FormSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ButtonUpdateNow_Click(sender As Object, e As EventArgs)
        Dim Updater As CheckUpdateForm = New CheckUpdateForm
        Updater.Show()
    End Sub
End Class