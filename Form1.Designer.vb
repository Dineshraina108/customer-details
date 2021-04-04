<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.txtcid = New System.Windows.Forms.TextBox()
        Me.txtcname = New System.Windows.Forms.TextBox()
        Me.txtcaddr = New System.Windows.Forms.TextBox()
        Me.chksel = New System.Windows.Forms.CheckBox()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.DGVcus = New System.Windows.Forms.DataGridView()
        Me.DGVcusup = New System.Windows.Forms.DataGridView()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet1 = New Customer.DataSet1()
        Me.CUST_DETAILSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CUST_DETAILSTableAdapter = New Customer.DataSet1TableAdapters.CUST_DETAILSTableAdapter()
        CType(Me.DGVcus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVcusup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUST_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtcid
        '
        Me.txtcid.Location = New System.Drawing.Point(122, 94)
        Me.txtcid.Name = "txtcid"
        Me.txtcid.Size = New System.Drawing.Size(100, 20)
        Me.txtcid.TabIndex = 0
        '
        'txtcname
        '
        Me.txtcname.Location = New System.Drawing.Point(121, 130)
        Me.txtcname.Name = "txtcname"
        Me.txtcname.Size = New System.Drawing.Size(100, 20)
        Me.txtcname.TabIndex = 1
        '
        'txtcaddr
        '
        Me.txtcaddr.Location = New System.Drawing.Point(121, 168)
        Me.txtcaddr.Name = "txtcaddr"
        Me.txtcaddr.Size = New System.Drawing.Size(100, 20)
        Me.txtcaddr.TabIndex = 2
        '
        'chksel
        '
        Me.chksel.AutoSize = True
        Me.chksel.Location = New System.Drawing.Point(122, 210)
        Me.chksel.Name = "chksel"
        Me.chksel.Size = New System.Drawing.Size(56, 17)
        Me.chksel.TabIndex = 3
        Me.chksel.Text = "Select"
        Me.chksel.UseVisualStyleBackColor = True
        '
        'btninsert
        '
        Me.btninsert.Location = New System.Drawing.Point(141, 260)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(75, 23)
        Me.btninsert.TabIndex = 4
        Me.btninsert.Text = "INSERT"
        Me.btninsert.UseVisualStyleBackColor = True
        '
        'DGVcus
        '
        Me.DGVcus.AllowUserToOrderColumns = True
        Me.DGVcus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVcus.Location = New System.Drawing.Point(240, 24)
        Me.DGVcus.Name = "DGVcus"
        Me.DGVcus.Size = New System.Drawing.Size(503, 150)
        Me.DGVcus.TabIndex = 5
        '
        'DGVcusup
        '
        Me.DGVcusup.AllowUserToOrderColumns = True
        Me.DGVcusup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVcusup.Location = New System.Drawing.Point(240, 232)
        Me.DGVcusup.Name = "DGVcusup"
        Me.DGVcusup.Size = New System.Drawing.Size(503, 150)
        Me.DGVcusup.TabIndex = 6
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(344, 190)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 23)
        Me.btnupdate.TabIndex = 7
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(122, 329)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 8
        Me.btnExport.Text = "export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "Cusdet"
        ReportDataSource1.Value = Me.CUST_DETAILSBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Customer.cusdeails.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(761, 24)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer1.TabIndex = 9
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CUST_DETAILSBindingSource
        '
        Me.CUST_DETAILSBindingSource.DataMember = "CUST_DETAILS"
        Me.CUST_DETAILSBindingSource.DataSource = Me.DataSet1
        '
        'CUST_DETAILSTableAdapter
        '
        Me.CUST_DETAILSTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1295, 493)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.DGVcusup)
        Me.Controls.Add(Me.DGVcus)
        Me.Controls.Add(Me.btninsert)
        Me.Controls.Add(Me.chksel)
        Me.Controls.Add(Me.txtcaddr)
        Me.Controls.Add(Me.txtcname)
        Me.Controls.Add(Me.txtcid)
        Me.Name = "Form1"
        Me.Text = "Home"
        CType(Me.DGVcus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVcusup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUST_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtcid As TextBox
    Friend WithEvents txtcname As TextBox
    Friend WithEvents txtcaddr As TextBox
    Friend WithEvents chksel As CheckBox
    Friend WithEvents btninsert As Button
    Friend WithEvents DGVcus As DataGridView
    Friend WithEvents DGVcusup As DataGridView
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CUST_DETAILSBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents CUST_DETAILSTableAdapter As DataSet1TableAdapters.CUST_DETAILSTableAdapter
End Class
