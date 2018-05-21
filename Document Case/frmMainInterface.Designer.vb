<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainInterface
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainInterface))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StyleManager2 = New DevComponents.DotNetBar.StyleManager()
        Me.tabDocument = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.RibbonBar1 = New DevComponents.DotNetBar.RibbonBar()
        Me.btnNew = New DevComponents.DotNetBar.ButtonItem()
        Me.btnEdit = New DevComponents.DotNetBar.ButtonItem()
        Me.btnDelete = New DevComponents.DotNetBar.ButtonItem()
        Me.btnReload = New DevComponents.DotNetBar.ButtonItem()
        Me.btnSearch = New DevComponents.DotNetBar.ButtonItem()
        Me.btnSearchPeriod = New DevComponents.DotNetBar.ButtonItem()
        Me.btnReport = New DevComponents.DotNetBar.ButtonItem()
        Me.btnExport = New DevComponents.DotNetBar.ButtonItem()
        Me.btnImport = New DevComponents.DotNetBar.ButtonItem()
        Me.btnOpenDBFolder = New DevComponents.DotNetBar.ButtonItem()
        Me.btnOpenDBInAccess = New DevComponents.DotNetBar.ButtonItem()
        Me.btnAbout = New DevComponents.DotNetBar.ButtonItem()
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.DocumentDataGridView = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.DocumentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpertIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpertNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocumentDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeesRemittedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateToPBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateFromPBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DespatchDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DespatchModeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DespatchAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InwardNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocumentCaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DocumentCaseDataSet = New DocumentCase.DocumentCaseDataSet()
        Me.btnDummySave = New DevComponents.DotNetBar.ButtonX()
        Me.PanelDocuments = New DevComponents.DotNetBar.PanelEx()
        Me.dtDummy = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.txtInwardNumber = New DevComponents.Editors.IntegerInput()
        Me.txtFileNumber = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.txtFeesRemitted = New DevComponents.Editors.IntegerInput()
        Me.cmbDespatchMode = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cmbStatus = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cmbDCPS = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cmbDCExpertName = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ExpertsListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbDCExpertSection = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.btnSaveDocuments = New DevComponents.DotNetBar.ButtonX()
        Me.txtDespatchAdress = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dtDespatch = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dtDocumentCase = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dtToPB = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dtFromPB = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.txtDCCrNo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtDCCourt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.tabDocumentCase = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.CourtDataGridView = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.ExpertDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourtDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfHearingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeOfCaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrNoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbsentFeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TADADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExaminedOrNotDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PostponedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourtDutyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelCourt = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX32 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX31 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX30 = New DevComponents.DotNetBar.LabelX()
        Me.cmbCDExpertName = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.btnSaveCourt = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX29 = New DevComponents.DotNetBar.LabelX()
        Me.dtPostponed = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.cmbExamined = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtTADA = New DevComponents.Editors.IntegerInput()
        Me.txtAbsentFees = New DevComponents.Editors.IntegerInput()
        Me.cmbCDPS = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX25 = New DevComponents.DotNetBar.LabelX()
        Me.txtCDCrNo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCDCCNo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cmbCivilCriminal = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.dtHearing = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX28 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX27 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX26 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX24 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX23 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX22 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX21 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX20 = New DevComponents.DotNetBar.LabelX()
        Me.txtCDCourt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.tabCourtDuty = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.ExpertsListBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DocumentCaseTableAdapter = New DocumentCase.DocumentCaseDataSetTableAdapters.DocumentCaseTableAdapter()
        Me.PSListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExpertsListTableAdapter = New DocumentCase.DocumentCaseDataSetTableAdapters.ExpertsListTableAdapter()
        Me.PSListTableAdapter = New DocumentCase.DocumentCaseDataSetTableAdapters.PSListTableAdapter()
        Me.StatusTableAdapter = New DocumentCase.DocumentCaseDataSetTableAdapters.StatusTableAdapter()
        Me.TableAdapterManager = New DocumentCase.DocumentCaseDataSetTableAdapters.TableAdapterManager()
        Me.CourtDutyTableAdapter = New DocumentCase.DocumentCaseDataSetTableAdapters.CourtDutyTableAdapter()
        Me.DocumentCaseImportAdapter = New DocumentCase.DocumentCaseDataSetTableAdapters.DocumentCaseTableAdapter()
        Me.DocumentCaseImportDataSet = New DocumentCase.DocumentCaseDataSet()
        Me.TempDocumentCaseDataSet = New DocumentCase.DocumentCaseDataSet()
        Me.TempDocumentCaseTableAdapter = New DocumentCase.DocumentCaseDataSetTableAdapters.DocumentCaseTableAdapter()
        Me.TableAdapterManager1 = New DocumentCase.DocumentCaseDataSetTableAdapters.TableAdapterManager()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        CType(Me.DocumentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentCaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentCaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDocuments.SuspendLayout()
        CType(Me.dtDummy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInwardNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFeesRemitted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpertsListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDespatch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDocumentCase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtToPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFromPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel2.SuspendLayout()
        CType(Me.CourtDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CourtDutyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCourt.SuspendLayout()
        CType(Me.dtPostponed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTADA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbsentFees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtHearing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpertsListBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentCaseImportDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TempDocumentCaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StyleManager2
        '
        Me.StyleManager2.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue
        '
        'tabDocument
        '
        Me.tabDocument.Name = "tabDocument"
        Me.tabDocument.Text = "Document Cases"
        '
        'RibbonBar1
        '
        Me.RibbonBar1.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar1.BackgroundMouseOverStyle.Class = ""
        '
        '
        '
        Me.RibbonBar1.BackgroundStyle.Class = ""
        Me.RibbonBar1.ContainerControlProcessDialogKey = True
        Me.RibbonBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibbonBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnNew, Me.btnEdit, Me.btnDelete, Me.btnReload, Me.btnSearch, Me.btnReport, Me.btnExport, Me.btnImport, Me.btnAbout})
        Me.RibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Size = New System.Drawing.Size(1370, 77)
        Me.RibbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.RibbonBar1.TabIndex = 17
        Me.RibbonBar1.Text = "DocumentCase"
        '
        '
        '
        Me.RibbonBar1.TitleStyle.Class = ""
        '
        '
        '
        Me.RibbonBar1.TitleStyleMouseOver.Class = ""
        '
        'btnNew
        '
        Me.btnNew.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN)
        Me.btnNew.SubItemsExpandWidth = 14
        Me.btnNew.Text = "New"
        '
        'btnEdit
        '
        Me.btnEdit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlE)
        Me.btnEdit.SubItemsExpandWidth = 14
        Me.btnEdit.Text = "Edit"
        '
        'btnDelete
        '
        Me.btnDelete.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlD)
        Me.btnDelete.SubItemsExpandWidth = 14
        Me.btnDelete.Text = "Delete"
        '
        'btnReload
        '
        Me.btnReload.BeginGroup = True
        Me.btnReload.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnReload.Image = CType(resources.GetObject("btnReload.Image"), System.Drawing.Image)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5)
        Me.btnReload.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlR)
        Me.btnReload.SubItemsExpandWidth = 14
        Me.btnReload.Text = "Reload"
        '
        'btnSearch
        '
        Me.btnSearch.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnSearch.Image = Global.DocumentCase.My.Resources.Resources.imgSearch
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlF)
        Me.btnSearch.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnSearchPeriod})
        Me.btnSearch.SubItemsExpandWidth = 14
        Me.btnSearch.Text = "Search"
        '
        'btnSearchPeriod
        '
        Me.btnSearchPeriod.Name = "btnSearchPeriod"
        Me.btnSearchPeriod.Text = "Search during Period"
        '
        'btnReport
        '
        Me.btnReport.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnReport.Image = CType(resources.GetObject("btnReport.Image"), System.Drawing.Image)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.SubItemsExpandWidth = 14
        Me.btnReport.Text = "Reports"
        '
        'btnExport
        '
        Me.btnExport.BeginGroup = True
        Me.btnExport.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Image)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlT)
        Me.btnExport.SubItemsExpandWidth = 14
        Me.btnExport.Text = "Export"
        '
        'btnImport
        '
        Me.btnImport.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnImport.Image = CType(resources.GetObject("btnImport.Image"), System.Drawing.Image)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlI)
        Me.btnImport.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnOpenDBFolder, Me.btnOpenDBInAccess})
        Me.btnImport.SubItemsExpandWidth = 14
        Me.btnImport.Text = "Import"
        '
        'btnOpenDBFolder
        '
        Me.btnOpenDBFolder.Name = "btnOpenDBFolder"
        Me.btnOpenDBFolder.Text = "Open Database Location"
        '
        'btnOpenDBInAccess
        '
        Me.btnOpenDBInAccess.BeginGroup = True
        Me.btnOpenDBInAccess.Name = "btnOpenDBInAccess"
        Me.btnOpenDBInAccess.Text = "Open Database in MS Access"
        '
        'btnAbout
        '
        Me.btnAbout.BeginGroup = True
        Me.btnAbout.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnAbout.Image = CType(resources.GetObject("btnAbout.Image"), System.Drawing.Image)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlI)
        Me.btnAbout.SubItemsExpandWidth = 14
        Me.btnAbout.Text = "About"
        '
        'TabControl1
        '
        Me.TabControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.Controls.Add(Me.TabControlPanel1)
        Me.TabControl1.Controls.Add(Me.TabControlPanel2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 77)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.SelectedTabIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1370, 384)
        Me.TabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document
        Me.TabControl1.TabIndex = 18
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.tabDocumentCase)
        Me.TabControl1.Tabs.Add(Me.tabCourtDuty)
        Me.TabControl1.TabStop = False
        Me.TabControl1.Text = "TabControl1"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.TabControlPanel1.Controls.Add(Me.PanelEx3)
        Me.TabControlPanel1.Controls.Add(Me.PanelDocuments)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 25)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(1370, 359)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.tabDocumentCase
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.DocumentDataGridView)
        Me.PanelEx3.Controls.Add(Me.btnDummySave)
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEx3.Location = New System.Drawing.Point(1, 169)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(1368, 189)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 19
        Me.PanelEx3.Text = "PanelEx3"
        '
        'DocumentDataGridView
        '
        Me.DocumentDataGridView.AllowUserToAddRows = False
        Me.DocumentDataGridView.AllowUserToDeleteRows = False
        Me.DocumentDataGridView.AllowUserToOrderColumns = True
        Me.DocumentDataGridView.AutoGenerateColumns = False
        Me.DocumentDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DocumentDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DocumentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DocumentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DocumentIDDataGridViewTextBoxColumn, Me.ExpertIDDataGridViewTextBoxColumn, Me.ExpertNameDataGridViewTextBoxColumn, Me.DocumentDateDataGridViewTextBoxColumn, Me.FileNoDataGridViewTextBoxColumn, Me.CourtDataGridViewTextBoxColumn, Me.PSDataGridViewTextBoxColumn, Me.CrNoDataGridViewTextBoxColumn, Me.FeesRemittedDataGridViewTextBoxColumn, Me.DateToPBDataGridViewTextBoxColumn, Me.DateFromPBDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.DespatchDateDataGridViewTextBoxColumn, Me.DespatchModeDataGridViewTextBoxColumn, Me.DespatchAddressDataGridViewTextBoxColumn, Me.InwardNumber})
        Me.DocumentDataGridView.DataSource = Me.DocumentCaseBindingSource
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DocumentDataGridView.DefaultCellStyle = DataGridViewCellStyle7
        Me.DocumentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DocumentDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DocumentDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DocumentDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.DocumentDataGridView.MultiSelect = False
        Me.DocumentDataGridView.Name = "DocumentDataGridView"
        Me.DocumentDataGridView.ReadOnly = True
        Me.DocumentDataGridView.RowTemplate.Height = 30
        Me.DocumentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DocumentDataGridView.Size = New System.Drawing.Size(1368, 189)
        Me.DocumentDataGridView.TabIndex = 19
        Me.DocumentDataGridView.TabStop = False
        Me.DocumentDataGridView.VirtualMode = True
        '
        'DocumentIDDataGridViewTextBoxColumn
        '
        Me.DocumentIDDataGridViewTextBoxColumn.DataPropertyName = "DocumentID"
        Me.DocumentIDDataGridViewTextBoxColumn.HeaderText = "DocumentID"
        Me.DocumentIDDataGridViewTextBoxColumn.Name = "DocumentIDDataGridViewTextBoxColumn"
        Me.DocumentIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.DocumentIDDataGridViewTextBoxColumn.Visible = False
        '
        'ExpertIDDataGridViewTextBoxColumn
        '
        Me.ExpertIDDataGridViewTextBoxColumn.DataPropertyName = "ExpertID"
        Me.ExpertIDDataGridViewTextBoxColumn.HeaderText = "Expert Section"
        Me.ExpertIDDataGridViewTextBoxColumn.Name = "ExpertIDDataGridViewTextBoxColumn"
        Me.ExpertIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ExpertIDDataGridViewTextBoxColumn.Width = 80
        '
        'ExpertNameDataGridViewTextBoxColumn
        '
        Me.ExpertNameDataGridViewTextBoxColumn.DataPropertyName = "ExpertName"
        Me.ExpertNameDataGridViewTextBoxColumn.HeaderText = "Name of Expert"
        Me.ExpertNameDataGridViewTextBoxColumn.Name = "ExpertNameDataGridViewTextBoxColumn"
        Me.ExpertNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ExpertNameDataGridViewTextBoxColumn.Width = 150
        '
        'DocumentDateDataGridViewTextBoxColumn
        '
        Me.DocumentDateDataGridViewTextBoxColumn.DataPropertyName = "DocumentDate"
        DataGridViewCellStyle2.Format = "dd/MM/yyyy"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DocumentDateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.DocumentDateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DocumentDateDataGridViewTextBoxColumn.Name = "DocumentDateDataGridViewTextBoxColumn"
        Me.DocumentDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.DocumentDateDataGridViewTextBoxColumn.Width = 85
        '
        'FileNoDataGridViewTextBoxColumn
        '
        Me.FileNoDataGridViewTextBoxColumn.DataPropertyName = "FileNo"
        Me.FileNoDataGridViewTextBoxColumn.HeaderText = "File No"
        Me.FileNoDataGridViewTextBoxColumn.Name = "FileNoDataGridViewTextBoxColumn"
        Me.FileNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FileNoDataGridViewTextBoxColumn.Width = 120
        '
        'CourtDataGridViewTextBoxColumn
        '
        Me.CourtDataGridViewTextBoxColumn.DataPropertyName = "Court"
        Me.CourtDataGridViewTextBoxColumn.HeaderText = "Court"
        Me.CourtDataGridViewTextBoxColumn.Name = "CourtDataGridViewTextBoxColumn"
        Me.CourtDataGridViewTextBoxColumn.ReadOnly = True
        Me.CourtDataGridViewTextBoxColumn.Width = 150
        '
        'PSDataGridViewTextBoxColumn
        '
        Me.PSDataGridViewTextBoxColumn.DataPropertyName = "PS"
        Me.PSDataGridViewTextBoxColumn.HeaderText = "Police Station"
        Me.PSDataGridViewTextBoxColumn.Name = "PSDataGridViewTextBoxColumn"
        Me.PSDataGridViewTextBoxColumn.ReadOnly = True
        Me.PSDataGridViewTextBoxColumn.Width = 150
        '
        'CrNoDataGridViewTextBoxColumn
        '
        Me.CrNoDataGridViewTextBoxColumn.DataPropertyName = "CrNo"
        Me.CrNoDataGridViewTextBoxColumn.HeaderText = "Cr.No/OS"
        Me.CrNoDataGridViewTextBoxColumn.Name = "CrNoDataGridViewTextBoxColumn"
        Me.CrNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FeesRemittedDataGridViewTextBoxColumn
        '
        Me.FeesRemittedDataGridViewTextBoxColumn.DataPropertyName = "FeesRemitted"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.FeesRemittedDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.FeesRemittedDataGridViewTextBoxColumn.HeaderText = "Fees Remitted"
        Me.FeesRemittedDataGridViewTextBoxColumn.Name = "FeesRemittedDataGridViewTextBoxColumn"
        Me.FeesRemittedDataGridViewTextBoxColumn.ReadOnly = True
        Me.FeesRemittedDataGridViewTextBoxColumn.Width = 80
        '
        'DateToPBDataGridViewTextBoxColumn
        '
        Me.DateToPBDataGridViewTextBoxColumn.DataPropertyName = "DateToPB"
        DataGridViewCellStyle4.Format = "dd/MM/yyyy"
        Me.DateToPBDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.DateToPBDataGridViewTextBoxColumn.HeaderText = "Date To PB"
        Me.DateToPBDataGridViewTextBoxColumn.Name = "DateToPBDataGridViewTextBoxColumn"
        Me.DateToPBDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateToPBDataGridViewTextBoxColumn.Width = 85
        '
        'DateFromPBDataGridViewTextBoxColumn
        '
        Me.DateFromPBDataGridViewTextBoxColumn.DataPropertyName = "DateFromPB"
        DataGridViewCellStyle5.Format = "dd/MM/yyyy"
        Me.DateFromPBDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.DateFromPBDataGridViewTextBoxColumn.HeaderText = "Date From PB"
        Me.DateFromPBDataGridViewTextBoxColumn.Name = "DateFromPBDataGridViewTextBoxColumn"
        Me.DateFromPBDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateFromPBDataGridViewTextBoxColumn.Width = 85
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DespatchDateDataGridViewTextBoxColumn
        '
        Me.DespatchDateDataGridViewTextBoxColumn.DataPropertyName = "DespatchDate"
        DataGridViewCellStyle6.Format = "dd/MM/yyyy"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DespatchDateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.DespatchDateDataGridViewTextBoxColumn.HeaderText = "Despatch Date"
        Me.DespatchDateDataGridViewTextBoxColumn.Name = "DespatchDateDataGridViewTextBoxColumn"
        Me.DespatchDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.DespatchDateDataGridViewTextBoxColumn.Width = 85
        '
        'DespatchModeDataGridViewTextBoxColumn
        '
        Me.DespatchModeDataGridViewTextBoxColumn.DataPropertyName = "DespatchMode"
        Me.DespatchModeDataGridViewTextBoxColumn.HeaderText = "Despatch Mode"
        Me.DespatchModeDataGridViewTextBoxColumn.Name = "DespatchModeDataGridViewTextBoxColumn"
        Me.DespatchModeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DespatchAddressDataGridViewTextBoxColumn
        '
        Me.DespatchAddressDataGridViewTextBoxColumn.DataPropertyName = "DespatchAddress"
        Me.DespatchAddressDataGridViewTextBoxColumn.HeaderText = "Despatch Address"
        Me.DespatchAddressDataGridViewTextBoxColumn.Name = "DespatchAddressDataGridViewTextBoxColumn"
        Me.DespatchAddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InwardNumber
        '
        Me.InwardNumber.DataPropertyName = "InwardNumber"
        Me.InwardNumber.HeaderText = "InwardNumber"
        Me.InwardNumber.Name = "InwardNumber"
        Me.InwardNumber.ReadOnly = True
        Me.InwardNumber.Visible = False
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
        'btnDummySave
        '
        Me.btnDummySave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDummySave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnDummySave.Location = New System.Drawing.Point(672, 75)
        Me.btnDummySave.Name = "btnDummySave"
        Me.btnDummySave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.btnDummySave.Size = New System.Drawing.Size(75, 23)
        Me.btnDummySave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnDummySave.TabIndex = 50
        Me.btnDummySave.Text = "Save"
        '
        'PanelDocuments
        '
        Me.PanelDocuments.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelDocuments.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelDocuments.Controls.Add(Me.dtDummy)
        Me.PanelDocuments.Controls.Add(Me.txtInwardNumber)
        Me.PanelDocuments.Controls.Add(Me.txtFileNumber)
        Me.PanelDocuments.Controls.Add(Me.LabelX18)
        Me.PanelDocuments.Controls.Add(Me.LabelX17)
        Me.PanelDocuments.Controls.Add(Me.LabelX16)
        Me.PanelDocuments.Controls.Add(Me.LabelX15)
        Me.PanelDocuments.Controls.Add(Me.txtFeesRemitted)
        Me.PanelDocuments.Controls.Add(Me.cmbDespatchMode)
        Me.PanelDocuments.Controls.Add(Me.cmbStatus)
        Me.PanelDocuments.Controls.Add(Me.cmbDCPS)
        Me.PanelDocuments.Controls.Add(Me.cmbDCExpertName)
        Me.PanelDocuments.Controls.Add(Me.cmbDCExpertSection)
        Me.PanelDocuments.Controls.Add(Me.btnSaveDocuments)
        Me.PanelDocuments.Controls.Add(Me.txtDespatchAdress)
        Me.PanelDocuments.Controls.Add(Me.dtDespatch)
        Me.PanelDocuments.Controls.Add(Me.dtDocumentCase)
        Me.PanelDocuments.Controls.Add(Me.dtToPB)
        Me.PanelDocuments.Controls.Add(Me.dtFromPB)
        Me.PanelDocuments.Controls.Add(Me.txtDCCrNo)
        Me.PanelDocuments.Controls.Add(Me.txtDCCourt)
        Me.PanelDocuments.Controls.Add(Me.LabelX2)
        Me.PanelDocuments.Controls.Add(Me.LabelX14)
        Me.PanelDocuments.Controls.Add(Me.LabelX1)
        Me.PanelDocuments.Controls.Add(Me.LabelX13)
        Me.PanelDocuments.Controls.Add(Me.LabelX3)
        Me.PanelDocuments.Controls.Add(Me.LabelX12)
        Me.PanelDocuments.Controls.Add(Me.LabelX4)
        Me.PanelDocuments.Controls.Add(Me.LabelX11)
        Me.PanelDocuments.Controls.Add(Me.LabelX5)
        Me.PanelDocuments.Controls.Add(Me.LabelX10)
        Me.PanelDocuments.Controls.Add(Me.LabelX6)
        Me.PanelDocuments.Controls.Add(Me.LabelX9)
        Me.PanelDocuments.Controls.Add(Me.LabelX7)
        Me.PanelDocuments.Controls.Add(Me.LabelX8)
        Me.PanelDocuments.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDocuments.Location = New System.Drawing.Point(1, 1)
        Me.PanelDocuments.Name = "PanelDocuments"
        Me.PanelDocuments.Size = New System.Drawing.Size(1368, 168)
        Me.PanelDocuments.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDocuments.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelDocuments.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelDocuments.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelDocuments.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelDocuments.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelDocuments.Style.GradientAngle = 90
        Me.PanelDocuments.TabIndex = 18
        '
        'dtDummy
        '
        '
        '
        '
        Me.dtDummy.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtDummy.ButtonClear.Visible = True
        Me.dtDummy.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtDummy.ButtonDropDown.Visible = True
        Me.dtDummy.CustomFormat = "dd/MM/yyyy"
        Me.dtDummy.FocusHighlightEnabled = True
        Me.dtDummy.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDummy.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.dtDummy.Location = New System.Drawing.Point(625, 71)
        '
        '
        '
        Me.dtDummy.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtDummy.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtDummy.MonthCalendar.BackgroundStyle.Class = ""
        Me.dtDummy.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtDummy.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtDummy.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtDummy.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtDummy.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtDummy.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtDummy.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtDummy.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.dtDummy.MonthCalendar.DisplayMonth = New Date(2012, 8, 1, 0, 0, 0, 0)
        Me.dtDummy.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.dtDummy.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtDummy.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtDummy.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtDummy.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtDummy.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtDummy.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.dtDummy.MonthCalendar.TodayButtonVisible = True
        Me.dtDummy.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtDummy.Name = "dtDummy"
        Me.dtDummy.Size = New System.Drawing.Size(118, 27)
        Me.dtDummy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtDummy.TabIndex = 48
        Me.dtDummy.Tag = "9"
        Me.dtDummy.Visible = False
        Me.dtDummy.WatermarkText = "Date To PB"
        '
        'txtInwardNumber
        '
        '
        '
        '
        Me.txtInwardNumber.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtInwardNumber.ButtonClear.Visible = True
        Me.txtInwardNumber.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtInwardNumber.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInwardNumber.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        Me.txtInwardNumber.Location = New System.Drawing.Point(91, 101)
        Me.txtInwardNumber.Name = "txtInwardNumber"
        Me.txtInwardNumber.Size = New System.Drawing.Size(118, 27)
        Me.txtInwardNumber.TabIndex = 4
        Me.txtInwardNumber.Tag = "15"
        Me.txtInwardNumber.WatermarkText = "Inward Number"
        '
        'txtFileNumber
        '
        '
        '
        '
        Me.txtFileNumber.Border.Class = "TextBoxBorder"
        Me.txtFileNumber.FocusHighlightEnabled = True
        Me.txtFileNumber.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFileNumber.Location = New System.Drawing.Point(215, 101)
        Me.txtFileNumber.MaxLength = 255
        Me.txtFileNumber.Name = "txtFileNumber"
        Me.txtFileNumber.Size = New System.Drawing.Size(139, 27)
        Me.txtFileNumber.TabIndex = 47
        Me.txtFileNumber.TabStop = False
        Me.txtFileNumber.Tag = "4"
        Me.txtFileNumber.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.txtFileNumber.WatermarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFileNumber.WatermarkText = "File Number"
        '
        'LabelX18
        '
        Me.LabelX18.AutoSize = True
        '
        '
        '
        Me.LabelX18.BackgroundStyle.Class = ""
        Me.LabelX18.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX18.ForeColor = System.Drawing.Color.Red
        Me.LabelX18.Location = New System.Drawing.Point(360, 106)
        Me.LabelX18.Name = "LabelX18"
        Me.LabelX18.Size = New System.Drawing.Size(7, 22)
        Me.LabelX18.TabIndex = 46
        Me.LabelX18.Text = "<b>*</b><font color=""#ED1C24""></font>"
        '
        'LabelX17
        '
        Me.LabelX17.AutoSize = True
        '
        '
        '
        Me.LabelX17.BackgroundStyle.Class = ""
        Me.LabelX17.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX17.ForeColor = System.Drawing.Color.Red
        Me.LabelX17.Location = New System.Drawing.Point(215, 74)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.Size = New System.Drawing.Size(7, 22)
        Me.LabelX17.TabIndex = 45
        Me.LabelX17.Text = "<b>*</b><font color=""#ED1C24""></font>"
        '
        'LabelX16
        '
        Me.LabelX16.AutoSize = True
        '
        '
        '
        Me.LabelX16.BackgroundStyle.Class = ""
        Me.LabelX16.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX16.ForeColor = System.Drawing.Color.Red
        Me.LabelX16.Location = New System.Drawing.Point(360, 41)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.Size = New System.Drawing.Size(7, 22)
        Me.LabelX16.TabIndex = 44
        Me.LabelX16.Text = "<b>*</b><font color=""#ED1C24""></font>"
        '
        'LabelX15
        '
        Me.LabelX15.AutoSize = True
        '
        '
        '
        Me.LabelX15.BackgroundStyle.Class = ""
        Me.LabelX15.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX15.ForeColor = System.Drawing.Color.Red
        Me.LabelX15.Location = New System.Drawing.Point(215, 11)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(7, 22)
        Me.LabelX15.TabIndex = 43
        Me.LabelX15.Text = "<b>*</b><font color=""#ED1C24""></font>"
        '
        'txtFeesRemitted
        '
        '
        '
        '
        Me.txtFeesRemitted.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtFeesRemitted.ButtonClear.Visible = True
        Me.txtFeesRemitted.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtFeesRemitted.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFeesRemitted.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        Me.txtFeesRemitted.Location = New System.Drawing.Point(468, 68)
        Me.txtFeesRemitted.Name = "txtFeesRemitted"
        Me.txtFeesRemitted.Size = New System.Drawing.Size(118, 27)
        Me.txtFeesRemitted.TabIndex = 8
        Me.txtFeesRemitted.Tag = "8"
        Me.txtFeesRemitted.WatermarkText = "Fees Remitted"
        '
        'cmbDespatchMode
        '
        Me.cmbDespatchMode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDespatchMode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbDespatchMode.DisplayMember = "Text"
        Me.cmbDespatchMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDespatchMode.FocusHighlightEnabled = True
        Me.cmbDespatchMode.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDespatchMode.FormattingEnabled = True
        Me.cmbDespatchMode.ItemHeight = 21
        Me.cmbDespatchMode.Location = New System.Drawing.Point(870, 68)
        Me.cmbDespatchMode.MaxLength = 255
        Me.cmbDespatchMode.Name = "cmbDespatchMode"
        Me.cmbDespatchMode.Size = New System.Drawing.Size(276, 27)
        Me.cmbDespatchMode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbDespatchMode.TabIndex = 13
        Me.cmbDespatchMode.Tag = "13"
        Me.cmbDespatchMode.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.cmbDespatchMode.WatermarkText = "Despatch Mode"
        '
        'cmbStatus
        '
        Me.cmbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbStatus.DisplayMember = "Text"
        Me.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbStatus.FocusHighlightEnabled = True
        Me.cmbStatus.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.ItemHeight = 21
        Me.cmbStatus.Location = New System.Drawing.Point(870, 6)
        Me.cmbStatus.MaxLength = 255
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(276, 27)
        Me.cmbStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbStatus.TabIndex = 11
        Me.cmbStatus.Tag = "11"
        Me.cmbStatus.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.cmbStatus.WatermarkText = "Status"
        '
        'cmbDCPS
        '
        Me.cmbDCPS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDCPS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDCPS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDCPS.FocusHighlightEnabled = True
        Me.cmbDCPS.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDCPS.FormattingEnabled = True
        Me.cmbDCPS.ItemHeight = 21
        Me.cmbDCPS.Location = New System.Drawing.Point(468, 6)
        Me.cmbDCPS.MaxLength = 255
        Me.cmbDCPS.Name = "cmbDCPS"
        Me.cmbDCPS.Size = New System.Drawing.Size(276, 27)
        Me.cmbDCPS.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbDCPS.TabIndex = 6
        Me.cmbDCPS.Tag = "6"
        Me.cmbDCPS.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.cmbDCPS.WatermarkText = "Police Station"
        '
        'cmbDCExpertName
        '
        Me.cmbDCExpertName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDCExpertName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbDCExpertName.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.ExpertsListBindingSource, "ExpertName", True))
        Me.cmbDCExpertName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDCExpertName.FocusHighlightEnabled = True
        Me.cmbDCExpertName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDCExpertName.FormattingEnabled = True
        Me.cmbDCExpertName.ItemHeight = 21
        Me.cmbDCExpertName.Location = New System.Drawing.Point(91, 36)
        Me.cmbDCExpertName.MaxLength = 255
        Me.cmbDCExpertName.Name = "cmbDCExpertName"
        Me.cmbDCExpertName.Size = New System.Drawing.Size(263, 27)
        Me.cmbDCExpertName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbDCExpertName.TabIndex = 2
        Me.cmbDCExpertName.Tag = "2"
        Me.cmbDCExpertName.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.cmbDCExpertName.WatermarkText = "Name of Expert"
        '
        'ExpertsListBindingSource
        '
        Me.ExpertsListBindingSource.DataMember = "ExpertsList"
        Me.ExpertsListBindingSource.DataSource = Me.DocumentCaseDataSet
        '
        'cmbDCExpertSection
        '
        Me.cmbDCExpertSection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDCExpertSection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbDCExpertSection.DisplayMember = "Text"
        Me.cmbDCExpertSection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDCExpertSection.FocusHighlightEnabled = True
        Me.cmbDCExpertSection.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDCExpertSection.FormattingEnabled = True
        Me.cmbDCExpertSection.ItemHeight = 21
        Me.cmbDCExpertSection.Location = New System.Drawing.Point(91, 6)
        Me.cmbDCExpertSection.MaxLength = 2
        Me.cmbDCExpertSection.Name = "cmbDCExpertSection"
        Me.cmbDCExpertSection.Size = New System.Drawing.Size(118, 27)
        Me.cmbDCExpertSection.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbDCExpertSection.TabIndex = 1
        Me.cmbDCExpertSection.Tag = "1"
        Me.cmbDCExpertSection.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.cmbDCExpertSection.WatermarkText = "Expert Section"
        '
        'btnSaveDocuments
        '
        Me.btnSaveDocuments.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSaveDocuments.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSaveDocuments.Image = CType(resources.GetObject("btnSaveDocuments.Image"), System.Drawing.Image)
        Me.btnSaveDocuments.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnSaveDocuments.Location = New System.Drawing.Point(1211, 47)
        Me.btnSaveDocuments.Name = "btnSaveDocuments"
        Me.btnSaveDocuments.Size = New System.Drawing.Size(110, 74)
        Me.btnSaveDocuments.TabIndex = 15
        Me.btnSaveDocuments.Text = "Save"
        '
        'txtDespatchAdress
        '
        '
        '
        '
        Me.txtDespatchAdress.Border.Class = "TextBoxBorder"
        Me.txtDespatchAdress.FocusHighlightEnabled = True
        Me.txtDespatchAdress.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDespatchAdress.Location = New System.Drawing.Point(870, 101)
        Me.txtDespatchAdress.MaxLength = 255
        Me.txtDespatchAdress.Multiline = True
        Me.txtDespatchAdress.Name = "txtDespatchAdress"
        Me.txtDespatchAdress.Size = New System.Drawing.Size(276, 60)
        Me.txtDespatchAdress.TabIndex = 14
        Me.txtDespatchAdress.Tag = "14"
        Me.txtDespatchAdress.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.txtDespatchAdress.WatermarkText = "Despatch Address"
        '
        'dtDespatch
        '
        '
        '
        '
        Me.dtDespatch.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtDespatch.ButtonClear.Visible = True
        Me.dtDespatch.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtDespatch.ButtonDropDown.Visible = True
        Me.dtDespatch.CustomFormat = "dd/MM/yyyy"
        Me.dtDespatch.FocusHighlightEnabled = True
        Me.dtDespatch.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDespatch.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.dtDespatch.Location = New System.Drawing.Point(870, 36)
        '
        '
        '
        Me.dtDespatch.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtDespatch.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtDespatch.MonthCalendar.BackgroundStyle.Class = ""
        Me.dtDespatch.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtDespatch.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtDespatch.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtDespatch.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtDespatch.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtDespatch.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtDespatch.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtDespatch.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.dtDespatch.MonthCalendar.DisplayMonth = New Date(2012, 8, 1, 0, 0, 0, 0)
        Me.dtDespatch.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.dtDespatch.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtDespatch.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtDespatch.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtDespatch.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtDespatch.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtDespatch.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.dtDespatch.MonthCalendar.TodayButtonVisible = True
        Me.dtDespatch.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtDespatch.Name = "dtDespatch"
        Me.dtDespatch.Size = New System.Drawing.Size(118, 27)
        Me.dtDespatch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtDespatch.TabIndex = 12
        Me.dtDespatch.Tag = "12"
        Me.dtDespatch.WatermarkText = "Despatch Date"
        '
        'dtDocumentCase
        '
        '
        '
        '
        Me.dtDocumentCase.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtDocumentCase.ButtonClear.Visible = True
        Me.dtDocumentCase.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtDocumentCase.ButtonDropDown.Visible = True
        Me.dtDocumentCase.CustomFormat = "dd/MM/yyyy"
        Me.dtDocumentCase.FocusHighlightEnabled = True
        Me.dtDocumentCase.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDocumentCase.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.dtDocumentCase.Location = New System.Drawing.Point(91, 68)
        '
        '
        '
        Me.dtDocumentCase.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtDocumentCase.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtDocumentCase.MonthCalendar.BackgroundStyle.Class = ""
        Me.dtDocumentCase.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtDocumentCase.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtDocumentCase.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtDocumentCase.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtDocumentCase.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtDocumentCase.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtDocumentCase.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtDocumentCase.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.dtDocumentCase.MonthCalendar.DisplayMonth = New Date(2012, 8, 1, 0, 0, 0, 0)
        Me.dtDocumentCase.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.dtDocumentCase.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtDocumentCase.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtDocumentCase.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtDocumentCase.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtDocumentCase.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtDocumentCase.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.dtDocumentCase.MonthCalendar.TodayButtonVisible = True
        Me.dtDocumentCase.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtDocumentCase.Name = "dtDocumentCase"
        Me.dtDocumentCase.Size = New System.Drawing.Size(118, 27)
        Me.dtDocumentCase.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtDocumentCase.TabIndex = 3
        Me.dtDocumentCase.Tag = "3"
        Me.dtDocumentCase.WatermarkText = "Date"
        '
        'dtToPB
        '
        '
        '
        '
        Me.dtToPB.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtToPB.ButtonClear.Visible = True
        Me.dtToPB.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtToPB.ButtonDropDown.Visible = True
        Me.dtToPB.CustomFormat = "dd/MM/yyyy"
        Me.dtToPB.FocusHighlightEnabled = True
        Me.dtToPB.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtToPB.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.dtToPB.Location = New System.Drawing.Point(468, 101)
        '
        '
        '
        Me.dtToPB.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtToPB.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtToPB.MonthCalendar.BackgroundStyle.Class = ""
        Me.dtToPB.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtToPB.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtToPB.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtToPB.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtToPB.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtToPB.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtToPB.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtToPB.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.dtToPB.MonthCalendar.DisplayMonth = New Date(2012, 8, 1, 0, 0, 0, 0)
        Me.dtToPB.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.dtToPB.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtToPB.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtToPB.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtToPB.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtToPB.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtToPB.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.dtToPB.MonthCalendar.TodayButtonVisible = True
        Me.dtToPB.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtToPB.Name = "dtToPB"
        Me.dtToPB.Size = New System.Drawing.Size(118, 27)
        Me.dtToPB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtToPB.TabIndex = 9
        Me.dtToPB.Tag = "9"
        Me.dtToPB.WatermarkText = "Date To PB"
        '
        'dtFromPB
        '
        '
        '
        '
        Me.dtFromPB.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtFromPB.ButtonClear.Visible = True
        Me.dtFromPB.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtFromPB.ButtonDropDown.Visible = True
        Me.dtFromPB.CustomFormat = "dd/MM/yyyy"
        Me.dtFromPB.FocusHighlightEnabled = True
        Me.dtFromPB.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFromPB.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.dtFromPB.Location = New System.Drawing.Point(468, 132)
        '
        '
        '
        Me.dtFromPB.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtFromPB.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtFromPB.MonthCalendar.BackgroundStyle.Class = ""
        Me.dtFromPB.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtFromPB.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtFromPB.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtFromPB.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtFromPB.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtFromPB.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtFromPB.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtFromPB.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.dtFromPB.MonthCalendar.DisplayMonth = New Date(2012, 8, 1, 0, 0, 0, 0)
        Me.dtFromPB.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.dtFromPB.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtFromPB.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtFromPB.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtFromPB.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtFromPB.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtFromPB.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.dtFromPB.MonthCalendar.TodayButtonVisible = True
        Me.dtFromPB.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtFromPB.Name = "dtFromPB"
        Me.dtFromPB.Size = New System.Drawing.Size(118, 27)
        Me.dtFromPB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtFromPB.TabIndex = 10
        Me.dtFromPB.Tag = "10"
        Me.dtFromPB.WatermarkText = "Date From PB"
        '
        'txtDCCrNo
        '
        '
        '
        '
        Me.txtDCCrNo.Border.Class = "TextBoxBorder"
        Me.txtDCCrNo.ButtonCustom.Image = CType(resources.GetObject("txtDCCrNo.ButtonCustom.Image"), System.Drawing.Image)
        Me.txtDCCrNo.FocusHighlightEnabled = True
        Me.txtDCCrNo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDCCrNo.Location = New System.Drawing.Point(468, 36)
        Me.txtDCCrNo.MaxLength = 255
        Me.txtDCCrNo.Name = "txtDCCrNo"
        Me.txtDCCrNo.Size = New System.Drawing.Size(276, 27)
        Me.txtDCCrNo.TabIndex = 7
        Me.txtDCCrNo.Tag = "7"
        Me.txtDCCrNo.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.txtDCCrNo.WatermarkText = "Crime Number/OS"
        '
        'txtDCCourt
        '
        Me.txtDCCourt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtDCCourt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.txtDCCourt.Border.Class = "TextBoxBorder"
        Me.txtDCCourt.ButtonCustom.Image = CType(resources.GetObject("txtDCCourt.ButtonCustom.Image"), System.Drawing.Image)
        Me.txtDCCourt.FocusHighlightEnabled = True
        Me.txtDCCourt.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDCCourt.Location = New System.Drawing.Point(91, 133)
        Me.txtDCCourt.MaxLength = 255
        Me.txtDCCourt.Name = "txtDCCourt"
        Me.txtDCCourt.Size = New System.Drawing.Size(263, 27)
        Me.txtDCCourt.TabIndex = 5
        Me.txtDCCourt.Tag = "5"
        Me.txtDCCourt.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.txtDCCourt.WatermarkText = "Name of Court"
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.Location = New System.Drawing.Point(3, 104)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(45, 18)
        Me.LabelX2.TabIndex = 17
        Me.LabelX2.Text = "File No."
        '
        'LabelX14
        '
        Me.LabelX14.AutoSize = True
        '
        '
        '
        Me.LabelX14.BackgroundStyle.Class = ""
        Me.LabelX14.Location = New System.Drawing.Point(382, 72)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(82, 18)
        Me.LabelX14.TabIndex = 42
        Me.LabelX14.Text = "Fees Remitted"
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.Location = New System.Drawing.Point(3, 72)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(29, 18)
        Me.LabelX1.TabIndex = 16
        Me.LabelX1.Text = "Date"
        '
        'LabelX13
        '
        Me.LabelX13.AutoSize = True
        '
        '
        '
        Me.LabelX13.BackgroundStyle.Class = ""
        Me.LabelX13.Location = New System.Drawing.Point(768, 104)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(103, 18)
        Me.LabelX13.TabIndex = 40
        Me.LabelX13.Text = "Despatch Address"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.Location = New System.Drawing.Point(3, 137)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(34, 18)
        Me.LabelX3.TabIndex = 19
        Me.LabelX3.Text = "Court"
        '
        'LabelX12
        '
        Me.LabelX12.AutoSize = True
        '
        '
        '
        Me.LabelX12.BackgroundStyle.Class = ""
        Me.LabelX12.Location = New System.Drawing.Point(768, 36)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(84, 18)
        Me.LabelX12.TabIndex = 38
        Me.LabelX12.Text = "Despatch Date"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.Location = New System.Drawing.Point(382, 6)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(80, 18)
        Me.LabelX4.TabIndex = 21
        Me.LabelX4.Text = "Police Station"
        '
        'LabelX11
        '
        Me.LabelX11.AutoSize = True
        '
        '
        '
        Me.LabelX11.BackgroundStyle.Class = ""
        Me.LabelX11.Location = New System.Drawing.Point(768, 72)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(91, 18)
        Me.LabelX11.TabIndex = 35
        Me.LabelX11.Text = "Despatch Mode"
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.Location = New System.Drawing.Point(382, 36)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(59, 18)
        Me.LabelX5.TabIndex = 24
        Me.LabelX5.Text = "Cr.No./OS"
        '
        'LabelX10
        '
        Me.LabelX10.AutoSize = True
        '
        '
        '
        Me.LabelX10.BackgroundStyle.Class = ""
        Me.LabelX10.Location = New System.Drawing.Point(768, 6)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(38, 18)
        Me.LabelX10.TabIndex = 33
        Me.LabelX10.Text = "Status"
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.Location = New System.Drawing.Point(3, 36)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(84, 18)
        Me.LabelX6.TabIndex = 25
        Me.LabelX6.Text = "Expert's Name"
        '
        'LabelX9
        '
        Me.LabelX9.AutoSize = True
        '
        '
        '
        Me.LabelX9.BackgroundStyle.Class = ""
        Me.LabelX9.Location = New System.Drawing.Point(382, 137)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(80, 18)
        Me.LabelX9.TabIndex = 32
        Me.LabelX9.Text = "Date From PB"
        '
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        '
        '
        '
        Me.LabelX7.BackgroundStyle.Class = ""
        Me.LabelX7.Location = New System.Drawing.Point(3, 6)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(44, 18)
        Me.LabelX7.TabIndex = 27
        Me.LabelX7.Text = "Section"
        '
        'LabelX8
        '
        Me.LabelX8.AutoSize = True
        '
        '
        '
        Me.LabelX8.BackgroundStyle.Class = ""
        Me.LabelX8.Location = New System.Drawing.Point(382, 104)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(65, 18)
        Me.LabelX8.TabIndex = 29
        Me.LabelX8.Text = "Date To PB"
        '
        'tabDocumentCase
        '
        Me.tabDocumentCase.AttachedControl = Me.TabControlPanel1
        Me.tabDocumentCase.Name = "tabDocumentCase"
        Me.tabDocumentCase.Text = "Document Case"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.TabControlPanel2.Controls.Add(Me.CourtDataGridView)
        Me.TabControlPanel2.Controls.Add(Me.PanelCourt)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 25)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(1370, 359)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 2
        Me.TabControlPanel2.TabItem = Me.tabCourtDuty
        '
        'CourtDataGridView
        '
        Me.CourtDataGridView.AllowUserToAddRows = False
        Me.CourtDataGridView.AllowUserToDeleteRows = False
        Me.CourtDataGridView.AllowUserToOrderColumns = True
        Me.CourtDataGridView.AutoGenerateColumns = False
        Me.CourtDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CourtDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.CourtDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CourtDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ExpertDataGridViewTextBoxColumn, Me.CourtDataGridViewTextBoxColumn1, Me.DateOfHearingDataGridViewTextBoxColumn, Me.TypeOfCaseDataGridViewTextBoxColumn, Me.CCNoDataGridViewTextBoxColumn, Me.CrNoDataGridViewTextBoxColumn1, Me.PSDataGridViewTextBoxColumn1, Me.AbsentFeeDataGridViewTextBoxColumn, Me.TADADataGridViewTextBoxColumn, Me.ExaminedOrNotDataGridViewCheckBoxColumn, Me.PostponedDateDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn})
        Me.CourtDataGridView.DataSource = Me.CourtDutyBindingSource
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CourtDataGridView.DefaultCellStyle = DataGridViewCellStyle11
        Me.CourtDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CourtDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.CourtDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.CourtDataGridView.Location = New System.Drawing.Point(1, 169)
        Me.CourtDataGridView.MultiSelect = False
        Me.CourtDataGridView.Name = "CourtDataGridView"
        Me.CourtDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CourtDataGridView.RowTemplate.Height = 30
        Me.CourtDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CourtDataGridView.Size = New System.Drawing.Size(1368, 189)
        Me.CourtDataGridView.TabIndex = 1
        Me.CourtDataGridView.TabStop = False
        Me.CourtDataGridView.VirtualMode = True
        '
        'ExpertDataGridViewTextBoxColumn
        '
        Me.ExpertDataGridViewTextBoxColumn.DataPropertyName = "Expert"
        Me.ExpertDataGridViewTextBoxColumn.HeaderText = "Name of Expert"
        Me.ExpertDataGridViewTextBoxColumn.Name = "ExpertDataGridViewTextBoxColumn"
        Me.ExpertDataGridViewTextBoxColumn.Width = 170
        '
        'CourtDataGridViewTextBoxColumn1
        '
        Me.CourtDataGridViewTextBoxColumn1.DataPropertyName = "Court"
        Me.CourtDataGridViewTextBoxColumn1.HeaderText = "Name of Court"
        Me.CourtDataGridViewTextBoxColumn1.Name = "CourtDataGridViewTextBoxColumn1"
        Me.CourtDataGridViewTextBoxColumn1.Width = 170
        '
        'DateOfHearingDataGridViewTextBoxColumn
        '
        Me.DateOfHearingDataGridViewTextBoxColumn.DataPropertyName = "DateOfHearing"
        DataGridViewCellStyle9.Format = "dd/MM/yyyy"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.DateOfHearingDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.DateOfHearingDataGridViewTextBoxColumn.HeaderText = "Date of Hearing"
        Me.DateOfHearingDataGridViewTextBoxColumn.Name = "DateOfHearingDataGridViewTextBoxColumn"
        '
        'TypeOfCaseDataGridViewTextBoxColumn
        '
        Me.TypeOfCaseDataGridViewTextBoxColumn.DataPropertyName = "TypeOfCase"
        Me.TypeOfCaseDataGridViewTextBoxColumn.HeaderText = "Civil/Criminal"
        Me.TypeOfCaseDataGridViewTextBoxColumn.Name = "TypeOfCaseDataGridViewTextBoxColumn"
        '
        'CCNoDataGridViewTextBoxColumn
        '
        Me.CCNoDataGridViewTextBoxColumn.DataPropertyName = "CCNo"
        Me.CCNoDataGridViewTextBoxColumn.HeaderText = "CCNo./OSNo."
        Me.CCNoDataGridViewTextBoxColumn.Name = "CCNoDataGridViewTextBoxColumn"
        '
        'CrNoDataGridViewTextBoxColumn1
        '
        Me.CrNoDataGridViewTextBoxColumn1.DataPropertyName = "CrNo"
        Me.CrNoDataGridViewTextBoxColumn1.HeaderText = "Cr.No."
        Me.CrNoDataGridViewTextBoxColumn1.Name = "CrNoDataGridViewTextBoxColumn1"
        '
        'PSDataGridViewTextBoxColumn1
        '
        Me.PSDataGridViewTextBoxColumn1.DataPropertyName = "PS"
        Me.PSDataGridViewTextBoxColumn1.HeaderText = "Police Station"
        Me.PSDataGridViewTextBoxColumn1.Name = "PSDataGridViewTextBoxColumn1"
        Me.PSDataGridViewTextBoxColumn1.Width = 150
        '
        'AbsentFeeDataGridViewTextBoxColumn
        '
        Me.AbsentFeeDataGridViewTextBoxColumn.DataPropertyName = "AbsentFee"
        Me.AbsentFeeDataGridViewTextBoxColumn.HeaderText = "Absent Fee"
        Me.AbsentFeeDataGridViewTextBoxColumn.Name = "AbsentFeeDataGridViewTextBoxColumn"
        '
        'TADADataGridViewTextBoxColumn
        '
        Me.TADADataGridViewTextBoxColumn.DataPropertyName = "TADA"
        Me.TADADataGridViewTextBoxColumn.HeaderText = "TA DA Received"
        Me.TADADataGridViewTextBoxColumn.Name = "TADADataGridViewTextBoxColumn"
        '
        'ExaminedOrNotDataGridViewCheckBoxColumn
        '
        Me.ExaminedOrNotDataGridViewCheckBoxColumn.DataPropertyName = "ExaminedOrNot"
        Me.ExaminedOrNotDataGridViewCheckBoxColumn.HeaderText = "Examined or Not"
        Me.ExaminedOrNotDataGridViewCheckBoxColumn.Name = "ExaminedOrNotDataGridViewCheckBoxColumn"
        Me.ExaminedOrNotDataGridViewCheckBoxColumn.Width = 90
        '
        'PostponedDateDataGridViewTextBoxColumn
        '
        Me.PostponedDateDataGridViewTextBoxColumn.DataPropertyName = "PostponedDate"
        DataGridViewCellStyle10.Format = "dd/MM/yyyy"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.PostponedDateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.PostponedDateDataGridViewTextBoxColumn.HeaderText = "Postpone Date"
        Me.PostponedDateDataGridViewTextBoxColumn.Name = "PostponedDateDataGridViewTextBoxColumn"
        Me.PostponedDateDataGridViewTextBoxColumn.Width = 90
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'CourtDutyBindingSource
        '
        Me.CourtDutyBindingSource.DataMember = "CourtDuty"
        Me.CourtDutyBindingSource.DataSource = Me.DocumentCaseDataSet
        '
        'PanelCourt
        '
        Me.PanelCourt.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelCourt.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelCourt.Controls.Add(Me.LabelX32)
        Me.PanelCourt.Controls.Add(Me.LabelX31)
        Me.PanelCourt.Controls.Add(Me.LabelX30)
        Me.PanelCourt.Controls.Add(Me.cmbCDExpertName)
        Me.PanelCourt.Controls.Add(Me.btnSaveCourt)
        Me.PanelCourt.Controls.Add(Me.LabelX29)
        Me.PanelCourt.Controls.Add(Me.dtPostponed)
        Me.PanelCourt.Controls.Add(Me.cmbExamined)
        Me.PanelCourt.Controls.Add(Me.txtTADA)
        Me.PanelCourt.Controls.Add(Me.txtAbsentFees)
        Me.PanelCourt.Controls.Add(Me.cmbCDPS)
        Me.PanelCourt.Controls.Add(Me.LabelX25)
        Me.PanelCourt.Controls.Add(Me.txtCDCrNo)
        Me.PanelCourt.Controls.Add(Me.txtCDCCNo)
        Me.PanelCourt.Controls.Add(Me.cmbCivilCriminal)
        Me.PanelCourt.Controls.Add(Me.dtHearing)
        Me.PanelCourt.Controls.Add(Me.LabelX28)
        Me.PanelCourt.Controls.Add(Me.LabelX27)
        Me.PanelCourt.Controls.Add(Me.LabelX26)
        Me.PanelCourt.Controls.Add(Me.LabelX24)
        Me.PanelCourt.Controls.Add(Me.LabelX23)
        Me.PanelCourt.Controls.Add(Me.LabelX22)
        Me.PanelCourt.Controls.Add(Me.LabelX21)
        Me.PanelCourt.Controls.Add(Me.LabelX19)
        Me.PanelCourt.Controls.Add(Me.LabelX20)
        Me.PanelCourt.Controls.Add(Me.txtCDCourt)
        Me.PanelCourt.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCourt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelCourt.Location = New System.Drawing.Point(1, 1)
        Me.PanelCourt.Name = "PanelCourt"
        Me.PanelCourt.Size = New System.Drawing.Size(1368, 168)
        Me.PanelCourt.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelCourt.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelCourt.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelCourt.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelCourt.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelCourt.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelCourt.Style.GradientAngle = 90
        Me.PanelCourt.TabIndex = 0
        '
        'LabelX32
        '
        Me.LabelX32.AutoSize = True
        '
        '
        '
        Me.LabelX32.BackgroundStyle.Class = ""
        Me.LabelX32.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX32.ForeColor = System.Drawing.Color.Red
        Me.LabelX32.Location = New System.Drawing.Point(217, 72)
        Me.LabelX32.Name = "LabelX32"
        Me.LabelX32.Size = New System.Drawing.Size(7, 22)
        Me.LabelX32.TabIndex = 49
        Me.LabelX32.Text = "<b>*</b><font color=""#ED1C24""></font>"
        '
        'LabelX31
        '
        Me.LabelX31.AutoSize = True
        '
        '
        '
        Me.LabelX31.BackgroundStyle.Class = ""
        Me.LabelX31.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX31.ForeColor = System.Drawing.Color.Red
        Me.LabelX31.Location = New System.Drawing.Point(362, 41)
        Me.LabelX31.Name = "LabelX31"
        Me.LabelX31.Size = New System.Drawing.Size(7, 22)
        Me.LabelX31.TabIndex = 48
        Me.LabelX31.Text = "<b>*</b><font color=""#ED1C24""></font>"
        '
        'LabelX30
        '
        Me.LabelX30.AutoSize = True
        '
        '
        '
        Me.LabelX30.BackgroundStyle.Class = ""
        Me.LabelX30.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX30.ForeColor = System.Drawing.Color.Red
        Me.LabelX30.Location = New System.Drawing.Point(362, 10)
        Me.LabelX30.Name = "LabelX30"
        Me.LabelX30.Size = New System.Drawing.Size(7, 22)
        Me.LabelX30.TabIndex = 47
        Me.LabelX30.Text = "<b>*</b><font color=""#ED1C24""></font>"
        '
        'cmbCDExpertName
        '
        Me.cmbCDExpertName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCDExpertName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCDExpertName.DisplayMember = "Text"
        Me.cmbCDExpertName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCDExpertName.FocusHighlightEnabled = True
        Me.cmbCDExpertName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCDExpertName.FormattingEnabled = True
        Me.cmbCDExpertName.ItemHeight = 21
        Me.cmbCDExpertName.Location = New System.Drawing.Point(93, 6)
        Me.cmbCDExpertName.Name = "cmbCDExpertName"
        Me.cmbCDExpertName.Size = New System.Drawing.Size(263, 27)
        Me.cmbCDExpertName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbCDExpertName.TabIndex = 1
        Me.cmbCDExpertName.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.cmbCDExpertName.WatermarkText = "Name of Expert"
        '
        'btnSaveCourt
        '
        Me.btnSaveCourt.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSaveCourt.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSaveCourt.Image = CType(resources.GetObject("btnSaveCourt.Image"), System.Drawing.Image)
        Me.btnSaveCourt.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnSaveCourt.Location = New System.Drawing.Point(877, 48)
        Me.btnSaveCourt.Name = "btnSaveCourt"
        Me.btnSaveCourt.Size = New System.Drawing.Size(110, 74)
        Me.btnSaveCourt.TabIndex = 12
        Me.btnSaveCourt.Text = "Save"
        '
        'LabelX29
        '
        Me.LabelX29.AutoSize = True
        '
        '
        '
        Me.LabelX29.BackgroundStyle.Class = ""
        Me.LabelX29.Location = New System.Drawing.Point(402, 137)
        Me.LabelX29.Name = "LabelX29"
        Me.LabelX29.Size = New System.Drawing.Size(93, 18)
        Me.LabelX29.TabIndex = 46
        Me.LabelX29.Text = "Date Postponed"
        '
        'dtPostponed
        '
        '
        '
        '
        Me.dtPostponed.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtPostponed.ButtonClear.Visible = True
        Me.dtPostponed.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtPostponed.ButtonDropDown.Visible = True
        Me.dtPostponed.CustomFormat = "dd/MM/yyyy"
        Me.dtPostponed.FocusHighlightEnabled = True
        Me.dtPostponed.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPostponed.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.dtPostponed.Location = New System.Drawing.Point(503, 133)
        '
        '
        '
        Me.dtPostponed.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtPostponed.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtPostponed.MonthCalendar.BackgroundStyle.Class = ""
        Me.dtPostponed.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtPostponed.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtPostponed.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtPostponed.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtPostponed.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtPostponed.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtPostponed.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtPostponed.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.dtPostponed.MonthCalendar.DisplayMonth = New Date(2012, 8, 1, 0, 0, 0, 0)
        Me.dtPostponed.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.dtPostponed.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtPostponed.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtPostponed.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtPostponed.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtPostponed.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtPostponed.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.dtPostponed.MonthCalendar.TodayButtonVisible = True
        Me.dtPostponed.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtPostponed.Name = "dtPostponed"
        Me.dtPostponed.Size = New System.Drawing.Size(118, 27)
        Me.dtPostponed.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtPostponed.TabIndex = 11
        Me.dtPostponed.Tag = "3"
        Me.dtPostponed.WatermarkText = "Postponed To"
        '
        'cmbExamined
        '
        Me.cmbExamined.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbExamined.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbExamined.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.ExpertsListBindingSource, "ExpertName", True))
        Me.cmbExamined.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbExamined.FocusHighlightEnabled = True
        Me.cmbExamined.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbExamined.FormattingEnabled = True
        Me.cmbExamined.ItemHeight = 21
        Me.cmbExamined.Location = New System.Drawing.Point(503, 101)
        Me.cmbExamined.MaxLength = 255
        Me.cmbExamined.Name = "cmbExamined"
        Me.cmbExamined.Size = New System.Drawing.Size(118, 27)
        Me.cmbExamined.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbExamined.TabIndex = 10
        Me.cmbExamined.Tag = "2"
        Me.cmbExamined.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.cmbExamined.WatermarkText = "Yes/No"
        '
        'txtTADA
        '
        '
        '
        '
        Me.txtTADA.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtTADA.ButtonClear.Visible = True
        Me.txtTADA.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtTADA.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTADA.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        Me.txtTADA.Location = New System.Drawing.Point(672, 69)
        Me.txtTADA.Name = "txtTADA"
        Me.txtTADA.Size = New System.Drawing.Size(118, 27)
        Me.txtTADA.TabIndex = 9
        Me.txtTADA.Tag = "8"
        Me.txtTADA.WatermarkText = "TA/DA"
        '
        'txtAbsentFees
        '
        '
        '
        '
        Me.txtAbsentFees.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtAbsentFees.ButtonClear.Visible = True
        Me.txtAbsentFees.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtAbsentFees.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbsentFees.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        Me.txtAbsentFees.Location = New System.Drawing.Point(503, 68)
        Me.txtAbsentFees.Name = "txtAbsentFees"
        Me.txtAbsentFees.Size = New System.Drawing.Size(118, 27)
        Me.txtAbsentFees.TabIndex = 8
        Me.txtAbsentFees.Tag = "8"
        Me.txtAbsentFees.WatermarkText = "Absent Fees"
        '
        'cmbCDPS
        '
        Me.cmbCDPS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCDPS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCDPS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCDPS.FocusHighlightEnabled = True
        Me.cmbCDPS.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCDPS.FormattingEnabled = True
        Me.cmbCDPS.ItemHeight = 21
        Me.cmbCDPS.Location = New System.Drawing.Point(503, 36)
        Me.cmbCDPS.MaxLength = 255
        Me.cmbCDPS.Name = "cmbCDPS"
        Me.cmbCDPS.Size = New System.Drawing.Size(287, 27)
        Me.cmbCDPS.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbCDPS.TabIndex = 7
        Me.cmbCDPS.Tag = "6"
        Me.cmbCDPS.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.cmbCDPS.WatermarkText = "Police Station"
        '
        'LabelX25
        '
        Me.LabelX25.AutoSize = True
        '
        '
        '
        Me.LabelX25.BackgroundStyle.Class = ""
        Me.LabelX25.Location = New System.Drawing.Point(402, 40)
        Me.LabelX25.Name = "LabelX25"
        Me.LabelX25.Size = New System.Drawing.Size(80, 18)
        Me.LabelX25.TabIndex = 41
        Me.LabelX25.Text = "Police Station"
        '
        'txtCDCrNo
        '
        '
        '
        '
        Me.txtCDCrNo.Border.Class = "TextBoxBorder"
        Me.txtCDCrNo.ButtonCustom.Image = CType(resources.GetObject("txtCDCrNo.ButtonCustom.Image"), System.Drawing.Image)
        Me.txtCDCrNo.FocusHighlightEnabled = True
        Me.txtCDCrNo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCDCrNo.Location = New System.Drawing.Point(503, 6)
        Me.txtCDCrNo.MaxLength = 255
        Me.txtCDCrNo.Name = "txtCDCrNo"
        Me.txtCDCrNo.Size = New System.Drawing.Size(287, 27)
        Me.txtCDCrNo.TabIndex = 6
        Me.txtCDCrNo.Tag = "7"
        Me.txtCDCrNo.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.txtCDCrNo.WatermarkText = "Crime Number"
        '
        'txtCDCCNo
        '
        '
        '
        '
        Me.txtCDCCNo.Border.Class = "TextBoxBorder"
        Me.txtCDCCNo.ButtonCustom.Image = CType(resources.GetObject("txtCDCCNo.ButtonCustom.Image"), System.Drawing.Image)
        Me.txtCDCCNo.FocusHighlightEnabled = True
        Me.txtCDCCNo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCDCCNo.Location = New System.Drawing.Point(93, 133)
        Me.txtCDCCNo.MaxLength = 255
        Me.txtCDCCNo.Name = "txtCDCCNo"
        Me.txtCDCCNo.Size = New System.Drawing.Size(263, 27)
        Me.txtCDCCNo.TabIndex = 5
        Me.txtCDCCNo.Tag = "7"
        Me.txtCDCCNo.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.txtCDCCNo.WatermarkText = "CC.No./OS.No."
        '
        'cmbCivilCriminal
        '
        Me.cmbCivilCriminal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCivilCriminal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbCivilCriminal.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.ExpertsListBindingSource, "ExpertName", True))
        Me.cmbCivilCriminal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCivilCriminal.FocusHighlightEnabled = True
        Me.cmbCivilCriminal.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCivilCriminal.FormattingEnabled = True
        Me.cmbCivilCriminal.ItemHeight = 21
        Me.cmbCivilCriminal.Location = New System.Drawing.Point(93, 101)
        Me.cmbCivilCriminal.MaxLength = 255
        Me.cmbCivilCriminal.Name = "cmbCivilCriminal"
        Me.cmbCivilCriminal.Size = New System.Drawing.Size(263, 27)
        Me.cmbCivilCriminal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbCivilCriminal.TabIndex = 4
        Me.cmbCivilCriminal.Tag = "2"
        Me.cmbCivilCriminal.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.cmbCivilCriminal.WatermarkText = "Civil/Criminal"
        '
        'dtHearing
        '
        '
        '
        '
        Me.dtHearing.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtHearing.ButtonClear.Visible = True
        Me.dtHearing.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtHearing.ButtonDropDown.Visible = True
        Me.dtHearing.CustomFormat = "dd/MM/yyyy"
        Me.dtHearing.FocusHighlightEnabled = True
        Me.dtHearing.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtHearing.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.dtHearing.Location = New System.Drawing.Point(93, 68)
        '
        '
        '
        Me.dtHearing.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtHearing.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtHearing.MonthCalendar.BackgroundStyle.Class = ""
        Me.dtHearing.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtHearing.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtHearing.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtHearing.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtHearing.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtHearing.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtHearing.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtHearing.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.dtHearing.MonthCalendar.DisplayMonth = New Date(2012, 8, 1, 0, 0, 0, 0)
        Me.dtHearing.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.dtHearing.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtHearing.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtHearing.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtHearing.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtHearing.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtHearing.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.dtHearing.MonthCalendar.TodayButtonVisible = True
        Me.dtHearing.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtHearing.Name = "dtHearing"
        Me.dtHearing.Size = New System.Drawing.Size(118, 27)
        Me.dtHearing.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtHearing.TabIndex = 3
        Me.dtHearing.Tag = "3"
        Me.dtHearing.WatermarkText = "Hearing Date"
        '
        'LabelX28
        '
        Me.LabelX28.AutoSize = True
        '
        '
        '
        Me.LabelX28.BackgroundStyle.Class = ""
        Me.LabelX28.Location = New System.Drawing.Point(402, 104)
        Me.LabelX28.Name = "LabelX28"
        Me.LabelX28.Size = New System.Drawing.Size(98, 18)
        Me.LabelX28.TabIndex = 35
        Me.LabelX28.Text = "Examined or Not"
        '
        'LabelX27
        '
        Me.LabelX27.AutoSize = True
        '
        '
        '
        Me.LabelX27.BackgroundStyle.Class = ""
        Me.LabelX27.Location = New System.Drawing.Point(627, 76)
        Me.LabelX27.Name = "LabelX27"
        Me.LabelX27.Size = New System.Drawing.Size(39, 18)
        Me.LabelX27.TabIndex = 34
        Me.LabelX27.Text = "TA DA"
        '
        'LabelX26
        '
        Me.LabelX26.AutoSize = True
        '
        '
        '
        Me.LabelX26.BackgroundStyle.Class = ""
        Me.LabelX26.Location = New System.Drawing.Point(402, 76)
        Me.LabelX26.Name = "LabelX26"
        Me.LabelX26.Size = New System.Drawing.Size(70, 18)
        Me.LabelX26.TabIndex = 33
        Me.LabelX26.Text = "Absent Fees"
        '
        'LabelX24
        '
        Me.LabelX24.AutoSize = True
        '
        '
        '
        Me.LabelX24.BackgroundStyle.Class = ""
        Me.LabelX24.Location = New System.Drawing.Point(402, 10)
        Me.LabelX24.Name = "LabelX24"
        Me.LabelX24.Size = New System.Drawing.Size(38, 18)
        Me.LabelX24.TabIndex = 31
        Me.LabelX24.Text = "Cr.No."
        '
        'LabelX23
        '
        Me.LabelX23.AutoSize = True
        '
        '
        '
        Me.LabelX23.BackgroundStyle.Class = ""
        Me.LabelX23.Location = New System.Drawing.Point(3, 137)
        Me.LabelX23.Name = "LabelX23"
        Me.LabelX23.Size = New System.Drawing.Size(79, 18)
        Me.LabelX23.TabIndex = 30
        Me.LabelX23.Text = "CCNo./OSNo."
        '
        'LabelX22
        '
        Me.LabelX22.AutoSize = True
        '
        '
        '
        Me.LabelX22.BackgroundStyle.Class = ""
        Me.LabelX22.Location = New System.Drawing.Point(3, 104)
        Me.LabelX22.Name = "LabelX22"
        Me.LabelX22.Size = New System.Drawing.Size(79, 18)
        Me.LabelX22.TabIndex = 29
        Me.LabelX22.Text = "Civil/Criminal"
        '
        'LabelX21
        '
        Me.LabelX21.AutoSize = True
        '
        '
        '
        Me.LabelX21.BackgroundStyle.Class = ""
        Me.LabelX21.Location = New System.Drawing.Point(3, 72)
        Me.LabelX21.Name = "LabelX21"
        Me.LabelX21.Size = New System.Drawing.Size(93, 18)
        Me.LabelX21.TabIndex = 28
        Me.LabelX21.Text = "Date of Hearing"
        '
        'LabelX19
        '
        Me.LabelX19.AutoSize = True
        '
        '
        '
        Me.LabelX19.BackgroundStyle.Class = ""
        Me.LabelX19.Location = New System.Drawing.Point(3, 36)
        Me.LabelX19.Name = "LabelX19"
        Me.LabelX19.Size = New System.Drawing.Size(34, 18)
        Me.LabelX19.TabIndex = 26
        Me.LabelX19.Text = "Court"
        '
        'LabelX20
        '
        Me.LabelX20.AutoSize = True
        '
        '
        '
        Me.LabelX20.BackgroundStyle.Class = ""
        Me.LabelX20.Location = New System.Drawing.Point(3, 6)
        Me.LabelX20.Name = "LabelX20"
        Me.LabelX20.Size = New System.Drawing.Size(84, 18)
        Me.LabelX20.TabIndex = 27
        Me.LabelX20.Text = "Expert's Name"
        '
        'txtCDCourt
        '
        Me.txtCDCourt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCDCourt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.txtCDCourt.Border.Class = "TextBoxBorder"
        Me.txtCDCourt.ButtonCustom.Image = CType(resources.GetObject("txtCDCourt.ButtonCustom.Image"), System.Drawing.Image)
        Me.txtCDCourt.FocusHighlightEnabled = True
        Me.txtCDCourt.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCDCourt.Location = New System.Drawing.Point(93, 36)
        Me.txtCDCourt.MaxLength = 255
        Me.txtCDCourt.Name = "txtCDCourt"
        Me.txtCDCourt.Size = New System.Drawing.Size(263, 27)
        Me.txtCDCourt.TabIndex = 2
        Me.txtCDCourt.Tag = "5"
        Me.txtCDCourt.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.txtCDCourt.WatermarkText = "Name of Court"
        '
        'tabCourtDuty
        '
        Me.tabCourtDuty.AttachedControl = Me.TabControlPanel2
        Me.tabCourtDuty.Name = "tabCourtDuty"
        Me.tabCourtDuty.Text = "Court Duty"
        '
        'ExpertsListBindingSource1
        '
        Me.ExpertsListBindingSource1.DataMember = "ExpertsList"
        Me.ExpertsListBindingSource1.DataSource = Me.DocumentCaseDataSet
        '
        'TabItem1
        '
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "Experts"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DocumentCaseTableAdapter
        '
        Me.DocumentCaseTableAdapter.ClearBeforeFill = True
        '
        'PSListBindingSource
        '
        Me.PSListBindingSource.DataMember = "PSList"
        Me.PSListBindingSource.DataSource = Me.DocumentCaseDataSet
        '
        'ExpertsListTableAdapter
        '
        Me.ExpertsListTableAdapter.ClearBeforeFill = True
        '
        'PSListTableAdapter
        '
        Me.PSListTableAdapter.ClearBeforeFill = True
        '
        'StatusTableAdapter
        '
        Me.StatusTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CourtDutyTableAdapter = Nothing
        Me.TableAdapterManager.DocumentCaseTableAdapter = Me.DocumentCaseTableAdapter
        Me.TableAdapterManager.ExpertsListTableAdapter = Me.ExpertsListTableAdapter
        Me.TableAdapterManager.PSListTableAdapter = Me.PSListTableAdapter
        Me.TableAdapterManager.StatusTableAdapter = Me.StatusTableAdapter
        Me.TableAdapterManager.UpdateOrder = DocumentCase.DocumentCaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CourtDutyTableAdapter
        '
        Me.CourtDutyTableAdapter.ClearBeforeFill = True
        '
        'DocumentCaseImportAdapter
        '
        Me.DocumentCaseImportAdapter.ClearBeforeFill = True
        '
        'DocumentCaseImportDataSet
        '
        Me.DocumentCaseImportDataSet.DataSetName = "DocumentCaseDataSet"
        Me.DocumentCaseImportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TempDocumentCaseDataSet
        '
        Me.TempDocumentCaseDataSet.DataSetName = "DocumentCaseDataSet"
        Me.TempDocumentCaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TempDocumentCaseTableAdapter
        '
        Me.TempDocumentCaseTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.CourtDutyTableAdapter = Nothing
        Me.TableAdapterManager1.DocumentCaseTableAdapter = Nothing
        Me.TableAdapterManager1.ExpertsListTableAdapter = Nothing
        Me.TableAdapterManager1.PSListTableAdapter = Nothing
        Me.TableAdapterManager1.StatusTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = DocumentCase.DocumentCaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmMainInterface
        '
        Me.ClientSize = New System.Drawing.Size(1370, 461)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMainInterface"
        Me.Text = "Document Cases"
        Me.TitleText = "<b>Document Cases</b>"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        CType(Me.DocumentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentCaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentCaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDocuments.ResumeLayout(False)
        Me.PanelDocuments.PerformLayout()
        CType(Me.dtDummy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInwardNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFeesRemitted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpertsListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDespatch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDocumentCase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtToPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFromPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel2.ResumeLayout(False)
        CType(Me.CourtDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CourtDutyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCourt.ResumeLayout(False)
        Me.PanelCourt.PerformLayout()
        CType(Me.dtPostponed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTADA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbsentFees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtHearing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpertsListBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentCaseImportDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TempDocumentCaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents RibbonControl1 As DevComponents.DotNetBar.RibbonControl
    Friend WithEvents RibbonPanel1 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonBar2 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents RibbonPanel2 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonTabItem1 As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents RibbonTabItem2 As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents QatCustomizeItem1 As DevComponents.DotNetBar.QatCustomizeItem
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents StyleManager2 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents DocumentCaseDataSet As DocumentCase.DocumentCaseDataSet
    Friend WithEvents DocumentCaseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DocumentCaseTableAdapter As DocumentCase.DocumentCaseDataSetTableAdapters.DocumentCaseTableAdapter
    Friend WithEvents tabDocument As DevComponents.DotNetBar.TabItem
    Friend WithEvents ExpertsListTableAdapter As DocumentCase.DocumentCaseDataSetTableAdapters.ExpertsListTableAdapter
    Friend WithEvents PSListTableAdapter As DocumentCase.DocumentCaseDataSetTableAdapters.PSListTableAdapter
    Friend WithEvents StatusTableAdapter As DocumentCase.DocumentCaseDataSetTableAdapters.StatusTableAdapter
    Friend WithEvents PSListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ExpertsListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As DocumentCase.DocumentCaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RibbonBar1 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents btnNew As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnEdit As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnDelete As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnReload As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnSearch As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnAbout As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents DocumentDataGridView As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents PanelDocuments As DevComponents.DotNetBar.PanelEx
    Friend WithEvents txtInwardNumber As DevComponents.Editors.IntegerInput
    Friend WithEvents txtFileNumber As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtFeesRemitted As DevComponents.Editors.IntegerInput
    Friend WithEvents cmbDespatchMode As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cmbStatus As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cmbDCPS As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cmbDCExpertName As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cmbDCExpertSection As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents btnSaveDocuments As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtDespatchAdress As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dtDespatch As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dtDocumentCase As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dtToPB As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dtFromPB As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents txtDCCrNo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtDCCourt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tabDocumentCase As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents tabCourtDuty As DevComponents.DotNetBar.TabItem
    Friend WithEvents PanelCourt As DevComponents.DotNetBar.PanelEx
    Friend WithEvents CourtDutyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CourtDutyTableAdapter As DocumentCase.DocumentCaseDataSetTableAdapters.CourtDutyTableAdapter
    Friend WithEvents btnReport As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CourtDataGridView As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents LabelX28 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX27 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX26 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX24 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX23 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX22 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX21 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX20 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCDCourt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dtHearing As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dtPostponed As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents cmbExamined As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtTADA As DevComponents.Editors.IntegerInput
    Friend WithEvents txtAbsentFees As DevComponents.Editors.IntegerInput
    Friend WithEvents cmbCDPS As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX25 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCDCrNo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCDCCNo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmbCivilCriminal As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX29 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnSaveCourt As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmbCDExpertName As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX32 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX31 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX30 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnDummySave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ExpertDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourtDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOfHearingDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeOfCaseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CrNoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AbsentFeeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TADADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExaminedOrNotDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PostponedDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocumentIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExpertIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExpertNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocumentDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FileNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CrNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FeesRemittedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateToPBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateFromPBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DespatchDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DespatchModeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DespatchAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InwardNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSearchPeriod As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnExport As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnImport As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnOpenDBFolder As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnOpenDBInAccess As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DocumentCaseImportAdapter As DocumentCase.DocumentCaseDataSetTableAdapters.DocumentCaseTableAdapter
    Friend WithEvents DocumentCaseImportDataSet As DocumentCase.DocumentCaseDataSet
    Friend WithEvents TempDocumentCaseDataSet As DocumentCase.DocumentCaseDataSet
    Friend WithEvents TempDocumentCaseTableAdapter As DocumentCase.DocumentCaseDataSetTableAdapters.DocumentCaseTableAdapter
    Friend WithEvents dtDummy As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents ExpertsListBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager1 As DocumentCase.DocumentCaseDataSetTableAdapters.TableAdapterManager

End Class
