'Programmed by: Aldwin Mark F. Solis
'Date: 10-18-2010
'Title: 201 file of Employee

Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmEmployeeInfo

#Region "Variable Declaration"
    Friend ID As String
    Friend NoPic As Boolean
#End Region

#Region "User Function"

    Private Function getPosition(ByVal str As String) As String
        Dim arrstr(2) As String
        arrstr = str.Split("~")
        getPosition = Trim(arrstr(0))
        Return getPosition
    End Function

    Private Function getDepartment(ByVal str As String) As String
        Dim arrstr(2) As String
        arrstr = str.Split("~")
        getDepartment = Trim(arrstr(0))
        Return getDepartment
    End Function

    Private Function getCivilStatus() As String
        If Me.rbtnSingle.Checked = True Then
            getCivilStatus = "Single"
        ElseIf Me.rbtnMarried.Checked = True Then
            getCivilStatus = "Married"
        Else
            getCivilStatus = "Widow"
        End If
        Return getCivilStatus
    End Function

    Private Function getGender() As String
        If Me.rbtnMale.Checked = True Then
            getGender = "Male"
        Else
            getGender = "Female"
        End If
        Return getGender
    End Function

    Private Function getACO() As String
        If Me.chkbxCrossOver.Checked = True Then
            getACO = "True"
        Else
            getACO = "False"
        End If
        Return getACO
    End Function

    Private Function getActive() As String
        If Me.chkbxActive.Checked = True Then
            getActive = "Active"
        Else
            getActive = "Not Active"
        End If
        Return getActive
    End Function

    Private Function getStatus() As String
        If Me.rbtnRegular.Checked = True Then
            getStatus = "Regular"
        Else
            getStatus = "Contractual"
        End If
        Return getStatus
    End Function

    Public Sub print201File()

        '+++++++++++++++++++++++EMPLOYEE PROFILE
        Dim strStatus As String
        Dim strEmployeeName As String
        Dim strEmployeeNo As String
        Dim strDEpartment As String
        Dim strPosition As String
        Dim strSalary As String
        Dim strDateHired As String
        'Dim strLDE As String
        Dim strEmail As String
        Dim strHistory As String
        Dim strActive As String
        Dim strACO As String
        Dim strHomeNo As String
        Dim strContactNo As String
        '+++++++++++++++++++++++EMPLOYEE PROFILE
        '+++++++++++++++++++++++PERSONAL PROFILE
        Dim strGender As String
        Dim strReligion As String
        Dim strSpouse As String
        Dim strFather As String
        Dim strMother As String
        Dim strDOB As String
        Dim strCivilStatus As String
        Dim strChildren As String
        '+++++++++++++++++++++++PERSONAL PROFILE
        '+++++++++++++++++++++++EDUCATIONAL PROFILE
        Dim strElem As String
        Dim strHS As String
        Dim strCollege As String
        Dim strDegree As String
        Dim strMajor As String
        Dim strMD As String
        Dim strDD As String
        '+++++++++++++++++++++++EDUCATIONAL PROFILE
        '+++++++++++++++++++++++ADDITIONAL PROFILE
        Dim strTIN As String
        Dim strSSS As String
        Dim strPagIbig As String
        Dim strPH As String
        Dim strECP As String
        Dim strECPNo As String
        Dim strNote As String
        Dim strHIID As String
        Dim strHITitle As String
        Dim strLIID As String
        Dim strLITitle As String
        '+++++++++++++++++++++++EDUCATIONAL PROFILE
        'Text Object************************************************
        '-----------+++++++++++++++++++++++EMPLOYEE PROFILE
        Dim Status As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim EmployeeName As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim EmployeeNo As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim DEpartment As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Position As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Salary As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim DateHired As CrystalDecisions.CrystalReports.Engine.TextObject
        'Dim LDE As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Email As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim History As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Active As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim ACO As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim HomeNo As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim ContactNo As CrystalDecisions.CrystalReports.Engine.TextObject
        '+++++++++++++++++++++++EMPLOYEE PROFILE
        '+++++++++++++++++++++++PERSONAL PROFILE
        Dim Gender As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Religion As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Spouse As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Father As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Mother As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim DOB As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim CivilStatus As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Children As CrystalDecisions.CrystalReports.Engine.TextObject
        '+++++++++++++++++++++++PERSONAL PROFILE
        '+++++++++++++++++++++++EDUCATIONAL PROFILE
        Dim Elem As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim HS As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim College As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Degree As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Major As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim MD As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim DD As CrystalDecisions.CrystalReports.Engine.TextObject
        '+++++++++++++++++++++++EDUCATIONAL PROFILE
        '+++++++++++++++++++++++ADDITIONAL PROFILE
        Dim TIN As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim SSS As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim PagIbig As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim PH As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim ECP As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim ECPNo As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Note As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim HIID As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim HITitle As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim LIID As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim LITitle As CrystalDecisions.CrystalReports.Engine.TextObject
        '+++++++++++++++++++++++EDUCATIONAL PROFILE

        Dim crSections As Sections
        Dim crSection As Section
        Dim crReportObjects As ReportObjects
        Dim myTable As CrystalDecisions.CrystalReports.Engine.Table
        Dim myLogin As CrystalDecisions.Shared.TableLogOnInfo

        Dim repDoc

        repDoc = New crptEmployeeProfile

        strStatus = getStatus()
        strEmployeeName = Me.txtLastName.Text & ", " & Me.txtFirstName.Text & " " & Me.txtMiddleInitial.Text & "."
        strEmployeeNo = Me.txtEmployeeNo.Text
        strDEpartment = getDepartment(Me.cmbxDepartment.Text)
        strPosition = getPosition(Me.cmbxPosition.Text)
        strSalary = Me.txtBasicSalary.Text
        strDateHired = Me.dtpDateHired.Text
        'Dim strLDE As String
        strEmail = Me.txtEmails.Text
        strHistory = Me.txtEmployeeStatusHistory.Text
        strActive = getActive()
        strACO = getACO()
        strHomeNo = Me.txtHomePhone.Text
        strContactNo = Me.txtContactNo.Text
        strGender = getGender()
        strReligion = Me.cmbxReligion.Text
        strSpouse = Me.txtSpouse.Text
        strFather = Me.txtFather.Text
        strMother = Me.txtMother.Text
        strDOB = Me.dtpDateOfBirth.Value
        strCivilStatus = getCivilStatus()
        strChildren = Me.txtChildren.Text
        strElem = Me.txtElementary.Text
        strHS = Me.txtHighSchool.Text
        strCollege = Me.txtCollege.Text
        strDegree = Me.txtDegree.Text
        strMajor = Me.txtMajor.Text
        strMD = Me.txtMaster.Text
        strDD = Me.txtDoctorate.Text
        strTIN = Me.txtTinNo.Text
        strSSS = Me.txtSSSNo.Text
        strPagIbig = Me.txtPagIbigNo.Text
        strPH = Me.txtPhilHealth.Text
        strECP = Me.txtEmergencyContactPerson.Text
        strECPNo = Me.txtEmergencyContactNo.Text
        strNote = Me.txtNote.Text
        strHIID = Me.txtHI_ID.Text
        strHITitle = Me.txtHI_Title.Text
        strLIID = Me.txtLI_ID.Text
        strLITitle = Me.txtLI_Title.Text

        '-----------+++++++++++++++++++++++EMPLOYEE PROFILE
        Status = repDoc.ReportDefinition.ReportObjects.Item("txtStatus")
        EmployeeName = repDoc.ReportDefinition.ReportObjects.Item("txtEmployeeName")
        EmployeeNo = repDoc.ReportDefinition.ReportObjects.Item("txtEmployeeNo")
        DEpartment = repDoc.ReportDefinition.ReportObjects.Item("txtDepartment")
        Position = repDoc.ReportDefinition.ReportObjects.Item("txtPosition")
        Salary = repDoc.ReportDefinition.ReportObjects.Item("txtSalary")
        DateHired = repDoc.ReportDefinition.ReportObjects.Item("txtDateHired")
        'LDE = repDoc.ReportDefinition.ReportObjects.Item("txt")
        Email = repDoc.ReportDefinition.ReportObjects.Item("txtEmail")
        History = repDoc.ReportDefinition.ReportObjects.Item("txtHistory")
        Active = repDoc.ReportDefinition.ReportObjects.Item("txtActive")
        ACO = repDoc.ReportDefinition.ReportObjects.Item("txtACO")
        HomeNo = repDoc.ReportDefinition.ReportObjects.Item("txtHomeNo")
        ContactNo = repDoc.ReportDefinition.ReportObjects.Item("txtContactNo")
        '+++++++++++++++++++++++EMPLOYEE PROFILE
        '+++++++++++++++++++++++PERSONAL PROFILE
        Gender = repDoc.ReportDefinition.ReportObjects.Item("txtGender")
        Religion = repDoc.ReportDefinition.ReportObjects.Item("txtReligion")
        Spouse = repDoc.ReportDefinition.ReportObjects.Item("txtSpouse")
        Father = repDoc.ReportDefinition.ReportObjects.Item("txtFather")
        Mother = repDoc.ReportDefinition.ReportObjects.Item("txtMother")
        DOB = repDoc.ReportDefinition.ReportObjects.Item("txtDateOfBirth")
        CivilStatus = repDoc.ReportDefinition.ReportObjects.Item("txtCivilStatus")
        Children = repDoc.ReportDefinition.ReportObjects.Item("txtChildren")
        '+++++++++++++++++++++++PERSONAL PROFILE
        '+++++++++++++++++++++++EDUCATIONAL PROFILE
        Elem = repDoc.ReportDefinition.ReportObjects.Item("txtElem")
        HS = repDoc.ReportDefinition.ReportObjects.Item("txtHS")
        College = repDoc.ReportDefinition.ReportObjects.Item("txtCollege")
        Degree = repDoc.ReportDefinition.ReportObjects.Item("txtDegree")
        Major = repDoc.ReportDefinition.ReportObjects.Item("txtMajor")
        MD = repDoc.ReportDefinition.ReportObjects.Item("txtMaster")
        DD = repDoc.ReportDefinition.ReportObjects.Item("txtDoctorate")
        '+++++++++++++++++++++++EDUCATIONAL PROFILE
        '+++++++++++++++++++++++ADDITIONAL PROFILE
        TIN = repDoc.ReportDefinition.ReportObjects.Item("txtTIN")
        SSS = repDoc.ReportDefinition.ReportObjects.Item("txtSSS")
        PagIbig = repDoc.ReportDefinition.ReportObjects.Item("txtPAGIBIG")
        PH = repDoc.ReportDefinition.ReportObjects.Item("txtPhil")
        ECP = repDoc.ReportDefinition.ReportObjects.Item("txtECP")
        ECPNo = repDoc.ReportDefinition.ReportObjects.Item("txtECPNo")
        Note = repDoc.ReportDefinition.ReportObjects.Item("txtNote")
        HIID = repDoc.ReportDefinition.ReportObjects.Item("txtHIID")
        HITitle = repDoc.ReportDefinition.ReportObjects.Item("txtHITitle")
        LIID = repDoc.ReportDefinition.ReportObjects.Item("LIID")
        LITitle = repDoc.ReportDefinition.ReportObjects.Item("txtLITitle")
        '+++++++++++++++++++++++EDUCATIONAL PROFILE
        '******************************
        '-----------+++++++++++++++++++++++EMPLOYEE PROFILE
        Status.Text = strStatus
        EmployeeName.Text = strEmployeeName
        EmployeeNo.Text = strEmployeeNo
        DEpartment.Text = strDEpartment
        Position.Text = strPosition
        Salary.Text = strSalary
        DateHired.Text = strDateHired
        'LDE.Text = strLDE
        Email.Text = strEmail
        History.Text = strHistory
        Active.Text = strActive
        ACO.Text = strACO
        HomeNo.Text = strHomeNo
        ContactNo.Text = strContactNo
        '+++++++++++++++++++++++EMPLOYEE PROFILE
        '+++++++++++++++++++++++PERSONAL PROFILE
        Gender.Text = strGender
        Religion.Text = strReligion
        Spouse.Text = strSpouse
        Father.Text = strFather
        Mother.Text = strMother
        DOB.Text = strDOB
        CivilStatus.Text = strCivilStatus
        Children.Text = strChildren
        '+++++++++++++++++++++++PERSONAL PROFILE
        '+++++++++++++++++++++++EDUCATIONAL PROFILE
        Elem.Text = strElem
        HS.Text = strHS
        College.Text = strCollege
        Major.Text = strMajor
        MD.Text = strMD
        DD.Text = strDD
        '+++++++++++++++++++++++EDUCATIONAL PROFILE
        '+++++++++++++++++++++++ADDITIONAL PROFILE
        TIN.Text = strTIN
        SSS.Text = strSSS
        PagIbig.Text = strPagIbig
        PH.Text = strPH
        ECP.Text = strECP
        ECPNo.Text = strECPNo
        Note.Text = strNote
        HIID.Text = strHIID
        HITitle.Text = strHITitle
        LIID.Text = strLIID
        LITitle.Text = strLIID
        '+++++++++++++++++++++++EDUCATIONAL PROFILE

        '**********************
        For Each myTable In repDoc.Database.Tables
            myLogin = myTable.LogOnInfo
            myLogin.ConnectionInfo.ServerName = "192.168.1.254"
            myLogin.ConnectionInfo.DatabaseName = "FingerID"
            myLogin.ConnectionInfo.UserID = "sa"
            myLogin.ConnectionInfo.Password = "zAm@1974101800"
            myTable.ApplyLogOnInfo(myLogin)
        Next

        crSections = repDoc.ReportDefinition.Sections
        'loop through all the sections to find all the report objects
        For Each crSection In crSections
            crReportObjects = crSection.ReportObjects
        Next
        frmReport201File.crptvw201File.ReportSource = repDoc
        frmReport201File.crptvw201File.SelectionFormula = "{Employees.PIN}=" & CInt(strEmployeeNo) & ""
        frmReport201File.ShowDialog()
    End Sub

    Private Function GetTrainingTitle(ByVal Training_ID As String) As String

        Dim SQL As String

        SQL = "SELECT * FROM tblTrainings WHERE ID='" & Training_ID & "'"

        CheckConnection(cn)
        Dim cmdSearch As New SqlCommand(SQL, cn)
        Dim objReader As SqlDataReader = cmdSearch.ExecuteReader

        objReader.Read()
        If objReader.HasRows = True Then
            GetTrainingTitle = objReader("Title")
        Else
            GetTrainingTitle = ""
        End If

        objReader.Close()

        Return GetTrainingTitle

    End Function

    Private Function GetTrainingStartDate(ByVal Training_ID As String) As String

        Dim SQL As String

        SQL = "SELECT * FROM tblTrainings WHERE ID='" & Training_ID & "'"

        CheckConnection(cn)
        Dim cmdSearch As New SqlCommand(SQL, cn)
        Dim objReader As SqlDataReader = cmdSearch.ExecuteReader

        objReader.Read()
        If objReader.HasRows = True Then
            GetTrainingStartDate = objReader("StartDate")
        Else
            GetTrainingStartDate = ""
        End If

        objReader.Close()

        Return GetTrainingStartDate

    End Function

    Private Function GetTrainingEndDate(ByVal Training_ID As String) As String

        Dim SQL As String

        SQL = "SELECT * FROM tblTrainings WHERE ID='" & Training_ID & "'"

        CheckConnection(cn)
        Dim cmdSearch As New SqlCommand(SQL, cn)
        Dim objReader As SqlDataReader = cmdSearch.ExecuteReader

        objReader.Read()
        If objReader.HasRows = True Then
            GetTrainingEndDate = objReader("EndDate")
        Else
            GetTrainingEndDate = ""
        End If

        objReader.Close()

        Return GetTrainingEndDate

    End Function

#End Region

#Region "Loading Data"

    Public Sub LoadDepartment()
        FillDepartment("SELECT * FROM Department")
    End Sub

    Public Sub LoadPosition()
        FillPosition("SELECT * FROM tblPositions")
    End Sub

    Public Sub LoadReligion()
        FillReligion("SELECT * FROM tblReligions")
    End Sub

    Public Sub LoadEmployeeTraining()
        FillEmployeeTraining("SELECT * FROM tblEmployeeTrainings WHERE Employee_ID='" & ID & "' ORDER BY ID ASC")
    End Sub

    Public Sub LoadEmployeeShift()
        FillEmployeeShift("SELECT * FROM tblShift WHERE Employee_ID='" & ID & "' ORDER BY ID_Shift ASC")
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

    Private Sub FillPosition(ByVal Sqlstring As String)

        Dim PositionCode As String
        Dim Position As String

        Me.cmbxPosition.Items.Clear()
        CheckConnection(cn)
        Sqlda.SelectCommand = New SqlCommand(Sqlstring, cn)
        Sqlcmbldr = New SqlCommandBuilder(Sqlda)

        ds.Clear()
        Sqlda.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                Position = dr("PositionTitle")
                PositionCode = dr("ID")

                Me.cmbxPosition.Items.Add(SetSpacing(Position, 80) & "~" & PositionCode)
            Next
        End If

    End Sub

    Private Sub FillReligion(ByVal Sqlstring As String)

        Me.cmbxReligion.Items.Clear()
        CheckConnection(cn)
        Sqlda.SelectCommand = New SqlCommand(Sqlstring, cn)
        Sqlcmbldr = New SqlCommandBuilder(Sqlda)

        ds.Clear()
        Sqlda.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                Me.cmbxReligion.Items.Add(dr("Title"))
            Next
        End If

    End Sub

    Private Sub FillEmployeeTraining(ByVal Sqlstring As String)

        Me.lstvwTrainings.Items.Clear()
        ds.Clear()

        Sqlda.SelectCommand = New SqlCommand(Sqlstring, cn)
        Sqlcmbldr = New SqlCommandBuilder(Sqlda)

        'On Error Resume Next
        Sqlda.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows
                Dim MyItem = Me.lstvwTrainings.Items.Add(dr("ID"), 0) '0
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(GetTrainingTitle(dr("Training_ID".ToString))) '1           
                    .SubItems.Add(GetTrainingStartDate(dr("Training_ID".ToString))) '2      
                    .SubItems.Add(GetTrainingEndDate(dr("Training_ID".ToString))) '3           
                End With
            Next
        End If
    End Sub

    Private Sub FillEmployeeShift(ByVal Sqlstring As String)

        Me.lstvwShifts.Items.Clear()
        ds.Clear()

        Sqlda.SelectCommand = New SqlCommand(Sqlstring, cn)
        Sqlcmbldr = New SqlCommandBuilder(Sqlda)

        'On Error Resume Next
        Sqlda.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows
                Dim MyItem = Me.lstvwShifts.Items.Add(dr("ID_Shift"), 0) '0
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("Day".ToString)) '1           
                    .SubItems.Add(dr("AMIn".ToString)) '2      
                    .SubItems.Add(dr("AMOut".ToString)) '3     
                    .SubItems.Add(dr("PMIn".ToString)) '4         
                    .SubItems.Add(dr("PMOut".ToString)) '5
                    .SubItems.Add(dr("DateFrom".ToString)) '6
                    .SubItems.Add(dr("DateTo".ToString)) '7
                End With
            Next
        End If
    End Sub

#End Region

    Private Sub txtBasicSalary_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBasicSalary.KeyDown
        ChangeSign(sender, e)
    End Sub

    Private Sub txtBasicSalary_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBasicSalary.KeyPress
        CurrencyCheckPeriod(sender, e)
    End Sub

    Private Sub txtBasicSalary_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBasicSalary.TextChanged
        RestrictCurrency(sender, e)
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim ms As New MemoryStream()
        'If NoPic = False Then
        Me.pcbxEmployeePic.Image.Save(ms, pcbxEmployeePic.Image.RawFormat)
        'End If


        Dim arrImage() As Byte = ms.GetBuffer
        ms.Close()

        Dim EmploymentStatus As String
        Dim Gender As Integer
        Dim CivilStatus As String
        Dim Active As Boolean
        Dim AutoCrossOver As Boolean
        Dim DepartmentCode(2) As String
        Dim PositionCode(2) As String

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
        ElseIf Len(Me.cmbxPosition.Text.Trim(" ")) = 0 Then
            MessageBox.Show("Please select a position.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxPosition.Focus()
            'ElseIf Len(Me.txtBasicSalary.Text.Trim(" ")) = 0 Then
            '    MessageBox.Show("Please enter a basic salary.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Me.txtBasicSalary.Focus()
            'ElseIf Len(Me.txtContactNo.Text.Trim(" ")) = 0 Then
            '    MessageBox.Show("Please enter a contact no.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Me.txtContactNo.Focus()
            'ElseIf Len(Me.cmbxReligion.Text.Trim(" ")) = 0 Then
            '    MessageBox.Show("Please select a religion.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Me.cmbxReligion.Focus()
        ElseIf Me.rbtnMarried.Checked = True And Len(Me.txtSpouse.Text.Trim(" ")) = 0 Then
            MessageBox.Show("Please enter spouse name.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtSpouse.Focus()
        ElseIf Me.rbtnWidow.Checked = True And Len(Me.txtSpouse.Text.Trim(" ")) = 0 Then
            MessageBox.Show("Please enter a spouse name.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtSpouse.Focus()
            'ElseIf Not Len(Me.txtHI_ID.Text.Trim(" ")) = 0 And Len(Me.txtHI_Title.Text.Trim(" ")) = 0 Then
            '    MessageBox.Show("Please enter title of health insurance.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Me.txtHI_Title.Focus()
            'ElseIf Not Len(Me.txtLI_ID.Text.Trim(" ")) = 0 And Len(Me.txtLI_Title.Text.Trim(" ")) = 0 Then
            '    MessageBox.Show("Please enter title of life insurance.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Me.txtLI_Title.Focus()
            'ElseIf Len(Me.txtEmergencyContactPerson.Text.Trim(" ")) = 0 Then
            '    MessageBox.Show("Please enter a name of the person in case of emergency.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Me.txtEmergencyContactPerson.Focus()
            'ElseIf Len(Me.txtEmergencyContactNo.Text.Trim(" ")) = 0 Then
            '    MessageBox.Show("Please enter contact no. of emergency contact person.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Me.txtEmergencyContactNo.Focus()
        Else
            'Employment Status
            If Me.rbtnRegular.Checked = True Then
                EmploymentStatus = "Regular"
            Else
                EmploymentStatus = "Contractual"
            End If
            'Gender
            If Me.rbtnMale.Checked = True Then
                Gender = "0"
            Else
                Gender = "1"
            End If
            'Civil Status
            If Me.rbtnSingle.Checked = True Then
                CivilStatus = "0"
            ElseIf Me.rbtnMarried.Checked = True Then
                CivilStatus = "1"
            Else
                CivilStatus = "2"
            End If

            'Deactivated
            If Me.chkbxActive.Checked = True Then
                Active = False
            Else
                Active = True
            End If

            'AutoCrossOver
            If Me.chkbxCrossOver.Checked = True Then
                AutoCrossOver = True
            Else
                AutoCrossOver = False
            End If

            DepartmentCode = Me.cmbxDepartment.Text.Split("~")
            PositionCode = Me.cmbxPosition.Text.Split("~")

            UpdateData("Employees", "LastName='" & CSQ(Me.txtLastName.Text) & "'" & _
                                    ",FirstName='" & CSQ(Me.txtFirstName.Text) & "'" & _
                                    ",MiddleInitial='" & CSQ(Me.txtMiddleInitial.Text) & "'" & _
                                    ",PIN='" & Me.txtEmployeeNo.Text & "'" & _
                                    ",DepartmentCode='" & DepartmentCode(1) & "'" & _
                                    ",Position='" & PositionCode(1) & "'" & _
                                    ",BasicSalary='" & Me.txtBasicSalary.Text & "'" & _
                                    ",HireDate='" & Me.dtpDateHired.Value & "'" & _
                                    ",ContactNo='" & Me.txtContactNo.Text & "'" & _
                                    ",BirthDate='" & Me.dtpDateOfBirth.Value & "'" & _
                                    ",Religion='" & Me.cmbxReligion.Text & "'" & _
                                    ",EmploymentStatus='" & EmploymentStatus & "'" & _
                                    ",Gender='" & Gender & "'" & _
                                    ",CivilStatus='" & CivilStatus & "'" & _
                                    ",EmergencyContactName='" & CSQ(Me.txtEmergencyContactPerson.Text) & "'" & _
                                    ",EmergencyContactNumber='" & CSQ(Me.txtEmergencyContactNo.Text) & "'" & _
                                    ",Deactivated='" & Active & "'" & _
                                    ",AutoCrossover='" & AutoCrossOver & "'" & _
                                    ",LastDateEmployed='" & Me.dtpLastEmployed.Value & "'" & _
                                    ",EmailAddress='" & CSQ(Me.txtEmails.Text) & "'" & _
                                    ",HomePhone='" & Me.txtHomePhone.Text & "'" & _
                                    ",Children='" & CSQ(Me.txtChildren.Text) & "'" & _
                                    ",Spouse='" & CSQ(Me.txtSpouse.Text) & "'" & _
                                    ",Father='" & CSQ(Me.txtFather.Text) & "'" & _
                                    ",Mother='" & CSQ(Me.txtMother.Text) & "'" & _
                                    ",Elementary='" & CSQ(Me.txtElementary.Text) & "'" & _
                                    ",HighSchool='" & CSQ(Me.txtHighSchool.Text) & "'" & _
                                    ",College='" & CSQ(Me.txtCollege.Text) & "'" & _
                                    ",Degree='" & CSQ(Me.txtDegree.Text) & "'" & _
                                    ",Major='" & CSQ(Me.txtMajor.Text) & "'" & _
                                    ",Master='" & CSQ(Me.txtMaster.Text) & "'" & _
                                    ",TIN='" & Me.txtTinNo.Text & "'" & _
                                    ",SSSNumber='" & Me.txtSSSNo.Text & "'" & _
                                    ",PagIbigNumber='" & Me.txtPagIbigNo.Text & "'" & _
                                    ",PhilHealth='" & Me.txtPhilHealth.Text & "'" & _
                                    ",HI_ID='" & Me.txtHI_ID.Text & "'" & _
                                    ",HI_Title='" & CSQ(Me.txtHI_Title.Text) & "'" & _
                                    ",LI_ID='" & Me.txtLI_ID.Text & "'" & _
                                    ",LI_Title='" & CSQ(Me.txtLI_Title.Text) & "'" & _
                                    ",EmployeeStatusHistory='" & CSQ(Me.txtEmployeeStatusHistory.Text) & "'" & _
                                    ",Notes='" & Me.txtNote.Text & "'", "ID", ID, "Data has been successfully updated.")


            'update imageTable set photo = ?
            CheckConnection(cn)
            Dim strQuery As String = "UPDATE Employees SET Photo=@Picture WHERE ID='" & ID & "'"

            Dim objcommand As New SqlCommand(strQuery, cn)
            With objcommand
                .Parameters.Add(New SqlParameter("@Picture", SqlDbType.Image)).Value = arrImage
            End With

            objcommand.ExecuteNonQuery()

            frmListEmployees.LoadEmployees()
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub chkbxActive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxActive.CheckedChanged
        If Me.chkbxActive.Checked = True Then
            Me.dtpLastEmployed.Enabled = False
        Else
            Me.dtpLastEmployed.Enabled = True
        End If
    End Sub

    Private Sub rbtnSingle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnSingle.CheckedChanged
        If Me.rbtnSingle.Checked = True Then
            Me.txtSpouse.Enabled = False
        Else
            Me.txtSpouse.Enabled = True
        End If
    End Sub

    Private Sub frmEmployeeInfo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub cmsTrainings_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmsTrainings.Opening
        If Me.lstvwTrainings.SelectedItems.Count > 0 Then
            Me.DeleteTraininglStripMenuItem.Enabled = True
        Else
            Me.DeleteTraininglStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub AddTraininglStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddTraininglStripMenuItem.Click
        With frmEmployeeTrainings
            .Employee_ID = ID
            .cmbxTraining.Focus()
            .ShowDialog()
        End With
    End Sub

    Private Sub DeleteTraininglStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteTraininglStripMenuItem.Click
        DeleteData("tblEmployeeTrainings", Me.lstvwTrainings.SelectedItems(0).SubItems(1).Text, "ID", Me.lstvwTrainings.SelectedItems(0).Text, Me.lstvwTrainings.SelectedItems(0).SubItems(1).Text & " has been successfully deleted.")
        Me.LoadEmployeeTraining()
    End Sub

    Private Sub btnSearchPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchPic.Click
        ' Use an OpenFileDialog to enable the user to find an image to save to the 
        ' database. Provide a pipe-delimited set of pipe-delimited pairs of file 
        ' types that will appear in the dialog. Set the FilterIndex to the default 
        ' file type.
        With ofdEmplyeePic
            .FileName = ""
            .Filter = "All Files|*.*|JPEGs|*.jpg|GIFs|*.gif|Bitmaps|*.bmp"
            .FilterIndex = 2
        End With

        ' When the user clicks the Open button (DialogResult.OK is the only option;
        ' there is not DialogResult.Open), display the image centered in the 
        ' PictureBox and display the full path of the image.
        If ofdEmplyeePic.ShowDialog() = Windows.Forms.DialogResult.OK Then
            With Me.pcbxEmployeePic
                .Image = Image.FromFile(Me.ofdEmplyeePic.FileName)
                .SizeMode = PictureBoxSizeMode.StretchImage
                .BorderStyle = BorderStyle.Fixed3D
            End With
            Me.lblPicPath.Text = ofdEmplyeePic.FileName
        End If
    End Sub

    Private Sub AddShiftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddShiftToolStripMenuItem.Click
        With frmShiftEntry
            .Employee_ID = ID
            .ShowDialog()
        End With
    End Sub

    Private Sub cmsShifts_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmsShifts.Opening
        If Me.lstvwShifts.SelectedItems.Count > 0 Then
            Me.DeleteShiftToolStripMenuItem.Enabled = True
        Else
            Me.DeleteShiftToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadEmployeeShift()
    End Sub

    Private Sub RefreshTraininglStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshTraininglStripMenuItem.Click
        LoadEmployeeTraining()
    End Sub

    Private Sub DeleteShiftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteShiftToolStripMenuItem.Click
        DeleteData("tblShift", Me.lstvwShifts.SelectedItems(0).SubItems(1).Text, "ID_Shift", Me.lstvwShifts.SelectedItems(0).Text, Me.lstvwShifts.SelectedItems(0).SubItems(1).Text & " has been successfully deleted.")
        Me.LoadEmployeeShift()
    End Sub

    Private Sub btnPrint201_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint201.Click
        Call print201File()
    End Sub

End Class