<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNonWorkingHolidayEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNonWorkingHolidayEntry))
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtHolidayTitle = New System.Windows.Forms.TextBox()
        Me.dtpHoliday = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.Color.Navy
        Me.btnEnter.Location = New System.Drawing.Point(91, 148)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 36)
        Me.btnEnter.TabIndex = 8
        Me.btnEnter.Text = "&Add"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(172, 148)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 36)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtHolidayTitle
        '
        Me.txtHolidayTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHolidayTitle.Location = New System.Drawing.Point(12, 38)
        Me.txtHolidayTitle.Multiline = True
        Me.txtHolidayTitle.Name = "txtHolidayTitle"
        Me.txtHolidayTitle.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtHolidayTitle.Size = New System.Drawing.Size(235, 104)
        Me.txtHolidayTitle.TabIndex = 11
        '
        'dtpHoliday
        '
        Me.dtpHoliday.Location = New System.Drawing.Point(12, 12)
        Me.dtpHoliday.Name = "dtpHoliday"
        Me.dtpHoliday.Size = New System.Drawing.Size(235, 20)
        Me.dtpHoliday.TabIndex = 12
        '
        'frmNonWorkingHolidayEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 190)
        Me.Controls.Add(Me.dtpHoliday)
        Me.Controls.Add(Me.txtHolidayTitle)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNonWorkingHolidayEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Non-Working Holiday Entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtHolidayTitle As System.Windows.Forms.TextBox
    Friend WithEvents dtpHoliday As System.Windows.Forms.DateTimePicker
End Class
