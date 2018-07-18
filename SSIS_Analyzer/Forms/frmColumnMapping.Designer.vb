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
        Me.itemPathText = New System.Windows.Forms.RichTextBox()
        Me.sqlCommandText = New System.Windows.Forms.RichTextBox()
        Me.connectionManagerRefIdText = New System.Windows.Forms.RichTextBox()
        Me.openRowsetVariableText = New System.Windows.Forms.RichTextBox()
        Me.openRowsetText = New System.Windows.Forms.RichTextBox()
        Me.SqlCommandVariableText = New System.Windows.Forms.RichTextBox()
        Me.nameText = New System.Windows.Forms.RichTextBox()
        Me.selectProjectBttn = New System.Windows.Forms.Button()
        Me.dataFlowComboBox = New System.Windows.Forms.ComboBox()
        Me.nameTextDest = New System.Windows.Forms.RichTextBox()
        Me.SqlCommandVariableTextDest = New System.Windows.Forms.RichTextBox()
        Me.openRowsetTextDest = New System.Windows.Forms.RichTextBox()
        Me.openRowsetVariableTextDest = New System.Windows.Forms.RichTextBox()
        Me.connectionManagerRefIdTextDest = New System.Windows.Forms.RichTextBox()
        Me.sqlCommandTextDest = New System.Windows.Forms.RichTextBox()
        Me.itemPathTextDest = New System.Windows.Forms.RichTextBox()
        Me.OutputColumnListBox = New System.Windows.Forms.ListBox()
        Me.InputColumnListBox = New System.Windows.Forms.ListBox()
        Me.packageComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.projectPathTextBox = New System.Windows.Forms.RichTextBox()
        Me.exportWordBttn = New System.Windows.Forms.Button()
        Me.batchExportBttn = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'itemPathText
        '
        Me.itemPathText.BackColor = System.Drawing.SystemColors.Control
        Me.itemPathText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemPathText.Location = New System.Drawing.Point(152, 127)
        Me.itemPathText.Name = "itemPathText"
        Me.itemPathText.ReadOnly = True
        Me.itemPathText.Size = New System.Drawing.Size(275, 35)
        Me.itemPathText.TabIndex = 0
        Me.itemPathText.Text = ""
        '
        'sqlCommandText
        '
        Me.sqlCommandText.Location = New System.Drawing.Point(152, 373)
        Me.sqlCommandText.Name = "sqlCommandText"
        Me.sqlCommandText.ReadOnly = True
        Me.sqlCommandText.Size = New System.Drawing.Size(275, 141)
        Me.sqlCommandText.TabIndex = 1
        Me.sqlCommandText.Text = ""
        '
        'connectionManagerRefIdText
        '
        Me.connectionManagerRefIdText.Location = New System.Drawing.Point(152, 332)
        Me.connectionManagerRefIdText.Name = "connectionManagerRefIdText"
        Me.connectionManagerRefIdText.ReadOnly = True
        Me.connectionManagerRefIdText.Size = New System.Drawing.Size(275, 35)
        Me.connectionManagerRefIdText.TabIndex = 2
        Me.connectionManagerRefIdText.Text = ""
        '
        'openRowsetVariableText
        '
        Me.openRowsetVariableText.Location = New System.Drawing.Point(152, 293)
        Me.openRowsetVariableText.Name = "openRowsetVariableText"
        Me.openRowsetVariableText.ReadOnly = True
        Me.openRowsetVariableText.Size = New System.Drawing.Size(275, 35)
        Me.openRowsetVariableText.TabIndex = 5
        Me.openRowsetVariableText.Text = ""
        '
        'openRowsetText
        '
        Me.openRowsetText.Location = New System.Drawing.Point(152, 252)
        Me.openRowsetText.Name = "openRowsetText"
        Me.openRowsetText.ReadOnly = True
        Me.openRowsetText.Size = New System.Drawing.Size(275, 35)
        Me.openRowsetText.TabIndex = 6
        Me.openRowsetText.Text = ""
        '
        'SqlCommandVariableText
        '
        Me.SqlCommandVariableText.Location = New System.Drawing.Point(152, 209)
        Me.SqlCommandVariableText.Name = "SqlCommandVariableText"
        Me.SqlCommandVariableText.ReadOnly = True
        Me.SqlCommandVariableText.Size = New System.Drawing.Size(275, 35)
        Me.SqlCommandVariableText.TabIndex = 7
        Me.SqlCommandVariableText.Text = ""
        '
        'nameText
        '
        Me.nameText.Location = New System.Drawing.Point(152, 168)
        Me.nameText.Name = "nameText"
        Me.nameText.ReadOnly = True
        Me.nameText.Size = New System.Drawing.Size(275, 35)
        Me.nameText.TabIndex = 8
        Me.nameText.Text = ""
        '
        'selectProjectBttn
        '
        Me.selectProjectBttn.Location = New System.Drawing.Point(601, 43)
        Me.selectProjectBttn.Name = "selectProjectBttn"
        Me.selectProjectBttn.Size = New System.Drawing.Size(111, 24)
        Me.selectProjectBttn.TabIndex = 10
        Me.selectProjectBttn.Text = "Select File"
        Me.selectProjectBttn.UseVisualStyleBackColor = True
        '
        'dataFlowComboBox
        '
        Me.dataFlowComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dataFlowComboBox.FormattingEnabled = True
        Me.dataFlowComboBox.Location = New System.Drawing.Point(152, 100)
        Me.dataFlowComboBox.Name = "dataFlowComboBox"
        Me.dataFlowComboBox.Size = New System.Drawing.Size(560, 21)
        Me.dataFlowComboBox.TabIndex = 11
        '
        'nameTextDest
        '
        Me.nameTextDest.Location = New System.Drawing.Point(437, 168)
        Me.nameTextDest.Name = "nameTextDest"
        Me.nameTextDest.ReadOnly = True
        Me.nameTextDest.Size = New System.Drawing.Size(275, 35)
        Me.nameTextDest.TabIndex = 20
        Me.nameTextDest.Text = ""
        '
        'SqlCommandVariableTextDest
        '
        Me.SqlCommandVariableTextDest.Location = New System.Drawing.Point(437, 209)
        Me.SqlCommandVariableTextDest.Name = "SqlCommandVariableTextDest"
        Me.SqlCommandVariableTextDest.ReadOnly = True
        Me.SqlCommandVariableTextDest.Size = New System.Drawing.Size(275, 35)
        Me.SqlCommandVariableTextDest.TabIndex = 19
        Me.SqlCommandVariableTextDest.Text = ""
        '
        'openRowsetTextDest
        '
        Me.openRowsetTextDest.Location = New System.Drawing.Point(437, 252)
        Me.openRowsetTextDest.Name = "openRowsetTextDest"
        Me.openRowsetTextDest.ReadOnly = True
        Me.openRowsetTextDest.Size = New System.Drawing.Size(275, 35)
        Me.openRowsetTextDest.TabIndex = 18
        Me.openRowsetTextDest.Text = ""
        '
        'openRowsetVariableTextDest
        '
        Me.openRowsetVariableTextDest.Location = New System.Drawing.Point(437, 293)
        Me.openRowsetVariableTextDest.Name = "openRowsetVariableTextDest"
        Me.openRowsetVariableTextDest.ReadOnly = True
        Me.openRowsetVariableTextDest.Size = New System.Drawing.Size(275, 35)
        Me.openRowsetVariableTextDest.TabIndex = 17
        Me.openRowsetVariableTextDest.Text = ""
        '
        'connectionManagerRefIdTextDest
        '
        Me.connectionManagerRefIdTextDest.Location = New System.Drawing.Point(437, 332)
        Me.connectionManagerRefIdTextDest.Name = "connectionManagerRefIdTextDest"
        Me.connectionManagerRefIdTextDest.ReadOnly = True
        Me.connectionManagerRefIdTextDest.Size = New System.Drawing.Size(275, 35)
        Me.connectionManagerRefIdTextDest.TabIndex = 14
        Me.connectionManagerRefIdTextDest.Text = ""
        '
        'sqlCommandTextDest
        '
        Me.sqlCommandTextDest.Location = New System.Drawing.Point(437, 373)
        Me.sqlCommandTextDest.Name = "sqlCommandTextDest"
        Me.sqlCommandTextDest.ReadOnly = True
        Me.sqlCommandTextDest.Size = New System.Drawing.Size(275, 141)
        Me.sqlCommandTextDest.TabIndex = 13
        Me.sqlCommandTextDest.Text = ""
        '
        'itemPathTextDest
        '
        Me.itemPathTextDest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemPathTextDest.Location = New System.Drawing.Point(437, 127)
        Me.itemPathTextDest.Name = "itemPathTextDest"
        Me.itemPathTextDest.ReadOnly = True
        Me.itemPathTextDest.Size = New System.Drawing.Size(275, 35)
        Me.itemPathTextDest.TabIndex = 12
        Me.itemPathTextDest.Text = ""
        '
        'OutputColumnListBox
        '
        Me.OutputColumnListBox.FormattingEnabled = True
        Me.OutputColumnListBox.Location = New System.Drawing.Point(152, 519)
        Me.OutputColumnListBox.Name = "OutputColumnListBox"
        Me.OutputColumnListBox.Size = New System.Drawing.Size(275, 225)
        Me.OutputColumnListBox.TabIndex = 22
        '
        'InputColumnListBox
        '
        Me.InputColumnListBox.FormattingEnabled = True
        Me.InputColumnListBox.Location = New System.Drawing.Point(437, 520)
        Me.InputColumnListBox.Name = "InputColumnListBox"
        Me.InputColumnListBox.Size = New System.Drawing.Size(275, 225)
        Me.InputColumnListBox.TabIndex = 23
        '
        'packageComboBox
        '
        Me.packageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.packageComboBox.FormattingEnabled = True
        Me.packageComboBox.Location = New System.Drawing.Point(152, 73)
        Me.packageComboBox.Name = "packageComboBox"
        Me.packageComboBox.Size = New System.Drawing.Size(560, 21)
        Me.packageComboBox.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(64, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Packages"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(11, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 20)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Data Flow Tasks"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(66, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Item Path"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(93, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(37, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 20)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "SQL Variable"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(36, 267)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 20)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Open Rowset"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(5, 308)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 20)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Open Rowset Var"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(19, 347)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 20)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Connection Mgr"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(22, 438)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 20)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "SQL Command"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(12, 622)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(134, 20)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Column Mapping"
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'projectPathTextBox
        '
        Me.projectPathTextBox.EnableAutoDragDrop = True
        Me.projectPathTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projectPathTextBox.Location = New System.Drawing.Point(152, 43)
        Me.projectPathTextBox.Multiline = False
        Me.projectPathTextBox.Name = "projectPathTextBox"
        Me.projectPathTextBox.Size = New System.Drawing.Size(443, 24)
        Me.projectPathTextBox.TabIndex = 36
        Me.projectPathTextBox.Text = ""
        '
        'exportWordBttn
        '
        Me.exportWordBttn.AutoSize = True
        Me.exportWordBttn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.exportWordBttn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exportWordBttn.Location = New System.Drawing.Point(304, 768)
        Me.exportWordBttn.Name = "exportWordBttn"
        Me.exportWordBttn.Size = New System.Drawing.Size(123, 27)
        Me.exportWordBttn.TabIndex = 38
        Me.exportWordBttn.Text = "Export to Word"
        Me.exportWordBttn.UseVisualStyleBackColor = True
        '
        'batchExportBttn
        '
        Me.batchExportBttn.AutoSize = True
        Me.batchExportBttn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.batchExportBttn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.batchExportBttn.Location = New System.Drawing.Point(437, 768)
        Me.batchExportBttn.Name = "batchExportBttn"
        Me.batchExportBttn.Size = New System.Drawing.Size(158, 27)
        Me.batchExportBttn.TabIndex = 39
        Me.batchExportBttn.Text = "Batch Export Project"
        Me.batchExportBttn.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.AutoUpgradeEnabled = False
        Me.SaveFileDialog1.DefaultExt = "docx"
        Me.SaveFileDialog1.Filter = "Word|*.docx"
        Me.SaveFileDialog1.RestoreDirectory = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(745, 827)
        Me.Controls.Add(Me.batchExportBttn)
        Me.Controls.Add(Me.exportWordBttn)
        Me.Controls.Add(Me.projectPathTextBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.packageComboBox)
        Me.Controls.Add(Me.InputColumnListBox)
        Me.Controls.Add(Me.OutputColumnListBox)
        Me.Controls.Add(Me.nameTextDest)
        Me.Controls.Add(Me.SqlCommandVariableTextDest)
        Me.Controls.Add(Me.openRowsetTextDest)
        Me.Controls.Add(Me.openRowsetVariableTextDest)
        Me.Controls.Add(Me.connectionManagerRefIdTextDest)
        Me.Controls.Add(Me.sqlCommandTextDest)
        Me.Controls.Add(Me.itemPathTextDest)
        Me.Controls.Add(Me.dataFlowComboBox)
        Me.Controls.Add(Me.selectProjectBttn)
        Me.Controls.Add(Me.nameText)
        Me.Controls.Add(Me.SqlCommandVariableText)
        Me.Controls.Add(Me.openRowsetText)
        Me.Controls.Add(Me.openRowsetVariableText)
        Me.Controls.Add(Me.connectionManagerRefIdText)
        Me.Controls.Add(Me.sqlCommandText)
        Me.Controls.Add(Me.itemPathText)
        Me.Name = "Form1"
        Me.Text = "SSIS Analyzer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents itemPathText As RichTextBox
    Friend WithEvents sqlCommandText As RichTextBox
    Friend WithEvents connectionManagerRefIdText As RichTextBox
    Friend WithEvents openRowsetVariableText As RichTextBox
    Friend WithEvents openRowsetText As RichTextBox
    Friend WithEvents SqlCommandVariableText As RichTextBox
    Friend WithEvents nameText As RichTextBox
    Friend WithEvents selectProjectBttn As Button
    Friend WithEvents dataFlowComboBox As ComboBox
    Friend WithEvents nameTextDest As RichTextBox
    Friend WithEvents SqlCommandVariableTextDest As RichTextBox
    Friend WithEvents openRowsetTextDest As RichTextBox
    Friend WithEvents openRowsetVariableTextDest As RichTextBox
    Friend WithEvents connectionManagerRefIdTextDest As RichTextBox
    Friend WithEvents sqlCommandTextDest As RichTextBox
    Friend WithEvents itemPathTextDest As RichTextBox
    Friend WithEvents OutputColumnListBox As ListBox
    Friend WithEvents InputColumnListBox As ListBox
    Friend WithEvents packageComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents projectPathTextBox As RichTextBox
    Friend WithEvents exportWordBttn As Button
    Friend WithEvents batchExportBttn As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
