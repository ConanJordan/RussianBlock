' 记录常量的数据类
Public Class ConstantData
    Public Shared ReadOnly LengthOutside As Integer = 19  ' 外边长
    Public Shared ReadOnly LengthInside As Integer = 17  ' 内边长
    Public Shared ReadOnly Delta As Integer = 19  ' 偏移量
    Public Shared ReadOnly MovingDelta As Integer = 19  ' 移动距离

    Public Enum Direction As Integer  ' 方向
        Left = 1  ' 向左
        Right = 2  ' 向右
        Down = 3  ' 向下
    End Enum
End Class
