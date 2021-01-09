<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListEmployees
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListEmployees))
        Me.lstvwEmployee = New System.Windows.Forms.ListView()
        Me.Emp_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Employee_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EmployeeName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Department = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Position = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tmpDepartment = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tmpPosition = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsListOfEmployee = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ListOfEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblTotalRecord = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rbtnPIN = New System.Windows.Forms.RadioButton()
        Me.rbtnEmployeeName = New System.Windows.Forms.RadioButton()
        Me.cmbxDepartment = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbxEmploymentStatus = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnDeActivate = New System.Windows.Forms.Button()
        Me.Activation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsListOfEmployee.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstvwEmployee
        '
        Me.lstvwEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstvwEmployee.CheckBoxes = True
        Me.lstvwEmployee.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Emp_ID, Me.Employee_ID, Me.EmployeeName, Me.Status, Me.Department, Me.Position, Me.tmpDepartment, Me.tmpPosition, Me.Activation})
        Me.lstvwEmployee.ContextMenuStrip = Me.cmsListOfEmployee
        Me.lstvwEmployee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwEmployee.FullRowSelect = True
        Me.lstvwEmployee.GridLines = True
        Me.lstvwEmployee.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwEmployee.Location = New System.Drawing.Point(4, 74)
        Me.lstvwEmployee.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstvwEmployee.MultiSelect = False
        Me.lstvwEmployee.Name = "lstvwEmployee"
        Me.lstvwEmployee.Size = New System.Drawing.Size(1003, 354)
        Me.lstvwEmployee.TabIndex = 2
        Me.lstvwEmployee.UseCompatibleStateImageBehavior = False
        Me.lstvwEmployee.View = System.Windows.Forms.View.Details
        '
        'Emp_ID
        '
        Me.Emp_ID.Text = ""
        Me.Emp_ID.Width = 20
        '
        'Employee_ID
        '
        Me.Employee_ID.Text = "ID Number"
        Me.Employee_ID.Width = 106
        '
        'EmployeeName
        '
        Me.EmployeeName.Text = "Employee Name"
        Me.EmployeeName.Width = 348
        '
        'Status
        '
        Me.Status.Text = "Status"
        Me.Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Status.Width = 170
        '
        'Department
        '
        Me.Department.Text = "Department"
        Me.Department.Width = 157
        '
        'Position
        '
        Me.Position.Text = "Position"
        Me.Position.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Position.Width = 199
        '
        'tmpDepartment
        '
        Me.tmpDepartment.Width = 0
        '
        'tmpPosition
        '
        Me.tmpPosition.Text = ""
        Me.tmpPosition.Width = 0
        '
        'cmsListOfEmployee
        '
        Me.cmsListOfEmployee.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmsListOfEmployee.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListOfEmployeeToolStripMenuItem, Me.ToolStripSeparator1, Me.AddToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator2, Me.RefreshToolStripMenuItem})
        Me.cmsListOfEmployee.Name = "cmsListOfEmployee"
        Me.cmsListOfEmployee.Size = New System.Drawing.Size(176, 126)
        '
        'ListOfEmployeeToolStripMenuItem
        '
        Me.ListOfEmployeeToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.doc_table
        Me.ListOfEmployeeToolStripMenuItem.Name = "ListOfEmployeeToolStripMenuItem"
        Me.ListOfEmployeeToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ListOfEmployeeToolStripMenuItem.Text = "List of Employee"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(172, 6)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.add
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.delete
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.DeleteToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.page_white_edit
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(172, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.arrow_refresh
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'lblTotalRecord
        '
        Me.lblTotalRecord.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRecord.ForeColor = System.Drawing.Color.White
        Me.lblTotalRecord.Location = New System.Drawing.Point(1, 433)
        Me.lblTotalRecord.Name = "lblTotalRecord"
        Me.lblTotalRecord.Size = New System.Drawing.Size(235, 23)
        Me.lblTotalRecord.TabIndex = 3
        Me.lblTotalRecord.Text = "Total record:"
        Me.lblTotalRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(4, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(350, 24)
        Me.txtSearch.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.rbtnPIN)
        Me.GroupBox6.Controls.Add(Me.rbtnEmployeeName)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.White
        Me.GroupBox6.Location = New System.Drawing.Point(832, -2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(175, 67)
        Me.GroupBox6.TabIndex = 33
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Search  By:"
        '
        'rbtnPIN
        '
        Me.rbtnPIN.AutoSize = True
        Me.rbtnPIN.Checked = True
        Me.rbtnPIN.ForeColor = System.Drawing.Color.White
        Me.rbtnPIN.Location = New System.Drawing.Point(15, 20)
        Me.rbtnPIN.Name = "rbtnPIN"
        Me.rbtnPIN.Size = New System.Drawing.Size(149, 22)
        Me.rbtnPIN.TabIndex = 0
        Me.rbtnPIN.TabStop = True
        Me.rbtnPIN.Text = "Employee Number"
        Me.rbtnPIN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.rbtnPIN.UseVisualStyleBackColor = True
        '
        'rbtnEmployeeName
        '
        Me.rbtnEmployeeName.AutoSize = True
        Me.rbtnEmployeeName.ForeColor = System.Drawing.Color.White
        Me.rbtnEmployeeName.Location = New System.Drawing.Point(15, 42)
        Me.rbtnEmployeeName.Name = "rbtnEmployeeName"
        Me.rbtnEmployeeName.Size = New System.Drawing.Size(133, 22)
        Me.rbtnEmployeeName.TabIndex = 1
        Me.rbtnEmployeeName.Text = "Employee name"
        Me.rbtnEmployeeName.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.rbtnEmployeeName.UseVisualStyleBackColor = True
        '
        'cmbxDepartment
        '
        Me.cmbxDepartment.DropDownHeight = 90
        Me.cmbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxDepartment.FormattingEnabled = True
        Me.cmbxDepartment.IntegralHeight = False
        Me.cmbxDepartment.Location = New System.Drawing.Point(598, 8)
        Me.cmbxDepartment.MaxDropDownItems = 5
        Me.cmbxDepartment.Name = "cmbxDepartment"
        Me.cmbxDepartment.Size = New System.Drawing.Size(228, 24)
        Me.cmbxDepartment.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(507, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 18)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Department"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(455, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 18)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Employment Status"
        '
        'cmbxEmploymentStatus
        '
        Me.cmbxEmploymentStatus.DropDownHeight = 70
        Me.cmbxEmploymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxEmploymentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxEmploymentStatus.FormattingEnabled = True
        Me.cmbxEmploymentStatus.IntegralHeight = False
        Me.cmbxEmploymentStatus.Items.AddRange(New Object() {"All", "Regular", "Contractual"})
        Me.cmbxEmploymentStatus.Location = New System.Drawing.Point(598, 39)
        Me.cmbxEmploymentStatus.MaxDropDownItems = 5
        Me.cmbxEmploymentStatus.Name = "cmbxEmploymentStatus"
        Me.cmbxEmploymentStatus.Size = New System.Drawing.Size(228, 24)
        Me.cmbxEmploymentStatus.TabIndex = 36
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.HR_System.My.Resources.Resources.magnifier
        Me.btnSearch.Location = New System.Drawing.Point(360, 10)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(85, 27)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnDeActivate
        '
        Me.btnDeActivate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeActivate.Location = New System.Drawing.Point(4, 39)
        Me.btnDeActivate.Name = "btnDeActivate"
        Me.btnDeActivate.Size = New System.Drawing.Size(91, 23)
        Me.btnDeActivate.TabIndex = 38
        Me.btnDeActivate.Text = "De-Activate"
        Me.btnDeActivate.UseVisualStyleBackColor = True
        '
        'Activation
        '
        Me.Activation.Text = ""
        Me.Activation.Width = 50
        '
        'frmListEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1011, 455)
        Me.Controls.Add(Me.btnDeActivate)
        Me.Controls.Add(Me.lstvwEmployee)
        Me.Controls.Add(Me.lblTotalRecord)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.cmbxDepartment)
        Me.Controls.Add(Me.cmbxEmploymentStatus)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListEmployees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List of Employee"
        Me.cmsListOfEmployee.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstvwEmployee As System.Windows.Forms.ListView
    Friend WithEvents Emp_ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Employee_ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Password As System.Windows.Forms.ColumnHeader
    Friend WithEvents Status As System.Windows.Forms.ColumnHeader
    Friend WithEvents Department As System.Windows.Forms.ColumnHeader
    Friend WithEvents Position As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblTotalRecord As System.Windows.Forms.Label
    Friend WithEvents EmpName As System.Windows.Forms.ColumnHeader
    Friend WithEvents EmployeeName As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmsListOfEmployee As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ListOfEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents tmpDepartment As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnPIN As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnEmployeeName As System.Windows.Forms.RadioButton
    Friend WithEvents cmbxDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbxEmploymentStatus As System.Windows.Forms.ComboBox
    Friend WithEvents tmpPosition As System.Windows.Forms.ColumnHeader
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDeActivate As System.Windows.Forms.Button
    Friend WithEvents Activation As System.Windows.Forms.ColumnHeader
End Class
