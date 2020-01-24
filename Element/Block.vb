' 方块类
Public Class Block
    Private locating As Point  ' 定位像素点
    Private color As Color  ' 方块颜色
    Private rec As Rectangle  ' 方块的矩形

    ' 构造函数
    ' @Param locating : 定位像素点
    ' @Param color : 方块颜色
    Public Sub New(locating As Point, color As Color)
        Me.locating = locating
        Me.color = color
        Me.rec = New Rectangle(locating.X - 8, locating.Y - 8, ConstantData.LengthInside, ConstantData.LengthInside)
    End Sub

    ' 绘制方块
    ' @Param graphics : 画板
    ' @Param brush : 画刷
    Public Sub DrawSelf(graphics As Graphics, brush As Brush)
        graphics.FillRectangle(brush, Me.rec)
    End Sub

End Class
