<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocumentCaseReport
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocumentCaseReport))
        Me.DocumentCaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DocumentCaseDataSet = New DocumentCase.DocumentCaseDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DocumentCaseTableAdapter = New DocumentCase.DocumentCaseDataSetTableAdapters.DocumentCaseTableAdapter()
        CType(Me.DocumentCaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentCaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DocumentCaseBindingSource
        '
        Me.DocumentCaseBindingSource.DataMember = "DocumentCase"
        Me.DocumentCaseBindingSource.DataSource = Me.DocumentCaseDataSet
        '
        'DocumentCaseDataSet
        '
        Me.DocumentCaseDataSet.DataSetName = "DocumentCaseDataSet"
        Me.DocumentCaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DocumentCaseDataSet"
        ReportDataSource1.Value = Me.DocumentCaseBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "DocumentCase.DocumentCaseReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(630, 383)
        Me.ReportViewer1.TabIndex = 0
        '
        'DocumentCaseTableAdapter
        '
        Me.DocumentCaseTableAdapter.ClearBeforeFill = True
        '
        'frmDocumentCaseReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 383)
        Me.Controls.Add(Me.ReportViewer1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDocumentCaseReport"
        Me.Text = "Document Case Report"
        Me.TitleText = "<b>Document Case Report</b>"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DocumentCaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentCaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DocumentCaseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DocumentCaseDataSet As DocumentCase.DocumentCaseDataSet
    Friend WithEvents DocumentCaseTableAdapter As DocumentCase.DocumentCaseDataSetTableAdapters.DocumentCaseTableAdapter
End Class
