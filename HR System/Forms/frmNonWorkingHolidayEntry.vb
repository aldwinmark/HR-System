'Programmed by: Aldwin Mark F. Solis
'Date: 3-017-2011
'Title: Non-working Holiday Entry

Imports System.Data.SqlClient

Public Class frmNonWorkingHolidayEntry

#Region "User Functions"
    Private Function CheckHolidayExist(ByVal HolidayDate As Date) As Boolean

        CheckConnection(cn)

        Dim cmdSearch As New SqlCommand("SELECT * FROM tblNonWorkingDay WHERE NonWorkingDate='" & HolidayDate.ToShortDateString & "'", cn)
        Dim objReader As SqlDataReader = cmdSearch.ExecuteReader
        objReader.Read()

        If objReader.HasRows = True Then
            CheckHolidayExist = True
        Else
            CheckHolidayExist = False
        End If

        'close the reader
        objReader.Close()

        Return CheckHolidayExist
    End Function
#End Region

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click

        If Me.txtHolidayTitle.Text = "" Then
            MessageBox.Show("Please enter a Title for the holiday.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtHolidayTitle.Focus()
        ElseIf CheckHolidayExist(Me.dtpHoliday.Value) = True Then
            MessageBox.Show("Holiday date entered already exist.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtHolidayTitle.Focus()
        Else
            Dim str As String

            str = "INSERT INTO tblNonWorkingDay (NonWorkingDate,HolidayTitle) VALUES('" & Me.dtpHoliday.Value.ToShortDateString & "','" & Me.txtHolidayTitle.Text & "')"
            CheckConnection(cn)
            Dim cmd As New SqlCommand(str, cn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Holiday has been successfully inserted", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmNonWorkingHoliday.LoadNonWorkingDays()
            Me.Close()
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmNonWorkingHolidayEntry_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

End Class