<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GameForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuBar = New System.Windows.Forms.MenuStrip()
        Me.MI_Game = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MI_Start = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_Pause = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_Stop = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_Rank = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_Help = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于游戏ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.操作指南ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_Difficulty = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_DiffRookie = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_DiffJunior = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_DiffNormal = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_DiffVeteran = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_DiffMaster = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuBar.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(12, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(266, 412)
        Me.Panel1.TabIndex = 0
        '
        'MenuBar
        '
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MI_Game, Me.MI_Rank, Me.MI_Help})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuBar.Size = New System.Drawing.Size(504, 27)
        Me.MenuBar.TabIndex = 1
        Me.MenuBar.Text = "MenuStrip1"
        '
        'MI_Game
        '
        Me.MI_Game.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MI_Start, Me.MI_Pause, Me.MI_Stop, Me.MI_Difficulty})
        Me.MI_Game.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MI_Game.Name = "MI_Game"
        Me.MI_Game.Size = New System.Drawing.Size(47, 23)
        Me.MI_Game.Text = "游戏"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Location = New System.Drawing.Point(347, 342)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(95, 95)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(293, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(199, 277)
        Me.Panel3.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("宋体", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(65, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "一般"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "00:00:00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(82, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "等级"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "时间"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "得分"
        '
        'MI_Start
        '
        Me.MI_Start.Name = "MI_Start"
        Me.MI_Start.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.MI_Start.Size = New System.Drawing.Size(180, 24)
        Me.MI_Start.Text = "开始"
        '
        'MI_Pause
        '
        Me.MI_Pause.Name = "MI_Pause"
        Me.MI_Pause.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.MI_Pause.Size = New System.Drawing.Size(180, 24)
        Me.MI_Pause.Text = "暂停"
        '
        'MI_Stop
        '
        Me.MI_Stop.Name = "MI_Stop"
        Me.MI_Stop.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D3), System.Windows.Forms.Keys)
        Me.MI_Stop.Size = New System.Drawing.Size(180, 24)
        Me.MI_Stop.Text = "结束"
        '
        'MI_Rank
        '
        Me.MI_Rank.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MI_Rank.Name = "MI_Rank"
        Me.MI_Rank.Size = New System.Drawing.Size(60, 23)
        Me.MI_Rank.Text = "得分榜"
        '
        'MI_Help
        '
        Me.MI_Help.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.关于游戏ToolStripMenuItem, Me.操作指南ToolStripMenuItem})
        Me.MI_Help.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MI_Help.Name = "MI_Help"
        Me.MI_Help.Size = New System.Drawing.Size(47, 23)
        Me.MI_Help.Text = "帮助"
        '
        '关于游戏ToolStripMenuItem
        '
        Me.关于游戏ToolStripMenuItem.Name = "关于游戏ToolStripMenuItem"
        Me.关于游戏ToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.关于游戏ToolStripMenuItem.Text = "关于游戏"
        '
        '操作指南ToolStripMenuItem
        '
        Me.操作指南ToolStripMenuItem.Name = "操作指南ToolStripMenuItem"
        Me.操作指南ToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.操作指南ToolStripMenuItem.Text = "操作指南"
        '
        'MI_Difficulty
        '
        Me.MI_Difficulty.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MI_DiffRookie, Me.MI_DiffJunior, Me.MI_DiffNormal, Me.MI_DiffVeteran, Me.MI_DiffMaster})
        Me.MI_Difficulty.Name = "MI_Difficulty"
        Me.MI_Difficulty.Size = New System.Drawing.Size(180, 24)
        Me.MI_Difficulty.Text = "难度"
        '
        'MI_DiffRookie
        '
        Me.MI_DiffRookie.Name = "MI_DiffRookie"
        Me.MI_DiffRookie.Size = New System.Drawing.Size(180, 24)
        Me.MI_DiffRookie.Text = "菜鸟"
        '
        'MI_DiffJunior
        '
        Me.MI_DiffJunior.Name = "MI_DiffJunior"
        Me.MI_DiffJunior.Size = New System.Drawing.Size(180, 24)
        Me.MI_DiffJunior.Text = "新手"
        '
        'MI_DiffNormal
        '
        Me.MI_DiffNormal.Name = "MI_DiffNormal"
        Me.MI_DiffNormal.Size = New System.Drawing.Size(180, 24)
        Me.MI_DiffNormal.Text = "一般"
        '
        'MI_DiffVeteran
        '
        Me.MI_DiffVeteran.Name = "MI_DiffVeteran"
        Me.MI_DiffVeteran.Size = New System.Drawing.Size(180, 24)
        Me.MI_DiffVeteran.Text = "高手"
        '
        'MI_DiffMaster
        '
        Me.MI_DiffMaster.Name = "MI_DiffMaster"
        Me.MI_DiffMaster.Size = New System.Drawing.Size(180, 24)
        Me.MI_DiffMaster.Text = "大师"
        '
        'GameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 449)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuBar)
        Me.Font = New System.Drawing.Font("宋体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuBar
        Me.Name = "GameForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "俄罗斯方块"
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuBar As MenuStrip
    Friend WithEvents MI_Game As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents MI_Start As ToolStripMenuItem
    Friend WithEvents MI_Pause As ToolStripMenuItem
    Friend WithEvents MI_Stop As ToolStripMenuItem
    Friend WithEvents MI_Rank As ToolStripMenuItem
    Friend WithEvents MI_Help As ToolStripMenuItem
    Friend WithEvents 关于游戏ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 操作指南ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MI_Difficulty As ToolStripMenuItem
    Friend WithEvents MI_DiffRookie As ToolStripMenuItem
    Friend WithEvents MI_DiffJunior As ToolStripMenuItem
    Friend WithEvents MI_DiffNormal As ToolStripMenuItem
    Friend WithEvents MI_DiffVeteran As ToolStripMenuItem
    Friend WithEvents MI_DiffMaster As ToolStripMenuItem
End Class
