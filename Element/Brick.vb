' 【砖块】父类
Public Class Brick
    Implements Movable

    Private _alpha As Block
    Private _beta As Block
    Private _gamma As Block
    Private _delte As Block
    Private _color As Color
    Private _graphics As Graphics
    Private _brush As Brush

    Public Sub New(
                  paramAlpha As Block,
                  paramBeta As Block,
                  paramGama As Block,
                  paramDelte As Block,
                  paramColor As Color,
                  paramGraphics As Graphics,
                  paramBrush As Brush)
        Alpha = paramAlpha
        Beta = paramBeta
        Gamma = paramGama
        Delte = paramDelte
        Color = paramColor
        Graphics = paramGraphics
        Brush = paramBrush
    End Sub

    Public Property Alpha As Block
        Get
            Return _alpha
        End Get
        Set(value As Block)
            _alpha = value
        End Set
    End Property

    Public Property Beta As Block
        Get
            Return _beta
        End Get
        Set(value As Block)
            _beta = value
        End Set
    End Property

    Public Property Gamma As Block
        Get
            Return _gamma
        End Get
        Set(value As Block)
            _gamma = value
        End Set
    End Property

    Public Property Delte As Block
        Get
            Return _delte
        End Get
        Set(value As Block)
            _delte = value
        End Set
    End Property

    Public Property Graphics As Graphics
        Get
            Return _graphics
        End Get
        Set(value As Graphics)
            _graphics = value
        End Set
    End Property

    Public Property Brush As Brush
        Get
            Return _brush
        End Get
        Set(value As Brush)
            _brush = value
        End Set
    End Property

    Public Property Color As Color
        Get
            Return _color
        End Get
        Set(value As Color)
            _color = value
        End Set
    End Property

    ' 砖块下沉
    Public Sub Sink() Implements Movable.Sink
        Throw New NotImplementedException()
    End Sub

    ' 砖块移动
    ' @Param direction : 移动方向
    Public Sub Move(direction As ConstantData.Direction) Implements Movable.Move
        Throw New NotImplementedException()
    End Sub

    ' 砖块旋转（顺时针）
    Public Sub Whilr() Implements Movable.Whilr
        Throw New NotImplementedException()
    End Sub

End Class
