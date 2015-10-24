<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormView
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
        Me.TreeViewMain = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'TreeViewMain
        '
        Me.TreeViewMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeViewMain.Location = New System.Drawing.Point(0, 0)
        Me.TreeViewMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TreeViewMain.Name = "TreeViewMain"
        Me.TreeViewMain.Size = New System.Drawing.Size(341, 688)
        Me.TreeViewMain.TabIndex = 1
        '
        'FormView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 688)
        Me.Controls.Add(Me.TreeViewMain)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormView"
        Me.Text = "FormView"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TreeViewMain As TreeView
End Class
