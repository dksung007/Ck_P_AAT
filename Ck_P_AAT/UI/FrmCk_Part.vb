Imports Ck_P_AAT.ClsConnect

Public Class FrmCk_Part
    Private data As String = String.Empty
    Private PathSound As String = "C:\Windows\Media\Windows Ringout.wav"
    Private PlaySound As New System.Media.SoundPlayer
    Private PartNo As String = String.Empty
    Private Str(), OHC(), _wire(), cf_part() As String
    Private Wire, Check_OHC As String
    Private _Sequence As String = String.Empty
    Private ooCls_UpdateData As New Cls_UpdateData
    Private ooClsGetData As New ClsGetData
    Private Sub FrmCk_Part_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Conn.Close()
        clsWriteLog.writeLog("Close Program")
    End Sub

    Private Sub FrmCk_Part_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        'ClassConnect.Connection()
        ShowData()
        PlaySound.SoundLocation = PathSound
        PlaySound.Load()
        Lock_Control()
        clsWriteLog.writeLog("Start Program")
    End Sub

    Private Sub Lock_Control()
        WM_lbl_Trim1.Enabled = False
        WM_lbl_Trim1.Enabled = False
        WM_bc_Wire1.Enabled = False
        WM_lbl_Ohc1.Enabled = False
        WM_bc_Wire1.Enabled = False
        WM_bc_Rack1.Enabled = False
    End Sub

    Public Sub ShowData()
        'Dim ooClsGetData As New ClsGetData
        ooClsGetData.p_Date = DateTimePicker1.Value.ToString("dd/MM/yyyy")
        Dim dt As DataTable = ooClsGetData.Get_ShowData
        If dt.Rows.Count > 0 Then
            DataGridView1.DataSource = dt
            FormattHeaders()
            lbl_amount.Text = "Amount : " & DataGridView1.Rows.Count - 1 & " Items"
        Else
            DataGridView1.DataSource = dt
        End If
        Check_Wire()
        WM_lbl_Production1.Focus()
    End Sub

    Private Sub Check_Wire()
        'Dim ooClsGetData As New ClsGetData
        'ooClsGetData.p_PartNo = lbl_part.Text.Trim()
        'Dim dt As DataTable = ooClsGetData.Get_BOM
        'If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
        '    Wire = dt.Rows(0)("no_wire").ToString()
        '    WM_bc_Wire1.Text = dt.Rows(0)("no_wire").ToString()
        '    lbl_ohc.Text = dt.Rows(0)("no_ohc").ToString()
        'End If


        'Dim ooClsGetData As New ClsGetData
        Dim dt As DataTable = ooClsGetData.getData_BOM_U375(lbl_part.Text.Trim())
        If dt.Rows.Count > 0 Then
            Wire = dt.Rows(0)("u_wire").ToString()
            WM_bc_Wire1.Text = dt.Rows(0)("u_wire").ToString()
            lbl_ohc.Text = dt.Rows(0)("u_ohc").ToString()
        Else
            Wire_P375()
        End If
    End Sub

    Private Sub Wire_P375()
        'Dim ooClsGetData As New ClsGetData
        Dim dt As DataTable = ooClsGetData.getData_BOM_P375(lbl_part.Text.Trim())
        If dt.Rows.Count > 0 Then
            Wire = dt.Rows(0)("Wire").ToString()
            WM_bc_Wire1.Text = dt.Rows(0)("Wire").ToString()
            lbl_ohc.Text = "-"
        Else
            Wire = String.Empty
            WM_bc_Rack1.Text = "-"
            lbl_ohc.Text = "-"
        End If
    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        If e.RowIndex = DataGridView1.Rows.Count - 1 Then
            Exit Sub
        End If
        With DataGridView1
            lbl_model.Text = CStr(.Rows.Item(e.RowIndex).Cells(3).Value.ToString())
            _Sequence = CStr(.Rows.Item(e.RowIndex).Cells(5).Value.ToString())
            lbl_part.Text = CStr(.Rows.Item(e.RowIndex).Cells(7).Value.ToString())
            PartNo = CStr(.Rows.Item(e.RowIndex).Cells(7).Value.ToString())
            Str = PartNo.Split(Chr(34), "-")
            lbl_EcssDate.Text = CStr(.Rows.Item(e.RowIndex).Cells(4).Value.ToString.Substring(0, 4)) _
               + CStr(.Rows.Item(e.RowIndex).Cells(4).Value.ToString.Substring(5, 2)) _
               + CStr(.Rows.Item(e.RowIndex).Cells(4).Value.ToString.Substring(8, 2)) _
               + CStr(.Rows.Item(e.RowIndex).Cells(5).Value.ToString())
            lbl_trim.Text = "Trim Rotation : " & _Sequence
            ts_last_time.Text = "Last Time : " & CStr(.Rows.Item(e.RowIndex).Cells(10).Value.ToString())
        End With
    End Sub

    Private Sub FormattHeaders()
        Me.DataGridView1.EnableHeadersVisualStyles = False
        With DataGridView1.ColumnHeadersDefaultCellStyle
            .Alignment = DataGridViewContentAlignment.MiddleCenter
            .Font = New Font(.Font.FontFamily, .Font.Size, _
             .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With
        FormatDgv()
    End Sub

    Private Sub FormatDgv()
        With DataGridView1
            If .RowCount > 0 Then
                .Columns(5).HeaderText = "Trim Rotation"
                .Columns(0).Width = 150
                .Columns(5).Width = 110
                .Columns(7).Width = 150
                .Columns(8).Width = 150
                .Columns(9).Width = 150
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .BackgroundColor = Color.White
                .Enabled = False
                .ReadOnly = True
            End If
        End With
    End Sub

    Private Sub check_id_stock()
        Try
            'Dim ooClsGetData As New ClsGetData
            ooClsGetData.p_PartNo = WM_lbl_Production1.Text.Trim()
            Dim dt As DataTable = ooClsGetData.Get_ID_Stock
            If dt.Rows.Count > 0 Then
                clsWriteLog.writeLog("check_id_stock working")
                '\\ update_status_stock()
                'Connection_DB_Stock()
                'Dim sqlSave As String = sb.ToString()
                'sqlSave = "UPDATE tb_st_u375 Set S_CF=1,Sequence='" & _Sequence.Trim() & "',Date_Sequence='" & Now.ToString("dd/MM/yyyy HH:mm:ss tt") & "'"
                'sqlSave &= " where SEQ ='" & WM_lbl_Production1.Text.Trim & "' AND S_CF=0 AND S_PD =1"
                'Com.CommandType = CommandType.Text
                'Com.CommandText = sqlSave
                'Com.Connection = Conn
                'Com.ExecuteNonQuery()
                'clsWriteLog.writeLog("update_status_stock finish")

                Dim blnRet As Boolean
                blnRet = ooCls_UpdateData.update_stock(_Sequence.Trim(), WM_lbl_Production1.Text.Trim)
                If blnRet = True Then
                    clsWriteLog.writeLog("update_status_stock finish")
                ElseIf blnRet = False Then
                    clsWriteLog.writeLog("update_status_stock error")
                End If
            Else
                clsWriteLog.writeLog("check_id_stock working not have data")
            End If
        Catch ex As Exception
            clsWriteLog.writeLog("check_id_stock error >>>>>>> " & ex.Message)
        End Try
    End Sub

    Private Sub Update_status()
        'Try
        Dim blnRet As Boolean
        'Dim ooClsGetData As New ClsGetData
        ooClsGetData.p_PartNo = lbl_part.Text.Trim()
        ooClsGetData.p_Trim = Microsoft.VisualBasic.Right(WM_lbl_Trim1.Text.Trim(), 4)
        blnRet = ooClsGetData.Get_Update_Status
        If blnRet = True Then
            clsWriteLog.writeLog("Update Status : " & _Sequence & " finish")

            ShowData()
            ClearData()
            Lock_Control()
            WM_lbl_Production1.Focus()
        ElseIf blnRet = False Then
            clsWriteLog.writeLog("Update_status error")
            PlaySound.Play()
        End If

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub ClearData()
        WM_lbl_Trim1.Clear()
        WM_lbl_Production1.Clear()
        WM_bc_Wire1.Clear()
        WM_lbl_Ohc1.Clear()
        WM_bc_Rack1.Clear()
    End Sub

    Private Sub pic_nhkant_Click(sender As Object, e As EventArgs) Handles pic_nhkant.Click
        PlaySound.Play()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        ShowData()
    End Sub

    Private Sub Ck_SortDate_CheckedChanged(sender As Object, e As EventArgs) Handles Ck_SortDate.CheckedChanged
        ShowData()
    End Sub

    Private Sub Btn_Report_Click(sender As Object, e As EventArgs) Handles Btn_Report.Click
        Dim frmReport As New FrmReport
        frmReport.ShowDialog(Me)
    End Sub

    Private Sub Btn_Sort_data_Click(sender As Object, e As EventArgs) Handles Btn_Sort_data.Click
        If DataGridView1.RowCount > 0 Then
            Dim f As New Frm_Sort_Sequence
            f._time = DateTimePicker1.Value.ToString("dd/MM/yyyy")
            f.sequence = _Sequence
            f.ShowDialog(Me)
        Else
            MsgBox("Nothing Data")
        End If
    End Sub

    Private Sub Btn_show_Click(sender As Object, e As EventArgs) Handles Btn_show.Click
        'Connection()
        ShowData()
    End Sub

    Private Sub Btn_pre_Click(sender As Object, e As EventArgs) Handles Btn_pre.Click
        Dim f As New Frm_pre_load
        f.ShowDialog(Me)
    End Sub

    Private Sub Btn_Wire_Click(sender As Object, e As EventArgs) Handles Btn_Wire.Click
        'Dim n As New FrmWire
        'n.Show()
    End Sub

    Private Sub WM_lbl_Production1_KeyDown(sender As Object, e As KeyEventArgs) Handles WM_lbl_Production1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If Ck_kanban.Checked = False Then
                    data = Str(2)
                ElseIf Ck_kanban.Checked = True Then
                    data = lbl_part.Text.Trim
                End If
                If e.KeyCode = Keys.Enter Then
                    cf_part = WM_lbl_Production1.Text.Split(Chr(34), "-")
                    If WM_lbl_Production1.Text.Trim = data.Trim Then
                        WM_lbl_Trim1.Enabled = True
                        WM_lbl_Trim1.Focus()
                        PictureBox1.Image = My.Resources.Normal
                        clsWriteLog.writeLog("Scan Complete Part : " & WM_lbl_Production1.Text.Trim & " On labal Suffix only")
                    ElseIf cf_part(0).Trim = data.Trim Then
                        WM_lbl_Trim1.Enabled = True
                        WM_lbl_Trim1.Focus()
                        PictureBox1.Image = My.Resources.Normal
                        clsWriteLog.writeLog("Scan Complete Part : " & WM_lbl_Production1.Text.Trim & "On label Suffix and ID")
                    Else
                        e.SuppressKeyPress = True
                        PlaySound.Play()
                        PictureBox1.Image = My.Resources.Datajump
                        clsWriteLog.writeLog("Scan Error Part")
                        WM_lbl_Production1.Clear()
                        WM_lbl_Production1.Focus()
                    End If
                End If
            Catch ex As Exception
                WM_lbl_Production1.Clear()
                WM_lbl_Production1.Focus()
                PictureBox1.Image = My.Resources.Datajump
                clsWriteLog.writeLog("Scan Error Part >>>>> " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub WM_lbl_Trim1_KeyDown(sender As Object, e As KeyEventArgs) Handles WM_lbl_Trim1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If e.KeyCode = Keys.Enter Then
                If WM_lbl_Trim1.Text.Trim = lbl_EcssDate.Text.Trim Then
                    WM_bc_Wire1.Enabled = True
                    WM_bc_Wire1.Clear()
                    WM_bc_Wire1.Focus()
                    PictureBox1.Image = My.Resources.Normal
                    clsWriteLog.writeLog("Scan Complete Label : " & WM_lbl_Trim1.Text.Trim)
                Else
                    e.SuppressKeyPress = True
                    PlaySound.Play()
                    PictureBox1.Image = My.Resources.Datajump
                    clsWriteLog.writeLog("Scan Error Label")
                    WM_lbl_Trim1.Clear()
                    WM_lbl_Trim1.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub WM_bc_Wire1_KeyDown(sender As Object, e As KeyEventArgs) Handles WM_bc_Wire1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If WM_bc_Wire1.Text.Trim = Wire.Trim Then
                'If lbl_ohc.Text.Trim() = "-" Then
                If lbl_ohc.Text.Length < 2 Then
                    WM_bc_Rack1.Enabled = True
                    WM_bc_Rack1.Focus()
                    PictureBox1.Image = My.Resources.Normal
                    clsWriteLog.writeLog("Scan complete Wire : " & WM_bc_Wire1.Text.Trim)
                Else
                    WM_lbl_Ohc1.Enabled = True
                    WM_lbl_Ohc1.Focus()
                    clsWriteLog.writeLog("Scan complete Wire : " & WM_bc_Wire1.Text.Trim)
                End If
            Else
                e.SuppressKeyPress = True
                PlaySound.Play()
                PictureBox1.Image = My.Resources.Datajump
                clsWriteLog.writeLog("Scan Error Wire")
                WM_bc_Wire1.Clear()
                WM_bc_Wire1.Focus()
            End If
        End If
    End Sub

    Private Sub WM_lbl_Ohc1_KeyDown(sender As Object, e As KeyEventArgs) Handles WM_lbl_Ohc1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Check_OHC = WM_lbl_Ohc1.Text
                OHC = Check_OHC.Split(Chr(34), "-")
                Dim txt_OHC As String
                txt_OHC = OHC(0) & "-" & OHC(1) & "-" & OHC(2)
                If txt_OHC.Trim() = lbl_ohc.Text.Trim() Then
                    WM_bc_Rack1.Enabled = True
                    WM_bc_Rack1.Focus()
                    PictureBox1.Image = My.Resources.Normal
                    clsWriteLog.writeLog("Scan complete OHC : " & lbl_ohc.Text.Trim)
                Else
                    e.SuppressKeyPress = True
                    PlaySound.Play()
                    WM_lbl_Ohc1.Clear()
                    WM_lbl_Ohc1.Focus()
                    PictureBox1.Image = My.Resources.Datajump
                    clsWriteLog.writeLog("Scan Error OHC")
                End If
            End If
        Catch
            e.SuppressKeyPress = True
            clsWriteLog.writeLog("Scan Error OHC Try Catch")
            PlaySound.Play()
            WM_lbl_Ohc1.Clear()
            WM_lbl_Ohc1.Focus()
            PictureBox1.Image = My.Resources.Datajump
        End Try
    End Sub

    Private Sub WM_bc_Rack1_KeyDown(sender As Object, e As KeyEventArgs) Handles WM_bc_Rack1.KeyDown
        If Ck_kanban.Checked = False Then
            data = Str(2)
        ElseIf Ck_kanban.Checked = True Then
            data = lbl_part.Text.Trim
        End If
        If e.KeyCode = Keys.Enter Then
            If WM_bc_Rack1.Text.Trim = lbl_EcssDate.Text.Trim Then
                PictureBox1.Image = My.Resources.Normal
                clsWriteLog.writeLog("Scan Complete Rack Summary : " & WM_bc_Wire1.Text.Trim)
                check_id_stock()
                Update_status()
            Else
                PlaySound.Play()
                PictureBox1.Image = My.Resources.Datajump
                clsWriteLog.writeLog("Scan Not match Rack Summary")
                WM_bc_Rack1.Clear()
                WM_bc_Rack1.Focus()
            End If
        End If
    End Sub

    'Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
    '    Update_status()
    'End Sub
End Class