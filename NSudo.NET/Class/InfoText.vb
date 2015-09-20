
Imports System.IO
Public Enum Info
    Message = 0
    ImportantMessage
    Warning
    [Error]
    FatalError
End Enum
Public Class InfoText
    Private RichTextInfo As RichTextBox
    Private _Color = Color.Green
    Private _NormalText As String = "#" & DateTime.Now & "#"
    Private Text As ArrayList = New ArrayList
    Sub New(ByVal RichTextBoxInfo As RichTextBox)
        RichTextInfo = RichTextBoxInfo
    End Sub
    Public Sub Show(ByVal _Text As String, Optional ByVal _Type As Info = Info.Message)
        _NormalText = ""
        _NormalText = "#" & DateTime.Now & "#"
        Select Case _Type
            Case Info.Message
                _NormalText &= "一般信息: "
                _Color = Color.Green
            Case Info.ImportantMessage
                _NormalText &= "重要信息: "
                _Color = Color.Blue
            Case Info.Warning
                _NormalText &= "警告:"
                _Color = Color.OrangeRed
            Case Info.Error
                _NormalText &= "错误: "
                _Color = Color.Red
                Beep()
            Case Info.FatalError
                Beep()
                SaveLogFile(My.Application.Info.DirectoryPath)
        End Select
        FormMain.RichTextBoxMessage.SelectionColor = _Color
        FormMain.RichTextBoxMessage.AppendText(_NormalText & _Text & vbNewLine)
        Text.Add(_NormalText & _Text)
    End Sub
    Public Function SaveLogFile(Optional ByVal _Path As String = "C:\NSudo.NETLog")
        Show("尝试保存日志文件...")
        Dim _Temp As String = _Path & "\" & Replace(Replace(Replace(DateTime.Now, ":", ""), " ", ""), "/", "") & ".log"
        Dim sw As StreamWriter
        Try
            If Not Directory.Exists(_Path) Then
                Directory.CreateDirectory(_Path)
            End If
            If File.Exists(_Temp) Then
                File.Delete(_Temp)
            End If
            sw = File.CreateText(_Temp)
            For Each i As String In Text
                sw.WriteLine(i)
            Next
            sw.WriteLine("================================================================")
            sw.WriteLine("==================以下内容由NSudo.NET自动生成===================")
            sw.WriteLine("================================================================")
            sw.WriteLine(My.Computer.Info.OSFullName)
            sw.WriteLine(My.Computer.Info.AvailablePhysicalMemory / (1024 ^ 2))
            sw.WriteLine(My.Computer.Info.AvailableVirtualMemory / (1024 ^ 2))
            sw.WriteLine(My.Computer.Info.TotalPhysicalMemory / (1024 ^ 2))
            sw.WriteLine(My.Computer.Info.TotalVirtualMemory / (1024 ^ 2))
            sw.WriteLine(My.User.Name)
            sw.WriteLine("64位系统:" & Environment.Is64BitOperatingSystem.ToString)
            sw.WriteLine("================================================================")
            sw.WriteLine("================================================================")
            sw.WriteLine("================================================================")
            Show("成功保存文件至""" & _Temp & """", Info.ImportantMessage)
        Catch ex As Exception
            Show(ex.Message, Info.Error)
            Return False
        Finally
            sw.Close()
            sw.Dispose()
        End Try
        Return True
    End Function
End Class
