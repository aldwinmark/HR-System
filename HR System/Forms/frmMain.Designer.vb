<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HRManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfEmpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TardinessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttentMonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WorkSchedulesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NonWorkingHolidayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DailyTimeRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditTimeRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDTRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportDailyTimeRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecruitmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrainingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PositionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReligionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BiometricSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HRManagementToolStripMenuItem, Me.PayrollToolStripMenuItem, Me.RecruitmentToolStripMenuItem, Me.TrainingsToolStripMenuItem, Me.MaintenanceToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1007, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem, Me.ExitApplicationToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(40, 21)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.lock_unlock
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.LogOutToolStripMenuItem.Text = "&Log out"
        '
        'ExitApplicationToolStripMenuItem
        '
        Me.ExitApplicationToolStripMenuItem.Name = "ExitApplicationToolStripMenuItem"
        Me.ExitApplicationToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ExitApplicationToolStripMenuItem.Text = "&Exit application"
        '
        'HRManagementToolStripMenuItem
        '
        Me.HRManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListOfEmpToolStripMenuItem, Me.ToolStripSeparator1, Me.TardinessToolStripMenuItem, Me.AttentMonToolStripMenuItem, Me.WorkSchedulesToolStripMenuItem, Me.NonWorkingHolidayToolStripMenuItem})
        Me.HRManagementToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.blog
        Me.HRManagementToolStripMenuItem.Name = "HRManagementToolStripMenuItem"
        Me.HRManagementToolStripMenuItem.Size = New System.Drawing.Size(139, 21)
        Me.HRManagementToolStripMenuItem.Text = "HR Management"
        '
        'ListOfEmpToolStripMenuItem
        '
        Me.ListOfEmpToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.doc_table
        Me.ListOfEmpToolStripMenuItem.Name = "ListOfEmpToolStripMenuItem"
        Me.ListOfEmpToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.ListOfEmpToolStripMenuItem.Text = "List of Employee"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(215, 6)
        '
        'TardinessToolStripMenuItem
        '
        Me.TardinessToolStripMenuItem.Name = "TardinessToolStripMenuItem"
        Me.TardinessToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.TardinessToolStripMenuItem.Text = "Tardiness"
        '
        'AttentMonToolStripMenuItem
        '
        Me.AttentMonToolStripMenuItem.Name = "AttentMonToolStripMenuItem"
        Me.AttentMonToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.AttentMonToolStripMenuItem.Text = "Attendance Monitoring"
        '
        'WorkSchedulesToolStripMenuItem
        '
        Me.WorkSchedulesToolStripMenuItem.Name = "WorkSchedulesToolStripMenuItem"
        Me.WorkSchedulesToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.WorkSchedulesToolStripMenuItem.Text = "Work Schedules"
        '
        'NonWorkingHolidayToolStripMenuItem
        '
        Me.NonWorkingHolidayToolStripMenuItem.Name = "NonWorkingHolidayToolStripMenuItem"
        Me.NonWorkingHolidayToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.NonWorkingHolidayToolStripMenuItem.Text = "Non Working Holiday"
        '
        'PayrollToolStripMenuItem
        '
        Me.PayrollToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DailyTimeRecordToolStripMenuItem, Me.ImportDailyTimeRecordToolStripMenuItem})
        Me.PayrollToolStripMenuItem.Name = "PayrollToolStripMenuItem"
        Me.PayrollToolStripMenuItem.Size = New System.Drawing.Size(61, 21)
        Me.PayrollToolStripMenuItem.Text = "Payroll"
        '
        'DailyTimeRecordToolStripMenuItem
        '
        Me.DailyTimeRecordToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditTimeRecordToolStripMenuItem, Me.PrintDTRToolStripMenuItem})
        Me.DailyTimeRecordToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.alarm
        Me.DailyTimeRecordToolStripMenuItem.Name = "DailyTimeRecordToolStripMenuItem"
        Me.DailyTimeRecordToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.DailyTimeRecordToolStripMenuItem.Text = "Daily Time Record"
        '
        'EditTimeRecordToolStripMenuItem
        '
        Me.EditTimeRecordToolStripMenuItem.Name = "EditTimeRecordToolStripMenuItem"
        Me.EditTimeRecordToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.EditTimeRecordToolStripMenuItem.Text = "Edit Time Record"
        '
        'PrintDTRToolStripMenuItem
        '
        Me.PrintDTRToolStripMenuItem.Name = "PrintDTRToolStripMenuItem"
        Me.PrintDTRToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.PrintDTRToolStripMenuItem.Text = "Print DTR"
        '
        'ImportDailyTimeRecordToolStripMenuItem
        '
        Me.ImportDailyTimeRecordToolStripMenuItem.Name = "ImportDailyTimeRecordToolStripMenuItem"
        Me.ImportDailyTimeRecordToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.ImportDailyTimeRecordToolStripMenuItem.Text = "Import Daily Time Record"
        '
        'RecruitmentToolStripMenuItem
        '
        Me.RecruitmentToolStripMenuItem.Name = "RecruitmentToolStripMenuItem"
        Me.RecruitmentToolStripMenuItem.Size = New System.Drawing.Size(94, 21)
        Me.RecruitmentToolStripMenuItem.Text = "Recruitment"
        Me.RecruitmentToolStripMenuItem.Visible = False
        '
        'TrainingsToolStripMenuItem
        '
        Me.TrainingsToolStripMenuItem.Name = "TrainingsToolStripMenuItem"
        Me.TrainingsToolStripMenuItem.Size = New System.Drawing.Size(75, 21)
        Me.TrainingsToolStripMenuItem.Text = "Trainings"
        '
        'MaintenanceToolStripMenuItem
        '
        Me.MaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserManagementToolStripMenuItem, Me.DepartmentsToolStripMenuItem, Me.PositionsToolStripMenuItem, Me.ReligionToolStripMenuItem, Me.BiometricSettingsToolStripMenuItem, Me.ToolStripSeparator2, Me.DatabaseToolStripMenuItem})
        Me.MaintenanceToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.cog
        Me.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem"
        Me.MaintenanceToolStripMenuItem.Size = New System.Drawing.Size(114, 21)
        Me.MaintenanceToolStripMenuItem.Text = "Maintenance"
        '
        'UserManagementToolStripMenuItem
        '
        Me.UserManagementToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.user_silhouette
        Me.UserManagementToolStripMenuItem.Name = "UserManagementToolStripMenuItem"
        Me.UserManagementToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.UserManagementToolStripMenuItem.Text = "User management"
        '
        'DepartmentsToolStripMenuItem
        '
        Me.DepartmentsToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.chart_organisation
        Me.DepartmentsToolStripMenuItem.Name = "DepartmentsToolStripMenuItem"
        Me.DepartmentsToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.DepartmentsToolStripMenuItem.Text = "Departments"
        '
        'PositionsToolStripMenuItem
        '
        Me.PositionsToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.group
        Me.PositionsToolStripMenuItem.Name = "PositionsToolStripMenuItem"
        Me.PositionsToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.PositionsToolStripMenuItem.Text = "Positions"
        '
        'ReligionToolStripMenuItem
        '
        Me.ReligionToolStripMenuItem.Name = "ReligionToolStripMenuItem"
        Me.ReligionToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ReligionToolStripMenuItem.Text = "Religion"
        '
        'BiometricSettingsToolStripMenuItem
        '
        Me.BiometricSettingsToolStripMenuItem.Name = "BiometricSettingsToolStripMenuItem"
        Me.BiometricSettingsToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.BiometricSettingsToolStripMenuItem.Text = "Biometric"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(185, 6)
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.page_white_database
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.DatabaseToolStripMenuItem.Text = "Database"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 546)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Human Resource Information System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HRManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListOfEmpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PayrollToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecruitmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitApplicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrainingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WorkSchedulesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NonWorkingHolidayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartmentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PositionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReligionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DailyTimeRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditTimeRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintDTRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TardinessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportDailyTimeRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BiometricSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttentMonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
