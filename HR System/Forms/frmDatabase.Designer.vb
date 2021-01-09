<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatabase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatabase))
        Me.btnClose = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.pgbarTimedata = New System.Windows.Forms.ProgressBar
        Me.btnUpdateTimedate = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnClearTimedata = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.pgbarFingerPrintdata = New System.Windows.Forms.ProgressBar
        Me.btnClearFingerdata = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnUpdateFingerdata = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.pgbarEmployee = New System.Windows.Forms.ProgressBar
        Me.btnClearEmployee = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnUpdateEmployee = New System.Windows.Forms.Button
        Me.txtConnectionString = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.bgworkerUpdateTimedata = New System.ComponentModel.BackgroundWorker
        Me.bgworkerUpdateFingerdata = New System.ComponentModel.BackgroundWorker
        Me.bgworkerUpdateEmployee = New System.ComponentModel.BackgroundWorker
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(617, 401)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 36)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pgbarTimedata)
        Me.GroupBox1.Controls.Add(Me.btnUpdateTimedate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnClearTimedata)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 166)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Timedata"
        '
        'pgbarTimedata
        '
        Me.pgbarTimedata.Location = New System.Drawing.Point(96, 21)
        Me.pgbarTimedata.Name = "pgbarTimedata"
        Me.pgbarTimedata.Size = New System.Drawing.Size(231, 23)
        Me.pgbarTimedata.TabIndex = 43
        '
        'btnUpdateTimedate
        '
        Me.btnUpdateTimedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateTimedate.ForeColor = System.Drawing.Color.Navy
        Me.btnUpdateTimedate.Image = Global.HR_System.My.Resources.Resources.group
        Me.btnUpdateTimedate.Location = New System.Drawing.Point(130, 125)
        Me.btnUpdateTimedate.Name = "btnUpdateTimedate"
        Me.btnUpdateTimedate.Size = New System.Drawing.Size(197, 36)
        Me.btnUpdateTimedate.TabIndex = 42
        Me.btnUpdateTimedate.Text = "UpdateTimedata"
        Me.btnUpdateTimedate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdateTimedate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(17, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 16)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Warning:"
        '
        'btnClearTimedata
        '
        Me.btnClearTimedata.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearTimedata.ForeColor = System.Drawing.Color.Red
        Me.btnClearTimedata.Image = Global.HR_System.My.Resources.Resources.delete
        Me.btnClearTimedata.Location = New System.Drawing.Point(130, 83)
        Me.btnClearTimedata.Name = "btnClearTimedata"
        Me.btnClearTimedata.Size = New System.Drawing.Size(197, 36)
        Me.btnClearTimedata.TabIndex = 6
        Me.btnClearTimedata.Text = "Clear Timedata"
        Me.btnClearTimedata.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClearTimedata.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(20, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(307, 65)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "All the data in the timedata table will be deleted and cannot be retrieved."
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.pgbarFingerPrintdata)
        Me.GroupBox3.Controls.Add(Me.btnClearFingerdata)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.btnUpdateFingerdata)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 261)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(333, 182)
        Me.GroupBox3.TabIndex = 43
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Finger data"
        '
        'pgbarFingerPrintdata
        '
        Me.pgbarFingerPrintdata.Location = New System.Drawing.Point(96, 27)
        Me.pgbarFingerPrintdata.Name = "pgbarFingerPrintdata"
        Me.pgbarFingerPrintdata.Size = New System.Drawing.Size(231, 23)
        Me.pgbarFingerPrintdata.TabIndex = 45
        '
        'btnClearFingerdata
        '
        Me.btnClearFingerdata.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearFingerdata.ForeColor = System.Drawing.Color.Red
        Me.btnClearFingerdata.Image = Global.HR_System.My.Resources.Resources.delete
        Me.btnClearFingerdata.Location = New System.Drawing.Point(130, 98)
        Me.btnClearFingerdata.Name = "btnClearFingerdata"
        Me.btnClearFingerdata.Size = New System.Drawing.Size(197, 36)
        Me.btnClearFingerdata.TabIndex = 44
        Me.btnClearFingerdata.Text = "Clear Finger data"
        Me.btnClearFingerdata.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClearFingerdata.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(13, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(307, 65)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "All the data in the finger table will be overwrite/deleted and cannot be retrieve" & _
            "d"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(17, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 16)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Warning:"
        '
        'btnUpdateFingerdata
        '
        Me.btnUpdateFingerdata.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateFingerdata.ForeColor = System.Drawing.Color.Navy
        Me.btnUpdateFingerdata.Image = Global.HR_System.My.Resources.Resources.group
        Me.btnUpdateFingerdata.Location = New System.Drawing.Point(130, 140)
        Me.btnUpdateFingerdata.Name = "btnUpdateFingerdata"
        Me.btnUpdateFingerdata.Size = New System.Drawing.Size(197, 36)
        Me.btnUpdateFingerdata.TabIndex = 6
        Me.btnUpdateFingerdata.Text = "Update Finger data"
        Me.btnUpdateFingerdata.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdateFingerdata.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.pgbarEmployee)
        Me.GroupBox4.Controls.Add(Me.btnClearEmployee)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.btnUpdateEmployee)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(365, 70)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(333, 166)
        Me.GroupBox4.TabIndex = 44
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Employees"
        '
        'pgbarEmployee
        '
        Me.pgbarEmployee.Location = New System.Drawing.Point(84, 22)
        Me.pgbarEmployee.Name = "pgbarEmployee"
        Me.pgbarEmployee.Size = New System.Drawing.Size(231, 23)
        Me.pgbarEmployee.TabIndex = 44
        '
        'btnClearEmployee
        '
        Me.btnClearEmployee.Enabled = False
        Me.btnClearEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearEmployee.ForeColor = System.Drawing.Color.Red
        Me.btnClearEmployee.Image = Global.HR_System.My.Resources.Resources.delete
        Me.btnClearEmployee.Location = New System.Drawing.Point(130, 83)
        Me.btnClearEmployee.Name = "btnClearEmployee"
        Me.btnClearEmployee.Size = New System.Drawing.Size(197, 36)
        Me.btnClearEmployee.TabIndex = 43
        Me.btnClearEmployee.Text = "Clear Employee"
        Me.btnClearEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClearEmployee.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(13, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(307, 65)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "All the data in the employee table will be overwrite and cannot be retrieved"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(17, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 16)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Warning:"
        '
        'btnUpdateEmployee
        '
        Me.btnUpdateEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateEmployee.ForeColor = System.Drawing.Color.Navy
        Me.btnUpdateEmployee.Image = Global.HR_System.My.Resources.Resources.group
        Me.btnUpdateEmployee.Location = New System.Drawing.Point(130, 125)
        Me.btnUpdateEmployee.Name = "btnUpdateEmployee"
        Me.btnUpdateEmployee.Size = New System.Drawing.Size(197, 36)
        Me.btnUpdateEmployee.TabIndex = 6
        Me.btnUpdateEmployee.Text = "Update Employee"
        Me.btnUpdateEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdateEmployee.UseVisualStyleBackColor = True
        '
        'txtConnectionString
        '
        Me.txtConnectionString.AcceptsReturn = True
        Me.txtConnectionString.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConnectionString.Location = New System.Drawing.Point(161, 20)
        Me.txtConnectionString.Name = "txtConnectionString"
        Me.txtConnectionString.Size = New System.Drawing.Size(537, 22)
        Me.txtConnectionString.TabIndex = 46
        Me.txtConnectionString.Text = "Data Source=192.168.1.206;uid=sa;pwd=zAm@1974101800;database=FingerID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(12, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 18)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Connection String"
        '
        'bgworkerUpdateTimedata
        '
        Me.bgworkerUpdateTimedata.WorkerReportsProgress = True
        Me.bgworkerUpdateTimedata.WorkerSupportsCancellation = True
        '
        'bgworkerUpdateFingerdata
        '
        Me.bgworkerUpdateFingerdata.WorkerReportsProgress = True
        Me.bgworkerUpdateFingerdata.WorkerSupportsCancellation = True
        '
        'bgworkerUpdateEmployee
        '
        Me.bgworkerUpdateEmployee.WorkerReportsProgress = True
        Me.bgworkerUpdateEmployee.WorkerSupportsCancellation = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(463, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 18)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Source Database"
        '
        'frmDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 451)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtConnectionString)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDatabase"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnClearTimedata As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnUpdateFingerdata As System.Windows.Forms.Button
    Friend WithEvents btnUpdateTimedate As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClearEmployee As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnUpdateEmployee As System.Windows.Forms.Button
    Friend WithEvents txtConnectionString As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnClearFingerdata As System.Windows.Forms.Button
    Friend WithEvents bgworkerUpdateTimedata As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgworkerUpdateFingerdata As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgworkerUpdateEmployee As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pgbarTimedata As System.Windows.Forms.ProgressBar
    Friend WithEvents pgbarFingerPrintdata As System.Windows.Forms.ProgressBar
    Friend WithEvents pgbarEmployee As System.Windows.Forms.ProgressBar
End Class
