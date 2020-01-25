' 【游戏主机】类
Public Class GameConsole
    Private _gameForm As GameForm  ' 游戏主窗口
    Private _gamePadGraphics As Graphics  ' 游戏面板画刷
    Private _nextBrickGraphics As Graphics  ' 下一个砖块画刷
    Private _gameStatus As Integer  ' 游戏状态
    Private _score As Integer  ' 游戏得分
    Private _runningTime As TimeSpan  ' 游戏运行时间
    Private _pauseTime As TimeSpan  ' 游戏暂停时间
    Private _nodeTime As Date  ' 游戏节点时刻（开始，暂停）
    Private _currentBrick As Brick  ' 当前砖块
    Private _nextBrick As Brick  ' 下一个砖块

    ' 构造函数

    Public Sub New(paramGameForm As GameForm)
        GameForm = paramGameForm  ' 游戏主窗口
    End Sub

    ' 初始化：游戏主机
    Private Sub InitConsole()
        GamePadGraphics = GameForm.PN_GamePad.CreateGraphics  ' 游戏面板画刷
        NextBrickGraphics = GameForm.PN_NextBrick.CreateGraphics  ' 下一个砖块画刷
        Score = 0  ' 游戏得分
        GameStatus = ConstantData.GameStatus.OK  ' 游戏状态
        InitBlockList()  ' 初始化：游戏面板的方块状态信息的集合
    End Sub

    ' 初始化：游戏面板的方块状态信息的集合
    Private Sub InitBlockList()
        Dim locating As Point
        For row As Integer = 1 To ConstantData.CountVertical  ' 行
            For collumn As Integer = 1 To ConstantData.CountHorizon  ' 列
                locating = New Point(9 + ConstantData.Delta * (collumn - 1), 9 + ConstantData.Delta * (row - 1))
                BlockList.Add(New BlockStatus(locating, False))
            Next
        Next
    End Sub

    Public Property GameForm As GameForm
        Get
            Return _gameForm
        End Get
        Set(value As GameForm)
            _gameForm = value
        End Set
    End Property

    Public Property GamePadGraphics As Graphics
        Get
            Return _gamePadGraphics
        End Get
        Set(value As Graphics)
            _gamePadGraphics = value
        End Set
    End Property

    Public Property NextBrickGraphics As Graphics
        Get
            Return _nextBrickGraphics
        End Get
        Set(value As Graphics)
            _nextBrickGraphics = value
        End Set
    End Property

    Public Property GameStatus As Integer
        Get
            Return _gameStatus
        End Get
        Set(value As Integer)
            _gameStatus = value
        End Set
    End Property

    Public Property Score As Integer
        Get
            Return _score
        End Get
        Set(value As Integer)
            _score = value
        End Set
    End Property

    Public Property RunningTime As TimeSpan
        Get
            Return _runningTime
        End Get
        Set(value As TimeSpan)
            _runningTime = value
        End Set
    End Property

    Public Property PauseTime As TimeSpan
        Get
            Return _pauseTime
        End Get
        Set(value As TimeSpan)
            _pauseTime = value
        End Set
    End Property

    Public Property NodeTime As Date
        Get
            Return _nodeTime
        End Get
        Set(value As Date)
            _nodeTime = value
        End Set
    End Property

    Public Property BlockList As New ArrayList()  ' 游戏面板的方块状态信息的集合

    Public Property CurrentBrick As Brick
        Get
            Return _currentBrick
        End Get
        Set(value As Brick)
            _currentBrick = value
        End Set
    End Property

    Public Property NextBrick As Brick
        Get
            Return _nextBrick
        End Get
        Set(value As Brick)
            _nextBrick = value
        End Set
    End Property
End Class

