'Programmed by: Aldwin Mark F. Solis
'Date: 10-18-2010
'Title: Employee Training selection

Imports System.Data.SqlClient

Public Class frmEmployeeTrainings

#Region "Variable Declaration"
    Friend Employee_ID As String
    Friend Training_ID As String
#End Region

#Region "User Functions"

    Private Function CheckExistingRecord() As Boolean

        Dim str(2) As String
        str = Me.cmbxTraining.Text.Split("~")
        CheckConnection(cn)
        Dim cmdSearch As New SqlCommand("SELECT * FROM tblEmployeeTrainings WHERE Training_ID='" & str(1) & "' AND  Employee_ID='" & Employee_ID & "'", cn)
        Dim objReader As SqlDataReader = cmdSearch.ExecuteReader

        objReader.Read()
        If objReader.HasRows = True Then
            CheckExistingRecord = True
        Else
            CheckExistingRecord = False
        End If

        objReader.Close()

        Return CheckExistingRecord

    End Function

#End Region

#Region "Filling Data"

    Private Sub FillTrainig(ByVal Sqlstring As String)

        Dim TrainingCode As String
        Dim Training As String

        Me.cmbxTraining.Items.Clear()
        CheckConnection(cn)
        Sqlda.SelectCommand = New SqlCommand(Sqlstring, cn)
        Sqlcmbldr = New SqlCommandBuilder(Sqlda)

        ds.Clear()
        Sqlda.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                Training = dr("Title")
                TrainingCode = dr("ID")

                Me.cmbxTraining.Items.Add(SetSpacing(Training, 160) & "~" & TrainingCode)
            Next
        End If

    End Sub

#End Region

#Region "Loading Data"

    Public Sub LoadTrainings()
        FillTrainig("SELECT * FROM tblTrainings")
    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmTrainings_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmEmployeeTrainings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LoadTrainings()
    End Sub

    Private Sub cmbxTraining_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbxTraining.SelectedIndexChanged

        Dim str(2) As String
        str = Me.cmbxTraining.Text.Split("~")

        CheckConnection(cn)
        Dim cmdSearch As New SqlCommand("SELECT * FROM tblTrainings WHERE ID='" & str(1) & "'", cn)
        Dim objReader As SqlDataReader = cmdSearch.ExecuteReader

        objReader.Read()
        If objReader.HasRows = True Then
            Me.txtDescription.Text = objReader("Description")
        Else
            Me.txtDescription.Text = "None"
        End If

        objReader.Close()

    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        If Me.cmbxTraining.Text = "" Then
            MessageBox.Show("Please select a training.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cmbxTraining.Focus()
        ElseIf CheckExistingRecord() = True Then
            MessageBox.Show("The selected training is already in the profile of the employee", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cmbxTraining.Focus()
        Else
            Dim str(2) As String
            str = Me.cmbxTraining.Text.Split("~")
            Training_ID = str(1)
            InsertData("tblEmployeeTrainings", "Employee_ID,Training_ID", "'" & Employee_ID & "','" & Training_ID & "'", "Data has been successfully inserted")
            frmEmployeeInfo.LoadEmployeeTraining()
            Me.Close()
        End If
    End Sub

End Class