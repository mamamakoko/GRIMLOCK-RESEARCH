Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.ComponentModel

' Class for grouping the corner radius properties
<TypeConverter(GetType(ExpandableObjectConverter))>
Public Class CornerRadius
    Private _topLeft As Integer = 30
    Private _topRight As Integer = 30
    Private _bottomLeft As Integer = 30
    Private _bottomRight As Integer = 30

    <Browsable(True), DefaultValue(30), Description("Sets the top-left corner radius.")>
    Public Property TopLeft As Integer
        Get
            Return _topLeft
        End Get
        Set(value As Integer)
            _topLeft = value
        End Set
    End Property

    <Browsable(True), DefaultValue(30), Description("Sets the top-right corner radius.")>
    Public Property TopRight As Integer
        Get
            Return _topRight
        End Get
        Set(value As Integer)
            _topRight = value
        End Set
    End Property

    <Browsable(True), DefaultValue(30), Description("Sets the bottom-left corner radius.")>
    Public Property BottomLeft As Integer
        Get
            Return _bottomLeft
        End Get
        Set(value As Integer)
            _bottomLeft = value
        End Set
    End Property

    <Browsable(True), DefaultValue(30), Description("Sets the bottom-right corner radius.")>
    Public Property BottomRight As Integer
        Get
            Return _bottomRight
        End Get
        Set(value As Integer)
            _bottomRight = value
        End Set
    End Property

    ' Override ToString so that the property displays "CornerRadius" instead of (Collection)
    Public Overrides Function ToString() As String
        Return $"({TopLeft}, {TopRight}, {BottomLeft}, {BottomRight})"
    End Function
End Class

' Custom button class
Public Class CustomButton
    Inherits Control

    ' Properties
    Private _cornerRadius As New CornerRadius()
    Private _textColor As Color = Color.Black
    Private _borderColor As Color = Color.Black
    Private _borderSize As Integer = 2
    Private _hoverColor As Color = Color.LightGray
    Private _defaultBackColor As Color
    Private _buttonIcon As Image
    Private _iconSize As Size = New Size(24, 24)

    ' Corner Radius Property (Grouped)
    <Browsable(True), Category("Appearance"), Description("Sets the corner radius of the button.")>
    Public Property CornerRadii As CornerRadius
        Get
            Return _cornerRadius
        End Get
        Set(value As CornerRadius)
            _cornerRadius = value
            Me.Invalidate()
        End Set
    End Property

    ' Button Text Property
    <Browsable(True), Category("Appearance"), Description("Sets the text displayed on the button.")>
    Public Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(value As String)
            MyBase.Text = value
            Me.Invalidate()
        End Set
    End Property

    ' Button Icon Property
    <Browsable(True), Category("Appearance"), Description("Sets the icon displayed on the button.")>
    Public Property ButtonIcon As Image
        Get
            Return _buttonIcon
        End Get
        Set(value As Image)
            _buttonIcon = value
            Me.Invalidate()
        End Set
    End Property

    ' Icon Size Property
    <Browsable(True), Category("Appearance"), DefaultValue(GetType(Size), "24, 24"), Description("Sets the size of the icon.")>
    Public Property IconSize As Size
        Get
            Return _iconSize
        End Get
        Set(value As Size)
            _iconSize = value
            Me.Invalidate()
        End Set
    End Property

    ' Constructor
    Public Sub New()
        Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.BackColor = Color.White
        _defaultBackColor = Me.BackColor
        Me.Cursor = Cursors.Hand
        Me.Size = New Size(120, 40) ' Default size

        ' Event handlers for hover effect
        AddHandler Me.MouseEnter, AddressOf OnMouseEnter
        AddHandler Me.MouseLeave, AddressOf OnMouseLeave
        AddHandler Me.MouseDown, AddressOf OnMouseDown
        AddHandler Me.MouseUp, AddressOf OnMouseUp
    End Sub

    ' Hover Effects
    Private Sub OnMouseEnter(sender As Object, e As EventArgs)
        Me.BackColor = _hoverColor
    End Sub

    Private Sub OnMouseLeave(sender As Object, e As EventArgs)
        Me.BackColor = _defaultBackColor
    End Sub

    Private Sub OnMouseDown(sender As Object, e As MouseEventArgs)
        Me.BackColor = ControlPaint.Dark(_hoverColor)
    End Sub

    Private Sub OnMouseUp(sender As Object, e As MouseEventArgs)
        Me.BackColor = _hoverColor
    End Sub

    ' Paint the Button (Fix: Add Icon and Text)
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        Dim rect As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim path As GraphicsPath = GetRoundedRectanglePath(rect)

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

        ' === Draw Icon and Text ===
        Dim textX As Integer = 0
        Dim textY As Integer = 0
        Dim iconX As Integer = 0
        Dim iconY As Integer = 0

        ' Calculate positions
        Dim hasIcon As Boolean = _buttonIcon IsNot Nothing
        Dim hasText As Boolean = Not String.IsNullOrEmpty(Me.Text)

        ' Get text size
        Dim textSize As SizeF = e.Graphics.MeasureString(Me.Text, Me.Font)

        ' Set base positions
        If hasIcon Then
            iconX = (Me.Width - _iconSize.Width) \ 2  ' Center icon horizontally
            iconY = (Me.Height - _iconSize.Height) \ 2 ' Center icon vertically

            If hasText Then
                ' Adjust icon and text positions
                iconX = (Me.Width - (_iconSize.Width + textSize.Width + 5)) \ 2
                textX = iconX + _iconSize.Width + 5
                textY = (Me.Height - textSize.Height) \ 2
            End If
        ElseIf hasText Then
            ' Only text, center it
            textX = (Me.Width - textSize.Width) \ 2
            textY = (Me.Height - textSize.Height) \ 2
        End If

        ' Draw Icon
        If hasIcon Then
            e.Graphics.DrawImage(_buttonIcon, iconX, iconY, _iconSize.Width, _iconSize.Height)
        End If

        ' Draw Text
        If hasText Then
            Using textBrush As New SolidBrush(_textColor)
                e.Graphics.DrawString(Me.Text, Me.Font, textBrush, textX, textY)
            End Using
        End If
    End Sub


    ' Generate Rounded Rectangle with Custom Corners (Fix: Handle zero-radius corners)
    Private Function GetRoundedRectanglePath(rect As Rectangle) As GraphicsPath
        Dim path As New GraphicsPath()

        path.StartFigure()

        ' Top-Left Corner
        If _cornerRadius.TopLeft > 0 Then
            path.AddArc(rect.X, rect.Y, _cornerRadius.TopLeft * 2, _cornerRadius.TopLeft * 2, 180, 90)
        Else
            path.AddLine(rect.X, rect.Y, rect.X + _cornerRadius.TopLeft, rect.Y)
        End If

        ' Top Edge
        path.AddLine(rect.X + _cornerRadius.TopLeft, rect.Y, rect.Right - _cornerRadius.TopRight, rect.Y)

        ' Top-Right Corner
        If _cornerRadius.TopRight > 0 Then
            path.AddArc(rect.Right - _cornerRadius.TopRight * 2, rect.Y, _cornerRadius.TopRight * 2, _cornerRadius.TopRight * 2, 270, 90)
        Else
            path.AddLine(rect.Right, rect.Y, rect.Right, rect.Y + _cornerRadius.TopRight)
        End If

        ' Right Edge
        path.AddLine(rect.Right, rect.Y + _cornerRadius.TopRight, rect.Right, rect.Bottom - _cornerRadius.BottomRight)

        ' Bottom-Right Corner
        If _cornerRadius.BottomRight > 0 Then
            path.AddArc(rect.Right - _cornerRadius.BottomRight * 2, rect.Bottom - _cornerRadius.BottomRight * 2, _cornerRadius.BottomRight * 2, _cornerRadius.BottomRight * 2, 0, 90)
        Else
            path.AddLine(rect.Right, rect.Bottom, rect.Right - _cornerRadius.BottomRight, rect.Bottom)
        End If

        ' Bottom Edge
        path.AddLine(rect.Right - _cornerRadius.BottomRight, rect.Bottom, rect.X + _cornerRadius.BottomLeft, rect.Bottom)

        ' Bottom-Left Corner
        If _cornerRadius.BottomLeft > 0 Then
            path.AddArc(rect.X, rect.Bottom - _cornerRadius.BottomLeft * 2, _cornerRadius.BottomLeft * 2, _cornerRadius.BottomLeft * 2, 90, 90)
        Else
            path.AddLine(rect.X, rect.Bottom, rect.X, rect.Bottom - _cornerRadius.BottomLeft)
        End If

        ' Left Edge
        path.AddLine(rect.X, rect.Bottom - _cornerRadius.BottomLeft, rect.X, rect.Y + _cornerRadius.TopLeft)

        path.CloseFigure()

        Return path
    End Function

End Class
