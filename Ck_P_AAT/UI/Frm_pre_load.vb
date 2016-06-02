Imports System.Data.SqlClient
Imports Ck_P_AAT.ClsConnect
Public Class Frm_pre_load
    Dim sort As String

    Private Sub Frm_pre_load_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

        If e.KeyCode = Keys.Enter Then
            SortData()
        End If
    End Sub

    Private Sub Frm_pre_load_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Connection()
        SortData()
    End Sub

    Private Sub SortData()
        If Chk_sort_trim.Checked = True Then
            sort = "asc"
        ElseIf Chk_sort_trim.Checked = False Then
            sort = "desc"
        End If
        Try

            sb.Remove(0, sb.Length)
            sb.Append(" SELECT tblOrder.DateRecv, tblOrder.Header, tblOrder.Suppliers, tblOrder.Model,")
            sb.Append(" tblOrder.EcssDate, tblOrder.TrmRotation,Part_List.N_PN,tblOrder.PartNo, tblOrder.PntName ")
            sb.Append(",tblOrder.VIN,tblOrder.bcPrint")
            sb.Append(" FROM tblOrder LEFT JOIN  Part_List ON tblOrder.PartNo = Part_List.A_PN ")
            sb.Append(" where tblOrder.DateRecv Like '%" & Now.ToString("dd/MM/yyyy") & "%'")
            'sb.Append(" AND  (TrmRotation >= '" & seq1 & "') AND (TrmRotation <= '" & seq2 & "')")
            If Ck_SortDate.Checked = False Then
                sb.Append(" and bcPrint='0'order by Trmrotation " & sort)
            ElseIf Ck_SortDate.Checked = True Then
                sb.Append(" and bcPrint='0' order by DateRecv " & sort)
            End If
            Dim sqlShow As String = sb.ToString()
            Com = New SqlCommand()
            With Com
                .CommandType = CommandType.Text
                .CommandText = sqlShow
                .Connection = Conn
                dr = .ExecuteReader()
                If dr.HasRows Then
                    dt = New DataTable()
                    dt.Load(dr)
                    DataGridView1.DataSource = dt
                    FormattHeaders()
                    'txt_cf_part.Focus()
                Else
                    DataGridView1.DataSource = Nothing
                End If
            End With
            dr.Close()
        Catch

        End Try
    End Sub

    Private Sub FormattHeaders()
        Me.DataGridView1.EnableHeadersVisualStyles = False

        With DataGridView1.ColumnHeadersDefaultCellStyle
            .Alignment = DataGridViewContentAlignment.MiddleCenter
            '.BackColor = Color.DarkRed
            '.ForeColor = Color.Gold
            .Font = New Font(.Font.FontFamily, .Font.Size, _
             .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With
        FormatDgvSum()
    End Sub

    Private Sub FormatDgvSum()
        With DataGridView1
            If .RowCount > 0 Then
                '.ReadOnly = True
                '.Columns(0).HeaderText = "Model"
                '.Columns(1).HeaderText = "Date"
                '.Columns(2).HeaderText = "FMA"
                '.Columns(3).HeaderText = "Part Code"
                '.Columns(4).HeaderText = "Total"
                .Columns(0).Width = 150
                '.Columns(1).Width = 100
                .Columns(7).Width = 150
                .Columns(8).Width = 150
                .Columns(9).Width = 150
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .BackgroundColor = Color.White
                '.Enabled = False
                .ReadOnly = True
            End If
        End With
        'Me.DataGridView1.FirstDisplayedScrollingRowIndex = Me.DataGridView1.RowCount - 1
    End Sub

    Private Sub Chk_sort_trim_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_sort_trim.CheckedChanged
        SortData()
    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        If e.RowIndex = DataGridView1.Rows.Count - 1 Then
            Exit Sub
        End If
        With DataGridView1

            lbl_trim.Text = "Trim Rotation : " & CStr(.Rows.Item(e.RowIndex).Cells(5).Value.ToString())
            lbl_n_part.Text = "NHKANT Part : " & CStr(.Rows.Item(e.RowIndex).Cells(6).Value.ToString())
            lbl_f_part.Text = "AAT Part : " & CStr(.Rows.Item(e.RowIndex).Cells(7).Value.ToString())

        End With
    End Sub

    Private Sub Ck_SortDate_CheckedChanged(sender As Object, e As EventArgs) Handles Ck_SortDate.CheckedChanged
        SortData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SortData()
    End Sub
End Class