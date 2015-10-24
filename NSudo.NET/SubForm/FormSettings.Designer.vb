<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSettings
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
        Me.ButtonUpdateNow = New System.Windows.Forms.Button()
        Me.ButtonSaveSettings = New System.Windows.Forms.Button()
        Me.LabelLoadMode = New System.Windows.Forms.Label()
        Me.LabelUpdateServer = New System.Windows.Forms.Label()
        Me.ButtonEditPlugin = New System.Windows.Forms.Button()
        Me.ButtonEditCron = New System.Windows.Forms.Button()
        Me.ButtonEditDefaultSearchLocation = New System.Windows.Forms.Button()
        Me.ComboBoxUpdateServer = New System.Windows.Forms.ComboBox()
        Me.ComboBoxLoadMode = New System.Windows.Forms.ComboBox()
        Me.CheckBoxCron = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAutoUpdate = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDefaultSearchLocation = New System.Windows.Forms.CheckBox()
        Me.CheckBoxBlockMode = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAutoSaveSettings = New System.Windows.Forms.CheckBox()
        Me.CheckBoxUsePlugin = New System.Windows.Forms.CheckBox()
        Me.CheckBoxBackground = New System.Windows.Forms.CheckBox()
        Me.GroupBoxSettings = New System.Windows.Forms.GroupBox()
        Me.CheckBoxUsedTime = New System.Windows.Forms.CheckBox()
        Me.GroupBoxSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonUpdateNow
        '
        Me.ButtonUpdateNow.Location = New System.Drawing.Point(187, 231)
        Me.ButtonUpdateNow.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonUpdateNow.Name = "ButtonUpdateNow"
        Me.ButtonUpdateNow.Size = New System.Drawing.Size(87, 33)
        Me.ButtonUpdateNow.TabIndex = 27
        Me.ButtonUpdateNow.Text = "现在更新"
        Me.ButtonUpdateNow.UseVisualStyleBackColor = True
        '
        'ButtonSaveSettings
        '
        Me.ButtonSaveSettings.Location = New System.Drawing.Point(187, 183)
        Me.ButtonSaveSettings.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonSaveSettings.Name = "ButtonSaveSettings"
        Me.ButtonSaveSettings.Size = New System.Drawing.Size(87, 33)
        Me.ButtonSaveSettings.TabIndex = 26
        Me.ButtonSaveSettings.Text = "现在保存..."
        Me.ButtonSaveSettings.UseVisualStyleBackColor = True
        '
        'LabelLoadMode
        '
        Me.LabelLoadMode.AutoSize = True
        Me.LabelLoadMode.Location = New System.Drawing.Point(37, 506)
        Me.LabelLoadMode.Name = "LabelLoadMode"
        Me.LabelLoadMode.Size = New System.Drawing.Size(59, 17)
        Me.LabelLoadMode.TabIndex = 25
        Me.LabelLoadMode.Text = "初始模式:"
        '
        'LabelUpdateServer
        '
        Me.LabelUpdateServer.AutoSize = True
        Me.LabelUpdateServer.Location = New System.Drawing.Point(37, 289)
        Me.LabelUpdateServer.Name = "LabelUpdateServer"
        Me.LabelUpdateServer.Size = New System.Drawing.Size(71, 17)
        Me.LabelUpdateServer.TabIndex = 24
        Me.LabelUpdateServer.Text = "更新服务器:"
        '
        'ButtonEditPlugin
        '
        Me.ButtonEditPlugin.Location = New System.Drawing.Point(187, 341)
        Me.ButtonEditPlugin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonEditPlugin.Name = "ButtonEditPlugin"
        Me.ButtonEditPlugin.Size = New System.Drawing.Size(87, 33)
        Me.ButtonEditPlugin.TabIndex = 23
        Me.ButtonEditPlugin.Text = "编辑..."
        Me.ButtonEditPlugin.UseVisualStyleBackColor = True
        '
        'ButtonEditCron
        '
        Me.ButtonEditCron.Location = New System.Drawing.Point(187, 132)
        Me.ButtonEditCron.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonEditCron.Name = "ButtonEditCron"
        Me.ButtonEditCron.Size = New System.Drawing.Size(87, 33)
        Me.ButtonEditCron.TabIndex = 22
        Me.ButtonEditCron.Text = "编辑..."
        Me.ButtonEditCron.UseVisualStyleBackColor = True
        '
        'ButtonEditDefaultSearchLocation
        '
        Me.ButtonEditDefaultSearchLocation.Location = New System.Drawing.Point(187, 86)
        Me.ButtonEditDefaultSearchLocation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonEditDefaultSearchLocation.Name = "ButtonEditDefaultSearchLocation"
        Me.ButtonEditDefaultSearchLocation.Size = New System.Drawing.Size(87, 33)
        Me.ButtonEditDefaultSearchLocation.TabIndex = 21
        Me.ButtonEditDefaultSearchLocation.Text = "编辑..."
        Me.ButtonEditDefaultSearchLocation.UseVisualStyleBackColor = True
        '
        'ComboBoxUpdateServer
        '
        Me.ComboBoxUpdateServer.FormattingEnabled = True
        Me.ComboBoxUpdateServer.Location = New System.Drawing.Point(187, 285)
        Me.ComboBoxUpdateServer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxUpdateServer.Name = "ComboBoxUpdateServer"
        Me.ComboBoxUpdateServer.Size = New System.Drawing.Size(140, 25)
        Me.ComboBoxUpdateServer.TabIndex = 17
        '
        'ComboBoxLoadMode
        '
        Me.ComboBoxLoadMode.FormattingEnabled = True
        Me.ComboBoxLoadMode.Location = New System.Drawing.Point(187, 494)
        Me.ComboBoxLoadMode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxLoadMode.Name = "ComboBoxLoadMode"
        Me.ComboBoxLoadMode.Size = New System.Drawing.Size(140, 25)
        Me.ComboBoxLoadMode.TabIndex = 16
        '
        'CheckBoxCron
        '
        Me.CheckBoxCron.AutoSize = True
        Me.CheckBoxCron.Location = New System.Drawing.Point(19, 137)
        Me.CheckBoxCron.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxCron.Name = "CheckBoxCron"
        Me.CheckBoxCron.Size = New System.Drawing.Size(75, 21)
        Me.CheckBoxCron.TabIndex = 15
        Me.CheckBoxCron.Text = "计划任务"
        Me.CheckBoxCron.UseVisualStyleBackColor = True
        '
        'CheckBoxAutoUpdate
        '
        Me.CheckBoxAutoUpdate.AutoSize = True
        Me.CheckBoxAutoUpdate.Location = New System.Drawing.Point(19, 234)
        Me.CheckBoxAutoUpdate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxAutoUpdate.Name = "CheckBoxAutoUpdate"
        Me.CheckBoxAutoUpdate.Size = New System.Drawing.Size(75, 21)
        Me.CheckBoxAutoUpdate.TabIndex = 11
        Me.CheckBoxAutoUpdate.Text = "自动更新"
        Me.CheckBoxAutoUpdate.UseVisualStyleBackColor = True
        '
        'CheckBoxDefaultSearchLocation
        '
        Me.CheckBoxDefaultSearchLocation.AutoSize = True
        Me.CheckBoxDefaultSearchLocation.Location = New System.Drawing.Point(19, 89)
        Me.CheckBoxDefaultSearchLocation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxDefaultSearchLocation.Name = "CheckBoxDefaultSearchLocation"
        Me.CheckBoxDefaultSearchLocation.Size = New System.Drawing.Size(123, 21)
        Me.CheckBoxDefaultSearchLocation.TabIndex = 12
        Me.CheckBoxDefaultSearchLocation.Text = "文件默认搜索位置"
        Me.CheckBoxDefaultSearchLocation.UseVisualStyleBackColor = True
        '
        'CheckBoxBlockMode
        '
        Me.CheckBoxBlockMode.AutoSize = True
        Me.CheckBoxBlockMode.Location = New System.Drawing.Point(19, 41)
        Me.CheckBoxBlockMode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxBlockMode.Name = "CheckBoxBlockMode"
        Me.CheckBoxBlockMode.Size = New System.Drawing.Size(75, 21)
        Me.CheckBoxBlockMode.TabIndex = 10
        Me.CheckBoxBlockMode.Text = "阻塞模式"
        Me.CheckBoxBlockMode.UseVisualStyleBackColor = True
        '
        'CheckBoxAutoSaveSettings
        '
        Me.CheckBoxAutoSaveSettings.AutoSize = True
        Me.CheckBoxAutoSaveSettings.Location = New System.Drawing.Point(19, 186)
        Me.CheckBoxAutoSaveSettings.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxAutoSaveSettings.Name = "CheckBoxAutoSaveSettings"
        Me.CheckBoxAutoSaveSettings.Size = New System.Drawing.Size(99, 21)
        Me.CheckBoxAutoSaveSettings.TabIndex = 8
        Me.CheckBoxAutoSaveSettings.Text = "自动保存设置"
        Me.CheckBoxAutoSaveSettings.UseVisualStyleBackColor = True
        '
        'CheckBoxUsePlugin
        '
        Me.CheckBoxUsePlugin.AutoSize = True
        Me.CheckBoxUsePlugin.Location = New System.Drawing.Point(19, 344)
        Me.CheckBoxUsePlugin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxUsePlugin.Name = "CheckBoxUsePlugin"
        Me.CheckBoxUsePlugin.Size = New System.Drawing.Size(75, 21)
        Me.CheckBoxUsePlugin.TabIndex = 13
        Me.CheckBoxUsePlugin.Text = "使用插件"
        Me.CheckBoxUsePlugin.UseVisualStyleBackColor = True
        '
        'CheckBoxBackground
        '
        Me.CheckBoxBackground.AutoSize = True
        Me.CheckBoxBackground.Location = New System.Drawing.Point(19, 395)
        Me.CheckBoxBackground.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxBackground.Name = "CheckBoxBackground"
        Me.CheckBoxBackground.Size = New System.Drawing.Size(75, 21)
        Me.CheckBoxBackground.TabIndex = 9
        Me.CheckBoxBackground.Text = "后台执行"
        Me.CheckBoxBackground.UseVisualStyleBackColor = True
        '
        'GroupBoxSettings
        '
        Me.GroupBoxSettings.Controls.Add(Me.ButtonUpdateNow)
        Me.GroupBoxSettings.Controls.Add(Me.ButtonSaveSettings)
        Me.GroupBoxSettings.Controls.Add(Me.LabelLoadMode)
        Me.GroupBoxSettings.Controls.Add(Me.LabelUpdateServer)
        Me.GroupBoxSettings.Controls.Add(Me.ButtonEditPlugin)
        Me.GroupBoxSettings.Controls.Add(Me.ButtonEditCron)
        Me.GroupBoxSettings.Controls.Add(Me.ButtonEditDefaultSearchLocation)
        Me.GroupBoxSettings.Controls.Add(Me.ComboBoxUpdateServer)
        Me.GroupBoxSettings.Controls.Add(Me.ComboBoxLoadMode)
        Me.GroupBoxSettings.Controls.Add(Me.CheckBoxCron)
        Me.GroupBoxSettings.Controls.Add(Me.CheckBoxAutoUpdate)
        Me.GroupBoxSettings.Controls.Add(Me.CheckBoxDefaultSearchLocation)
        Me.GroupBoxSettings.Controls.Add(Me.CheckBoxBlockMode)
        Me.GroupBoxSettings.Controls.Add(Me.CheckBoxUsedTime)
        Me.GroupBoxSettings.Controls.Add(Me.CheckBoxAutoSaveSettings)
        Me.GroupBoxSettings.Controls.Add(Me.CheckBoxUsePlugin)
        Me.GroupBoxSettings.Controls.Add(Me.CheckBoxBackground)
        Me.GroupBoxSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxSettings.Location = New System.Drawing.Point(0, 0)
        Me.GroupBoxSettings.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBoxSettings.Name = "GroupBoxSettings"
        Me.GroupBoxSettings.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBoxSettings.Size = New System.Drawing.Size(567, 569)
        Me.GroupBoxSettings.TabIndex = 6
        Me.GroupBoxSettings.TabStop = False
        Me.GroupBoxSettings.Text = "设置"
        '
        'CheckBoxUsedTime
        '
        Me.CheckBoxUsedTime.AutoSize = True
        Me.CheckBoxUsedTime.Location = New System.Drawing.Point(19, 449)
        Me.CheckBoxUsedTime.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxUsedTime.Name = "CheckBoxUsedTime"
        Me.CheckBoxUsedTime.Size = New System.Drawing.Size(99, 21)
        Me.CheckBoxUsedTime.TabIndex = 14
        Me.CheckBoxUsedTime.Text = "统计所用时间"
        Me.CheckBoxUsedTime.UseVisualStyleBackColor = True
        '
        'FormSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 569)
        Me.Controls.Add(Me.GroupBoxSettings)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormSettings"
        Me.Text = "FormSettings"
        Me.GroupBoxSettings.ResumeLayout(False)
        Me.GroupBoxSettings.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonUpdateNow As Button
    Friend WithEvents ButtonSaveSettings As Button
    Friend WithEvents LabelLoadMode As Label
    Friend WithEvents LabelUpdateServer As Label
    Friend WithEvents ButtonEditPlugin As Button
    Friend WithEvents ButtonEditCron As Button
    Friend WithEvents ButtonEditDefaultSearchLocation As Button
    Friend WithEvents ComboBoxUpdateServer As ComboBox
    Friend WithEvents ComboBoxLoadMode As ComboBox
    Friend WithEvents CheckBoxCron As CheckBox
    Friend WithEvents CheckBoxAutoUpdate As CheckBox
    Friend WithEvents CheckBoxDefaultSearchLocation As CheckBox
    Friend WithEvents CheckBoxBlockMode As CheckBox
    Friend WithEvents CheckBoxAutoSaveSettings As CheckBox
    Friend WithEvents CheckBoxUsePlugin As CheckBox
    Friend WithEvents CheckBoxBackground As CheckBox
    Friend WithEvents GroupBoxSettings As GroupBox
    Friend WithEvents CheckBoxUsedTime As CheckBox
End Class
