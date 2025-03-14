Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Public Class CustomListView
    Inherits ListView

    ' Custom Properties
    Private _headerColor As Color = Color.DarkSlateGray
    Private _headerTextColor As Color = Color.White
    Private _evenRowColor As Color = Color.LightGray
    Private _oddRowColor As Color = Color.White

    ' Property: Header Background Color
    <Category("Appearance"), Description("Set the background color of the header"), Browsable(True)>
    Public Property HeaderColor As Color
        Get
            Return _headerColor
        End Get
        Set(value As Color)
            _headerColor = value
            Me.Invalidate()
            If Me.DesignMode Then Me.Refresh()
        End Set
    End Property

    ' Property: Header Text Color
    <Category("Appearance"), Description("Set the text color of the header"), Browsable(True)>
    Public Property HeaderTextColor As Color
        Get
            Return _headerTextColor
        End Get
        Set(value As Color)
            _headerTextColor = value
            Me.Invalidate()
            If Me.DesignMode Then Me.Refresh()
        End Set
    End Property

    ' Property: Even Row Color
    <Category("Appearance"), Description("Set the background color for even rows"), Browsable(True)>
    Public Property EvenRowColor As Color
        Get
            Return _evenRowColor
        End Get
        Set(value As Color)
            _evenRowColor = value
            Me.Invalidate()
            If Me.DesignMode Then Me.Refresh()
        End Set
    End Property

    ' Property: Odd Row Color
    <Category("Appearance"), Description("Set the background color for odd rows"), Browsable(True)>
    Public Property OddRowColor As Color
        Get
            Return _oddRowColor
        End Get
        Set(value As Color)
            _oddRowColor = value
            Me.Invalidate()
            If Me.DesignMode Then Me.Refresh()
        End Set
    End Property

    ' Constructor
    Public Sub New()
        Me.OwnerDraw = True
        Me.View = View.Details
        Me.FullRowSelect = True
        Me.DoubleBuffered = True
        SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
    End Sub

    ' Force repaint in Designer Mode
    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        MyBase.OnHandleCreated(e)
        If Me.DesignMode Then Me.Refresh()
    End Sub

    ' Draw the Header (Fix for Multiple Columns)
    Protected Overrides Sub OnDrawColumnHeader(e As DrawListViewColumnHeaderEventArgs)
        If Me.DesignMode Then
            e.DrawDefault = True ' Allow normal drawing in the designer
        Else
            e.DrawBackground()
            Using headerBrush As New SolidBrush(_headerColor)
                e.Graphics.FillRectangle(headerBrush, e.Bounds)
            End Using
            TextRenderer.DrawText(e.Graphics, e.Header.Text, e.Font, e.Bounds, _headerTextColor, TextFormatFlags.Left Or TextFormatFlags.VerticalCenter)
        End If
    End Sub

    ' Draw Items (Default)
    Protected Overrides Sub OnDrawItem(e As DrawListViewItemEventArgs)
        e.DrawDefault = True
    End Sub

    ' Draw SubItems (Custom Background)
    Protected Overrides Sub OnDrawSubItem(e As DrawListViewSubItemEventArgs)
        If Me.DesignMode Then Exit Sub ' Prevent errors in design mode

        Dim bgColor As Color = If(e.ItemIndex Mod 2 = 0, _evenRowColor, _oddRowColor)
        Using bgBrush As New SolidBrush(bgColor)
            e.Graphics.FillRectangle(bgBrush, e.Bounds)
        End Using

        ' Draw text
        TextRenderer.DrawText(e.Graphics, e.SubItem.Text, Me.Font, e.Bounds, Color.Black, TextFormatFlags.Left)
    End Sub
End Class
