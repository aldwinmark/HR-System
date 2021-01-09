'Programmed by: Aldwin Mark F. Solis
'Date: 03-17-2011
'Title: Shift Entry

Imports System.Data.SqlClient
Imports System.IO

Public Class frmShiftEntry

    Friend Employee_ID As String

#Region "User Function"

    Function CheckForDay(ByVal Employee_ID As String, ByVal Day As String) As Boolean

        CheckConnection(cn)

        Dim cmdSearch As New SqlCommand("SELECT * FROM tblShift WHERE Employee_ID='" & Employee_ID & "' AND Day='" & Day & "'", cn)
        Dim objReader As SqlDataReader = cmdSearch.ExecuteReader

        objReader.Read()

        If objReader.HasRows = True Then
            CheckForDay = True
        Else
            CheckForDay = False
        End If

        'close the reader
        objReader.Close()

        Return CheckForDay

    End Function

    Private Sub FillDays()

        If CheckForDay(Employee_ID, "Sunday") = False Then
            Me.cmbxDay.Items.Add("Sunday")
        End If
        If CheckForDay(Employee_ID, "Monday") = False Then
            Me.cmbxDay.Items.Add("Monday")
        End If
        If CheckForDay(Employee_ID, "Tuesday") = False Then
            Me.cmbxDay.Items.Add("Tuesday")
        End If
        If CheckForDay(Employee_ID, "Wednesday") = False Then
            Me.cmbxDay.Items.Add("Wednesday")
        End If
        If CheckForDay(Employee_ID, "Thursday") = False Then
            Me.cmbxDay.Items.Add("Thursday")
        End If
        If CheckForDay(Employee_ID, "Friday") = False Then
            Me.cmbxDay.Items.Add("Friday")
        End If
        If CheckForDay(Employee_ID, "Saturday") = False Then
            Me.cmbxDay.Items.Add("Saturday")
        End If

    End Sub

    Sub DateFrom()
        If Me.rbtnOff.Checked = True Then
            Me.grpbxDate.Enabled = False
        Else
            Me.grpbxDate.Enabled = True
        End If
    End Sub

    Function CheckIfShiftExist(ByVal Employee_ID As String, ByVal Day As String) As Boolean

        CheckConnection(cn)

        Dim cmdSearch As New SqlCommand("SELECT * FROM tblShift WHERE Employee_ID='" & Employee_ID & "' AND Day='" & Day & "'", cn)
        Dim objReader As SqlDataReader = cmdSearch.ExecuteReader

        objReader.Read()

        If objReader.HasRows = True Then
            CheckIfShiftExist = True
        Else
            CheckIfShiftExist = False
        End If

        'close the reader
        objReader.Close()

        Return CheckIfShiftExist

    End Function

#End Region

#Region "Loading Functions"


#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmShiftEntry_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub rbtnOn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnOn.CheckedChanged
        DateFrom()
    End Sub

    Private Sub rbtnOff_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnOff.CheckedChanged
        DateFrom()
    End Sub

    Private Sub btnEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntry.Click
        If Me.cmbxDay.Text = "" Then
            MessageBox.Show("Please select a day for the shift.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxDay.Focus()
        ElseIf Me.mtxtAMIn.MaskCompleted = False Then
            MessageBox.Show("Please enter a valid AM(In)time.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.mtxtAMIn.Focus()
        ElseIf Me.mtxtAMOut.MaskCompleted = False Then
            MessageBox.Show("Please enter a valid AM(Out)time.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.mtxtAMOut.Focus()
        ElseIf Me.mtxtPMIn.MaskCompleted = False Then
            MessageBox.Show("Please enter a valid PM(In)time.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.mtxtPMIn.Focus()
        ElseIf Me.mtxtPMOut.MaskCompleted = False Then
            MessageBox.Show("Please enter a valid PM(Out)time.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.mtxtPMOut.Focus()
        ElseIf CheckIfShiftExist(Employee_ID, Me.cmbxDay.Text) = True Then
            MessageBox.Show(Me.cmbxDay.Text & " already exist, please select another day.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxDay.Focus()
        Else
            Dim str As String
            Dim DateFrom As String
            Dim DateTo As String

            If Me.grpbxDate.Enabled = True Then
                DateFrom = Me.dtpFrom.Value.ToShortDateString
                DateTo = Me.dtpFrom.Value.ToShortDateString
            Else
                DateFrom = "-"
                DateTo = "-"
            End If

            str = "INSERT INTO tblShift (Employee_ID,Day,AMIn,AMOut,PMIn,PMOut,DateFrom,DateTo) VALUES('" & Employee_ID & "','" & Me.cmbxDay.Text & "','" & Me.mtxtAMIn.Text & " " & Me.cmbxAMIn.Text & "','" & Me.mtxtAMOut.Text & " " & Me.cmbxAMOut.Text & "','" & Me.mtxtPMIn.Text & " " & Me.cmbxPMIn.Text & "','" & Me.mtxtPMOut.Text & " " & Me.cmbxPMOut.Text & "','" & DateFrom & "','" & DateTo & "')"
            CheckConnection(cn)
            Dim cmd As New SqlCommand(str, cn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Shift has been successfully saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmEmployeeInfo.LoadEmployeeShift()
            Me.Close()
        End If
    End Sub

    Private Sub frmShiftEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillDays()
        Me.cmbxAMIn.Text = "AM"
        Me.cmbxAMOut.Text = "PM"
        Me.cmbxPMIn.Text = "PM"
        Me.cmbxPMOut.Text = "PM"
    End Sub

End Class