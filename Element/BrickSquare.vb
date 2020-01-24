' 正方形砖块
Public NotInheritable Class BrickSquare
    Inherits Brick

    Public Sub New(
                      paramAlpha As Block,
                      paramBeta As Block,
                      paramGama As Block,
                      paramDelte As Block,
                      paramColor As Color,
                      paramGraphics As Graphics,
                      paramBrush As Brush)
        MyBase.New(paramAlpha, paramBeta, paramGama, paramDelte, paramColor, paramGraphics, paramBrush)
    End Sub

End Class
