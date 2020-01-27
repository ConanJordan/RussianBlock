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
        Me.components = New System.ComponentModel.Container()
        Me.PN_GamePad = New System.Windows.Forms.Panel()
        Me.MenuBar = New System.Windows.Forms.MenuStrip()
        Me.MI_Game = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_Start = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_Pause = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_Stop = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_Difficulty = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_DiffRookie = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_DiffJunior = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_DiffNormal = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_DiffVeteran = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_DiffMaster = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_Rank = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_Help = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_AboutGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_OperateGuide = New System.Windows.Forms.ToolStripMenuItem()
        Me.PN_NextBrick = New System.Windows.Forms.Panel()
        Me.PN_Status = New System.Windows.Forms.Panel()
        Me.LB_DiffucultyB = New System.Windows.Forms.Label()
        Me.LB_TimeB = New System.Windows.Forms.Label()
        Me.LB_ScoreB = New System.Windows.Forms.Label()
        Me.LB_DiffcultyA = New System.Windows.Forms.Label()
        Me.LB_TimeA = New System.Windows.Forms.Label()
        Me.LB_ScoreA = New System.Windows.Forms.Label()
        Me.TI_Game = New System.Windows.Forms.Timer(Me.components)
        Me.MenuBar.SuspendLayout()
        Me.PN_Status.SuspendLayout()
        Me.SuspendLayout()
        '
        'PN_GamePad
        '
        Me.PN_GamePad.AllowDrop = True
        Me.PN_GamePad.BackColor = System.Drawing.Color.Black
        Me.PN_GamePad.Location = New System.Drawing.Point(12, 28)
        Me.PN_GamePad.Name = "PN_GamePad"
        Me.PN_GamePad.Size = New System.Drawing.Size(228, 380)
        Me.PN_GamePad.TabIndex = 0
        '
        'MenuBar
        '
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MI_Game, Me.MI_Rank, Me.MI_Help})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuBar.Size = New System.Drawing.Size(489, 27)
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
        Me.MI_DiffRookie.Size = New System.Drawing.Size(104, 24)
        Me.MI_DiffRookie.Text = "菜鸟"
        '
        'MI_DiffJunior
        '
        Me.MI_DiffJunior.Name = "MI_DiffJunior"
        Me.MI_DiffJunior.Size = New System.Drawing.Size(104, 24)
        Me.MI_DiffJunior.Text = "新手"
        '
        'MI_DiffNormal
        '
        Me.MI_DiffNormal.Name = "MI_DiffNormal"
        Me.MI_DiffNormal.Size = New System.Drawing.Size(104, 24)
        Me.MI_DiffNormal.Text = "一般"
        '
        'MI_DiffVeteran
        '
        Me.MI_DiffVeteran.Name = "MI_DiffVeteran"
        Me.MI_DiffVeteran.Size = New System.Drawing.Size(104, 24)
        Me.MI_DiffVeteran.Text = "高手"
        '
        'MI_DiffMaster
        '
        Me.MI_DiffMaster.Name = "MI_DiffMaster"
        Me.MI_DiffMaster.Size = New System.Drawing.Size(104, 24)
        Me.MI_DiffMaster.Text = "大师"
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
        Me.MI_Help.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MI_AboutGame, Me.MI_OperateGuide})
        Me.MI_Help.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MI_Help.Name = "MI_Help"
        Me.MI_Help.Size = New System.Drawing.Size(47, 23)
        Me.MI_Help.Text = "帮助"
        '
        'MI_AboutGame
        '
        Me.MI_AboutGame.Name = "MI_AboutGame"
        Me.MI_AboutGame.Size = New System.Drawing.Size(130, 24)
        Me.MI_AboutGame.Text = "关于游戏"
        '
        'MI_OperateGuide
        '
        Me.MI_OperateGuide.Name = "MI_OperateGuide"
        Me.MI_OperateGuide.Size = New System.Drawing.Size(130, 24)
        Me.MI_OperateGuide.Text = "操作指南"
        '
        'PN_NextBrick
        '
        Me.PN_NextBrick.BackColor = System.Drawing.Color.Black
        Me.PN_NextBrick.Location = New System.Drawing.Point(317, 308)
        Me.PN_NextBrick.Name = "PN_NextBrick"
        Me.PN_NextBrick.Size = New System.Drawing.Size(100, 100)
        Me.PN_NextBrick.TabIndex = 2
        '
        'PN_Status
        '
        Me.PN_Status.BackColor = System.Drawing.Color.White
        Me.PN_Status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PN_Status.Controls.Add(Me.LB_DiffucultyB)
        Me.PN_Status.Controls.Add(Me.LB_TimeB)
        Me.PN_Status.Controls.Add(Me.LB_ScoreB)
        Me.PN_Status.Controls.Add(Me.LB_DiffcultyA)
        Me.PN_Status.Controls.Add(Me.LB_TimeA)
        Me.PN_Status.Controls.Add(Me.LB_ScoreA)
        Me.PN_Status.Location = New System.Drawing.Point(263, 30)
        Me.PN_Status.Name = "PN_Status"
        Me.PN_Status.Size = New System.Drawing.Size(199, 263)
        Me.PN_Status.TabIndex = 3
        '
        'LB_DiffucultyB
        '
        Me.LB_DiffucultyB.AutoSize = True
        Me.LB_DiffucultyB.BackColor = System.Drawing.Color.White
        Me.LB_DiffucultyB.Font = New System.Drawing.Font("宋体", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_DiffucultyB.Location = New System.Drawing.Point(65, 228)
        Me.LB_DiffucultyB.Name = "LB_DiffucultyB"
        Me.LB_DiffucultyB.Size = New System.Drawing.Size(58, 24)
        Me.LB_DiffucultyB.TabIndex = 5
        Me.LB_DiffucultyB.Text = "一般"
        '
        'LB_TimeB
        '
        Me.LB_TimeB.AutoSize = True
        Me.LB_TimeB.BackColor = System.Drawing.Color.White
        Me.LB_TimeB.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_TimeB.Location = New System.Drawing.Point(48, 136)
        Me.LB_TimeB.Name = "LB_TimeB"
        Me.LB_TimeB.Size = New System.Drawing.Size(106, 24)
        Me.LB_TimeB.TabIndex = 4
        Me.LB_TimeB.Text = "00:00:00"
        '
        'LB_ScoreB
        '
        Me.LB_ScoreB.AutoSize = True
        Me.LB_ScoreB.BackColor = System.Drawing.Color.White
        Me.LB_ScoreB.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_ScoreB.Location = New System.Drawing.Point(82, 43)
        Me.LB_ScoreB.Name = "LB_ScoreB"
        Me.LB_ScoreB.Size = New System.Drawing.Size(22, 24)
        Me.LB_ScoreB.TabIndex = 3
        Me.LB_ScoreB.Text = "0"
        '
        'LB_DiffcultyA
        '
        Me.LB_DiffcultyA.AutoSize = True
        Me.LB_DiffcultyA.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LB_DiffcultyA.Location = New System.Drawing.Point(18, 188)
        Me.LB_DiffcultyA.Name = "LB_DiffcultyA"
        Me.LB_DiffcultyA.Size = New System.Drawing.Size(40, 16)
        Me.LB_DiffcultyA.TabIndex = 2
        Me.LB_DiffcultyA.Text = "难度"
        '
        'LB_TimeA
        '
        Me.LB_TimeA.AutoSize = True
        Me.LB_TimeA.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LB_TimeA.Location = New System.Drawing.Point(18, 102)
        Me.LB_TimeA.Name = "LB_TimeA"
        Me.LB_TimeA.Size = New System.Drawing.Size(40, 16)
        Me.LB_TimeA.TabIndex = 1
        Me.LB_TimeA.Text = "时间"
        '
        'LB_ScoreA
        '
        Me.LB_ScoreA.AutoSize = True
        Me.LB_ScoreA.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LB_ScoreA.Location = New System.Drawing.Point(18, 16)
        Me.LB_ScoreA.Name = "LB_ScoreA"
        Me.LB_ScoreA.Size = New System.Drawing.Size(40, 16)
        Me.LB_ScoreA.TabIndex = 0
        Me.LB_ScoreA.Text = "得分"
        '
        'TI_Game
        '
        Me.TI_Game.Interval = 500
        '
        'GameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 421)
        Me.Controls.Add(Me.PN_Status)
        Me.Controls.Add(Me.PN_NextBrick)
        Me.Controls.Add(Me.PN_GamePad)
        Me.Controls.Add(Me.MenuBar)
        Me.Font = New System.Drawing.Font("宋体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuBar
        Me.Name = "GameForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "俄罗斯方块"
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.PN_Status.ResumeLayout(False)
        Me.PN_Status.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PN_GamePad As Panel
    Friend WithEvents MenuBar As MenuStrip
    Friend WithEvents MI_Game As ToolStripMenuItem
    Friend WithEvents PN_NextBrick As Panel
    Friend WithEvents PN_Status As Panel
    Friend WithEvents LB_TimeA As Label
    Friend WithEvents LB_ScoreA As Label
    Friend WithEvents LB_DiffcultyA As Label
    Friend WithEvents LB_ScoreB As Label
    Friend WithEvents LB_TimeB As Label
    Friend WithEvents LB_DiffucultyB As Label
    Friend WithEvents MI_Start As ToolStripMenuItem
    Friend WithEvents MI_Pause As ToolStripMenuItem
    Friend WithEvents MI_Stop As ToolStripMenuItem
    Friend WithEvents MI_Rank As ToolStripMenuItem
    Friend WithEvents MI_Help As ToolStripMenuItem
    Friend WithEvents MI_AboutGame As ToolStripMenuItem
    Friend WithEvents MI_OperateGuide As ToolStripMenuItem
    Friend WithEvents MI_Difficulty As ToolStripMenuItem
    Friend WithEvents MI_DiffRookie As ToolStripMenuItem
    Friend WithEvents MI_DiffJunior As ToolStripMenuItem
    Friend WithEvents MI_DiffNormal As ToolStripMenuItem
    Friend WithEvents MI_DiffVeteran As ToolStripMenuItem
    Friend WithEvents MI_DiffMaster As ToolStripMenuItem
    Friend WithEvents TI_Game As Timer
End Class
