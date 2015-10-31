Imports Updater
Imports NSudo.NET.ClassMain
Imports System.IO

Public Class FormMain
    Public Info As InfoText = New InfoText(RichTextBoxMessage)
    Public IsFolder As Boolean = False
    Public Filter As ArrayList
    Private Sub ButtonJoin_Click(sender As Object, e As EventArgs) Handles ButtonJoin.Click
        If TextBoxPath.Text = "" And TextBoxMoreArgs.Text = "" Then
            Info.Show("路径与附加参数不能同时为空！", "Error")
        End If
        If IsFolder = True Then
            If Directory.Exists(TextBoxPath.Text) Then
                Dim dirs() As String = Directory.GetFiles(TextBoxPath.Text, "*.exe")
                For Each FilePath As String In dirs
                Next
                dirs = Directory.GetFiles(TextBoxPath.Text, "*.bat")
                For Each FilePath As String In dirs
                Next
                dirs = Directory.GetFiles(TextBoxPath.Text, "*.cmd")
                For Each FilePath As String In dirs
                Next
            Else
                Info.Show("目录不存在！", "Warning")
            End If
        Else
            If File.Exists(TextBoxPath.Text) Then
            Else
                Info.Show("可执行文件不存在！", "Warning")
            End If
        End If
    End Sub

    Private Sub ButtonSaveFavorite_Click(sender As Object, e As EventArgs) Handles ButtonSaveFavorite.Click

    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click

    End Sub

    Private Sub ButtonShell_Click(sender As Object, e As EventArgs) Handles ButtonShell.Click
    End Sub

    Private Sub ButtonFilter_Click(sender As Object, e As EventArgs) Handles ButtonFilter.Click
        Dim FormFilter As FormFilter = New FormFilter
        FormFilter.ShowDialog()
    End Sub

    Private Sub 保存配置文件ToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBoxMessage.ReadOnly = True
        ButtonFilter.Enabled = False

        Info.Show("应用程序正常初始化...")
        Info.Show("操作系统:" & My.Computer.Info.OSFullName)
        Info.Show("是否64位进程:" & Environment.Is64BitProcess)
    End Sub

    Private Sub 工具TToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 工具TToolStripMenuItem.Click

    End Sub

    Private Sub 储存日志文件LToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 储存日志文件LToolStripMenuItem.Click
        Info.SaveLogFile(My.Application.Info.DirectoryPath & "\Data\Log")
    End Sub

    Private Sub 储存日志文件LToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 储存日志文件LToolStripMenuItem1.Click
        Info.SaveLogFile(My.Application.Info.DirectoryPath & "\Data\Log")
    End Sub

    Private Sub ButtonUpdateNow_Click(sender As Object, e As EventArgs) Handles ButtonUpdateNow.Click
        Dim Updater As CheckUpdateForm = New CheckUpdateForm
        Updater.Show()
    End Sub

    Private Sub ButtonOpen_Click(sender As Object, e As EventArgs) Handles ButtonOpen.Click
        Dim OpenFileDialogMain As OpenFileDialog = New OpenFileDialog
        With OpenFileDialogMain
            .Filter = "应用程序(*.exe)|*.exe|Windows命令脚本(*.cmd)|*.cmd|批处理文件(*.bat)|*.bat|可执行文件(*.exe;*.cmd;*.bat)|*.exe;*.cmd;*.bat|所有文件(*.*)|*.*"
            .FilterIndex = 4
            .Title = "选择一个文件"
        End With
        If OpenFileDialogMain.ShowDialog = DialogResult.OK Then
            TextBoxPath.Text = OpenFileDialogMain.FileName
            Info.Show(（"打开文件" & """" & OpenFileDialogMain.FileName & """"）, InfoType.Message)
            IsFolder = False
            TextBoxMoreArgs.Enabled = True
            ButtonShell.Enabled = True
            ButtonFilter.Enabled = False
        End If
    End Sub

    Private Sub ButtonOpenFolder_Click(sender As Object, e As EventArgs) Handles ButtonOpenFolder.Click
        Dim FolderBrowserDialogMain As FolderBrowserDialog = New FolderBrowserDialog
        With FolderBrowserDialogMain
        End With
        If FolderBrowserDialogMain.ShowDialog = DialogResult.OK Then
            TextBoxPath.Text = FolderBrowserDialogMain.SelectedPath
            Info.Show(（"打开文件夹" & """" & FolderBrowserDialogMain.SelectedPath & """"）, InfoType.Message)
            IsFolder = True
            TextBoxMoreArgs.Enabled = False
            ButtonShell.Enabled = False
            ButtonFilter.Enabled = True
        End If
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
