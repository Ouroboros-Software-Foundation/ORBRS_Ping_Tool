<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pbPoll = New System.Windows.Forms.ToolStripProgressBar()
        Me.spacelabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.osflabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.numPoll = New System.Windows.Forms.NumericUpDown()
        Me.chkPoll = New System.Windows.Forms.CheckBox()
        Me.tbLog = New System.Windows.Forms.TextBox()
        Me.tmTime = New System.Windows.Forms.Timer(Me.components)
        Me.tmPoll = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.numPoll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnStart.Location = New System.Drawing.Point(330, 399)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(322, 34)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "手动检测"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.dgv, 2)
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(3, 3)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowTemplate.Height = 23
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(649, 390)
        Me.dgv.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.Controls.Add(Me.StatusStrip1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.dgv, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnStart, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnOpen, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbLog, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(984, 461)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'StatusStrip1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.StatusStrip1, 3)
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbTime, Me.pbPoll, Me.spacelabel, Me.osflabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 436)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(984, 25)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbTime
        '
        Me.lbTime.Name = "lbTime"
        Me.lbTime.Size = New System.Drawing.Size(126, 20)
        Me.lbTime.Text = "0000-00-00 00:00:00"
        '
        'pbPoll
        '
        Me.pbPoll.Name = "pbPoll"
        Me.pbPoll.Size = New System.Drawing.Size(150, 19)
        Me.pbPoll.Step = 1
        Me.pbPoll.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'spacelabel
        '
        Me.spacelabel.Name = "spacelabel"
        Me.spacelabel.Size = New System.Drawing.Size(421, 20)
        Me.spacelabel.Spring = True
        '
        'osflabel
        '
        Me.osflabel.Name = "osflabel"
        Me.osflabel.Size = New System.Drawing.Size(270, 20)
        Me.osflabel.Text = "Powered by Ouroboros Software Foundation"
        '
        'btnOpen
        '
        Me.btnOpen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOpen.Location = New System.Drawing.Point(3, 399)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(321, 34)
        Me.btnOpen.TabIndex = 3
        Me.btnOpen.Text = "打开文件"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.numPoll)
        Me.Panel1.Controls.Add(Me.chkPoll)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(658, 399)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(323, 34)
        Me.Panel1.TabIndex = 5
        '
        'numPoll
        '
        Me.numPoll.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.numPoll.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numPoll.Location = New System.Drawing.Point(78, 5)
        Me.numPoll.Maximum = New Decimal(New Integer() {3600, 0, 0, 0})
        Me.numPoll.Name = "numPoll"
        Me.numPoll.Size = New System.Drawing.Size(74, 26)
        Me.numPoll.TabIndex = 1
        Me.numPoll.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'chkPoll
        '
        Me.chkPoll.AutoSize = True
        Me.chkPoll.Dock = System.Windows.Forms.DockStyle.Left
        Me.chkPoll.Location = New System.Drawing.Point(0, 0)
        Me.chkPoll.Name = "chkPoll"
        Me.chkPoll.Size = New System.Drawing.Size(72, 34)
        Me.chkPoll.TabIndex = 0
        Me.chkPoll.Text = "自动刷新"
        Me.chkPoll.UseVisualStyleBackColor = True
        '
        'tbLog
        '
        Me.tbLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbLog.Location = New System.Drawing.Point(658, 3)
        Me.tbLog.Multiline = True
        Me.tbLog.Name = "tbLog"
        Me.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbLog.Size = New System.Drawing.Size(323, 390)
        Me.tbLog.TabIndex = 6
        '
        'tmTime
        '
        Me.tmTime.Enabled = True
        Me.tmTime.Interval = 1000
        '
        'tmPoll
        '
        Me.tmPoll.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 461)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ouroboros' Ping Tool  （本软件由Ouroboros软件基金会免费提供）"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.numPoll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnOpen As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lbTime As ToolStripStatusLabel
    Friend WithEvents tmTime As Timer
    Friend WithEvents spacelabel As ToolStripStatusLabel
    Friend WithEvents osflabel As ToolStripStatusLabel
    Friend WithEvents pbPoll As ToolStripProgressBar
    Friend WithEvents tmPoll As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents chkPoll As CheckBox
    Friend WithEvents numPoll As NumericUpDown
    Friend WithEvents tbLog As TextBox
End Class
