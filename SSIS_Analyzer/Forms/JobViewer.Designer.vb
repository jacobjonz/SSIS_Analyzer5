<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class JobViewer
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.mainSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.lastExecutionIdLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.jobNameComboBox = New System.Windows.Forms.ComboBox()
        Me.commandsListBox = New System.Windows.Forms.ListBox()
        Me.ownerTextBox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.proxyTextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.descriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.scheduleListBox = New System.Windows.Forms.ListBox()
        Me.lastExecutionIDTextBox = New System.Windows.Forms.TextBox()
        Me.statusLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.currentRunStatusTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.nextRunDateTextBox = New System.Windows.Forms.TextBox()
        Me.serverComboBox = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.enabledTextBox = New System.Windows.Forms.TextBox()
        Me.lastRunDurationTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lastRunOutcomeTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lastRunDateTextBox = New System.Windows.Forms.TextBox()
        Me.viewExecutionRprtBtn = New System.Windows.Forms.Button()
        Me.executionIdLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.stepNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.stepIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.executionIdTextBox = New System.Windows.Forms.TextBox()
        Me.jobMessageTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.jobHistoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.jobDurationTextBox = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.jobOutcomeTextBox = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.jobDateTextBox = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.mainSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainSplitContainer.Panel1.SuspendLayout()
        Me.mainSplitContainer.Panel2.SuspendLayout()
        Me.mainSplitContainer.SuspendLayout()
        CType(Me.jobHistoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainSplitContainer
        '
        Me.mainSplitContainer.BackColor = System.Drawing.SystemColors.ControlLight
        Me.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.mainSplitContainer.MinimumSize = New System.Drawing.Size(617, 641)
        Me.mainSplitContainer.Name = "mainSplitContainer"
        '
        'mainSplitContainer.Panel1
        '
        Me.mainSplitContainer.Panel1.Controls.Add(Me.Button1)
        Me.mainSplitContainer.Panel1.Controls.Add(Me.lastExecutionIdLinkLabel)
        Me.mainSplitContainer.Panel1.Controls.Add(Me.jobNameComboBox)
        Me.mainSplitContainer.Panel1.Controls.Add(Me.commandsListBox)
        Me.mainSplitContainer.Panel1.Controls.Add(Me.ownerTextBox)
        Me.mainSplitContainer.Panel1.Controls.Add(Me.Label14)
        Me.mainSplitContainer.Panel1.Controls.Add(Me.proxyTextBox)
        Me.mainSplitContainer.Panel1.Controls.Add(Me.Label13)
        Me.mainSplitContainer.Panel1.Controls.Add(Me.descriptionTextBox)
        Me.mainSplitContainer.Panel1.Controls.Add(Me.Label12)
        Me.mainSplitContainer.Panel1.Controls.Add(Me.Label4)
        Me.mainSplitContainer.Panel1.Controls.Add(Me.scheduleListBox)
        Me.mainSplitContainer.Panel1.Controls.Add(Me.lastExecutionIDTextBox)
        Me.mainSplitContainer.Panel1.Controls.Add(Me.statusLabel)
        Me.mainSplitContainer.Panel1.Controls.Add(Me.Label2)
        Me.mainSplitContainer.Panel1.Controls.Add(Me.currentRunStatusTextBox)
        Me.mainSplitContainer.Panel1.Controls.Add(Me.Label1)
        Me.mainSplitContainer.Panel1.Controls.Add(Me.Label10)
        Me.mainSplitContainer.Panel1.Controls.Add(Me.nextRunDateTextBox)
        Me.mainSplitContainer.Panel1.Controls.Add(Me.serverComboBox)
        Me.mainSplitContainer.Panel1.Controls.Add(Me.Label9)
        Me.mainSplitContainer.Panel1.Controls.Add(Me.enabledTextBox)
        Me.mainSplitContainer.Panel1.Controls.Add(Me.lastRunDurationTextBox)
        Me.mainSplitContainer.Panel1.Controls.Add(Me.Label3)
        Me.mainSplitContainer.Panel1.Controls.Add(Me.Label8)
        Me.mainSplitContainer.Panel1.Controls.Add(Me.lastRunOutcomeTextBox)
        Me.mainSplitContainer.Panel1.Controls.Add(Me.Label5)
        Me.mainSplitContainer.Panel1.Controls.Add(Me.Label7)
        Me.mainSplitContainer.Panel1.Controls.Add(Me.Label6)
        Me.mainSplitContainer.Panel1.Controls.Add(Me.lastRunDateTextBox)
        '
        'mainSplitContainer.Panel2
        '
        Me.mainSplitContainer.Panel2.Controls.Add(Me.viewExecutionRprtBtn)
        Me.mainSplitContainer.Panel2.Controls.Add(Me.executionIdLinkLabel)
        Me.mainSplitContainer.Panel2.Controls.Add(Me.stepNameTextBox)
        Me.mainSplitContainer.Panel2.Controls.Add(Me.Label22)
        Me.mainSplitContainer.Panel2.Controls.Add(Me.stepIdTextBox)
        Me.mainSplitContainer.Panel2.Controls.Add(Me.Label21)
        Me.mainSplitContainer.Panel2.Controls.Add(Me.executionIdTextBox)
        Me.mainSplitContainer.Panel2.Controls.Add(Me.jobMessageTextBox)
        Me.mainSplitContainer.Panel2.Controls.Add(Me.Label19)
        Me.mainSplitContainer.Panel2.Controls.Add(Me.jobHistoryDataGridView)
        Me.mainSplitContainer.Panel2.Controls.Add(Me.jobDurationTextBox)
        Me.mainSplitContainer.Panel2.Controls.Add(Me.Label16)
        Me.mainSplitContainer.Panel2.Controls.Add(Me.jobOutcomeTextBox)
        Me.mainSplitContainer.Panel2.Controls.Add(Me.Label17)
        Me.mainSplitContainer.Panel2.Controls.Add(Me.Label18)
        Me.mainSplitContainer.Panel2.Controls.Add(Me.jobDateTextBox)
        Me.mainSplitContainer.Panel2.Controls.Add(Me.Label15)
        Me.mainSplitContainer.Size = New System.Drawing.Size(824, 688)
        Me.mainSplitContainer.SplitterDistance = 335
        Me.mainSplitContainer.TabIndex = 2
        '
        'lastExecutionIdLinkLabel
        '
        Me.lastExecutionIdLinkLabel.AutoSize = True
        Me.lastExecutionIdLinkLabel.Location = New System.Drawing.Point(7, 333)
        Me.lastExecutionIdLinkLabel.Name = "lastExecutionIdLinkLabel"
        Me.lastExecutionIdLinkLabel.Size = New System.Drawing.Size(102, 15)
        Me.lastExecutionIdLinkLabel.TabIndex = 26
        Me.lastExecutionIdLinkLabel.TabStop = True
        Me.lastExecutionIdLinkLabel.Text = "Last Execution ID"
        '
        'jobNameComboBox
        '
        Me.jobNameComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.jobNameComboBox.FormattingEnabled = True
        Me.jobNameComboBox.Location = New System.Drawing.Point(77, 45)
        Me.jobNameComboBox.Name = "jobNameComboBox"
        Me.jobNameComboBox.Size = New System.Drawing.Size(250, 21)
        Me.jobNameComboBox.TabIndex = 1
        '
        'commandsListBox
        '
        Me.commandsListBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.commandsListBox.FormattingEnabled = True
        Me.commandsListBox.Location = New System.Drawing.Point(10, 581)
        Me.commandsListBox.Name = "commandsListBox"
        Me.commandsListBox.Size = New System.Drawing.Size(308, 95)
        Me.commandsListBox.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.commandsListBox, "Double click to view in a new window")
        '
        'ownerTextBox
        '
        Me.ownerTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ownerTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ownerTextBox.Location = New System.Drawing.Point(119, 304)
        Me.ownerTextBox.Name = "ownerTextBox"
        Me.ownerTextBox.ReadOnly = True
        Me.ownerTextBox.Size = New System.Drawing.Size(196, 20)
        Me.ownerTextBox.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.ownerTextBox, "Who created the job")
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 304)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 15)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Owner ID"
        '
        'proxyTextBox
        '
        Me.proxyTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.proxyTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.proxyTextBox.Location = New System.Drawing.Point(119, 278)
        Me.proxyTextBox.Name = "proxyTextBox"
        Me.proxyTextBox.ReadOnly = True
        Me.proxyTextBox.Size = New System.Drawing.Size(196, 20)
        Me.proxyTextBox.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 278)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 15)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Proxy Name"
        '
        'descriptionTextBox
        '
        Me.descriptionTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.descriptionTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.descriptionTextBox.Location = New System.Drawing.Point(119, 122)
        Me.descriptionTextBox.Name = "descriptionTextBox"
        Me.descriptionTextBox.ReadOnly = True
        Me.descriptionTextBox.Size = New System.Drawing.Size(196, 20)
        Me.descriptionTextBox.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.descriptionTextBox, "The Job description")
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 122)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 15)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Description"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 561)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Command(s)"
        '
        'scheduleListBox
        '
        Me.scheduleListBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.scheduleListBox.FormattingEnabled = True
        Me.scheduleListBox.Location = New System.Drawing.Point(10, 458)
        Me.scheduleListBox.Name = "scheduleListBox"
        Me.scheduleListBox.Size = New System.Drawing.Size(308, 95)
        Me.scheduleListBox.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.scheduleListBox, "Double click to view in a new window")
        '
        'lastExecutionIDTextBox
        '
        Me.lastExecutionIDTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lastExecutionIDTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lastExecutionIDTextBox.Location = New System.Drawing.Point(119, 330)
        Me.lastExecutionIDTextBox.Name = "lastExecutionIDTextBox"
        Me.lastExecutionIDTextBox.ReadOnly = True
        Me.lastExecutionIDTextBox.Size = New System.Drawing.Size(196, 20)
        Me.lastExecutionIDTextBox.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.lastExecutionIDTextBox, "The most recent Execution ID passed to SQL Agent from a package")
        '
        'statusLabel
        '
        Me.statusLabel.AutoSize = True
        Me.statusLabel.Location = New System.Drawing.Point(4, 621)
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(0, 15)
        Me.statusLabel.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.471698!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Job Name"
        '
        'currentRunStatusTextBox
        '
        Me.currentRunStatusTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.currentRunStatusTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.currentRunStatusTextBox.Location = New System.Drawing.Point(119, 148)
        Me.currentRunStatusTextBox.Name = "currentRunStatusTextBox"
        Me.currentRunStatusTextBox.ReadOnly = True
        Me.currentRunStatusTextBox.Size = New System.Drawing.Size(196, 20)
        Me.currentRunStatusTextBox.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.currentRunStatusTextBox, "What the job was doing when this was refreshed")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.471698!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Server"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 148)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 15)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Current Run Status"
        '
        'nextRunDateTextBox
        '
        Me.nextRunDateTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nextRunDateTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.nextRunDateTextBox.Location = New System.Drawing.Point(119, 252)
        Me.nextRunDateTextBox.Name = "nextRunDateTextBox"
        Me.nextRunDateTextBox.ReadOnly = True
        Me.nextRunDateTextBox.Size = New System.Drawing.Size(196, 20)
        Me.nextRunDateTextBox.TabIndex = 13
        '
        'serverComboBox
        '
        Me.serverComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.serverComboBox.FormattingEnabled = True
        Me.serverComboBox.Items.AddRange(New Object() {"LALFID0DBS07\SQL1", "LALFID0DBS07\SQL2", "LALFID0DBS11\SQL1", "LALFID0DBS11\SQL2"})
        Me.serverComboBox.Location = New System.Drawing.Point(77, 18)
        Me.serverComboBox.Name = "serverComboBox"
        Me.serverComboBox.Size = New System.Drawing.Size(250, 21)
        Me.serverComboBox.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 252)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 15)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Next Run Date"
        '
        'enabledTextBox
        '
        Me.enabledTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.enabledTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.enabledTextBox.Location = New System.Drawing.Point(119, 96)
        Me.enabledTextBox.Name = "enabledTextBox"
        Me.enabledTextBox.ReadOnly = True
        Me.enabledTextBox.Size = New System.Drawing.Size(196, 20)
        Me.enabledTextBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.enabledTextBox, "Is the job enabled?")
        '
        'lastRunDurationTextBox
        '
        Me.lastRunDurationTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lastRunDurationTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lastRunDurationTextBox.Location = New System.Drawing.Point(119, 226)
        Me.lastRunDurationTextBox.Name = "lastRunDurationTextBox"
        Me.lastRunDurationTextBox.ReadOnly = True
        Me.lastRunDurationTextBox.Size = New System.Drawing.Size(196, 20)
        Me.lastRunDurationTextBox.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 440)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Schedule(s)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 15)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Last Run Duration"
        '
        'lastRunOutcomeTextBox
        '
        Me.lastRunOutcomeTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lastRunOutcomeTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lastRunOutcomeTextBox.Location = New System.Drawing.Point(119, 200)
        Me.lastRunOutcomeTextBox.Name = "lastRunOutcomeTextBox"
        Me.lastRunOutcomeTextBox.ReadOnly = True
        Me.lastRunOutcomeTextBox.Size = New System.Drawing.Size(196, 20)
        Me.lastRunOutcomeTextBox.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Enabled"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 15)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Last Run Outcome"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Last Run Date"
        '
        'lastRunDateTextBox
        '
        Me.lastRunDateTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lastRunDateTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lastRunDateTextBox.Location = New System.Drawing.Point(119, 174)
        Me.lastRunDateTextBox.Name = "lastRunDateTextBox"
        Me.lastRunDateTextBox.ReadOnly = True
        Me.lastRunDateTextBox.Size = New System.Drawing.Size(196, 20)
        Me.lastRunDateTextBox.TabIndex = 7
        '
        'viewExecutionRprtBtn
        '
        Me.viewExecutionRprtBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewExecutionRprtBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewExecutionRprtBtn.Location = New System.Drawing.Point(332, 656)
        Me.viewExecutionRprtBtn.Name = "viewExecutionRprtBtn"
        Me.viewExecutionRprtBtn.Size = New System.Drawing.Size(138, 25)
        Me.viewExecutionRprtBtn.TabIndex = 28
        Me.viewExecutionRprtBtn.Text = "View Execution Report"
        Me.viewExecutionRprtBtn.UseVisualStyleBackColor = True
        '
        'executionIdLinkLabel
        '
        Me.executionIdLinkLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.executionIdLinkLabel.AutoSize = True
        Me.executionIdLinkLabel.Location = New System.Drawing.Point(7, 658)
        Me.executionIdLinkLabel.Name = "executionIdLinkLabel"
        Me.executionIdLinkLabel.Size = New System.Drawing.Size(76, 15)
        Me.executionIdLinkLabel.TabIndex = 27
        Me.executionIdLinkLabel.TabStop = True
        Me.executionIdLinkLabel.Text = "Execution ID"
        Me.executionIdLinkLabel.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'stepNameTextBox
        '
        Me.stepNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.stepNameTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.stepNameTextBox.Location = New System.Drawing.Point(92, 553)
        Me.stepNameTextBox.Name = "stepNameTextBox"
        Me.stepNameTextBox.ReadOnly = True
        Me.stepNameTextBox.Size = New System.Drawing.Size(381, 20)
        Me.stepNameTextBox.TabIndex = 26
        '
        'Label22
        '
        Me.Label22.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(7, 556)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(69, 15)
        Me.Label22.TabIndex = 25
        Me.Label22.Text = "Step Name"
        '
        'stepIdTextBox
        '
        Me.stepIdTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.stepIdTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.stepIdTextBox.Location = New System.Drawing.Point(92, 527)
        Me.stepIdTextBox.Name = "stepIdTextBox"
        Me.stepIdTextBox.ReadOnly = True
        Me.stepIdTextBox.Size = New System.Drawing.Size(381, 20)
        Me.stepIdTextBox.TabIndex = 24
        '
        'Label21
        '
        Me.Label21.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(7, 530)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(47, 15)
        Me.Label21.TabIndex = 23
        Me.Label21.Text = "Step ID"
        '
        'executionIdTextBox
        '
        Me.executionIdTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.executionIdTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.executionIdTextBox.Location = New System.Drawing.Point(92, 658)
        Me.executionIdTextBox.Name = "executionIdTextBox"
        Me.executionIdTextBox.ReadOnly = True
        Me.executionIdTextBox.Size = New System.Drawing.Size(233, 20)
        Me.executionIdTextBox.TabIndex = 22
        '
        'jobMessageTextBox
        '
        Me.jobMessageTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.jobMessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.jobMessageTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jobMessageTextBox.Location = New System.Drawing.Point(10, 363)
        Me.jobMessageTextBox.Name = "jobMessageTextBox"
        Me.jobMessageTextBox.ReadOnly = True
        Me.jobMessageTextBox.Size = New System.Drawing.Size(460, 158)
        Me.jobMessageTextBox.TabIndex = 20
        Me.jobMessageTextBox.Text = ""
        '
        'Label19
        '
        Me.Label19.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(7, 344)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(122, 15)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "Last Run Date/Times"
        '
        'jobHistoryDataGridView
        '
        Me.jobHistoryDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.jobHistoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.jobHistoryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.jobHistoryDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.jobHistoryDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.jobHistoryDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.jobHistoryDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.jobHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.471698!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.jobHistoryDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.jobHistoryDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.jobHistoryDataGridView.EnableHeadersVisualStyles = False
        Me.jobHistoryDataGridView.Location = New System.Drawing.Point(7, 35)
        Me.jobHistoryDataGridView.Name = "jobHistoryDataGridView"
        Me.jobHistoryDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.jobHistoryDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.jobHistoryDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.jobHistoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.jobHistoryDataGridView.ShowCellErrors = False
        Me.jobHistoryDataGridView.ShowCellToolTips = False
        Me.jobHistoryDataGridView.Size = New System.Drawing.Size(463, 306)
        Me.jobHistoryDataGridView.TabIndex = 18
        '
        'jobDurationTextBox
        '
        Me.jobDurationTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.jobDurationTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.jobDurationTextBox.Location = New System.Drawing.Point(92, 631)
        Me.jobDurationTextBox.Name = "jobDurationTextBox"
        Me.jobDurationTextBox.ReadOnly = True
        Me.jobDurationTextBox.Size = New System.Drawing.Size(381, 20)
        Me.jobDurationTextBox.TabIndex = 17
        '
        'Label16
        '
        Me.Label16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 631)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 15)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Job Duration"
        '
        'jobOutcomeTextBox
        '
        Me.jobOutcomeTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.jobOutcomeTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.jobOutcomeTextBox.Location = New System.Drawing.Point(92, 605)
        Me.jobOutcomeTextBox.Name = "jobOutcomeTextBox"
        Me.jobOutcomeTextBox.ReadOnly = True
        Me.jobOutcomeTextBox.Size = New System.Drawing.Size(381, 20)
        Me.jobOutcomeTextBox.TabIndex = 15
        '
        'Label17
        '
        Me.Label17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 605)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 15)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Job Outcome"
        '
        'Label18
        '
        Me.Label18.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(7, 579)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 15)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "Job Date"
        '
        'jobDateTextBox
        '
        Me.jobDateTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.jobDateTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.jobDateTextBox.Location = New System.Drawing.Point(92, 579)
        Me.jobDateTextBox.Name = "jobDateTextBox"
        Me.jobDateTextBox.ReadOnly = True
        Me.jobDateTextBox.Size = New System.Drawing.Size(381, 20)
        Me.jobDateTextBox.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(0, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(485, 36)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Job History"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(252, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Refresh"
        Me.ToolTip1.SetToolTip(Me.Button1, "Refreshes the last selected job")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'JobViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 688)
        Me.Controls.Add(Me.mainSplitContainer)
        Me.MinimumSize = New System.Drawing.Size(633, 682)
        Me.Name = "JobViewer"
        Me.Text = "JobViewer"
        Me.mainSplitContainer.Panel1.ResumeLayout(False)
        Me.mainSplitContainer.Panel1.PerformLayout()
        Me.mainSplitContainer.Panel2.ResumeLayout(False)
        Me.mainSplitContainer.Panel2.PerformLayout()
        CType(Me.mainSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainSplitContainer.ResumeLayout(False)
        CType(Me.jobHistoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mainSplitContainer As SplitContainer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents jobNameComboBox As ComboBox
    Friend WithEvents serverComboBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lastExecutionIDTextBox As TextBox
    Friend WithEvents currentRunStatusTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents nextRunDateTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lastRunDurationTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lastRunOutcomeTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lastRunDateTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents enabledTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents statusLabel As Label
    Friend WithEvents scheduleListBox As ListBox
    Friend WithEvents descriptionTextBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents proxyTextBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ownerTextBox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents commandsListBox As ListBox
    Friend WithEvents Label15 As Label
    Friend WithEvents jobDurationTextBox As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents jobOutcomeTextBox As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents jobDateTextBox As TextBox
    Friend WithEvents jobHistoryDataGridView As DataGridView
    Friend WithEvents Label19 As Label
    Friend WithEvents jobMessageTextBox As RichTextBox
    Friend WithEvents executionIdTextBox As TextBox
    Friend WithEvents stepNameTextBox As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents stepIdTextBox As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents lastExecutionIdLinkLabel As LinkLabel
    Friend WithEvents executionIdLinkLabel As LinkLabel
    Friend WithEvents viewExecutionRprtBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
