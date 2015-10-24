Public Class FormInput
    Public Info As InfoText = New InfoText(RichTextBoxMessage)
    Private Sub FormInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Info.Show("应用程序正常初始化...")
        Info.Show("操作系统:" & My.Computer.Info.OSFullName)
        Info.Show("是否64位进程:" & Environment.Is64BitProcess)
    End Sub
End Class