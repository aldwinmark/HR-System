<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttendanceMon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAttendanceMon))
        Me.lstvwAbsences = New System.Windows.Forms.ListView()
        Me.EmployeeName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PIN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Absences = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LateHours = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbxDepartment = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbxStatus = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.bgworkerLoadEmplyees = New System.ComponentModel.BackgroundWorker()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.lstvwDateRange = New System.Windows.Forms.ListView()
        Me.colmnDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstvwAbsences
        '
        Me.lstvwAbsences.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.EmployeeName, Me.PIN, Me.Absences, Me.LateHours})
        Me.lstvwAbsences.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwAbsences.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwAbsences.FullRowSelect = True
        Me.lstvwAbsences.GridLines = True
        Me.lstvwAbsences.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwAbsences.Location = New System.Drawing.Point(13, 96)
        Me.lstvwAbsences.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstvwAbsences.MultiSelect = False
        Me.lstvwAbsences.Name = "lstvwAbsences"
        Me.lstvwAbsences.Size = New System.Drawing.Size(888, 341)
        Me.lstvwAbsences.TabIndex = 22
        Me.lstvwAbsences.UseCompatibleStateImageBehavior = False
        Me.lstvwAbsences.View = System.Windows.Forms.View.Details
        '
        'EmployeeName
        '
        Me.EmployeeName.Text = "Employee name"
        Me.EmployeeName.Width = 362
        '
        'PIN
        '
        Me.PIN.Text = "PIN"
        Me.PIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PIN.Width = 126
        '
        'Absences
        '
        Me.Absences.Text = "Absences"
        Me.Absences.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Absences.Width = 133
        '
        'LateHours
        '
        Me.LateHours.Text = "Late hours"
        Me.LateHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.LateHours.Width = 112
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
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(887, 76)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select to process"
        '
        'cmbxDepartment
        '
        Me.cmbxDepartment.DropDownHeight = 200
        Me.cmbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxDepartment.DropDownWidth = 249
        Me.cmbxDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxDepartment.FormattingEnabled = True
        Me.cmbxDepartment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbxDepartment.IntegralHeight = False
        Me.cmbxDepartment.ItemHeight = 16
        Me.cmbxDepartment.Location = New System.Drawing.Point(6, 44)
        Me.cmbxDepartment.MaxDropDownItems = 10
        Me.cmbxDepartment.Name = "cmbxDepartment"
        Me.cmbxDepartment.Size = New System.Drawing.Size(332, 24)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(341, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 18)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Employment Status"
        '
        'cmbxStatus
        '
        Me.cmbxStatus.DropDownHeight = 100
        Me.cmbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxStatus.FormattingEnabled = True
        Me.cmbxStatus.IntegralHeight = False
        Me.cmbxStatus.ItemHeight = 16
        Me.cmbxStatus.Items.AddRange(New Object() {"All", "Contractual", "Regular"})
        Me.cmbxStatus.Location = New System.Drawing.Point(344, 44)
        Me.cmbxStatus.MaxDropDownItems = 5
        Me.cmbxStatus.Name = "cmbxStatus"
        Me.cmbxStatus.Size = New System.Drawing.Size(180, 24)
        Me.cmbxStatus.TabIndex = 26
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
        'dtpStart
        '
        Me.dtpStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStart.Location = New System.Drawing.Point(540, 43)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(132, 24)
        Me.dtpStart.TabIndex = 28
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
        'dtpEnd
        '
        Me.dtpEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEnd.Location = New System.Drawing.Point(728, 43)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(132, 24)
        Me.dtpEnd.TabIndex = 29
        '
        'btnBack
        '
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Red
        Me.btnBack.Location = New System.Drawing.Point(811, 445)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(90, 38)
        Me.btnBack.TabIndex = 40
        Me.btnBack.Text = "<&Back>"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(715, 445)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(90, 38)
        Me.btnLoad.TabIndex = 41
        Me.btnLoad.Text = "&Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'lstvwDateRange
        '
        Me.lstvwDateRange.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colmnDate})
        Me.lstvwDateRange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwDateRange.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwDateRange.FullRowSelect = True
        Me.lstvwDateRange.GridLines = True
        Me.lstvwDateRange.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwDateRange.Location = New System.Drawing.Point(741, 107)
        Me.lstvwDateRange.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstvwDateRange.MultiSelect = False
        Me.lstvwDateRange.Name = "lstvwDateRange"
        Me.lstvwDateRange.Size = New System.Drawing.Size(137, 317)
        Me.lstvwDateRange.TabIndex = 42
        Me.lstvwDateRange.TabStop = False
        Me.lstvwDateRange.UseCompatibleStateImageBehavior = False
        Me.lstvwDateRange.View = System.Windows.Forms.View.Details
        '
        'colmnDate
        '
        Me.colmnDate.Text = "Date"
        Me.colmnDate.Width = 207
        '
        'frmAttendanceMon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 490)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstvwAbsences)
        Me.Controls.Add(Me.lstvwDateRange)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAttendanceMon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attendance Monitoring"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstvwAbsences As System.Windows.Forms.ListView
    Friend WithEvents EmployeeName As System.Windows.Forms.ColumnHeader
    Friend WithEvents PIN As System.Windows.Forms.ColumnHeader
    Friend WithEvents Absences As System.Windows.Forms.ColumnHeader
    Friend WithEvents LateHours As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbxDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbxStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents bgworkerLoadEmplyees As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents lstvwDateRange As System.Windows.Forms.ListView
    Friend WithEvents colmnDate As System.Windows.Forms.ColumnHeader
End Class
