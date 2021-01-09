'Programmed by: Aldwin Mark F. Solis
'Date: 9-16-2010
'Title: DTR Editing

Imports System.Data.SqlClient

Public Class frmDailyTimeRecordEntry

#Region "Variable Declaration"
    Friend DTR_ID As Integer
    Friend PIN As Integer
#End Region

#Region "User Function"

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        If checkTime(Me.mtxtTime, Me.mtxtTime.Text) = False Then
            MessageBox.Show("Please enter a valid time.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.mtxtTime.Focus()
        ElseIf Me.cmbxAMPM.Text = "" Then
            MessageBox.Show("Please select either AM/PM.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cmbxAMPM.Focus()
        ElseIf Me.mtxtCount.Text.Trim(" ") = "" Then
            MessageBox.Show("Please enter a count.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.mtxtCount.Focus()
        ElseIf Me.cmbxStatus.Text = "" Then
            MessageBox.Show("Please select either IN/OUT.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cmbxStatus.Focus()
        Else
            InsertData("Timedata", "PIN" & _
                                ",Timedata" & _
                               ",Count" & _
                              ",InOut", "'" & PIN & _
                                 "','" & CDate(Me.dtpDate.Value.ToShortDateString & " " & Me.mtxtTime.Text & " " & Me.cmbxAMPM.Text) & _
                                "','" & Me.mtxtCount.Text & _
                               "','" & Me.cmbxStatus.Text & "'", "Data has been successfully inserted")
            Me.Close()
        End If

        frmDailyTimeRecord.LoadDTR()

    End Sub

    Private Sub frmDailyTimeRecordEntry_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

End Class