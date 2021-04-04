Imports Oracle.DataAccess.Client
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Microsoft.Reporting.WinForms
Imports System.IO
Public Class Form1
    Dim query, cname, caddr, chkboxval As String
    Dim dr As DataRow

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim message As String = String.Empty
        For Each row As DataGridViewRow In DGVcus.Rows
            Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("checkBoxColumn").Value)
            If isSelected Then
                message &= Environment.NewLine
                message &= row.Cells("CUSNAME").Value.ToString()
            End If
        Next
        MessageBox.Show("Selected Values" & message)
        DGVcusup.Visible = True
        Dim dt As DataTable = GetTable()
        For Each cusrow As DataGridViewRow In DGVcus.Rows
            'For i As Integer = 0 To DGVcus.Rows.Count
            Dim isSelected As Boolean = Convert.ToBoolean(cusrow.Cells("checkBoxColumn").Value)
            If isSelected Then
                message &= Environment.NewLine
                message &= cusrow.Cells("CUSNAME").Value.ToString()
                dr = dt.NewRow()
                dr("CUSID") = cusrow.Cells("CUSID").Value.ToString
                dr("CUSNAME") = cusrow.Cells("CUSNAME").Value.ToString
                dr("CUSADDR") = cusrow.Cells("CUSADDR").Value.ToString
                'dt.Rows(i)("CUSID").ToString = cusrow.Cells("CUSID").Value.ToString
                'dt.Rows(i)("CUSNAME").ToString = cusrow.Cells("CUSNAME").Value.ToString
                'dt.Rows(i)("CUSADDR").ToString = cusrow.Cells("CUSADDR").Value.ToString
                dt.Rows.Add(dr)
                DGVcusup.DataSource = dt
            End If
        Next
        'Next
        connclose()
    End Sub
    Function GetTable() As DataTable
        ' Create new DataTable instance.
        Dim table As New DataTable
        ' Create four typed columns in the DataTable.
        table.Columns.Add("CUSID", GetType(Integer))
        table.Columns.Add("CUSNAME", GetType(String))
        table.Columns.Add("CUSADDR", GetType(String))
        Return table
    End Function
    Dim cuid As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        connopen()
        query = "CUST_DETAILS"
        dt = sel(query)
        If dt.Rows.Count = 0 Then
            MsgBox("no records ")
        Else
            DGVcus.DataSource = dt
            DGVcusup.DataSource = dt
            Dim checkBoxColumn As New DataGridViewCheckBoxColumn()
            checkBoxColumn.HeaderText = ""
            checkBoxColumn.Width = 30
            checkBoxColumn.Name = "checkBoxColumn"
            DGVcus.Columns.Insert(0, checkBoxColumn)
        End If
        DGVcusup.Visible = True
        connclose()
        Dim datasource As New ReportDataSource("Cusdet", dt)
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(datasource)
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub btnExport_Click_1(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim dt As DataTable = New DataTable()
        For Each column As DataGridViewTextBoxColumn In DGVcusup.Columns
            dt.Columns.Add(column.Name, column.ValueType)
        Next
        For Each row As DataGridViewRow In DGVcusup.Rows
            Dim dr1 As DataRow = dt.NewRow()
            For Each column As DataGridViewTextBoxColumn In DGVcusup.Columns
                If row.Cells(column.Name).Value IsNot Nothing Then
                    dr1(column.Name) = row.Cells(column.Name).Value.ToString()
                End If
            Next
            dt.Rows.Add(dr1)
        Next
        Dim filePath As String = "D:\Result.txt"
        DataTableToTextFile(dt, filePath)
    End Sub

    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        Dim dt As New DataTable
        cuid = txtcid.Text
        cname = txtcname.Text
        caddr = txtcaddr.Text
        If chksel.Checked = True Then
            chkboxval = "yes"
        Else
            chkboxval = "No"
        End If
        connopen()
        query = "INSERT INTO CUST_DETAILS VALUES(" & cuid & ",'" & cname & "','" & caddr & "','" & chkboxval & "')"
        ins(query)
        query = "SELECT * from CUST_DETAILS"
        dt = sel(query)
        If dt.Rows.Count = 0 Then
            MsgBox("no records ")
        Else
            DGVcus.DataSource = dt
            DGVcusup.DataSource = dt
            DGVcus.Update()
        End If
        DGVcusup.Visible = False
        connclose()

    End Sub

    Private Sub DataTableToTextFile(ByVal dt As DataTable, ByVal outputFilePath As String)
        Dim maxLengths As Integer() = New Integer(dt.Columns.Count - 1) {}
        For i As Integer = 0 To dt.Columns.Count - 1
            maxLengths(i) = dt.Columns(i).ColumnName.Length
            For Each row As DataRow In dt.Rows
                If Not row.IsNull(i) Then
                    Dim length As Integer = row(i).ToString().Length
                    If length > maxLengths(i) Then
                        maxLengths(i) = length
                    End If
                End If
            Next
        Next
        Using sw As StreamWriter = New StreamWriter(outputFilePath, False)
            For i As Integer = 0 To dt.Columns.Count - 1
                sw.Write(dt.Columns(i).ColumnName.PadRight(maxLengths(i) + 2))
            Next
            sw.WriteLine()
            For Each row As DataRow In dt.Rows
                For i As Integer = 0 To dt.Columns.Count - 1
                    If Not row.IsNull(i) Then
                        sw.Write(row(i).ToString().PadRight(maxLengths(i) + 2))
                    Else
                        sw.Write(New String(" "c, maxLengths(i) + 2))
                    End If
                Next
                sw.WriteLine()
            Next
            sw.Close()
        End Using
    End Sub

End Class

