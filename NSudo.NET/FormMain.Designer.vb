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
        Me.TreeViewMain = New System.Windows.Forms.TreeView()
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
        Me.GroupBoxSettings = New System.Windows.Forms.GroupBox()
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
        Me.CheckBoxUsedTime = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAutoSaveSettings = New System.Windows.Forms.CheckBox()
        Me.CheckBoxUsePlugin = New System.Windows.Forms.CheckBox()
        Me.CheckBoxBackground = New System.Windows.Forms.CheckBox()
        Me.ListViewFavorite = New System.Windows.Forms.ListView()
        Me.RichTextBoxMessage = New System.Windows.Forms.RichTextBox()
        Me.FolderBrowserDialogMain = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialogMain = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialogMain = New System.Windows.Forms.SaveFileDialog()
        Me.ContextMenuStripMain.SuspendLayout()
        Me.MenuStripMain.SuspendLayout()
        Me.GroupBoxControl.SuspendLayout()
        Me.GroupBoxSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeViewMain
        '
        Me.TreeViewMain.ContextMenuStrip = Me.ContextMenuStripMain
        Me.TreeViewMain.Location = New System.Drawing.Point(16, 61)
        Me.TreeViewMain.Name = "TreeViewMain"
        Me.TreeViewMain.Size = New System.Drawing.Size(305, 619)
        Me.TreeViewMain.TabIndex = 0
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
        'GroupBoxControl
        '
        Me.GroupBoxControl.ContextMenuStrip = Me.ContextMenuStripMain
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
        Me.GroupBoxControl.Location = New System.Drawing.Point(332, 52)
        Me.GroupBoxControl.Name = "GroupBoxControl"
        Me.GroupBoxControl.Size = New System.Drawing.Size(454, 386)
        Me.GroupBoxControl.TabIndex = 4
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
        'GroupBoxSettings
        '
        Me.GroupBoxSettings.ContextMenuStrip = Me.ContextMenuStripMain
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
        Me.GroupBoxSettings.Location = New System.Drawing.Point(801, 52)
        Me.GroupBoxSettings.Name = "GroupBoxSettings"
        Me.GroupBoxSettings.Size = New System.Drawing.Size(401, 386)
        Me.GroupBoxSettings.TabIndex = 5
        Me.GroupBoxSettings.TabStop = False
        Me.GroupBoxSettings.Text = "设置"
        '
        'ButtonUpdateNow
        '
        Me.ButtonUpdateNow.Location = New System.Drawing.Point(160, 163)
        Me.ButtonUpdateNow.Name = "ButtonUpdateNow"
        Me.ButtonUpdateNow.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUpdateNow.TabIndex = 27
        Me.ButtonUpdateNow.Text = "现在更新"
        Me.ButtonUpdateNow.UseVisualStyleBackColor = True
        '
        'ButtonSaveSettings
        '
        Me.ButtonSaveSettings.Location = New System.Drawing.Point(160, 129)
        Me.ButtonSaveSettings.Name = "ButtonSaveSettings"
        Me.ButtonSaveSettings.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSaveSettings.TabIndex = 26
        Me.ButtonSaveSettings.Text = "现在保存..."
        Me.ButtonSaveSettings.UseVisualStyleBackColor = True
        '
        'LabelLoadMode
        '
        Me.LabelLoadMode.AutoSize = True
        Me.LabelLoadMode.Location = New System.Drawing.Point(32, 357)
        Me.LabelLoadMode.Name = "LabelLoadMode"
        Me.LabelLoadMode.Size = New System.Drawing.Size(59, 17)
        Me.LabelLoadMode.TabIndex = 25
        Me.LabelLoadMode.Text = "初始模式:"
        '
        'LabelUpdateServer
        '
        Me.LabelUpdateServer.AutoSize = True
        Me.LabelUpdateServer.Location = New System.Drawing.Point(32, 204)
        Me.LabelUpdateServer.Name = "LabelUpdateServer"
        Me.LabelUpdateServer.Size = New System.Drawing.Size(71, 17)
        Me.LabelUpdateServer.TabIndex = 24
        Me.LabelUpdateServer.Text = "更新服务器:"
        '
        'ButtonEditPlugin
        '
        Me.ButtonEditPlugin.Location = New System.Drawing.Point(160, 241)
        Me.ButtonEditPlugin.Name = "ButtonEditPlugin"
        Me.ButtonEditPlugin.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEditPlugin.TabIndex = 23
        Me.ButtonEditPlugin.Text = "编辑..."
        Me.ButtonEditPlugin.UseVisualStyleBackColor = True
        '
        'ButtonEditCron
        '
        Me.ButtonEditCron.Location = New System.Drawing.Point(160, 93)
        Me.ButtonEditCron.Name = "ButtonEditCron"
        Me.ButtonEditCron.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEditCron.TabIndex = 22
        Me.ButtonEditCron.Text = "编辑..."
        Me.ButtonEditCron.UseVisualStyleBackColor = True
        '
        'ButtonEditDefaultSearchLocation
        '
        Me.ButtonEditDefaultSearchLocation.Location = New System.Drawing.Point(160, 61)
        Me.ButtonEditDefaultSearchLocation.Name = "ButtonEditDefaultSearchLocation"
        Me.ButtonEditDefaultSearchLocation.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEditDefaultSearchLocation.TabIndex = 21
        Me.ButtonEditDefaultSearchLocation.Text = "编辑..."
        Me.ButtonEditDefaultSearchLocation.UseVisualStyleBackColor = True
        '
        'ComboBoxUpdateServer
        '
        Me.ComboBoxUpdateServer.FormattingEnabled = True
        Me.ComboBoxUpdateServer.Location = New System.Drawing.Point(160, 201)
        Me.ComboBoxUpdateServer.Name = "ComboBoxUpdateServer"
        Me.ComboBoxUpdateServer.Size = New System.Drawing.Size(121, 25)
        Me.ComboBoxUpdateServer.TabIndex = 17
        '
        'ComboBoxLoadMode
        '
        Me.ComboBoxLoadMode.FormattingEnabled = True
        Me.ComboBoxLoadMode.Location = New System.Drawing.Point(160, 349)
        Me.ComboBoxLoadMode.Name = "ComboBoxLoadMode"
        Me.ComboBoxLoadMode.Size = New System.Drawing.Size(121, 25)
        Me.ComboBoxLoadMode.TabIndex = 16
        '
        'CheckBoxCron
        '
        Me.CheckBoxCron.AutoSize = True
        Me.CheckBoxCron.Location = New System.Drawing.Point(16, 97)
        Me.CheckBoxCron.Name = "CheckBoxCron"
        Me.CheckBoxCron.Size = New System.Drawing.Size(75, 21)
        Me.CheckBoxCron.TabIndex = 15
        Me.CheckBoxCron.Text = "计划任务"
        Me.CheckBoxCron.UseVisualStyleBackColor = True
        '
        'CheckBoxAutoUpdate
        '
        Me.CheckBoxAutoUpdate.AutoSize = True
        Me.CheckBoxAutoUpdate.Location = New System.Drawing.Point(16, 165)
        Me.CheckBoxAutoUpdate.Name = "CheckBoxAutoUpdate"
        Me.CheckBoxAutoUpdate.Size = New System.Drawing.Size(75, 21)
        Me.CheckBoxAutoUpdate.TabIndex = 11
        Me.CheckBoxAutoUpdate.Text = "自动更新"
        Me.CheckBoxAutoUpdate.UseVisualStyleBackColor = True
        '
        'CheckBoxDefaultSearchLocation
        '
        Me.CheckBoxDefaultSearchLocation.AutoSize = True
        Me.CheckBoxDefaultSearchLocation.Location = New System.Drawing.Point(16, 63)
        Me.CheckBoxDefaultSearchLocation.Name = "CheckBoxDefaultSearchLocation"
        Me.CheckBoxDefaultSearchLocation.Size = New System.Drawing.Size(123, 21)
        Me.CheckBoxDefaultSearchLocation.TabIndex = 12
        Me.CheckBoxDefaultSearchLocation.Text = "文件默认搜索位置"
        Me.CheckBoxDefaultSearchLocation.UseVisualStyleBackColor = True
        '
        'CheckBoxBlockMode
        '
        Me.CheckBoxBlockMode.AutoSize = True
        Me.CheckBoxBlockMode.Location = New System.Drawing.Point(16, 29)
        Me.CheckBoxBlockMode.Name = "CheckBoxBlockMode"
        Me.CheckBoxBlockMode.Size = New System.Drawing.Size(75, 21)
        Me.CheckBoxBlockMode.TabIndex = 10
        Me.CheckBoxBlockMode.Text = "阻塞模式"
        Me.CheckBoxBlockMode.UseVisualStyleBackColor = True
        '
        'CheckBoxUsedTime
        '
        Me.CheckBoxUsedTime.AutoSize = True
        Me.CheckBoxUsedTime.Location = New System.Drawing.Point(16, 317)
        Me.CheckBoxUsedTime.Name = "CheckBoxUsedTime"
        Me.CheckBoxUsedTime.Size = New System.Drawing.Size(99, 21)
        Me.CheckBoxUsedTime.TabIndex = 14
        Me.CheckBoxUsedTime.Text = "统计所用时间"
        Me.CheckBoxUsedTime.UseVisualStyleBackColor = True
        '
        'CheckBoxAutoSaveSettings
        '
        Me.CheckBoxAutoSaveSettings.AutoSize = True
        Me.CheckBoxAutoSaveSettings.Location = New System.Drawing.Point(16, 131)
        Me.CheckBoxAutoSaveSettings.Name = "CheckBoxAutoSaveSettings"
        Me.CheckBoxAutoSaveSettings.Size = New System.Drawing.Size(99, 21)
        Me.CheckBoxAutoSaveSettings.TabIndex = 8
        Me.CheckBoxAutoSaveSettings.Text = "自动保存设置"
        Me.CheckBoxAutoSaveSettings.UseVisualStyleBackColor = True
        '
        'CheckBoxUsePlugin
        '
        Me.CheckBoxUsePlugin.AutoSize = True
        Me.CheckBoxUsePlugin.Location = New System.Drawing.Point(16, 243)
        Me.CheckBoxUsePlugin.Name = "CheckBoxUsePlugin"
        Me.CheckBoxUsePlugin.Size = New System.Drawing.Size(75, 21)
        Me.CheckBoxUsePlugin.TabIndex = 13
        Me.CheckBoxUsePlugin.Text = "使用插件"
        Me.CheckBoxUsePlugin.UseVisualStyleBackColor = True
        '
        'CheckBoxBackground
        '
        Me.CheckBoxBackground.AutoSize = True
        Me.CheckBoxBackground.Location = New System.Drawing.Point(16, 279)
        Me.CheckBoxBackground.Name = "CheckBoxBackground"
        Me.CheckBoxBackground.Size = New System.Drawing.Size(75, 21)
        Me.CheckBoxBackground.TabIndex = 9
        Me.CheckBoxBackground.Text = "后台执行"
        Me.CheckBoxBackground.UseVisualStyleBackColor = True
        '
        'ListViewFavorite
        '
        Me.ListViewFavorite.ContextMenuStrip = Me.ContextMenuStripMain
        Me.ListViewFavorite.Location = New System.Drawing.Point(801, 458)
        Me.ListViewFavorite.Name = "ListViewFavorite"
        Me.ListViewFavorite.Size = New System.Drawing.Size(401, 222)
        Me.ListViewFavorite.TabIndex = 6
        Me.ListViewFavorite.UseCompatibleStateImageBehavior = False
        '
        'RichTextBoxMessage
        '
        Me.RichTextBoxMessage.ContextMenuStrip = Me.ContextMenuStripMain
        Me.RichTextBoxMessage.Location = New System.Drawing.Point(332, 458)
        Me.RichTextBoxMessage.Name = "RichTextBoxMessage"
        Me.RichTextBoxMessage.Size = New System.Drawing.Size(454, 222)
        Me.RichTextBoxMessage.TabIndex = 7
        Me.RichTextBoxMessage.Text = ""
        Me.RichTextBoxMessage.WordWrap = False
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
        Me.Controls.Add(Me.RichTextBoxMessage)
        Me.Controls.Add(Me.ListViewFavorite)
        Me.Controls.Add(Me.GroupBoxSettings)
        Me.Controls.Add(Me.GroupBoxControl)
        Me.Controls.Add(Me.StatusStripMain)
        Me.Controls.Add(Me.ToolStripMain)
        Me.Controls.Add(Me.TreeViewMain)
        Me.Controls.Add(Me.MenuStripMain)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStripMain
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.Text = "NSudo.NET"
        Me.ContextMenuStripMain.ResumeLayout(False)
        Me.MenuStripMain.ResumeLayout(False)
        Me.MenuStripMain.PerformLayout()
        Me.GroupBoxControl.ResumeLayout(False)
        Me.GroupBoxControl.PerformLayout()
        Me.GroupBoxSettings.ResumeLayout(False)
        Me.GroupBoxSettings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TreeViewMain As TreeView
    Friend WithEvents NotifyIcon As NotifyIcon
    Friend WithEvents MenuStripMain As MenuStrip
    Friend WithEvents ToolStripMain As ToolStrip
    Friend WithEvents StatusStripMain As StatusStrip
    Friend WithEvents GroupBoxControl As GroupBox
    Friend WithEvents ComboBoxTask As ComboBox
    Friend WithEvents TextBoxPath As TextBox
    Friend WithEvents TextBoxMoreArgs As TextBox
    Friend WithEvents LabelArgP As Label
    Friend WithEvents LabelArgU As Label
    Friend WithEvents LabelMoreArgs As Label
    Friend WithEvents LabelPath As Label
    Friend WithEvents LabelArgM As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents GroupBoxSettings As GroupBox
    Friend WithEvents ListViewFavorite As ListView
    Friend WithEvents RichTextBoxMessage As RichTextBox
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
    Friend WithEvents CheckBoxUsedTime As CheckBox
    Friend WithEvents CheckBoxAutoSaveSettings As CheckBox
    Friend WithEvents CheckBoxUsePlugin As CheckBox
    Friend WithEvents CheckBoxBackground As CheckBox
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
