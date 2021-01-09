'Programmed by: Aldwin Mark F. Solis
'Date: 3-1-2011
'Title: Add Employee

Imports System.Data.SqlClient
Imports System.IO

Public Class frmAddEmployee

#Region "Load Data"
    Public Sub LoadDepartment()
        FillDepartment("SELECT * FROM Department")
    End Sub
#End Region

#Region "Filling Data"
    Private Sub FillDepartment(ByVal Sqlstring As String)

        Dim DepartmentCode As String
        Dim Department As String

        Me.cmbxDepartment.Items.Clear()
        CheckConnection(cn)
        Sqlda.SelectCommand = New SqlCommand(Sqlstring, cn)
        Sqlcmbldr = New SqlCommandBuilder(Sqlda)

        ds.Clear()
        Sqlda.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                Department = dr("DepartmentDescription")
                DepartmentCode = dr("DepartmentCode")

                Me.cmbxDepartment.Items.Add(SetSpacing(Department, 80) & "~" & DepartmentCode)
            Next
        End If

    End Sub
#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim DepartmentCode(2) As String
        Dim EmploymentStatus As String

        If Len(Me.txtLastName.Text.Trim(" ")) = 0 Then
            MessageBox.Show("Please enter a last name.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtLastName.Focus()
        ElseIf Len(Me.txtFirstName.Text.Trim(" ")) = 0 Then
            MessageBox.Show("Please enter a first name.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtFirstName.Focus()
        ElseIf Len(Me.txtMiddleInitial.Text.Trim(" ")) = 0 Then
            MessageBox.Show("Please enter a middle initial.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtMiddleInitial.Focus()
        ElseIf Len(Me.txtEmployeeNo.Text.Trim(" ")) = 0 Then
            MessageBox.Show("Please enter a valid employee no.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtEmployeeNo.Focus()
        ElseIf Len(Me.cmbxDepartment.Text.Trim(" ")) = 0 Then
            MessageBox.Show("Please select a department.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxDepartment.Focus()
        Else
            DepartmentCode = Me.cmbxDepartment.Text.Split("~")

            'Employment Status
            If Me.rbtnRegular.Checked = True Then
                EmploymentStatus = "Regular"
            Else
                EmploymentStatus = "Contractual"
            End If

            InsertData("Employees", "LastName" & _
                                                  ",FirstName" & _
                                                  ",MiddleInitial" & _
                                                  ",PIN" & _
                                                  ",strEmployeeID" & _
                                                  ",DepartmentCode" & _
                                                  ",EmploymentStatus" & _
                                                  ",CompanyCode" & _
                                                  ",BirthDate", "'" & CSQ(Me.txtLastName.Text) & _
                                                                 "','" & CSQ(Me.txtFirstName.Text) & _
                                                                 "','" & CSQ(Me.txtMiddleInitial.Text) & _
                                                                 "','" & Me.txtEmployeeNo.Text & _
                                                                 "','" & Me.txtEmployeeNo.Text & _
                                                                 "','" & DepartmentCode(1) & _
                                                                 "','" & EmploymentStatus & _
                                                                 "','" & "ZAMCELCO" & _
                                                                 "','" & Me.dtpBirthDate.Value & _
                                                                 "'", "")
            MessageBox.Show(Me.txtLastName.Text & ", " & Me.txtFirstName.Text & " " & Me.txtMiddleInitial.Text & "has been successfully saved.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmListEmployees.LoadEmployees()
            Me.Close()
        End If
    End Sub

    Private Sub frmAddEmployee_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub txtEmployeeNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmployeeNo.KeyPress
        e.Handled = OnlyNumeric(Asc(e.KeyChar))
    End Sub

End Class