'Programmed by: Aldwin Mark F. Solis
'Date: 9-17-2010
'Title: 201 file of Employee

Imports System.Data.SqlClient

Public Class frmListEmployees

#Region "Variable Declaration"

#End Region

#Region "Loading Function"

    Public Sub LoadEmployees()
        'If Len(Me.txtSearch.Text) > 0 Then
        If Me.rbtnPIN.Checked = True And IsNumeric(Me.txtSearch.Text) = True Then
            If Me.cmbxDepartment.Text = "All" And Me.cmbxEmploymentStatus.Text = "All" Then
                FillEmployee("SELECT TOP 50 * FROM Employees WHERE PIN='" & Me.txtSearch.Text & "' ")
            ElseIf Not Me.cmbxDepartment.Text = "All" And Me.cmbxEmploymentStatus.Text = "All" Then
                Dim DepartmentCode(2) As String
                DepartmentCode = Me.cmbxDepartment.Text.Split("~")
                FillEmployee("SELECT TOP 50 * FROM Employees WHERE PIN='" & Me.txtSearch.Text & "' AND DepartmentCode='" & DepartmentCode(1) & "'")
            ElseIf Me.cmbxDepartment.Text = "All" And Not Me.cmbxEmploymentStatus.Text = "All" Then
                FillEmployee("SELECT TOP 50 * FROM Employees WHERE PIN='" & Me.txtSearch.Text & "' AND EmploymentStatus='" & Me.cmbxEmploymentStatus.Text & "'")
            Else
                Dim DepartmentCode(2) As String
                DepartmentCode = Me.cmbxDepartment.Text.Split("~")
                FillEmployee("SELECT TOP 50 * FROM Employees WHERE PIN='" & Me.txtSearch.Text & "' AND DepartmentCode='" & DepartmentCode(1) & "' AND EmploymentStatus='" & Me.cmbxEmploymentStatus.Text & "'")
            End If
        Else
            If Me.cmbxDepartment.Text = "All" And Me.cmbxEmploymentStatus.Text = "All" Then
                FillEmployee("SELECT TOP 50 * FROM Employees WHERE LastName Like '%" & CSQ(Me.txtSearch.Text) & "%' or FirstName Like '%" & CSQ(Me.txtSearch.Text) & "%'")
            ElseIf Not Me.cmbxDepartment.Text = "All" And Me.cmbxEmploymentStatus.Text = "All" Then
                Dim DepartmentCode(2) As String
                DepartmentCode = Me.cmbxDepartment.Text.Split("~")
                If Me.txtSearch.Text = "" Then
                    FillEmployee("SELECT TOP 50 * FROM Employees WHERE DepartmentCode='" & CSQ(DepartmentCode(1)) & "'")
                Else
                    FillEmployee("SELECT TOP 50 * FROM Employees WHERE DepartmentCode='" & CSQ(DepartmentCode(1)) & "' and LastName Like '%" & CSQ(Me.txtSearch.Text) & "%' or FirstName Like '%" & CSQ(Me.txtSearch.Text) & "%'")
                End If
            ElseIf Me.cmbxDepartment.Text = "All" And Not Me.cmbxEmploymentStatus.Text = "All" Then
                If Me.txtSearch.Text = "" Then
                    FillEmployee("SELECT TOP 50 * FROM Employees WHERE EmploymentStatus='" & Me.cmbxEmploymentStatus.Text & "'")
                Else
                    FillEmployee("SELECT TOP 50 * FROM Employees WHERE EmploymentStatus='" & Me.cmbxEmploymentStatus.Text & "' LastName Like '%" & CSQ(Me.txtSearch.Text) & "%' or FirstName Like '%" & CSQ(Me.txtSearch.Text) & "%'")
                End If
            Else
                Dim DepartmentCode(2) As String
                DepartmentCode = Me.cmbxDepartment.Text.Split("~")
                If Me.txtSearch.Text = "" Then
                    FillEmployee("SELECT TOP 50 * FROM Employees WHERE DepartmentCode='" & DepartmentCode(1) & "' AND EmploymentStatus='" & Me.cmbxEmploymentStatus.Text & "'")
                Else
                    FillEmployee("SELECT TOP 50 * FROM Employees WHERE DepartmentCode='" & DepartmentCode(1) & "' AND EmploymentStatus='" & Me.cmbxEmploymentStatus.Text & "' AND LastName Like '%" & CSQ(Me.txtSearch.Text) & "%' or FirstName Like '%" & CSQ(Me.txtSearch.Text) & "%'")
                End If
            End If
        End If
        'Else
        'FillEmployee("SELECT TOP 50 * FROM Employees")
        'End If
    End Sub

    Public Sub LoadDepartment()
        FillDepartment("SELECT * FROM Department")
    End Sub

#End Region

#Region "User Function"

    Private Function GetDepartment(ByVal DepartmentCode As String) As String

        Dim SQL As String

        SQL = "SELECT DepartmentCode,DepartmentDescription FROM Department WHERE DepartmentCode='" & DepartmentCode & "'"

        CheckConnection(cn)
        Dim cmdSearch As New SqlCommand(SQL, cn)
        Dim objReader As SqlDataReader = cmdSearch.ExecuteReader

        objReader.Read()
        If objReader.HasRows = True Then
            GetDepartment = objReader("DepartmentDescription")
        Else
            GetDepartment = ""
        End If

        objReader.Close()

        Return GetDepartment

    End Function

    Private Function GetPosition(ByVal PositionID As String) As String

        Dim SQL As String

        SQL = "SELECT ID,PositionTitle FROM tblPositions WHERE ID='" & PositionID & "'"

        CheckConnection(cn)
        Dim cmdSearch As New SqlCommand(SQL, cn)
        Dim objReader As SqlDataReader = cmdSearch.ExecuteReader

        objReader.Read()
        If objReader.HasRows = True Then
            GetPosition = objReader("PositionTitle")
        Else
            GetPosition = "None"
        End If

        objReader.Close()

        Return GetPosition

    End Function

    Private Sub GetEmployeeInfo(ByVal PIN As String)

        Dim SQL As String
        SQL = "SELECT * FROM Employees WHERE PIN='" & PIN & "'"

        CheckConnection(cn)
        Dim cmdSearch As New SqlCommand(SQL, cn)
        Dim objReader As SqlDataReader = cmdSearch.ExecuteReader

        objReader.Read()
        If objReader.HasRows = True Then
            With frmEmployeeInfo
                .txtLastName.Text = objReader("LastName")
                .txtFirstName.Text = objReader("FirstName")
                .txtMiddleInitial.Text = objReader("MiddleInitial")
                .txtEmployeeNo.Text = objReader("PIN")
                .txtLastName.Text = objReader("LastName")
                .txtBasicSalary.Text = CheckNull(objReader("BasicSalary"), "Number")
                .dtpDateHired.Value = CheckNull(objReader("HireDate"), "Date")
                .dtpLastEmployed.Value = CheckNull(objReader("LastDateEmployed"), "Date")
                .txtEmails.Text = CheckNull(objReader("EmailAddress"), "")
                .txtHomePhone.Text = CheckNull(objReader("HomePhone"), "")
                .txtContactNo.Text = CheckNull(objReader("ContactNo"), "")
                .txtEmployeeStatusHistory.Text = CheckNull(objReader("EmployeeStatusHistory"), "")

                'check for employment status
                If IsDBNull(objReader("EmploymentStatus")) = True Then
                    .rbtnRegular.Checked = True
                    .rbtnContractual.Checked = False
                ElseIf objReader("EmploymentStatus") = "Regular" Then
                    .rbtnRegular.Checked = True
                    .rbtnContractual.Checked = False
                Else
                    .rbtnRegular.Checked = False
                    .rbtnContractual.Checked = True
                End If

                'check if record still active
                If CStr(objReader("Deactivated")) = "True" Then
                    .chkbxActive.Checked = False
                Else
                    .chkbxActive.Checked = True
                End If

                'check if record AutoCrossover
                If CStr(objReader("AutoCrossover")) = "True" Then
                    .chkbxCrossOver.Checked = True
                Else
                    .chkbxCrossOver.Checked = False
                End If

                'check if male/female(0=male,1=female)
                If CheckNull(objReader("Gender"), "Number") = 0 Then
                    .rbtnFemale.Checked = False
                    .rbtnMale.Checked = True
                Else
                    .rbtnFemale.Checked = True
                    .rbtnMale.Checked = False
                End If

                'check for Civil Status(0=single,1=married,else=widow)
                If IsDBNull(objReader("CivilStatus")) = True Then
                    .rbtnSingle.Checked = True
                    .rbtnMarried.Checked = False
                    .rbtnWidow.Checked = False
                ElseIf objReader("CivilStatus") = "" Then
                    .rbtnSingle.Checked = True
                    .rbtnMarried.Checked = False
                    .rbtnWidow.Checked = False
                ElseIf CheckNull(objReader("CivilStatus"), "Number") = 0 Then
                    .rbtnSingle.Checked = True
                    .rbtnMarried.Checked = False
                    .rbtnWidow.Checked = False
                ElseIf CheckNull(objReader("CivilStatus"), "Number") = 1 Then
                    .rbtnSingle.Checked = False
                    .rbtnMarried.Checked = True
                    .rbtnWidow.Checked = False
                Else
                    .rbtnSingle.Checked = False
                    .rbtnMarried.Checked = False
                    .rbtnWidow.Checked = True
                End If

                .dtpDateOfBirth.Value = CheckNull(objReader("BirthDate"), "Date")

                If (Date.Now.Month > .dtpDateOfBirth.Value.Month) Then
                    .txtAge.Text = CInt(Date.Now.Year) - CInt(.dtpDateOfBirth.Value.Year)
                ElseIf (Date.Now.Month = .dtpDateOfBirth.Value.Month) Then
                    If Date.Now.Day >= .dtpDateOfBirth.Value.Day Then
                        .txtAge.Text = CInt(Date.Now.Year) - CInt(.dtpDateOfBirth.Value.Year)
                    Else
                        .txtAge.Text = CInt(Date.Now.Year) - CInt(.dtpDateOfBirth.Value.Year) - 1
                    End If
                Else
                    .txtAge.Text = CInt(Date.Now.Year) - CInt(.dtpDateOfBirth.Value.Year) - 1
                End If

        .cmbxReligion.Text = CheckNull(objReader("Religion"), "")
        .txtChildren.Text = CheckNull(objReader("Children"), "")
        .txtSpouse.Text = CheckNull(objReader("Spouse"), "")
        .txtFather.Text = CheckNull(objReader("Father"), "")
        .txtMother.Text = CheckNull(objReader("Mother"), "")
        .txtElementary.Text = CheckNull(objReader("Elementary"), "")
        .txtHighSchool.Text = CheckNull(objReader("HighSchool"), "")
        .txtCollege.Text = CheckNull(objReader("College"), "")
        .txtDegree.Text = CheckNull(objReader("Degree"), "")
        .txtMajor.Text = CheckNull(objReader("Major"), "")
        .txtMaster.Text = CheckNull(objReader("Master"), "")
        .txtTinNo.Text = CheckNull(objReader("TIN"), "")
        .txtSSSNo.Text = CheckNull(objReader("SSSNumber"), "")
        .txtPagIbigNo.Text = CheckNull(objReader("PagIbigNumber"), "")
        .txtPhilHealth.Text = CheckNull(objReader("PhilHealth"), "")

        .txtHI_ID.Text = CheckNull(objReader("HI_ID"), "")
        .txtHI_Title.Text = CheckNull(objReader("HI_Title"), "")
        .txtLI_ID.Text = CheckNull(objReader("LI_ID"), "")
        .txtLI_Title.Text = CheckNull(objReader("LI_Title"), "")

        .txtEmergencyContactPerson.Text = CheckNull(objReader("EmergencyContactName"), "")
        .txtEmergencyContactNo.Text = CheckNull(objReader("EmergencyContactNumber"), "")

        .txtNote.Text = CheckNull(objReader("Notes"), "")

        'Load image
        If IsDBNull(objReader("Photo")) = False Then
            Dim arrayImage() As Byte = CType(objReader("Photo"), Byte())
            Dim ms As New IO.MemoryStream(arrayImage)
                    'Try
                    If arrayImage.Length <> 0 Then
                        .pcbxEmployeePic.Image = Image.FromStream(ms)
                    Else
                        .pcbxEmployeePic.Image = Image.FromFile(Application.StartupPath & "\EmployeePictures\0.jpg")
                    End If

                    'Catch ex As Exception
                    'MsgBox(ex.ToString)
                    'End Try
                Else
                    .pcbxEmployeePic.Image = Image.FromFile(Application.StartupPath & "\EmployeePictures\0.jpg")
                End If
            End With
        End If
        objReader.Close()
    End Sub

#End Region

#Region "Filling Function"

    Private Sub FillEmployee(ByVal Sqlstring As String)

        Dim LastName As String
        Dim FirstName As String
        Dim MiddleInitial As String

        Me.lstvwEmployee.Items.Clear()
        ds.Clear()

        Sqlda.SelectCommand = New SqlCommand(Sqlstring, cn)
        Sqlcmbldr = New SqlCommandBuilder(Sqlda)

        'On Error Resume Next

        Sqlda.Fill(ds)
        Me.lblTotalRecord.Text = "Total record: " & ds.Tables(0).Rows.Count
        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows
                Dim MyItem = Me.lstvwEmployee.Items.Add(dr("ID"), 0) '0
                MyItem.tag = X
                X = X + 1
                With MyItem

                    LastName = dr("Lastname".ToString)
                    FirstName = dr("Firstname".ToString)
                    MiddleInitial = dr("MiddleInitial".ToString)

                    .SubItems.Add(dr("PIN".ToString)) '1
                    .SubItems.Add(UCase(LastName & "," & FirstName & " " & MiddleInitial)) '2
                    If IsDBNull(dr("EmploymentStatus".ToString)) = False Then
                        .SubItems.Add(dr("EmploymentStatus".ToString)) '3
                    Else
                        .SubItems.Add("") '3
                    End If

                    .SubItems.Add(GetDepartment(dr("DepartmentCode".ToString))) '4
                    .SubItems.Add(GetPosition(dr("Position".ToString))) '5
                    .SubItems.Add(SetSpacing(GetDepartment(dr("DepartmentCode".ToString)), 80) & "~" & dr("DepartmentCode".ToString)) '6
                    .SubItems.Add(SetSpacing(GetPosition(dr("Position".ToString)), 80) & "~" & dr("Position".ToString)) '7
                    .SubItems.Add(dr("Deactivated".ToString)) '8
                    'Deactivated
                End With
            Next
        End If

        Dim z As Integer
        For z = 0 To Me.lstvwEmployee.Items.Count - 1
            If Me.lstvwEmployee.Items(z).SubItems(8).Text = "True" Then
                Me.lstvwEmployee.Items(z).Checked = True
            Else
                Me.lstvwEmployee.Items(z).Checked = False
            End If
        Next

    End Sub

    Private Sub FillDepartment(ByVal Sqlstring As String)

        Dim DepartmentCode As String
        Dim Department As String

        Me.cmbxDepartment.Items.Clear()
        CheckConnection(cn)
        Sqlda.SelectCommand = New SqlCommand(Sqlstring, cn)
        Sqlcmbldr = New SqlCommandBuilder(Sqlda)

        ds.Clear()
        Sqlda.Fill(ds)

        Me.cmbxDepartment.Items.Add("All")
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                Department = dr("DepartmentDescription")
                DepartmentCode = dr("DepartmentCode")

                Me.cmbxDepartment.Items.Add(SetSpacing(Department, 100) & "~" & DepartmentCode)
            Next
        End If

        Me.cmbxDepartment.Text = "All"

    End Sub

#End Region

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmEmployeeInfo.ShowDialog()
    End Sub

    Private Sub frmListEmployees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDepartment()
        Me.cmbxEmploymentStatus.Text = "All"
        Me.cmbxDepartment.Text = "All"
        LoadEmployees()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        With frmEmployeeInfo
            .ID = Me.lstvwEmployee.SelectedItems(0).Text
            .LoadDepartment()
            .LoadPosition()
            .LoadReligion()
            .LoadEmployeeTraining()
            .LoadEmployeeShift()
            .cmbxDepartment.Text = Me.lstvwEmployee.SelectedItems(0).SubItems(6).Text
            .cmbxPosition.Text = Me.lstvwEmployee.SelectedItems(0).SubItems(7).Text
            GetEmployeeInfo(Me.lstvwEmployee.SelectedItems(0).SubItems(1).Text)
            .ShowDialog()
        End With

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        LoadEmployees()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        DeleteData("Employees", Me.lstvwEmployee.SelectedItems(0).SubItems(2).Text, "ID", Me.lstvwEmployee.SelectedItems(0).Text, Me.lstvwEmployee.SelectedItems(0).SubItems(2).Text & " has been successfully deleted.")
        Me.LoadEmployees()
    End Sub

    Private Sub cmsListOfEmployee_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmsListOfEmployee.Opening
        If Me.lstvwEmployee.SelectedItems.Count > 0 Then
            Me.EditToolStripMenuItem.Enabled = True
            Me.DeleteToolStripMenuItem.Enabled = True
        Else
            Me.EditToolStripMenuItem.Enabled = False
            Me.DeleteToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyValue = Keys.Enter Then
            LoadEmployees()
        End If
    End Sub

    Private Sub AddToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        With frmAddEmployee
            .LoadDepartment()
            .ShowDialog()
        End With
    End Sub

    Private Sub btnDeActivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeActivate.Click
        If MessageBox.Show("Are you sure you want to de-activate the list of employees?", "De-Activate", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim z As Integer
            Dim Active As Boolean

            For z = 0 To Me.lstvwEmployee.Items.Count - 1
                If Me.lstvwEmployee.Items(z).Checked = True Then
                    Active = True
                Else
                    Active = False
                End If
                UpdateData("Employees", "Deactivated='" & Active & "'", "ID", Me.lstvwEmployee.Items(z).Text, "")
            Next
            LoadEmployees()
        End If
    End Sub

End Class