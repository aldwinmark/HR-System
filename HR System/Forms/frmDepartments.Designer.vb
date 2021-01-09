<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartments
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDepartments))
        Me.lblTotalRecord = New System.Windows.Forms.Label
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.lstvwDepartments = New System.Windows.Forms.ListView
        Me.Dept_ID = New System.Windows.Forms.ColumnHeader
        Me.Positions = New System.Windows.Forms.ColumnHeader
        Me.DepartmentDescription = New System.Windows.Forms.ColumnHeader
        Me.btnSearch = New System.Windows.Forms.Button
        Me.cmsDepartments = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EmployeeStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsDepartments.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTotalRecord
        '
        Me.lblTotalRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRecord.Location = New System.Drawing.Point(12, 437)
        Me.lblTotalRecord.Name = "lblTotalRecord"
        Me.lblTotalRecord.Size = New System.Drawing.Size(235, 23)
        Me.lblTotalRecord.TabIndex = 44
        Me.lblTotalRecord.Text = "Total record:"
        Me.lblTotalRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(13, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(350, 24)
        Me.txtSearch.TabIndex = 42
        '
        'lstvwDepartments
        '
        Me.lstvwDepartments.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Dept_ID, Me.Positions, Me.DepartmentDescription})
        Me.lstvwDepartments.ContextMenuStrip = Me.cmsDepartments
        Me.lstvwDepartments.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwDepartments.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwDepartments.FullRowSelect = True
        Me.lstvwDepartments.GridLines = True
        Me.lstvwDepartments.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwDepartments.Location = New System.Drawing.Point(13, 51)
        Me.lstvwDepartments.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstvwDepartments.MultiSelect = False
        Me.lstvwDepartments.Name = "lstvwDepartments"
        Me.lstvwDepartments.Size = New System.Drawing.Size(441, 381)
        Me.lstvwDepartments.TabIndex = 43
        Me.lstvwDepartments.UseCompatibleStateImageBehavior = False
        Me.lstvwDepartments.View = System.Windows.Forms.View.Details
        '
        'Dept_ID
        '
        Me.Dept_ID.Text = ""
        Me.Dept_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Dept_ID.Width = 0
        '
        'Positions
        '
        Me.Positions.Text = "Code"
        Me.Positions.Width = 89
        '
        'DepartmentDescription
        '
        Me.DepartmentDescription.Text = "Description"
        Me.DepartmentDescription.Width = 327
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.HR_System.My.Resources.Resources.magnifier
        Me.btnSearch.Location = New System.Drawing.Point(369, 10)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(85, 27)
        Me.btnSearch.TabIndex = 45
        Me.btnSearch.Text = "Search"
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cmsDepartments
        '
        Me.cmsDepartments.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmsDepartments.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeStatusToolStripMenuItem, Me.ToolStripSeparator1, Me.AddToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator2, Me.RefreshToolStripMenuItem})
        Me.cmsDepartments.Name = "cmsEmpStatus"
        Me.cmsDepartments.Size = New System.Drawing.Size(156, 126)
        '
        'EmployeeStatusToolStripMenuItem
        '
        Me.EmployeeStatusToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.chart_organisation
        Me.EmployeeStatusToolStripMenuItem.Name = "EmployeeStatusToolStripMenuItem"
        Me.EmployeeStatusToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.EmployeeStatusToolStripMenuItem.Text = "Departments"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(152, 6)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.AddToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.add
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.page_white_edit
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.DeleteToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.delete
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(152, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.arrow_refresh
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'frmDepartments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 475)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblTotalRecord)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lstvwDepartments)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDepartments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Departments"
        Me.cmsDepartments.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTotalRecord As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lstvwDepartments As System.Windows.Forms.ListView
    Friend WithEvents Dept_ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Positions As System.Windows.Forms.ColumnHeader
    Friend WithEvents DepartmentDescription As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents cmsDepartments As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EmployeeStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
