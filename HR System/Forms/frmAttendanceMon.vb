'Programmed by: Aldwin Mark F. Solis
'Date: 07-02-2011
'Title: Form Attendance Monitoring

Imports System.Data.SqlClient

Public Class frmAttendanceMon

#Region "Variable Declaration"



#End Region

#Region "Functions"

    Private Sub LoadLsit()

        Dim DTRDate As Date
        Dim Fullname As String = ""
        Dim Absences As Decimal
        Dim TAbsences As Decimal
        Dim LateHours As Double
        Dim x As Integer
        Dim y As Integer

        Dim TardinessAM As Decimal
        Dim TardinessPM As Decimal
        Dim TotalTardiness As Decimal

        Dim CheckIn As String
        Dim CheckOUT As String

        Dim AMIn As String
        Dim PMIn As String

        Dim tmpStr(2) As String
        tmpStr = Me.cmbxDepartment.Text.Split(":")

        If Me.cmbxDepartment.Text = "" Then
            MessageBox.Show("Please select a department.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cmbxDepartment.Focus()
        ElseIf Me.cmbxStatus.Text = "" Then
            MessageBox.Show("Please select the status of employees.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cmbxStatus.Focus()
        Else
            Me.lstvwAbsences.Items.Clear()
            ds.Clear()

            If Me.cmbxStatus.Text = "All" Then
                Sqlda.SelectCommand = New SqlCommand("SELECT * FROM Employees WHERE DepartmentCode='" & tmpStr(1) & "' ORDER BY LastName ASC", cn)
            Else
                Sqlda.SelectCommand = New SqlCommand("SELECT * FROM Employees WHERE DepartmentCode='" & tmpStr(1) & "' AND EmploymentStatus='" & Me.cmbxStatus.Text & "' ORDER BY LastName ASC", cn)
            End If

            Sqlcmbldr = New SqlCommandBuilder(Sqlda)

            Sqlda.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                For Each dr In ds.Tables(0).Rows
                    TAbsences = 0
                    LateHours = 0
                    For y = 0 To Me.lstvwDateRange.Items.Count - 1
                        DTRDate = CDate(Me.lstvwDateRange.Items(y).SubItems(0).Text)
                        'check if holiday
                        If GetHoliday(DTRDate) = False Then
                            'check if sunday
                            If CheckIfSunday(CDate(Me.lstvwDateRange.Items(y).SubItems(0).Text)) = False Then
                                '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                                '+  Calculates the number of absences per employee
                                '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

                                CheckIn = GetInOut(dr("PIN"), DTRDate.ToString("MM/dd/yy"), "IN", "ASC")
                                If Not CheckIn = "" Then
                                    AMIn = GetInOut(dr("PIN"), DTRDate.ToString("MM/dd/yy"), 1, "IN")
                                    TardinessAM = CompIn(GetEmployeeID(dr("PIN")), AMIn, "AM", DTRDate.DayOfWeek)
                                End If

                                CheckOUT = GetInOut(dr("PIN"), DTRDate.ToString("MM/dd/yy"), "OUT", "DESC")
                                If Not CheckOUT = "" Then
                                    PMIn = GetInOut(dr("PIN"), DTRDate.ToString("MM/dd/yy"), 3, "IN")
                                    TardinessPM = CompIn(GetEmployeeID(dr("PIN")), PMIn, "PM", DTRDate.DayOfWeek)
                                End If

                                If Not CheckIn = "" And Not CheckOUT = "" Then
                                    Absences = DateDiff(DateInterval.Hour, CDate(CheckIn), CDate(CheckOUT))
                                    If Absences > 8 Then
                                        TAbsences += 0
                                    ElseIf Absences <= 4 Then
                                        TAbsences += 0.5
                                    End If
                                Else
                                    TAbsences += 1
                                End If

                                '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                                '+ Calculates the number of lates per employee
                                '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

                                TotalTardiness = TardinessAM + TardinessPM
                                If TotalTardiness < 0 Then
                                    LateHours += 1
                                End If
                                '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++



                            End If
                        End If
                    Next
                    'Add employees their absences, Late hours with a specific date.
                    Fullname = dr("LastName") & ", " & dr("FirstName") & " " & dr("MiddleInitial")
                    Dim MyItem = Me.lstvwAbsences.Items.Add(Fullname.ToUpper, 0) '0
                    MyItem.tag = x
                    x = x + 1
                    With MyItem
                        .SubItems.Add(dr("PIN")) '1
                        .SubItems.Add(TAbsences) '2
                        .SubItems.Add(LateHours) '3
                    End With
                Next
            End If

            MsgBox("Process completed.")

        End If

    End Sub

    Function GetHoliday(ByVal DtrDate As Date) As Boolean

        CheckConnection(cn)
        Dim cmdSearch As New SqlCommand("SELECT * FROM tblNonWorkingDay WHERE NonWorkingDate='" & DtrDate.ToShortDateString & "'", cn)
        Dim objReader As SqlDataReader = cmdSearch.ExecuteReader

        objReader.Read()

        If objReader.HasRows = True Then
            GetHoliday = True
        Else
            GetHoliday = False
        End If

        'close the reader
        objReader.Close()
        Return GetHoliday

    End Function

    Private Function CheckIfSunday(ByVal Day As Date) As Boolean

        If Day.DayOfWeek = DayOfWeek.Sunday = True Then
            CheckIfSunday = True
        Else
            CheckIfSunday = False
        End If

        Return CheckIfSunday
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

    Private Function GetInOut(ByVal PIN As String, ByVal tmpDate As String, ByVal Status As String, ByVal Order As String) As String

        CheckConnection(cn)
        Dim cmdSearch As New SqlCommand("SELECT * FROM vwEmpDTR WHERE PIN='" & PIN & "' AND Date='" & tmpDate & "' AND InOut='" & Status & "' ORDER BY Timedata " & Order & "", cn)
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

#End Region

#Region "Loading Data"

    Public Sub LoadDepartment()
        FillDepartment("SELECT * FROM Department")
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
                Me.cmbxDepartment.Items.Add(SetSpacing(dr("DepartmentDescription"), 100) & ":" & dr("DepartmentCode"))
            Next
        End If

    End Sub

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

#End Region

    Private Sub frmAttendanceMon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpStart.Value = Date.Now
        Me.dtpEnd.Value = Date.Now
        LoadDepartment()
        LoadDateRange()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click

        LoadLsit()

    End Sub

    Private Sub dtpStart_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpStart.ValueChanged
        LoadDateRange()
    End Sub

    Private Sub dtpEnd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpEnd.ValueChanged
        LoadDateRange()
    End Sub

End Class