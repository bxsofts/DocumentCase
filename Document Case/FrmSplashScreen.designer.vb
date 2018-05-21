<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplashScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplashScreen))
        Me.lblApplicationTitle = New DevComponents.DotNetBar.LabelX()
        Me.lblVersion = New DevComponents.DotNetBar.LabelX()
        Me.lblCopyright = New DevComponents.DotNetBar.LabelX()
        Me.lblBaiju = New DevComponents.DotNetBar.LabelX()
        Me.lblLicence = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.ReflectionImage1 = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblApplicationTitle
        '
        Me.lblApplicationTitle.AutoSize = True
        '
        '
        '
        Me.lblApplicationTitle.BackgroundStyle.Class = ""
        Me.lblApplicationTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApplicationTitle.Location = New System.Drawing.Point(156, 88)
        Me.lblApplicationTitle.Name = "lblApplicationTitle"
        Me.lblApplicationTitle.Size = New System.Drawing.Size(178, 34)
        Me.lblApplicationTitle.TabIndex = 7
        Me.lblApplicationTitle.Text = "Document Case"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        '
        '
        '
        Me.lblVersion.BackgroundStyle.Class = ""
        Me.lblVersion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(156, 134)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(108, 20)
        Me.lblVersion.TabIndex = 8
        Me.lblVersion.Text = "Version {0}.{1:00}"
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        '
        '
        '
        Me.lblCopyright.BackgroundStyle.Class = ""
        Me.lblCopyright.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.Location = New System.Drawing.Point(156, 164)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(63, 20)
        Me.lblCopyright.TabIndex = 9
        Me.lblCopyright.Text = "Copyright"
        '
        'lblBaiju
        '
        Me.lblBaiju.AutoSize = True
        '
        '
        '
        Me.lblBaiju.BackgroundStyle.Class = ""
        Me.lblBaiju.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBaiju.Location = New System.Drawing.Point(156, 194)
        Me.lblBaiju.Name = "lblBaiju"
        Me.lblBaiju.Size = New System.Drawing.Size(33, 20)
        Me.lblBaiju.TabIndex = 10
        Me.lblBaiju.Text = "baiju"
        '
        'lblLicence
        '
        Me.lblLicence.AutoSize = True
        '
        '
        '
        Me.lblLicence.BackgroundStyle.Class = ""
        Me.lblLicence.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLicence.Location = New System.Drawing.Point(156, 227)
        Me.lblLicence.Name = "lblLicence"
        Me.lblLicence.Size = New System.Drawing.Size(47, 20)
        Me.lblLicence.TabIndex = 11
        Me.lblLicence.Text = "License"
        Me.lblLicence.WordWrap = True
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.ReflectionImage1)
        Me.PanelEx1.Controls.Add(Me.lblApplicationTitle)
        Me.PanelEx1.Controls.Add(Me.lblLicence)
        Me.PanelEx1.Controls.Add(Me.lblVersion)
        Me.PanelEx1.Controls.Add(Me.lblBaiju)
        Me.PanelEx1.Controls.Add(Me.lblCopyright)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(529, 273)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 12
        '
        'ReflectionImage1
        '
        '
        '
        '
        Me.ReflectionImage1.BackgroundStyle.Class = ""
        Me.ReflectionImage1.Image = CType(resources.GetObject("ReflectionImage1.Image"), System.Drawing.Image)
        Me.ReflectionImage1.Location = New System.Drawing.Point(12, -8)
        Me.ReflectionImage1.Name = "ReflectionImage1"
        Me.ReflectionImage1.Size = New System.Drawing.Size(133, 281)
        Me.ReflectionImage1.TabIndex = 12
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'frmSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 273)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSplashScreen"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblApplicationTitle As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblVersion As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblCopyright As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblBaiju As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblLicence As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ReflectionImage1 As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
