
Imports System.IO

Public Class clsWriteLog

    Public Const P_LOG_FILE_PATH As String = "\Log"
    Public Shared p_blnWriteLog As Boolean = True
    Public Shared Sub writeLog(ByVal message As String)
        Try
            If p_blnWriteLog Then

                Dim strFile As String = String.Empty
                Dim strPath As String = Application.StartupPath & P_LOG_FILE_PATH & "\" & Now.ToString("yyyyMM")

                If Not Directory.Exists(strPath) Then
                    Dim di As DirectoryInfo = Directory.CreateDirectory(strPath)
                End If

                strFile = strPath & "\" & Now.ToString("yyyyMMdd") & ".log"

                'My.Computer.FileSystem.WriteAllText(Application.StartupPath & _
                '                                    P_LOG_FILE_PATH, Now.ToString("yyyyMMddHHmmss") & " : " & message & vbNewLine, _
                '                                    True)
                My.Computer.FileSystem.WriteAllText(strFile, _
                                                     Now.ToString("yyyyMMddHHmmss") & " : " & message & vbNewLine, _
                                                    True)

            End If
            Debug.Print("Log: " & message)

        Catch ex As Exception
            Debug.Print("[writeLog] Error: " & ex.Message)
        End Try
    End Sub



End Class
