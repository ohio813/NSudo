<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormControl
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
        Me.GroupBoxControl = New System.Windows.Forms.GroupBox()
        Me.ButtonOpen = New System.Windows.Forms.Button()
        Me.ButtonOpenFolder = New System.Windows.Forms.Button()
        Me.ButtonFilter = New System.Windows.Forms.Button()
        Me.ButtonSaveFavorite = New System.Windows.Forms.Button()
        Me.ButtonJoin = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.RadioButtonNotCmd = New System.Windows.Forms.RadioButton()
        Me.ButtonShell = New System.Windows.Forms.Button()
        Me.RadioButtonCmdK = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCmdC = New System.Windows.Forms.RadioButton()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBoxTask = New System.Windows.Forms.ComboBox()
        Me.TextBoxPath = New System.Windows.Forms.TextBox()
        Me.TextBoxMoreArgs = New System.Windows.Forms.TextBox()
        Me.LabelArgP = New System.Windows.Forms.Label()
        Me.LabelArgU = New System.Windows.Forms.Label()
        Me.LabelMoreArgs = New System.Windows.Forms.Label()
        Me.LabelPath = New System.Windows.Forms.Label()
        Me.LabelArgM = New System.Windows.Forms.Label()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.GroupBoxControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxControl
        '
        Me.GroupBoxControl.Controls.Add(Me.ButtonOpen)
        Me.GroupBoxControl.Controls.Add(Me.ButtonOpenFolder)
        Me.GroupBoxControl.Controls.Add(Me.ButtonFilter)
        Me.GroupBoxControl.Controls.Add(Me.ButtonSaveFavorite)
        Me.GroupBoxControl.Controls.Add(Me.ButtonJoin)
        Me.GroupBoxControl.Controls.Add(Me.ButtonClear)
        Me.GroupBoxControl.Controls.Add(Me.RadioButtonNotCmd)
        Me.GroupBoxControl.Controls.Add(Me.ButtonShell)
        Me.GroupBoxControl.Controls.Add(Me.RadioButtonCmdK)
        Me.GroupBoxControl.Controls.Add(Me.RadioButtonCmdC)
        Me.GroupBoxControl.Controls.Add(Me.ComboBox2)
        Me.GroupBoxControl.Controls.Add(Me.ComboBox3)
        Me.GroupBoxControl.Controls.Add(Me.ComboBox4)
        Me.GroupBoxControl.Controls.Add(Me.ComboBoxTask)
        Me.GroupBoxControl.Controls.Add(Me.TextBoxPath)
        Me.GroupBoxControl.Controls.Add(Me.TextBoxMoreArgs)
        Me.GroupBoxControl.Controls.Add(Me.LabelArgP)
        Me.GroupBoxControl.Controls.Add(Me.LabelArgU)
        Me.GroupBoxControl.Controls.Add(Me.LabelMoreArgs)
        Me.GroupBoxControl.Controls.Add(Me.LabelPath)
        Me.GroupBoxControl.Controls.Add(Me.LabelArgM)
        Me.GroupBoxControl.Controls.Add(Me.LabelName)
        Me.GroupBoxControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxControl.Location = New System.Drawing.Point(0, 0)
        Me.GroupBoxControl.Name = "GroupBoxControl"
        Me.GroupBoxControl.Size = New System.Drawing.Size(448, 403)
        Me.GroupBoxControl.TabIndex = 5
        Me.GroupBoxControl.TabStop = False
        Me.GroupBoxControl.Text = "控制"
        '
        'ButtonOpen
        '
        Me.ButtonOpen.Location = New System.Drawing.Point(88, 93)
        Me.ButtonOpen.Name = "ButtonOpen"
        Me.ButtonOpen.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOpen.TabIndex = 8
        Me.ButtonOpen.Text = "打开"
        Me.ButtonOpen.UseVisualStyleBackColor = True
        '
        'ButtonOpenFolder
        '
        Me.ButtonOpenFolder.Location = New System.Drawing.Point(176, 93)
        Me.ButtonOpenFolder.Name = "ButtonOpenFolder"
        Me.ButtonOpenFolder.Size = New System.Drawing.Size(168, 23)
        Me.ButtonOpenFolder.TabIndex = 9
        Me.ButtonOpenFolder.Text = "打开文件夹"
        Me.ButtonOpenFolder.UseVisualStyleBackColor = True
        '
        'ButtonFilter
        '
        Me.ButtonFilter.Location = New System.Drawing.Point(357, 93)
        Me.ButtonFilter.Name = "ButtonFilter"
        Me.ButtonFilter.Size = New System.Drawing.Size(75, 23)
        Me.ButtonFilter.TabIndex = 10
        Me.ButtonFilter.Text = "筛选器"
        Me.ButtonFilter.UseVisualStyleBackColor = True
        '
        'ButtonSaveFavorite
        '
        Me.ButtonSaveFavorite.Location = New System.Drawing.Point(88, 357)
        Me.ButtonSaveFavorite.Name = "ButtonSaveFavorite"
        Me.ButtonSaveFavorite.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSaveFavorite.TabIndex = 11
        Me.ButtonSaveFavorite.Text = "加入收藏"
        Me.ButtonSaveFavorite.UseVisualStyleBackColor = True
        '
        'ButtonJoin
        '
        Me.ButtonJoin.Location = New System.Drawing.Point(177, 357)
        Me.ButtonJoin.Name = "ButtonJoin"
        Me.ButtonJoin.Size = New System.Drawing.Size(75, 23)
        Me.ButtonJoin.TabIndex = 12
        Me.ButtonJoin.Text = "加入队列"
        Me.ButtonJoin.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(266, 357)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClear.TabIndex = 13
        Me.ButtonClear.Text = "清空"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'RadioButtonNotCmd
        '
        Me.RadioButtonNotCmd.AutoSize = True
        Me.RadioButtonNotCmd.Location = New System.Drawing.Point(345, 132)
        Me.RadioButtonNotCmd.Name = "RadioButtonNotCmd"
        Me.RadioButtonNotCmd.Size = New System.Drawing.Size(87, 21)
        Me.RadioButtonNotCmd.TabIndex = 20
        Me.RadioButtonNotCmd.TabStop = True
        Me.RadioButtonNotCmd.Text = "不使用cmd"
        Me.RadioButtonNotCmd.UseVisualStyleBackColor = True
        '
        'ButtonShell
        '
        Me.ButtonShell.Location = New System.Drawing.Point(355, 357)
        Me.ButtonShell.Name = "ButtonShell"
        Me.ButtonShell.Size = New System.Drawing.Size(75, 23)
        Me.ButtonShell.TabIndex = 14
        Me.ButtonShell.Text = "直接运行"
        Me.ButtonShell.UseVisualStyleBackColor = True
        '
        'RadioButtonCmdK
        '
        Me.RadioButtonCmdK.AutoSize = True
        Me.RadioButtonCmdK.Location = New System.Drawing.Point(345, 174)
        Me.RadioButtonCmdK.Name = "RadioButtonCmdK"
        Me.RadioButtonCmdK.Size = New System.Drawing.Size(66, 21)
        Me.RadioButtonCmdK.TabIndex = 18
        Me.RadioButtonCmdK.TabStop = True
        Me.RadioButtonCmdK.Text = "cmd /c"
        Me.RadioButtonCmdK.UseVisualStyleBackColor = True
        '
        'RadioButtonCmdC
        '
        Me.RadioButtonCmdC.AutoSize = True
        Me.RadioButtonCmdC.Location = New System.Drawing.Point(345, 216)
        Me.RadioButtonCmdC.Name = "RadioButtonCmdC"
        Me.RadioButtonCmdC.Size = New System.Drawing.Size(67, 21)
        Me.RadioButtonCmdC.TabIndex = 19
        Me.RadioButtonCmdC.TabStop = True
        Me.RadioButtonCmdC.Text = "cmd /k"
        Me.RadioButtonCmdC.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(88, 216)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(228, 25)
        Me.ComboBox2.TabIndex = 9
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(88, 175)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(228, 25)
        Me.ComboBox3.TabIndex = 10
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(88, 131)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(228, 25)
        Me.ComboBox4.TabIndex = 11
        '
        'ComboBoxTask
        '
        Me.ComboBoxTask.FormattingEnabled = True
        Me.ComboBoxTask.Location = New System.Drawing.Point(88, 29)
        Me.ComboBoxTask.Name = "ComboBoxTask"
        Me.ComboBoxTask.Size = New System.Drawing.Size(343, 25)
        Me.ComboBoxTask.TabIndex = 10
        '
        'TextBoxPath
        '
        Me.TextBoxPath.Location = New System.Drawing.Point(88, 61)
        Me.TextBoxPath.Name = "TextBoxPath"
        Me.TextBoxPath.Size = New System.Drawing.Size(343, 23)
        Me.TextBoxPath.TabIndex = 9
        '
        'TextBoxMoreArgs
        '
        Me.TextBoxMoreArgs.Location = New System.Drawing.Point(88, 261)
        Me.TextBoxMoreArgs.Multiline = True
        Me.TextBoxMoreArgs.Name = "TextBoxMoreArgs"
        Me.TextBoxMoreArgs.Size = New System.Drawing.Size(343, 77)
        Me.TextBoxMoreArgs.TabIndex = 7
        '
        'LabelArgP
        '
        Me.LabelArgP.AutoSize = True
        Me.LabelArgP.Location = New System.Drawing.Point(23, 178)
        Me.LabelArgP.Name = "LabelArgP"
        Me.LabelArgP.Size = New System.Drawing.Size(35, 17)
        Me.LabelArgP.TabIndex = 6
        Me.LabelArgP.Text = "特权:"
        '
        'LabelArgU
        '
        Me.LabelArgU.AutoSize = True
        Me.LabelArgU.Location = New System.Drawing.Point(23, 134)
        Me.LabelArgU.Name = "LabelArgU"
        Me.LabelArgU.Size = New System.Drawing.Size(35, 17)
        Me.LabelArgU.TabIndex = 5
        Me.LabelArgU.Text = "用户:"
        '
        'LabelMoreArgs
        '
        Me.LabelMoreArgs.AutoSize = True
        Me.LabelMoreArgs.Location = New System.Drawing.Point(23, 261)
        Me.LabelMoreArgs.Name = "LabelMoreArgs"
        Me.LabelMoreArgs.Size = New System.Drawing.Size(59, 17)
        Me.LabelMoreArgs.TabIndex = 4
        Me.LabelMoreArgs.Text = "附加参数:"
        '
        'LabelPath
        '
        Me.LabelPath.AutoSize = True
        Me.LabelPath.Location = New System.Drawing.Point(23, 64)
        Me.LabelPath.Name = "LabelPath"
        Me.LabelPath.Size = New System.Drawing.Size(35, 17)
        Me.LabelPath.TabIndex = 2
        Me.LabelPath.Text = "路径:"
        '
        'LabelArgM
        '
        Me.LabelArgM.AutoSize = True
        Me.LabelArgM.Location = New System.Drawing.Point(23, 219)
        Me.LabelArgM.Name = "LabelArgM"
        Me.LabelArgM.Size = New System.Drawing.Size(47, 17)
        Me.LabelArgM.TabIndex = 1
        Me.LabelArgM.Text = "完整性:"
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Location = New System.Drawing.Point(23, 32)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(47, 17)
        Me.LabelName.TabIndex = 0
        Me.LabelName.Text = "任务名:"
        '
        'FormControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 403)
        Me.Controls.Add(Me.GroupBoxControl)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormControl"
        Me.Text = "FormControl"
        Me.GroupBoxControl.ResumeLayout(False)
        Me.GroupBoxControl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxControl As GroupBox
    Friend WithEvents ButtonOpen As Button
    Friend WithEvents ButtonOpenFolder As Button
    Friend WithEvents ButtonFilter As Button
    Friend WithEvents ButtonSaveFavorite As Button
    Friend WithEvents ButtonJoin As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents RadioButtonNotCmd As RadioButton
    Friend WithEvents ButtonShell As Button
    Friend WithEvents RadioButtonCmdK As RadioButton
    Friend WithEvents RadioButtonCmdC As RadioButton
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBoxTask As ComboBox
    Friend WithEvents TextBoxPath As TextBox
    Friend WithEvents TextBoxMoreArgs As TextBox
    Friend WithEvents LabelArgP As Label
    Friend WithEvents LabelArgU As Label
    Friend WithEvents LabelMoreArgs As Label
    Friend WithEvents LabelPath As Label
    Friend WithEvents LabelArgM As Label
    Friend WithEvents LabelName As Label
End Class
