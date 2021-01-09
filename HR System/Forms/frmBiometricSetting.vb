'Programmed By: Aldwin Mark F. Solis
'Description  : Settings of biometric
'Date started : 06-13-2011
'Date ended   : 

Imports System.Data.SqlClient

Public Class frmBiometricSetting

#Region "Variable declaration"

    Friend Method As Integer

#End Region

#Region "User Functions"

    Private Function GetBioMethod() As String

        CheckConnection(cn)
        Dim cmd As New SqlCommand("SELECT * FROM tblSettings", cn)
        Dim Reader As SqlDataReader = cmd.ExecuteReader

        Reader.Read()

        If Reader.HasRows = True Then
            GetBioMethod = Reader("Method")
        Else
            GetBioMethod = "None"
        End If

        If GetBioMethod = 1 Then
            GetBioMethod = "ID and Scan"
        ElseIf GetBioMethod = 2 Then
            GetBioMethod = "ID only"
        ElseIf GetBioMethod = 3 Then
            GetBioMethod = "ID and Image"
        Else
            GetBioMethod = "none"
        End If

        Reader.Close()

        Return GetBioMethod

    End Function

#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub frmBiometricSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmbxMethod.Text = GetBioMethod()
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        Dim Method As Integer

        If Me.cmbxMethod.Text = "ID and Scan" Then
            Method = 1
        ElseIf Me.cmbxMethod.Text = "ID only" Then
            Method = 2
        ElseIf Me.cmbxMethod.Text = "ID and Image" Then
            Method = 3
        Else
            Method = 0
        End If

        CheckConnection(cn)
        Dim cmd As New SqlCommand("UPDATE tblSettings SET [Method]='" & Method & "'", cn)
        cmd.ExecuteNonQuery()

        MessageBox.Show("Settings in the Biometric has been successfully updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

End Class