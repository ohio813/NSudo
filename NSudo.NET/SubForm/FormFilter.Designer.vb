<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFilter
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
        Me.GroupBoxFilter = New System.Windows.Forms.GroupBox()
        Me.LabelFilter = New System.Windows.Forms.Label()
        Me.TextBoxFilter = New System.Windows.Forms.TextBox()
        Me.RadioButtonUserDefined = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCmdBat = New System.Windows.Forms.RadioButton()
        Me.RadioButtonExe = New System.Windows.Forms.RadioButton()
        Me.CheckBoxUseDefaultFilter = New System.Windows.Forms.CheckBox()
        Me.ButtonO = New System.Windows.Forms.Button()
        Me.ButtonC = New System.Windows.Forms.Button()
        Me.GroupBoxFilter.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxFilter
        '
        Me.GroupBoxFilter.Controls.Add(Me.LabelFilter)
        Me.GroupBoxFilter.Controls.Add(Me.TextBoxFilter)
        Me.GroupBoxFilter.Controls.Add(Me.RadioButtonUserDefined)
        Me.GroupBoxFilter.Controls.Add(Me.RadioButtonCmdBat)
        Me.GroupBoxFilter.Controls.Add(Me.RadioButtonExe)
        Me.GroupBoxFilter.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBoxFilter.Location = New System.Drawing.Point(12, 39)
        Me.GroupBoxFilter.Name = "GroupBoxFilter"
        Me.GroupBoxFilter.Size = New System.Drawing.Size(373, 248)
        Me.GroupBoxFilter.TabIndex = 0
        Me.GroupBoxFilter.TabStop = False
        '
        'LabelFilter
        '
        Me.LabelFilter.AutoEllipsis = True
        Me.LabelFilter.AutoSize = True
        Me.LabelFilter.Location = New System.Drawing.Point(21, 204)
        Me.LabelFilter.Name = "LabelFilter"
        Me.LabelFilter.Size = New System.Drawing.Size(275, 34)
        Me.LabelFilter.TabIndex = 5
        Me.LabelFilter.Text = "筛选器可以自动选取文件夹中特定的文件格式。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "请按照""*.*;*.*""的格式添加筛选项，可使用通配符。"
        '
        'TextBoxFilter
        '
        Me.TextBoxFilter.Location = New System.Drawing.Point(24, 97)
        Me.TextBoxFilter.Multiline = True
        Me.TextBoxFilter.Name = "TextBoxFilter"
        Me.TextBoxFilter.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxFilter.Size = New System.Drawing.Size(326, 91)
        Me.TextBoxFilter.TabIndex = 4
        '
        'RadioButtonUserDefined
        '
        Me.RadioButtonUserDefined.AutoSize = True
        Me.RadioButtonUserDefined.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RadioButtonUserDefined.Location = New System.Drawing.Point(6, 64)
        Me.RadioButtonUserDefined.Name = "RadioButtonUserDefined"
        Me.RadioButtonUserDefined.Size = New System.Drawing.Size(62, 21)
        Me.RadioButtonUserDefined.TabIndex = 1
        Me.RadioButtonUserDefined.TabStop = True
        Me.RadioButtonUserDefined.Text = "自定义"
        Me.RadioButtonUserDefined.UseVisualStyleBackColor = True
        '
        'RadioButtonCmdBat
        '
        Me.RadioButtonCmdBat.AutoSize = True
        Me.RadioButtonCmdBat.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RadioButtonCmdBat.Location = New System.Drawing.Point(6, 42)
        Me.RadioButtonCmdBat.Name = "RadioButtonCmdBat"
        Me.RadioButtonCmdBat.Size = New System.Drawing.Size(270, 21)
        Me.RadioButtonCmdBat.TabIndex = 2
        Me.RadioButtonCmdBat.TabStop = True
        Me.RadioButtonCmdBat.Text = "Windows命令脚本及批处理文件(*.cmd;*.bat)"
        Me.RadioButtonCmdBat.UseVisualStyleBackColor = True
        '
        'RadioButtonExe
        '
        Me.RadioButtonExe.AutoSize = True
        Me.RadioButtonExe.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RadioButtonExe.Location = New System.Drawing.Point(6, 20)
        Me.RadioButtonExe.Name = "RadioButtonExe"
        Me.RadioButtonExe.Size = New System.Drawing.Size(122, 21)
        Me.RadioButtonExe.TabIndex = 3
        Me.RadioButtonExe.TabStop = True
        Me.RadioButtonExe.Text = "可执行文件(*.exe)"
        Me.RadioButtonExe.UseVisualStyleBackColor = True
        '
        'CheckBoxUseDefaultFilter
        '
        Me.CheckBoxUseDefaultFilter.AutoSize = True
        Me.CheckBoxUseDefaultFilter.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CheckBoxUseDefaultFilter.Location = New System.Drawing.Point(18, 12)
        Me.CheckBoxUseDefaultFilter.Name = "CheckBoxUseDefaultFilter"
        Me.CheckBoxUseDefaultFilter.Size = New System.Drawing.Size(201, 21)
        Me.CheckBoxUseDefaultFilter.TabIndex = 0
        Me.CheckBoxUseDefaultFilter.Text = "使用默认筛选(*.exe;*.bat;*.cmd)"
        Me.CheckBoxUseDefaultFilter.UseVisualStyleBackColor = True
        '
        'ButtonO
        '
        Me.ButtonO.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.ButtonO.Location = New System.Drawing.Point(213, 298)
        Me.ButtonO.Name = "ButtonO"
        Me.ButtonO.Size = New System.Drawing.Size(75, 23)
        Me.ButtonO.TabIndex = 1
        Me.ButtonO.Text = "确认"
        Me.ButtonO.UseVisualStyleBackColor = True
        '
        'ButtonC
        '
        Me.ButtonC.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.ButtonC.Location = New System.Drawing.Point(310, 298)
        Me.ButtonC.Name = "ButtonC"
        Me.ButtonC.Size = New System.Drawing.Size(75, 23)
        Me.ButtonC.TabIndex = 2
        Me.ButtonC.Text = "取消"
        Me.ButtonC.UseVisualStyleBackColor = True
        '
        'FormFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 333)
        Me.Controls.Add(Me.ButtonC)
        Me.Controls.Add(Me.ButtonO)
        Me.Controls.Add(Me.CheckBoxUseDefaultFilter)
        Me.Controls.Add(Me.GroupBoxFilter)
        Me.Name = "FormFilter"
        Me.Text = "文件筛选器"
        Me.GroupBoxFilter.ResumeLayout(False)
        Me.GroupBoxFilter.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxFilter As GroupBox
    Friend WithEvents RadioButtonUserDefined As RadioButton
    Friend WithEvents RadioButtonCmdBat As RadioButton
    Friend WithEvents RadioButtonExe As RadioButton
    Friend WithEvents CheckBoxUseDefaultFilter As CheckBox
    Friend WithEvents TextBoxFilter As TextBox
    Friend WithEvents LabelFilter As Label
    Friend WithEvents ButtonO As Button
    Friend WithEvents ButtonC As Button
End Class
