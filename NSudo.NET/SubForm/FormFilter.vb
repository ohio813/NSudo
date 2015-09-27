Public Class FormFilter
    Private Sub GroupBoxFilter_Enter(sender As Object, e As EventArgs) Handles GroupBoxFilter.Enter

    End Sub

    Private Sub ButtonC_Click(sender As Object, e As EventArgs) Handles ButtonC.Click
        Me.Close()
    End Sub

    Private Sub FormFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBoxUseDefaultFilter.Checked = True
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
End Class