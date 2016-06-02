Imports System.Data.SqlClient
Imports Ck_P_AAT.ClsConnect
Public Class FrmReport

    Private Sub FrmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        ShowData()
        clsWriteLog.writeLog("Open Report")
    End Sub

    Private Sub ShowData()
        Dim ooClsGetData As New ClsGetData
        Dim dt As DataTable = ooClsGetData.Get_Report(DateTimePicker1.Value.ToString("dd/MM/yyyy"))
        If dt.Rows.Count > 0 Then
            DataGridView1.DataSource = dt
            FormatDgvSum()
            lbl_amount.Text = "Amount : " & DataGridView1.Rows.Count.ToString - 1 & "Items"
        Else
            DataGridView1.DataSource = Nothing
            lbl_amount.Text = "Amount : 0 Items"
        End If
    End Sub

    Private Sub FormatDgvSum()
        With DataGridView1
            If .RowCount > 0 Then
                .ReadOnly = True
                .Columns(5).HeaderText = "Trim Rotation"
                .Columns(5).Width = 160
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .BackgroundColor = Color.White
            End If
        End With
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        ShowData()
    End Sub
End Class