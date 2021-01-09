<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDailyTimeRecord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDailyTimeRecord))
        Me.lstvwDTR = New System.Windows.Forms.ListView()
        Me.DTR_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DTR_Date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DTRTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DTR_AMPM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Count = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.InOut = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsDailyTimeRecord = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ListOfEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.cmbxEmployee = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmsDailyTimeRecord.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstvwDTR
        '
        Me.lstvwDTR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstvwDTR.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.DTR_ID, Me.DTR_Date, Me.DTRTime, Me.DTR_AMPM, Me.Count, Me.InOut})
        Me.lstvwDTR.ContextMenuStrip = Me.cmsDailyTimeRecord
        Me.lstvwDTR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwDTR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwDTR.FullRowSelect = True
        Me.lstvwDTR.GridLines = True
        Me.lstvwDTR.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwDTR.Location = New System.Drawing.Point(3, 75)
        Me.lstvwDTR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstvwDTR.MultiSelect = False
        Me.lstvwDTR.Name = "lstvwDTR"
        Me.lstvwDTR.Size = New System.Drawing.Size(888, 381)
        Me.lstvwDTR.TabIndex = 17
        Me.lstvwDTR.UseCompatibleStateImageBehavior = False
        Me.lstvwDTR.View = System.Windows.Forms.View.Details
        '
        'DTR_ID
        '
        Me.DTR_ID.Text = ""
        Me.DTR_ID.Width = 0
        '
        'DTR_Date
        '
        Me.DTR_Date.Text = "Date"
        Me.DTR_Date.Width = 280
        '
        'DTRTime
        '
        Me.DTRTime.Text = "Time"
        Me.DTRTime.Width = 100
        '
        'DTR_AMPM
        '
        Me.DTR_AMPM.Text = ""
        Me.DTR_AMPM.Width = 50
        '
        'Count
        '
        Me.Count.Text = "Count"
        Me.Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Count.Width = 213
        '
        'InOut
        '
        Me.InOut.Text = "InOut"
        Me.InOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InOut.Width = 175
        '
        'cmsDailyTimeRecord
        '
        Me.cmsDailyTimeRecord.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmsDailyTimeRecord.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListOfEmployeeToolStripMenuItem, Me.ToolStripSeparator1, Me.AddToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator2, Me.RefreshToolStripMenuItem})
        Me.cmsDailyTimeRecord.Name = "cmsListOfEmployee"
        Me.cmsDailyTimeRecord.Size = New System.Drawing.Size(185, 148)
        '
        'ListOfEmployeeToolStripMenuItem
        '
        Me.ListOfEmployeeToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.Clock
        Me.ListOfEmployeeToolStripMenuItem.Name = "ListOfEmployeeToolStripMenuItem"
        Me.ListOfEmployeeToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ListOfEmployeeToolStripMenuItem.Text = "Daily Time Record"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(181, 6)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.AddToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.add
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.delete
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        Me.EditToolStripMenuItem.Visible = False
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.DeleteToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.page_white_edit
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(181, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.arrow_refresh
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'dtpStart
        '
        Me.dtpStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStart.Location = New System.Drawing.Point(624, 38)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(116, 24)
        Me.dtpStart.TabIndex = 18
        '
        'dtpEnd
        '
        Me.dtpEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEnd.Location = New System.Drawing.Point(775, 39)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(116, 24)
        Me.dtpEnd.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(746, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 18)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "to"
        '
        'btnGo
        '
        Me.btnGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.Image = Global.HR_System.My.Resources.Resources.magnifier
        Me.btnGo.Location = New System.Drawing.Point(429, 36)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 27)
        Me.btnGo.TabIndex = 21
        Me.btnGo.Text = "Go"
        Me.btnGo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'cmbxEmployee
        '
        Me.cmbxEmployee.DropDownHeight = 100
        Me.cmbxEmployee.DropDownWidth = 500
        Me.cmbxEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxEmployee.FormattingEnabled = True
        Me.cmbxEmployee.IntegralHeight = False
        Me.cmbxEmployee.ItemHeight = 18
        Me.cmbxEmployee.Location = New System.Drawing.Point(3, 36)
        Me.cmbxEmployee.MaxDropDownItems = 10
        Me.cmbxEmployee.Name = "cmbxEmployee"
        Me.cmbxEmployee.Size = New System.Drawing.Size(420, 26)
        Me.cmbxEmployee.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(257, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 18)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Search Employee name"
        '
        'frmDailyTimeRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(893, 484)
        Me.Controls.Add(Me.dtpEnd)
        Me.Controls.Add(Me.lstvwDTR)
        Me.Controls.Add(Me.cmbxEmployee)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.dtpStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDailyTimeRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daily Time Record Edit"
        Me.cmsDailyTimeRecord.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstvwDTR As System.Windows.Forms.ListView
    Friend WithEvents DTR_ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents DTR_Date As System.Windows.Forms.ColumnHeader
    Friend WithEvents Count As System.Windows.Forms.ColumnHeader
    Friend WithEvents InOut As System.Windows.Forms.ColumnHeader
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents cmbxEmployee As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmsDailyTimeRecord As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ListOfEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DTRTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents DTR_AMPM As System.Windows.Forms.ColumnHeader
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
