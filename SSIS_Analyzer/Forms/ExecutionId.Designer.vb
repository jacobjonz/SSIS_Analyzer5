<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExecutionId
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.executionDataGridView = New System.Windows.Forms.DataGridView()
        Me.isErrorTextBox = New System.Windows.Forms.TextBox()
        Me.execPathTextBox = New System.Windows.Forms.TextBox()
        Me.msgSrcNameTextBox = New System.Windows.Forms.TextBox()
        Me.msgTypeTextBox = New System.Windows.Forms.TextBox()
        Me.msgTimeTextBox = New System.Windows.Forms.TextBox()
        Me.messageTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.executionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'titleLabel
        '
        Me.titleLabel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.titleLabel.CausesValidation = False
        Me.titleLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.Location = New System.Drawing.Point(0, 0)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(911, 37)
        Me.titleLabel.TabIndex = 0
        Me.titleLabel.Text = "Execution ID: "
        Me.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(911, 505)
        Me.Panel1.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(5, 5)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.executionDataGridView)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.isErrorTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.execPathTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.msgSrcNameTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.msgTypeTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.msgTimeTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.messageTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Size = New System.Drawing.Size(901, 495)
        Me.SplitContainer1.SplitterDistance = 196
        Me.SplitContainer1.TabIndex = 1
        '
        'executionDataGridView
        '
        Me.executionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.executionDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.executionDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.executionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.471698!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.executionDataGridView.DefaultCellStyle = DataGridViewCellStyle1
        Me.executionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.executionDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.executionDataGridView.Margin = New System.Windows.Forms.Padding(0)
        Me.executionDataGridView.Name = "executionDataGridView"
        Me.executionDataGridView.ReadOnly = True
        Me.executionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.executionDataGridView.Size = New System.Drawing.Size(901, 196)
        Me.executionDataGridView.TabIndex = 0
        '
        'isErrorTextBox
        '
        Me.isErrorTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.isErrorTextBox.BackColor = System.Drawing.Color.White
        Me.isErrorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.isErrorTextBox.Location = New System.Drawing.Point(155, 263)
        Me.isErrorTextBox.Name = "isErrorTextBox"
        Me.isErrorTextBox.ReadOnly = True
        Me.isErrorTextBox.Size = New System.Drawing.Size(734, 20)
        Me.isErrorTextBox.TabIndex = 11
        '
        'execPathTextBox
        '
        Me.execPathTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.execPathTextBox.BackColor = System.Drawing.Color.White
        Me.execPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.execPathTextBox.Location = New System.Drawing.Point(155, 237)
        Me.execPathTextBox.Name = "execPathTextBox"
        Me.execPathTextBox.ReadOnly = True
        Me.execPathTextBox.Size = New System.Drawing.Size(734, 20)
        Me.execPathTextBox.TabIndex = 10
        '
        'msgSrcNameTextBox
        '
        Me.msgSrcNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.msgSrcNameTextBox.BackColor = System.Drawing.Color.White
        Me.msgSrcNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.msgSrcNameTextBox.Location = New System.Drawing.Point(155, 211)
        Me.msgSrcNameTextBox.Name = "msgSrcNameTextBox"
        Me.msgSrcNameTextBox.ReadOnly = True
        Me.msgSrcNameTextBox.Size = New System.Drawing.Size(734, 20)
        Me.msgSrcNameTextBox.TabIndex = 9
        '
        'msgTypeTextBox
        '
        Me.msgTypeTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.msgTypeTextBox.BackColor = System.Drawing.Color.White
        Me.msgTypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.msgTypeTextBox.Location = New System.Drawing.Point(155, 185)
        Me.msgTypeTextBox.Name = "msgTypeTextBox"
        Me.msgTypeTextBox.ReadOnly = True
        Me.msgTypeTextBox.Size = New System.Drawing.Size(734, 20)
        Me.msgTypeTextBox.TabIndex = 8
        '
        'msgTimeTextBox
        '
        Me.msgTimeTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.msgTimeTextBox.BackColor = System.Drawing.Color.White
        Me.msgTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.msgTimeTextBox.Location = New System.Drawing.Point(155, 160)
        Me.msgTimeTextBox.Name = "msgTimeTextBox"
        Me.msgTimeTextBox.ReadOnly = True
        Me.msgTimeTextBox.Size = New System.Drawing.Size(734, 20)
        Me.msgTimeTextBox.TabIndex = 7
        '
        'messageTextBox
        '
        Me.messageTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.messageTextBox.BackColor = System.Drawing.Color.White
        Me.messageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.messageTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.messageTextBox.Location = New System.Drawing.Point(12, 32)
        Me.messageTextBox.Name = "messageTextBox"
        Me.messageTextBox.ReadOnly = True
        Me.messageTextBox.Size = New System.Drawing.Size(877, 122)
        Me.messageTextBox.TabIndex = 6
        Me.messageTextBox.Text = ""
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.Location = New System.Drawing.Point(13, 266)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Is Error"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.Location = New System.Drawing.Point(13, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Execution path"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Message"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.Location = New System.Drawing.Point(13, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Message Source Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.Location = New System.Drawing.Point(13, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Message Type"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(13, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Message Time"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ExecutionId
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(911, 542)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.titleLabel)
        Me.Name = "ExecutionId"
        Me.Text = "Execution Report"
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.executionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents titleLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents executionDataGridView As DataGridView
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents messageTextBox As RichTextBox
    Friend WithEvents isErrorTextBox As TextBox
    Friend WithEvents execPathTextBox As TextBox
    Friend WithEvents msgSrcNameTextBox As TextBox
    Friend WithEvents msgTypeTextBox As TextBox
    Friend WithEvents msgTimeTextBox As TextBox
End Class
