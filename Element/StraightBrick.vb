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
        ' 判断砖块是水平还是垂直状态
        If Alpha.Locating.X = Beta.Locating.X = Gamma.Locating.X = Delta.Locating.X Then  ' 垂直状态
            ' 擦除所有砖块
            Block.DoErase(Graphics, Alpha.Locating)
            Block.DoErase(Graphics, Beta.Locating)
            Block.DoErase(Graphics, Gamma.Locating)
            Block.DoErase(Graphics, Delta.Locating)
            MyBase.Move(direction)  ' 调用父类方法
            ' 绘制新的砖块
            Alpha.DrawSelf()
            Beta.DrawSelf()
            Gamma.DrawSelf()
            Delta.DrawSelf()
        Else  ' 水平状态
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
        End If

    End Sub

    ' 砖块旋转（顺时针）
    ' 旋转方式参照【游戏设计.xlsx】
    Public Overrides Sub Whirl(blockList As ArrayList)
        ' 用临时变量保存Alpha,Beta,Gamma,Delta的位置
        Dim tempAlpha As Block = Alpha
        Dim tempBeta As Block = Beta
        Dim tempGamma As Block = Gamma
        Dim tempDelta As Block = Delta

        DoWhirl()  ' 旋转

        If IsMovable(ConstantData.Direction.Stilless, blockList) Then  ' 如果能旋转
            ' 清除旧的砖块
            Block.DoErase(Graphics, tempAlpha.Locating)
            Block.DoErase(Graphics, tempBeta.Locating)
            Block.DoErase(Graphics, tempGamma.Locating)
            Block.DoErase(Graphics, tempDelta.Locating)
            ' 在旋转后的位置绘制砖块
            Alpha.DrawSelf()
            Beta.DrawSelf()
            Gamma.DrawSelf()
            Delta.DrawSelf()
        Else  ' 如果不能旋转
            ' 回撤之前的旋转操作
            Alpha = tempAlpha
            Beta = tempBeta
            Gamma = tempGamma
            Delta = tempDelta
        End If

    End Sub

    ' 砖块旋转（改变砖块的位置）
    Private Sub DoWhirl()
        ' 形态A→形态B
        If (Alpha.Locating.Y = Beta.Locating.Y = Gamma.Locating.Y = Delta.Locating.Y) AndAlso LeftBrick() Is Alpha Then
            Alpha.Locating.Offset(ConstantData.MovingDelta, -ConstantData.MovingDelta)
            Beta.Locating.Offset(0, 0)
            Gamma.Locating.Offset(-ConstantData.MovingDelta, ConstantData.MovingDelta)
            Delta.Locating.Offset(-ConstantData.MovingDelta * 2, ConstantData.MovingDelta * 2)
            Exit Sub
        End If

        ' 形态B→形态C
        If (Alpha.Locating.X = Beta.Locating.X = Gamma.Locating.X = Delta.Locating.X) AndAlso TopBrick() Is Alpha Then
            Alpha.Locating.Offset(ConstantData.MovingDelta * 2, ConstantData.MovingDelta)
            Beta.Locating.Offset(ConstantData.MovingDelta, 0)
            Gamma.Locating.Offset(0, -ConstantData.MovingDelta)
            Delta.Locating.Offset(-ConstantData.MovingDelta, -ConstantData.MovingDelta * 2)
            Exit Sub
        End If

        ' 形态C→形态D
        If (Alpha.Locating.Y = Beta.Locating.Y = Gamma.Locating.Y = Delta.Locating.Y) AndAlso RightBrick() Is Alpha Then
            Alpha.Locating.Offset(-ConstantData.MovingDelta * 2, ConstantData.MovingDelta * 2)
            Beta.Locating.Offset(-ConstantData.MovingDelta, ConstantData.MovingDelta)
            Gamma.Locating.Offset(0, 0)
            Delta.Locating.Offset(ConstantData.MovingDelta, -ConstantData.MovingDelta)
            Exit Sub
        End If

        ' 形态C→形态D
        If (Alpha.Locating.X = Beta.Locating.X = Gamma.Locating.X = Delta.Locating.X) AndAlso BottomBrick() Is Alpha Then
            Alpha.Locating.Offset(-ConstantData.MovingDelta, -ConstantData.MovingDelta * 2)
            Beta.Locating.Offset(0, -ConstantData.MovingDelta)
            Gamma.Locating.Offset(ConstantData.MovingDelta, 0)
            Delta.Locating.Offset(ConstantData.MovingDelta * 2, ConstantData.MovingDelta)
            Exit Sub
        End If
    End Sub

End Class
