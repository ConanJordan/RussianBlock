' 【游戏方块的状态信息】类
Public Class BlockStatus
    Private _locating As Point  ' 定位像素点
    Private _occupied As Boolean  ' 方块是否被占据

    ' 构造函数
    Public Sub New(locating As Point, occupied As Boolean)
        _locating = locating
        _occupied = occupied
    End Sub

    Public Property Locating As Point
        Get
            Return _locating
        End Get
        Set(value As Point)
            _locating = value
        End Set
    End Property

    Public Property Occupied As Boolean
        Get
            Return _occupied
        End Get
        Set(value As Boolean)
            _occupied = value
        End Set
    End Property
End Class
