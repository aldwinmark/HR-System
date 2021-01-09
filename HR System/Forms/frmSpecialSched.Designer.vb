<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpecialSched
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSpecialSched))
        Me.lstvwEspsSched = New System.Windows.Forms.ListView
        Me.colmnPin = New System.Windows.Forms.ColumnHeader
        Me.colmnName = New System.Windows.Forms.ColumnHeader
        Me.colmnDepartment = New System.Windows.Forms.ColumnHeader
        Me.colmnStatus = New System.Windows.Forms.ColumnHeader
        Me.lblEmpName = New System.Windows.Forms.Label
        Me.lblEmpId = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.mtxtTimeOut = New System.Windows.Forms.MaskedTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.mtxtTimeIn = New System.Windows.Forms.MaskedTextBox
        Me.pnMain = New System.Windows.Forms.Panel
        Me.btnEdit = New System.Windows.Forms.Button
        Me.lblTotalRecord = New System.Windows.Forms.Label
        Me.mtxtSearch = New System.Windows.Forms.MaskedTextBox
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.pnSearch = New System.Windows.Forms.Panel
        Me.btnClose = New System.Windows.Forms.Button
        Me.mtxtSearchInput = New System.Windows.Forms.MaskedTextBox
        Me.lstvwSearch = New System.Windows.Forms.ListView
        Me.clomnEmpId = New System.Windows.Forms.ColumnHeader
        Me.colmnSearchName = New System.Windows.Forms.ColumnHeader
        Me.pnEdit = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnDeleteDay = New System.Windows.Forms.Button
        Me.grpbxDay = New System.Windows.Forms.GroupBox
        Me.lstvwEspDays = New System.Windows.Forms.ListView
        Me.colmnId = New System.Windows.Forms.ColumnHeader
        Me.colmnPINDays = New System.Windows.Forms.ColumnHeader
        Me.colmnDay = New System.Windows.Forms.ColumnHeader
        Me.colmnTimeIn = New System.Windows.Forms.ColumnHeader
        Me.colmnTimeOut = New System.Windows.Forms.ColumnHeader
        Me.cmsDays = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SundayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.MondayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TuesdayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WednesdayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ThursdayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FridayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.SaturdayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnCloseDay = New System.Windows.Forms.Button
        Me.btnAddDay = New System.Windows.Forms.Button
        Me.pnMain.SuspendLayout()
        Me.pnSearch.SuspendLayout()
        Me.pnEdit.SuspendLayout()
        Me.grpbxDay.SuspendLayout()
        Me.cmsDays.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstvwEspsSched
        '
        Me.lstvwEspsSched.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colmnPin, Me.colmnName, Me.colmnDepartment, Me.colmnStatus})
        Me.lstvwEspsSched.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwEspsSched.FullRowSelect = True
        Me.lstvwEspsSched.Location = New System.Drawing.Point(0, 57)
        Me.lstvwEspsSched.Name = "lstvwEspsSched"
        Me.lstvwEspsSched.Size = New System.Drawing.Size(748, 363)
        Me.lstvwEspsSched.TabIndex = 6
        Me.lstvwEspsSched.TabStop = False
        Me.lstvwEspsSched.UseCompatibleStateImageBehavior = False
        Me.lstvwEspsSched.View = System.Windows.Forms.View.Details
        '
        'colmnPin
        '
        Me.colmnPin.Text = ""
        Me.colmnPin.Width = 91
        '
        'colmnName
        '
        Me.colmnName.Text = "Name"
        Me.colmnName.Width = 282
        '
        'colmnDepartment
        '
        Me.colmnDepartment.Text = "Department"
        Me.colmnDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colmnDepartment.Width = 166
        '
        'colmnStatus
        '
        Me.colmnStatus.Text = "Status"
        Me.colmnStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colmnStatus.Width = 118
        '
        'lblEmpName
        '
        Me.lblEmpName.BackColor = System.Drawing.Color.Transparent
        Me.lblEmpName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpName.ForeColor = System.Drawing.Color.Yellow
        Me.lblEmpName.Location = New System.Drawing.Point(116, 37)
        Me.lblEmpName.Name = "lblEmpName"
        Me.lblEmpName.Size = New System.Drawing.Size(166, 19)
        Me.lblEmpName.TabIndex = 9
        Me.lblEmpName.Text = "lblEmpName"
        Me.lblEmpName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmpId
        '
        Me.lblEmpId.BackColor = System.Drawing.Color.Transparent
        Me.lblEmpId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpId.ForeColor = System.Drawing.Color.Yellow
        Me.lblEmpId.Location = New System.Drawing.Point(116, 16)
        Me.lblEmpId.Name = "lblEmpId"
        Me.lblEmpId.Size = New System.Drawing.Size(169, 19)
        Me.lblEmpId.TabIndex = 3
        Me.lblEmpId.Text = "lblEmpId"
        Me.lblEmpId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(152, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Time-Out:"
        '
        'mtxtTimeOut
        '
        Me.mtxtTimeOut.Enabled = False
        Me.mtxtTimeOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtTimeOut.Location = New System.Drawing.Point(220, 17)
        Me.mtxtTimeOut.Mask = "90:00"
        Me.mtxtTimeOut.Name = "mtxtTimeOut"
        Me.mtxtTimeOut.Size = New System.Drawing.Size(77, 22)
        Me.mtxtTimeOut.TabIndex = 6
        Me.mtxtTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(18, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Time-In:"
        '
        'mtxtTimeIn
        '
        Me.mtxtTimeIn.Enabled = False
        Me.mtxtTimeIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtTimeIn.Location = New System.Drawing.Point(75, 17)
        Me.mtxtTimeIn.Mask = "90:00"
        Me.mtxtTimeIn.Name = "mtxtTimeIn"
        Me.mtxtTimeIn.Size = New System.Drawing.Size(77, 22)
        Me.mtxtTimeIn.TabIndex = 4
        Me.mtxtTimeIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnMain
        '
        Me.pnMain.BackColor = System.Drawing.Color.Transparent
        Me.pnMain.Controls.Add(Me.btnEdit)
        Me.pnMain.Controls.Add(Me.lblTotalRecord)
        Me.pnMain.Controls.Add(Me.mtxtSearch)
        Me.pnMain.Controls.Add(Me.btnDelete)
        Me.pnMain.Controls.Add(Me.btnAdd)
        Me.pnMain.Controls.Add(Me.lstvwEspsSched)
        Me.pnMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnMain.Location = New System.Drawing.Point(0, 0)
        Me.pnMain.Name = "pnMain"
        Me.pnMain.Size = New System.Drawing.Size(748, 484)
        Me.pnMain.TabIndex = 11
        '
        'btnEdit
        '
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Image = Global.HR_System.My.Resources.Resources.page_white_edit
        Me.btnEdit.Location = New System.Drawing.Point(350, 427)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(86, 45)
        Me.btnEdit.TabIndex = 15
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'lblTotalRecord
        '
        Me.lblTotalRecord.AutoSize = True
        Me.lblTotalRecord.Location = New System.Drawing.Point(3, 427)
        Me.lblTotalRecord.Name = "lblTotalRecord"
        Me.lblTotalRecord.Size = New System.Drawing.Size(74, 13)
        Me.lblTotalRecord.TabIndex = 14
        Me.lblTotalRecord.Text = "Total Records"
        '
        'mtxtSearch
        '
        Me.mtxtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtSearch.Location = New System.Drawing.Point(65, 27)
        Me.mtxtSearch.Name = "mtxtSearch"
        Me.mtxtSearch.Size = New System.Drawing.Size(224, 24)
        Me.mtxtSearch.TabIndex = 0
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Image = Global.HR_System.My.Resources.Resources.delete
        Me.btnDelete.Location = New System.Drawing.Point(442, 427)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(86, 45)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Image = Global.HR_System.My.Resources.Resources.add
        Me.btnAdd.Location = New System.Drawing.Point(258, 427)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(86, 45)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'pnSearch
        '
        Me.pnSearch.BackColor = System.Drawing.Color.Red
        Me.pnSearch.BackgroundImage = CType(resources.GetObject("pnSearch.BackgroundImage"), System.Drawing.Image)
        Me.pnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnSearch.Controls.Add(Me.btnClose)
        Me.pnSearch.Controls.Add(Me.mtxtSearchInput)
        Me.pnSearch.Controls.Add(Me.lstvwSearch)
        Me.pnSearch.Location = New System.Drawing.Point(230, 113)
        Me.pnSearch.Name = "pnSearch"
        Me.pnSearch.Size = New System.Drawing.Size(284, 191)
        Me.pnSearch.TabIndex = 12
        Me.pnSearch.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = Global.HR_System.My.Resources.Resources.cross_octagon_fram
        Me.btnClose.Location = New System.Drawing.Point(255, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(26, 23)
        Me.btnClose.TabIndex = 14
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'mtxtSearchInput
        '
        Me.mtxtSearchInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mtxtSearchInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtSearchInput.Location = New System.Drawing.Point(3, 6)
        Me.mtxtSearchInput.Name = "mtxtSearchInput"
        Me.mtxtSearchInput.Size = New System.Drawing.Size(224, 24)
        Me.mtxtSearchInput.TabIndex = 12
        '
        'lstvwSearch
        '
        Me.lstvwSearch.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clomnEmpId, Me.colmnSearchName})
        Me.lstvwSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwSearch.FullRowSelect = True
        Me.lstvwSearch.Location = New System.Drawing.Point(3, 33)
        Me.lstvwSearch.MultiSelect = False
        Me.lstvwSearch.Name = "lstvwSearch"
        Me.lstvwSearch.Size = New System.Drawing.Size(278, 155)
        Me.lstvwSearch.TabIndex = 7
        Me.lstvwSearch.UseCompatibleStateImageBehavior = False
        Me.lstvwSearch.View = System.Windows.Forms.View.Details
        '
        'clomnEmpId
        '
        Me.clomnEmpId.Text = ""
        Me.clomnEmpId.Width = 67
        '
        'colmnSearchName
        '
        Me.colmnSearchName.Text = "Name"
        Me.colmnSearchName.Width = 185
        '
        'pnEdit
        '
        Me.pnEdit.BackColor = System.Drawing.Color.Red
        Me.pnEdit.BackgroundImage = CType(resources.GetObject("pnEdit.BackgroundImage"), System.Drawing.Image)
        Me.pnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnEdit.Controls.Add(Me.Label4)
        Me.pnEdit.Controls.Add(Me.Label1)
        Me.pnEdit.Controls.Add(Me.btnDeleteDay)
        Me.pnEdit.Controls.Add(Me.grpbxDay)
        Me.pnEdit.Controls.Add(Me.lblEmpName)
        Me.pnEdit.Controls.Add(Me.lstvwEspDays)
        Me.pnEdit.Controls.Add(Me.lblEmpId)
        Me.pnEdit.Controls.Add(Me.btnCloseDay)
        Me.pnEdit.Controls.Add(Me.btnAddDay)
        Me.pnEdit.Location = New System.Drawing.Point(230, 74)
        Me.pnEdit.Name = "pnEdit"
        Me.pnEdit.Size = New System.Drawing.Size(333, 338)
        Me.pnEdit.TabIndex = 13
        Me.pnEdit.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(7, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Employee name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(30, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Employee Id:"
        '
        'btnDeleteDay
        '
        Me.btnDeleteDay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteDay.Enabled = False
        Me.btnDeleteDay.Image = Global.HR_System.My.Resources.Resources.delete
        Me.btnDeleteDay.Location = New System.Drawing.Point(247, 287)
        Me.btnDeleteDay.Name = "btnDeleteDay"
        Me.btnDeleteDay.Size = New System.Drawing.Size(75, 46)
        Me.btnDeleteDay.TabIndex = 20
        Me.btnDeleteDay.Text = "&Delete day"
        Me.btnDeleteDay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDeleteDay.UseVisualStyleBackColor = True
        '
        'grpbxDay
        '
        Me.grpbxDay.BackColor = System.Drawing.Color.Transparent
        Me.grpbxDay.Controls.Add(Me.mtxtTimeOut)
        Me.grpbxDay.Controls.Add(Me.mtxtTimeIn)
        Me.grpbxDay.Controls.Add(Me.Label2)
        Me.grpbxDay.Controls.Add(Me.Label3)
        Me.grpbxDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxDay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grpbxDay.Location = New System.Drawing.Point(15, 232)
        Me.grpbxDay.Name = "grpbxDay"
        Me.grpbxDay.Size = New System.Drawing.Size(303, 49)
        Me.grpbxDay.TabIndex = 19
        Me.grpbxDay.TabStop = False
        Me.grpbxDay.Text = "Day"
        '
        'lstvwEspDays
        '
        Me.lstvwEspDays.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lstvwEspDays.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colmnId, Me.colmnPINDays, Me.colmnDay, Me.colmnTimeIn, Me.colmnTimeOut})
        Me.lstvwEspDays.ContextMenuStrip = Me.cmsDays
        Me.lstvwEspDays.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwEspDays.FullRowSelect = True
        Me.lstvwEspDays.Location = New System.Drawing.Point(10, 65)
        Me.lstvwEspDays.Name = "lstvwEspDays"
        Me.lstvwEspDays.Size = New System.Drawing.Size(314, 161)
        Me.lstvwEspDays.TabIndex = 18
        Me.lstvwEspDays.TabStop = False
        Me.lstvwEspDays.UseCompatibleStateImageBehavior = False
        Me.lstvwEspDays.View = System.Windows.Forms.View.Details
        '
        'colmnId
        '
        Me.colmnId.Text = ""
        Me.colmnId.Width = 0
        '
        'colmnPINDays
        '
        Me.colmnPINDays.Text = ""
        Me.colmnPINDays.Width = 40
        '
        'colmnDay
        '
        Me.colmnDay.Text = "Day"
        Me.colmnDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colmnDay.Width = 97
        '
        'colmnTimeIn
        '
        Me.colmnTimeIn.Text = "TimeIn"
        Me.colmnTimeIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colmnTimeIn.Width = 89
        '
        'colmnTimeOut
        '
        Me.colmnTimeOut.Text = "TimeOut"
        Me.colmnTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colmnTimeOut.Width = 76
        '
        'cmsDays
        '
        Me.cmsDays.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SundayToolStripMenuItem, Me.ToolStripSeparator1, Me.MondayToolStripMenuItem, Me.TuesdayToolStripMenuItem, Me.WednesdayToolStripMenuItem, Me.ThursdayToolStripMenuItem, Me.FridayToolStripMenuItem, Me.ToolStripSeparator2, Me.SaturdayToolStripMenuItem})
        Me.cmsDays.Name = "cmsDays"
        Me.cmsDays.Size = New System.Drawing.Size(136, 170)
        '
        'SundayToolStripMenuItem
        '
        Me.SundayToolStripMenuItem.Name = "SundayToolStripMenuItem"
        Me.SundayToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.SundayToolStripMenuItem.Text = "Sunday"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(132, 6)
        '
        'MondayToolStripMenuItem
        '
        Me.MondayToolStripMenuItem.Name = "MondayToolStripMenuItem"
        Me.MondayToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.MondayToolStripMenuItem.Text = "Monday"
        '
        'TuesdayToolStripMenuItem
        '
        Me.TuesdayToolStripMenuItem.Name = "TuesdayToolStripMenuItem"
        Me.TuesdayToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.TuesdayToolStripMenuItem.Text = "Tuesday"
        '
        'WednesdayToolStripMenuItem
        '
        Me.WednesdayToolStripMenuItem.Name = "WednesdayToolStripMenuItem"
        Me.WednesdayToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.WednesdayToolStripMenuItem.Text = "Wednesday"
        '
        'ThursdayToolStripMenuItem
        '
        Me.ThursdayToolStripMenuItem.Name = "ThursdayToolStripMenuItem"
        Me.ThursdayToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ThursdayToolStripMenuItem.Text = "Thursday"
        '
        'FridayToolStripMenuItem
        '
        Me.FridayToolStripMenuItem.Name = "FridayToolStripMenuItem"
        Me.FridayToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.FridayToolStripMenuItem.Text = "Friday"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(132, 6)
        '
        'SaturdayToolStripMenuItem
        '
        Me.SaturdayToolStripMenuItem.Name = "SaturdayToolStripMenuItem"
        Me.SaturdayToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.SaturdayToolStripMenuItem.Text = "Saturday"
        '
        'btnCloseDay
        '
        Me.btnCloseDay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCloseDay.Image = Global.HR_System.My.Resources.Resources.cancel
        Me.btnCloseDay.Location = New System.Drawing.Point(304, 3)
        Me.btnCloseDay.Name = "btnCloseDay"
        Me.btnCloseDay.Size = New System.Drawing.Size(26, 24)
        Me.btnCloseDay.TabIndex = 1
        Me.btnCloseDay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCloseDay.UseVisualStyleBackColor = True
        '
        'btnAddDay
        '
        Me.btnAddDay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddDay.Enabled = False
        Me.btnAddDay.Image = Global.HR_System.My.Resources.Resources.page_save
        Me.btnAddDay.Location = New System.Drawing.Point(168, 287)
        Me.btnAddDay.Name = "btnAddDay"
        Me.btnAddDay.Size = New System.Drawing.Size(75, 46)
        Me.btnAddDay.TabIndex = 0
        Me.btnAddDay.Text = "&Add day"
        Me.btnAddDay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAddDay.UseVisualStyleBackColor = True
        '
        'frmSpecialSched
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(748, 484)
        Me.Controls.Add(Me.pnEdit)
        Me.Controls.Add(Me.pnSearch)
        Me.Controls.Add(Me.pnMain)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSpecialSched"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Time-In"
        Me.pnMain.ResumeLayout(False)
        Me.pnMain.PerformLayout()
        Me.pnSearch.ResumeLayout(False)
        Me.pnSearch.PerformLayout()
        Me.pnEdit.ResumeLayout(False)
        Me.pnEdit.PerformLayout()
        Me.grpbxDay.ResumeLayout(False)
        Me.grpbxDay.PerformLayout()
        Me.cmsDays.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstvwEspsSched As System.Windows.Forms.ListView
    Friend WithEvents colmnPin As System.Windows.Forms.ColumnHeader
    Friend WithEvents colmnName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colmnDepartment As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAddDay As System.Windows.Forms.Button
    Friend WithEvents btnCloseDay As System.Windows.Forms.Button
    Friend WithEvents lblEmpId As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mtxtTimeOut As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mtxtTimeIn As System.Windows.Forms.MaskedTextBox
    Friend WithEvents pnMain As System.Windows.Forms.Panel
    Friend WithEvents mtxtSearch As System.Windows.Forms.MaskedTextBox
    Friend WithEvents pnSearch As System.Windows.Forms.Panel
    Friend WithEvents mtxtSearchInput As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lstvwSearch As System.Windows.Forms.ListView
    Friend WithEvents clomnEmpId As System.Windows.Forms.ColumnHeader
    Friend WithEvents colmnSearchName As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblEmpName As System.Windows.Forms.Label
    Friend WithEvents lblTotalRecord As System.Windows.Forms.Label
    Friend WithEvents pnEdit As System.Windows.Forms.Panel
    Friend WithEvents lstvwEspDays As System.Windows.Forms.ListView
    Friend WithEvents colmnId As System.Windows.Forms.ColumnHeader
    Friend WithEvents colmnDay As System.Windows.Forms.ColumnHeader
    Friend WithEvents colmnStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents colmnTimeIn As System.Windows.Forms.ColumnHeader
    Friend WithEvents colmnTimeOut As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmsDays As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SundayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MondayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TuesdayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WednesdayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThursdayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FridayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaturdayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents grpbxDay As System.Windows.Forms.GroupBox
    Friend WithEvents btnDeleteDay As System.Windows.Forms.Button
    Friend WithEvents colmnPINDays As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
