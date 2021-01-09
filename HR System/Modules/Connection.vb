Imports System.Data.SqlClient
'Imports CrystalDecisions.CrystalReports.Engine
'Imports CrystalDecisions.Shared

Module Connection

    Public strConnection As String = "Data Source=192.168.1.254;" & _
                                     "uid=sa;" & _
                                     "pwd=zAm@1974101800;" & _
                                     "database=FingerID"
    Public cn As SqlConnection = New SqlConnection(strConnection)

    'Public strConnection As String = "Data Source=Silver-PC;" & _
    '                               "uid=sa;" & _
    '                               "pwd=zAm@1974101800;" & _
    '                               "database=FingerID"
    'Public cn As SqlConnection = New SqlConnection(strConnection)


    Public da As SqlDataAdapter = New SqlDataAdapter
    Public cmbldr As SqlCommandBuilder
    Public Sqlds As DataSet = New DataSet
    Public Sqlda As SqlDataAdapter = New SqlDataAdapter
    Public Sqlcmbldr As SqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public dr As DataRow
    Public dt As DataTable
   
    Public Function CheckConnection(ByVal conn As SqlConnection) As SqlConnection
        'Try
        'This function checks the recordset if it is open.
        'if it is open, then it will close the recordset
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        Return conn
        'Catch ex As Exception
        'MessageBox.Show(ex.Message, "Connection to SQL Server failed", MessageBoxButtons.OK)
        End
        'End Try

    End Function

    'Public Function CheckrptConnection(ByVal strCrystal As String) As CrystalDecisions.CrystalReports.Engine.ReportDocument

    '    Dim intCounter As Integer
    '    'Crystal Report's report document object
    '    Dim objReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    '    'object of table Log on info of Crystal report
    '    Dim ConInfo As New CrystalDecisions.Shared.TableLogOnInfo

    '    Try
    '        'Load the report
    '        'objReport.Load(Application.StartupPath & "\crptWinners.rpt")
    '        objReport.Load(strCrystal)

    '        ConInfo.ConnectionInfo.UserID = "sa"
    '        ConInfo.ConnectionInfo.Password = "zAm@1974101800"
    '        ConInfo.ConnectionInfo.ServerName = "IBMSERVER2"
    '        ConInfo.ConnectionInfo.DatabaseName = "CADDB"

    '        For intCounter = 0 To objReport.Database.Tables.Count - 1
    '            objReport.Database.Tables(intCounter).ApplyLogOnInfo(ConInfo)
    '        Next

    '    Catch ex As System.Exception
    '        MsgBox(ex.Message)
    '    End Try

    '    Return objReport

    'End Function

End Module
