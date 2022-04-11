Public Class ngon
    Public Property Pen As Pen
    Public Property Sides As Integer
    Public Property Radius As Integer
    Dim m_image As Image
    Dim m_a As Point
    Dim m_b As Point
    Public Sub New(i As Image, a As Point, b As Point)
        Pen = Pens.Red
        m_image = i
        m_a = a
        m_b = b
    End Sub
    Public Sub Draw()
        Using g As Graphics = Graphics.FromImage(m_image)
            Dim points(Sides - 1) As Point

            For index = 0 To Sides - 1
                Dim x As Integer
                Dim y As Integer
                y = Math.Sin(index * 2 * Math.PI / Sides) * Radius
                x = Math.Cos(index * 2 * Math.PI / Sides) * Radius
                points(index) = New Point(m_a.X + x, m_a.Y + y)
            Next

            g.DrawPolygon(Pen, points)
        End Using
    End Sub
End Class


