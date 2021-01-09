'Programmed by: Aldwin Mark F. Solis
'Date: 10-07-2010
'Title: Printing of Daily Time Record

Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmPrintDTR

#Region "Variable Declaration"
#End Region

#Region "User Function"


    Function GetTotalWorkingHours(ByVal PIN As String) As Double

        Return 0
    End Function


    Function GetShift(ByVal Day As String, ByVal Employee_ID As String) As String

        Dim RestDay As Boolean = False
        Dim HalfDay As Boolean = False
        Dim ShifttTimeAM As Date
        Dim ShifttTimePM As Date

        Dim ShifttDay As String
        If Day = 0 Then
            ShifttDay = "Sunday"
            RestDay = True
        ElseIf Day = 1 Then
            ShifttDay = "Monday"
        ElseIf Day = 2 Then
            ShifttDay = "Tuesday"
        ElseIf Day = 3 Then
            ShifttDay = "Wednesday"
        ElseIf Day = 4 Then
            ShifttDay = "Thursday"
        ElseIf Day = 5 Then
            ShifttDay = "Friday"
        Else
            ShifttDay = "Saturday"
            HalfDay = True
        End If

        CheckConnection(cn)
        Dim cmdSearch As New SqlCommand("SELECT * FROM tblShift WHERE Employee_ID='" & Employee_ID & "' AND Day='" & ShifttDay & "'", cn)
        Dim objReader As SqlDataReader = cmdSearch.ExecuteReader

        objReader.Read()

        If objReader.HasRows = True Then
            ShifttTimeAM = objReader("AMIn")
            ShifttTimePM = objReader("PMOut")
            GetShift = ShifttTimeAM.ToShortTimeString & "-" & ShifttTimePM.ToShortTimeString
        Else
            'default shift for every employee
            If HalfDay = True Then
                GetShift = "08:00-12:00"
            Else
                If RestDay = False Then
                    GetShift = "08:00-05:00"
                Else
                    GetShift = "Rest Day"
                End If
            End If
        End If

        'close the reader
        objReader.Close()
        Return GetShift
    End Function

    Function GetOT(ByVal Day As String, ByVal Employee_ID As String, ByVal AMOut As String, ByVal PMOut As String) As Integer

        'declare halfday as boolean
        Dim HalfDay As Boolean = False

        'Initialize function to 0
        GetOT = 0

        Dim ShifttTimeAM As Date
        Dim ShifttTimePM As Date

        Dim TimeAM As Date
        Dim TimePM As Date

        Dim compTimeAM As Integer = 0
        Dim compTimePM As Integer = 0

        'declaration
        Dim ShifttDay As String

        'check if what day, which has different computations
        If Day = 0 Then
            ShifttDay = "Sunday"
        ElseIf Day = 1 Then
            ShifttDay = "Monday"
        ElseIf Day = 2 Then
            ShifttDay = "Tuesday"
        ElseIf Day = 3 Then
            ShifttDay = "Wednesday"
        ElseIf Day = 4 Then
            ShifttDay = "Thursday"
        ElseIf Day = 5 Then
            ShifttDay = "Friday"
        Else
            ShifttDay = "Saturday"
            HalfDay = True
        End If

        'check if has a shifting schedules
        CheckConnection(cn)
        Dim cmdSearch As New SqlCommand("SELECT * FROM tblShift WHERE Employee_ID='" & Employee_ID & "' AND Day='" & ShifttDay & "'", cn)
        Dim objReader As SqlDataReader = cmdSearch.ExecuteReader

        objReader.Read()

        If objReader.HasRows = True Then
            ShifttTimeAM = objReader("AMOut")
            ShifttTimePM = objReader("PMOut")
        Else
            'if no shifting schedule
            If HalfDay = True Or PMOut = "" Then
                ShifttTimeAM = "08:00 AM"
                ShifttTimePM = "12:00 PM"
            Else
                ShifttTimeAM = "08:00 AM"
                ShifttTimePM = "05:00 PM"
            End If
        End If
        'if AMOut has a value and PMOut has no value
        If AMOut <> "" And PMOut = "" Then
            TimeAM = AMOut
            'compTimeAM = DateDiff(DateInterval.Minute, ShifttTimeAM, TimeAM)
            compTimePM = DateDiff(DateInterval.Minute, ShifttTimePM, TimeAM)
        ElseIf Not PMOut = "" And AMOut = "" Then
            'tmpTimePM = PMOut
            'tmp1 = DateDiff(DateInterval.Minute, ShifttTimeAM, TimePM)
            'tmp2 = DateDiff(DateInterval.Minute, ShifttTimePM, TimePM)
        ElseIf PMOut <> "" And AMOut <> "" Then
            TimeAM = AMOut
            TimePM = PMOut
            compTimeAM = DateDiff(DateInterval.Minute, ShifttTimeAM, TimeAM)
            compTimePM = DateDiff(DateInterval.Minute, ShifttTimePM, TimePM)
        End If

        If compTimeAM > 0 And compTimePM < 0 Then
            GetOT = compTimeAM
        ElseIf compTimePM > 0 And compTimeAM < 0 Then
            GetOT = compTimePM
        ElseIf compTimeAM > 0 And compTimePM > 0 Then
            GetOT = compTimePM
        End If

        'close the reader
        objReader.Close()
        Return GetOT
    End Function

    Function GetUT(ByVal Day As String, ByVal Employee_ID As String, ByVal AMOut As String, ByVal PMOut As String) As Integer

        Dim HalfDay As Boolean = False
        GetUT = 0

        Dim ShifttTimeAM As Date
        Dim ShifttTimePM As Date

        Dim tmpTimeAM As Date
        Dim tmpTimePM As Date

        Dim tmp1 As Integer = 0
        Dim tmp2 As Integer = 0

        Dim ShifttDay As String
        If Day = 0 Then
            ShifttDay = "Sunday"
        ElseIf Day = 1 Then
            ShifttDay = "Monday"
        ElseIf Day = 2 Then
            ShifttDay = "Tuesday"
        ElseIf Day = 3 Then
            ShifttDay = "Wednesday"
        ElseIf Day = 4 Then
            ShifttDay = "Thursday"
        ElseIf Day = 5 Then
            ShifttDay = "Friday"
        Else
            ShifttDay = "Saturday"
            HalfDay = True
        End If

        CheckConnection(cn)
        Dim cmdSearch As New SqlCommand("SELECT * FROM tblShift WHERE Employee_ID='" & Employee_ID & "' AND Day='" & ShifttDay & "'", cn)
        Dim objReader As SqlDataReader = cmdSearch.ExecuteReader

        objReader.Read()

        If objReader.HasRows = True Then
            ShifttTimeAM = objReader("AMOut")
            ShifttTimePM = objReader("PMOut")
        Else
            If HalfDay = False And Not PMOut = "" Then
                ShifttTimeAM = "08:00 AM"
                ShifttTimePM = "05:00 PM"
            Else
                ShifttTimeAM = "08:00 AM"
                ShifttTimePM = "12:00 PM"
            End If
        End If

        If Not AMOut = "" And PMOut = "" Then
            tmpTimeAM = AMOut
            tmp1 = DateDiff(DateInterval.Minute, ShifttTimeAM, tmpTimeAM)
            tmp2 = DateDiff(DateInterval.Minute, ShifttTimePM, tmpTimeAM)
        ElseIf AMOut = "" And Not PMOut = "" Then
            tmpTimePM = PMOut
            tmp1 = DateDiff(DateInterval.Minute, ShifttTimeAM, tmpTimePM)
            tmp2 = DateDiff(DateInterval.Minute, ShifttTimePM, tmpTimePM)
        ElseIf Not AMOut = "" And Not PMOut = "" Then
            tmpTimeAM = AMOut
            tmpTimePM = PMOut
            tmp1 = DateDiff(DateInterval.Minute, ShifttTimeAM, tmpTimeAM)
            tmp2 = DateDiff(DateInterval.Minute, ShifttTimePM, tmpTimePM)
        End If

        If tmp1 < 0 And tmp2 > 0 Then
            GetUT = tmp1
        ElseIf tmp2 < 0 And tmp1 > 0 Then
            GetUT = tmp2
        ElseIf tmp1 < 0 And tmp2 < 0 Then
            GetUT = tmp1 + tmp2
        End If

        'End If

        'close the reader
        objReader.Close()
        Return GetUT
    End Function

    Function GetHoliday(ByVal DtrDate As Date) As String

        CheckConnection(cn)
        Dim cmdSearch As New SqlCommand("SELECT * FROM tblNonWorkingDay WHERE NonWorkingDate='" & DtrDate.ToShortDateString & "'", cn)
        Dim objReader As SqlDataReader = cmdSearch.ExecuteReader

        objReader.Read()

        If objReader.HasRows = True Then
            GetHoliday = objReader("HolidayTitle")
        Else
            GetHoliday = "-"
        End If

        'close the reader
        objReader.Close()
        Return GetHoliday

    End Function

    Function GetEmployeeID(ByVal PIN As String) As String

        CheckConnection(cn)
        Dim cmdSearch As New SqlCommand("SELECT * FROM Employees WHERE PIN='" & PIN & "'", cn)
        Dim objReader As SqlDataReader = cmdSearch.ExecuteReader

        objReader.Read()

        If objReader.HasRows = True Then
            GetEmployeeID = objReader("ID")
        Else
            GetEmployeeID = "0"
        End If

        'close the reader
        objReader.Close()
        Return GetEmployeeID

    End Function

    Function GetShiftTime(ByVal Employee_ID As String, ByVal ShiftTime As Integer, ByVal Day As Integer) As String

        Dim ShifttDay As String
        If Day = 0 Then
            ShifttDay = "Sunday"
        ElseIf Day = 1 Then
            ShifttDay = "Monday"
        ElseIf Day = 2 Then
            ShifttDay = "Tuesday"
        ElseIf Day = 3 Then
            ShifttDay = "Wednesday"
        ElseIf Day = 4 Then
            ShifttDay = "Thursday"
        ElseIf Day = 5 Then
            ShifttDay = "Friday"
        Else
            ShifttDay = "Saturday"
        End If

        CheckConnection(cn)
        Dim cmdSearch As New SqlCommand("SELECT * FROM tblShift WHERE Employee_ID='" & Employee_ID & "' AND Day='" & ShifttDay & "'", cn)
        Dim objReader As SqlDataReader = cmdSearch.ExecuteReader

        objReader.Read()

        If objReader.HasRows = True Then
            If ShiftTime = 1 Then
                GetShiftTime = objReader("AMIn")
            Else
                GetShiftTime = objReader("PMIn")
            End If
        Else
            GetShiftTime = ""
            'If ShiftTime = 1 Then
            'GetShiftTime = "07:00 AM"
            'Else
            'GetShiftTime = "12:00 AM"
            'End If
        End If

        'close the reader
        objReader.Close()
        Return GetShiftTime

    End Function

    Function CompIn(ByVal Employee_ID As String, ByVal DTRIN As String, ByVal ShiftIn As String, ByVal Day As String) As Decimal

        CompIn = 0
        Dim time1 As Date
        Dim time2 As Date
        If DTRIN = "" Then
            DTRIN = "00:00"
        Else
            time1 = DTRIN
        End If
        If ShiftIn = "AM" Then
            If GetShiftTime(Employee_ID, "1", Day) = "" Then
                time2 = "08:00 AM"
                CompIn = DateDiff(DateInterval.Minute, time1, time2)
            Else
                time2 = GetShiftTime(Employee_ID, "1", Day)
                CompIn = DateDiff(DateInterval.Minute, time1, time2)
            End If
        Else
            If GetShiftTime(Employee_ID, "2", Day) = "" Then
                time2 = "01:00 PM"
                CompIn = DateDiff(DateInterval.Minute, time1, time2)
            Else
                time2 = GetShiftTime(Employee_ID, "2", Day)
                CompIn = DateDiff(DateInterval.Minute, time1, time2)
            End If
        End If

        If CompIn > 0 Then
            Return 0
        Else
            Return CompIn
        End If

    End Function

    Private Sub LoadDateRange()
        Me.lstvwDateRange.Items.Clear()
        Dim x As Integer
        Dim month As String
        Dim NumberOfDays As Integer

        Dim tsTimeSpan As TimeSpan

        tsTimeSpan = Me.dtpEnd.Value.Subtract(Me.dtpStart.Value)
        NumberOfDays = tsTimeSpan.Days

        For x = 0 To NumberOfDays
            month = Me.dtpStart.Value.AddDays(x).Month & "/" & Me.dtpStart.Value.AddDays(x).Day & "/" & Me.dtpStart.Value.AddDays(x).ToString("yy")
            Dim MyItem = Me.lstvwDateRange.Items.Add(month, 0) '0
            With MyItem
                '.SubItems.Add(dr("MiddleInitial".ToString)) '1
                '.SubItems.Add(dr("LastName".ToString)) '2
            End With
        Next
    End Sub

    Private Sub LoadDTRReport()

        Dim DateStart As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim DateEnd As CrystalDecisions.CrystalReports.Engine.TextObject

        Dim crSections As Sections
        Dim crSection As Section
        Dim crReportObjects As ReportObjects
        'Dim crReportObject As ReportObject
        Dim myTable As CrystalDecisions.CrystalReports.Engine.Table
        Dim myLogin As CrystalDecisions.Shared.TableLogOnInfo
        'Dim crSubreportObject As SubreportObject
        'Dim crSubreportDocument As ReportDocument
        'Dim crDatabase As Database
        'Dim crTables As Tables
        'Dim aTable As Table
        'Dim crTableLogOnInfo As TableLogOnInfo

        Dim repDoc

        repDoc = New crptDTR

        DateStart = repDoc.ReportDefinition.ReportObjects.Item("txtStartingDate")
        DateEnd = repDoc.ReportDefinition.ReportObjects.Item("txtEndingDate")

        DateStart.Text = Me.dtpStart.Value.ToShortDateString
        DateEnd.Text = Me.dtpEnd.Value.ToShortDateString

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
            'loop through all the report objects in there to find all subreports 
            'For Each crReportObject In crReportObjects
            '    If crReportObject.Kind = ReportObjectKind.SubreportObject Then
            '        crSubreportObject = CType(crReportObject, SubreportObject)
            '        'open the subreport object and logon as for the general report
            '        crSubreportDocument = crSubreportObject.OpenSubreport(crSubreportObject.SubreportName)
            '        crDatabase = crSubreportDocument.Database
            '        crTables = crDatabase.Tables
            '        For Each aTable In crTables
            '            crTableLogOnInfo = aTable.LogOnInfo
            '            crTableLogOnInfo.ConnectionInfo.UserID = "Admin"
            '            crTableLogOnInfo.ConnectionInfo.Password = ""
            '            'crTableLogOnInfo.ConnectionInfo.DatabaseName = GetcrptDBPath() & "\ElectriPartsDB.mdb"
            '            aTable.ApplyLogOnInfo(crTableLogOnInfo)
            '        Next
            '    End If
            'Next
        Next
        frmReportDTR.crptvwDTR.ReportSource = repDoc

        'Dim tmpStr(2) As String
        'tmpStr = Me.cmbxDepartment.Text.Split(":")

        'If Me.cmbxStatus.Text = "All" Then
        '    frmReportDTR.crptvwDTR.SelectionFormula = "{Employees.DepartmentCode}='" & tmpStr(1) & "' AND Date({vwEmpDTR.Timedata})>= #" & Me.dtpStart.Value.ToShortDateString & "# And Date({vwEmpDTR.Timedata})<= #" & Me.dtpEnd.Value.ToShortDateString & "#"
        'ElseIf Me.cmbxStatus.Text = "Regular" Then
        '    frmReportDTR.crptvwDTR.SelectionFormula = "{Employees.DepartmentCode}='" & tmpStr(1) & "' AND {Employees.EmploymentStatus}='" & Me.cmbxStatus.Text & "' AND Date({vwEmpDTR.Timedata})>= #" & Me.dtpStart.Value.ToShortDateString & "# And Date({vwEmpDTR.Timedata})<= #" & Me.dtpEnd.Value.ToShortDateString & "#"
        'Else
        '    frmReportDTR.crptvwDTR.SelectionFormula = "{Employees.DepartmentCode}='" & tmpStr(1) & "' AND {Employees.EmploymentStatus}='" & Me.cmbxStatus.Text & "' AND Date({vwEmpDTR.Timedata})>= #" & Me.dtpStart.Value.ToShortDateString & "# And Date({vwEmpDTR.Timedata})<= #" & Me.dtpEnd.Value.ToShortDateString & "#"
        'End If

        frmReportDTR.crptvwDTR.RefreshReport()
        frmReportDTR.Show()

    End Sub

    Private Sub InsertDTR(ByVal PIN As Integer, ByVal DTRDate As Date)

        Dim CrossOverOut As String
        Dim AMIn As String
        Dim AMOut As String
        Dim PMIn As String
        Dim PMOut As String
        Dim TardinessAM As Decimal
        Dim TardinessPM As Decimal
        Dim TotalTardiness As Decimal
        Dim UT As String
        Dim OT As String
        Dim Shift As String
        Dim Remarks As String

        CrossOverOut = GetInOut(PIN, DTRDate.ToString("MM/dd/yy"), 0, "OUT")
        AMIn = GetInOut(PIN, DTRDate.ToString("MM/dd/yy"), 1, "IN")
        AMOut = GetInOut(PIN, DTRDate.ToString("MM/dd/yy"), 2, "OUT")
        PMIn = GetInOut(PIN, DTRDate.ToString("MM/dd/yy"), 3, "IN")
        PMOut = GetInOut(PIN, DTRDate.ToString("MM/dd/yy"), 4, "OUT")

        TardinessAM = CompIn(GetEmployeeID(PIN), AMIn, "AM", DTRDate.DayOfWeek)
        TardinessPM = CompIn(GetEmployeeID(PIN), PMIn, "PM", DTRDate.DayOfWeek)
        TotalTardiness = TardinessAM + TardinessPM
        UT = GetUT(DTRDate.DayOfWeek, GetEmployeeID(PIN), AMOut, PMOut)
        OT = GetOT(DTRDate.DayOfWeek, GetEmployeeID(PIN), AMOut, PMOut)
        Shift = GetShift(DTRDate.DayOfWeek, GetEmployeeID(PIN))
        Remarks = GetHoliday(DTRDate)
        InsertData("tblProcessDTR", "PIN" & _
                              ",Date" & _
                              ",CrossOverOut" & _
                              ",AMIn" & _
                              ",AMOut" & _
                              ",PMIn" & _
                              ",PMOut" & _
                              ",Tardiness" & _
                              ",UT" & _
                              ",OT" & _
                              ",Shift" & _
                              ",Remarks", "'" & PIN & _
                              "','" & DTRDate & _
                              "','" & CrossOverOut & _
                              "','" & AMIn & _
                              "','" & AMOut & _
                              "','" & PMIn & _
                              "','" & PMOut & _
                              "','" & TotalTardiness & _
                              "','" & UT & _
                              "','" & OT & _
                              "','" & Shift & _
                              "','" & Remarks & "'", "")
    End Sub

    Private Sub ClearDTRProcessTable()
        CheckConnection(cn)
        Dim cmd As New SqlCommand("DELETE FROM tblProcessDTR", cn)
        cmd.ExecuteNonQuery()
    End Sub

    Private Function GetInOut(ByVal PIN As String, ByVal tmpDate As String, ByVal Count As Integer, ByVal INOUT As String) As String

        CheckConnection(cn)
        Dim cmdSearch As New SqlCommand("SELECT * FROM vwEmpDTR WHERE PIN='" & PIN & "' AND Date='" & tmpDate & "' AND Count='" & Count & "' AND InOut='" & INOUT & "'", cn)
        Dim objReader As SqlDataReader = cmdSearch.ExecuteReader

        objReader.Read()
        If objReader.HasRows = True Then
            GetInOut = CDate(objReader("TimeData")).ToShortTimeString
        Else
            GetInOut = ""
        End If

        'close the reader
        objReader.Close()

        Return GetInOut

    End Function

#End Region

#Region "Loading Data"

    Public Sub LoadDepartment()
        FillDepartment("SELECT * FROM Department")
    End Sub

    Public Sub LoadEmployee()
        If Not Me.cmbxDepartment.Text = "" Then
            Dim tmpStr(2) As String
            tmpStr = Me.cmbxDepartment.Text.Split(":")
            If Not tmpStr(1) = "" Then
                If Me.cmbxStatus.Text = "All" Then
                    FillEmployee("SELECT * FROM Employees WHERE DepartmentCode='" & tmpStr(1) & "'")
                Else
                    FillEmployee("SELECT * FROM Employees WHERE DepartmentCode='" & tmpStr(1) & "' AND EmploymentStatus='" & Me.cmbxStatus.Text & "'")
                End If
            End If
        End If
    End Sub

#End Region

#Region "Filling Data"

    Private Sub FillDepartment(ByVal Sqlstring As String)

        Me.cmbxDepartment.Items.Clear()
        CheckConnection(cn)
        Sqlda.SelectCommand = New SqlCommand(Sqlstring, cn)
        Sqlcmbldr = New SqlCommandBuilder(Sqlda)

        ds.Clear()
        Sqlda.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                Me.cmbxDepartment.Items.Add(SetSpacing(dr("DepartmentDescription"), 50) & ":" & dr("DepartmentCode"))
            Next
        End If

    End Sub

    Private Sub FillEmployee(ByVal Sqlstring As String)

        Me.lstvwEmployee.Items.Clear()
        ds.Clear()

        Sqlda.SelectCommand = New SqlCommand(Sqlstring, cn)
        Sqlcmbldr = New SqlCommandBuilder(Sqlda)

        'On Error Resume Next
        Sqlda.Fill(ds)
        Me.lblTotalListOfEmployee.Text = ds.Tables(0).Rows.Count
        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows
                Dim MyItem = Me.lstvwEmployee.Items.Add(dr("FirstName"), 0) '0
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("MiddleInitial".ToString)) '1
                    .SubItems.Add(dr("LastName".ToString)) '2
                    .SubItems.Add(dr("PIN".ToString)) '3

                End With
            Next
        End If
    End Sub

#End Region

    Private Sub frmPrintDTR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDepartment()
        LoadDateRange()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click

        Dim x As Integer
        Dim y As Integer

        If Me.cmbxDepartment.Text = "" Then
            MessageBox.Show("Please select a department.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cmbxDepartment.Focus()
        ElseIf Me.cmbxStatus.Text = "" Then
            MessageBox.Show("Please select the status of employees.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cmbxStatus.Focus()
        Else
            'todo code
            ClearDTRProcessTable()
            For x = 0 To Me.lstvwEmployee.Items.Count - 1
                If Me.lstvwEmployee.Items(x).Checked = True Then
                    For y = 0 To Me.lstvwDateRange.Items.Count - 1
                        InsertDTR(Me.lstvwEmployee.Items(x).SubItems(3).Text, Me.lstvwDateRange.Items(y).SubItems(0).Text)
                    Next
                End If
            Next
            MsgBox("Process completed.")
        End If

    End Sub

    Private Sub cmbxStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbxStatus.SelectedIndexChanged
        LoadEmployee()
    End Sub

    Private Sub cmbxDepartment_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbxDepartment.SelectedIndexChanged
        LoadEmployee()
    End Sub

    Private Sub dtpStart_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpStart.ValueChanged
        LoadDateRange()
    End Sub

    Private Sub dtpEnd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpEnd.ValueChanged
        LoadDateRange()
    End Sub

    Private Sub btnCheckAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckAll.Click
        Dim x As Integer
        For x = 0 To Me.lstvwEmployee.Items.Count - 1
            Me.lstvwEmployee.Items(x).Checked = True
        Next
    End Sub

    Private Sub btnUncheckAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUncheckAll.Click
        Dim x As Integer
        For x = 0 To Me.lstvwEmployee.Items.Count - 1
            Me.lstvwEmployee.Items(x).Checked = False
        Next
    End Sub

    Private Sub btnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintPreview.Click
        LoadDTRReport()
    End Sub

    Private Sub btnExtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtract.Click
        Dim AMIn As String
        Dim AMOut As String
        Dim PMIn As String
        Dim PMOut As String
        Dim y As Integer
        Dim DTRDate As Date
        Dim FILE_NAME As String = Application.StartupPath & "\Employee.opl"
        Dim objWriter As New IO.StreamWriter(FILE_NAME)

        ds.Clear()
        Sqlda.SelectCommand = New SqlCommand("SELECT * FROM Employees WHERE Deactivated <> 'True'", cn)
        Sqlcmbldr = New SqlCommandBuilder(Sqlda)

        'On Error Resume Next
        Sqlda.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                'get the data for each day within the range
                For y = 0 To Me.lstvwDateRange.Items.Count - 1
                    AMIn = GetInOut(dr("PIN".ToString), DTRDate.ToString("MM/dd/yy"), 1, "IN")
                    AMOut = GetInOut(dr("PIN".ToString), DTRDate.ToString("MM/dd/yy"), 2, "OUT")
                    PMIn = GetInOut(dr("PIN".ToString), DTRDate.ToString("MM/dd/yy"), 3, "IN")
                    PMOut = GetInOut(dr("PIN".ToString), DTRDate.ToString("MM/dd/yy"), 4, "OUT")
                    MsgBox(dr("PIN".ToString) & " " & Me.lstvwDateRange.Items(y).SubItems(0).Text & " " & AMIn)
                    'InsertDTR(Me.lstvwEmployee.Items(X).SubItems(3).Text, Me.lstvwDateRange.Items(y).SubItems(0).Text)
                Next
        ' objWriter.WriteLine(dr("PIN".ToString) & Space(1)) '1
            Next
        End If
        objWriter.Close()
    End Sub

End Class