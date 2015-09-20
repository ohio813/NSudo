Imports Updater
Public Class FormMain
    Public Info As InfoText = New InfoText(RichTextBoxMessage)

    Private Sub ButtonJoin_Click(sender As Object, e As EventArgs) Handles ButtonJoin.Click

    End Sub

    Private Sub ButtonSaveFavorite_Click(sender As Object, e As EventArgs) Handles ButtonSaveFavorite.Click

    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click

    End Sub

    Private Sub ButtonShell_Click(sender As Object, e As EventArgs) Handles ButtonShell.Click

    End Sub

    Private Sub ButtonFilter_Click(sender As Object, e As EventArgs) Handles ButtonFilter.Click

    End Sub

    Private Sub 保存配置文件ToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBoxMessage.ReadOnly = True
        Info.Show("应用程序正常初始化...")
        Info.Show("操作系统:" & My.Computer.Info.OSFullName)
        Info.Show("是否64位进程:" & Environment.Is64BitProcess)
    End Sub

    Private Sub 工具TToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 工具TToolStripMenuItem.Click

    End Sub

    Private Sub 储存日志文件LToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 储存日志文件LToolStripMenuItem.Click
        Info.SaveLogFile(My.Application.Info.DirectoryPath & "\NSudo.NETLog")
    End Sub

    Private Sub 储存日志文件LToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 储存日志文件LToolStripMenuItem1.Click
        Info.SaveLogFile(My.Application.Info.DirectoryPath & "\NSudo.NETLog")
    End Sub

    Private Sub ButtonUpdateNow_Click(sender As Object, e As EventArgs) Handles ButtonUpdateNow.Click
        Dim Updater As CheckUpdateForm = New CheckUpdateForm
        Updater.Show()
    End Sub
End Class
