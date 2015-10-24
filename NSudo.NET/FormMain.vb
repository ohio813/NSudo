Imports Updater
Imports NSudo.NET.ClassMain

Public Class FormMain
    Public Filter As ArrayList



    Private Sub ButtonFilter_Click(sender As Object, e As EventArgs)
        Dim FormFilter As FormFilter = New FormFilter
        FormFilter.ShowDialog()
    End Sub

    Private Sub 保存配置文件ToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormInput.RichTextBoxMessage.ReadOnly = True
        FormControl.ButtonFilter.Enabled = False
    End Sub

    Private Sub 工具TToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 工具TToolStripMenuItem.Click

    End Sub

    Private Sub 储存日志文件LToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 储存日志文件LToolStripMenuItem.Click
        FormInput.Info.SaveLogFile(My.Application.Info.DirectoryPath & "\Data\Log")
    End Sub

    Private Sub 储存日志文件LToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 储存日志文件LToolStripMenuItem1.Click
        FormInput.Info.SaveLogFile(My.Application.Info.DirectoryPath & "\Data\Log")
    End Sub

    Private Sub 剪切TToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 剪切TToolStripMenuItem.Click
        Cut()
    End Sub

    Private Sub 复制ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 复制ToolStripMenuItem.Click
        Copy()
    End Sub

    Private Sub 粘贴PToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 粘贴PToolStripMenuItem.Click
        Paste()
    End Sub

    Private Sub 删除ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 删除ToolStripMenuItem.Click
        Delete()
    End Sub

    Private Sub 全选AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 全选AToolStripMenuItem.Click
        SelectAll()
    End Sub

    Private Sub 撤销ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 撤销ToolStripMenuItem.Click
        Undo()
    End Sub
End Class
