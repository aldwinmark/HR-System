'Programmed by: Aldwin Mark F. Solis
'Date: 9-16-2010
'Title: Log-in
'Revised:
'~09-21-12

Imports System.Data.SqlClient

Public Class frmLogIn

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        If Len(Trim(Me.txtUsername.Text)) = 0 Then
            MessageBox.Show("Please enter a valid username.", "required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtUsername.Focus()
        ElseIf Len(Trim(Me.txtPassword.Text)) = 0 Then
            MessageBox.Show("Please enter a valid password.", "required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtPassword.Focus()
        Else
            Dim Level As String
            CheckConnection(cn)

            Dim cmdSearch As New SqlCommand("SELECT * FROM tblUserAccount WHERE UserName='" & Me.txtUsername.Text & "' AND Password='" & Me.txtPassword.Text & "'", cn)
            Dim objReader As SqlDataReader = cmdSearch.ExecuteReader

            objReader.Read()

            If objReader.HasRows = True Then
                Level = objReader("UserLevel")
                With frmMain
                    If Level = "1" Then
                        'todo
                    ElseIf Level = "2" Then 'for viewing
                        .HRManagementToolStripMenuItem.Visible = False
                        .EditTimeRecordToolStripMenuItem.Visible = False
                        .ImportDailyTimeRecordToolStripMenuItem.Visible = False
                        .TrainingsToolStripMenuItem.Visible = False
                        .MaintenanceToolStripMenuItem.Visible = False
                    End If
                End With

                Me.Close()
            Else
                MessageBox.Show("Please enter a valid username/password.", "Invalid username/password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtUsername.Focus()
            End If
            objReader.Close()

        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MessageBox.Show("Are you sure you want to exit the application", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub txtUsername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyValue = Keys.Enter Then
            Me.txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyValue = Keys.Enter Then
            Me.btnEnter.Focus()
        End If
    End Sub

End Class