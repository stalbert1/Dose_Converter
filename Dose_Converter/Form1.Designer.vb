<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDoseConverter
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDoseConverter))
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.cboxUnitFrom = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radbtnRate = New System.Windows.Forms.RadioButton()
        Me.radbtnDose = New System.Windows.Forms.RadioButton()
        Me.cboxRateTo = New System.Windows.Forms.ComboBox()
        Me.chkboxScientificNotation = New System.Windows.Forms.CheckBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.cboxUnitTo = New System.Windows.Forms.ComboBox()
        Me.cboxRateFrom = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtResults = New System.Windows.Forms.TextBox()
        Me.lblScientificNotation = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtValue
        '
        Me.txtValue.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValue.Location = New System.Drawing.Point(12, 87)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(213, 22)
        Me.txtValue.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(237, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuAbout})
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'cmnuAbout
        '
        Me.cmnuAbout.Name = "cmnuAbout"
        Me.cmnuAbout.Size = New System.Drawing.Size(152, 22)
        Me.cmnuAbout.Text = "About"
        '
        'cboxUnitFrom
        '
        Me.cboxUnitFrom.FormattingEnabled = True
        Me.cboxUnitFrom.Location = New System.Drawing.Point(8, 20)
        Me.cboxUnitFrom.Name = "cboxUnitFrom"
        Me.cboxUnitFrom.Size = New System.Drawing.Size(52, 21)
        Me.cboxUnitFrom.TabIndex = 3
        Me.cboxUnitFrom.TabStop = False
        Me.cboxUnitFrom.Text = "From"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radbtnRate)
        Me.GroupBox1.Controls.Add(Me.radbtnDose)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 174)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(213, 43)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dose or Rate Selection"
        '
        'radbtnRate
        '
        Me.radbtnRate.AutoSize = True
        Me.radbtnRate.Location = New System.Drawing.Point(88, 18)
        Me.radbtnRate.Name = "radbtnRate"
        Me.radbtnRate.Size = New System.Drawing.Size(48, 17)
        Me.radbtnRate.TabIndex = 1
        Me.radbtnRate.Text = "Rate"
        Me.radbtnRate.UseVisualStyleBackColor = True
        '
        'radbtnDose
        '
        Me.radbtnDose.AutoSize = True
        Me.radbtnDose.Location = New System.Drawing.Point(6, 18)
        Me.radbtnDose.Name = "radbtnDose"
        Me.radbtnDose.Size = New System.Drawing.Size(50, 17)
        Me.radbtnDose.TabIndex = 0
        Me.radbtnDose.Text = "Dose"
        Me.radbtnDose.UseVisualStyleBackColor = True
        '
        'cboxRateTo
        '
        Me.cboxRateTo.FormattingEnabled = True
        Me.cboxRateTo.Location = New System.Drawing.Point(66, 20)
        Me.cboxRateTo.Name = "cboxRateTo"
        Me.cboxRateTo.Size = New System.Drawing.Size(83, 21)
        Me.cboxRateTo.TabIndex = 4
        Me.cboxRateTo.TabStop = False
        Me.cboxRateTo.Text = "Select Rate"
        Me.cboxRateTo.Visible = False
        '
        'chkboxScientificNotation
        '
        Me.chkboxScientificNotation.AutoSize = True
        Me.chkboxScientificNotation.Location = New System.Drawing.Point(12, 223)
        Me.chkboxScientificNotation.Name = "chkboxScientificNotation"
        Me.chkboxScientificNotation.Size = New System.Drawing.Size(15, 14)
        Me.chkboxScientificNotation.TabIndex = 5
        Me.chkboxScientificNotation.TabStop = False
        Me.chkboxScientificNotation.UseVisualStyleBackColor = True
        '
        'btnConvert
        '
        Me.btnConvert.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(12, 246)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(213, 36)
        Me.btnConvert.TabIndex = 1
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'cboxUnitTo
        '
        Me.cboxUnitTo.FormattingEnabled = True
        Me.cboxUnitTo.Location = New System.Drawing.Point(5, 20)
        Me.cboxUnitTo.Name = "cboxUnitTo"
        Me.cboxUnitTo.Size = New System.Drawing.Size(55, 21)
        Me.cboxUnitTo.TabIndex = 8
        Me.cboxUnitTo.TabStop = False
        Me.cboxUnitTo.Text = "To"
        '
        'cboxRateFrom
        '
        Me.cboxRateFrom.FormattingEnabled = True
        Me.cboxRateFrom.Location = New System.Drawing.Point(66, 20)
        Me.cboxRateFrom.Name = "cboxRateFrom"
        Me.cboxRateFrom.Size = New System.Drawing.Size(83, 21)
        Me.cboxRateFrom.TabIndex = 9
        Me.cboxRateFrom.TabStop = False
        Me.cboxRateFrom.Text = "Select Rate"
        Me.cboxRateFrom.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboxUnitFrom)
        Me.GroupBox2.Controls.Add(Me.cboxRateFrom)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(213, 54)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Convert From"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboxUnitTo)
        Me.GroupBox3.Controls.Add(Me.cboxRateTo)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 115)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(213, 53)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Convert To"
        '
        'txtResults
        '
        Me.txtResults.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResults.Location = New System.Drawing.Point(12, 288)
        Me.txtResults.Multiline = True
        Me.txtResults.Name = "txtResults"
        Me.txtResults.ReadOnly = True
        Me.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResults.Size = New System.Drawing.Size(213, 134)
        Me.txtResults.TabIndex = 12
        Me.txtResults.TabStop = False
        '
        'lblScientificNotation
        '
        Me.lblScientificNotation.AutoSize = True
        Me.lblScientificNotation.Location = New System.Drawing.Point(33, 224)
        Me.lblScientificNotation.Name = "lblScientificNotation"
        Me.lblScientificNotation.Size = New System.Drawing.Size(115, 13)
        Me.lblScientificNotation.TabIndex = 13
        Me.lblScientificNotation.Text = "Add Scientific Notation"
        '
        'frmDoseConverter
        '
        Me.AcceptButton = Me.btnConvert
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(237, 442)
        Me.Controls.Add(Me.lblScientificNotation)
        Me.Controls.Add(Me.txtResults)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.chkboxScientificNotation)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmDoseConverter"
        Me.Text = "Dose Converter"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboxUnitFrom As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radbtnRate As System.Windows.Forms.RadioButton
    Friend WithEvents radbtnDose As System.Windows.Forms.RadioButton
    Friend WithEvents chkboxScientificNotation As System.Windows.Forms.CheckBox
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents cboxUnitTo As System.Windows.Forms.ComboBox
    Friend WithEvents cboxRateTo As System.Windows.Forms.ComboBox
    Friend WithEvents cboxRateFrom As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtResults As System.Windows.Forms.TextBox
    Friend WithEvents lblScientificNotation As System.Windows.Forms.Label

End Class
