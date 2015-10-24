Imports System.IO


Public Class FormControl
    Public IsFolder As Boolean = False
    Private Sub ButtonJoin_Click(sender As Object, e As EventArgs)
        If TextBoxPath.Text = "" And TextBoxMoreArgs.Text = "" Then
            FormInput.Info.Show("路径与附加参数不能同时为空！", "Error")
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
                FormInput.Info.Show("目录不存在！", "Warning")
            End If
        Else
            If File.Exists(TextBoxPath.Text) Then
            Else
                FormInput.Info.Show("可执行文件不存在！", "Warning")
            End If
        End If
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
            FormInput.Info.Show(（"打开文件" & """" & OpenFileDialogMain.FileName & """"）, InfoType.Message)
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
            FormInput.Info.Show(（"打开文件夹" & """" & FolderBrowserDialogMain.SelectedPath & """"）, InfoType.Message)
            IsFolder = True
            TextBoxMoreArgs.Enabled = False
            ButtonShell.Enabled = False
            ButtonFilter.Enabled = True
        End If
    End Sub
End Class