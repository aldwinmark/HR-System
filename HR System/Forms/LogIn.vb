'Programmed by: Aldwin Mark F. Solis
'Date: 9-16-2010
'Title: Log-in

Public Class LogIn

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        If Len(Trim(Me.txtUsername.Text)) = 0 Then
            MessageBox.Show("Please enter a valid username.", "required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtUsername.Focus()
        ElseIf Len(Trim(Me.txtPassword.Text)) = 0 Then
            MessageBox.Show("Please enter a valid password.", "required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtPassword.Focus()
        Else
            CheckConnection(cn)


        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MessageBox.Show("Are you sure you want to exit the application", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class