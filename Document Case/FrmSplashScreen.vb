

Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Rendering

Public NotInheritable Class frmSplashScreen

    Dim timercount As Integer = 0

    Private Sub frmSplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        On Error Resume Next
        Me.Timer1.Enabled = True
        Me.TopMost = True
        If My.Application.Info.Title <> "" Then
            lblApplicationTitle.Text = My.Application.Info.Title
        Else
            lblApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.lblVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)

        lblCopyright.Text = "Copyright © Baiju Xavior 2012-" & Year(Today) + 1
        lblBaiju.Text = My.Application.Info.CompanyName
        Me.lblLicence.Text = "Licenced to State Fingerprint Bureau, Thiruvananthapuram"


    End Sub


   
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        timercount += 1
        If timercount = 2 Then
            frmMainInterface.Show()
            '  Me.BringToFront()
        End If
        If timercount = 5 Then
            Me.Close()
        End If
    End Sub
End Class
