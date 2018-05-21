Public Class frmDocumentCaseReport

    Private Sub frmDocumentCaseReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Me.DocumentCaseTableAdapter.Fill(Me.DocumentCaseDataSet.DocumentCase)
            Me.DocumentCaseBindingSource.DataSource = frmMainInterface.DocumentCaseBindingSource.DataSource
            Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, AppName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
       
    End Sub

End Class