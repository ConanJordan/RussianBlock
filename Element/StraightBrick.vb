' 长条形砖块
Public NotInheritable Class StraightBrick
    Inherits Brick

    ' 构造函数
    Public Sub New(
                      paramAlpha As Block,
                      paramColor As Color,
                      paramGraphics As Graphics,
                      paramBrush As SolidBrush)
        MyBase.New(paramAlpha, paramColor, paramGraphics, paramBrush)  ' 调用父类方法

        Dim locatingBeta As Point = New Point(Alpha.Locating.X + ConstantData.Delta, Alpha.Locating.Y)
        Beta = New Block(locatingBeta, Alpha.Color, Graphics, Brush)
        Dim locatingGamma As Point = New Point(Beta.Locating.X + ConstantData.Delta, Beta.Locating.Y)
        Gamma = New Block(locatingGamma, Alpha.Color, Graphics, Brush)
        Dim locatingDelte As Point = New Point(Gamma.Locating.X + ConstantData.Delta, Gamma.Locating.Y)
        Delta = New Block(locatingDelte, Alpha.Color, Graphics, Brush)
    End Sub

    ' 方块下沉
    Public Overrides Sub Sink()
        ' 擦除砖块Alpha,Beta,Gamma,Delta
        Block.DoErase(Graphics, Alpha.Locating)
        Block.DoErase(Graphics, Beta.Locating)
        Block.DoErase(Graphics, Gamma.Locating)
        Block.DoErase(Graphics, Delta.Locating)

        MyBase.Sink()  ' 调用父类方法

        ' 绘制砖块Alpha,Beta,Gamma,Delta
        Alpha.DrawSelf()
        Beta.DrawSelf()
        Gamma.DrawSelf()
        Delta.DrawSelf()
    End Sub

    ' 砖块移动
    Public Overrides Sub Move(direction As Integer)
        If direction = ConstantData.Direction.Left Then  ' 向左移动
            ' 擦除最右边砖块
            Block.DoErase(Graphics, RightBrick().Locating)

            MyBase.Move(direction)  ' 调用父类方法

            ' 绘制最左边砖块
            LeftBrick().DrawSelf()
        End If
        If direction = ConstantData.Direction.Right Then  ' 向右移动
            ' 擦除最左边砖块
            Block.DoErase(Graphics, LeftBrick().Locating)

            MyBase.Move(direction)  ' 调用父类方法

            ' 绘制最右边砖块
            RightBrick().DrawSelf()
        End If
    End Sub

    ' 砖块旋转（顺时针）
    ' 旋转方式参照【游戏设计.xlsx】
    Public Overrides Sub Whirl()

    End Sub

End Class
