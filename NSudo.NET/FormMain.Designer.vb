<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.ContextMenuStripMain = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.剪切ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.复制CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.粘贴PToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.删除DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.全选AToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.撤销ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.重做RToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.任务管理器ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.收藏管理器ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.储存日志文件LToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.开始队列ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.暂停队列ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.停止队列ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MenuStripMain = New System.Windows.Forms.MenuStrip()
        Me.文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.打开OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.配置文件包含列表收藏与设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.收藏文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.列表文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.保存SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.配置文件包含列表收藏与设置ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.收藏文件ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.列表文件ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.关闭CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.储存日志文件LToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.编辑EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.剪切TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.复制ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.粘贴PToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.删除ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.全选AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.撤销ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.工具TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助HToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.捐赠DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.语言LanguageLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMain = New System.Windows.Forms.ToolStrip()
        Me.StatusStripMain = New System.Windows.Forms.StatusStrip()
        Me.FolderBrowserDialogMain = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialogMain = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialogMain = New System.Windows.Forms.SaveFileDialog()
        Me.ContextMenuStripMain.SuspendLayout()
        Me.MenuStripMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStripMain
        '
        Me.ContextMenuStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.剪切ToolStripMenuItem, Me.复制CToolStripMenuItem, Me.粘贴PToolStripMenuItem1, Me.删除DToolStripMenuItem, Me.ToolStripSeparator3, Me.全选AToolStripMenuItem1, Me.ToolStripSeparator4, Me.撤销ToolStripMenuItem1, Me.重做RToolStripMenuItem, Me.ToolStripSeparator5, Me.任务管理器ToolStripMenuItem, Me.收藏管理器ToolStripMenuItem, Me.ToolStripSeparator6, Me.储存日志文件LToolStripMenuItem1, Me.ToolStripSeparator7, Me.开始队列ToolStripMenuItem, Me.暂停队列ToolStripMenuItem, Me.停止队列ToolStripMenuItem})
        Me.ContextMenuStripMain.Name = "ContextMenuStripMain"
        Me.ContextMenuStripMain.Size = New System.Drawing.Size(163, 320)
        '
        '剪切ToolStripMenuItem
        '
        Me.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem"
        Me.剪切ToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.剪切ToolStripMenuItem.Text = "剪切(&T)"
        '
        '复制CToolStripMenuItem
        '
        Me.复制CToolStripMenuItem.Name = "复制CToolStripMenuItem"
        Me.复制CToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.复制CToolStripMenuItem.Text = "复制(&C)"
        '
        '粘贴PToolStripMenuItem1
        '
        Me.粘贴PToolStripMenuItem1.Name = "粘贴PToolStripMenuItem1"
        Me.粘贴PToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.粘贴PToolStripMenuItem1.Text = "粘贴(&P)"
        '
        '删除DToolStripMenuItem
        '
        Me.删除DToolStripMenuItem.Name = "删除DToolStripMenuItem"
        Me.删除DToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.删除DToolStripMenuItem.Text = "删除(&D)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(159, 6)
        '
        '全选AToolStripMenuItem1
        '
        Me.全选AToolStripMenuItem1.Name = "全选AToolStripMenuItem1"
        Me.全选AToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.全选AToolStripMenuItem1.Text = "全选(&A)"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(159, 6)
        '
        '撤销ToolStripMenuItem1
        '
        Me.撤销ToolStripMenuItem1.Name = "撤销ToolStripMenuItem1"
        Me.撤销ToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.撤销ToolStripMenuItem1.Text = "撤销(&U)"
        '
        '重做RToolStripMenuItem
        '
        Me.重做RToolStripMenuItem.Name = "重做RToolStripMenuItem"
        Me.重做RToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.重做RToolStripMenuItem.Text = "重做(&R)"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(159, 6)
        '
        '任务管理器ToolStripMenuItem
        '
        Me.任务管理器ToolStripMenuItem.Name = "任务管理器ToolStripMenuItem"
        Me.任务管理器ToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.任务管理器ToolStripMenuItem.Text = "任务管理器..."
        '
        '收藏管理器ToolStripMenuItem
        '
        Me.收藏管理器ToolStripMenuItem.Name = "收藏管理器ToolStripMenuItem"
        Me.收藏管理器ToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.收藏管理器ToolStripMenuItem.Text = "收藏管理器..."
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(159, 6)
        '
        '储存日志文件LToolStripMenuItem1
        '
        Me.储存日志文件LToolStripMenuItem1.Name = "储存日志文件LToolStripMenuItem1"
        Me.储存日志文件LToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.储存日志文件LToolStripMenuItem1.Text = "储存日志文件(&L)"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(159, 6)
        '
        '开始队列ToolStripMenuItem
        '
        Me.开始队列ToolStripMenuItem.Name = "开始队列ToolStripMenuItem"
        Me.开始队列ToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.开始队列ToolStripMenuItem.Text = "开始队列"
        '
        '暂停队列ToolStripMenuItem
        '
        Me.暂停队列ToolStripMenuItem.Name = "暂停队列ToolStripMenuItem"
        Me.暂停队列ToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.暂停队列ToolStripMenuItem.Text = "暂停队列"
        '
        '停止队列ToolStripMenuItem
        '
        Me.停止队列ToolStripMenuItem.Name = "停止队列ToolStripMenuItem"
        Me.停止队列ToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.停止队列ToolStripMenuItem.Text = "停止队列"
        '
        'NotifyIcon
        '
        Me.NotifyIcon.Text = "NSudo.NET"
        Me.NotifyIcon.Visible = True
        '
        'MenuStripMain
        '
        Me.MenuStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.文件ToolStripMenuItem, Me.编辑EToolStripMenuItem, Me.工具TToolStripMenuItem, Me.帮助HToolStripMenuItem, Me.语言LanguageLToolStripMenuItem})
        Me.MenuStripMain.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripMain.Name = "MenuStripMain"
        Me.MenuStripMain.Size = New System.Drawing.Size(1214, 25)
        Me.MenuStripMain.TabIndex = 1
        Me.MenuStripMain.Text = "MenuStrip1"
        '
        '文件ToolStripMenuItem
        '
        Me.文件ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.打开OToolStripMenuItem, Me.保存SToolStripMenuItem, Me.关闭CToolStripMenuItem, Me.储存日志文件LToolStripMenuItem})
        Me.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem"
        Me.文件ToolStripMenuItem.Size = New System.Drawing.Size(58, 21)
        Me.文件ToolStripMenuItem.Text = "文件(&F)"
        '
        '打开OToolStripMenuItem
        '
        Me.打开OToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.配置文件包含列表收藏与设置ToolStripMenuItem, Me.收藏文件ToolStripMenuItem, Me.列表文件ToolStripMenuItem})
        Me.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem"
        Me.打开OToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.打开OToolStripMenuItem.Text = "打开(&O)"
        '
        '配置文件包含列表收藏与设置ToolStripMenuItem
        '
        Me.配置文件包含列表收藏与设置ToolStripMenuItem.Name = "配置文件包含列表收藏与设置ToolStripMenuItem"
        Me.配置文件包含列表收藏与设置ToolStripMenuItem.Size = New System.Drawing.Size(292, 22)
        Me.配置文件包含列表收藏与设置ToolStripMenuItem.Text = "配置文件（包含列表、收藏与设置）...(&S)"
        '
        '收藏文件ToolStripMenuItem
        '
        Me.收藏文件ToolStripMenuItem.Name = "收藏文件ToolStripMenuItem"
        Me.收藏文件ToolStripMenuItem.Size = New System.Drawing.Size(292, 22)
        Me.收藏文件ToolStripMenuItem.Text = "收藏文件...(&F)"
        '
        '列表文件ToolStripMenuItem
        '
        Me.列表文件ToolStripMenuItem.Name = "列表文件ToolStripMenuItem"
        Me.列表文件ToolStripMenuItem.Size = New System.Drawing.Size(292, 22)
        Me.列表文件ToolStripMenuItem.Text = "列表文件...(&L)"
        '
        '保存SToolStripMenuItem
        '
        Me.保存SToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.配置文件包含列表收藏与设置ToolStripMenuItem1, Me.收藏文件ToolStripMenuItem1, Me.列表文件ToolStripMenuItem1})
        Me.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem"
        Me.保存SToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.保存SToolStripMenuItem.Text = "保存(&S)"
        '
        '配置文件包含列表收藏与设置ToolStripMenuItem1
        '
        Me.配置文件包含列表收藏与设置ToolStripMenuItem1.Name = "配置文件包含列表收藏与设置ToolStripMenuItem1"
        Me.配置文件包含列表收藏与设置ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.配置文件包含列表收藏与设置ToolStripMenuItem1.Size = New System.Drawing.Size(336, 22)
        Me.配置文件包含列表收藏与设置ToolStripMenuItem1.Text = "配置文件（包含列表、收藏与设置）...(&S)"
        '
        '收藏文件ToolStripMenuItem1
        '
        Me.收藏文件ToolStripMenuItem1.Name = "收藏文件ToolStripMenuItem1"
        Me.收藏文件ToolStripMenuItem1.Size = New System.Drawing.Size(336, 22)
        Me.收藏文件ToolStripMenuItem1.Text = "收藏文件...(&F)"
        '
        '列表文件ToolStripMenuItem1
        '
        Me.列表文件ToolStripMenuItem1.Name = "列表文件ToolStripMenuItem1"
        Me.列表文件ToolStripMenuItem1.Size = New System.Drawing.Size(336, 22)
        Me.列表文件ToolStripMenuItem1.Text = "列表文件...(&L)"
        '
        '关闭CToolStripMenuItem
        '
        Me.关闭CToolStripMenuItem.Name = "关闭CToolStripMenuItem"
        Me.关闭CToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.关闭CToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.关闭CToolStripMenuItem.Text = "关闭(&C)"
        '
        '储存日志文件LToolStripMenuItem
        '
        Me.储存日志文件LToolStripMenuItem.Name = "储存日志文件LToolStripMenuItem"
        Me.储存日志文件LToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.储存日志文件LToolStripMenuItem.Text = "储存日志文件(&L)"
        '
        '编辑EToolStripMenuItem
        '
        Me.编辑EToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.剪切TToolStripMenuItem, Me.复制ToolStripMenuItem, Me.粘贴PToolStripMenuItem, Me.删除ToolStripMenuItem, Me.ToolStripSeparator1, Me.全选AToolStripMenuItem, Me.ToolStripSeparator2, Me.撤销ToolStripMenuItem})
        Me.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem"
        Me.编辑EToolStripMenuItem.Size = New System.Drawing.Size(59, 21)
        Me.编辑EToolStripMenuItem.Text = "编辑(&E)"
        '
        '剪切TToolStripMenuItem
        '
        Me.剪切TToolStripMenuItem.Name = "剪切TToolStripMenuItem"
        Me.剪切TToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.剪切TToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.剪切TToolStripMenuItem.Text = "剪切(&T)"
        '
        '复制ToolStripMenuItem
        '
        Me.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem"
        Me.复制ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.复制ToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.复制ToolStripMenuItem.Text = "复制(&C)"
        '
        '粘贴PToolStripMenuItem
        '
        Me.粘贴PToolStripMenuItem.Name = "粘贴PToolStripMenuItem"
        Me.粘贴PToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.粘贴PToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.粘贴PToolStripMenuItem.Text = "粘贴(&P)"
        '
        '删除ToolStripMenuItem
        '
        Me.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem"
        Me.删除ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.删除ToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.删除ToolStripMenuItem.Text = "删除(&D)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(159, 6)
        '
        '全选AToolStripMenuItem
        '
        Me.全选AToolStripMenuItem.Name = "全选AToolStripMenuItem"
        Me.全选AToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.全选AToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.全选AToolStripMenuItem.Text = "全选(&A)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(159, 6)
        '
        '撤销ToolStripMenuItem
        '
        Me.撤销ToolStripMenuItem.Name = "撤销ToolStripMenuItem"
        Me.撤销ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.撤销ToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.撤销ToolStripMenuItem.Text = "撤销(&U)"
        '
        '工具TToolStripMenuItem
        '
        Me.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem"
        Me.工具TToolStripMenuItem.Size = New System.Drawing.Size(59, 21)
        Me.工具TToolStripMenuItem.Text = "工具(&T)"
        '
        '帮助HToolStripMenuItem
        '
        Me.帮助HToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.关于AToolStripMenuItem, Me.捐赠DToolStripMenuItem})
        Me.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem"
        Me.帮助HToolStripMenuItem.Size = New System.Drawing.Size(61, 21)
        Me.帮助HToolStripMenuItem.Text = "帮助(&H)"
        '
        '关于AToolStripMenuItem
        '
        Me.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem"
        Me.关于AToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.关于AToolStripMenuItem.Text = "关于...(&A)"
        '
        '捐赠DToolStripMenuItem
        '
        Me.捐赠DToolStripMenuItem.Name = "捐赠DToolStripMenuItem"
        Me.捐赠DToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.捐赠DToolStripMenuItem.Text = "捐赠...(&D)"
        '
        '语言LanguageLToolStripMenuItem
        '
        Me.语言LanguageLToolStripMenuItem.Name = "语言LanguageLToolStripMenuItem"
        Me.语言LanguageLToolStripMenuItem.Size = New System.Drawing.Size(120, 21)
        Me.语言LanguageLToolStripMenuItem.Text = "语言-Language(&L)"
        '
        'ToolStripMain
        '
        Me.ToolStripMain.ContextMenuStrip = Me.ContextMenuStripMain
        Me.ToolStripMain.Location = New System.Drawing.Point(0, 25)
        Me.ToolStripMain.Name = "ToolStripMain"
        Me.ToolStripMain.Size = New System.Drawing.Size(1214, 25)
        Me.ToolStripMain.TabIndex = 2
        Me.ToolStripMain.Text = "ToolStrip1"
        '
        'StatusStripMain
        '
        Me.StatusStripMain.ContextMenuStrip = Me.ContextMenuStripMain
        Me.StatusStripMain.Location = New System.Drawing.Point(0, 699)
        Me.StatusStripMain.Name = "StatusStripMain"
        Me.StatusStripMain.Size = New System.Drawing.Size(1214, 22)
        Me.StatusStripMain.TabIndex = 3
        Me.StatusStripMain.Text = "StatusStrip1"
        '
        'OpenFileDialogMain
        '
        Me.OpenFileDialogMain.FileName = "OpenFileDialog1"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1214, 721)
        Me.ContextMenuStrip = Me.ContextMenuStripMain
        Me.Controls.Add(Me.StatusStripMain)
        Me.Controls.Add(Me.ToolStripMain)
        Me.Controls.Add(Me.MenuStripMain)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStripMain
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.Text = "NSudo.NET"
        Me.ContextMenuStripMain.ResumeLayout(False)
        Me.MenuStripMain.ResumeLayout(False)
        Me.MenuStripMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NotifyIcon As NotifyIcon
    Friend WithEvents MenuStripMain As MenuStrip
    Friend WithEvents ToolStripMain As ToolStrip
    Friend WithEvents StatusStripMain As StatusStrip
    Friend WithEvents 文件ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 打开OToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 配置文件包含列表收藏与设置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 收藏文件ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 列表文件ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 保存SToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 配置文件包含列表收藏与设置ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 收藏文件ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 列表文件ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 关闭CToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 编辑EToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 剪切TToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 复制ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 粘贴PToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 删除ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents 全选AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents 撤销ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 工具TToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 帮助HToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 关于AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 捐赠DToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 语言LanguageLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 储存日志文件LToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStripMain As ContextMenuStrip
    Friend WithEvents 剪切ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 复制CToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 粘贴PToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 删除DToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents 全选AToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents 撤销ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 重做RToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents 任务管理器ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 收藏管理器ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents 储存日志文件LToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents 开始队列ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 暂停队列ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 停止队列ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FolderBrowserDialogMain As FolderBrowserDialog
    Friend WithEvents OpenFileDialogMain As OpenFileDialog
    Friend WithEvents SaveFileDialogMain As SaveFileDialog
End Class
