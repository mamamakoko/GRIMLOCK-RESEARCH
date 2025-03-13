Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.ComponentModel ' Required for Browsable and Category attributes

Public Class CustomButton
    Inherits Panel

    ' Properties
    Private _cornerRadius As Integer = 30
    Private _buttonText As String = "Button"
    Private _textColor As Color = Color.Black
    Private _borderColor As Color = Color.Black
    Private _borderSize As Integer = 2
    Private _hoverColor As Color = Color.LightGray
    Private _defaultBackColor As Color

    <Browsable(True)>
    <Category("Appearance")>
    <Description("Sets the corner radius of the button.")>
    Public Property CornerRadius As Integer
        Get
            Return _cornerRadius
        End Get
        Set(value As Integer)
            _cornerRadius = value
            Me.Invalidate() ' Redraw when changed
        End Set
    End Property

    <Browsable(True)>
    <Category("Appearance")>
    <Description("Sets the text displayed on the button.")>
    Public Property ButtonText As String
        Get
            Return _buttonText
        End Get
        Set(value As String)
            _buttonText = value
            Me.Invalidate() ' Redraw when changed
        End Set
    End Property

    <Browsable(True)>
    <Category("Appearance")>
    <Description("Sets the text color of the button.")>
    Public Property TextColor As Color
        Get
            Return _textColor
        End Get
        Set(value As Color)
            _textColor = value
            Me.Invalidate()
        End Set
    End Property

    <Browsable(True)>
    <Category("Appearance")>
    <Description("Sets the border color of the button.")>
    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get
        Set(value As Color)
            _borderColor = value
            Me.Invalidate()
        End Set
    End Property

    <Browsable(True)>
    <Category("Appearance")>
    <Description("Sets the border thickness of the button.")>
    Public Property BorderSize As Integer
        Get
            Return _borderSize
        End Get
        Set(value As Integer)
            _borderSize = value
            Me.Invalidate()
        End Set
    End Property

    <Browsable(True)>
    <Category("Appearance")>
    <Description("Sets the background color when the mouse hovers over the button.")>
    Public Property HoverColor As Color
        Get
            Return _hoverColor
        End Get
        Set(value As Color)
            _hoverColor = value
        End Set
    End Property

    ' Constructor
    Public Sub New()
        Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.BackColor = Color.White ' Default background color
        _defaultBackColor = Me.BackColor
        Me.Cursor = Cursors.Hand

        ' Add event handlers for hover effect
        AddHandler Me.MouseEnter, AddressOf OnMouseEnter
        AddHandler Me.MouseLeave, AddressOf OnMouseLeave
        AddHandler Me.MouseDown, AddressOf OnMouseDown
        AddHandler Me.MouseUp, AddressOf OnMouseUp
    End Sub

    ' Mouse hover effect
    Private Sub OnMouseEnter(sender As Object, e As EventArgs)
        Me.BackColor = _hoverColor
    End Sub

    Private Sub OnMouseLeave(sender As Object, e As EventArgs)
        Me.BackColor = _defaultBackColor
    End Sub

    Private Sub OnMouseDown(sender As Object, e As MouseEventArgs)
        Me.BackColor = ControlPaint.Dark(_hoverColor) ' Darker when clicked
    End Sub

    Private Sub OnMouseUp(sender As Object, e As MouseEventArgs)
        Me.BackColor = _hoverColor
    End Sub

    ' Draw rounded button
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        Dim rect As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim path As GraphicsPath = GetRoundedRectanglePath(rect, _cornerRadius)

        ' Fill background
        Using brush As New SolidBrush(Me.BackColor)
            e.Graphics.FillPath(brush, path)
        End Using

        ' Draw border
        Using pen As New Pen(_borderColor, _borderSize)
            e.Graphics.DrawPath(pen, path)
        End Using

        ' Set clipping region
        Me.Region = New Region(path)

        ' Draw text
        Dim textSize As SizeF = e.Graphics.MeasureString(_buttonText, Me.Font)
        Dim textX As Single = (Me.Width - textSize.Width) / 2
        Dim textY As Single = (Me.Height - textSize.Height) / 2

        Using textBrush As New SolidBrush(_textColor)
            e.Graphics.DrawString(_buttonText, Me.Font, textBrush, textX, textY)
        End Using
    End Sub

    ' Function to create a rounded rectangle path
    Private Function GetRoundedRectanglePath(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        Dim d As Integer = radius * 2

        path.StartFigure()
        ' Top-left corner
        path.AddArc(rect.X, rect.Y, d, d, 180, 90)
        ' Top edge
        path.AddLine(rect.X + radius, rect.Y, rect.Right - radius, rect.Y)
        ' Top-right corner
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90)
        ' Right edge
        path.AddLine(rect.Right, rect.Y + radius, rect.Right, rect.Bottom - radius)
        ' Bottom-right corner
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90)
        ' Bottom edge
        path.AddLine(rect.Right - radius, rect.Bottom, rect.X + radius, rect.Bottom)
        ' Bottom-left corner
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90)
        ' Left edge
        path.AddLine(rect.X, rect.Bottom - radius, rect.X, rect.Y + radius)
        path.CloseFigure()

        Return path
    End Function
End Class
