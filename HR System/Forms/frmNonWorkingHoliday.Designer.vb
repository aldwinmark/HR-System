<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNonWorkingHoliday
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNonWorkingHoliday))
        Me.lstvwHolidays = New System.Windows.Forms.ListView()
        Me.Holiday_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Title = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HolidayDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsNonWorkingHoliday = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ListOfEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cmsNonWorkingHoliday.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstvwHolidays
        '
        Me.lstvwHolidays.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Holiday_ID, Me.Title, Me.HolidayDate})
        Me.lstvwHolidays.ContextMenuStrip = Me.cmsNonWorkingHoliday
        Me.lstvwHolidays.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwHolidays.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwHolidays.FullRowSelect = True
        Me.lstvwHolidays.GridLines = True
        Me.lstvwHolidays.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwHolidays.Location = New System.Drawing.Point(1, 39)
        Me.lstvwHolidays.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstvwHolidays.MultiSelect = False
        Me.lstvwHolidays.Name = "lstvwHolidays"
        Me.lstvwHolidays.Size = New System.Drawing.Size(426, 473)
        Me.lstvwHolidays.TabIndex = 15
        Me.lstvwHolidays.UseCompatibleStateImageBehavior = False
        Me.lstvwHolidays.View = System.Windows.Forms.View.Details
        '
        'Holiday_ID
        '
        Me.Holiday_ID.Text = ""
        Me.Holiday_ID.Width = 0
        '
        'Title
        '
        Me.Title.Text = "Title"
        Me.Title.Width = 299
        '
        'HolidayDate
        '
        Me.HolidayDate.Text = "Date"
        Me.HolidayDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.HolidayDate.Width = 116
        '
        'cmsNonWorkingHoliday
        '
        Me.cmsNonWorkingHoliday.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmsNonWorkingHoliday.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListOfEmployeeToolStripMenuItem, Me.ToolStripSeparator1, Me.AddToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator2, Me.RefreshToolStripMenuItem})
        Me.cmsNonWorkingHoliday.Name = "cmsListOfEmployee"
        Me.cmsNonWorkingHoliday.Size = New System.Drawing.Size(214, 104)
        '
        'ListOfEmployeeToolStripMenuItem
        '
        Me.ListOfEmployeeToolStripMenuItem.Name = "ListOfEmployeeToolStripMenuItem"
        Me.ListOfEmployeeToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.ListOfEmployeeToolStripMenuItem.Text = "Non- Working Holiday"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(210, 6)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.AddToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.add
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.DeleteToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.page_white_edit
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(210, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.arrow_refresh
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(1, 9)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(350, 24)
        Me.txtSearch.TabIndex = 16
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.HR_System.My.Resources.Resources.magnifier
        Me.btnSearch.Location = New System.Drawing.Point(352, 8)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 27)
        Me.btnSearch.TabIndex = 17
        Me.btnSearch.Text = "Search"
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'frmNonWorkingHoliday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 517)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lstvwHolidays)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNonWorkingHoliday"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Non-Working Day"
        Me.cmsNonWorkingHoliday.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstvwHolidays As System.Windows.Forms.ListView
    Friend WithEvents Holiday_ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Title As System.Windows.Forms.ColumnHeader
    Friend WithEvents HolidayDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmsNonWorkingHoliday As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ListOfEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
