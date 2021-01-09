'Programmed by: Aldwin Mark F. Solis
'Date: 10-24-2010
'Title: Employee Positions Entry

Imports System.Data.SqlClient

Public Class frmPositionEntry

#Region "Variable Declaration"
    Friend ID As String
    Friend PositionTitle As String
#End Region

#Region "User Functions"

    Private Function CheckExistingRecord() As Boolean

        CheckConnection(cn)
        Dim cmdSearch As New SqlCommand("SELECT * FROM tblPositions WHERE PositionTitle='" & CSQ(Me.txtPositionName.Text) & "'", cn)
        Dim objReader As SqlDataReader = cmdSearch.ExecuteReader

        objReader.Read()
        If objReader.HasRows = True And Not PositionTitle = Me.txtPositionName.Text Then
            CheckExistingRecord = True
        Else
            CheckExistingRecord = False
        End If

        objReader.Close()

        Return CheckExistingRecord

    End Function

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmPositionEntry_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        If Len(Me.txtPositionName.Text.Trim(" ")) = 0 Then
            MessageBox.Show("Please enter title of the position.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtPositionName.Focus()
        ElseIf Len(Me.txtRoleDescription.Text.Trim(" ")) = 0 Then
            MessageBox.Show("Please enter role of the position.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtRoleDescription.Focus()
        ElseIf CheckExistingRecord() = True Then
            MessageBox.Show("Position name is already an existing position.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtPositionName.Focus()
        Else
            If Me.btnEnter.Text = "Save" Then
                InsertData("tblPositions", "PositionTitle" & "," & "RoleDescription", "'" & CSQ(Me.txtPositionName.Text) & "','" & CSQ(Me.txtRoleDescription.Text) & "'", Me.txtPositionName.Text & " has been successfully inserted")
            Else
                UpdateData("tblPositions", "PositionTitle='" & CSQ(Me.txtPositionName.Text) & "',RoleDescription='" & CSQ(Me.txtRoleDescription.Text) & "'", "ID", ID, Me.txtPositionName.Text & " has been successfully updated")
            End If
            frmPositions.LoadPositions()
            Me.Close()
        End If
    End Sub

End Class