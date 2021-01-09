<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDailyTardinessMon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDailyTardinessMon))
        Me.rbtnAutomatic = New System.Windows.Forms.RadioButton
        Me.rbtnManual = New System.Windows.Forms.RadioButton
        Me.lstvwDTM = New System.Windows.Forms.ListView
        Me.colmnPin = New System.Windows.Forms.ColumnHeader
        Me.colmnName = New System.Windows.Forms.ColumnHeader
        Me.colmnDepartment = New System.Windows.Forms.ColumnHeader
        Me.colmnTime = New System.Windows.Forms.ColumnHeader
        Me.colmnStatus = New System.Windows.Forms.ColumnHeader
        Me.cmsTardiness = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.SpecialTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lblTotalRecord = New System.Windows.Forms.Label
        Me.tmRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.bgWorker = New System.ComponentModel.BackgroundWorker
        Me.lblTime = New System.Windows.Forms.Label
        Me.lblDepartment = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.pcbxEmpPic = New System.Windows.Forms.PictureBox
        Me.pnManual = New System.Windows.Forms.Panel
        Me.lblEndingDate = New System.Windows.Forms.Label
        Me.lblStartingDate = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dtpEnding = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpStarting = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmsTardiness.SuspendLayout()
        CType(Me.pcbxEmpPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnManual.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbtnAutomatic
        '
        Me.rbtnAutomatic.AutoSize = True
        Me.rbtnAutomatic.BackColor = System.Drawing.Color.Transparent
        Me.rbtnAutomatic.Checked = True
        Me.rbtnAutomatic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtnAutomatic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnAutomatic.ForeColor = System.Drawing.Color.Yellow
        Me.rbtnAutomatic.Location = New System.Drawing.Point(75, 118)
        Me.rbtnAutomatic.Name = "rbtnAutomatic"
        Me.rbtnAutomatic.Size = New System.Drawing.Size(81, 17)
        Me.rbtnAutomatic.TabIndex = 0
        Me.rbtnAutomatic.TabStop = True
        Me.rbtnAutomatic.Text = "Automatic"
        Me.rbtnAutomatic.UseVisualStyleBackColor = False
        '
        'rbtnManual
        '
        Me.rbtnManual.AutoSize = True
        Me.rbtnManual.BackColor = System.Drawing.Color.Transparent
        Me.rbtnManual.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtnManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnManual.ForeColor = System.Drawing.Color.Yellow
        Me.rbtnManual.Location = New System.Drawing.Point(185, 118)
        Me.rbtnManual.Name = "rbtnManual"
        Me.rbtnManual.Size = New System.Drawing.Size(66, 17)
        Me.rbtnManual.TabIndex = 1
        Me.rbtnManual.Text = "Manual"
        Me.rbtnManual.UseVisualStyleBackColor = False
        '
        'lstvwDTM
        '
        Me.lstvwDTM.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lstvwDTM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstvwDTM.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colmnPin, Me.colmnName, Me.colmnDepartment, Me.colmnTime, Me.colmnStatus})
        Me.lstvwDTM.ContextMenuStrip = Me.cmsTardiness
        Me.lstvwDTM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwDTM.FullRowSelect = True
        Me.lstvwDTM.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwDTM.HideSelection = False
        Me.lstvwDTM.HoverSelection = True
        Me.lstvwDTM.Location = New System.Drawing.Point(0, 210)
        Me.lstvwDTM.Name = "lstvwDTM"
        Me.lstvwDTM.Size = New System.Drawing.Size(873, 339)
        Me.lstvwDTM.TabIndex = 5
        Me.lstvwDTM.UseCompatibleStateImageBehavior = False
        Me.lstvwDTM.View = System.Windows.Forms.View.Details
        '
        'colmnPin
        '
        Me.colmnPin.Text = ""
        Me.colmnPin.Width = 91
        '
        'colmnName
        '
        Me.colmnName.Text = "Name"
        Me.colmnName.Width = 343
        '
        'colmnDepartment
        '
        Me.colmnDepartment.Text = "Department"
        Me.colmnDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colmnDepartment.Width = 148
        '
        'colmnTime
        '
        Me.colmnTime.Text = "Time"
        Me.colmnTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colmnTime.Width = 111
        '
        'colmnStatus
        '
        Me.colmnStatus.Text = "Status"
        Me.colmnStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colmnStatus.Width = 106
        '
        'cmsTardiness
        '
        Me.cmsTardiness.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.SpecialTimeToolStripMenuItem, Me.ToolStripSeparator2, Me.PrintPreviewToolStripMenuItem})
        Me.cmsTardiness.Name = "cmsTardiness"
        Me.cmsTardiness.Size = New System.Drawing.Size(144, 60)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(140, 6)
        '
        'SpecialTimeToolStripMenuItem
        '
        Me.SpecialTimeToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.award_star_gold
        Me.SpecialTimeToolStripMenuItem.Name = "SpecialTimeToolStripMenuItem"
        Me.SpecialTimeToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.SpecialTimeToolStripMenuItem.Text = "Special time"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(140, 6)
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.printer
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "Print preview"
        '
        'lblTotalRecord
        '
        Me.lblTotalRecord.AutoSize = True
        Me.lblTotalRecord.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalRecord.ForeColor = System.Drawing.Color.Black
        Me.lblTotalRecord.Location = New System.Drawing.Point(12, 561)
        Me.lblTotalRecord.Name = "lblTotalRecord"
        Me.lblTotalRecord.Size = New System.Drawing.Size(64, 13)
        Me.lblTotalRecord.TabIndex = 6
        Me.lblTotalRecord.Text = "Total record"
        '
        'tmRefresh
        '
        Me.tmRefresh.Enabled = True
        Me.tmRefresh.Interval = 1000
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(532, 149)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(168, 30)
        Me.lblTime.TabIndex = 3
        Me.lblTime.Text = "Time"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDepartment
        '
        Me.lblDepartment.BackColor = System.Drawing.Color.Transparent
        Me.lblDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.ForeColor = System.Drawing.Color.White
        Me.lblDepartment.Location = New System.Drawing.Point(532, 119)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(164, 30)
        Me.lblDepartment.TabIndex = 2
        Me.lblDepartment.Text = "Department"
        Me.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(532, 83)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(171, 36)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pcbxEmpPic
        '
        Me.pcbxEmpPic.BackColor = System.Drawing.Color.Black
        Me.pcbxEmpPic.Image = CType(resources.GetObject("pcbxEmpPic.Image"), System.Drawing.Image)
        Me.pcbxEmpPic.Location = New System.Drawing.Point(737, 90)
        Me.pcbxEmpPic.Name = "pcbxEmpPic"
        Me.pcbxEmpPic.Size = New System.Drawing.Size(93, 90)
        Me.pcbxEmpPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbxEmpPic.TabIndex = 0
        Me.pcbxEmpPic.TabStop = False
        '
        'pnManual
        '
        Me.pnManual.BackColor = System.Drawing.Color.Transparent
        Me.pnManual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnManual.Controls.Add(Me.lblEndingDate)
        Me.pnManual.Controls.Add(Me.lblStartingDate)
        Me.pnManual.Controls.Add(Me.GroupBox2)
        Me.pnManual.Controls.Add(Me.GroupBox1)
        Me.pnManual.Controls.Add(Me.Label2)
        Me.pnManual.Enabled = False
        Me.pnManual.Location = New System.Drawing.Point(12, 141)
        Me.pnManual.Name = "pnManual"
        Me.pnManual.Size = New System.Drawing.Size(487, 54)
        Me.pnManual.TabIndex = 4
        '
        'lblEndingDate
        '
        Me.lblEndingDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndingDate.ForeColor = System.Drawing.Color.Black
        Me.lblEndingDate.Location = New System.Drawing.Point(258, 4)
        Me.lblEndingDate.Name = "lblEndingDate"
        Me.lblEndingDate.Size = New System.Drawing.Size(214, 13)
        Me.lblEndingDate.TabIndex = 9
        Me.lblEndingDate.Text = "lblEndingDate"
        Me.lblEndingDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStartingDate
        '
        Me.lblStartingDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartingDate.ForeColor = System.Drawing.Color.Black
        Me.lblStartingDate.Location = New System.Drawing.Point(5, 4)
        Me.lblStartingDate.Name = "lblStartingDate"
        Me.lblStartingDate.Size = New System.Drawing.Size(214, 13)
        Me.lblStartingDate.TabIndex = 8
        Me.lblStartingDate.Text = "lblStartingDate"
        Me.lblStartingDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.dtpEnding)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(258, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(211, 35)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'dtpEnding
        '
        Me.dtpEnding.CustomFormat = "hh:mm tt"
        Me.dtpEnding.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEnding.Location = New System.Drawing.Point(101, 11)
        Me.dtpEnding.Name = "dtpEnding"
        Me.dtpEnding.Size = New System.Drawing.Size(105, 20)
        Me.dtpEnding.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Ending Datetime"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpStarting)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(214, 35)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Starting Datetime"
        '
        'dtpStarting
        '
        Me.dtpStarting.CustomFormat = "hh:mm tt"
        Me.dtpStarting.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStarting.Location = New System.Drawing.Point(104, 11)
        Me.dtpStarting.Name = "dtpStarting"
        Me.dtpStarting.Size = New System.Drawing.Size(105, 20)
        Me.dtpStarting.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "to"
        '
        'frmDailyTardinessMon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(873, 587)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.pcbxEmpPic)
        Me.Controls.Add(Me.lblTotalRecord)
        Me.Controls.Add(Me.lstvwDTM)
        Me.Controls.Add(Me.rbtnManual)
        Me.Controls.Add(Me.rbtnAutomatic)
        Me.Controls.Add(Me.pnManual)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDailyTardinessMon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daily Tardiness Monitoring"
        Me.cmsTardiness.ResumeLayout(False)
        CType(Me.pcbxEmpPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnManual.ResumeLayout(False)
        Me.pnManual.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbtnAutomatic As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnManual As System.Windows.Forms.RadioButton
    Friend WithEvents dtpStarting As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnManual As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpEnding As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstvwDTM As System.Windows.Forms.ListView
    Friend WithEvents colmnPin As System.Windows.Forms.ColumnHeader
    Friend WithEvents colmnName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colmnDepartment As System.Windows.Forms.ColumnHeader
    Friend WithEvents colmnTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents colmnStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblTotalRecord As System.Windows.Forms.Label
    Friend WithEvents lblEndingDate As System.Windows.Forms.Label
    Friend WithEvents lblStartingDate As System.Windows.Forms.Label
    Friend WithEvents tmRefresh As System.Windows.Forms.Timer
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents pcbxEmpPic As System.Windows.Forms.PictureBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents cmsTardiness As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SpecialTimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
