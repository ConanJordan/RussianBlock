' 记录常量的数据类
Public Class ConstantData
    Public Shared ReadOnly LengthOutside As Integer = 19  ' 外边长
    Public Shared ReadOnly LengthInside As Integer = 17  ' 内边长
    Public Shared ReadOnly Delta As Integer = 19  ' 偏移量
    Public Shared ReadOnly MovingDelta As Integer = 19  ' 移动距离
    Public Shared ReadOnly CountHorizon As Integer = 12  ' 水平方向可容纳的方块数
    Public Shared ReadOnly CountVertical As Integer = 20  ' 垂直方向可容纳的方块数
    Public Shared ReadOnly SizeWidth As Integer = 228  ' 游戏面板的宽
    Public Shared ReadOnly SizeHeight As Integer = 380  ' 游戏面板的高
    Public Shared ReadOnly ColorBackground As Color = Color.Black  ' 背景颜色
    Public Shared ReadOnly ColorGridLine As Color = Color.LightGray  ' 网格线颜色
    Public Shared ReadOnly ColorSquare As Color = Color.LightYellow  ' 正方形砖块颜色
    Public Shared ReadOnly ColorStraight As Color = Color.LightBlue  ' 长条砖块颜色
    Public Shared ReadOnly ColorShapeLA As Color = Color.Blue  ' L形(形状A)砖块颜色
    Public Shared ReadOnly ColorShapeLB As Color = Color.Orange  ' L形(形状B)砖块颜色
    Public Shared ReadOnly ColorShapeSA As Color = Color.Green  ' S形(形状A)砖块颜色
    Public Shared ReadOnly ColorShapeSB As Color = Color.Red  ' S形(形状B)砖块颜色
    Public Shared ReadOnly ColorBasement As Color = Color.Violet  ' 堡垒形砖块颜色

    Public Enum Direction As Integer  ' 方向
        Left = 1  ' 向左
        Right = -1  ' 向右
        Down = 2  ' 向下
        Up = -2  ' 向上
        ' 上下，左右的数值正好互为相反数
    End Enum

    Public Enum GameStatus As Integer  ' 游戏状态
        OK = 1  ' 游戏可开始
        Running = 2  ' 游戏运行中
        Pausing = 3  ' 游戏暂停中
        Stoped = 4  ' 游戏结束
    End Enum

End Class
