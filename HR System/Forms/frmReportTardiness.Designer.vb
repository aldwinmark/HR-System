<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportTardiness
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
        Me.crptvwTardiness = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.crptTardiness1 = New HR_System.crptTardiness
        Me.SuspendLayout()
        '
        'crptvwTardiness
        '
        Me.crptvwTardiness.ActiveViewIndex = 0
        Me.crptvwTardiness.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crptvwTardiness.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crptvwTardiness.Location = New System.Drawing.Point(0, 0)
        Me.crptvwTardiness.Name = "crptvwTardiness"
        Me.crptvwTardiness.ReportSource = Me.crptTardiness1
        Me.crptvwTardiness.Size = New System.Drawing.Size(1028, 573)
        Me.crptvwTardiness.TabIndex = 0
        '
        'frmReportTardiness
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 573)
        Me.Controls.Add(Me.crptvwTardiness)
        Me.Name = "frmReportTardiness"
        Me.Text = "frmReportTardiness"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crptvwTardiness As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crptTardiness1 As HR_System.crptTardiness
End Class
