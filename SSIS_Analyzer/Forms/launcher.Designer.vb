<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class launcher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(launcher))
        Me.ssisViewerButton = New System.Windows.Forms.Button()
        Me.jobViewerButton = New System.Windows.Forms.Button()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.ssisViewerLabel = New System.Windows.Forms.Label()
        Me.jobViewerLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.oldViewerLabel = New System.Windows.Forms.Label()
        Me.oldViewerButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ssisViewerButton
        '
        Me.ssisViewerButton.BackColor = System.Drawing.SystemColors.Control
        Me.ssisViewerButton.BackgroundImage = CType(resources.GetObject("ssisViewerButton.BackgroundImage"), System.Drawing.Image)
        Me.ssisViewerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ssisViewerButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ssisViewerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ssisViewerButton.FlatAppearance.BorderSize = 0
        Me.ssisViewerButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ssisViewerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ssisViewerButton.Location = New System.Drawing.Point(12, 137)
        Me.ssisViewerButton.Name = "ssisViewerButton"
        Me.ssisViewerButton.Size = New System.Drawing.Size(50, 50)
        Me.ssisViewerButton.TabIndex = 1
        Me.ssisViewerButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ssisViewerButton.UseVisualStyleBackColor = False
        '
        'jobViewerButton
        '
        Me.jobViewerButton.BackColor = System.Drawing.SystemColors.Control
        Me.jobViewerButton.BackgroundImage = CType(resources.GetObject("jobViewerButton.BackgroundImage"), System.Drawing.Image)
        Me.jobViewerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.jobViewerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.jobViewerButton.FlatAppearance.BorderSize = 0
        Me.jobViewerButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow
        Me.jobViewerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.jobViewerButton.Location = New System.Drawing.Point(12, 193)
        Me.jobViewerButton.Name = "jobViewerButton"
        Me.jobViewerButton.Size = New System.Drawing.Size(50, 50)
        Me.jobViewerButton.TabIndex = 2
        Me.jobViewerButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.jobViewerButton.UseVisualStyleBackColor = False
        '
        'titleLabel
        '
        Me.titleLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.titleLabel.Font = New System.Drawing.Font("MS Outlook", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.Location = New System.Drawing.Point(0, 0)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(379, 73)
        Me.titleLabel.TabIndex = 3
        Me.titleLabel.Text = "SSIS Analyzer"
        Me.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ssisViewerLabel
        '
        Me.ssisViewerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ssisViewerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ssisViewerLabel.Location = New System.Drawing.Point(62, 137)
        Me.ssisViewerLabel.Name = "ssisViewerLabel"
        Me.ssisViewerLabel.Size = New System.Drawing.Size(299, 50)
        Me.ssisViewerLabel.TabIndex = 6
        Me.ssisViewerLabel.Text = "SSIS Package Viewer"
        Me.ssisViewerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'jobViewerLabel
        '
        Me.jobViewerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.jobViewerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jobViewerLabel.Location = New System.Drawing.Point(62, 193)
        Me.jobViewerLabel.Name = "jobViewerLabel"
        Me.jobViewerLabel.Size = New System.Drawing.Size(299, 50)
        Me.jobViewerLabel.TabIndex = 7
        Me.jobViewerLabel.Text = "Job Viewer"
        Me.jobViewerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.GitHub_Logo
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(292, 247)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'oldViewerLabel
        '
        Me.oldViewerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oldViewerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oldViewerLabel.Location = New System.Drawing.Point(62, 81)
        Me.oldViewerLabel.Name = "oldViewerLabel"
        Me.oldViewerLabel.Size = New System.Drawing.Size(299, 50)
        Me.oldViewerLabel.TabIndex = 10
        Me.oldViewerLabel.Text = "Old Viewer"
        Me.oldViewerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'oldViewerButton
        '
        Me.oldViewerButton.BackColor = System.Drawing.SystemColors.Control
        Me.oldViewerButton.BackgroundImage = CType(resources.GetObject("oldViewerButton.BackgroundImage"), System.Drawing.Image)
        Me.oldViewerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.oldViewerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.oldViewerButton.FlatAppearance.BorderSize = 0
        Me.oldViewerButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow
        Me.oldViewerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oldViewerButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.oldViewerButton.Location = New System.Drawing.Point(12, 81)
        Me.oldViewerButton.Name = "oldViewerButton"
        Me.oldViewerButton.Size = New System.Drawing.Size(50, 50)
        Me.oldViewerButton.TabIndex = 9
        Me.oldViewerButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.oldViewerButton.UseVisualStyleBackColor = False
        '
        'launcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 282)
        Me.Controls.Add(Me.oldViewerLabel)
        Me.Controls.Add(Me.oldViewerButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.jobViewerLabel)
        Me.Controls.Add(Me.ssisViewerLabel)
        Me.Controls.Add(Me.titleLabel)
        Me.Controls.Add(Me.jobViewerButton)
        Me.Controls.Add(Me.ssisViewerButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "launcher"
        Me.Text = "launcher"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ssisViewerButton As Button
    Friend WithEvents jobViewerButton As Button
    Friend WithEvents titleLabel As Label
    Friend WithEvents ssisViewerLabel As Label
    Friend WithEvents jobViewerLabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents oldViewerLabel As Label
    Friend WithEvents oldViewerButton As Button
End Class
