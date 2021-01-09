'Programmed by: Aldwin Mark F. Solis
'Date: 10-26-2010
'Title: Training form

Imports System.Data.SqlClient

Public Class frmTrainings

#Region "Variable Declaration"
#End Region

#Region "Filling Data"

    Private Sub FillTrainings(ByVal Sqlstring As String)

        Me.lstvwTrainings.Items.Clear()
        ds.Clear()

        Sqlda.SelectCommand = New SqlCommand(Sqlstring, cn)
        Sqlcmbldr = New SqlCommandBuilder(Sqlda)

        'On Error Resume Next
        Sqlda.Fill(ds)
        Me.lblTotalRecord.Text = "Total record:  " & FormatNumber(ds.Tables(0).Rows.Count, 0)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows
                Dim MyItem = Me.lstvwTrainings.Items.Add(dr("ID"), 0) '0
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(UCase(dr("Title".ToString))) '1
                    .SubItems.Add(UCase(dr("Description".ToString))) '2
                    .SubItems.Add(FormatDateTime(dr("StartDate".ToString), DateFormat.ShortDate)) '4
                    .SubItems.Add(FormatDateTime(dr("EndDate".ToString), DateFormat.ShortDate)) '5
                End With
            Next
        End If
    End Sub

#End Region

#Region "Loading Data"

    Public Sub LoadTrainings()
        FillTrainings("SELECT * FROM tblTrainings WHERE Title Like '" & CSQ(Me.txtSearch.Text) & "%'")
    End Sub

#End Region

    Private Sub frmTrainings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LoadTrainings()
    End Sub

    Private Sub cmsTrainings_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmsTrainings.Opening
        If Me.lstvwTrainings.SelectedItems.Count > 0 Then
            Me.EditTraininglStripMenuItem.Enabled = True
            Me.DeleteTraininglStripMenuItem.Enabled = True
        Else
            Me.EditTraininglStripMenuItem.Enabled = False
            Me.DeleteTraininglStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub AddTraininglStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddTraininglStripMenuItem.Click
        With frmTrainingEntry
            .btnEnter.Text = "Save"
            .txtTitle.Focus()
            .ShowDialog()
        End With
    End Sub

    Private Sub EditTraininglStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditTraininglStripMenuItem.Click
        With frmTrainingEntry
            .btnEnter.Text = "Update"
            .ID = Me.lstvwTrainings.SelectedItems(0).Text
            .Title = Me.lstvwTrainings.SelectedItems(0).SubItems(1).Text
            .txtTitle.Text = Me.lstvwTrainings.SelectedItems(0).SubItems(1).Text
            .txtDescription.Text = Me.lstvwTrainings.SelectedItems(0).SubItems(2).Text
            .dtpStartDate.Value = CDate(Me.lstvwTrainings.SelectedItems(0).SubItems(3).Text)
            .dtpEndDate.Value = CDate(Me.lstvwTrainings.SelectedItems(0).SubItems(4).Text)
            .txtTitle.Focus()
            .ShowDialog()
        End With
    End Sub

    Private Sub DeleteTraininglStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteTraininglStripMenuItem.Click
        DeleteData("tblTrainings", Me.lstvwTrainings.SelectedItems(0).SubItems(1).Text, "ID", Me.lstvwTrainings.SelectedItems(0).Text, Me.lstvwTrainings.SelectedItems(0).SubItems(1).Text & " has been successfully deleted.")
        Me.LoadTrainings()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Me.LoadTrainings()
    End Sub

    Private Sub RefreshTraininglStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshTraininglStripMenuItem.Click
        Me.LoadTrainings()
    End Sub

End Class