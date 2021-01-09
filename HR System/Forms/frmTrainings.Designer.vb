<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrainings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrainings))
        Me.lstvwTrainings = New System.Windows.Forms.ListView
        Me.Trianing_ID = New System.Windows.Forms.ColumnHeader
        Me.Title = New System.Windows.Forms.ColumnHeader
        Me.Description = New System.Windows.Forms.ColumnHeader
        Me.cmsTrainings = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.StartDate = New System.Windows.Forms.ColumnHeader
        Me.EndDate = New System.Windows.Forms.ColumnHeader
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.lblTotalRecord = New System.Windows.Forms.Label
        Me.btnSearch = New System.Windows.Forms.Button
        Me.AddTraininglStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditTraininglStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteTraininglStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RefreshTraininglStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsTrainings.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstvwTrainings
        '
        Me.lstvwTrainings.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Trianing_ID, Me.Title, Me.Description, Me.StartDate, Me.EndDate})
        Me.lstvwTrainings.ContextMenuStrip = Me.cmsTrainings
        Me.lstvwTrainings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwTrainings.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwTrainings.FullRowSelect = True
        Me.lstvwTrainings.GridLines = True
        Me.lstvwTrainings.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwTrainings.Location = New System.Drawing.Point(13, 42)
        Me.lstvwTrainings.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstvwTrainings.MultiSelect = False
        Me.lstvwTrainings.Name = "lstvwTrainings"
        Me.lstvwTrainings.Size = New System.Drawing.Size(915, 374)
        Me.lstvwTrainings.TabIndex = 26
        Me.lstvwTrainings.UseCompatibleStateImageBehavior = False
        Me.lstvwTrainings.View = System.Windows.Forms.View.Details
        '
        'Trianing_ID
        '
        Me.Trianing_ID.Text = ""
        Me.Trianing_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Trianing_ID.Width = 0
        '
        'Title
        '
        Me.Title.Text = "Title"
        Me.Title.Width = 269
        '
        'Description
        '
        Me.Description.Text = "Description"
        Me.Description.Width = 412
        '
        'cmsTrainings
        '
        Me.cmsTrainings.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmsTrainings.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripSeparator3, Me.AddTraininglStripMenuItem, Me.EditTraininglStripMenuItem, Me.DeleteTraininglStripMenuItem, Me.ToolStripSeparator4, Me.RefreshTraininglStripMenuItem})
        Me.cmsTrainings.Name = "cmsEmpStatus"
        Me.cmsTrainings.Size = New System.Drawing.Size(153, 148)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem1.Text = "Trainings"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(149, 6)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(149, 6)
        '
        'StartDate
        '
        Me.StartDate.Text = "Start Date"
        Me.StartDate.Width = 100
        '
        'EndDate
        '
        Me.EndDate.Text = "End Date"
        Me.EndDate.Width = 100
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(13, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(350, 24)
        Me.txtSearch.TabIndex = 28
        '
        'lblTotalRecord
        '
        Me.lblTotalRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRecord.Location = New System.Drawing.Point(10, 421)
        Me.lblTotalRecord.Name = "lblTotalRecord"
        Me.lblTotalRecord.Size = New System.Drawing.Size(235, 23)
        Me.lblTotalRecord.TabIndex = 42
        Me.lblTotalRecord.Text = "Total record:"
        Me.lblTotalRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.HR_System.My.Resources.Resources.magnifier
        Me.btnSearch.Location = New System.Drawing.Point(369, 10)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(85, 27)
        Me.btnSearch.TabIndex = 29
        Me.btnSearch.Text = "Search"
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'AddTraininglStripMenuItem
        '
        Me.AddTraininglStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.AddTraininglStripMenuItem.Image = Global.HR_System.My.Resources.Resources.add
        Me.AddTraininglStripMenuItem.Name = "AddTraininglStripMenuItem"
        Me.AddTraininglStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddTraininglStripMenuItem.Text = "Add"
        '
        'EditTraininglStripMenuItem
        '
        Me.EditTraininglStripMenuItem.Image = Global.HR_System.My.Resources.Resources.page_white_edit
        Me.EditTraininglStripMenuItem.Name = "EditTraininglStripMenuItem"
        Me.EditTraininglStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditTraininglStripMenuItem.Text = "Edit"
        '
        'DeleteTraininglStripMenuItem
        '
        Me.DeleteTraininglStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.DeleteTraininglStripMenuItem.Image = Global.HR_System.My.Resources.Resources.delete
        Me.DeleteTraininglStripMenuItem.Name = "DeleteTraininglStripMenuItem"
        Me.DeleteTraininglStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteTraininglStripMenuItem.Text = "Delete"
        '
        'RefreshTraininglStripMenuItem
        '
        Me.RefreshTraininglStripMenuItem.Image = Global.HR_System.My.Resources.Resources.arrow_refresh
        Me.RefreshTraininglStripMenuItem.Name = "RefreshTraininglStripMenuItem"
        Me.RefreshTraininglStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RefreshTraininglStripMenuItem.Text = "Refresh"
        '
        'frmTrainings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 453)
        Me.Controls.Add(Me.lblTotalRecord)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lstvwTrainings)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTrainings"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trainings"
        Me.cmsTrainings.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstvwTrainings As System.Windows.Forms.ListView
    Friend WithEvents Trianing_ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Title As System.Windows.Forms.ColumnHeader
    Friend WithEvents Description As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmsTrainings As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddTraininglStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditTraininglStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteTraininglStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshTraininglStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents EndDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblTotalRecord As System.Windows.Forms.Label
End Class
