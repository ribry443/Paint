﻿Public Class Arc
    Public Class Arc
        Public Property Pen As Pen
        Dim m_image As Image
        Dim m_a As Point
        Dim m_b As Point
        Public Property h
        Public Property w
        Public Sub New(i As Image, a As Point, b As Point)
            Pen = Pens.Red
            m_image = i
            m_a = a
            m_b = b
        End Sub
        Public Sub Draw()
            Using g As Graphics = Graphics.FromImage(m_image)
                g.DrawArc(Pen, m_a.X, m_b.Y, h, w, 0, 90)
            End Using

        End Sub

    End Class

End Class
