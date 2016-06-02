Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Text
Imports System.Runtime.InteropServices

Public Class ClsConnect
    'ส่วนของ Form
    Public Shared Conn As New SqlConnection
    Public Shared sb As New StringBuilder
    Public Shared dr As SqlDataReader
    Public Shared da As SqlDataAdapter
    Public Shared Com As New SqlCommand
    Public Shared tr As SqlTransaction
    Public Shared dt As DataTable
    Public Shared ds As DataSet

    Friend Shared dbConn As String = "Data Source=110.170.28.10\SQLEXPRESS;Initial Catalog=AAT_FORD;Persist Security Info=True;User ID=sa;Password=Passw0rd"
    'Public Shared dbConn As String = "Data Source=10.101.1.22\SQLEXPRESS;Initial Catalog=AAT_FORD;Persist Security Info=True;User ID=sa;Password=Passw0rd"
    Public Shared Conn_db_stock As String = "Data Source=10.101.1.20\SQLEXPRESS;Initial Catalog=db_cf_ford;Persist Security Info=True;User ID=sa;Password=Passw0rd"

    Public Shared Sub Connection()
        Conn = New SqlConnection(dbConn)
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.ConnectionString = dbConn
        Conn.Open()
    End Sub

    Public Shared Sub Connection_DB_Stock()
        Conn = New SqlConnection(Conn_db_stock)
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.ConnectionString = Conn_db_stock
        Conn.Open()
    End Sub
End Class