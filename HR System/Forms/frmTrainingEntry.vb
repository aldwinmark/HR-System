'Programmed by: Aldwin Mark F. Solis
'Date: 10-24-2010
'Title: Employee Positions Entry

Imports System.Data.SqlClient

Public Class frmTrainingEntry

#Region "Variable Declaration"
    Friend ID As String
    Friend Title As String
#End Region

#Region "User Functions"

    Private Function CheckExistingRecord() As Boolean

        CheckConnection(cn)
        Dim cmdSearch As New SqlCommand("SELECT * FROM tblTrainings WHERE Title='" & Me.txtTitle.Text & "'", cn)
        Dim objReader As SqlDataReader = cmdSearch.ExecuteReader

        objReader.Read()
        If objReader.HasRows = True And Not Title = Me.txtTitle.Text Then
            CheckExistingRecord = True
        Else
            CheckExistingRecord = False
        End If

        objReader.Close()

        Return CheckExistingRecord

    End Function

#End Region

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        If Len(Me.txtTitle.Text.Trim(" ")) = 0 Then
            MessageBox.Show("Please enter title of the position.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtTitle.Focus()
        ElseIf Len(Me.txtDescription.Text.Trim(" ")) = 0 Then
            MessageBox.Show("Please enter role of the position.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtDescription.Focus()
        ElseIf CheckExistingRecord() = True Then
            MessageBox.Show("Position name is already an existing position.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtTitle.Focus()
        Else
            If Me.btnEnter.Text = "Save" Then
                InsertData("tblTrainings", "Title" & _
                                           ",Description" & _
                                           ",StartDate" & _
                                           ",EndDate", "" & _
                                           "'" & CSQ(Me.txtTitle.Text) & "'," & _
                                           "'" & CSQ(Me.txtDescription.Text) & "'," & _
                                           "'" & Me.dtpStartDate.Value & "'," & _
                                           "'" & Me.dtpEndDate.Value & "'" & _
                                           "", Me.txtTitle.Text & " has been successfully inserted")
            Else
                UpdateData("tblTrainings", "Title='" & Me.txtTitle.Text & "'" & _
                                     ",Description='" & Me.txtDescription.Text & "'" & _
                                     ",StartDate='" & Me.dtpStartDate.Value & "'" & _
                                     ",EndDate='" & Me.dtpStartDate.Value & "'", "ID", ID, "Data has been successfully updated.")
            End If
            frmTrainings.LoadTrainings()
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmTrainingEntry_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

End Class