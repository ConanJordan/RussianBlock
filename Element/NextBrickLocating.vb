' 游戏进行中，需要在【下一个砖块】的面板区域显示下一个砖块
' 这个类时用来记录每一种砖块在【下一个砖块】的面板区域的定位像素点的
Public NotInheritable Class NextBrickLocating
    Public Shared ReadOnly Square As Point = CalculateLocatingSquare()
    Public Shared ReadOnly Straight As Point = CalculateLocatingStraight()
    Public Shared ReadOnly ShapeLA As Point = CalculateLocatingShapeLA()
    Public Shared ReadOnly ShapeLB As Point = CalculateLocatingShapeLB()
    Public Shared ReadOnly ShapeSA As Point = CalculateLocatingShapeSA()
    Public Shared ReadOnly ShapeSB As Point = CalculateLocatingShapeSB()
    Public Shared ReadOnly Fort As Point = CalculateLocatingFort()

    Private Shared Function CalculateLocatingSquare() As Point
        Dim x, y As Integer
        x = ConstantData.SizeWidthNext / 2
        y = ConstantData.SizeHeightNext / 2
        x = x - 9
        y = y - 9
        Return New Point(x - 1, y - 1)
    End Function

    Private Shared Function CalculateLocatingStraight() As Point
        Dim x, y As Integer
        x = ConstantData.SizeWidthNext / 2
        y = ConstantData.SizeHeightNext / 2
        x = x - 9 - ConstantData.Delta * 1
        Return New Point(x - 1, y - 1)
    End Function

    Private Shared Function CalculateLocatingShapeLA() As Point
        Dim x, y As Integer
        x = ConstantData.SizeWidthNext / 2
        y = ConstantData.SizeHeightNext / 2
        x = x - ConstantData.Delta
        y = y + 9
        Return New Point(x - 1, y - 1)
    End Function

    Private Shared Function CalculateLocatingShapeLB() As Point
        Dim x, y As Integer
        x = ConstantData.SizeWidthNext / 2
        y = ConstantData.SizeHeightNext / 2
        x = x - ConstantData.Delta
        y = y - 9
        Return New Point(x - 1, y - 1)
    End Function

    Private Shared Function CalculateLocatingShapeSA() As Point
        Dim x, y As Integer
        x = ConstantData.SizeWidthNext / 2
        y = ConstantData.SizeHeightNext / 2
        x = x - ConstantData.Delta
        y = y - 9
        Return New Point(x - 1, y - 1)
    End Function

    Private Shared Function CalculateLocatingShapeSB() As Point
        Dim x, y As Integer
        x = ConstantData.SizeWidthNext / 2
        y = ConstantData.SizeHeightNext / 2
        x = x - ConstantData.Delta
        y = y + 9
        Return New Point(x - 1, y - 1)
    End Function

    Private Shared Function CalculateLocatingFort() As Point
        Dim x, y As Integer
        x = ConstantData.SizeWidthNext / 2
        y = ConstantData.SizeHeightNext / 2
        y = y - 9
        Return New Point(x - 1, y - 1)
    End Function

End Class
