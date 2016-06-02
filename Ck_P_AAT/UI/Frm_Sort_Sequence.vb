Imports System.Data.SqlClient
Imports System.Text
Imports Ck_P_AAT.ClsConnect
Public Class Frm_Sort_Sequence

    Dim data As String = String.Empty
    Dim data1 As String = String.Empty
    Dim PathSound As String = "C:\Windows\Media\Windows Ringout.wav"
    Dim PlaySound As New System.Media.SoundPlayer
    Dim PartNo As String = String.Empty
    Dim Str() As String
    Private wire, ck_ohc As String
    Dim OHC(), _wire(), cf_part() As String
    Dim seq1, seq2, a As String
    Public sequence, _time As String

    Private Sub Frm_Sort_Sequence_Click(sender As Object, e As EventArgs) Handles Me.Click
        txt_cf_part.Focus()
    End Sub

    Private Sub Frm_Sort_Sequence_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        FrmCk_Part.ShowData()
    End Sub

    Private Sub Frm_Sort_Sequence_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Connection()
        seq1 = sequence
        seq2 = sequence + 9
        SortData()

        PlaySound.SoundLocation = PathSound
        PlaySound.Load()

        txt_cf_label.Enabled = False
        txt_s_wire.Enabled = False
        txt_cf_rack.Enabled = False
        txt_s_ohc.Enabled = False
        clsWriteLog.writeLog("Open Form Sort Data")

    End Sub

    Private Sub SortData()
        Try
            sb.Remove(0, sb.Length)
            sb.Append(" SELECT tblOrder.DateRecv, tblOrder.Header, tblOrder.Suppliers, tblOrder.Model,")
            sb.Append(" tblOrder.EcssDate, tblOrder.TrmRotation,Part_List.N_PN,tblOrder.PartNo, tblOrder.PntName ")
            sb.Append(",tblOrder.VIN,tblOrder.bcPrint")
            'sb.Append(" FROM tblOrder LEFT JOIN  Part_List ON tblOrder.PartNo = Part_List.A_PN ")
            sb.Append(" FROM tblOrder INNER JOIN  Part_List ON tblOrder.PartNo = Part_List.A_PN ")
            sb.Append(" where tblOrder.DateRecv Like '%" & _time & "%'")
            sb.Append(" AND  (TrmRotation >= '" & seq1 & "') AND (TrmRotation <= '" & seq2 & "')")
            If Ck_SortDate.Checked = False Then
                sb.Append(" and bcPrint='1'order by Footer1 desc")
            ElseIf Ck_SortDate.Checked = True Then
                sb.Append(" and bcPrint='1' order by DateRecv desc")
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
                    txt_cf_part.Focus()
                Else
                    DataGridView1.DataSource = Nothing
                End If
            End With
            dr.Close()
            clsWriteLog.writeLog("SortData finish")
        Catch ex As Exception
            clsWriteLog.writeLog("Sort Data >>>>" & ex.Message)
        End Try
        txt_cf_part.Focus()
    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        If e.RowIndex = DataGridView1.Rows.Count - 1 Then
            Exit Sub
        End If
        With DataGridView1
            lbl_model.Text = CStr(.Rows.Item(e.RowIndex).Cells(3).Value.ToString())
            a = CStr(.Rows.Item(e.RowIndex).Cells(5).Value.ToString())
            lbl_part.Text = CStr(.Rows.Item(e.RowIndex).Cells(7).Value.ToString())
            PartNo = CStr(.Rows.Item(e.RowIndex).Cells(7).Value.ToString())

            Str = PartNo.Split(Chr(34), "-")
            lbl_seq.Text = CStr(.Rows.Item(e.RowIndex).Cells(4).Value.ToString.Substring(0, 4)) _
               + CStr(.Rows.Item(e.RowIndex).Cells(4).Value.ToString.Substring(5, 2)) _
               + CStr(.Rows.Item(e.RowIndex).Cells(4).Value.ToString.Substring(8, 2)) _
               + CStr(.Rows.Item(e.RowIndex).Cells(5).Value.ToString())
            .Enabled = False
            Show_wire()
        End With
    End Sub

    Private Sub Show_wire()
        Dim ds As New DataSet
        Dim sqltext As String
        sqltext = "SELECT * FROM tb_wire where id_wire='" & lbl_part.Text.Trim() & "'"
        da = New SqlDataAdapter(sqltext, Conn)
        da.Fill(ds, "tb_wire")
        If ds.Tables("tb_wire").Rows.Count <> 0 Then 'ถ้ามีเจอข้อมูลก็ให้แสดงข้อมูลขึ้นมา
            With ds.Tables("tb_wire")
                wire = .Rows(0)("no_wire").ToString()
                txt_s_wire.Text = .Rows(0)("no_wire").ToString()
                lbl_ohc.Text = .Rows(0)("no_ohc").ToString()
            End With
            clsWriteLog.writeLog("Show_wire working")
        Else
            clsWriteLog.writeLog("No data Show_wire")
        End If

    End Sub

    Private Sub txt_cf_part_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cf_part.KeyDown
        'If Ck_kanban.Checked = False Then
        '    data = Str(2)
        'ElseIf Ck_kanban.Checked = True Then
        '    data = lbl_part.Text.Trim
        'End If
        'Try
        '    If e.KeyCode = Keys.Enter Then
        '        If txt_cf_part.Text.Trim = data.Trim Then
        '            txt_cf_label.Enabled = True
        '            txt_cf_label.Focus()
        '            PictureBox1.Image = My.Resources.Normal
        '            clsWriteLog.writeLog("Scan complete Part : " & txt_cf_part.Text.Trim)
        '        Else
        '            e.SuppressKeyPress = True
        '            PlaySound.Play()
        '            PictureBox1.Image = My.Resources.Datajump
        '            clsWriteLog.writeLog("Scan Error Part")
        '            txt_cf_part.Clear()
        '            txt_cf_part.Focus()
        '        End If
        '    End If
        'Catch
        '    txt_cf_part.Clear()
        '    txt_cf_part.Focus()
        'End Try

        Try
            If Ck_kanban.Checked = False Then
                data = Str(2)
            ElseIf Ck_kanban.Checked = True Then
                data = lbl_part.Text.Trim
            End If
            If e.KeyCode = Keys.Enter Then
                cf_part = txt_cf_part.Text.Split(Chr(34), "-")
                If txt_cf_part.Text.Trim = data.Trim Then
                    txt_cf_label.Enabled = True
                    txt_cf_label.Focus()
                    PictureBox1.Image = My.Resources.Normal
                    clsWriteLog.writeLog("Scan complete Part : " & txt_cf_part.Text.Trim & " On labal Suffix only")
                ElseIf cf_part(0).Trim = data.Trim Then
                    txt_cf_label.Enabled = True
                    txt_cf_label.Focus()
                    PictureBox1.Image = My.Resources.Normal
                    clsWriteLog.writeLog("Scan complete Part : " & txt_cf_part.Text.Trim & "On label Suffix and ID")
                Else
                    e.SuppressKeyPress = True
                    PlaySound.Play()
                    PictureBox1.Image = My.Resources.Datajump
                    clsWriteLog.writeLog("Scan Error Part")
                    txt_cf_part.Clear()
                    txt_cf_part.Focus()
                End If
            End If
        Catch ex As Exception
            txt_cf_part.Clear()
            txt_cf_part.Focus()
            PictureBox1.Image = My.Resources.Datajump
            clsWriteLog.writeLog("Scan Error Part >>>>> " & ex.Message)
        End Try

    End Sub

    Private Sub txt_cf_label_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cf_label.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_cf_label.Text.Trim = lbl_seq.Text.Trim Then
                txt_s_wire.Enabled = True
                txt_s_wire.Clear()
                txt_s_wire.Focus()
                PictureBox1.Image = My.Resources.Normal
                clsWriteLog.writeLog("Scan complete label : " & txt_cf_label.Text.Trim)
            Else
                e.SuppressKeyPress = True
                PlaySound.Play()
                PictureBox1.Image = My.Resources.Datajump
                clsWriteLog.writeLog("Scan Error Wire")
                txt_cf_label.Clear()
                txt_cf_label.Focus()
            End If
        End If
    End Sub

    Private Sub txt_s_wire_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_s_wire.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_s_wire.Text.Trim = wire.Trim Then
                If lbl_model.Text.Trim() = "U375" Then
                    txt_s_ohc.Enabled = True
                    txt_s_ohc.Focus()
                    clsWriteLog.writeLog("Scan complete Wire : " & txt_s_wire.Text.Trim)
                Else
                    txt_cf_rack.Enabled = True
                    txt_cf_rack.Focus()
                    PictureBox1.Image = My.Resources.Normal
                    clsWriteLog.writeLog("Scan complete Wire : " & txt_s_wire.Text.Trim)
                End If
            Else
                e.SuppressKeyPress = True
                PlaySound.Play()
                PictureBox1.Image = My.Resources.Datajump
                txt_s_wire.Clear()
                txt_s_wire.Focus()
            End If
        End If
    End Sub

    Private Sub txt_cf_rack_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cf_rack.KeyDown
        If Ck_kanban.Checked = False Then
            data = Str(2)
        ElseIf Ck_kanban.Checked = True Then
            data = lbl_part.Text.Trim
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cf_rack.Text.Trim = lbl_seq.Text.Trim Then
                PictureBox1.Image = My.Resources.Normal
                clsWriteLog.writeLog("Scan complete RCK SUM : " & txt_cf_rack.Text.Trim)
                check_id_stock()
                Update_status()
            Else
                PlaySound.Play()
                PictureBox1.Image = My.Resources.Datajump
                clsWriteLog.writeLog("Scan Error RCK SUM")
                txt_cf_rack.Clear()
                txt_cf_rack.Focus()
            End If
        End If
    End Sub

    Private Sub check_id_stock()
        Try
            Dim Conn As New SqlConnection
            Dim sb As New StringBuilder
            Dim Com As New SqlCommand
            Conn = New SqlConnection(ClsConnect.Conn_db_stock)
            With Conn
                .ConnectionString = ClsConnect.Conn_db_stock
                .Open()
            End With
            Dim ds As New DataSet
            Dim sql As String
            sql = " select SEQ from tb_st_u375 where SEQ='" & txt_cf_part.Text.Trim & "' AND S_PD=1 AND S_CF=0"
            da = New SqlDataAdapter(sql, ClsConnect.Conn_db_stock)
            da.Fill(ds, "data_stock")
            If ds.Tables("data_stock").Rows.Count <> 0 Then
                clsWriteLog.writeLog("check_id_stock working")
                'update_status_stock()
                Dim sqlSave As String = sb.ToString()
                sqlSave = " update tb_st_u375 Set S_CF=1,Sequence='" & a & "',Date_Sequence='" & Now.ToString("dd/MM/yyyy HH:mm:ss tt") & "'"
                sqlSave &= " where SEQ ='" & txt_cf_part.Text.Trim & "' and S_CF=0 and S_PD =1"
                With Com
                    .CommandType = CommandType.Text
                    .CommandText = sqlSave
                    .Connection = Conn
                    .ExecuteNonQuery()
                    clsWriteLog.writeLog("update_status_stock finish")
                End With
            Else
                clsWriteLog.writeLog("check_id_stock working not have data")
            End If
        Catch ex As Exception
            clsWriteLog.writeLog(ex.Message)
        End Try
    End Sub

    Private Sub Update_status()
        Connection()
        Dim sqlSave As String = sb.ToString()
        Try
            'sqlSave = " UPDATE tblOrder Set bcPrint= '2'" 'Old Database
            sqlSave = " UPDATE  tblOrder Set bcPrint= '2'"
            sqlSave &= " WHERE PartNo ='" & lbl_part.Text.Trim() & "' And TrmRotation ='" & _
               Microsoft.VisualBasic.Right(txt_cf_label.Text.Trim(), 4) & "'"

            With Com
                .CommandType = CommandType.Text
                .CommandText = sqlSave
                .Connection = Conn
                .ExecuteNonQuery()
            End With
            clsWriteLog.writeLog("Update Status : " & a)
            SortData()
        Catch
            PlaySound.Play()
        End Try
        txt_cf_label.Clear() : txt_cf_part.Clear() : txt_cf_rack.Clear() : txt_s_ohc.Clear()
        txt_cf_label.Enabled = False
        txt_s_wire.Enabled = False
        txt_cf_rack.Enabled = False
        txt_s_ohc.Enabled = False
        txt_cf_part.Focus()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'Connection()
        'Dim sqlSave As String = sb.ToString()
        'Try
        '    'sqlSave = " UPDATE tblOrder Set bcPrint= '2'" 'Old Database
        '    sqlSave = " UPDATE  tblOrder Set bcPrint= '2'"
        '    sqlSave &= " WHERE PartNo ='" & lbl_part.Text.Trim() & "' And TrmRotation ='" & _
        '       Microsoft.VisualBasic.Right(lbl_seq.Text.Trim(), 4) & "'"

        '    With Com
        '        .CommandType = CommandType.Text
        '        .CommandText = sqlSave
        '        .Connection = Conn
        '        .ExecuteNonQuery()
        '    End With
        '    clsWriteLog.writeLog("Jump Trim : " & a)
        '    SortData()
        'Catch
        '    PlaySound.Play()
        'End Try
    End Sub

    Private Sub FormattHeaders()
        Me.DataGridView1.EnableHeadersVisualStyles = False
        With DataGridView1.ColumnHeadersDefaultCellStyle
            .Alignment = DataGridViewContentAlignment.MiddleCenter
            .Font = New Font(.Font.FontFamily, .Font.Size, _
             .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With
        FormatDgvSum()
    End Sub

    Private Sub FormatDgvSum()
        With DataGridView1
            If .RowCount > 0 Then
                .Columns(0).Width = 150
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
                .Enabled = False
                .ReadOnly = True
            End If
        End With

    End Sub

    Private Sub pic_AAT_Click(sender As Object, e As EventArgs) Handles pic_AAT.Click
        txt_cf_part.Focus()
    End Sub

    Private Sub txt_s_ohc_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_s_ohc.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                ck_ohc = txt_s_ohc.Text
                OHC = ck_ohc.Split(Chr(34), "-")
                data1 = OHC(0) & "-" & OHC(1) & "-" & OHC(2)
                If data1.Trim() = lbl_ohc.Text.Trim() Then
                    txt_cf_rack.Enabled = True
                    txt_cf_rack.Focus()
                    PictureBox1.Image = My.Resources.Normal
                    clsWriteLog.writeLog("Scan complete OHC : " & lbl_ohc.Text.Trim)
                Else
                    e.SuppressKeyPress = True
                    PlaySound.Play()
                    txt_s_ohc.Clear()
                    PictureBox1.Image = My.Resources.Datajump
                    clsWriteLog.writeLog("Scan Error OHC")
                End If
            End If
        Catch
            e.SuppressKeyPress = True
            clsWriteLog.writeLog("Scan Error OHC")
            PlaySound.Play()
            txt_s_ohc.Clear()
            PictureBox1.Image = My.Resources.Datajump
        End Try
    End Sub

End Class