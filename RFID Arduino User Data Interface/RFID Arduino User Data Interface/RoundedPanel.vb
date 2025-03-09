Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class RoundedPanel
    Inherits Panel

    Private _cornerRadius As Integer = 30

    Public Property CornerRadius As Integer
        Get
            Return _cornerRadius
        End Get
        Set(value As Integer)
            _cornerRadius = value
            Me.Invalidate() ' Redraw when value changes
        End Set
    End Property

    Public Sub New()
        Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.BackColor = Color.Transparent ' Make it transparent in the designer
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        ' Get panel size
        Dim rect As Rectangle = New Rectangle(0, 0, Me.Width, Me.Height)
        Dim radius As Integer = _cornerRadius * 2
        Dim path As New GraphicsPath()

        ' Create a rounded rectangle shape
        path.StartFigure()
        path.AddLine(0, 0, rect.Width, 0) ' Top edge
        path.AddLine(rect.Width, 0, rect.Width, rect.Height - _cornerRadius) ' Right edge

        ' Bottom-right rounded corner
        path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90)

        ' Bottom edge
        path.AddLine(rect.Width - _cornerRadius, rect.Height, _cornerRadius, rect.Height)

        ' Bottom-left rounded corner
        path.AddArc(0, rect.Height - radius, radius, radius, 90, 90)

        ' Left edge
        path.AddLine(0, rect.Height - _cornerRadius, 0, 0)
        path.CloseFigure()

        ' ✅ Fix: Fill with Parent's Background to Simulate Transparency
        Using brush As New SolidBrush(Me.Parent.BackColor)
            e.Graphics.FillRectangle(brush, rect) ' Fill entire panel with parent background color
            e.Graphics.FillPath(New SolidBrush(Me.BackColor), path) ' Fill rounded panel with its actual color
        End Using

        ' Apply the rounded shape as the clipping region
        Me.Region = New Region(path)
    End Sub
End Class
