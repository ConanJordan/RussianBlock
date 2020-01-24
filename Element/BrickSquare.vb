' 正方形砖块
Public NotInheritable Class BrickSquare
    Inherits Brick
    Implements Movable

    Public Sub New(
                      paramAlpha As Block,
                      paramColor As Color,
                      paramGraphics As Graphics,
                      paramBrush As Brush)
        MyBase.New(paramAlpha, paramColor, paramGraphics, paramBrush)
        Dim locatingBeta As Point = New Point(Alpha.Locating.X + ConstantData.Delta, Alpha.Locating.Y)
        Beta = New Block(locatingBeta, Alpha.Color)
        Dim locatingGamma As Point = New Point(Alpha.Locating.X, Alpha.Locating.Y + ConstantData.Delta)
        Gamma = New Block(locatingGamma, Alpha.Color)
        Dim locatingDelte As Point = New Point(Alpha.Locating.X + ConstantData.Delta, Alpha.Locating.Y + ConstantData.Delta)
        Delte = New Block(locatingDelte, Alpha.Color)

    End Sub

    Public Sub Sink() Implements Movable.Sink
        Throw New NotImplementedException()
    End Sub

    Public Sub Move(direction As ConstantData.Direction) Implements Movable.Move
        Throw New NotImplementedException()
    End Sub

    Public Sub Whilr() Implements Movable.Whilr
        Throw New NotImplementedException()
    End Sub
End Class
