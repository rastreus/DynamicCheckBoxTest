<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
		Me.pnlMain = New System.Windows.Forms.Panel()
		Me.btnCreate = New System.Windows.Forms.Button()
		Me.btnDelete = New System.Windows.Forms.Button()
		Me.cbSelectAll = New System.Windows.Forms.CheckBox()
		Me.SuspendLayout()
		'
		'pnlMain
		'
		Me.pnlMain.BackColor = System.Drawing.SystemColors.ControlDark
		Me.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlMain.ForeColor = System.Drawing.Color.White
		Me.pnlMain.Location = New System.Drawing.Point(12, 11)
		Me.pnlMain.Name = "pnlMain"
		Me.pnlMain.Size = New System.Drawing.Size(181, 172)
		Me.pnlMain.TabIndex = 0
		'
		'btnCreate
		'
		Me.btnCreate.BackColor = System.Drawing.Color.DarkGreen
		Me.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.btnCreate.FlatAppearance.BorderSize = 2
		Me.btnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
		Me.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
		Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnCreate.ForeColor = System.Drawing.Color.Lime
		Me.btnCreate.Location = New System.Drawing.Point(12, 208)
		Me.btnCreate.Name = "btnCreate"
		Me.btnCreate.Size = New System.Drawing.Size(87, 23)
		Me.btnCreate.TabIndex = 1
		Me.btnCreate.Text = "Create"
		Me.btnCreate.UseVisualStyleBackColor = False
		'
		'btnDelete
		'
		Me.btnDelete.BackColor = System.Drawing.Color.Maroon
		Me.btnDelete.Enabled = False
		Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.btnDelete.FlatAppearance.BorderSize = 2
		Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.HotPink
		Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
		Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnDelete.ForeColor = System.Drawing.Color.HotPink
		Me.btnDelete.Location = New System.Drawing.Point(106, 208)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(87, 23)
		Me.btnDelete.TabIndex = 2
		Me.btnDelete.UseVisualStyleBackColor = False
		'
		'cbSelectAll
		'
		Me.cbSelectAll.AutoSize = True
		Me.cbSelectAll.BackColor = System.Drawing.Color.Transparent
		Me.cbSelectAll.Enabled = False
		Me.cbSelectAll.ForeColor = System.Drawing.Color.White
		Me.cbSelectAll.Location = New System.Drawing.Point(17, 188)
		Me.cbSelectAll.Name = "cbSelectAll"
		Me.cbSelectAll.Size = New System.Drawing.Size(86, 17)
		Me.cbSelectAll.TabIndex = 3
		Me.cbSelectAll.Text = "Select All"
		Me.cbSelectAll.UseVisualStyleBackColor = False
		Me.cbSelectAll.Visible = False
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
		Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.ClientSize = New System.Drawing.Size(208, 240)
		Me.Controls.Add(Me.cbSelectAll)
		Me.Controls.Add(Me.btnDelete)
		Me.Controls.Add(Me.btnCreate)
		Me.Controls.Add(Me.pnlMain)
		Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.MaximizeBox = False
		Me.Name = "frmMain"
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.Text = "DynamicCheckBoxTest"
		Me.TopMost = True
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Private WithEvents pnlMain As System.Windows.Forms.Panel
	Private WithEvents btnCreate As System.Windows.Forms.Button
	Private WithEvents btnDelete As System.Windows.Forms.Button
	Friend WithEvents cbSelectAll As System.Windows.Forms.CheckBox

End Class
