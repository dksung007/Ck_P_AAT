Imports System.ComponentModel
Public Class WM_bc_Rack
    Inherits TextBox
    Dim waterTxt As String
    Dim waterColor As Color
    Dim waterFont As Font
    Dim waterBrush As SolidBrush
    Dim waterContainer As Panel

    Public Sub New()
        MyBase.New()
        StartProcess()
    End Sub

    Private Sub StartProcess()
        waterTxt = "Barcode Rack Summary"
        waterColor = Color.Gray
        waterFont = New Font(Me.Font, FontStyle.Italic)
        waterBrush = New SolidBrush(waterColor)

        CreateWatermark()
        AddHandler TextChanged, AddressOf ChangeText
        AddHandler FontChanged, AddressOf ChangeFont

    End Sub

    Private Sub CreateWatermark()
        waterContainer = New Panel
        Me.Controls.Add(waterContainer)
        AddHandler waterContainer.Click, AddressOf Clicked
        AddHandler waterContainer.Paint, AddressOf Painted

    End Sub

    Private Sub RemoveWatermark()
        Me.Controls.Remove(waterContainer)
    End Sub

    Private Sub ChangeText(sender As Object, e As EventArgs)
        If Me.TextLength <= 0 Then
            CreateWatermark()
        ElseIf Me.TextLength > 0 Then
            RemoveWatermark()
        End If
    End Sub

    Private Sub ChangeFont(sender As Object, e As EventArgs)
        waterFont = New Font(Me.Font, FontStyle.Italic)
    End Sub

    Private Sub Clicked(sender As Object, e As EventArgs)
        Me.Focus()
    End Sub

    Private Sub Painted(sender As Object, e As PaintEventArgs)
        waterContainer.Location = New Point(2, 0)
        waterContainer.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        waterContainer.Height = Me.Height
        waterContainer.Width = Me.Width
        waterBrush = New SolidBrush(waterColor)

        Dim Graphic As Graphics = e.Graphics
        Graphic.DrawString(waterTxt, waterFont, waterBrush, New PointF(-2.0!, 1.0!))
    End Sub

    Protected Overrides Sub OnInvalidated(e As InvalidateEventArgs)
        MyBase.OnInvalidated(e)
        waterContainer.Invalidate()

    End Sub
    <Category("Watermark Attributes"), Description("Sets Watermark Text")> Public Property waterMarkText As String
        Get
            Return waterTxt
        End Get
        Set(value As String)
            waterTxt = value
            Me.Invalidate()

        End Set
    End Property

    <Category("Watermark Attributes"), Description("Sets Watermark Color")> Public Property waterMarkColor As Color
        Get
            Return waterColor

        End Get
        Set(value As Color)
            waterColor = value
            Me.Invalidate()
        End Set
    End Property
End Class