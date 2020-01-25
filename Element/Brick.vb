' 【砖块】父类
Public Class Brick

    Private _alpha As Block
    Private _beta As Block
    Private _gamma As Block
    Private _delta As Block
    Private _color As Color
    Private _graphics As Graphics
    Private _brush As SolidBrush

    Public Sub New(
                  paramAlpha As Block,
                  paramColor As Color,
                  paramGraphics As Graphics,
                  paramBrush As SolidBrush)
        Alpha = paramAlpha
        Color = paramColor
        Graphics = paramGraphics
        Brush = paramBrush
    End Sub

    ' 砖块下沉
    Public Overridable Sub Sink()
        Move(ConstantData.Direction.Down)
    End Sub

    ' 砖块移动
    Public Overridable Sub Move(direction As Integer)
        Select Case direction
            Case ConstantData.Direction.Down  ' 向下移动
                ' 四个砖块向下移动一个方块的距离
                Alpha.Locating.Offset(0, ConstantData.MovingDelta)
                Beta.Locating.Offset(0, ConstantData.MovingDelta)
                Gamma.Locating.Offset(0, ConstantData.MovingDelta)
                Delta.Locating.Offset(0, ConstantData.MovingDelta)
            Case ConstantData.Direction.Up  ' 向上移动
                ' 四个砖块向上移动一个方块的距离
                Alpha.Locating.Offset(0, -ConstantData.MovingDelta)
                Beta.Locating.Offset(0, -ConstantData.MovingDelta)
                Gamma.Locating.Offset(0, -ConstantData.MovingDelta)
                Delta.Locating.Offset(0, -ConstantData.MovingDelta)
            Case ConstantData.Direction.Left  ' 向左移动
                ' 四个砖块向左移动一个方块的距离
                Alpha.Locating.Offset(-ConstantData.MovingDelta, 0)
                Beta.Locating.Offset(-ConstantData.MovingDelta, 0)
                Gamma.Locating.Offset(-ConstantData.MovingDelta, 0)
                Delta.Locating.Offset(-ConstantData.MovingDelta, 0)
            Case ConstantData.Direction.Right  ' 向右移动
                ' 四个砖块向右移动一个方块的距离
                Alpha.Locating.Offset(ConstantData.MovingDelta, 0)
                Beta.Locating.Offset(ConstantData.MovingDelta, 0)
                Gamma.Locating.Offset(ConstantData.MovingDelta, 0)
                Delta.Locating.Offset(ConstantData.MovingDelta, 0)
        End Select
    End Sub

    ' 砖块旋转（顺时针）
    Public Overridable Sub Whirl()

    End Sub

    ' 获取最左边的砖块
    Public Function LeftBrick() As Block
        LeftBrick = Alpha
        If Beta.Locating.X <= LeftBrick.Locating.X Then
            LeftBrick = Beta
        End If
        If Gamma.Locating.X <= LeftBrick.Locating.X Then
            LeftBrick = Gamma
        End If
        If delta.Locating.X <= LeftBrick.Locating.X Then
            LeftBrick = delta
        End If
    End Function

    ' 获取最右边的砖块
    Public Function RightBrick() As Block
        RightBrick = Alpha
        If Beta.Locating.X >= LeftBrick.Locating.X Then
            RightBrick = Beta
        End If
        If Gamma.Locating.X >= LeftBrick.Locating.X Then
            RightBrick = Gamma
        End If
        If delta.Locating.X >= LeftBrick.Locating.X Then
            RightBrick = delta
        End If
    End Function

    ' 获取最下面的砖块
    Public Function BottomBrick() As Block
        BottomBrick = Alpha
        If Beta.Locating.Y >= LeftBrick.Locating.Y Then
            BottomBrick = Beta
        End If
        If Gamma.Locating.Y >= LeftBrick.Locating.Y Then
            BottomBrick = Gamma
        End If
        If delta.Locating.Y >= LeftBrick.Locating.Y Then
            BottomBrick = delta
        End If
    End Function

    ' 判断是否可以移动
    Public Function IsMovable(direction As Integer, blockList As ArrayList) As Boolean
        IsMovable = True  ' 默认情况下可以移动

        If IsKnocking(direction) Then  ' 如果会撞到两侧墙壁
            IsMovable = False
            Exit Function  ' 结束函数
        End If

        Move(direction)  '移动砖块

        For Each blockStatus As BlockStatus In blockList
            If blockStatus.Locating.Equals(Alpha.Locating) Then
                IsMovable = False
                Exit For
            End If
            If blockStatus.Locating.Equals(Beta.Locating) Then
                IsMovable = False
                Exit For
            End If
            If blockStatus.Locating.Equals(Gamma.Locating) Then
                IsMovable = False
                Exit For
            End If
            If blockStatus.Locating.Equals(Delta.Locating) Then
                IsMovable = False
                Exit For
            End If
        Next

        Move(-direction)  ' 向反方向移动回去
    End Function

    ' 判断是否会撞到左右两侧墙壁
    Public Function IsKnocking(direction As Integer) As Boolean
        IsKnocking = False  ' 默认情况下不会撞到墙壁
        Move(direction)  ' 移动砖块

        If LeftBrick().Locating.X < 0 OrElse RightBrick().Locating.X > ConstantData.SizeWidth Then
            ' 最左边的砖块在左侧墙壁左侧，或者最右边的砖块在右侧墙壁右侧，说明砖块碰撞到墙壁了。
            IsKnocking = True
        End If
        Move(-direction)  ' 向反方向移动回去
    End Function

    Public Property Alpha As Block
        Get
            Return _alpha
        End Get
        Set(value As Block)
            _alpha = value
        End Set
    End Property

    Public Property Beta As Block
        Get
            Return _beta
        End Get
        Set(value As Block)
            _beta = value
        End Set
    End Property

    Public Property Gamma As Block
        Get
            Return _gamma
        End Get
        Set(value As Block)
            _gamma = value
        End Set
    End Property

    Public Property Delta As Block
        Get
            Return _delta
        End Get
        Set(value As Block)
            _delta = value
        End Set
    End Property

    Public Property Graphics As Graphics
        Get
            Return _graphics
        End Get
        Set(value As Graphics)
            _graphics = value
        End Set
    End Property

    Public Property Brush As SolidBrush
        Get
            Return _brush
        End Get
        Set(value As SolidBrush)
            _brush = value
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

End Class
