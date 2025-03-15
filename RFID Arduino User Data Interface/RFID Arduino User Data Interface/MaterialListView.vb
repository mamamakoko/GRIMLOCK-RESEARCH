Imports System.Drawing
Imports System.Windows.Forms
Imports MaterialSkin.Controls

Public Class CustomMaterialListView
    Inherits MaterialListView

    Private _headerBackColor As Color = Color.DarkBlue
    Private _headerForeColor As Color = Color.White
    Private _oddRowColor As Color = Color.LightGray
    Private _evenRowColor As Color = Color.White
    Private _columnBackColor As Color = Color.LightSkyBlue
    Private _columnForeColor As Color = Color.Black

    ' Property for Header Background Color
    Public Property HeaderBackColor As Color
        Get
            Return _headerBackColor
        End Get
        Set(value As Color)
            _headerBackColor = value
            Me.Invalidate() ' Redraw ListView
        End Set
    End Property

    ' Property for Header Foreground Color
    Public Property HeaderForeColor As Color
        Get
            Return _headerForeColor
        End Get
        Set(value As Color)
            _headerForeColor = value
            Me.Invalidate()
        End Set
    End Property

    ' Property for Odd Row Color
    Public Property OddRowColor As Color
        Get
            Return _oddRowColor
        End Get
        Set(value As Color)
            _oddRowColor = value
            Me.Invalidate()
        End Set
    End Property

    ' Property for Even Row Color
    Public Property EvenRowColor As Color
        Get
            Return _evenRowColor
        End Get
        Set(value As Color)
            _evenRowColor = value
            Me.Invalidate()
        End Set
    End Property

    ' Property for Column Background Color
    Public Property ColumnBackColor As Color
        Get
            Return _columnBackColor
        End Get
        Set(value As Color)
            _columnBackColor = value
            Me.Invalidate()
        End Set
    End Property

    ' Property for Column Foreground Color
    Public Property ColumnForeColor As Color
        Get
            Return _columnForeColor
        End Get
        Set(value As Color)
            _columnForeColor = value
            Me.Invalidate()
        End Set
    End Property

    ' Override the header drawing
    Protected Overrides Sub OnDrawColumnHeader(e As DrawListViewColumnHeaderEventArgs)
        Using brush As New SolidBrush(_headerBackColor)
            e.Graphics.FillRectangle(brush, e.Bounds)
        End Using

        Dim format As New StringFormat() With {
            .Alignment = StringAlignment.Center,
            .LineAlignment = StringAlignment.Center
        }

        Using textBrush As New SolidBrush(_headerForeColor)
            e.Graphics.DrawString(e.Header.Text, Me.Font, textBrush, e.Bounds, format)
        End Using
    End Sub

    ' Override row drawing (for alternating colors)
    Protected Overrides Sub OnDrawSubItem(e As DrawListViewSubItemEventArgs)
        Dim rowColor As Color = If(e.Item.Index Mod 2 = 0, _evenRowColor, _oddRowColor)

        Using brush As New SolidBrush(rowColor)
            e.Graphics.FillRectangle(brush, e.Bounds)
        End Using

        Dim format As New StringFormat() With {
            .Alignment = StringAlignment.Center,
            .LineAlignment = StringAlignment.Center
        }

        Using textBrush As New SolidBrush(_columnForeColor)
            e.Graphics.DrawString(e.SubItem.Text, Me.Font, textBrush, e.Bounds, format)
        End Using
    End Sub
End Class
