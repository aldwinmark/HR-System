<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportDTR
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImportDTR))
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lstvwImportDTR = New System.Windows.Forms.ListView()
        Me.File = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Path = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsImportDTR = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EmployeeStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OFDDatabase = New System.Windows.Forms.OpenFileDialog()
        Me.bgworkerImport = New System.ComponentModel.BackgroundWorker()
        Me.pgbarImport = New System.Windows.Forms.ProgressBar()
        Me.cmsImportDTR.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnProcess
        '
        Me.btnProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcess.ForeColor = System.Drawing.Color.Navy
        Me.btnProcess.Location = New System.Drawing.Point(486, 295)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(92, 36)
        Me.btnProcess.TabIndex = 4
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(584, 295)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 36)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "&Cancel>>"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lstvwImportDTR
        '
        Me.lstvwImportDTR.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.File, Me.Path})
        Me.lstvwImportDTR.ContextMenuStrip = Me.cmsImportDTR
        Me.lstvwImportDTR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwImportDTR.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwImportDTR.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lstvwImportDTR.FullRowSelect = True
        Me.lstvwImportDTR.GridLines = True
        Me.lstvwImportDTR.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwImportDTR.Location = New System.Drawing.Point(13, 14)
        Me.lstvwImportDTR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstvwImportDTR.MultiSelect = False
        Me.lstvwImportDTR.Name = "lstvwImportDTR"
        Me.lstvwImportDTR.Size = New System.Drawing.Size(645, 199)
        Me.lstvwImportDTR.TabIndex = 6
        Me.lstvwImportDTR.UseCompatibleStateImageBehavior = False
        Me.lstvwImportDTR.View = System.Windows.Forms.View.Details
        '
        'File
        '
        Me.File.Text = "File"
        Me.File.Width = 187
        '
        'Path
        '
        Me.Path.Text = "Path"
        Me.Path.Width = 447
        '
        'cmsImportDTR
        '
        Me.cmsImportDTR.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmsImportDTR.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeStatusToolStripMenuItem, Me.ToolStripSeparator1, Me.AddToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.cmsImportDTR.Name = "cmsEmpStatus"
        Me.cmsImportDTR.Size = New System.Drawing.Size(147, 76)
        '
        'EmployeeStatusToolStripMenuItem
        '
        Me.EmployeeStatusToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.application_double
        Me.EmployeeStatusToolStripMenuItem.Name = "EmployeeStatusToolStripMenuItem"
        Me.EmployeeStatusToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.EmployeeStatusToolStripMenuItem.Text = "Import DTR"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(143, 6)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.AddToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.add
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.DeleteToolStripMenuItem.Image = Global.HR_System.My.Resources.Resources.delete
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Note:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(286, 21)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Please enter the access database to import data from"
        '
        'bgworkerImport
        '
        Me.bgworkerImport.WorkerReportsProgress = True
        Me.bgworkerImport.WorkerSupportsCancellation = True
        '
        'pgbarImport
        '
        Me.pgbarImport.Location = New System.Drawing.Point(455, 219)
        Me.pgbarImport.Name = "pgbarImport"
        Me.pgbarImport.Size = New System.Drawing.Size(204, 23)
        Me.pgbarImport.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pgbarImport.TabIndex = 40
        '
        'frmImportDTR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(671, 343)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pgbarImport)
        Me.Controls.Add(Me.lstvwImportDTR)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnProcess)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImportDTR"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import Daily Time Record"
        Me.cmsImportDTR.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lstvwImportDTR As System.Windows.Forms.ListView
    Friend WithEvents File As System.Windows.Forms.ColumnHeader
    Friend WithEvents Path As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmsImportDTR As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EmployeeStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OFDDatabase As System.Windows.Forms.OpenFileDialog
    Friend WithEvents bgworkerImport As System.ComponentModel.BackgroundWorker
    Friend WithEvents pgbarImport As System.Windows.Forms.ProgressBar
End Class
