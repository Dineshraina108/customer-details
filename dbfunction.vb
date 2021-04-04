Imports Oracle.DataAccess.Client
Module dbfunction
    Dim query As String
    Public con As New OracleConnection
    Public Sub connopen()
        con.ConnectionString = "Data Source=XE;User ID=DINESH;Password=esec;"
        con.Open()
    End Sub
    Public Sub connclose()
        con.Close()
    End Sub
    Public Sub upd(ByRef qry As String)
        Dim tval As Integer = 0
        Using cmd As New OracleCommand(qry, con)
            tval = cmd.ExecuteNonQuery()
        End Using
        If tval > 0 Then
            MsgBox("update sucessfully")
        Else
            MsgBox("not update")
        End If
    End Sub
    Public Sub del(ByRef qry As String)
        Dim tval As Integer = 0
        Using cmd As New OracleCommand(qry, con)
            tval = cmd.ExecuteNonQuery()
        End Using
        If tval > 0 Then
            MsgBox("delete sucessfully")
        Else
            MsgBox("not delete")
        End If
    End Sub
    Public Sub ins(ByRef qry As String)
        Dim tval As Integer = 0
        Using cmd As New OracleCommand(qry, con)
            tval = cmd.ExecuteNonQuery()
        End Using
        If tval > 0 Then
            MsgBox("insert sucessfully")
        Else
            MsgBox("not insert")
        End If
    End Sub
    Public Function sel(ByRef qry As String)
        query = "select * from" & qry & ""
        Dim dt As New DataTable
        Using cmd As New OracleCommand(query, con)
            Using ada As New OracleDataAdapter(cmd)
                ada.Fill(dt)
            End Using
        End Using
        Return dt
    End Function
End Module
