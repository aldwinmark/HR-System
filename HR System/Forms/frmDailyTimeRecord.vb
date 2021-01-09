'Programmed by: Aldwin Mark F. Solis
'Date: 9-23-2010
'Title: List of Daily Time Record of Employee

Imports System.Data.SqlClient

Public Class frmDailyTimeRecord

#Region "Variable Declaration"
#End Region

#Region "User Function"
    
#End Region

#Region "Loading Data"

    Public Sub LoadDTR()
        Dim tmpStr(2) As String
        tmpStr = Me.cmbxEmployee.Text.Split("-")
        If tmpStr.Length = 2 Then
            FillDTR("SELECT TOP 50 * FROM TimeData WHERE PIN='" & tmpStr(1).Trim & "' AND Timedata >='" & Me.dtpStart.Value.ToShortDateString & " 12:00:00 AM ' AND Timedata <'" & Me.dtpEnd.Value.AddDays(1).ToShortDateString & "  12:00:00 AM' ORDER BY Timedata,Count ASC")
        End If
    End Sub

    Public Sub LoadEmployee()
        FillEmployee("SELECT * FROM Employees ORDER BY LastName ASC")
    End Sub

#End Region

#Region "Filling Data"

    Private Sub FillDTR(ByVal Sqlstring As String)

        Dim strDate As String
        Dim tmpDate As Date

        Me.lstvwDTR.Items.Clear()
        ds.Clear()

        Sqlda.SelectCommand = New SqlCommand(Sqlstring, cn)
        Sqlcmbldr = New SqlCommandBuilder(Sqlda)

        'On Error Resume Next
        Sqlda.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows
                Dim MyItem = Me.lstvwDTR.Items.Add(dr("ID"), 0) '0
                MyItem.tag = X
                X = X + 1
                With MyItem
                    tmpDate = dr("Timedata")
                    strDate = tmpDate.ToString("MM-dd-yyyy")
                    .SubItems.Add(strDate) '1
                    strDate = tmpDate.ToString("hh:mm")
                    .SubItems.Add(strDate) '2
                    strDate = tmpDate.ToString("tt")
                    .SubItems.Add(strDate) '3
                    .SubItems.Add(dr("Count".ToString)) '4
                    .SubItems.Add(dr("InOut".ToString)) '5
                  
                End With
            Next
        End If

        Dim i, j As Integer
        For i = 0 To Me.lstvwDTR.Items.Count - 1
            lstvwDTR.Items(i).UseItemStyleForSubItems = False
        Next

        For j = 0 To Me.lstvwDTR.Items.Count - 1
            If lstvwDTR.Items(j).SubItems(5).Text = "IN" Then
                lstvwDTR.Items(j).SubItems(5).ForeColor = Color.Red
            Else
                lstvwDTR.Items(j).SubItems(5).ForeColor = Color.Blue
            End If
        Next


    End Sub

    Private Sub FillEmployee(ByVal Sqlstring As String)

        Dim LastName As String
        Dim FirstName As String
        Dim MI As String
        Dim PIN As String
        Dim EmployeeName As String

        Me.cmbxEmployee.Items.Clear()
        CheckConnection(cn)
        Sqlda.SelectCommand = New SqlCommand(Sqlstring, cn)
        Sqlcmbldr = New SqlCommandBuilder(Sqlda)

        ds.Clear()
        Sqlda.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                LastName = dr("LastName")
                FirstName = dr("FirstName")
                MI = dr("MiddleInitial")
                PIN = dr("PIN")

                EmployeeName = LastName.Trim(" ") & ", " & FirstName.Trim(" ") & " " & MI.Trim(" ") & " -" & PIN

                Me.cmbxEmployee.Items.Add(SetSpacing(EmployeeName, 80))
            Next
        End If

    End Sub

#End Region

    Private Sub frmDailyTimeRecordEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadEmployee()
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        If Len(Me.cmbxEmployee.Text.Trim) > 0 Then
            LoadDTR()
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        With frmDailyTimeRecordEntry
            .dtpDate.Value = FormatDateTime(Me.lstvwDTR.SelectedItems(0).SubItems(1).Text)
            .mtxtCount.Text = Me.lstvwDTR.SelectedItems(0).SubItems(4).Text
            .mtxtTime.Text = Me.lstvwDTR.SelectedItems(0).SubItems(2).Text
            .cmbxAMPM.Text = Me.lstvwDTR.SelectedItems(0).SubItems(3).Text
            .DTR_ID = CInt(Me.lstvwDTR.SelectedItems(0).SubItems(0).Text)
            .cmbxStatus.Text = Me.lstvwDTR.SelectedItems(0).SubItems(5).Text
            .ShowDialog()
        End With
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        If Me.cmbxEmployee.Text = "" Then
            MessageBox.Show("Please select an employee.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cmbxEmployee.Focus()
        Else
            With frmDailyTimeRecordEntry
                Dim tmpStr(2) As String
                tmpStr = Me.cmbxEmployee.Text.Split("-")
                .PIN = tmpStr(1)
                .dtpDate.Focus()
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim str As String
        str = Me.lstvwDTR.SelectedItems(0).SubItems(1).Text & " " & Me.lstvwDTR.SelectedItems(0).SubItems(2).Text
        DeleteData("Timedata", str, "ID", Me.lstvwDTR.SelectedItems(0).SubItems(0).Text, str & " has been successfully deleted")
        LoadDTR()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadDTR()
    End Sub

    Private Sub cmsDailyTimeRecord_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmsDailyTimeRecord.Opening
        If Me.lstvwDTR.SelectedItems.Count > 0 Then
            Me.DeleteToolStripMenuItem.Enabled = True
        Else
            Me.DeleteToolStripMenuItem.Enabled = False
        End If
    End Sub

End Class