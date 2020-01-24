' 方块类
Public Class Block
    Private _locating As Point  ' 定位像素点
    Private _color As Color  ' 方块颜色
    Private _rec As Rectangle  ' 方块的矩形
    Private _graphics As Graphics  ' 画板
    Private _brush As SolidBrush  ' 画刷
    Public Shared ReadOnly EraseBrush As SolidBrush = New SolidBrush(ConstantData.ColorBackground)
    Public Shared EraseRec As Rectangle

    ' 构造函数
    Public Sub New(locating As Point, color As Color, graphics As Graphics, brush As SolidBrush)
        Me.Locating = locating
        Me.Color = color
        Me.Graphics = graphics
        Me.Brush = brush
        Me.Rec = New Rectangle(locating.X - 8, locating.Y - 8, ConstantData.LengthInside, ConstantData.LengthInside)
    End Sub

    Public Property Locating As Point
        Get
            Return _locating
        End Get
        Set(value As Point)
            _locating = value
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

    Public Property Rec As Rectangle
        Get
            Return Rec1
        End Get
        Set(value As Rectangle)
            Rec1 = value
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

    Public Property Brush As SolidBrush
        Get
            Return _brush
        End Get
        Set(value As SolidBrush)
            _brush = value
        End Set
    End Property

    Public Property Rec1 As Rectangle
        Get
            Return Rec2
        End Get
        Set(value As Rectangle)
            Rec2 = value
        End Set
    End Property

    Public Property Rec2 As Rectangle
        Get
            Return _rec
        End Get
        Set(value As Rectangle)
            _rec = value
        End Set
    End Property

    ' 绘制方块
    ' @Param graphics : 画板
    ' @Param brush : 画刷
    Public Sub DrawSelf(graphics As Graphics, brush As Brush)
        graphics.FillRectangle(brush, Rec)
    End Sub

    ' 绘制方块
    Public Sub DrawSelf()
        Brush.Color = Me.Color
        Graphics.FillRectangle(Brush, Rec)
    End Sub

    ' 擦除砖块
    Public Shared Sub DoErase(graphics As Graphics, locating As Point)
        EraseRec = New Rectangle(locating.X, locating.Y, ConstantData.LengthInside, ConstantData.LengthInside)
        graphics.FillRectangle(EraseBrush, eraseRec)
    End Sub

End Class
