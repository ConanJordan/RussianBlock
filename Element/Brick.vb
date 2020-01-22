' 【砖块】接口
Public Interface Brick

    ' 砖块下沉
    Sub Sink()

    ' 砖块移动
    Sub Move(direction As ConstantData.Direction)

    ' 砖块旋转（顺时针）
    Sub Whilr()
End Interface
