<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SsisViewer
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SsisViewer))
        Me.lowerSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.upperSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.nodePanel = New System.Windows.Forms.Panel()
        Me.addProjectBttn = New System.Windows.Forms.Button()
        Me.projectTreeView = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.menuMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddProjectFromServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllProjectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentationOfSelectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColumnsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sqlStatementsPanel = New System.Windows.Forms.Panel()
        Me.sqlStatmentsLabel = New System.Windows.Forms.Label()
        Me.sqlTextBox = New System.Windows.Forms.RichTextBox()
        Me.verticalMainSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.propertiesDataGridView = New System.Windows.Forms.DataGridView()
        Me.PropertyName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PropertyValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.lowerSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lowerSplitContainer.Panel1.SuspendLayout()
        Me.lowerSplitContainer.Panel2.SuspendLayout()
        Me.lowerSplitContainer.SuspendLayout()
        CType(Me.upperSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.upperSplitContainer.Panel1.SuspendLayout()
        Me.upperSplitContainer.Panel2.SuspendLayout()
        Me.upperSplitContainer.SuspendLayout()
        Me.nodePanel.SuspendLayout()
        Me.menuMenuStrip.SuspendLayout()
        Me.sqlStatementsPanel.SuspendLayout()
        CType(Me.verticalMainSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.verticalMainSplitContainer.Panel1.SuspendLayout()
        Me.verticalMainSplitContainer.Panel2.SuspendLayout()
        Me.verticalMainSplitContainer.SuspendLayout()
        CType(Me.propertiesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.columnDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lowerSplitContainer
        '
        Me.lowerSplitContainer.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lowerSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lowerSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.lowerSplitContainer.Name = "lowerSplitContainer"
        Me.lowerSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'lowerSplitContainer.Panel1
        '
        Me.lowerSplitContainer.Panel1.Controls.Add(Me.upperSplitContainer)
        '
        'lowerSplitContainer.Panel2
        '
        Me.lowerSplitContainer.Panel2.Controls.Add(Me.verticalMainSplitContainer)
        Me.lowerSplitContainer.Size = New System.Drawing.Size(650, 657)
        Me.lowerSplitContainer.SplitterDistance = 303
        Me.lowerSplitContainer.TabIndex = 13
        '
        'upperSplitContainer
        '
        Me.upperSplitContainer.BackColor = System.Drawing.SystemColors.ControlLight
        Me.upperSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.upperSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.upperSplitContainer.Name = "upperSplitContainer"
        '
        'upperSplitContainer.Panel1
        '
        Me.upperSplitContainer.Panel1.Controls.Add(Me.nodePanel)
        '
        'upperSplitContainer.Panel2
        '
        Me.upperSplitContainer.Panel2.Controls.Add(Me.sqlStatementsPanel)
        Me.upperSplitContainer.Size = New System.Drawing.Size(650, 303)
        Me.upperSplitContainer.SplitterDistance = 302
        Me.upperSplitContainer.TabIndex = 13
        '
        'nodePanel
        '
        Me.nodePanel.Controls.Add(Me.addProjectBttn)
        Me.nodePanel.Controls.Add(Me.projectTreeView)
        Me.nodePanel.Controls.Add(Me.menuMenuStrip)
        Me.nodePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nodePanel.Location = New System.Drawing.Point(0, 0)
        Me.nodePanel.Margin = New System.Windows.Forms.Padding(20)
        Me.nodePanel.Name = "nodePanel"
        Me.nodePanel.Padding = New System.Windows.Forms.Padding(5)
        Me.nodePanel.Size = New System.Drawing.Size(302, 303)
        Me.nodePanel.TabIndex = 9
        '
        'addProjectBttn
        '
        Me.addProjectBttn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addProjectBttn.AutoSize = True
        Me.addProjectBttn.BackColor = System.Drawing.Color.White
        Me.addProjectBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.addProjectBttn.Cursor = System.Windows.Forms.Cursors.Default
        Me.addProjectBttn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.addProjectBttn.FlatAppearance.BorderSize = 0
        Me.addProjectBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.addProjectBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.addProjectBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addProjectBttn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addProjectBttn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.addProjectBttn.Location = New System.Drawing.Point(263, 268)
        Me.addProjectBttn.Margin = New System.Windows.Forms.Padding(0)
        Me.addProjectBttn.Name = "addProjectBttn"
        Me.addProjectBttn.Size = New System.Drawing.Size(32, 29)
        Me.addProjectBttn.TabIndex = 7
        Me.addProjectBttn.Text = "+"
        Me.ToolTip1.SetToolTip(Me.addProjectBttn, "Add a Project")
        Me.addProjectBttn.UseVisualStyleBackColor = False
        '
        'projectTreeView
        '
        Me.projectTreeView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.projectTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.projectTreeView.ImageIndex = 0
        Me.projectTreeView.ImageList = Me.ImageList1
        Me.projectTreeView.Location = New System.Drawing.Point(5, 38)
        Me.projectTreeView.Margin = New System.Windows.Forms.Padding(0)
        Me.projectTreeView.Name = "projectTreeView"
        Me.projectTreeView.SelectedImageIndex = 0
        Me.projectTreeView.Size = New System.Drawing.Size(292, 260)
        Me.projectTreeView.TabIndex = 2
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "solution.ico")
        Me.ImageList1.Images.SetKeyName(1, "package.png")
        Me.ImageList1.Images.SetKeyName(2, "dataFlowTask.png")
        Me.ImageList1.Images.SetKeyName(3, "srcDest.ico")
        Me.ImageList1.Images.SetKeyName(4, "SQLScript.ico")
        '
        'menuMenuStrip
        '
        Me.menuMenuStrip.BackColor = System.Drawing.SystemColors.ControlLight
        Me.menuMenuStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.menuMenuStrip.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.menuMenuStrip.GripMargin = New System.Windows.Forms.Padding(0)
        Me.menuMenuStrip.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.menuMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ExportToolStripMenuItem})
        Me.menuMenuStrip.Location = New System.Drawing.Point(1, 1)
        Me.menuMenuStrip.Margin = New System.Windows.Forms.Padding(5)
        Me.menuMenuStrip.Name = "menuMenuStrip"
        Me.menuMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.menuMenuStrip.Size = New System.Drawing.Size(116, 28)
        Me.menuMenuStrip.TabIndex = 8
        Me.menuMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddProjectToolStripMenuItem, Me.AddProjectFromServerToolStripMenuItem, Me.DeleteSelectedToolStripMenuItem, Me.CloseAllProjectsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AddProjectToolStripMenuItem
        '
        Me.AddProjectToolStripMenuItem.Name = "AddProjectToolStripMenuItem"
        Me.AddProjectToolStripMenuItem.Size = New System.Drawing.Size(247, 24)
        Me.AddProjectToolStripMenuItem.Text = "Open Project"
        '
        'AddProjectFromServerToolStripMenuItem
        '
        Me.AddProjectFromServerToolStripMenuItem.Name = "AddProjectFromServerToolStripMenuItem"
        Me.AddProjectFromServerToolStripMenuItem.Size = New System.Drawing.Size(247, 24)
        Me.AddProjectFromServerToolStripMenuItem.Text = "Open Project from Server"
        '
        'DeleteSelectedToolStripMenuItem
        '
        Me.DeleteSelectedToolStripMenuItem.Name = "DeleteSelectedToolStripMenuItem"
        Me.DeleteSelectedToolStripMenuItem.Size = New System.Drawing.Size(247, 24)
        Me.DeleteSelectedToolStripMenuItem.Text = "Close Selected Project"
        '
        'CloseAllProjectsToolStripMenuItem
        '
        Me.CloseAllProjectsToolStripMenuItem.Name = "CloseAllProjectsToolStripMenuItem"
        Me.CloseAllProjectsToolStripMenuItem.Size = New System.Drawing.Size(247, 24)
        Me.CloseAllProjectsToolStripMenuItem.Text = "Close All Projects"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ExportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DocumentationToolStripMenuItem, Me.DocumentationOfSelectionToolStripMenuItem, Me.ColumnsToolStripMenuItem})
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'DocumentationToolStripMenuItem
        '
        Me.DocumentationToolStripMenuItem.Name = "DocumentationToolStripMenuItem"
        Me.DocumentationToolStripMenuItem.Size = New System.Drawing.Size(248, 24)
        Me.DocumentationToolStripMenuItem.Text = "Project Documentation"
        '
        'DocumentationOfSelectionToolStripMenuItem
        '
        Me.DocumentationOfSelectionToolStripMenuItem.Name = "DocumentationOfSelectionToolStripMenuItem"
        Me.DocumentationOfSelectionToolStripMenuItem.Size = New System.Drawing.Size(248, 24)
        Me.DocumentationOfSelectionToolStripMenuItem.Text = "Selection Documentation"
        '
        'ColumnsToolStripMenuItem
        '
        Me.ColumnsToolStripMenuItem.Name = "ColumnsToolStripMenuItem"
        Me.ColumnsToolStripMenuItem.Size = New System.Drawing.Size(248, 24)
        Me.ColumnsToolStripMenuItem.Text = "Column Mapping"
        '
        'sqlStatementsPanel
        '
        Me.sqlStatementsPanel.AutoSize = True
        Me.sqlStatementsPanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.sqlStatementsPanel.Controls.Add(Me.sqlStatmentsLabel)
        Me.sqlStatementsPanel.Controls.Add(Me.sqlTextBox)
        Me.sqlStatementsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sqlStatementsPanel.Location = New System.Drawing.Point(0, 0)
        Me.sqlStatementsPanel.Name = "sqlStatementsPanel"
        Me.sqlStatementsPanel.Size = New System.Drawing.Size(344, 303)
        Me.sqlStatementsPanel.TabIndex = 11
        '
        'sqlStatmentsLabel
        '
        Me.sqlStatmentsLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.sqlStatmentsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sqlStatmentsLabel.Location = New System.Drawing.Point(0, 0)
        Me.sqlStatmentsLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.sqlStatmentsLabel.Name = "sqlStatmentsLabel"
        Me.sqlStatmentsLabel.Size = New System.Drawing.Size(344, 31)
        Me.sqlStatmentsLabel.TabIndex = 1
        Me.sqlStatmentsLabel.Text = "SQL Statements"
        Me.sqlStatmentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sqlTextBox
        '
        Me.sqlTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sqlTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.sqlTextBox.Location = New System.Drawing.Point(4, 38)
        Me.sqlTextBox.Name = "sqlTextBox"
        Me.sqlTextBox.Size = New System.Drawing.Size(333, 259)
        Me.sqlTextBox.TabIndex = 0
        Me.sqlTextBox.Text = ""
        Me.ToolTip1.SetToolTip(Me.sqlTextBox, "The SQL of the selected object")
        '
        'verticalMainSplitContainer
        '
        Me.verticalMainSplitContainer.BackColor = System.Drawing.SystemColors.ControlLight
        Me.verticalMainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.verticalMainSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.verticalMainSplitContainer.Name = "verticalMainSplitContainer"
        '
        'verticalMainSplitContainer.Panel1
        '
        Me.verticalMainSplitContainer.Panel1.Controls.Add(Me.Label1)
        Me.verticalMainSplitContainer.Panel1.Controls.Add(Me.propertiesDataGridView)
        Me.verticalMainSplitContainer.Panel1.Padding = New System.Windows.Forms.Padding(3)
        '
        'verticalMainSplitContainer.Panel2
        '
        Me.verticalMainSplitContainer.Panel2.Controls.Add(Me.Label2)
        Me.verticalMainSplitContainer.Panel2.Controls.Add(Me.columnDataGridView)
        Me.verticalMainSplitContainer.Panel2.Padding = New System.Windows.Forms.Padding(3)
        Me.verticalMainSplitContainer.Size = New System.Drawing.Size(650, 350)
        Me.verticalMainSplitContainer.SplitterDistance = 302
        Me.verticalMainSplitContainer.TabIndex = 12
        '
        'propertiesDataGridView
        '
        Me.propertiesDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propertiesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.propertiesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.propertiesDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.propertiesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.propertiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.propertiesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PropertyName, Me.PropertyValue})
        Me.propertiesDataGridView.Location = New System.Drawing.Point(3, 35)
        Me.propertiesDataGridView.Name = "propertiesDataGridView"
        Me.propertiesDataGridView.ReadOnly = True
        Me.propertiesDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.propertiesDataGridView.Size = New System.Drawing.Size(296, 315)
        Me.propertiesDataGridView.TabIndex = 4
        '
        'PropertyName
        '
        Me.PropertyName.HeaderText = "Property"
        Me.PropertyName.Name = "PropertyName"
        Me.PropertyName.ReadOnly = True
        '
        'PropertyValue
        '
        Me.PropertyValue.HeaderText = "Value"
        Me.PropertyValue.Name = "PropertyValue"
        Me.PropertyValue.ReadOnly = True
        '
        'columnDataGridView
        '
        Me.columnDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.columnDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.columnDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.columnDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.columnDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.columnDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.columnDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.columnDataGridView.Location = New System.Drawing.Point(3, 35)
        Me.columnDataGridView.Margin = New System.Windows.Forms.Padding(0)
        Me.columnDataGridView.Name = "columnDataGridView"
        Me.columnDataGridView.ReadOnly = True
        Me.columnDataGridView.Size = New System.Drawing.Size(338, 315)
        Me.columnDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Source Column"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Destination Column"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Properties"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(338, 29)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Column Mapping"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SsisViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(650, 657)
        Me.Controls.Add(Me.lowerSplitContainer)
        Me.MainMenuStrip = Me.menuMenuStrip
        Me.Name = "SsisViewer"
        Me.Text = "SSIS Analyzer"
        Me.lowerSplitContainer.Panel1.ResumeLayout(False)
        Me.lowerSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.lowerSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lowerSplitContainer.ResumeLayout(False)
        Me.upperSplitContainer.Panel1.ResumeLayout(False)
        Me.upperSplitContainer.Panel2.ResumeLayout(False)
        Me.upperSplitContainer.Panel2.PerformLayout()
        CType(Me.upperSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.upperSplitContainer.ResumeLayout(False)
        Me.nodePanel.ResumeLayout(False)
        Me.nodePanel.PerformLayout()
        Me.menuMenuStrip.ResumeLayout(False)
        Me.menuMenuStrip.PerformLayout()
        Me.sqlStatementsPanel.ResumeLayout(False)
        Me.verticalMainSplitContainer.Panel1.ResumeLayout(False)
        Me.verticalMainSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.verticalMainSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.verticalMainSplitContainer.ResumeLayout(False)
        CType(Me.propertiesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.columnDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lowerSplitContainer As SplitContainer
    Friend WithEvents upperSplitContainer As SplitContainer
    Friend WithEvents nodePanel As Panel
    Friend WithEvents projectTreeView As TreeView
    Friend WithEvents addProjectBttn As Button
    Friend WithEvents sqlStatementsPanel As Panel
    Friend WithEvents sqlStatmentsLabel As Label
    Friend WithEvents sqlTextBox As RichTextBox
    Friend WithEvents verticalMainSplitContainer As SplitContainer
    Friend WithEvents propertiesDataGridView As DataGridView
    Friend WithEvents PropertyName As DataGridViewTextBoxColumn
    Friend WithEvents PropertyValue As DataGridViewTextBoxColumn
    Friend WithEvents columnDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents menuMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DocumentationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColumnsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteSelectedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddProjectFromServerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseAllProjectsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents DocumentationOfSelectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
