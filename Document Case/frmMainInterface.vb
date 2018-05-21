Imports DevComponents
Imports DevComponents.DotNetBar
Public Class frmMainInterface

    Dim OldDocumentID As String = ""
    Dim OldFileNumber As String = ""
    Dim OldCourtID As String = ""
    Public CurrentTab = "Document"
#Region "FORM LOAD EVENTS"

    Private Sub FormLoadEvents(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        On Error Resume Next
        Dim CurrentTab = "Document"
        Me.DocumentDataGridView.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.CourtDataGridView.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        ConnectToDatabase()
        Me.DocumentCaseTableAdapter.FillByDateFileNumberOrder(Me.DocumentCaseDataSet.DocumentCase)
        Me.CourtDutyTableAdapter.FillByDateOrder(Me.DocumentCaseDataSet.CourtDuty)
        LoadAutoText()

        Dim y As String = Year(Today)
        Dim d1 As Date = CDate("#01/01/" & y & "#")
        Dim d2 As Date = CDate("#12/31/" & y & "#")
    End Sub

#End Region


#Region "CONNECT TO DATABASE"

    Private Sub ConnectToDatabase()
        On Error Resume Next
        If Me.DocumentCaseTableAdapter.Connection.State = ConnectionState.Open Then Me.DocumentCaseTableAdapter.Connection.Close()
        Me.DocumentCaseTableAdapter.Connection.ConnectionString = ConString
        Me.DocumentCaseTableAdapter.Connection.Open()

        If Me.ExpertsListTableAdapter.Connection.State = ConnectionState.Open Then Me.ExpertsListTableAdapter.Connection.Close()
        Me.ExpertsListTableAdapter.Connection.ConnectionString = ConString
        Me.ExpertsListTableAdapter.Connection.Open()

        If Me.PSListTableAdapter.Connection.State = ConnectionState.Open Then Me.PSListTableAdapter.Connection.Close()
        Me.PSListTableAdapter.Connection.ConnectionString = ConString
        Me.PSListTableAdapter.Connection.Open()

        If Me.StatusTableAdapter.Connection.State = ConnectionState.Open Then Me.StatusTableAdapter.Connection.Close()
        Me.StatusTableAdapter.Connection.ConnectionString = ConString
        Me.StatusTableAdapter.Connection.Open()

        If Me.CourtDutyTableAdapter.Connection.State = ConnectionState.Open Then Me.CourtDutyTableAdapter.Connection.Close()
        Me.CourtDutyTableAdapter.Connection.ConnectionString = ConString
        Me.CourtDutyTableAdapter.Connection.Open()

        If Me.TempDocumentCaseTableAdapter.Connection.State = ConnectionState.Open Then Me.TempDocumentCaseTableAdapter.Connection.Close()
        Me.TempDocumentCaseTableAdapter.Connection.ConnectionString = ConString
        Me.TempDocumentCaseTableAdapter.Connection.Open()
    End Sub


#End Region


#Region "RELOAD DATA"

    Private Sub LoadData() Handles btnReload.Click
        On Error Resume Next
        If CurrentTab = "Document" Then
            Dim oldid = Me.DocumentDataGridView.SelectedRows(0).Cells(0).Value
            Me.DocumentCaseTableAdapter.FillByDateFileNumberOrder(Me.DocumentCaseDataSet.DocumentCase)
            If oldid = Nothing Then
                Me.DocumentCaseBindingSource.MoveLast()
                Exit Sub
            End If

            Me.DocumentCaseBindingSource.Position = Me.DocumentCaseBindingSource.Find("DocumentID", oldid)
        End If

        If CurrentTab = "Court" Then
            Dim oldid = Me.CourtDataGridView.SelectedRows(0).Cells(11).Value
            Me.CourtDutyTableAdapter.FillByDateOrder(Me.DocumentCaseDataSet.CourtDuty)
            If oldid = Nothing Then
                Me.CourtDutyBindingSource.MoveLast()
                Exit Sub
            End If

            Me.CourtDutyBindingSource.Position = Me.CourtDutyBindingSource.Find("ID", oldid)
        End If
    End Sub
#End Region


#Region "AUTO TEXT"

    Private Sub LoadAutoText()
        On Error Resume Next
        Me.cmbDCPS.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Me.cmbDCExpertSection.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Me.cmbDCExpertName.AutoCompleteMode = AutoCompleteMode.SuggestAppend '
        Me.cmbDespatchMode.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Me.cmbStatus.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Me.cmbCDExpertName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Me.cmbCDPS.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Me.cmbCivilCriminal.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Me.cmbExamined.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        For i = 0 To 4
            Me.cmbDCExpertSection.Items.Add("X" & i + 1)
            Me.cmbDCExpertSection.AutoCompleteCustomSource.Add("X" & i + 1)
        Next

        Me.PSListTableAdapter.Fill(Me.DocumentCaseDataSet.PSList)
        For i = 0 To Me.DocumentCaseDataSet.PSList.Count - 1
            Me.cmbDCPS.Items.Add(Me.DocumentCaseDataSet.PSList(i).PS)
            Me.cmbDCPS.AutoCompleteCustomSource.Add(Me.DocumentCaseDataSet.PSList(i).PS)
            Me.cmbCDPS.Items.Add(Me.DocumentCaseDataSet.PSList(i).PS)

        Next
        ' Me.cmbCDPS.AutoCompleteCustomSource = Me.cmbDCPS.AutoCompleteCustomSource
        Me.cmbDCPS.Text = ""
        Me.cmbCDPS.Text = ""

        Me.ExpertsListTableAdapter.Fill(Me.DocumentCaseDataSet.ExpertsList)
        For i = 0 To Me.DocumentCaseDataSet.ExpertsList.Count - 1
            Me.cmbDCExpertName.Items.Add(Me.DocumentCaseDataSet.ExpertsList(i).ExpertName)
            Me.cmbDCExpertName.AutoCompleteCustomSource.Add(Me.DocumentCaseDataSet.ExpertsList(i).ExpertName)
            Me.cmbCDExpertName.Items.Add(Me.DocumentCaseDataSet.ExpertsList(i).ExpertName)

        Next
        ' Me.cmbCDExpertName.AutoCompleteCustomSource = Me.cmbDCExpertName.AutoCompleteCustomSource
        Me.cmbDCExpertName.Text = ""
        Me.cmbCDExpertName.Text = ""

        Me.StatusTableAdapter.Fill(Me.DocumentCaseDataSet.Status)
        For i = 0 To Me.DocumentCaseDataSet.Status.Count - 1
            Me.cmbStatus.Items.Add(Me.DocumentCaseDataSet.Status(i).Status)
            Me.cmbStatus.AutoCompleteCustomSource.Add(Me.DocumentCaseDataSet.Status(i).Status)
            ChangeDropdownWidth(Me.DocumentCaseDataSet.Status(i).Status, cmbStatus)
        Next
        Me.cmbStatus.Text = ""

        Me.cmbDespatchMode.Items.Add("By Registered Post")
        Me.cmbDespatchMode.Items.Add("By Spl. Messenger")
        Me.cmbDespatchMode.AutoCompleteCustomSource.Add("By Registered Post")
        Me.cmbDespatchMode.AutoCompleteCustomSource.Add("By Spl. Messenger")
        Me.cmbCivilCriminal.Items.Add("Civil")
        Me.cmbCivilCriminal.Items.Add("Criminal")
        Me.cmbCivilCriminal.AutoCompleteCustomSource.Add("Civil")
        Me.cmbCivilCriminal.AutoCompleteCustomSource.Add("Criminal")
        Me.cmbExamined.Items.Add("Yes")
        Me.cmbExamined.Items.Add("No")
        Me.cmbExamined.AutoCompleteCustomSource.Add("Yes")
        Me.cmbExamined.AutoCompleteCustomSource.Add("No")
        Me.cmbDCExpertSection.Focus()
    End Sub

    Public Sub ChangeDropdownWidth(ByVal Text As String, ByVal cmb As DevComponents.DotNetBar.Controls.ComboBoxEx)
        On Error Resume Next
        Static Dim length As Integer = cmb.DropDownWidth
        Dim g As Graphics = cmb.CreateGraphics
        Dim newlength As Integer = g.MeasureString(Text, cmb.Font).Width
        If length < newlength Then
            length = newlength
            cmb.DropDownWidth = newlength
        End If

    End Sub

#End Region


#Region "FIELD SETTINGS"

    Private Sub ClearAllDocumentFields() Handles btnNew.Click
        On Error Resume Next
        If CurrentTab = "Document" Then
            For Each Ctrl As Control In Me.PanelDocuments.Controls
                If TypeOf (Ctrl) Is DevComponents.DotNetBar.Controls.TextBoxX Or TypeOf (Ctrl) Is DevComponents.Editors.DateTimeAdv.DateTimeInput Or TypeOf (Ctrl) Is DevComponents.DotNetBar.Controls.ComboBoxEx Then
                    Ctrl.Text = ""
                End If
            Next
            Me.txtFeesRemitted.Text = Nothing
            Me.cmbDCExpertSection.Focus()
            Me.txtInwardNumber.Text = Nothing
            Me.txtFileNumber.Text = ""
            OldFileNumber = ""
            Me.btnSaveDocuments.Text = "Save"
        End If

        If CurrentTab = "Court" Then
            For Each Ctrl As Control In Me.PanelCourt.Controls
                If TypeOf (Ctrl) Is DevComponents.DotNetBar.Controls.TextBoxX Or TypeOf (Ctrl) Is DevComponents.Editors.DateTimeAdv.DateTimeInput Or TypeOf (Ctrl) Is DevComponents.DotNetBar.Controls.ComboBoxEx Then
                    Ctrl.Text = ""
                End If
            Next
            Me.txtTADA.Text = Nothing
            Me.cmbCDExpertName.Focus()
            Me.txtAbsentFees.Text = Nothing
            OldCourtID = ""
            Me.btnSaveCourt.Text = "Save"
        End If

    End Sub

    Private Sub InitializeFields()
        On Error Resume Next
        If CurrentTab = "Document" Then
            For Each Ctrl As Control In Me.PanelDocuments.Controls
                If TypeOf (Ctrl) Is DevComponents.DotNetBar.Controls.TextBoxX Or TypeOf (Ctrl) Is DevComponents.DotNetBar.Controls.TextBoxDropDown Or TypeOf (Ctrl) Is DevComponents.Editors.DateTimeAdv.DateTimeInput Or TypeOf (Ctrl) Is DevComponents.DotNetBar.Controls.ComboBoxEx Then
                    If Ctrl.Name <> cmbDCExpertSection.Name And Ctrl.Name <> cmbDCExpertName.Name And Ctrl.Name <> dtDocumentCase.Name Then Ctrl.Text = ""
                End If
            Next
            Me.txtFeesRemitted.Text = Nothing
            Me.txtInwardNumber.Focus()
            Me.txtInwardNumber.Text = Nothing
            Me.txtFileNumber.Text = ""
            OldFileNumber = ""
            Me.btnSaveDocuments.Text = "Save"
        End If


        If CurrentTab = "Court" Then
            For Each Ctrl As Control In Me.PanelCourt.Controls
                If TypeOf (Ctrl) Is DevComponents.DotNetBar.Controls.TextBoxX Or TypeOf (Ctrl) Is DevComponents.Editors.DateTimeAdv.DateTimeInput Or TypeOf (Ctrl) Is DevComponents.DotNetBar.Controls.ComboBoxEx Then
                    If Ctrl.Name <> cmbCDExpertName.Text Then Ctrl.Text = ""
                End If
            Next
            Me.txtTADA.Text = Nothing
            Me.cmbCDExpertName.Focus()
            Me.txtAbsentFees.Text = Nothing
            OldCourtID = ""
            Me.btnSaveCourt.Text = "Save"
        End If

    End Sub

    Private Sub txInward_ButtonCustomClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInwardNumber.ButtonClearClick
        txtInwardNumber.Text = Nothing
        txtInwardNumber.Value = Nothing


    End Sub

    Private Sub txtFees_ButtonCustomClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFeesRemitted.ButtonClearClick
        txtFeesRemitted.Text = Nothing
        txtFeesRemitted.Value = Nothing

    End Sub


    Private Sub txtAbsengtFees_ButtonClearClick(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAbsentFees.ButtonClearClick
        Me.txtAbsentFees.Text = Nothing
        Me.txtAbsentFees.Value = Nothing
    End Sub


    Private Sub txttada_ButtonClearClick(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTADA.ButtonClearClick
        Me.txtTADA.Text = Nothing
        Me.txtTADA.Value = Nothing
    End Sub

    Private Sub cmbExpertName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDCExpertName.GotFocus
        On Error Resume Next
        If Me.cmbDCExpertSection.Text <> "" And Me.cmbDCExpertName.Text = "" Then

            Me.ExpertsListTableAdapter.FillByExpertSectionCurrentOfficer(Me.DocumentCaseDataSet.ExpertsList, Me.cmbDCExpertSection.Text)
            If Me.DocumentCaseDataSet.ExpertsList.Count = 1 Then
                Me.cmbDCExpertName.Text = Me.DocumentCaseDataSet.ExpertsList(0).ExpertName
            End If
        End If
    End Sub


    Private Sub dtDocument_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtDocumentCase.GotFocus
        On Error Resume Next
        If Me.dtDocumentCase.Text = "" Then Me.dtDocumentCase.Value = Today
    End Sub



    Private Function MandatoryDocumentFieldsFilled() As Boolean
        On Error Resume Next
        If Me.cmbDCExpertName.Text.Trim = "" Or Me.cmbDCExpertSection.Text.Trim = "" Or Me.dtDocumentCase.Text = Nothing Or Me.txtInwardNumber.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function


    Private Function MandatoryCourtFieldsFilled() As Boolean
        On Error Resume Next
        If Me.cmbCDExpertName.Text.Trim = "" Or Me.txtCDCourt.Text.Trim = "" Or Me.dtHearing.Text = Nothing Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub txtFileNumber_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDCExpertSection.TextChanged, dtDocumentCase.TextChanged, txtInwardNumber.ValueChanged
        On Error Resume Next
        If Me.cmbDCExpertSection.Text = "" Or Me.cmbDCExpertName.Text = "" Or Me.dtDocumentCase.Text = "" Or Me.txtInwardNumber.Value = Nothing Then
            Me.txtFileNumber.Text = ""
            Exit Sub
        End If

        Me.txtFileNumber.Text = Me.cmbDCExpertSection.Text & "/" & Me.txtInwardNumber.Text & "/" & Year(Me.dtDocumentCase.Value).ToString.Substring(2, 2) & "/FPB"
    End Sub

    Private Sub ShowMandatoryDocumentFieldsMessage()
        On Error Resume Next
        Dim msg1 As String = "Please fill the following mandatory field(s):" & vbNewLine & vbNewLine
        Dim msg As String = ""
        Dim x As Integer = 0


        If Me.cmbDCExpertSection.Text.Trim = "" Then
            msg = msg & " Expert's Section" & vbNewLine
            If x <> 1 Then x = 2
        End If

        If Me.cmbDCExpertName.Text.Trim = "" Then
            msg = msg & " Expert's Name" & vbNewLine
            If x <> 1 And x <> 2 Then x = 3
        End If
        If Me.dtDocumentCase.Text = Nothing Then
            msg = msg & " Date" & vbNewLine
            If x <> 1 And x <> 2 And x <> 3 Then x = 4
        End If
        If Me.txtInwardNumber.Text = "" Then
            msg = msg & " File Number" & vbNewLine
            If x <> 1 And x <> 2 And x <> 3 And x <> 4 Then x = 5
        End If


        msg1 = msg1 & msg
        DevComponents.DotNetBar.MessageBoxEx.Show(msg1, AppName, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Select Case x
            Case 2
                Me.cmbDCExpertSection.Focus()
            Case 3
                Me.cmbDCExpertName.Focus()
            Case 4
                Me.dtDocumentCase.Focus()
            Case 5
                Me.txtInwardNumber.Focus()
        End Select

    End Sub



    Private Sub ShowMandatoryCourtFieldsMessage()
        On Error Resume Next
        Dim msg1 As String = "Please fill the following mandatory field(s):" & vbNewLine & vbNewLine
        Dim msg As String = ""
        Dim x As Integer = 0


        If Me.cmbCDExpertName.Text.Trim = "" Then
            msg = msg & " Name of the Expert" & vbNewLine
            If x <> 1 Then x = 2
        End If

        If Me.txtCDCourt.Text.Trim = "" Then
            msg = msg & " Name of the Court" & vbNewLine
            If x <> 1 And x <> 2 Then x = 3
        End If
        If Me.dtHearing.Text = Nothing Then
            msg = msg & " Hearing Date" & vbNewLine
            If x <> 1 And x <> 2 And x <> 3 Then x = 4
        End If



        msg1 = msg1 & msg
        DevComponents.DotNetBar.MessageBoxEx.Show(msg1, AppName, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Select Case x
            Case 2
                Me.cmbCDExpertName.Focus()
            Case 3
                Me.txtCDCourt.Focus()
            Case 4
                Me.dtHearing.Focus()

        End Select

    End Sub

#End Region


#Region "DATAGRID PROPERTIES"

    Private Sub PaintSerialNumber(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles DocumentDataGridView.CellPainting, CourtDataGridView.CellPainting
        On Error Resume Next
        Dim sf As New StringFormat
        sf.Alignment = StringAlignment.Center

        Dim f As Font = New Font("Segoe UI", 10, FontStyle.Bold)
        sf.LineAlignment = StringAlignment.Center
        Using b As SolidBrush = New SolidBrush(Me.ForeColor)
            If e.ColumnIndex < 0 AndAlso e.RowIndex < 0 Then
                e.Graphics.DrawString("Sl.No", f, b, e.CellBounds, sf)
                e.Handled = True
            End If

            If e.ColumnIndex < 0 AndAlso e.RowIndex >= 0 Then
                e.Graphics.DrawString((e.RowIndex + 1).ToString, f, b, e.CellBounds, sf)
                e.Handled = True
            End If
        End Using

    End Sub


    Private Sub DocumentDataGridView_CellValueNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValueEventArgs) ' Handles DocumentDataGridView.CellValueNeeded
        ' If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.SlNo.Index Then
        'e.Value = e.RowIndex + 1
        ' End If
    End Sub
#End Region



    Private Sub btnDummySave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDummySave.Click
        If CurrentTab = "Document" Then
            SaveDocumentData()
        Else
            SaveCourtData()
        End If
    End Sub


#Region "SAVE DOCUMENT DATA"



    Private Sub SaveDocumentData() Handles btnSaveDocuments.Click
        Try
            If MandatoryDocumentFieldsFilled() = False Then
                ShowMandatoryDocumentFieldsMessage()
                Exit Sub
            End If



            If btnSaveDocuments.Text = "Save" Then

                If Me.DocumentCaseTableAdapter.CheckFileNumber(Me.txtFileNumber.Text.Trim) > 0 Then
                    DevComponents.DotNetBar.MessageBoxEx.Show("File Number <b>" & Me.txtFileNumber.Text.Trim & "</b> already exists.", AppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtFileNumber.Focus()
                    Exit Sub
                End If

                Dim newRow As DocumentCaseDataSet.DocumentCaseRow
                newRow = Me.DocumentCaseDataSet.DocumentCase.NewDocumentCaseRow

                With newRow
                    .ExpertID = Me.cmbDCExpertSection.Text
                    .ExpertName = Me.cmbDCExpertName.Text
                    .DocumentDate = Me.dtDocumentCase.ValueObject
                    .FileNo = Me.txtFileNumber.Text
                    .Court = Me.txtDCCourt.Text
                    .PS = Me.cmbDCPS.Text
                    .CrNo = Me.txtDCCrNo.Text
                    .FeesRemitted = Me.txtFeesRemitted.Value
                    .DateToPB = Me.dtToPB.ValueObject
                    .DateFromPB = Me.dtFromPB.ValueObject
                    .Status = Me.cmbStatus.Text
                    .DespatchDate = Me.dtDespatch.ValueObject
                    .DespatchMode = Me.cmbDespatchMode.Text
                    .DespatchAddress = Me.txtDespatchAdress.Text
                    .InwardNumber = Me.txtInwardNumber.Text
                End With
                Me.DocumentCaseDataSet.DocumentCase.Rows.Add(newRow)
                Me.DocumentCaseTableAdapter.Insert(Me.dtDocumentCase.ValueObject, Me.txtFileNumber.Text.Trim, Me.txtDCCourt.Text.Trim, Me.cmbDCPS.Text.Trim, Me.txtDCCrNo.Text.Trim, Me.dtToPB.ValueObject, Me.dtFromPB.ValueObject, Me.cmbStatus.Text.Trim, Me.dtDespatch.ValueObject, Me.cmbDespatchMode.Text.Trim, Me.txtDespatchAdress.Text.Trim, Me.cmbDCExpertName.Text.Trim, Me.cmbDCExpertSection.Text.Trim, Me.txtFeesRemitted.Value, Me.txtInwardNumber.Text.Trim)
                Me.DocumentCaseBindingSource.Position = Me.DocumentCaseBindingSource.Find("DocumentID", newRow.DocumentID)
                InitializeFields()
                Me.btnSaveDocuments.Text = "Save"
            End If

            If btnSaveDocuments.Text = "Update" Then

                If OldFileNumber <> Me.txtFileNumber.Text.Trim Then
                    If Me.DocumentCaseTableAdapter.CheckFileNumber(Me.txtFileNumber.Text.Trim) > 0 Then
                        DevComponents.DotNetBar.MessageBoxEx.Show("File Number <b>" & Me.txtFileNumber.Text.Trim & "</b> already exists.", AppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtFileNumber.Focus()
                        Exit Sub
                    End If
                End If

                Dim oldRow As DocumentCaseDataSet.DocumentCaseRow 'add a new row to insert values
                oldRow = Me.DocumentCaseDataSet.DocumentCase.FindByFileNo(OldFileNumber)
                If oldRow IsNot Nothing Then
                    With oldRow
                        .ExpertID = Me.cmbDCExpertSection.Text
                        .ExpertName = Me.cmbDCExpertName.Text
                        .DocumentDate = Me.dtDocumentCase.ValueObject
                        .FileNo = Me.txtFileNumber.Text
                        .Court = Me.txtDCCourt.Text
                        .PS = Me.cmbDCPS.Text
                        .CrNo = Me.txtDCCrNo.Text
                        .FeesRemitted = Me.txtFeesRemitted.Value
                        .DateToPB = Me.dtToPB.ValueObject
                        .DateFromPB = Me.dtFromPB.ValueObject
                        .Status = Me.cmbStatus.Text
                        .DespatchDate = Me.dtDespatch.ValueObject
                        .DespatchMode = Me.cmbDespatchMode.Text
                        .DespatchAddress = Me.txtDespatchAdress.Text
                        .InwardNumber = Me.txtInwardNumber.Text
                    End With
                End If

                Me.DocumentCaseTableAdapter.UpdateQuery(Me.dtDocumentCase.ValueObject, Me.txtFileNumber.Text.Trim, Me.txtDCCourt.Text.Trim, Me.cmbDCPS.Text.Trim, Me.txtDCCrNo.Text.Trim, Me.dtToPB.ValueObject, Me.dtFromPB.ValueObject, Me.cmbStatus.Text.Trim, Me.dtDespatch.ValueObject, Me.cmbDespatchMode.Text.Trim, Me.txtDespatchAdress.Text.Trim, Me.cmbDCExpertName.Text.Trim, Me.cmbDCExpertSection.Text.Trim, Me.txtFeesRemitted.Value, Me.txtInwardNumber.Text.Trim, OldFileNumber)
                Me.DocumentCaseBindingSource.Position = Me.DocumentCaseBindingSource.Find("FileNo", OldFileNumber)
                InitializeFields()
                Me.btnSaveDocuments.Text = "Save"
                OldFileNumber = ""
            End If

        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show("The data you entered cannot be updated for the following reason:" & vbNewLine & vbNewLine & vbTab & ex.Message, AppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

#End Region



#Region "SAVE COURT DATA"


    Private Sub SaveCourtData() Handles btnSaveCourt.Click
        Try
            If MandatoryCourtFieldsFilled() = False Then
                ShowMandatoryCourtFieldsMessage()
                Exit Sub
            End If


            If Me.cmbCivilCriminal.Text.ToLower <> "civil" And Me.cmbCivilCriminal.Text.ToLower <> "criminal" And Me.cmbCivilCriminal.Text.ToLower <> "" Then
                DevComponents.DotNetBar.MessageBoxEx.Show("Value you entered for the field 'Civil/Criminal' is not valid.", AppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cmbCivilCriminal.Focus()
                Exit Sub
            End If


            If Me.cmbExamined.Text.ToLower <> "yes" And Me.cmbExamined.Text.ToLower <> "no" And Me.cmbExamined.Text.ToLower <> "" Then
                DevComponents.DotNetBar.MessageBoxEx.Show("Value you entered for the field 'Examined or Not' is not valid.", AppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cmbExamined.Focus()
                Exit Sub
            End If

            If btnSaveCourt.Text = "Save" Then
                Dim newRow As DocumentCaseDataSet.CourtDutyRow
                newRow = Me.DocumentCaseDataSet.CourtDuty.NewCourtDutyRow
                Dim examined As Boolean = IIf(Me.cmbExamined.Text.ToLower.Trim = "yes", True, False)
                With newRow
                    .Expert = Me.cmbCDExpertName.Text
                    .Court = Me.txtCDCourt.Text
                    .DateOfHearing = Me.dtHearing.ValueObject
                    .TypeOfCase = Me.cmbCivilCriminal.Text
                    .CCNo = Me.txtCDCCNo.Text
                    .CrNo = Me.txtCDCrNo.Text
                    .PS = Me.cmbCDPS.Text
                    .AbsentFee = Me.txtAbsentFees.Value
                    .TADA = Me.txtTADA.Value
                    .ExaminedOrNot = examined
                    .PostponedDate = Me.dtPostponed.ValueObject
                End With
                Me.DocumentCaseDataSet.CourtDuty.Rows.Add(newRow)
                Me.CourtDutyTableAdapter.Insert(Me.cmbCDExpertName.Text.Trim, Me.txtCDCourt.Text.Trim, Me.dtHearing.ValueObject, Me.cmbCivilCriminal.Text.Trim, Me.txtCDCCNo.Text.Trim, Me.txtCDCrNo.Text.Trim, Me.cmbCDPS.Text.Trim, Me.txtAbsentFees.Value, Me.txtTADA.Value, examined, Me.dtPostponed.ValueObject)
                Me.CourtDutyBindingSource.Position = Me.CourtDutyBindingSource.Find("ID", newRow.ID)
                InitializeFields()
                Me.btnSaveCourt.Text = "Save"
            End If

            If btnSaveCourt.Text = "Update" Then
                Dim oldRow As DocumentCaseDataSet.CourtDutyRow 'add a new row to insert values
                oldRow = Me.DocumentCaseDataSet.CourtDuty.FindByID(OldCourtID)
                Dim examined As Boolean = IIf(Me.cmbExamined.Text.ToLower.Trim = "yes", True, False)
                If oldRow IsNot Nothing Then
                    With oldRow
                        .Expert = Me.cmbCDExpertName.Text
                        .Court = Me.txtCDCourt.Text
                        .DateOfHearing = Me.dtHearing.ValueObject
                        .TypeOfCase = Me.cmbCivilCriminal.Text
                        .CCNo = Me.txtCDCCNo.Text
                        .CrNo = Me.txtCDCrNo.Text
                        .PS = Me.cmbCDPS.Text
                        .AbsentFee = Me.txtAbsentFees.Value
                        .TADA = Me.txtTADA.Value
                        .ExaminedOrNot = examined
                        .PostponedDate = Me.dtPostponed.ValueObject
                    End With
                End If

                Me.CourtDutyTableAdapter.UpdateQuery(Me.cmbCDExpertName.Text.Trim, Me.txtCDCourt.Text.Trim, Me.dtHearing.ValueObject, Me.cmbCivilCriminal.Text.Trim, Me.txtCDCCNo.Text.Trim, Me.txtCDCrNo.Text.Trim, Me.cmbCDPS.Text.Trim, Me.txtAbsentFees.Value, Me.txtTADA.Value, examined, Me.dtPostponed.ValueObject, OldCourtID)
                Me.CourtDutyBindingSource.Position = Me.CourtDutyBindingSource.Find("ID", OldCourtID)
                InitializeFields()
                Me.btnSaveCourt.Text = "Save"
                OldCourtID = ""
            End If

        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show("The data you entered cannot be updated for the following reason:" & vbNewLine & vbNewLine & vbTab & ex.Message, AppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

#End Region



#Region "EDIT DATA"


    Private Sub EditData() Handles btnEdit.Click
        On Error Resume Next


        If CurrentTab = "Document" Then
            If DocumentDataGridView.SelectedRows.Count = 0 Then
                DevComponents.DotNetBar.MessageBoxEx.Show("No records selected", AppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            ClearAllDocumentFields()
            Me.btnSaveDocuments.Text = "Update"

            With DocumentDataGridView.SelectedRows(0)
                OldDocumentID = .Cells(0).Value
                Me.cmbDCExpertSection.Text = .Cells(1).Value
                Me.cmbDCExpertName.Text = .Cells(2).Value
                Me.dtDocumentCase.ValueObject = .Cells(3).Value
                Me.txtDCCourt.Text = .Cells(5).Value
                Me.cmbDCPS.Text = .Cells(6).Value
                Me.txtDCCrNo.Text = .Cells(7).Value
                Me.txtFeesRemitted.Value = .Cells(8).Value
                Me.dtToPB.ValueObject = .Cells(9).Value
                Me.dtFromPB.ValueObject = .Cells(10).Value
                Me.cmbStatus.Text = .Cells(11).Value
                Me.dtDespatch.ValueObject = .Cells(12).Value
                Me.cmbDespatchMode.Text = .Cells(13).Value
                Me.txtDespatchAdress.Text = .Cells(14).Value
                Me.txtInwardNumber.Value = .Cells(15).Value
                Me.txtFileNumber.Text = .Cells(4).Value
                OldFileNumber = .Cells(4).Value
            End With
        End If



        If CurrentTab = "Court" Then
            If CourtDataGridView.SelectedRows.Count = 0 Then
                DevComponents.DotNetBar.MessageBoxEx.Show("No records selected", AppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            ClearAllDocumentFields()
            Me.btnSaveCourt.Text = "Update"

            With CourtDataGridView.SelectedRows(0)
                OldCourtID = .Cells(11).Value
                Me.cmbCDExpertName.Text = .Cells(0).Value
                Me.txtCDCourt.Text = .Cells(1).Value
                Me.dtHearing.ValueObject = .Cells(2).Value
                Me.cmbCivilCriminal.Text = .Cells(3).Value
                Me.txtCDCCNo.Text = .Cells(4).Value
                Me.txtCDCrNo.Text = .Cells(5).Value
                Me.cmbCDPS.Text = .Cells(6).Value
                Me.txtAbsentFees.Value = .Cells(7).Value
                Me.txtTADA.Value = .Cells(8).Value
                Me.cmbExamined.Text = IIf(.Cells(9).Value = True, "Yes", "No")
                Me.dtPostponed.ValueObject = .Cells(10).Value
            End With
        End If

    End Sub
#End Region


#Region "DELETE DATA"

    Private Sub DeleteSelectedItem() Handles btnDelete.Click
        Try

            If CurrentTab = "Document" Then
                If Me.DocumentDataGridView.SelectedRows.Count = 0 Then
                    DevComponents.DotNetBar.MessageBoxEx.Show("No records selected", AppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If


                If DevComponents.DotNetBar.MessageBoxEx.Show("Do you really want to delete the selected record?", AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                    Me.btnSaveDocuments.Text = "Save"
                    OldFileNumber = ""
                    Me.DocumentCaseTableAdapter.DeleteQuery(Me.DocumentDataGridView.SelectedRows(0).Cells(0).Value)
                    Me.DocumentCaseBindingSource.RemoveCurrent()
                End If

            End If


            If CurrentTab = "Court" Then
                If Me.CourtDataGridView.SelectedRows.Count = 0 Then
                    DevComponents.DotNetBar.MessageBoxEx.Show("No records selected", AppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If


                If DevComponents.DotNetBar.MessageBoxEx.Show("Do you really want to delete the selected record?", AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                    Me.btnSaveCourt.Text = "Save"
                    OldCourtID = ""
                    Me.CourtDutyTableAdapter.DeleteQuery(Me.CourtDataGridView.SelectedRows(0).Cells(11).Value)
                    Me.CourtDutyBindingSource.RemoveCurrent()
                End If

            End If


        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, AppName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



#End Region


#Region "SEARCH"
    Private Sub Search() Handles btnSearch.Click

        On Error GoTo err

        If CurrentTab = "Document" Then

            Dim expertid As String = IIf(Me.cmbDCExpertSection.Text.Trim = "", "", " ExpertID like '" & Me.cmbDCExpertSection.Text.Trim & "%'")
            Dim expertname As String = IIf(Me.cmbDCExpertName.Text.Trim = "", "", " ExpertName like '" & Me.cmbDCExpertName.Text.Trim & "%'")
            Dim documentdate As String = IIf(Me.dtDocumentCase.Text = "", "", " DocumentDate = #" & Me.dtDocumentCase.Value & "#")
            Dim inwardnumber As String = IIf(Me.txtInwardNumber.Text = Nothing, "", " InwardNumber = " & Me.txtInwardNumber.Text)
            Dim court As String = IIf(Me.txtDCCourt.Text.Trim = "", "", " Court like '" & Me.txtDCCourt.Text.Trim & "%'")
            Dim ps As String = IIf(Me.cmbDCPS.Text.Trim = "", "", " PS like '" & Me.cmbDCPS.Text.Trim & "%'")
            Dim cr As String = IIf(Me.txtDCCrNo.Text.Trim = "", "", " CrNo like '" & Me.txtDCCrNo.Text.Trim & "%'")
            Dim fees As String = IIf(Me.txtFeesRemitted.Text = Nothing, "", " FeesRemitted = " & Me.txtFeesRemitted.Text)
            Dim dttopb As String = IIf(Me.dtToPB.Text = "", "", " DateToPB = #" & Me.dtToPB.Value & "#")
            Dim dtfrompb As String = IIf(Me.dtFromPB.Text = "", "", " DateFromPB = #" & Me.dtFromPB.Value & "#")
            Dim status As String = IIf(Me.cmbStatus.Text.Trim = "", "", " Status like '" & Me.cmbStatus.Text.Trim & "%'")
            Dim despatchdate As String = IIf(Me.dtDespatch.Text = "", "", " DespatchDate = #" & Me.dtDespatch.Value & "#")
            Dim despatchmode As String = IIf(Me.cmbDespatchMode.Text.Trim = "", "", " DespatchMode like '" & Me.cmbDespatchMode.Text.Trim & "%'")
            Dim despatchaddress As String = IIf(Me.txtDespatchAdress.Text.Trim = "", "", " DespatchAddress like '" & Me.txtDespatchAdress.Text.Trim & "%'")

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
                Exit Sub
            End If
            Dim con As OleDb.OleDbConnection = New OleDb.OleDbConnection(ConString)
            con.Open()
            Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sqltext, con)
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Me.DocumentCaseDataSet.DocumentCase.Clear()
            da.Fill(Me.DocumentCaseDataSet.DocumentCase)
        End If



        If CurrentTab = "Court" Then


            Dim expertname As String = IIf(Me.cmbCDExpertName.Text.Trim = "", "", " Expert like '" & Me.cmbCDExpertName.Text.Trim & "%'")
            Dim court As String = IIf(Me.txtCDCourt.Text.Trim = "", "", " Court like '" & Me.txtCDCourt.Text.Trim & "%'")
            Dim hearingdate As String = IIf(Me.dtHearing.Text = "", "", " DateOfHearing = #" & Me.dtHearing.Value & "#")
            Dim casetype As String = IIf(Me.cmbCivilCriminal.Text = "", "", " TypeOfCase like '" & Me.cmbCivilCriminal.Text.Trim & "%'")
            Dim ccno As String = IIf(Me.txtCDCCNo.Text.Trim = "", "", " CCNo like '" & Me.txtCDCCNo.Text.Trim & "%'")
            Dim ps As String = IIf(Me.cmbCDPS.Text.Trim = "", "", " PS like '" & Me.cmbCDPS.Text.Trim & "%'")
            Dim cr As String = IIf(Me.txtCDCrNo.Text.Trim = "", "", " CrNo like '" & Me.txtCDCrNo.Text.Trim & "%'")
            Dim fees As String = IIf(Me.txtAbsentFees.Text = Nothing, "", " AbsentFee = " & Me.txtAbsentFees.Text)
            Dim tada As String = IIf(Me.txtTADA.Text = Nothing, "", " TADA = " & Me.txtTADA.Text)
            Dim bexamined As Boolean = IIf(Me.cmbExamined.Text.ToLower.Trim = "yes", True, False)
            Dim examined As String = IIf(Me.cmbExamined.Text.Trim = "", "", " ExaminedOrNot = " & bexamined)
            Dim dtpostponed As String = IIf(Me.dtPostponed.Text = "", "", " PostponedDate = #" & Me.dtPostponed.Value & "#")

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
                Exit Sub
            End If
            '   MsgBox(sqltext)
            Dim con As OleDb.OleDbConnection = New OleDb.OleDbConnection(ConString)
            con.Open()
            Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sqltext, con)
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Me.DocumentCaseDataSet.CourtDuty.Clear()
            da.Fill(Me.DocumentCaseDataSet.CourtDuty)
        End If



        Exit Sub
err:
        DevComponents.DotNetBar.MessageBoxEx.Show(Err.Description, AppName, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub


    Private Sub btnSearchPeriod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchPeriod.Click

        Dim title As String = "Search"
        If CurrentTab = "Court" Then
            frmSearch.Text = "Search Court Duty"
            frmSearch.TitleText = "Search Court Duty"
        Else
            frmSearch.Text = "Search Document Case"
            frmSearch.TitleText = "Search Document Case"
        End If

        frmSearch.StartPosition = FormStartPosition.CenterParent
        frmSearch.ShowDialog()
        frmSearch.BringToFront()
    End Sub
#End Region


#Region "MISCELLANEOUS"


    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        frmAbout.ShowDialog()
    End Sub


    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        If CurrentTab = "Court" Then
            frmCourtDutyReport.Show()
            frmCourtDutyReport.BringToFront()
        Else
            frmDocumentCaseReport.Show()
            frmDocumentCaseReport.BringToFront()
        End If

    End Sub


    Private Sub TabControl1_SelectedTabChanged(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.TabStripTabChangedEventArgs) Handles TabControl1.SelectedTabChanged
        Select Case e.NewTab.Name

            Case tabDocumentCase.Name
                CurrentTab = "Document"
                Me.RibbonBar1.Text = "Document Case"
                Me.cmbDCExpertSection.Focus()
            Case tabCourtDuty.Name
                CurrentTab = "Court"
                Me.RibbonBar1.Text = "Court Duty"
                Me.cmbCDExpertName.Focus()
        End Select
    End Sub
#End Region


#Region "OPEN DATABASE"

    Private Sub OpenDBLocation() Handles btnOpenDBFolder.Click
        Try
            Call Shell("explorer.exe /select," & DatabaseFile, AppWinStyle.NormalFocus)
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, AppName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub OpenDBInAccess() Handles btnOpenDBInAccess.Click
        Try
            Shell("explorer.exe " & DatabaseFile, AppWinStyle.MaximizedFocus)
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, AppName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region



#Region "IMPORT AND EXPORT DATABASE"


    Private Sub ExportDatabase() Handles btnExport.Click
        Try
            Dim Source As String = DatabaseFile
            Dim Destination As String
            Me.FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer
            Me.FolderBrowserDialog1.ShowNewFolderButton = True
            Me.FolderBrowserDialog1.Description = "Select location to export database"
            Dim result As DialogResult = FolderBrowserDialog1.ShowDialog()
            If (result = DialogResult.OK) Then
                Dim Path As String = Me.FolderBrowserDialog1.SelectedPath
                If Path = AppPath Then
                    DevComponents.DotNetBar.MessageBoxEx.Show("The source and destination are same. Cannot export database", AppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                Destination = Path & "\DocumentCase.mdb"
                My.Computer.FileSystem.CopyFile(Source, Destination, FileIO.UIOption.AllDialogs, FileIO.UICancelOption.ThrowException)
                DevComponents.DotNetBar.MessageBoxEx.Show("Database exported", AppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, AppName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub



    Sub ImportDatabase() Handles btnImport.Click
        On Error Resume Next
        OpenFileDialog1.Filter = "DocumentCase.mdb(*.mdb)|*.mdb"
        OpenFileDialog1.FileName = "DocumentCase.mdb"
        OpenFileDialog1.Title = "Select Database to import data"
        OpenFileDialog1.RestoreDirectory = True
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim SelectedDB As String = OpenFileDialog1.FileName
            If SelectedDB = DatabaseFile Then
                DevComponents.DotNetBar.MessageBoxEx.Show("The source and destination files are same. Cannot import data!", AppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Me.Refresh()
            Application.DoEvents()
            If OpenSelectedDB(SelectedDB) = False Then Exit Sub
        Else
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor
        DocumentCaseImportAdapter.Fill(DocumentCaseImportDataSet.DocumentCase)
        Dim initialcount As Long = DocumentCaseTableAdapter.CountQuery
        ' Me.TempDocumentCaseDataSet.Clear()
        Me.TempDocumentCaseTableAdapter.Fill(Me.TempDocumentCaseDataSet.DocumentCase)
        Me.TempDocumentCaseDataSet.Merge(Me.DocumentCaseImportDataSet.DocumentCase)
        ' Me.DocumentDataGridView.DataSource = Me.TempDocumentCaseDataSet.DocumentCase
        ' Me.Cursor = Cursors.Default
        ' Exit Sub
        Dim finalcount = TempDocumentCaseDataSet.DocumentCase.Count

        Dim progvalue = finalcount - initialcount
        If progvalue = 0 Then
            MessageBoxEx.Show("No records were imported!", AppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        frmImportData.StartPosition = FormStartPosition.CenterScreen
        frmImportData.Show()

        frmImportData.ProgressBar.Maximum = progvalue
        frmImportData.ProgressBar.Text = "Please Wait. Importing Data ..."
        For i As Long = initialcount To finalcount
            If CancelImport = True Then
                Dim reply As DialogResult

                reply = MessageBoxEx.Show("Do you want to cancel importing of data?", AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                If reply = Windows.Forms.DialogResult.Yes Then
                    Exit For
                Else
                    CancelImport = False
                End If
            End If

            With TempDocumentCaseDataSet.DocumentCase.Item(i)

                Dim filenumber = .FileNo
                Me.dtDummy.Text = .DespatchDate
                Dim despatchdate = Me.dtDummy.ValueObject
                Me.dtDummy.Text = .DocumentDate
                Dim documentdate = Me.dtDummy.ValueObject
                Me.dtDummy.Text = .DateToPB
                Dim DateToPB = Me.dtDummy.ValueObject

                Me.dtDummy.Text = .DateFromPB
                Dim DateFromPB = Me.dtDummy.ValueObject

                If Me.DocumentCaseTableAdapter.CheckFileNumber(filenumber) = False Then
                    Me.DocumentCaseTableAdapter.Insert(documentdate, filenumber, .Court, .PS, .CrNo, DateToPB, DateFromPB, .Status, despatchdate, .DespatchMode, .DespatchAddress, .ExpertName, .ExpertID, .FeesRemitted, .InwardNumber)

                End If
                frmImportData.ProgressBar.Increment(1)
                frmImportData.ProgressBar.Text = "Please Wait. Imported " & frmImportData.ProgressBar.Value & " of " & progvalue & " records"
                Application.DoEvents()
            End With

        Next
        frmImportData.Close()
        '   UpdateNullValues()

        btnReload.RaiseClick()

        Me.DocumentCaseImportDataSet.Clear()
        Me.TempDocumentCaseDataSet.Clear()

        DocumentCaseImportAdapter.Connection.Close()

        finalcount = Me.DocumentCaseTableAdapter.CountQuery
        Dim c = finalcount - initialcount
        If c = 0 Then
            MessageBoxEx.Show("No records were imported", AppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf c = 1 Then
            MessageBoxEx.Show("1 Record imported successfully", AppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBoxEx.Show(c & " Records imported successfully", AppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.Cursor = Cursors.Default


    End Sub

    Private Function OpenSelectedDB(ByVal SelectedDB As String) As Boolean
        OpenSelectedDB = False
        Try
            If Me.DocumentCaseImportAdapter.Connection.State = ConnectionState.Open Then Me.DocumentCaseImportAdapter.Connection.Close()
            Me.DocumentCaseImportAdapter.Connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & SelectedDB
            Me.DocumentCaseImportAdapter.Connection.Open()

            OpenSelectedDB = True
        Catch ex As Exception
            ' MessageBoxEx.Show(ex.Message, AppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            OpenSelectedDB = False
        End Try
    End Function


#End Region

    Private Sub DataGridViewX1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridViewX1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Me.TableAdapterManager.ExpertsListTableAdapter.Update(DocumentCaseDataSet.ExpertsList)
    End Sub
End Class
