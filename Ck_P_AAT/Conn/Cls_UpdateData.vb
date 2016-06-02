Imports System.Data.SqlClient
Public Class Cls_UpdateData
    Inherits ClsConnect

    Public Function update_stock(ByVal _Sequence As String, ByVal Label As String) As Boolean
        Dim blnRet As Boolean
        sb.Remove(0, sb.Length)
        sb.Append("UPDATE tb_st_u375 Set S_CF=1,Sequence='" & _Sequence & "',Date_Sequence='" & Now.ToString("dd/MM/yyyy HH:mm:ss tt") & "'")
        sb.Append("where SEQ ='" & Label & "' AND S_CF=0 AND S_PD =1")
        Dim strSQL As String = sb.ToString()
        Using Conn As New SqlConnection(Conn_db_stock)
            Conn.Open()
            Com = New SqlCommand(strSQL, Conn)
            If Com.ExecuteNonQuery() > 0 Then
                blnRet = True
            Else
                blnRet = False
            End If
        End Using
        Return blnRet 'Return data
    End Function
End Class
