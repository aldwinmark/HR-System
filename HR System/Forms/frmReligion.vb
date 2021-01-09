'Programmed by: Aldwin Mark F. Solis
'Date: 10-24-2010
'Title: Religion form

Imports System.Data.SqlClient

Public Class frmReligion

#Region "Variable Declaration"
    Friend Edit As Boolean
#End Region

#Region "Filling Data"

    Private Sub FillReligion(ByVal Sqlstring As String)

        Me.lstvwReligion.Items.Clear()
        ds.Clear()

        Sqlda.SelectCommand = New SqlCommand(Sqlstring, cn)
        Sqlcmbldr = New SqlCommandBuilder(Sqlda)

        'On Error Resume Next
        Sqlda.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows
                Dim MyItem = Me.lstvwReligion.Items.Add(dr("ID"), 0) '0
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("Title".ToString)) '1
                End With
            Next
        End If
    End Sub

#End Region

#Region "Loading Data"

    Public Sub LoadReligion()
        FillReligion("SELECT * FROM tblReligions")
    End Sub

#End Region

    Private Sub frmReligion_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmReligion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadReligion()
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        Me.btnEnter.Text = "Save"
        Me.lstvwReligion.Enabled = False
        Me.txtReligion.Text = ""
        Me.txtReligion.Enabled = True
        Me.txtReligion.Focus()
        Me.btnEnter.Text = "Save"
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If Me.btnCancel.Text = "Cancel" Then
            Me.lstvwReligion.Enabled = True
            Me.txtReligion.Enabled = False
            Me.txtReligion.Text = ""
            Me.lstvwReligion.Focus()
        Else
            Me.Close()
        End If

    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Me.lstvwReligion.Enabled = False
        Me.txtReligion.Text = ""
        Me.txtReligion.Enabled = True
        Me.txtReligion.Focus()
        Me.btnEnter.Text = "Update"
    End Sub

    Private Sub lstvwReligion_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstvwReligion.EnabledChanged
        If Me.lstvwReligion.Enabled = False Then
            Me.btnCancel.Text = "Cancel"
            Me.btnEnter.Enabled = True
        Else
            Me.btnCancel.Text = "Close"
            Me.btnEnter.Enabled = False
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        Me.LoadReligion()
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        If Len(Me.txtReligion.Text.Trim) = 0 Then
            MessageBox.Show("Please enter the name of religion.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtReligion.Focus()
        Else
            If Me.btnEnter.Text = "Save" Then
                InsertData("tblReligions", "Title", "'" & CSQ(txtReligion.Text) & "'", "Data has been successfully inserted")
            Else
                UpdateData("tblReligions", "Title='" & CSQ(Me.txtReligion.Text) & "'", "ID", Me.lstvwReligion.SelectedItems(0).Text, "Data has been successfully updated")
            End If
            Me.LoadReligion()
            Me.lstvwReligion.Enabled = True
            Me.txtReligion.Enabled = False
            Me.txtReligion.Text = ""
            Me.btnEnter.Text = "Save"
            Me.btnEnter.Enabled = False
        End If
    End Sub

    Private Sub cmsReligion_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmsReligion.Opening
        If Me.lstvwReligion.SelectedItems.Count > 0 Then
            Me.EditToolStripMenuItem.Enabled = True
            Me.DeleteToolStripMenuItem.Enabled = True
        Else
            Me.EditToolStripMenuItem.Enabled = False
            Me.DeleteToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        DeleteData("tblReligions", Me.lstvwReligion.SelectedItems(0).SubItems(1).Text, "ID", Me.lstvwReligion.SelectedItems(0).Text, Me.lstvwReligion.SelectedItems(0).SubItems(1).Text & " has been successfully deleted.")
        Me.LoadReligion()
    End Sub

End Class