' 【砖块】父类
Public Class Brick

    Private _alpha As Block
    Private _beta As Block
    Private _gamma As Block
    Private _delte As Block
    Private _color As Color
    Private _graphics As Graphics
    Private _brush As Brush

    Public Sub New(
                  paramAlpha As Block,
                  paramColor As Color,
                  paramGraphics As Graphics,
                  paramBrush As Brush)
        Alpha = paramAlpha
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

End Class
