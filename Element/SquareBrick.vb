﻿' 正方形砖块
Public NotInheritable Class SquareBrick
    Inherits Brick  ' 继承【Brick】父类

    Public Sub New(
                      paramAlpha As Block,
                      paramColor As Color,
                      paramGraphics As Graphics,
                      paramBrush As SolidBrush)
        MyBase.New(paramAlpha, paramColor, paramGraphics, paramBrush)
        Dim locatingBeta As Point = New Point(Alpha.Locating.X + ConstantData.Delta, Alpha.Locating.Y)
        Beta = New Block(locatingBeta, Alpha.Color, Graphics, Brush)
        Dim locatingGamma As Point = New Point(Alpha.Locating.X, Alpha.Locating.Y + ConstantData.Delta)
        Gamma = New Block(locatingGamma, Alpha.Color, Graphics, Brush)
        Dim locatingDelte As Point = New Point(Alpha.Locating.X + ConstantData.Delta, Alpha.Locating.Y + ConstantData.Delta)
        Delte = New Block(locatingDelte, Alpha.Color, Graphics, Brush)

    End Sub

    ' 砖块下沉
    Public Overloads Sub Sink()
        ' 擦除砖块Alpha和Beta
        Block.DoErase(Graphics, Alpha.Locating)
        Block.DoErase(Graphics, Beta.Locating)

        MyBase.Sink()  ' 调用父类方法

        ' 绘制砖块Gamma和Delte
        Gamma.DrawSelf()
        Delte.DrawSelf()

    End Sub

    ' 砖块旋转（顺时针）
    Public Overloads Sub Whilr()
        ' 正方形砖块不需要做旋转操作
    End Sub

End Class