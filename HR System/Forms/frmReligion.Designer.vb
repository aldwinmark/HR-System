<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReligion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReligion))
        Me.btnEnter = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.lstvwReligion = New System.Windows.Forms.ListView
        Me.Reg_ID = New System.Windows.Forms.ColumnHeader
        Me.Religion = New System.Windows.Forms.ColumnHeader
        Me.cmsReligion = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EmployeeStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.txtReligion = New System.Windows.Forms.TextBox
        Me.cmsReligion.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.Color.Navy
        Me.btnEnter.Location = New System.Drawing.Point(226, 324)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 36)
        Me.btnEnter.TabIndex = 5
        Me.btnEnter.Text = "&Save"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(307, 324)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 36)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 263)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 18)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Religion"
        '
        'lstvwReligion
        '
        Me.lstvwReligion.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Reg_ID, Me.Religion})
        Me.lstvwReligion.ContextMenuStrip = Me.cmsReligion
        Me.lstvwReligion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwReligion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwReligion.FullRowSelect = True
        Me.lstvwReligion.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwReligion.Location = New System.Drawing.Point(13, 14)
        Me.lstvwReligion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstvwReligion.MultiSelect = False
        Me.lstvwReligion.Name = "lstvwReligion"
        Me.lstvwReligion.Size = New System.Drawing.Size(369, 234)
        Me.lstvwReligion.TabIndex = 36
        Me.lstvwReligion.UseCompatibleStateImageBehavior = False
        Me.lstvwReligion.View = System.Windows.Forms.View.Details
        '
        'Reg_ID
        '
        Me.Reg_ID.Text = ""
        Me.Reg_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Reg_ID.Width = 0
        '
        'Religion
        '
        Me.Religion.Text = "Religion"
        Me.Religion.Width = 351
        '
        'cmsReligion
        '
        Me.cmsReligion.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmsReligion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeStatusToolStripMenuItem, Me.ToolStripSeparator1, Me.AddToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator2, Me.RefreshToolStripMenuItem})
        Me.cmsReligion.Name = "cmsEmpStatus"
        Me.cmsReligion.Size = New System.Drawing.Size(125, 126)
        '
        'EmployeeStatusToolStripMenuItem
        '
        Me.EmployeeStatusToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.user_silhouette
        Me.EmployeeStatusToolStripMenuItem.Name = "EmployeeStatusToolStripMenuItem"
        Me.EmployeeStatusToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.EmployeeStatusToolStripMenuItem.Text = "Religion"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(121, 6)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.AddToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.add
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.page_white_edit
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.DeleteToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.delete
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(121, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.arrow_refresh
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'txtReligion
        '
        Me.txtReligion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReligion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReligion.Location = New System.Drawing.Point(11, 284)
        Me.txtReligion.Name = "txtReligion"
        Me.txtReligion.Size = New System.Drawing.Size(362, 24)
        Me.txtReligion.TabIndex = 37
        '
        'frmReligion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 375)
        Me.Controls.Add(Me.txtReligion)
        Me.Controls.Add(Me.lstvwReligion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReligion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Religion"
        Me.cmsReligion.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstvwReligion As System.Windows.Forms.ListView
    Friend WithEvents Reg_ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Religion As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmsReligion As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EmployeeStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtReligion As System.Windows.Forms.TextBox
End Class
