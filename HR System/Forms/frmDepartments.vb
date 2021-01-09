'Programmed by: Aldwin Mark F. Solis
'Date: 10-24-2010
'Title: Deaprtments

Imports System.Data.SqlClient

Public Class frmDepartments

#Region "Variable Declaration"
#End Region

#Region "Filling Data"

    Private Sub FillDepartments(ByVal Sqlstring As String)

        Me.lstvwDepartments.Items.Clear()
        ds.Clear()

        Sqlda.SelectCommand = New SqlCommand(Sqlstring, cn)
        Sqlcmbldr = New SqlCommandBuilder(Sqlda)

        'On Error Resume Next
        Sqlda.Fill(ds)
        Me.lblTotalRecord.Text = "Total record:  " & FormatNumber(ds.Tables(0).Rows.Count, 0)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows
                Dim MyItem = Me.lstvwDepartments.Items.Add(dr("DepartmentNumber"), 0) '0
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(UCase(dr("DepartmentCode".ToString))) '1
                    .SubItems.Add(dr("DepartmentDescription".ToString)) '2
                End With
            Next
        End If
    End Sub

#End Region

#Region "Loading Data"

    Public Sub LoadDepartments()
        FillDepartments("SELECT * FROM Department WHERE DepartmentDescription Like '" & CSQ(Me.txtSearch.Text) & "%'")
    End Sub

#End Region

    Private Sub frmDepartments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDepartments()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Me.LoadDepartments()
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        With frmDepartmentEntry
            .btnEnter.Text = "Save"
            .txtDepartmentCode.Focus()
            .ShowDialog()
        End With
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        With frmDepartmentEntry
            .btnEnter.Text = "Update"
            .ID = Me.lstvwDepartments.SelectedItems(0).Text
            .DepartmentCode = Me.lstvwDepartments.SelectedItems(0).SubItems(1).Text
            .txtDepartmentCode.Text = Me.lstvwDepartments.SelectedItems(0).SubItems(1).Text
            .txtDepartmentTitle.Text = Me.lstvwDepartments.SelectedItems(0).SubItems(2).Text
            .txtDepartmentCode.Focus()
            .ShowDialog()
        End With
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        DeleteData("Department", Me.lstvwDepartments.SelectedItems(0).SubItems(1).Text, "DepartmentNumber", Me.lstvwDepartments.SelectedItems(0).Text, Me.lstvwDepartments.SelectedItems(0).SubItems(1).Text & " has been successfully deleted.")
        Me.LoadDepartments()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        Me.LoadDepartments()
    End Sub

    Private Sub cmsDepartments_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmsDepartments.Opening
        If Me.lstvwDepartments.SelectedItems.Count > 0 Then
            Me.EditToolStripMenuItem.Enabled = True
            Me.DeleteToolStripMenuItem.Enabled = True
        Else
            Me.EditToolStripMenuItem.Enabled = False
            Me.DeleteToolStripMenuItem.Enabled = False
        End If
    End Sub

End Class