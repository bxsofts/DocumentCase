Public Class frmSearch

    Dim d1 As Date
    Dim d2 As Date

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        Dim m As Integer = DateAndTime.Month(Today)
        Dim y As Integer = DateAndTime.Year(Today)

       
        dtFrom.Value = CDate("01/01/" & y)
        dtTo.Value = Today
        Me.cmbMonth.Items.Clear()
        For i = 0 To 11
            Me.cmbMonth.Items.Add(MonthName(i + 1))
        Next


        Me.cmbMonth.SelectedIndex = m - 1
        Me.txtYear.Value = y

        d1 = Me.dtFrom.Value
        d2 = CDate(Today)
        Me.dtFrom.Focus()
    End Sub

    Private Sub Search(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchByDate.Click, btnSearchByMonth.Click

        On Error GoTo err


        Select Case DirectCast(sender, DevComponents.DotNetBar.ButtonX).Name
            Case btnSearchByDate.Name
                d1 = CDate(Me.dtFrom.Value)
                d2 = CDate(Me.dtTo.Value)
            Case btnSearchByMonth.Name
                Dim m = Me.cmbMonth.SelectedIndex + 1
                Dim y = Me.txtYear.Value
                Dim d As Integer = Date.DaysInMonth(y, m)
                d1 = CDate(m & "/01/" & y)
                d2 = CDate(m & "/" & d & "/" & y)
        End Select


        If frmMainInterface.CurrentTab = "Document" Then

            Dim expertid As String = IIf(frmMainInterface.cmbDCExpertSection.Text.Trim = "", "", " ExpertID like '" & frmMainInterface.cmbDCExpertSection.Text.Trim & "%'")
            Dim expertname As String = IIf(frmMainInterface.cmbDCExpertName.Text.Trim = "", "", " ExpertName like '" & frmMainInterface.cmbDCExpertName.Text.Trim & "%'")
            Dim documentdate As String = IIf(frmMainInterface.dtDocumentCase.Text = "", "", " DocumentDate = #" & frmMainInterface.dtDocumentCase.Value & "#")
            Dim inwardnumber As String = IIf(frmMainInterface.txtInwardNumber.Text = Nothing, "", " InwardNumber = " & frmMainInterface.txtInwardNumber.Text)
            Dim court As String = IIf(frmMainInterface.txtDCCourt.Text.Trim = "", "", " Court like '" & frmMainInterface.txtDCCourt.Text.Trim & "%'")
            Dim ps As String = IIf(frmMainInterface.cmbDCPS.Text.Trim = "", "", " PS like '" & frmMainInterface.cmbDCPS.Text.Trim & "%'")
            Dim cr As String = IIf(frmMainInterface.txtDCCrNo.Text.Trim = "", "", " CrNo like '" & frmMainInterface.txtDCCrNo.Text.Trim & "%'")
            Dim fees As String = IIf(frmMainInterface.txtFeesRemitted.Text = Nothing, "", " FeesRemitted = " & frmMainInterface.txtFeesRemitted.Text)
            Dim dttopb As String = IIf(frmMainInterface.dtToPB.Text = "", "", " DateToPB = #" & frmMainInterface.dtToPB.Value & "#")
            Dim dtfrompb As String = IIf(frmMainInterface.dtFromPB.Text = "", "", " DateFromPB = #" & frmMainInterface.dtFromPB.Value & "#")
            Dim status As String = IIf(frmMainInterface.cmbStatus.Text.Trim = "", "", " Status like '" & frmMainInterface.cmbStatus.Text.Trim & "%'")
            Dim despatchdate As String = IIf(frmMainInterface.dtDespatch.Text = "", "", " DespatchDate = #" & frmMainInterface.dtDespatch.Value & "#")
            Dim despatchmode As String = IIf(frmMainInterface.cmbDespatchMode.Text.Trim = "", "", " DespatchMode like '" & frmMainInterface.cmbDespatchMode.Text.Trim & "%'")
            Dim despatchaddress As String = IIf(frmMainInterface.txtDespatchAdress.Text.Trim = "", "", " DespatchAddress like '" & frmMainInterface.txtDespatchAdress.Text.Trim & "%'")

            Dim sqltext = expertid
            sqltext += IIf(sqltext = "", expertname, IIf(expertname = "", "", " and " & expertname))
            sqltext += IIf(sqltext = "", documentdate, IIf(documentdate = "", "", " and " & documentdate))
            sqltext += IIf(sqltext = "", inwardnumber, IIf(inwardnumber = "", "", " and " & inwardnumber))
            sqltext += IIf(sqltext = "", court, IIf(court = "", "", " and " & court))
            sqltext += IIf(sqltext = "", ps, IIf(ps = "", "", " and " & ps))
            sqltext += IIf(sqltext = "", cr, IIf(cr = "", "", " and " & cr))
            sqltext += IIf(sqltext = "", fees, IIf(fees = "", "", " and " & fees))
            sqltext += IIf(sqltext = "", dttopb, IIf(dttopb = "", "", " and " & dttopb))
            sqltext += IIf(sqltext = "", dtfrompb, IIf(dtfrompb = "", "", " and " & dtfrompb))
            sqltext += IIf(sqltext = "", status, IIf(status = "", "", " and " & status))
            sqltext += IIf(sqltext = "", despatchdate, IIf(despatchdate = "", "", " and " & despatchdate))
            sqltext += IIf(sqltext = "", despatchmode, IIf(despatchmode = "", "", " and " & despatchmode))
            sqltext += IIf(sqltext = "", despatchaddress, IIf(despatchaddress = "", "", " and " & despatchaddress))


            sqltext = "Select * from DocumentCase where " & sqltext

            If sqltext.EndsWith("where ") Then
                DevComponents.DotNetBar.MessageBoxEx.Show("Please enter atleast one search text", AppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                Exit Sub

            End If
            sqltext += " and DocumentDate between #" & d1 & "# and #" & d2 & "#"
            ' MsgBox(sqltext)
            Dim con As OleDb.OleDbConnection = New OleDb.OleDbConnection(ConString)
            con.Open()
            Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sqltext, con)
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            frmMainInterface.DocumentCaseDataSet.DocumentCase.Clear()
            da.Fill(frmMainInterface.DocumentCaseDataSet.DocumentCase)
        End If



        If frmMainInterface.CurrentTab = "Court" Then


            Dim expertname As String = IIf(frmMainInterface.cmbCDExpertName.Text.Trim = "", "", " Expert like '" & frmMainInterface.cmbCDExpertName.Text.Trim & "%'")
            Dim court As String = IIf(frmMainInterface.txtCDCourt.Text.Trim = "", "", " Court like '" & frmMainInterface.txtCDCourt.Text.Trim & "%'")
            Dim hearingdate As String = IIf(frmMainInterface.dtHearing.Text = "", "", " DateOfHearing = #" & frmMainInterface.dtHearing.Value & "#")
            Dim casetype As String = IIf(frmMainInterface.cmbCivilCriminal.Text = "", "", " TypeOfCase like '" & frmMainInterface.cmbCivilCriminal.Text.Trim & "%'")
            Dim ccno As String = IIf(frmMainInterface.txtCDCCNo.Text.Trim = "", "", " CCNo like '" & frmMainInterface.txtCDCCNo.Text.Trim & "%'")
            Dim ps As String = IIf(frmMainInterface.cmbCDPS.Text.Trim = "", "", " PS like '" & frmMainInterface.cmbCDPS.Text.Trim & "%'")
            Dim cr As String = IIf(frmMainInterface.txtCDCrNo.Text.Trim = "", "", " CrNo like '" & frmMainInterface.txtCDCrNo.Text.Trim & "%'")
            Dim fees As String = IIf(frmMainInterface.txtAbsentFees.Text = Nothing, "", " AbsentFee = " & frmMainInterface.txtAbsentFees.Text)
            Dim tada As String = IIf(frmMainInterface.txtTADA.Text = Nothing, "", " TADA = " & frmMainInterface.txtTADA.Text)
            Dim bexamined As Boolean = IIf(frmMainInterface.cmbExamined.Text.ToLower.Trim = "yes", True, False)
            Dim examined As String = IIf(frmMainInterface.cmbExamined.Text.Trim = "", "", " ExaminedOrNot = " & bexamined)
            Dim dtpostponed As String = IIf(frmMainInterface.dtPostponed.Text = "", "", " PostponedDate = #" & frmMainInterface.dtPostponed.Value & "#")

            Dim sqltext = expertname
            sqltext += IIf(sqltext = "", court, IIf(court = "", "", " and " & court))
            sqltext += IIf(sqltext = "", hearingdate, IIf(hearingdate = "", "", " and " & hearingdate))
            sqltext += IIf(sqltext = "", casetype, IIf(casetype = "", "", " and " & casetype))
            sqltext += IIf(sqltext = "", ccno, IIf(ccno = "", "", " and " & ccno))
            sqltext += IIf(sqltext = "", ps, IIf(ps = "", "", " and " & ps))
            sqltext += IIf(sqltext = "", cr, IIf(cr = "", "", " and " & cr))
            sqltext += IIf(sqltext = "", fees, IIf(fees = "", "", " and " & fees))
            sqltext += IIf(sqltext = "", tada, IIf(tada = "", "", " and " & tada))
            sqltext += IIf(sqltext = "", examined, IIf(examined = "", "", " and " & examined))
            sqltext += IIf(sqltext = "", dtpostponed, IIf(dtpostponed = "", "", " and " & dtpostponed))

            sqltext = "Select * from CourtDuty where " & sqltext

            If sqltext.EndsWith("where ") Then
                DevComponents.DotNetBar.MessageBoxEx.Show("Please enter atleast one search text", AppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                Exit Sub
            End If
            sqltext += " and DateOfHearing between #" & d1 & "# and #" & d2 & "#"
            ' MsgBox(sqltext)
            Dim con As OleDb.OleDbConnection = New OleDb.OleDbConnection(ConString)
            con.Open()
            Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sqltext, con)
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            frmMainInterface.DocumentCaseDataSet.CourtDuty.Clear()
            da.Fill(frmMainInterface.DocumentCaseDataSet.CourtDuty)
        End If



        Exit Sub
err:
        DevComponents.DotNetBar.MessageBoxEx.Show(Err.Description, AppName, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    
End Class