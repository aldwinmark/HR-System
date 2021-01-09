Imports System.Data.SqlClient

Public Class frmSpecialSched

#Region "Functions"

    Private Sub Loadlist()
        FillEspSched("SELECT TOP 20 * FROM vwEmpEspSched WHERE Fullname Like '%" & Me.mtxtSearch.Text & "%' OR PIN Like '%" & Me.mtxtSearch.Text & "%' ORDER BY Fullname")
    End Sub

    Private Sub LoadListDays()
        FillEspDays("SELECT * FROM tblEmpEspDay WHERE PIN='" & Me.lblEmpId.Text & "'")
    End Sub

    Private Sub ActivateCMS()
        Me.SundayToolStripMenuItem.Enabled = True
        Me.MondayToolStripMenuItem.Enabled = True
        Me.TuesdayToolStripMenuItem.Enabled = True
        Me.WednesdayToolStripMenuItem.Enabled = True
        Me.ThursdayToolStripMenuItem.Enabled = True
        Me.FridayToolStripMenuItem.Enabled = True
        Me.SaturdayToolStripMenuItem.Enabled = True
    End Sub

    Private Sub AddDay()
        Me.cmsDays.Enabled = False
        Me.btnAddDay.Enabled = True
        Me.btnDeleteDay.Enabled = False
        Me.mtxtTimeIn.Enabled = True
        Me.mtxtTimeOut.Enabled = True
        Me.mtxtTimeIn.Focus()
    End Sub

    Private Sub ClearAddData()
        Me.cmsDays.Enabled = True
        Me.mtxtTimeIn.Clear()
        Me.mtxtTimeOut.Clear()
        Me.mtxtTimeIn.Enabled = False
        Me.mtxtTimeOut.Enabled = False
        Me.btnAddDay.Enabled = False
    End Sub

    Private Sub FillEspDays(ByVal Sqlstring As String)

        Dim y As Integer
        Me.lstvwEspDays.Items.Clear()

        ds.Clear()

        Sqlda.SelectCommand = New SqlCommand(Sqlstring, cn)
        Sqlcmbldr = New SqlCommandBuilder(Sqlda)

        'On Error Resume Next
        Sqlda.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows
                Dim MyItem = Me.lstvwEspDays.Items.Add(dr("Id"), 0) '0
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("PIN".ToString)) '1
                    .SubItems.Add(dr("Day".ToString)) '1
                    .SubItems.Add(dr("TimeIn".ToString)) '2
                    .SubItems.Add(dr("TimeOut".ToString)) '3
                End With
            Next
        End If

        ActivateCMS()

        For y = 0 To Me.lstvwEspDays.Items.Count - 1

            If Me.lstvwEspDays.Items(y).SubItems(2).Text = "Sunday" Then
                Me.SundayToolStripMenuItem.Enabled = False
            End If
            If Me.lstvwEspDays.Items(y).SubItems(2).Text = "Monday" Then
                Me.MondayToolStripMenuItem.Enabled = False
            End If
            If Me.lstvwEspDays.Items(y).SubItems(2).Text = "Tuesday" Then
                Me.TuesdayToolStripMenuItem.Enabled = False
            End If
            If Me.lstvwEspDays.Items(y).SubItems(2).Text = "Wednesday" Then
                Me.WednesdayToolStripMenuItem.Enabled = False
            End If
            If Me.lstvwEspDays.Items(y).SubItems(2).Text = "Thursday" Then
                Me.ThursdayToolStripMenuItem.Enabled = False
            End If
            If Me.lstvwEspDays.Items(y).SubItems(2).Text = "Friday" Then
                Me.FridayToolStripMenuItem.Enabled = False
            End If
            If Me.lstvwEspDays.Items(y).SubItems(2).Text = "Saturday" Then
                Me.SaturdayToolStripMenuItem.Enabled = False
            End If

        Next

    End Sub


    Private Sub FillEspSched(ByVal Sqlstring As String)

        Me.lstvwEspsSched.Items.Clear()

        ds.Clear()

        Sqlda.SelectCommand = New SqlCommand(Sqlstring, cn)
        Sqlcmbldr = New SqlCommandBuilder(Sqlda)

        On Error Resume Next
        Sqlda.Fill(ds)

        Me.lblTotalRecord.Text = "Total record(s): " & Format(ds.Tables(0).Rows.Count, "###0")
        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows
                iCurrentRecord = Me.BindingContext(ds.Tables(0)).Position + 1

                Dim MyItem = Me.lstvwEspsSched.Items.Add(dr("PIN"), 0) '0
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("Fullname".ToString)) '1
                    .SubItems.Add(dr("DepartmentCode".ToString)) '2
                    .SubItems.Add(dr("EmploymentStatus".ToString)) '3
                End With
            Next
        End If
    End Sub

    Private Sub FillSearch(ByVal Sqlstring As String)

        Me.lstvwSearch.Items.Clear()

        ds.Clear()

        Sqlda.SelectCommand = New SqlCommand(Sqlstring, cn)
        Sqlcmbldr = New SqlCommandBuilder(Sqlda)

        'On Error Resume Next
        Sqlda.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows
                'iCurrentRecord = Me.BindingContext(ds.Tables(0)).Position + 1
                If SearchData("SELECT * FROM vwEmpEspSched WHERE PIN='" & dr("PIN") & "'") = True Then GoTo ok
                Dim MyItem = Me.lstvwSearch.Items.Add(dr("PIN"), 0) '0
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("Fullname".ToString)) '1
                End With
ok:
            Next
        End If
    End Sub

#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.pnSearch.Visible = False
        Me.pnMain.Enabled = True
        Me.mtxtSearch.Focus()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseDay.Click

        ActivateCMS()

        Me.cmsDays.Enabled = True

        Me.btnAddDay.Enabled = False
        Me.btnDeleteDay.Enabled = False

        Me.pnEdit.Visible = False
        Me.pnMain.Enabled = True
        Me.mtxtSearch.Focus()

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        FillSearch("SELECT TOP 20 * FROM qryEmpNames WHERE Fullname Like '%" & Me.mtxtSearchInput.Text & "%' OR PIN Like '%" & Me.mtxtSearchInput.Text & "%' ORDER BY Fullname")
        Me.pnSearch.Visible = True
        Me.pnMain.Enabled = False
        Me.mtxtSearchInput.Focus()
    End Sub

    Private Sub mtxtSearchInput_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mtxtSearchInput.KeyDown
        If e.KeyValue = Keys.Down = True And Me.lstvwSearch.Items.Count > 0 Then
            Me.lstvwSearch.Focus()
            Me.lstvwSearch.TopItem.Selected = True
            Me.lstvwSearch.Items(0).Selected = True
            Me.lstvwSearch.Items(0).Focused = True
        End If
    End Sub

    Private Sub mtxtSearchInput_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles mtxtSearchInput.TextChanged
        FillSearch("SELECT TOP 20 * FROM qryEmpNames WHERE Fullname Like '%" & CSQ(Me.mtxtSearchInput.Text) & "%' OR PIN Like '%" & Me.mtxtSearchInput.Text & "%' ORDER BY Fullname")
    End Sub

    Private Sub lstvwSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstvwSearch.KeyDown
        If e.KeyValue = Keys.Escape = True Then
            Me.mtxtSearchInput.Focus()
        ElseIf e.KeyValue = Keys.Enter = True Then
            'Saving....

            InsertData("tblEmpEspTimeIn", "PIN", "'" & Me.lstvwSearch.Items(Me.lstvwSearch.SelectedItems(0).Index).SubItems(0).Text & "'", "Data has been successfully inserted")
            Loadlist()

            Me.pnSearch.Visible = False
            Me.btnAddDay.Enabled = True
            Me.pnMain.Enabled = True
            Me.mtxtTimeIn.Focus()
        End If
    End Sub

    Private Sub mtxtTimeIn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mtxtTimeIn.KeyPress
        KeyPressAll(Me.mtxtTimeOut, Me.mtxtTimeIn, e)
    End Sub

    Private Sub mtxtTimeOut_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mtxtTimeOut.KeyPress
        KeyPressAll(Me.btnAddDay, Me.mtxtTimeIn, e)
    End Sub

    Private Sub btnSave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnAddDay.KeyPress
        KeyPressAll(Me.btnAddDay, Me.mtxtTimeOut, e)
    End Sub

    Private Sub btnAddDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDay.Click
        If Me.mtxtTimeIn.MaskCompleted = True Then
            Try
                If CDate(Me.mtxtTimeIn.Text) > CDate("12:00") Then
                    MsgBox("Please enter a valid Time-In.", MsgBoxStyle.Exclamation, "invalid time")
                    Me.mtxtTimeIn.Focus()
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox("Please enter a valid Time-In.", MsgBoxStyle.Exclamation, "invalid time")
                Me.mtxtTimeIn.Focus()
                Exit Sub
            End Try
        Else
            MsgBox("Time-In is empty.", MsgBoxStyle.Exclamation, "invalid time")
            Me.mtxtTimeIn.Focus()
            Exit Sub
        End If

        If Me.mtxtTimeOut.MaskCompleted = True Then
            Try
                If CDate(Me.mtxtTimeOut.Text) > CDate("12:00") Then
                    MsgBox("Please enter a valid Time-Out.", MsgBoxStyle.Exclamation, "invalid time")
                    Me.mtxtTimeOut.Focus()
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox("Please enter a valid Time-Out.", MsgBoxStyle.Exclamation, "invalid time")
                Me.mtxtTimeOut.Focus()
                Exit Sub
            End Try
           
        Else
            MsgBox("Time-Out is empty.", MsgBoxStyle.Exclamation, "invalid time")
            Me.mtxtTimeOut.Focus()
            Exit Sub
        End If

        InsertData("tblEmpEspDay", "PIN" & _
                                  ",Day" & _
                                  ",TimeIn" & _
                                  ",TimeOut", "'" & Me.lblEmpId.Text & _
                                      "','" & Me.grpbxDay.Text & _
                                      "','" & Me.mtxtTimeIn.Text & _
                                      "','" & Me.mtxtTimeOut.Text & "'", "Data has been successfully inserted")

        ClearAddData()
        ActivateCMS()
        LoadListDays()

    End Sub

    Private Sub frmSpecialSched_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmDailyTardinessMon.LoadList()
    End Sub

    Private Sub frmSpecialSched_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Loadlist()
    End Sub

    Private Sub mtxtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles mtxtSearch.TextChanged
        Loadlist()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim StrSelect As String
        Try
            DeleteData("tblEmpEspTimeIn", Me.lstvwEspsSched.Items(Me.lstvwEspsSched.SelectedItems(0).Index).SubItems(1).Text, "PIN", Me.lstvwEspsSched.Items(Me.lstvwEspsSched.SelectedItems(0).Index).SubItems(0).Text, Me.lstvwEspsSched.Items(Me.lstvwEspsSched.SelectedItems(0).Index).SubItems(1).Text & " has been successfully deleted")

            StrSelect = "DELETE FROM tblEmpEspDay WHERE PIN= '" & Me.lstvwEspsSched.Items(Me.lstvwEspsSched.SelectedItems(0).Index).SubItems(0).Text & "'"

            CheckConnection(cn)
            Dim cmd As New SqlCommand(StrSelect, cn)
            cmd.ExecuteNonQuery()

            Loadlist()

        Catch ex As Exception
            Me.mtxtSearch.Focus()
        End Try

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        Try
            Me.lblEmpId.Text = Me.lstvwEspsSched.Items(Me.lstvwEspsSched.SelectedItems(0).Index).SubItems(0).Text
            Me.lblEmpName.Text = Me.lstvwEspsSched.Items(Me.lstvwEspsSched.SelectedItems(0).Index).SubItems(1).Text

            Me.pnEdit.Visible = True
            Me.pnMain.Enabled = False
            Me.btnAddDay.Enabled = False
        Catch ex As Exception
            Me.mtxtSearch.Focus()
        End Try
       
        LoadListDays()

    End Sub

    Private Sub SundayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SundayToolStripMenuItem.Click
        Me.grpbxDay.Text = "Sunday"
        Me.SundayToolStripMenuItem.Enabled = False
        AddDay()
    End Sub

    Private Sub MondayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MondayToolStripMenuItem.Click
        Me.grpbxDay.Text = "Monday"
        Me.MondayToolStripMenuItem.Enabled = False
        AddDay()
    End Sub

    Private Sub TuesdayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TuesdayToolStripMenuItem.Click
        Me.grpbxDay.Text = "Tuesday"
        Me.TuesdayToolStripMenuItem.Enabled = False
        AddDay()
    End Sub

    Private Sub WednesdayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WednesdayToolStripMenuItem.Click
        Me.grpbxDay.Text = "Wednesday"
        Me.WednesdayToolStripMenuItem.Enabled = False
        AddDay()
    End Sub

    Private Sub ThursdayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThursdayToolStripMenuItem.Click
        Me.grpbxDay.Text = "Thursday"
        Me.ThursdayToolStripMenuItem.Enabled = False
        AddDay()
    End Sub

    Private Sub FridayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FridayToolStripMenuItem.Click
        Me.grpbxDay.Text = "Friday"
        Me.FridayToolStripMenuItem.Enabled = False
        AddDay()
    End Sub

    Private Sub SaturdayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaturdayToolStripMenuItem.Click
        Me.grpbxDay.Text = "Saturday"
        Me.SaturdayToolStripMenuItem.Enabled = False
        AddDay()
    End Sub

    Private Sub btnDeleteDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteDay.Click
        Try
            DeleteData("tblEmpEspDay", Me.lstvwEspDays.Items(Me.lstvwEspDays.SelectedItems(0).Index).SubItems(2).Text, "Id", Me.lstvwEspDays.Items(Me.lstvwEspDays.SelectedItems(0).Index).SubItems(0).Text, Me.lstvwEspDays.Items(Me.lstvwEspDays.SelectedItems(0).Index).SubItems(2).Text & " has been successfully deleted")
            Me.btnDeleteDay.Enabled = False
            LoadListDays()
        Catch ex As Exception
            Me.btnAdd.Focus()
            Me.btnDeleteDay.Enabled = False
        End Try
    End Sub

    Private Sub lstvwEspDays_ItemActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstvwEspDays.ItemActivate
        If Me.btnAddDay.Enabled = False Then Me.btnDeleteDay.Enabled = True
    End Sub

End Class