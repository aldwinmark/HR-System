'Programmed by: Aldwin Mark F. Solis
'Date: 10-24-2010
'Title: Employee Positions

Imports System.Data.SqlClient

Public Class frmPositions

#Region "Variable Declaration"
#End Region

#Region "Filling Data"

    Private Sub FillPositions(ByVal Sqlstring As String)

        Me.lstvwPositions.Items.Clear()
        ds.Clear()

        Sqlda.SelectCommand = New SqlCommand(Sqlstring, cn)
        Sqlcmbldr = New SqlCommandBuilder(Sqlda)

        'On Error Resume Next
        Sqlda.Fill(ds)
        Me.lblTotalRecord.Text = "Total record:  " & FormatNumber(ds.Tables(0).Rows.Count, 0)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows
                Dim MyItem = Me.lstvwPositions.Items.Add(dr("ID"), 0) '0
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(UCase(dr("PositionTitle".ToString))) '1
                    .SubItems.Add(UCase(dr("RoleDescription".ToString))) '2
                End With
            Next
        End If
    End Sub

#End Region

#Region "Loading Data"

    Public Sub LoadPositions()
        FillPositions("SELECT * FROM tblPositions WHERE PositionTitle Like '" & CSQ(Me.txtSearch.Text) & "%'")
    End Sub

#End Region

    Private Sub frmPositions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadPositions()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        Me.LoadPositions()
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        With frmPositionEntry
            .btnEnter.Text = "Save"
            .txtPositionName.Focus()
            .ShowDialog()
        End With
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        With frmPositionEntry
            .btnEnter.Text = "Update"
            .ID = Me.lstvwPositions.SelectedItems(0).Text
            .PositionTitle = Me.lstvwPositions.SelectedItems(0).SubItems(1).Text
            .txtPositionName.Text = Me.lstvwPositions.SelectedItems(0).SubItems(1).Text
            .txtRoleDescription.Text = Me.lstvwPositions.SelectedItems(0).SubItems(2).Text
            .txtPositionName.Focus()
            .ShowDialog()
        End With
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        DeleteData("tblPositions", Me.lstvwPositions.SelectedItems(0).SubItems(1).Text, "ID", Me.lstvwPositions.SelectedItems(0).Text, Me.lstvwPositions.SelectedItems(0).SubItems(1).Text & " has been successfully deleted.")
        Me.LoadPositions()
    End Sub

    Private Sub cmsPositions_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmsPositions.Opening
        If Me.lstvwPositions.SelectedItems.Count > 0 Then
            Me.EditToolStripMenuItem.Enabled = True
            Me.DeleteToolStripMenuItem.Enabled = True
        Else
            Me.EditToolStripMenuItem.Enabled = False
            Me.DeleteToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Me.LoadPositions()
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter = True Then
            Me.btnSearch_Click(sender, e)
        End If
    End Sub

End Class