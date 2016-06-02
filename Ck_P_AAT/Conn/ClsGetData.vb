Imports System.Data.SqlClient

Public Class ClsGetData
    Inherits ClsConnect
#Region " Variable "
    Private _Date As String = String.Empty
    Private _Sort As String = String.Empty
    Private _PartNo As String = String.Empty
    Private _Trim As String = String.Empty
#End Region
#Region " Property "
    Public Property p_Date As String
        Get
            Return _Date
        End Get
        Set(value As String)
            _Date = value
        End Set
    End Property

    Public Property p_Sort As String
        Get
            Return _Sort
        End Get
        Set(value As String)
            _Sort = value
        End Set
    End Property

    Public Property p_PartNo As String
        Get
            Return _PartNo
        End Get
        Set(value As String)
            _PartNo = value
        End Set
    End Property

    Public Property p_Trim As String
        Get
            Return _Trim
        End Get
        Set(value As String)
            _Trim = value
        End Set
    End Property

#End Region
#Region " Constructor "
    Public Sub New()

    End Sub
#End Region
#Region " Function "
    Public Function Get_BOM() As DataTable
        Dim dt As DataTable = Nothing
        Dim strSQL As String = "SELECT * FROM tb_wire where id_wire='" & _PartNo & "'"
        Using Cn As New SqlConnection(ClsConnect.dbConn)
            da = New SqlDataAdapter(strSQL, Cn)
            dt = New DataTable
            da.Fill(dt)
        End Using
        Return dt
    End Function

    Public Function Get_Update_Status() As Boolean
        Dim blnRet As Boolean
        Dim strSQL As String = "UPDATE tblOrder Set bcPrint=2 WHERE PartNo ='" & _PartNo & "'" & _
            " And TrmRotation ='" & _Trim & "'"
        Using Cn As New SqlConnection(ClsConnect.dbConn)
            Cn.Open()
            Dim cm As New SqlCommand(strSQL, Cn)
            If cm.ExecuteNonQuery() > 0 Then
                blnRet = True
            Else
                blnRet = False
            End If
        End Using
        Return blnRet
    End Function

    Public Function Get_ID_Stock() As DataTable
        Dim dt As DataTable = Nothing
        Dim strSQL As String = "SELECT SEQ from tb_st_u375 where SEQ='" & _PartNo & "' AND S_PD=1 AND S_CF=0"
        Using Cn As New SqlConnection(ClsConnect.Conn_db_stock)
            da = New SqlDataAdapter(strSQL, Cn)
            dt = New DataTable
            da.Fill(dt)
        End Using
        Return dt
    End Function

    Public Function Get_ShowData() As DataTable
        Dim dt As DataTable = Nothing
        Dim strSQL As String = "SELECT tblOrder.DateRecv, tblOrder.Header, tblOrder.Suppliers, tblOrder.Model, " & _
         " tblOrder.EcssDate, tblOrder.TrmRotation,Part_List.N_PN,tblOrder.PartNo,tblOrder.PntName,tblOrder.VIN,tblOrder.Footer1,tblOrder.bcPrint " & _
         " FROM tblOrder INNER JOIN  Part_List ON tblOrder.PartNo = Part_List.A_PN " & _
         " where tblOrder.DateRecv Like '%" & _Date & "%' AND bcPrint=1 order by Footer1"
        Using Cn As New SqlConnection(ClsConnect.dbConn)
            da = New SqlDataAdapter(strSQL, Cn)
            dt = New DataTable
            da.Fill(dt)
        End Using
        Return dt
    End Function

    Public Function getData_BOM_U375(ByVal id As String) As DataTable
        Dim dt As DataTable = Nothing
        Dim strSQL As String = "SELECT u_wire,u_ohc from tb_bom_u375 where bom_id='" & id & "'"
        Using Cn As New SqlConnection(ClsConnect.Conn_db_stock)
            da = New SqlDataAdapter(strSQL, Cn)
            dt = New DataTable
            da.Fill(dt)
        End Using
        Return dt
    End Function

    Public Function getData_BOM_P375(ByVal id As String) As DataTable
        Dim dt As DataTable = Nothing
        Dim strSQL As String = "SELECT Wire from tb_bom_t6 where part_id='" & id & "'"
        Using Cn As New SqlConnection(ClsConnect.Conn_db_stock)
            da = New SqlDataAdapter(strSQL, Cn)
            dt = New DataTable
            da.Fill(dt)
        End Using
        Return dt
    End Function

    Public Function Get_Report(ByVal _Date As String) As DataTable
        Dim dt As DataTable = Nothing
        sb.Remove(0, sb.Length)
        sb.Append("SELECT tblOrder.DateRecv, tblOrder.Header, tblOrder.Suppliers, tblOrder.Model,")
        sb.Append("tblOrder.EcssDate, tblOrder.TrmRotation,Part_List.N_PN,tblOrder.PartNo, tblOrder.PntName ")
        sb.Append(",tblOrder.VIN,tblOrder.Footer1,tblOrder.bcPrint ")
        sb.Append("FROM tblOrder LEFT JOIN  Part_List ON tblOrder.PartNo = Part_List.A_PN ")
        sb.Append("where tblOrder.DateRecv Like '%" & _Date & "%'")
        sb.Append(" and bcPrint='2'order by Footer1")
        Dim strSQL As String = sb.ToString()
        Using Cn As New SqlConnection(ClsConnect.dbConn)
            da = New SqlDataAdapter(strSQL, Cn)
            dt = New DataTable
            da.Fill(dt)
        End Using
        Return dt
    End Function

    Public Function Update_Status() As Boolean
        Dim blnRet As Boolean
        Dim strSQL As String = "UPDATE tblOrder Set bcPrint=2 WHERE PartNo ='" & _PartNo & "'" & _
            " And TrmRotation ='" & _Trim & "'"
        Using Cn As New SqlConnection(ClsConnect.dbConn)
            Cn.Open()
            Dim cm As New SqlCommand(strSQL, Cn)
            If cm.ExecuteNonQuery() > 0 Then
                blnRet = True
            Else
                blnRet = False
            End If
        End Using
        Return blnRet
    End Function

#End Region

End Class