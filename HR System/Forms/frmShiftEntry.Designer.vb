<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShiftEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShiftEntry))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rbtnOn = New System.Windows.Forms.RadioButton()
        Me.rbtnOff = New System.Windows.Forms.RadioButton()
        Me.grpbxDate = New System.Windows.Forms.GroupBox()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.btnEntry = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cmbxDay = New System.Windows.Forms.ComboBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.mtxtPMOut = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtPMIn = New System.Windows.Forms.MaskedTextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.mtxtAMOut = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtAMIn = New System.Windows.Forms.MaskedTextBox()
        Me.cmbxAMIn = New System.Windows.Forms.ComboBox()
        Me.cmbxAMOut = New System.Windows.Forms.ComboBox()
        Me.cmbxPMIn = New System.Windows.Forms.ComboBox()
        Me.cmbxPMOut = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.grpbxDate.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox6)
        Me.Panel1.Controls.Add(Me.grpbxDate)
        Me.Panel1.Controls.Add(Me.btnEntry)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.cmbxDay)
        Me.Panel1.Controls.Add(Me.GroupBox8)
        Me.Panel1.Controls.Add(Me.Label42)
        Me.Panel1.Controls.Add(Me.GroupBox7)
        Me.Panel1.Location = New System.Drawing.Point(4, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(368, 307)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rbtnOn)
        Me.GroupBox6.Controls.Add(Me.rbtnOff)
        Me.GroupBox6.Location = New System.Drawing.Point(107, 10)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(193, 22)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        '
        'rbtnOn
        '
        Me.rbtnOn.AutoSize = True
        Me.rbtnOn.Checked = True
        Me.rbtnOn.Location = New System.Drawing.Point(8, 5)
        Me.rbtnOn.Name = "rbtnOn"
        Me.rbtnOn.Size = New System.Drawing.Size(39, 17)
        Me.rbtnOn.TabIndex = 0
        Me.rbtnOn.TabStop = True
        Me.rbtnOn.Text = "On"
        Me.rbtnOn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.rbtnOn.UseVisualStyleBackColor = True
        '
        'rbtnOff
        '
        Me.rbtnOff.AutoSize = True
        Me.rbtnOff.Location = New System.Drawing.Point(98, 5)
        Me.rbtnOff.Name = "rbtnOff"
        Me.rbtnOff.Size = New System.Drawing.Size(39, 17)
        Me.rbtnOff.TabIndex = 1
        Me.rbtnOff.Text = "Off"
        Me.rbtnOff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.rbtnOff.UseVisualStyleBackColor = True
        '
        'grpbxDate
        '
        Me.grpbxDate.Controls.Add(Me.dtpFrom)
        Me.grpbxDate.Controls.Add(Me.Label47)
        Me.grpbxDate.Controls.Add(Me.dtpTo)
        Me.grpbxDate.Controls.Add(Me.Label46)
        Me.grpbxDate.Location = New System.Drawing.Point(9, 32)
        Me.grpbxDate.Name = "grpbxDate"
        Me.grpbxDate.Size = New System.Drawing.Size(352, 48)
        Me.grpbxDate.TabIndex = 2
        Me.grpbxDate.TabStop = False
        '
        'dtpFrom
        '
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(59, 16)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(120, 20)
        Me.dtpFrom.TabIndex = 0
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label47.Location = New System.Drawing.Point(9, 16)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(44, 18)
        Me.Label47.TabIndex = 27
        Me.Label47.Text = "From"
        '
        'dtpTo
        '
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(222, 16)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(120, 20)
        Me.dtpTo.TabIndex = 1
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.BackColor = System.Drawing.Color.Transparent
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label46.Location = New System.Drawing.Point(190, 16)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(26, 18)
        Me.Label46.TabIndex = 26
        Me.Label46.Text = "To"
        '
        'btnEntry
        '
        Me.btnEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntry.ForeColor = System.Drawing.Color.Navy
        Me.btnEntry.Location = New System.Drawing.Point(199, 261)
        Me.btnEntry.Name = "btnEntry"
        Me.btnEntry.Size = New System.Drawing.Size(75, 36)
        Me.btnEntry.TabIndex = 6
        Me.btnEntry.Text = "&Add"
        Me.btnEntry.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(280, 261)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 36)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "&Cancel>>"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cmbxDay
        '
        Me.cmbxDay.DropDownHeight = 100
        Me.cmbxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxDay.FormattingEnabled = True
        Me.cmbxDay.IntegralHeight = False
        Me.cmbxDay.Location = New System.Drawing.Point(59, 92)
        Me.cmbxDay.Name = "cmbxDay"
        Me.cmbxDay.Size = New System.Drawing.Size(296, 26)
        Me.cmbxDay.TabIndex = 3
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.cmbxPMOut)
        Me.GroupBox8.Controls.Add(Me.cmbxPMIn)
        Me.GroupBox8.Controls.Add(Me.Label44)
        Me.GroupBox8.Controls.Add(Me.Label45)
        Me.GroupBox8.Controls.Add(Me.mtxtPMOut)
        Me.GroupBox8.Controls.Add(Me.mtxtPMIn)
        Me.GroupBox8.Location = New System.Drawing.Point(186, 150)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(151, 94)
        Me.GroupBox8.TabIndex = 5
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "PM"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Blue
        Me.Label44.Location = New System.Drawing.Point(10, 26)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(22, 18)
        Me.Label44.TabIndex = 15
        Me.Label44.Text = "IN"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Blue
        Me.Label45.Location = New System.Drawing.Point(10, 58)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(40, 18)
        Me.Label45.TabIndex = 16
        Me.Label45.Text = "OUT"
        '
        'mtxtPMOut
        '
        Me.mtxtPMOut.Location = New System.Drawing.Point(59, 55)
        Me.mtxtPMOut.Mask = "90:00"
        Me.mtxtPMOut.Name = "mtxtPMOut"
        Me.mtxtPMOut.Size = New System.Drawing.Size(36, 20)
        Me.mtxtPMOut.TabIndex = 1
        Me.mtxtPMOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mtxtPMOut.ValidatingType = GetType(Date)
        '
        'mtxtPMIn
        '
        Me.mtxtPMIn.Location = New System.Drawing.Point(59, 23)
        Me.mtxtPMIn.Mask = "90:00"
        Me.mtxtPMIn.Name = "mtxtPMIn"
        Me.mtxtPMIn.Size = New System.Drawing.Size(36, 20)
        Me.mtxtPMIn.TabIndex = 0
        Me.mtxtPMIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mtxtPMIn.ValidatingType = GetType(Date)
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label42.Location = New System.Drawing.Point(10, 92)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(34, 18)
        Me.Label42.TabIndex = 7
        Me.Label42.Text = "Day"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.cmbxAMOut)
        Me.GroupBox7.Controls.Add(Me.cmbxAMIn)
        Me.GroupBox7.Controls.Add(Me.Label41)
        Me.GroupBox7.Controls.Add(Me.Label43)
        Me.GroupBox7.Controls.Add(Me.mtxtAMOut)
        Me.GroupBox7.Controls.Add(Me.mtxtAMIn)
        Me.GroupBox7.Location = New System.Drawing.Point(13, 150)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(151, 94)
        Me.GroupBox7.TabIndex = 4
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "AM"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Blue
        Me.Label41.Location = New System.Drawing.Point(10, 26)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(22, 18)
        Me.Label41.TabIndex = 15
        Me.Label41.Text = "IN"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Blue
        Me.Label43.Location = New System.Drawing.Point(10, 58)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(40, 18)
        Me.Label43.TabIndex = 16
        Me.Label43.Text = "OUT"
        '
        'mtxtAMOut
        '
        Me.mtxtAMOut.Location = New System.Drawing.Point(59, 55)
        Me.mtxtAMOut.Mask = "90:00"
        Me.mtxtAMOut.Name = "mtxtAMOut"
        Me.mtxtAMOut.Size = New System.Drawing.Size(36, 20)
        Me.mtxtAMOut.TabIndex = 1
        Me.mtxtAMOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mtxtAMOut.ValidatingType = GetType(Date)
        '
        'mtxtAMIn
        '
        Me.mtxtAMIn.Location = New System.Drawing.Point(59, 23)
        Me.mtxtAMIn.Mask = "90:00"
        Me.mtxtAMIn.Name = "mtxtAMIn"
        Me.mtxtAMIn.Size = New System.Drawing.Size(36, 20)
        Me.mtxtAMIn.TabIndex = 0
        Me.mtxtAMIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mtxtAMIn.ValidatingType = GetType(Date)
        '
        'cmbxAMIn
        '
        Me.cmbxAMIn.FormattingEnabled = True
        Me.cmbxAMIn.Items.AddRange(New Object() {"AM", "PM"})
        Me.cmbxAMIn.Location = New System.Drawing.Point(95, 22)
        Me.cmbxAMIn.Name = "cmbxAMIn"
        Me.cmbxAMIn.Size = New System.Drawing.Size(50, 21)
        Me.cmbxAMIn.TabIndex = 17
        '
        'cmbxAMOut
        '
        Me.cmbxAMOut.FormattingEnabled = True
        Me.cmbxAMOut.Items.AddRange(New Object() {"AM", "PM"})
        Me.cmbxAMOut.Location = New System.Drawing.Point(95, 54)
        Me.cmbxAMOut.Name = "cmbxAMOut"
        Me.cmbxAMOut.Size = New System.Drawing.Size(50, 21)
        Me.cmbxAMOut.TabIndex = 18
        '
        'cmbxPMIn
        '
        Me.cmbxPMIn.FormattingEnabled = True
        Me.cmbxPMIn.Items.AddRange(New Object() {"AM", "PM"})
        Me.cmbxPMIn.Location = New System.Drawing.Point(95, 22)
        Me.cmbxPMIn.Name = "cmbxPMIn"
        Me.cmbxPMIn.Size = New System.Drawing.Size(50, 21)
        Me.cmbxPMIn.TabIndex = 19
        '
        'cmbxPMOut
        '
        Me.cmbxPMOut.FormattingEnabled = True
        Me.cmbxPMOut.Items.AddRange(New Object() {"AM", "PM"})
        Me.cmbxPMOut.Location = New System.Drawing.Point(94, 54)
        Me.cmbxPMOut.Name = "cmbxPMOut"
        Me.cmbxPMOut.Size = New System.Drawing.Size(50, 21)
        Me.cmbxPMOut.TabIndex = 20
        '
        'frmShiftEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 322)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmShiftEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shift Entry"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.grpbxDate.ResumeLayout(False)
        Me.grpbxDate.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnEntry As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbxDay As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents mtxtPMOut As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxtPMIn As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents mtxtAMOut As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxtAMIn As System.Windows.Forms.MaskedTextBox
    Friend WithEvents grpbxDate As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnOn As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnOff As System.Windows.Forms.RadioButton
    Friend WithEvents cmbxAMIn As System.Windows.Forms.ComboBox
    Friend WithEvents cmbxPMOut As System.Windows.Forms.ComboBox
    Friend WithEvents cmbxPMIn As System.Windows.Forms.ComboBox
    Friend WithEvents cmbxAMOut As System.Windows.Forms.ComboBox
End Class
