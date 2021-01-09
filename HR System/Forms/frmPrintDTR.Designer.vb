<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintDTR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintDTR))
        Me.cmbxDepartment = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstvwEmployee = New System.Windows.Forms.ListView()
        Me.FirstName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MiddleInitial = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LastName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PIN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbxStatus = New System.Windows.Forms.ComboBox()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblTotalListOfEmployee = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstvwDateRange = New System.Windows.Forms.ListView()
        Me.colmnDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnUncheckAll = New System.Windows.Forms.Button()
        Me.btnCheckAll = New System.Windows.Forms.Button()
        Me.btnPrintPreview = New System.Windows.Forms.Button()
        Me.btnExtract = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbxDepartment
        '
        Me.cmbxDepartment.DropDownHeight = 200
        Me.cmbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxDepartment.DropDownWidth = 249
        Me.cmbxDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxDepartment.FormattingEnabled = True
        Me.cmbxDepartment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbxDepartment.IntegralHeight = False
        Me.cmbxDepartment.ItemHeight = 18
        Me.cmbxDepartment.Location = New System.Drawing.Point(6, 43)
        Me.cmbxDepartment.MaxDropDownItems = 10
        Me.cmbxDepartment.Name = "cmbxDepartment"
        Me.cmbxDepartment.Size = New System.Drawing.Size(249, 26)
        Me.cmbxDepartment.Sorted = True
        Me.cmbxDepartment.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(6, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 18)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "By Department"
        '
        'lstvwEmployee
        '
        Me.lstvwEmployee.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.lstvwEmployee.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstvwEmployee.CheckBoxes = True
        Me.lstvwEmployee.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.FirstName, Me.MiddleInitial, Me.LastName, Me.PIN})
        Me.lstvwEmployee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwEmployee.FullRowSelect = True
        Me.lstvwEmployee.GridLines = True
        Me.lstvwEmployee.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwEmployee.HideSelection = False
        Me.lstvwEmployee.Location = New System.Drawing.Point(13, 137)
        Me.lstvwEmployee.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstvwEmployee.MultiSelect = False
        Me.lstvwEmployee.Name = "lstvwEmployee"
        Me.lstvwEmployee.Size = New System.Drawing.Size(880, 347)
        Me.lstvwEmployee.TabIndex = 25
        Me.lstvwEmployee.UseCompatibleStateImageBehavior = False
        Me.lstvwEmployee.View = System.Windows.Forms.View.Details
        '
        'FirstName
        '
        Me.FirstName.Text = "First name"
        Me.FirstName.Width = 162
        '
        'MiddleInitial
        '
        Me.MiddleInitial.Text = "Initial"
        Me.MiddleInitial.Width = 77
        '
        'LastName
        '
        Me.LastName.Text = "Last name"
        Me.LastName.Width = 252
        '
        'PIN
        '
        Me.PIN.Text = "PIN"
        Me.PIN.Width = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(272, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 18)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Employment Status"
        '
        'cmbxStatus
        '
        Me.cmbxStatus.DropDownHeight = 100
        Me.cmbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxStatus.FormattingEnabled = True
        Me.cmbxStatus.IntegralHeight = False
        Me.cmbxStatus.ItemHeight = 18
        Me.cmbxStatus.Items.AddRange(New Object() {"All", "Contractual", "Regular"})
        Me.cmbxStatus.Location = New System.Drawing.Point(275, 43)
        Me.cmbxStatus.MaxDropDownItems = 5
        Me.cmbxStatus.Name = "cmbxStatus"
        Me.cmbxStatus.Size = New System.Drawing.Size(249, 26)
        Me.cmbxStatus.TabIndex = 26
        '
        'dtpEnd
        '
        Me.dtpEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEnd.Location = New System.Drawing.Point(728, 43)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(132, 24)
        Me.dtpEnd.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(693, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 18)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "to"
        '
        'dtpStart
        '
        Me.dtpStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStart.Location = New System.Drawing.Point(540, 43)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(132, 24)
        Me.dtpStart.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(537, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 18)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Start date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(725, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 18)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "End date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(9, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 18)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "List of Employee"
        '
        'btnProcess
        '
        Me.btnProcess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcess.Location = New System.Drawing.Point(708, 492)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(90, 38)
        Me.btnProcess.TabIndex = 34
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Red
        Me.btnBack.Location = New System.Drawing.Point(804, 492)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(90, 38)
        Me.btnBack.TabIndex = 35
        Me.btnBack.Text = "<Back>"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblTotalListOfEmployee
        '
        Me.lblTotalListOfEmployee.AutoSize = True
        Me.lblTotalListOfEmployee.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalListOfEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalListOfEmployee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotalListOfEmployee.Location = New System.Drawing.Point(172, 492)
        Me.lblTotalListOfEmployee.Name = "lblTotalListOfEmployee"
        Me.lblTotalListOfEmployee.Size = New System.Drawing.Size(17, 18)
        Me.lblTotalListOfEmployee.TabIndex = 36
        Me.lblTotalListOfEmployee.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(9, 492)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(157, 18)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Total no. of Employee:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmbxDepartment)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbxStatus)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpStart)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpEnd)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(877, 76)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select to process"
        '
        'lstvwDateRange
        '
        Me.lstvwDateRange.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colmnDate})
        Me.lstvwDateRange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwDateRange.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwDateRange.FullRowSelect = True
        Me.lstvwDateRange.GridLines = True
        Me.lstvwDateRange.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwDateRange.Location = New System.Drawing.Point(923, 137)
        Me.lstvwDateRange.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstvwDateRange.MultiSelect = False
        Me.lstvwDateRange.Name = "lstvwDateRange"
        Me.lstvwDateRange.Size = New System.Drawing.Size(294, 347)
        Me.lstvwDateRange.TabIndex = 40
        Me.lstvwDateRange.TabStop = False
        Me.lstvwDateRange.UseCompatibleStateImageBehavior = False
        Me.lstvwDateRange.View = System.Windows.Forms.View.Details
        '
        'colmnDate
        '
        Me.colmnDate.Text = "Date"
        Me.colmnDate.Width = 207
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnUncheckAll)
        Me.GroupBox2.Controls.Add(Me.btnCheckAll)
        Me.GroupBox2.Location = New System.Drawing.Point(134, 83)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 46)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        '
        'btnUncheckAll
        '
        Me.btnUncheckAll.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnUncheckAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUncheckAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUncheckAll.Location = New System.Drawing.Point(102, 15)
        Me.btnUncheckAll.Name = "btnUncheckAll"
        Me.btnUncheckAll.Size = New System.Drawing.Size(90, 25)
        Me.btnUncheckAll.TabIndex = 43
        Me.btnUncheckAll.Text = "Uncheck All"
        Me.btnUncheckAll.UseVisualStyleBackColor = False
        '
        'btnCheckAll
        '
        Me.btnCheckAll.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCheckAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckAll.Location = New System.Drawing.Point(6, 15)
        Me.btnCheckAll.Name = "btnCheckAll"
        Me.btnCheckAll.Size = New System.Drawing.Size(90, 25)
        Me.btnCheckAll.TabIndex = 42
        Me.btnCheckAll.Text = "Check All"
        Me.btnCheckAll.UseVisualStyleBackColor = False
        '
        'btnPrintPreview
        '
        Me.btnPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrintPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintPreview.ForeColor = System.Drawing.Color.Black
        Me.btnPrintPreview.Image = Global.HR_System.My.Resources.Resources.printer
        Me.btnPrintPreview.Location = New System.Drawing.Point(594, 492)
        Me.btnPrintPreview.Name = "btnPrintPreview"
        Me.btnPrintPreview.Size = New System.Drawing.Size(108, 38)
        Me.btnPrintPreview.TabIndex = 42
        Me.btnPrintPreview.Text = "Print preview"
        Me.btnPrintPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrintPreview.UseVisualStyleBackColor = True
        '
        'btnExtract
        '
        Me.btnExtract.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExtract.Location = New System.Drawing.Point(363, 492)
        Me.btnExtract.Name = "btnExtract"
        Me.btnExtract.Size = New System.Drawing.Size(125, 38)
        Me.btnExtract.TabIndex = 43
        Me.btnExtract.Text = "Extract to Textfile"
        Me.btnExtract.UseVisualStyleBackColor = True
        '
        'frmPrintDTR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 542)
        Me.Controls.Add(Me.btnExtract)
        Me.Controls.Add(Me.btnPrintPreview)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lstvwDateRange)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTotalListOfEmployee)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lstvwEmployee)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrintDTR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Daily Time Record"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbxDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lstvwEmployee As System.Windows.Forms.ListView
    Friend WithEvents FirstName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbxStatus As System.Windows.Forms.ComboBox
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MiddleInitial As System.Windows.Forms.ColumnHeader
    Friend WithEvents LastName As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblTotalListOfEmployee As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstvwDateRange As System.Windows.Forms.ListView
    Friend WithEvents colmnDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents PIN As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnUncheckAll As System.Windows.Forms.Button
    Friend WithEvents btnCheckAll As System.Windows.Forms.Button
    Friend WithEvents btnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents btnExtract As System.Windows.Forms.Button
End Class
