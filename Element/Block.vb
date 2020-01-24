' 方块类
Public Class Block
    Private _locating As Point  ' 定位像素点
    Private _color As Color  ' 方块颜色
    Private _rec As Rectangle  ' 方块的矩形

    ' 构造函数
    ' @Param locating : 定位像素点
    ' @Param color : 方块颜色
    Public Sub New(locating As Point, color As Color)
        Me.Locating = locating
        Me.Color = color
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

End Class
