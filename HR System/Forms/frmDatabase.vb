'Programmed by: Aldwin Mark F. Solis
'Date: 11-2-2010
'Title: Database

Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO

Public Class frmDatabase

#Region "User Variable"

    Dim success As Boolean

#End Region

#Region "User functions"

    Private Function CheckIfRecordAlreadyExist(ByVal Pin As String) As Boolean

        CheckConnection(cn)
        Dim cmd As New SqlCommand("SELECT * FROM Employees WHERE Pin='" & Pin & "'", cn)
        Dim objReader As SqlDataReader
        objReader = cmd.ExecuteReader

        If objReader.HasRows Then
            CheckIfRecordAlreadyExist = True
        Else
            CheckIfRecordAlreadyExist = False
        End If

        objReader.Close()

        Return CheckIfRecordAlreadyExist

    End Function

    Private Sub ImportingData(ByVal StrPath As String)

        Dim counter As Integer
        Dim progress As Integer
        Dim TotalRec As Integer


        Dim ID As String
        'Employee Profile
        Dim LastName As String
        Dim FirstName As String
        Dim MiddleInitial As String
        Dim EmployeeNumber As String
        Dim Department As String
        Dim Position As Integer
        Dim BasicSalary As Decimal
        Dim DateHired As Date
        Dim EmailAddress As String = ""
        Dim EmploymentStatus As String = ""
        'Dim Picture As b
        Dim ContactNo As String = ""
        Dim HomeNo As String = ""
        Dim LastDateEmployed As Date
        Dim EmployeeStatusHistory As String = ""
        Dim Active As Boolean
        Dim AutoCrossover As Boolean

        'Personal Profile
        Dim Gender As String = ""
        Dim CivilStatus As String = ""
        Dim DateOfBirth As Date
        Dim Religion As String = ""
        Dim Children As String = ""
        Dim Spouse As String = ""
        Dim Father As String = ""
        Dim Mother As String = ""
        Dim Elementary As String = ""
        Dim HighSchool As String = ""
        Dim College As String = ""
        Dim Degree As String = ""
        Dim Major As String = ""
        Dim Master As String = ""

        'Additional Information
        Dim TinNo As String = ""
        Dim SSSNo As String = ""
        Dim PagIbigNo As String = ""
        Dim PhilHealthNo As String = ""
        Dim HI_ID As String = ""
        Dim HI_Title As String = ""
        Dim LI_ID As String = ""
        Dim LI_Title As String = ""
        Dim EmergencyContactName As String = ""
        Dim EmergencyContactNo As String = ""
        Dim Notes As String = ""


        Dim strConnection As String = Me.txtConnectionString.Text
        Dim cnAccess As SqlConnection = New SqlConnection(strConnection)

        cnAccess.Open()
        Dim cmdTotalRec As New SqlCommand("SELECT COUNT(*) FROM Employees", cnAccess)
        TotalRec = (cmdTotalRec.ExecuteScalar())

        Dim cmd As New SqlCommand("SELECT * FROM Employees", cnAccess)

        Dim objReader As SqlDataReader
        'Try
        objReader = cmd.ExecuteReader
        'Catch ex As Exception
        'MessageBox.Show("The Database from " & Me.txtConnectionString.Text & " is not a valid connection string", "Invalid connection string", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Me.bgworkerUpdateEmployee.CancelAsync()
        'success = False
        'Exit Sub
        'End Try

        'success = True

        If objReader.HasRows Then
            While objReader.Read

                ID = objReader("ID")
                LastName = objReader("LastName")
                FirstName = objReader("FirstName")
                MiddleInitial = objReader("MiddleInitial")
                EmployeeNumber = objReader("PIN")
                Department = objReader("DepartmentCode")
                Position = objReader("Position")
                'BasicSalary = objReader("BasicSalary")
                'DateHired = objReader("HireDate")
                'EmailAddress = objReader("EmailAddress")
                'EmploymentStatus = objReader("EmploymentStatus")
                'Picture = objReader("Photo")
                'ContactNo = objReader("ContactNo")
                'HomeNo = objReader("HomePhone")
                'LastDateEmployed = objReader("LastDateEmployed")
                'EmployeeStatusHistory = objReader("EmployeeStatusHistory")
                Active = objReader("Deactivated")
                AutoCrossover = objReader("AutoCrossover")

                'Gender = objReader("Gender")
                'CivilStatus = objReader("CivilStatus")
                DateOfBirth = objReader("BirthDate")
                'Religion = objReader("Religion")
                'Children = objReader("Children")
                'Spouse = objReader("Spouse")
                'Father = objReader("Father")
                'Mother = objReader("Mother")
                'Elementary = objReader("Elementary")
                'HighSchool = objReader("HighSchool")
                'College = objReader("College")
                'Degree = objReader("Degree")
                'Major = objReader("Major")
                'Master = objReader("Master")

                'TinNo = objReader("TIN")
                'SSSNo = objReader("SSSNumber")
                'PagIbigNo = objReader("PagIbigNumber")
                'PhilHealthNo = objReader("PhilHealth_ID")
                'HI_ID = objReader("HI_ID")
                'HI_Title = objReader("HI_Title")
                'LI_ID = objReader("LI_ID")
                'LI_Title = objReader("LI_Title")
                'EmergencyContactName = objReader("EmergencyContactName")
                'EmergencyContactNo = objReader("EmergencyContactNumber")
                'Notes = objReader("Notes")


                If CheckIfRecordAlreadyExist(EmployeeNumber) = True Then
                    UpdateData("Employees", "LastName='" & CSQ(LastName) & "'" & _
                                     ",FirstName='" & CSQ(FirstName) & "'" & _
                                     ",MiddleInitial='" & CSQ(MiddleInitial) & "'" & _
                                     ",PIN='" & EmployeeNumber & "'" & _
                                     ",BirthDate='" & DateOfBirth & "'" & _
                                     ",Deactivated='" & Active & "'" & _
                                     ",AutoCrossover='" & AutoCrossover & "'", "ID", ID, "")
                    success = False
                    'MsgBox(EmployeeNumber)
                Else 'strEmployeeID
                    InsertData("Employees", "LastName" & _
                                           ",FirstName" & _
                                           ",MiddleInitial" & _
                                           ",PIN" & _
                                           ",strEmployeeID" & _
                                           ",DepartmentCode" & _
                                           ",Position" & _
                                           ",BasicSalary" & _
                                           ",HireDate" & _
                                           ",EmailAddress" & _
                                           ",EmploymentStatus" & _
                                           ",ContactNo" & _
                                           ",HomePhone" & _
                                           ",LastDateEmployed" & _
                                           ",EmployeeStatusHistory" & _
                                           ",Deactivated" & _
                                           ",AutoCrossover" & _
                                           ",CompanyCode" & _
                                           ",Gender" & _
                                           ",CivilStatus" & _
                                           ",BirthDate" & _
                                           ",Religion" & _
                                           ",Children" & _
                                           ",Spouse" & _
                                           ",Father" & _
                                           ",Mother" & _
                                           ",Elementary" & _
                                           ",HighSchool" & _
                                           ",College" & _
                                           ",Degree" & _
                                           ",Major" & _
                                           ",Master" & _
                                           ",TIN" & _
                                           ",SSSNumber" & _
                                           ",PagIbigNumber" & _
                                           ",PhilHealth" & _
                                           ",HI_ID" & _
                                           ",HI_Title" & _
                                           ",LI_ID" & _
                                           ",LI_Title" & _
                                           ",EmergencyContactName" & _
                                           ",EmergencyContactNumber" & _
                                           ",Notes", "'" & LastName & _
                                                          "','" & FirstName & _
                                                          "','" & MiddleInitial & _
                                                          "','" & EmployeeNumber & _
                                                          "','" & EmployeeNumber & _
                                                          "','" & Department & _
                                                          "','" & Position & _
                                                          "','" & BasicSalary & _
                                                          "','" & DateHired & _
                                                          "','" & EmailAddress & _
                                                          "','" & EmploymentStatus & _
                                                          "','" & ContactNo & _
                                                          "','" & HomeNo & _
                                                          "','" & LastDateEmployed & _
                                                          "','" & EmployeeStatusHistory & _
                                                          "','" & Active & _
                                                          "','" & AutoCrossover & _
                                                          "','" & "ZAMCELCO" & _
                                                          "','" & Gender & _
                                                          "','" & CivilStatus & _
                                                          "','" & DateOfBirth & _
                                                          "','" & Religion & _
                                                          "','" & Children & _
                                                          "','" & Spouse & _
                                                          "','" & Father & _
                                                          "','" & Mother & _
                                                          "','" & Elementary & _
                                                          "','" & HighSchool & _
                                                          "','" & College & _
                                                          "','" & Degree & _
                                                          "','" & Major & _
                                                          "','" & Master & _
                                                          "','" & TinNo & _
                                                          "','" & SSSNo & _
                                                          "','" & PagIbigNo & _
                                                          "','" & PhilHealthNo & _
                                                          "','" & HI_ID & _
                                                          "','" & HI_Title & _
                                                          "','" & LI_ID & _
                                                          "','" & LI_Title & _
                                                          "','" & EmergencyContactName & _
                                                          "','" & EmergencyContactNo & _
                                                          "','" & Notes & _
                                                          "'", "")
                End If

                counter += 1
                progress = (counter * 100) / TotalRec
                Me.bgworkerUpdateEmployee.ReportProgress(progress)
               
            End While
        End If
        cnAccess.Close()
    End Sub

    Private Sub ImportTimedata(ByVal StrPath As String)

        Dim counter As Integer
        Dim progress As Integer
        Dim TotalRec As Integer

        Dim PIN As String
        Dim Timedata As Date
        Dim Count As Integer
        Dim InOut As String
        Dim StrEmployee As String
        Dim CompanyCode As String
        Dim DepartmentCode As String


        Dim strConnection As String = Me.txtConnectionString.Text
        Dim cnAccess As SqlConnection = New SqlConnection(strConnection)

        cnAccess.Open()
        Dim cmdTotalRec As New SqlCommand("SELECT COUNT(*) FROM Timedata", cnAccess)
        TotalRec = (cmdTotalRec.ExecuteScalar())

        Dim cmd As New SqlCommand("SELECT * FROM Timedata", cnAccess)

        Dim objReader As SqlDataReader
        'Try
        objReader = cmd.ExecuteReader
        'Catch ex As Exception
        'MessageBox.Show("The Database from " & Me.txtConnectionString.Text & " is not a valid connection string", "Invalid connection string", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Me.bgworkerUpdateEmployee.CancelAsync()
        'success = False
        'Exit Sub
        'End Try

        'success = True
        If objReader.HasRows Then
            While objReader.Read
                PIN = objReader("PIN")
                Timedata = objReader("Timedata")
                Count = objReader("Count")
                InOut = objReader("InOut")
                If IsDBNull(objReader("StrEmployeeID")) = True Then
                    StrEmployee = ""
                Else
                    StrEmployee = objReader("StrEmployeeID")
                End If

                If IsDBNull(objReader("CompanyCode")) = True Then
                    CompanyCode = ""
                Else
                    CompanyCode = objReader("CompanyCode")
                End If

                If IsDBNull(objReader("CompanyCode")) = True Then
                    DepartmentCode = ""
                Else
                    DepartmentCode = objReader("DepartmentCode")
                End If


                InsertData("Timedata", "PIN" & _
                                           ",Timedata" & _
                                           ",Count" & _
                                           ",InOut" & _
                                           ",strEmployeeID" & _
                                           ",CompanyCode" & _
                                           ",DepartmentCode", "'" & PIN & _
                                                          "','" & Timedata & _
                                                          "','" & Count & _
                                                          "','" & InOut & _
                                                          "','" & StrEmployee & _
                                                          "','" & CompanyCode & _
                                                          "','" & DepartmentCode & _
                                                          "'", "")

                counter += 1
                progress = (counter * 100) / TotalRec
                Me.bgworkerUpdateTimedata.ReportProgress(progress)

            End While
        End If
    End Sub

    Private Sub ImportFingerdata(ByVal StrPath As String)

        Dim x As Integer = 0
        Dim counter As Integer
        Dim progress As Integer
        Dim TotalRec As Integer

        Dim PIN As Integer
        Dim FP() As Byte
        Dim FingerCode As String

        Dim ms As New MemoryStream()

        Dim strConnection As String = Me.txtConnectionString.Text
        Dim cnAccess As SqlConnection = New SqlConnection(strConnection)

        cnAccess.Open()
        Dim cmdTotalRec As New SqlCommand("SELECT COUNT(*) FROM FPData", cnAccess)
        TotalRec = (cmdTotalRec.ExecuteScalar())

        Dim cmd As New SqlCommand("SELECT * FROM FPData", cnAccess)

        Dim objReader As SqlDataReader
        'Try
        objReader = cmd.ExecuteReader
        'Catch ex As Exception
        'MessageBox.Show("The Database from " & Me.txtConnectionString.Text & " is not a valid connection string", "Invalid connection string", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Me.bgworkerUpdateEmployee.CancelAsync()
        'success = False
        'Exit Sub
        'End Try

        'success = True
        If objReader.HasRows Then
            While objReader.Read
                PIN = objReader("PIN")
                FP = objReader("FP")
                FingerCode = objReader("FingerCode")

                'update imageTable set photo = ?
                CheckConnection(cn)
                Dim strQuery As String = "INSERT INTO FPData (PIN,FP,FingerCode) VALUES(@PIN,@FP,@FingerCode)"

                Dim objcommand As New SqlCommand(strQuery, cn)
                With objcommand
                    .Parameters.Add(New SqlParameter("@PIN", SqlDbType.Int)).Value = PIN
                    .Parameters.Add(New SqlParameter("@FP", SqlDbType.Image)).Value = FP
                    .Parameters.Add(New SqlParameter("@FingerCode", SqlDbType.NVarChar)).Value = FingerCode
                End With

                objcommand.ExecuteNonQuery()

                'Sql = "INSERT INTO " & Table & "(" & Data & ")VALUES (" & Val() & ")"


                counter += 1
                progress = (counter * 100) / TotalRec
                Me.bgworkerUpdateFingerdata.ReportProgress(progress)

            End While
        End If
    End Sub

#End Region

    Private Sub btnClearTimedata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearTimedata.Click
        Dim StrSelect As String

        If MessageBox.Show("Are you sure you want to clear Timedata?", "confirm delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            StrSelect = "DELETE FROM Timedata"

            CheckConnection(cn)

            Dim cmd As New SqlCommand(StrSelect, cn)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Timedata has been cleared successfully.", "Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUpdateTimedate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateTimedate.Click
        Me.btnUpdateTimedate.Enabled = False
        Me.bgworkerUpdateTimedata.RunWorkerAsync()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmDatabase_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btnUpdateEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateEmployee.Click
        Me.bgworkerUpdateEmployee.RunWorkerAsync()
    End Sub

    Private Sub bgworkerUpdateEmployee_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgworkerUpdateEmployee.DoWork
        ImportingData(Me.txtConnectionString.Text)
    End Sub

    Private Sub btnClearEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearEmployee.Click
        Dim StrSelect As String

        If MessageBox.Show("Are you sure you want to clear Employees?", "confirm delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            StrSelect = "DELETE FROM Employees"

            CheckConnection(cn)

            Dim cmd As New SqlCommand(StrSelect, cn)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Employees has been cleared successfully.", "Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bgworkerUpdateTimedata_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgworkerUpdateTimedata.DoWork
        ImportTimedata(Me.txtConnectionString.Text)
    End Sub

    Private Sub bgworkerUpdateTimedata_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bgworkerUpdateTimedata.ProgressChanged
        Me.pgbarTimedata.Value = e.ProgressPercentage
    End Sub

    Private Sub bgworkerUpdateTimedata_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgworkerUpdateTimedata.RunWorkerCompleted
        Me.btnClearTimedata.Enabled = True
        Me.btnUpdateTimedate.Enabled = True
        MessageBox.Show("Timedata Data has been successfully updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnClearFingerdata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearFingerdata.Click
        Dim StrSelect As String

        If MessageBox.Show("Are you sure you want to clear Finger Print Data?", "confirm delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            StrSelect = "DELETE FROM FPData"

            CheckConnection(cn)

            Dim cmd As New SqlCommand(StrSelect, cn)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Finger Print Data has been cleared successfully.", "Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bgworkerUpdateFingerdata_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgworkerUpdateFingerdata.DoWork
        ImportFingerdata(Me.txtConnectionString.Text)
    End Sub

    Private Sub btnUpdateFingerdata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateFingerdata.Click
        Me.btnClearFingerdata.Enabled = False
        Me.btnUpdateFingerdata.Enabled = False
        Me.bgworkerUpdateFingerdata.RunWorkerAsync()
    End Sub

    Private Sub bgworkerUpdateFingerdata_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bgworkerUpdateFingerdata.ProgressChanged
        Me.pgbarFingerPrintdata.Value = e.ProgressPercentage
    End Sub

    Private Sub bgworkerUpdateFingerdata_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgworkerUpdateFingerdata.RunWorkerCompleted
        Me.btnClearFingerdata.Enabled = True
        Me.btnUpdateFingerdata.Enabled = True
        MessageBox.Show("Finger Print Data has been successfully updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub bgworkerUpdateEmployee_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bgworkerUpdateEmployee.ProgressChanged
        Me.pgbarEmployee.Value = e.ProgressPercentage
    End Sub

    Private Sub bgworkerUpdateEmployee_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgworkerUpdateEmployee.RunWorkerCompleted
        Me.btnClearEmployee.Enabled = True
        Me.btnUpdateEmployee.Enabled = True
        MessageBox.Show("Employee Data has been successfully updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class