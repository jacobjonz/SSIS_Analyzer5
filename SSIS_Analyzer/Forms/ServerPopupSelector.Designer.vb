<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServerPopupSelector
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.serverComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.projectComboBox = New System.Windows.Forms.ComboBox()
        Me.okBttn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.folderComboBox = New System.Windows.Forms.ComboBox()
        Me.topPanel = New System.Windows.Forms.Panel()
        Me.topInternalPanel = New System.Windows.Forms.Panel()
        Me.bottomPanel = New System.Windows.Forms.Panel()
        Me.expandablePanel = New System.Windows.Forms.Panel()
        Me.useDefaultCheckBox = New System.Windows.Forms.CheckBox()
        Me.defaultLabel = New System.Windows.Forms.Label()
        Me.expandButton = New System.Windows.Forms.Button()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.userNameTextBox = New System.Windows.Forms.TextBox()
        Me.saveCheckBox = New System.Windows.Forms.CheckBox()
        Me.otherLoginRadioButton = New System.Windows.Forms.RadioButton()
        Me.windowsAuthRadioButton = New System.Windows.Forms.RadioButton()
        Me.topPanel.SuspendLayout()
        Me.topInternalPanel.SuspendLayout()
        Me.bottomPanel.SuspendLayout()
        Me.expandablePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.22642!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(502, 64)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server Connection"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'serverComboBox
        '
        Me.serverComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.serverComboBox.FormattingEnabled = True
        Me.serverComboBox.Location = New System.Drawing.Point(197, 3)
        Me.serverComboBox.Name = "serverComboBox"
        Me.serverComboBox.Size = New System.Drawing.Size(246, 21)
        Me.serverComboBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Server Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Project Name"
        '
        'projectComboBox
        '
        Me.projectComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.projectComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.projectComboBox.FormattingEnabled = True
        Me.projectComboBox.Location = New System.Drawing.Point(197, 81)
        Me.projectComboBox.Name = "projectComboBox"
        Me.projectComboBox.Size = New System.Drawing.Size(246, 21)
        Me.projectComboBox.TabIndex = 3
        '
        'okBttn
        '
        Me.okBttn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.okBttn.Location = New System.Drawing.Point(197, 33)
        Me.okBttn.Name = "okBttn"
        Me.okBttn.Size = New System.Drawing.Size(86, 36)
        Me.okBttn.TabIndex = 5
        Me.okBttn.Text = "OK"
        Me.okBttn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(58, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Folder Name"
        '
        'folderComboBox
        '
        Me.folderComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.folderComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.folderComboBox.FormattingEnabled = True
        Me.folderComboBox.Location = New System.Drawing.Point(197, 41)
        Me.folderComboBox.Name = "folderComboBox"
        Me.folderComboBox.Size = New System.Drawing.Size(246, 21)
        Me.folderComboBox.TabIndex = 6
        '
        'topPanel
        '
        Me.topPanel.Controls.Add(Me.topInternalPanel)
        Me.topPanel.Controls.Add(Me.Label1)
        Me.topPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.topPanel.Location = New System.Drawing.Point(0, 0)
        Me.topPanel.Name = "topPanel"
        Me.topPanel.Size = New System.Drawing.Size(502, 184)
        Me.topPanel.TabIndex = 8
        '
        'topInternalPanel
        '
        Me.topInternalPanel.Controls.Add(Me.serverComboBox)
        Me.topInternalPanel.Controls.Add(Me.Label4)
        Me.topInternalPanel.Controls.Add(Me.Label2)
        Me.topInternalPanel.Controls.Add(Me.folderComboBox)
        Me.topInternalPanel.Controls.Add(Me.projectComboBox)
        Me.topInternalPanel.Controls.Add(Me.Label3)
        Me.topInternalPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.topInternalPanel.Location = New System.Drawing.Point(0, 64)
        Me.topInternalPanel.Name = "topInternalPanel"
        Me.topInternalPanel.Size = New System.Drawing.Size(502, 120)
        Me.topInternalPanel.TabIndex = 1
        '
        'bottomPanel
        '
        Me.bottomPanel.Controls.Add(Me.okBttn)
        Me.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bottomPanel.Location = New System.Drawing.Point(0, 419)
        Me.bottomPanel.Name = "bottomPanel"
        Me.bottomPanel.Size = New System.Drawing.Size(502, 100)
        Me.bottomPanel.TabIndex = 9
        '
        'expandablePanel
        '
        Me.expandablePanel.Controls.Add(Me.useDefaultCheckBox)
        Me.expandablePanel.Controls.Add(Me.defaultLabel)
        Me.expandablePanel.Controls.Add(Me.expandButton)
        Me.expandablePanel.Controls.Add(Me.passwordTextBox)
        Me.expandablePanel.Controls.Add(Me.userNameTextBox)
        Me.expandablePanel.Controls.Add(Me.saveCheckBox)
        Me.expandablePanel.Controls.Add(Me.otherLoginRadioButton)
        Me.expandablePanel.Controls.Add(Me.windowsAuthRadioButton)
        Me.expandablePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.expandablePanel.Location = New System.Drawing.Point(0, 184)
        Me.expandablePanel.Name = "expandablePanel"
        Me.expandablePanel.Size = New System.Drawing.Size(502, 235)
        Me.expandablePanel.TabIndex = 10
        '
        'useDefaultCheckBox
        '
        Me.useDefaultCheckBox.AutoSize = True
        Me.useDefaultCheckBox.Checked = True
        Me.useDefaultCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.useDefaultCheckBox.Location = New System.Drawing.Point(62, 38)
        Me.useDefaultCheckBox.Name = "useDefaultCheckBox"
        Me.useDefaultCheckBox.Size = New System.Drawing.Size(152, 19)
        Me.useDefaultCheckBox.TabIndex = 8
        Me.useDefaultCheckBox.Text = "Use my default settings"
        Me.useDefaultCheckBox.UseVisualStyleBackColor = True
        '
        'defaultLabel
        '
        Me.defaultLabel.AutoSize = True
        Me.defaultLabel.Location = New System.Drawing.Point(233, 38)
        Me.defaultLabel.Name = "defaultLabel"
        Me.defaultLabel.Size = New System.Drawing.Size(0, 15)
        Me.defaultLabel.TabIndex = 7
        '
        'expandButton
        '
        Me.expandButton.AutoSize = True
        Me.expandButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.expandButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.expandButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.expandButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expandButton.Location = New System.Drawing.Point(4, 4)
        Me.expandButton.Name = "expandButton"
        Me.expandButton.Size = New System.Drawing.Size(25, 26)
        Me.expandButton.TabIndex = 6
        Me.expandButton.Text = "+"
        Me.expandButton.UseVisualStyleBackColor = False
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Enabled = False
        Me.passwordTextBox.Location = New System.Drawing.Point(236, 144)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.Size = New System.Drawing.Size(196, 20)
        Me.passwordTextBox.TabIndex = 5
        Me.passwordTextBox.UseSystemPasswordChar = True
        '
        'userNameTextBox
        '
        Me.userNameTextBox.Enabled = False
        Me.userNameTextBox.Location = New System.Drawing.Point(236, 118)
        Me.userNameTextBox.Name = "userNameTextBox"
        Me.userNameTextBox.Size = New System.Drawing.Size(196, 20)
        Me.userNameTextBox.TabIndex = 4
        '
        'saveCheckBox
        '
        Me.saveCheckBox.AutoSize = True
        Me.saveCheckBox.Location = New System.Drawing.Point(62, 181)
        Me.saveCheckBox.Name = "saveCheckBox"
        Me.saveCheckBox.Size = New System.Drawing.Size(399, 19)
        Me.saveCheckBox.TabIndex = 3
        Me.saveCheckBox.Text = "Save these options as my default (currently, no passwords are saved)"
        Me.saveCheckBox.UseVisualStyleBackColor = True
        '
        'otherLoginRadioButton
        '
        Me.otherLoginRadioButton.AutoSize = True
        Me.otherLoginRadioButton.Enabled = False
        Me.otherLoginRadioButton.Location = New System.Drawing.Point(118, 119)
        Me.otherLoginRadioButton.Name = "otherLoginRadioButton"
        Me.otherLoginRadioButton.Size = New System.Drawing.Size(67, 19)
        Me.otherLoginRadioButton.TabIndex = 2
        Me.otherLoginRadioButton.Text = "Custom"
        Me.otherLoginRadioButton.UseVisualStyleBackColor = True
        '
        'windowsAuthRadioButton
        '
        Me.windowsAuthRadioButton.AutoSize = True
        Me.windowsAuthRadioButton.Checked = True
        Me.windowsAuthRadioButton.Enabled = False
        Me.windowsAuthRadioButton.Location = New System.Drawing.Point(118, 71)
        Me.windowsAuthRadioButton.Name = "windowsAuthRadioButton"
        Me.windowsAuthRadioButton.Size = New System.Drawing.Size(155, 19)
        Me.windowsAuthRadioButton.TabIndex = 0
        Me.windowsAuthRadioButton.TabStop = True
        Me.windowsAuthRadioButton.Text = "Windows Authentication"
        Me.windowsAuthRadioButton.UseVisualStyleBackColor = True
        '
        'ServerPopupSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 519)
        Me.Controls.Add(Me.expandablePanel)
        Me.Controls.Add(Me.bottomPanel)
        Me.Controls.Add(Me.topPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(518, 560)
        Me.MinimumSize = New System.Drawing.Size(518, 360)
        Me.Name = "ServerPopupSelector"
        Me.Text = "ServerConnection"
        Me.topPanel.ResumeLayout(False)
        Me.topInternalPanel.ResumeLayout(False)
        Me.topInternalPanel.PerformLayout()
        Me.bottomPanel.ResumeLayout(False)
        Me.expandablePanel.ResumeLayout(False)
        Me.expandablePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents serverComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents projectComboBox As ComboBox
    Friend WithEvents okBttn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents folderComboBox As ComboBox
    Friend WithEvents topPanel As Panel
    Friend WithEvents topInternalPanel As Panel
    Friend WithEvents bottomPanel As Panel
    Friend WithEvents expandablePanel As Panel
    Friend WithEvents expandButton As Button
    Friend WithEvents passwordTextBox As TextBox
    Friend WithEvents userNameTextBox As TextBox
    Friend WithEvents saveCheckBox As CheckBox
    Friend WithEvents otherLoginRadioButton As RadioButton
    Friend WithEvents windowsAuthRadioButton As RadioButton
    Friend WithEvents defaultLabel As Label
    Friend WithEvents useDefaultCheckBox As CheckBox
End Class
