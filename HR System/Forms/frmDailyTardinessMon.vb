Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System.IO

Public Class frmDailyTardinessMon

#Region "Declaration/Variables"

    Dim tmpcount As Integer

#End Region

#Region "Function"

    Public Sub LoadList()
        If Me.rbtnAutomatic.Checked = True Then
            FillDTM("SELECT TOP 200 * FROM vwEmpTimeIn WHERE Timedata >'" & Date.Now.ToString("MM/dd/yyyy") & " 08:01:00 AM" & "' AND Timedata <'" & Date.Now.ToString("MM/dd/yyyy") & " 12:00:00 PM" & "' ORDER BY Timedata ASC")
        Else
            FillDTM("SELECT TOP 200 * FROM vwEmpTimeIn WHERE Timedata >= '" & CDate(Me.dtpStarting.Value) & "'AND Timedata <'" & CDate(Me.dtpEnding.Value) & "' ORDER BY Timedata ASC")
        End If

    End Sub

    Private Function CheckEsp(ByVal ID As String, ByVal IntDay As Integer, ByVal strTime As String) As Boolean

        Dim strDay As String = ""
        CheckConnection(cn)

        If IntDay = 0 Then
            strDay = "Sunday"
        ElseIf IntDay = 1 Then
            strDay = "Monday"
        ElseIf IntDay = 2 Then
            strDay = "Tuesday"
        ElseIf IntDay = 3 Then
            strDay = "Wednesday"
        ElseIf IntDay = 4 Then
            strDay = "Thursday"
        ElseIf IntDay = 5 Then
            strDay = "Friday"
        ElseIf IntDay = 6 Then
            strDay = "Saturday"
        End If

        Dim cmdSearch As New SqlCommand("SELECT * FROM tblEmpEspDay WHERE PIN='" & ID & "' AND Day='" & strDay & "' AND TimeIn >'" & strTime & "'", cn)
        Dim objReader As SqlDataReader = cmdSearch.ExecuteReader

        objReader.Read()

        If objReader.HasRows = True Then
            objReader.Close()
            Return True
        Else
            objReader.Close()
            Return False
        End If

    End Function

    Private Sub FillDTM(ByVal Sqlstring As String)

        Dim str As String
        Dim strTime As String
        Dim count As Integer
        Dim IntDay As Integer
        Dim EspDate As Date
        Me.lstvwDTM.Items.Clear()

        ds.Clear()

        Sqlda.SelectCommand = New SqlCommand(Sqlstring, cn)
        Sqlcmbldr = New SqlCommandBuilder(Sqlda)

        On Error Resume Next
        Sqlda.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows
                'iCurrentRecord = Me.BindingContext(ds.Tables(0)).Position + 1
                EspDate = dr("Timedata")
                strTime = CDate(dr("Timedata")).ToString("hh:mm")
                Dim strId As String = dr("PIN")

                IntDay = EspDate.DayOfWeek

                str = dr("Fullname".ToString)
                If CheckEsp(dr("PIN"), IntDay, strTime) = True Then GoTo ok

                Dim MyItem = Me.lstvwDTM.Items.Add(dr("PIN"), 0) '0
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("Fullname".ToString)) '1
                    .SubItems.Add(dr("DepartmentCode".ToString)) '2
                    .SubItems.Add(strTime) '3
                    .SubItems.Add(dr("EmploymentStatus".ToString)) '4
                End With
                count += 1
ok:
            Next
            Me.lblTotalRecord.Text = "Total record(s): " & FormatNumber(count, 0)
        End If
    End Sub

#End Region

    Private Sub rbtnManual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnManual.CheckedChanged
        If Me.rbtnManual.Checked = True Then
            Me.tmRefresh.Stop()
            Me.pnManual.Enabled = True

            Me.dtpStarting.Value = Date.Now.ToString("MM/dd/yyyy") & " 08:01:00 AM"
            Me.dtpEnding.Value = Date.Now.ToString("MM/dd/yyyy") & " 12:00:00 PM"

            LoadList()
        Else
            Me.pnManual.Enabled = False
        End If
    End Sub

    Private Sub frmDailyTardinessMon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblStartingDate.Text = Date.Now.ToString("MM/dd/yyyy")
        Me.lblEndingDate.Text = Date.Now.ToString("MM/dd/yyyy")
        Me.tmRefresh.Start()
    End Sub

    Private Sub dtpStarting_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpStarting.ValueChanged
        Me.lblStartingDate.Text = Me.dtpStarting.Value.ToString("MM/dd/yyyy")
        LoadList()
    End Sub

    Private Sub dtpEnding_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpEnding.ValueChanged
        If Me.dtpStarting.Value > Me.dtpEnding.Value = True Then
            'MsgBox("Please enter a valid starting ending datetime.", MsgBoxStyle.Exclamation, "invalid starting datetime")
            Me.dtpStarting.Value = Now
        Else
            Me.lblEndingDate.Text = Me.dtpEnding.Value.ToString("MM/dd/yyyy")
            LoadList()
        End If

    End Sub

    Private Sub rbtnAutomatic_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnAutomatic.CheckedChanged
        Me.lstvwDTM.Items.Clear()
        If Me.rbtnAutomatic.Checked = True Then
            LoadList()
            Me.tmRefresh.Start()
        End If
    End Sub

    Private Sub tmRefresh_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmRefresh.Tick

        Dim count As Integer = 0

        Dim Sqlstring As String = "SELECT * FROM vwEmpTimeIn WHERE Timedata >'" & Date.Now.ToString("MM/dd/yyyy") & " 08:01:00 AM" & "' AND Timedata <'" & Date.Now.ToString("MM/dd/yyyy") & " 12:00:00 PM" & "' ORDER BY Timedata ASC"
        ds.Clear()

        Sqlda.SelectCommand = New SqlCommand(Sqlstring, cn)
        Sqlcmbldr = New SqlCommandBuilder(Sqlda)

        'On Error Resume Next
        Sqlda.Fill(ds)

        count = Format(ds.Tables(0).Rows.Count, "###0")
        If tmpcount <> count Then
            tmpcount = count
            LoadList()
        End If

    End Sub

    Private Sub lstvwDTM_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lstvwDTM.ItemSelectionChanged
        Me.lblName.Text = e.Item.SubItems(1).Text
        Me.lblDepartment.Text = e.Item.SubItems(2).Text
        Me.lblTime.Text = e.Item.SubItems(3).Text

        Dim sAppPath As String

        sAppPath = Application.StartupPath

        Dim str As String = sAppPath & "\EmployeePictures\" & e.Item.SubItems(0).Text & ".jpg"

        If File.Exists(str) = True Then
            Me.pcbxEmpPic.Image = New System.Drawing.Bitmap(str)
        Else
            Me.pcbxEmpPic.Image = New System.Drawing.Bitmap(sAppPath & "\EmployeePictures\" & 0 & ".jpg")
        End If

    End Sub

    Private Sub SpecialTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpecialTimeToolStripMenuItem.Click
        Me.tmRefresh.Stop()
        frmSpecialSched.ShowDialog()
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        'REPORT OBJECT
        Dim MyRpt As New MyReport

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("vwEmpTimeIn")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("PIN", Type.GetType("System.String"))
            .Add("Fullname", Type.GetType("System.String"))
            .Add("DepartmentCode", Type.GetType("System.String"))
            .Add("Timedata", Type.GetType("System.String"))
            .Add("EmploymentStatus", Type.GetType("System.String"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        For Each LVI As ListViewItem In Me.lstvwDTM.Items
            row = DS.Tables(0).NewRow
            row(0) = LVI.SubItems(0).Text
            row(1) = LVI.SubItems(1).Text
            row(2) = LVI.SubItems(2).Text
            row(3) = LVI.SubItems(3).Text
            row(4) = LVI.SubItems(4).Text
            DS.Tables(0).Rows.Add(row)
        Next

        'If Me.rbtnAutomatic.Checked = True Then
        'Date range of the summary 
        Dim DateRange As CrystalDecisions.CrystalReports.Engine.TextObject
        DateRange = MyRpt.ReportDefinition.ReportObjects.Item("txtDateRange")
        DateRange.Text = Me.dtpEnding.Value.ToLongDateString
        'Else
        ''Date range of the summary 
        'Dim DateRange As CrystalDecisions.CrystalReports.Engine.TextObject
        'DateRange = MyRpt.ReportDefinition.ReportObjects.Item("txtDateRange")
        'DateRange.Text = Me.lblStartingDate.Text & " to " & Me.lblEndingDate.Text
        'End If

        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        frmReportTardiness.crptvwTardiness.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing

        frmReportTardiness.Show()

    End Sub

End Class