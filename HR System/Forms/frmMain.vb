'Programmed by: Aldwin Mark F. Solis
'Date: 9-16-2010
'Title: Main form

Imports System.Data.SqlClient

Public Class frmMain

    Private Sub ExitApplicationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitApplicationToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to exit the application?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub ListOfEmpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOfEmpToolStripMenuItem.Click
        frmListEmployees.ShowDialog()
    End Sub

    Private Sub WorkSchedulesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorkSchedulesToolStripMenuItem.Click
        frmWorkSchedule.ShowDialog()
    End Sub

    Private Sub NonWorkingHolidayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NonWorkingHolidayToolStripMenuItem.Click
        frmNonWorkingHoliday.ShowDialog()
    End Sub

    Private Sub EditTimeRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditTimeRecordToolStripMenuItem.Click
        frmDailyTimeRecord.ShowDialog()
    End Sub

    Private Sub PrintDTRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintDTRToolStripMenuItem.Click
        frmPrintDTR.ShowDialog()
    End Sub

    Private Sub ReligionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReligionToolStripMenuItem.Click
        frmReligion.ShowDialog()
    End Sub

    Private Sub PositionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PositionsToolStripMenuItem.Click
        frmPositions.ShowDialog()
    End Sub

    Private Sub DepartmentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentsToolStripMenuItem.Click
        frmDepartments.ShowDialog()
    End Sub

    Private Sub TrainingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrainingsToolStripMenuItem.Click
        frmTrainings.ShowDialog()
    End Sub

    Private Sub TardinessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TardinessToolStripMenuItem.Click
        frmDailyTardinessMon.ShowDialog()
    End Sub

    Private Sub ImportDailyTimeRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportDailyTimeRecordToolStripMenuItem.Click
        frmImportDTR.ShowDialog()
    End Sub

    Private Sub DatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatabaseToolStripMenuItem.Click
        frmDatabase.ShowDialog()
    End Sub

    Private Sub BiometricSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BiometricSettingsToolStripMenuItem.Click
        frmBiometricSetting.ShowDialog()
    End Sub

    Private Sub AttentMonToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttentMonToolStripMenuItem.Click
        frmAttendanceMon.ShowDialog()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmLogIn.ShowDialog()
        frmLogIn.txtUsername.Focus()
    End Sub

End Class