<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkSchedule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWorkSchedule))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lstvwEmployee = New System.Windows.Forms.ListView
        Me.Work_ID = New System.Windows.Forms.ColumnHeader
        Me.Employee_ID = New System.Windows.Forms.ColumnHeader
        Me.Day = New System.Windows.Forms.ColumnHeader
        Me.StartTime = New System.Windows.Forms.ColumnHeader
        Me.EndTime = New System.Windows.Forms.ColumnHeader
        Me.cmsWorkSchedule = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ListOfEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsWorkSchedule.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 36)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(361, 26)
        Me.ComboBox1.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 18)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Search Employee name"
        '
        'lstvwEmployee
        '
        Me.lstvwEmployee.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Work_ID, Me.Employee_ID, Me.Day, Me.StartTime, Me.EndTime})
        Me.lstvwEmployee.ContextMenuStrip = Me.cmsWorkSchedule
        Me.lstvwEmployee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwEmployee.FullRowSelect = True
        Me.lstvwEmployee.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwEmployee.Location = New System.Drawing.Point(13, 70)
        Me.lstvwEmployee.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstvwEmployee.MultiSelect = False
        Me.lstvwEmployee.Name = "lstvwEmployee"
        Me.lstvwEmployee.Size = New System.Drawing.Size(718, 359)
        Me.lstvwEmployee.TabIndex = 14
        Me.lstvwEmployee.UseCompatibleStateImageBehavior = False
        Me.lstvwEmployee.View = System.Windows.Forms.View.Details
        '
        'Work_ID
        '
        Me.Work_ID.Text = ""
        Me.Work_ID.Width = 0
        '
        'Employee_ID
        '
        Me.Employee_ID.Text = "ID Number"
        Me.Employee_ID.Width = 0
        '
        'Day
        '
        Me.Day.Text = "Day"
        Me.Day.Width = 248
        '
        'StartTime
        '
        Me.StartTime.Text = "Start time"
        Me.StartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.StartTime.Width = 150
        '
        'EndTime
        '
        Me.EndTime.Text = "End time"
        Me.EndTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.EndTime.Width = 150
        '
        'cmsWorkSchedule
        '
        Me.cmsWorkSchedule.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmsWorkSchedule.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListOfEmployeeToolStripMenuItem, Me.ToolStripSeparator1, Me.AddToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator2, Me.RefreshToolStripMenuItem})
        Me.cmsWorkSchedule.Name = "cmsListOfEmployee"
        Me.cmsWorkSchedule.Size = New System.Drawing.Size(168, 148)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(164, 6)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(164, 6)
        '
        'ListOfEmployeeToolStripMenuItem
        '
        Me.ListOfEmployeeToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.calendar_1
        Me.ListOfEmployeeToolStripMenuItem.Name = "ListOfEmployeeToolStripMenuItem"
        Me.ListOfEmployeeToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ListOfEmployeeToolStripMenuItem.Text = "Work Schedule"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.AddToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.add
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.delete
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.DeleteToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.page_white_edit
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.arrow_refresh
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'frmWorkSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 443)
        Me.Controls.Add(Me.lstvwEmployee)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWorkSchedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Work Schedule"
        Me.cmsWorkSchedule.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lstvwEmployee As System.Windows.Forms.ListView
    Friend WithEvents Work_ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Employee_ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Day As System.Windows.Forms.ColumnHeader
    Friend WithEvents StartTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents EndTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmsWorkSchedule As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ListOfEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
