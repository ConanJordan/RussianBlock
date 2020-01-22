Public Class GameForm
    Private Sub GameForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' 初始化游戏面板的网格线
    Private Sub InitializeGrid()
        Dim graphics As Graphics = PN_GamePad.CreateGraphics  ' 获取画板
        Dim pen1 As Pen = New Pen(ConstantData.ColorGridLine, 1)  ' 生成一号画笔(粗一个像素)
        Dim pen2 As Pen = New Pen(ConstantData.ColorGridLine, 2)  ' 生成一号画笔(粗两个像素)

        Dim brush As SolidBrush = New SolidBrush(ConstantData.ColorGridLine)  ' 生成画刷

        ' 画边框
        'graphics.DrawLine(pen1, 0, 0, 0, ConstantData.SizeHeight - 1)
        'graphics.DrawLine(pen1, 0, 0, ConstantData.SizeWidth - 1, 0)
        'graphics.DrawLine(pen1, ConstantData.SizeWidth - 1, 0, ConstantData.SizeWidth - 1, ConstantData.SizeHeight - 1)
        'graphics.DrawLine(pen1, 0, ConstantData.SizeHeight - 1, ConstantData.SizeWidth - 1, ConstantData.SizeHeight - 1)

        graphics.FillRectangle(brush, 0, 0, 1, ConstantData.SizeHeight)
        graphics.FillRectangle(brush, 0, 0, ConstantData.SizeWidth, 1)
        graphics.FillRectangle(brush, ConstantData.SizeWidth - 1, 0, 1, ConstantData.SizeHeight)
        graphics.FillRectangle(brush, 0, ConstantData.SizeHeight - 1, ConstantData.SizeWidth, 1)

        ' 画网格线
        ' 画水平网格线
        For row As Integer = 1 To ConstantData.CountVertical
            graphics.FillRectangle(brush, 0, ConstantData.Delta * row - 1, ConstantData.SizeWidth, 2)
        Next
        ' 画垂直网格线
        For collumn As Integer = 1 To ConstantData.CountHorizon
            graphics.FillRectangle(brush, ConstantData.Delta * collumn - 1, 0, 2, ConstantData.SizeHeight)
        Next

    End Sub

    ' 开始
    Private Sub MI_Start_Click(sender As Object, e As EventArgs) Handles MI_Start.Click
        InitializeGrid()
    End Sub
End Class
