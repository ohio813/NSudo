Imports System.IO


Public Class FormFilter
    Private Sub GroupBoxFilter_Enter(sender As Object, e As EventArgs) Handles GroupBoxFilter.Enter

    End Sub

    Private Sub ButtonC_Click(sender As Object, e As EventArgs) Handles ButtonC.Click
        Me.Close()
    End Sub

    Private Sub FormFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBoxUseDefaultFilter.Checked = True
        Dim sr As StreamReader
        If File.Exists(My.Application.Info.DirectoryPath & "\Data\Config\Filter.ini") Then
            sr = File.OpenText(My.Application.Info.DirectoryPath & "\Data\Config\Filter.ini")
        Else
            Dim sw As StreamWriter
            sw = File.CreateText(My.Application.Info.DirectoryPath & "\Data\Config\Filter.ini")
            sw.Write("*.exe;*.cmd;*.bat")
            sw.Dispose()
            sr = File.OpenText(My.Application.Info.DirectoryPath & "\Data\Config\Filter.ini")
        End If
        TextBoxFilter.Text = sr.ReadToEnd
        For Each i As Control In GroupBoxFilter.Controls
            i.Enabled = False
        Next
        RadioButtonExe.Select()
    End Sub

    Private Sub CheckBoxUseDefaultFilter_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxUseDefaultFilter.CheckedChanged
        If CheckBoxUseDefaultFilter.Checked = True Then
            For Each i As Control In GroupBoxFilter.Controls
                i.Enabled = False
            Next
        ElseIf CheckBoxUseDefaultFilter.Checked = False
            For Each i As Control In GroupBoxFilter.Controls
                i.Enabled = True
            Next
        End If
    End Sub

    Private Sub ButtonO_Click(sender As Object, e As EventArgs) Handles ButtonO.Click

    End Sub
End Class