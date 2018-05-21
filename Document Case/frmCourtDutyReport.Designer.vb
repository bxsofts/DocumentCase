<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourtDutyReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCourtDutyReport))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DocumentCaseDataSet = New DocumentCase.DocumentCaseDataSet()
        Me.CourtDutyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CourtDutyTableAdapter = New DocumentCase.DocumentCaseDataSetTableAdapters.CourtDutyTableAdapter()
        CType(Me.DocumentCaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CourtDutyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.CourtDutyBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "DocumentCase.CourtDutyReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(686, 274)
        Me.ReportViewer1.TabIndex = 0
        '
        'DocumentCaseDataSet
        '
        Me.DocumentCaseDataSet.DataSetName = "DocumentCaseDataSet"
        Me.DocumentCaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CourtDutyBindingSource
        '
        Me.CourtDutyBindingSource.DataMember = "CourtDuty"
        Me.CourtDutyBindingSource.DataSource = Me.DocumentCaseDataSet
        '
        'CourtDutyTableAdapter
        '
        Me.CourtDutyTableAdapter.ClearBeforeFill = True
        '
        'frmCourtDutyReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 274)
        Me.Controls.Add(Me.ReportViewer1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCourtDutyReport"
        Me.Text = "Court Duty Report"
        Me.TitleText = "<b>Court Duty Report</b>"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DocumentCaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CourtDutyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CourtDutyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DocumentCaseDataSet As DocumentCase.DocumentCaseDataSet
    Friend WithEvents CourtDutyTableAdapter As DocumentCase.DocumentCaseDataSetTableAdapters.CourtDutyTableAdapter
End Class
