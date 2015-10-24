<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFavorite
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListViewFavorite = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'ListViewFavorite
        '
        Me.ListViewFavorite.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewFavorite.Location = New System.Drawing.Point(0, 0)
        Me.ListViewFavorite.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListViewFavorite.Name = "ListViewFavorite"
        Me.ListViewFavorite.Size = New System.Drawing.Size(666, 449)
        Me.ListViewFavorite.TabIndex = 7
        Me.ListViewFavorite.UseCompatibleStateImageBehavior = False
        '
        'FormFavorite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 449)
        Me.Controls.Add(Me.ListViewFavorite)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormFavorite"
        Me.Text = "FormFavorite"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListViewFavorite As ListView
End Class
