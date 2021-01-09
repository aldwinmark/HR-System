'Programmed by: Aldwin Mark F. Solis
'Date: 10-29-2010
'Title: Importing Daily time record

Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class frmImportDTR

#Region "User Variable"
    Dim strPath(10) As String
    Dim success As Boolean
    Dim Password As Boolean
#End Region

#Region "User Function"

    Private Function CheckIfEmployeeExist(ByVal PIN As String) As Boolean

        Dim cmd As New SqlCommand("SELECT * FROM Employees WHERE PIN='" & PIN & "'", cn)
        Dim objReader As SqlDataReader

        CheckConnection(cn)
        objReader = cmd.ExecuteReader

        If objReader.HasRows Then
            CheckIfEmployeeExist = True
        Else
            CheckIfEmployeeExist = False
        End If

        objReader.Close()

        Return CheckIfEmployeeExist

    End Function

    Private Function CheckExistingData(ByVal strFile As String) As Boolean
        Dim x As Integer
        For x = 0 To Me.lstvwImportDTR.Items.Count - 1
            If Me.lstvwImportDTR.Items(x).Text = strFile Then
                MessageBox.Show("The file is already in the list.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            End If
        Next
        Return False
    End Function

    Private Function CheckIfRecordAlreadyExist(ByVal PIN As String, ByVal StrDate As String) As Boolean

        Dim cmd As New SqlCommand("SELECT * FROM Timedata WHERE PIN='" & PIN & "' AND Timedata='" & StrDate & "'", cn)
        Dim objReader As SqlDataReader

        CheckConnection(cn)
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

        Dim PIN As String
        Dim Timedata As String
        Dim Count As String
        Dim InOut As String
        Dim strEmployeeID As String
        Dim CompanyCode As String
        Dim Department As String

        Dim strConnection As String
WithPassword:
        If Password = True Then
            strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & StrPath & ";Jet OLEDB:Database Password=9fgr12;"
        Else
            strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & StrPath & ";User Id=admin;Password=;"
        End If

        Dim cnAccess As OleDbConnection = New OleDbConnection(strConnection)

        Try
            cnAccess.Open()
        Catch ex As Exception
            'Me.bgworkerImport.Dispose()
            'Me.bgworkerImport.CancelAsync()
            Password = True
            GoTo WithPassword
        End Try

        Dim cmdTotalRec As New OleDbCommand("SELECT COUNT(*) FROM Timedata", cnAccess)
        Try
            TotalRec = (cmdTotalRec.ExecuteScalar())
        Catch ex As Exception
            MessageBox.Show("The Database from " & StrPath & " is not a valid database to import", "Invalid import", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.bgworkerImport.CancelAsync()
            success = False
            Exit Sub
        End Try


        Dim cmd As New OleDbCommand("SELECT * FROM Timedata", cnAccess)

        Dim objReader As OleDbDataReader
        Try
            objReader = cmd.ExecuteReader
        Catch ex As Exception
            MessageBox.Show("The Database from " & StrPath & " is not a valid database to import", "Invalid import", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.bgworkerImport.CancelAsync()
            success = False
            Exit Sub
        End Try

        success = True

        If objReader.HasRows Then
            While objReader.Read

                counter += 1
                progress = (counter * 100) / TotalRec
                Me.bgworkerImport.ReportProgress(progress)

                PIN = objReader("PIN")
                Timedata = objReader("Timedata")
                Count = objReader("Count")
                InOut = objReader("InOut")
                strEmployeeID = objReader("strEmployeeID")
                CompanyCode = objReader("CompanyCode")
                Department = objReader("DepartmentCode")

                If CheckIfRecordAlreadyExist(PIN, Timedata) = False Then
                    If CheckIfEmployeeExist(PIN) = True Then
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
                                                                             "','" & strEmployeeID & _
                                                                             "','" & CompanyCode & _
                                                                             "','" & Department & _
                                                                             "'", "")
                    Else
                        MessageBox.Show(PIN & " has no record in the database. Please add this person in the employee list.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                    'If MessageBox.Show("The records from " & StrPath & " has already been imported.", "Record already exist.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.No Then
                    'Me.bgworkerImport.CancelAsync()
                    'success = False
                    'Exit Sub
                    'End If

                End If

            End While
        End If
        cnAccess.Close()
    End Sub

#End Region

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        Me.OFDDatabase.Title = "Please select a database source"
        Me.OFDDatabase.Filter = "Microsoft Access Database (*.mdb)|*.mdb"
        Me.OFDDatabase.DefaultExt = ".mdb"
        Me.OFDDatabase.FileName = ""

        If Not Me.OFDDatabase.ShowDialog = Windows.Forms.DialogResult.Cancel = True And CheckExistingData(Me.OFDDatabase.SafeFileName.ToString) = False Then
            Dim MyItem = Me.lstvwImportDTR.Items.Add(Me.OFDDatabase.SafeFileName.ToString, 0) '0
            With MyItem
                .SubItems.Add(Me.OFDDatabase.FileName.ToString) '1
            End With
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmImportDTR_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to delete file " & Me.lstvwImportDTR.SelectedItems(0).Text & "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.lstvwImportDTR.Items.RemoveAt(Me.lstvwImportDTR.SelectedItems(0).Index)
        End If

    End Sub

    Private Sub cmsImportDTR_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmsImportDTR.Opening
        If Me.lstvwImportDTR.SelectedItems.Count > 0 Then
            Me.DeleteToolStripMenuItem.Enabled = True
        Else
            Me.DeleteToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        If Me.lstvwImportDTR.Items.Count = 0 Then
            MessageBox.Show("Please add an access database to import in the listview.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.btnProcess.Focus()
        Else
            Dim x As Integer
            For x = 0 To Me.lstvwImportDTR.Items.Count - 1
                strPath(x) = Me.lstvwImportDTR.Items(x).SubItems(1).Text
            Next
            Me.bgworkerImport.RunWorkerAsync()
        End If

    End Sub

    Private Sub bgworkerImport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgworkerImport.DoWork

        Dim x As Integer
        Control.CheckForIllegalCrossThreadCalls = False
        For x = 0 To strPath.Length - 1
            If Not strPath(x) = Nothing Then
                Me.pgbarImport.Value = 0
                ImportingData(strPath(x))
            End If
        Next

    End Sub

    Private Sub bgworkerImport_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bgworkerImport.ProgressChanged
        Me.pgbarImport.Value = e.ProgressPercentage
    End Sub

    Private Sub bgworkerImport_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgworkerImport.RunWorkerCompleted
        If success = True Then
            MessageBox.Show("Importing Daily Time Record has been successfully completed.", "Import", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.pgbarImport.Value = 0
        Else
            Dim x As Integer
            For x = 0 To strPath.Length - 1
                strPath(x) = Nothing
            Next
        End If
    End Sub

End Class