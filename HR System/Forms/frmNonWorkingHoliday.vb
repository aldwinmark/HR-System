'Programmed by: Aldwin Mark F. Solis
'Date: 3-017-2011
'Title: Non-working Holiday List

Imports System.Data.SqlClient

Public Class frmNonWorkingHoliday

#Region "User Functions"
   
#End Region

#Region "Filling Functions"

    Private Sub FillHoliday(ByVal Sqlstring As String)

        Dim tmpDate As Date
        Me.lstvwHolidays.Items.Clear()
        ds.Clear()

        Sqlda.SelectCommand = New SqlCommand(Sqlstring, cn)
        Sqlcmbldr = New SqlCommandBuilder(Sqlda)

        'On Error Resume Next
        Sqlda.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows
                Dim MyItem = Me.lstvwHolidays.Items.Add(dr("ID_NonWorkingDays"), 0) '0
                MyItem.tag = X
                X = X + 1
                With MyItem
                    tmpDate = dr("NonWorkingDate")
                    .SubItems.Add(UCase(dr("HolidayTitle".ToString))) '1
                    .SubItems.Add(UCase(tmpDate.ToString("MM/dd/yyyy"))) '2
                End With
            Next
        End If
    End Sub

#End Region

#Region "Loading Functions"

    Friend Sub LoadNonWorkingDays()
        FillHoliday("SELECT * FROM tblNonWorkingDay WHERE HolidayTitle Like '%" & Me.txtSearch.Text & "%'")
    End Sub

#End Region

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        frmNonWorkingHolidayEntry.ShowDialog()
    End Sub

    Private Sub frmNonWorkingHoliday_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmNonWorkingHoliday_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadNonWorkingDays()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        DeleteData("tblNonWorkingDay", Me.lstvwHolidays.SelectedItems(0).SubItems(1).Text, "ID_NonWorkingDays", Me.lstvwHolidays.SelectedItems(0).Text, Me.lstvwHolidays.SelectedItems(0).SubItems(1).Text & " has been successfully deleted.")
        Me.LoadNonWorkingDays()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadNonWorkingDays()
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyValue = Keys.Enter = True Then
            LoadNonWorkingDays()
        End If
    End Sub

End Class