Imports System.Data.SqlClient
Imports Ck_P_AAT.ClsConnect
Public Class FrmWire
    Dim Action As String = String.Empty
    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Me.Close()
    End Sub

    Private Sub FrmWire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()
        ShowData()
    End Sub

    Private Sub ShowData()
        sb.Remove(0, sb.Length)
        sb.Append(" SELECT * FROM tb_wire ")
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
                Me.Text = "Data Wire Amount : " & DataGridView1.Rows.Count - 1 & " Items"
            Else
                DataGridView1.DataSource = Nothing
            End If
        End With
        dr.Close()
        FormatDgv()
        LockControl(False)
    End Sub

    Private Sub FormatDgv()
        Dim cs As New DataGridViewCellStyle
        cs.Font = New Font("Ms Sans Serif", 10, FontStyle.Bold)
        With DataGridView1
            If .RowCount > 0 Then
                .ColumnHeadersDefaultCellStyle = cs
                .ReadOnly = True

                .Columns(0).HeaderText = "ID"
                .Columns(1).HeaderText = "Part No."
                .Columns(2).HeaderText = "OHC No."

                .Columns(0).Width = 150
                .Columns(1).Width = 150
                .Columns(2).Width = 150
                .AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen
                .BackgroundColor = Color.White
            End If
        End With
    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        If e.RowIndex = DataGridView1.Rows.Count - 1 Then
            Exit Sub
        End If
        With DataGridView1
            txt_id.Text = CStr(.Rows.Item(e.RowIndex).Cells(0).Value.ToString())
            txt_wire.Text = CStr(.Rows.Item(e.RowIndex).Cells(1).Value.ToString())
            txt_ohc.Text = CStr(.Rows.Item(e.RowIndex).Cells(2).Value.ToString())
        End With
    End Sub

    Private Sub DataGridView1_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles DataGridView1.RowPostPaint
        'สร้างเลขบรรทัด
        Using b As SolidBrush = New SolidBrush(DataGridView1.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString((e.RowIndex + 1).ToString(System.Globalization.CultureInfo.CurrentUICulture), _
                  sender.DefaultCellStyle.Font, _
                  b, _
                  e.RowBounds.Location.X + 40, _
                  e.RowBounds.Location.Y + 3, _
                  New StringFormat(StringFormatFlags.DirectionRightToLeft))
        End Using
    End Sub

    Private Sub TS_add_Click(sender As Object, e As EventArgs) Handles TS_add.Click
        Action = "add"
        txt_id.Clear() : txt_wire.Clear()
        txt_id.Focus()
        LockControl(True)
    End Sub

    Private Sub SaveData()
        Try
            tr = Conn.BeginTransaction()
            Dim sqlSave As String = sb.ToString()
            If Action = "add" Then
                sb.Remove(0, sb.Length)
                sb.Append("INSERT INTO  tb_wire(id_wire,no_wire,no_ohc)")
                sb.Append(" VALUES (@id_wire,@no_wire,@no_ohc)")
            ElseIf Action = "edit" Then
                sb.Remove(0, sb.Length)
                sb.Append("UPDATE tb_wire  SET no_wire=@no_wire,no_ohc=@no_ohc")
                sb.Append(" WHERE (id_wire=@id_wire)")
            End If
            sqlSave = sb.ToString()
            With Com
                .CommandType = CommandType.Text
                .CommandText = sqlSave
                .Connection = Conn
                .Transaction = tr
                .CommandText = sqlSave
                .Parameters.Clear()
                .Parameters.Add("@id_wire", SqlDbType.NVarChar).Value = txt_id.Text.Trim()
                .Parameters.Add("@no_wire", SqlDbType.NVarChar).Value = txt_wire.Text.Trim()
                .Parameters.Add("@no_ohc", SqlDbType.NVarChar).Value = txt_ohc.Text.Trim()
                .ExecuteNonQuery()
            End With
            tr.Commit()
            If Action = "add" Then
                MessageBox.Show("บันทึกข้อมูล รียบร้อยแล้ว", "ผลการทำงาน", MessageBoxButtons.OK, _
                            MessageBoxIcon.Information)
            ElseIf Action = "edit" Then
                MessageBox.Show("แก้ไขข้อมูล รียบร้อยแล้ว", "ผลการทำงาน", MessageBoxButtons.OK, _
                            MessageBoxIcon.Information)
            End If
            ShowData()
            FormatDgv()
        Catch ex As Exception
            tr.Rollback()
            MessageBox.Show("เกิดข้อผิดพลาด เนื่องจาก " & ex.Message, "ผลการทำงาน", MessageBoxButtons.OK, _
                            MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub TS_save_Click(sender As Object, e As EventArgs) Handles TS_save.Click
        SaveData()
    End Sub

    Private Sub TS_Edit_Click(sender As Object, e As EventArgs) Handles TS_Edit.Click
        Action = "edit"
        LockControl(True)
        txt_wire.Focus()
    End Sub

    Private Sub LockControl(ByVal isEnabel As Boolean)
        txt_id.Enabled = isEnabel
        txt_wire.Enabled = isEnabel
        txt_ohc.Enabled = isEnabel
        DataGridView1.Enabled = Not isEnabel

        TS_add.Enabled = Not isEnabel
        TS_Del.Enabled = Not isEnabel
        TS_Edit.Enabled = Not isEnabel

        TS_save.Enabled = isEnabel
    End Sub

    Private Sub TS_Del_Click(sender As Object, e As EventArgs) Handles TS_Del.Click
        If MessageBox.Show("คุณต้องการลบข้อมูล ใช่หรือไม่?", "คำยืนยัน", MessageBoxButtons.YesNo, _
                     MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            tr = Conn.BeginTransaction()
            Try
                sb.Remove(0, sb.Length)
                sb.Append("Delete From tb_wire WHERE id_wire=@id_wire")

                Dim sqldel As String
                sqldel = sb.ToString()

                With Com
                    .CommandText = sqldel
                    .CommandType = CommandType.Text
                    .Connection = Conn
                    .Transaction = tr
                    .Parameters.Clear()
                    .Parameters.Add("@id_wire", SqlDbType.VarChar).Value = txt_id.Text.Trim()
                    Dim result As Integer
                    result = .ExecuteNonQuery()
                    If result = 0 Then
                        tr.Rollback()
                        MessageBox.Show("รหัสที่คุณป้อน ไม่ถูกต้อง !!!", "ผลการทำงาน", MessageBoxButtons.OK, _
                                      MessageBoxIcon.Information)
                        txt_id.SelectAll()
                    Else
                        tr.Commit()
                        MessageBox.Show("ลบข้อมูล เรียบร้อยแล้ว !!!", "ผลการทำงาน", MessageBoxButtons.OK, _
                                        MessageBoxIcon.Information)
                        LockControl(False)
                        ShowData()
                    End If
                End With
            Catch ex As Exception
                tr.Rollback()
                MessageBox.Show("เกิดข้อผิดพลาด เนื่องจาก " & ex.Message, "ผลการทำงาน", MessageBoxButtons.OK, _
                                MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub Ts_refresh_Click(sender As Object, e As EventArgs) Handles Ts_refresh.Click
        ShowData()
    End Sub

    Private Sub txt_find_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_find.KeyDown
        If e.KeyCode = Keys.Enter Then
            Find()
        End If
    End Sub

    Private Sub Find()
        sb.Remove(0, sb.Length)
        sb.Append(" SELECT * FROM tb_wire where id_wire LIKE '%" & txt_find.Text.Trim() & "%'")
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
            Else
                DataGridView1.DataSource = Nothing
            End If
        End With
        dr.Close()
        FormatDgv()
        LockControl(False)
    End Sub

    Private Sub txt_find_TextChanged(sender As Object, e As EventArgs) Handles txt_find.TextChanged

    End Sub
End Class