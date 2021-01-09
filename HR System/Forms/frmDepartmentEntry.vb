'Programmed by: Aldwin Mark F. Solis
'Date: 10-24-2010
'Title: Department Entry

Imports System.Data.SqlClient

Public Class frmDepartmentEntry

#Region "Variable Declaration"
    Friend ID As String
    Friend DepartmentCode As String
#End Region

#Region "User Functions"

    Private Function CheckExistingRecord() As Boolean

        CheckConnection(cn)
        Dim cmdSearch As New SqlCommand("SELECT * FROM Department WHERE DepartmentCode='" & Me.txtDepartmentCode.Text & "'", cn)
        Dim objReader As SqlDataReader = cmdSearch.ExecuteReader

        objReader.Read()
        If objReader.HasRows = True And Not DepartmentCode = Me.txtDepartmentCode.Text Then
            CheckExistingRecord = True
        Else
            CheckExistingRecord = False
        End If

        objReader.Close()

        Return CheckExistingRecord

    End Function

#End Region

    Private Sub frmDepartmentEntry_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        If Len(Me.txtDepartmentCode.Text.Trim(" ")) = 0 Then
            MessageBox.Show("Please enter a unique code for the department.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtDepartmentCode.Focus()
        ElseIf Len(Me.txtDepartmentTitle.Text.Trim(" ")) = 0 Then
            MessageBox.Show("Please enter the department name.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtDepartmentTitle.Focus()
        ElseIf Me.CheckExistingRecord = True Then
            MessageBox.Show("Department code is existing.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtDepartmentCode.Focus()
        Else
            If Me.btnEnter.Text = "Save" Then
                InsertData("Department", "DepartmentCode" & "," & "DepartmentDescription", "'" & Me.txtDepartmentCode.Text & "','" & Me.txtDepartmentTitle.Text & "'", Me.txtDepartmentTitle.Text & " has been successfully inserted")
            Else
                UpdateData("Department", "DepartmentCode='" & Me.txtDepartmentCode.Text & "',DepartmentDescription='" & Me.txtDepartmentTitle.Text & "'", "DepartmentNumber", ID, Me.txtDepartmentTitle.Text & " has been successfully updated")
            End If
            frmDepartments.LoadDepartments()
            Me.Close()
        End If
    End Sub

End Class