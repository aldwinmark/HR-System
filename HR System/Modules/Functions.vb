Imports System.Data.SqlClient

Module Functions

#Region "Public variables"
    Public tmpDateNow As Date = FormatDateTime(Date.Now, DateFormat.ShortDate)
    Public tmpDateDue As Date = FormatDateTime(tmpDateDue, DateFormat.ShortDate)
#End Region

#Region "Currency Formatting and Restriction"

    Public Sub ChangeSign(ByVal mtxt As TextBox, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Subtract = True Or e.KeyCode = Keys.OemMinus = True Then
            If Not mtxt.Text = "" Then
                mtxt.Text = CDbl(mtxt.Text) * -1
                If CDbl(mtxt.Text) > 0 Then
                    mtxt.SelectionStart = 0
                Else
                    mtxt.SelectionStart = 1
                End If
            End If
        End If
    End Sub 'KeyDown

    Public Sub CurrencyCheckPeriod(ByVal mtxt As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If mtxt.Text.Contains(".") = True Then
            e.Handled = OnlyNumeric(Asc(e.KeyChar))
        ElseIf mtxt.Text.Contains(".") = False And mtxt.Text.Length <= 0 Then
            e.Handled = OnlyNumeric(Asc(e.KeyChar))
        Else
            e.Handled = OnlyNumericWithPeriod(Asc(e.KeyChar))
        End If
    End Sub 'KeyPress

    Public Sub RestrictCurrency(ByVal mtxt As TextBox, ByVal e As System.EventArgs)
        If mtxt.Text.StartsWith("-") = False And mtxt.Text.Contains("-") = True Then
            mtxt.Text = mtxt.Text.Remove(0, 1)
        ElseIf mtxt.Text = "" Then
            mtxt.Text = 0
        End If
    End Sub 'TextChanged

#End Region

    Public Function CheckNull(ByVal obj As Object, ByVal Choice As String) As String
        If IsDBNull(obj) = True Then
            If Choice = "Date" Then
                CheckNull = Date.Now
            ElseIf Choice = "Number" Then
                CheckNull = 0
            Else
                CheckNull = ""
            End If
        Else
            If IsDate(obj) = True Then
                CheckNull = CDate(obj)
            Else
                CheckNull = obj
            End If
        End If
        Return CheckNull
    End Function

    Public Function DateEditMask(ByVal strDate As String) As String

        Dim f() As String
        f = (Split(strDate, "/"))

        If f(0).Length < 2 And f(1).Length > 2 Then
            DateEditMask = "0" & f(0) & "/" & f(1) & "/" & f(2)
        ElseIf f(0).Length = 2 And f(1).Length = 1 Then
            DateEditMask = f(0) & "/" & "0" & f(1) & "/" & f(2)
        ElseIf f(0).Length < 2 And f(1).Length < 2 Then
            DateEditMask = "0" & f(0) & "/" & "0" & f(1) & "/" & f(2)
        Else
            DateEditMask = f(0) & "/" & f(1) & "/" & f(2)
        End If

        Return DateEditMask

    End Function

    Public Function SetKWHRGotFocus(ByVal txt As MaskedTextBox, ByVal e As System.EventArgs)

        Dim strCheck As String = ""

        strCheck = OnlyNumberString(txt.Text)
        If Len(Trim(strCheck)) = 2 Then
            txt.Mask = "0000.0"
            txt.Text = "___" & strCheck
        ElseIf Len(Trim(strCheck)) = 3 Then
            txt.Mask = "0000.0"
            txt.Text = "__" & strCheck
        ElseIf Len(Trim(strCheck)) = 4 Then
            txt.Mask = "0000.0"
            txt.Text = "_" & strCheck
        End If

        Return txt.Focus

    End Function

    Public Function SetKWHRLostFocus(ByVal txt As MaskedTextBox, ByVal e As System.EventArgs)

        Dim str As String = ""

        str = OnlyNumberString(txt.Text)
        If str.Length > 0 Then str = (CInt(str)).ToString
        If Len(Trim(str)) = 2 AndAlso Not CDbl(str) <= 0 Then
            txt.Mask = "0.0"
            txt.Text = str
        ElseIf Len(Trim(str)) = 3 AndAlso Not CDbl(str) <= 0 Then
            txt.Mask = "00.0"
            txt.Text = str
        ElseIf Len(Trim(str)) = 4 AndAlso Not CDbl(str) <= 0 Then
            txt.Mask = "000.0"
            txt.Text = str
        Else
            txt.Clear()
            txt.Mask = "0000.0"
            txt.SelectionStart = 1
        End If

        Return Nothing

    End Function

    Public Function SetCurrencyGotFocus(ByVal txt As MaskedTextBox, ByVal e As System.EventArgs) As MaskedTextBox
        Dim strCheck As String = ""

        strCheck = OnlyNumberString(txt.Text)
        If Len(Trim(strCheck)) = 3 Then
            txt.Mask = "0,000,000.00"
            txt.Text = "______" & strCheck
        ElseIf Len(Trim(strCheck)) = 4 Then
            txt.Mask = "0,000,000.00"
            txt.Text = "_____" & strCheck
        ElseIf Len(Trim(strCheck)) = 5 Then
            txt.Mask = "0,000,000.00"
            txt.Text = "____" & strCheck
        ElseIf Len(Trim(strCheck)) = 6 Then
            txt.Mask = "0,000,000.00"
            txt.Text = "___" & strCheck
        ElseIf Len(Trim(strCheck)) = 7 Then
            txt.Mask = "0,000,000.00"
            txt.Text = "__" & strCheck
        ElseIf Len(Trim(strCheck)) = 8 Then
            txt.Mask = "0,000,000.00"
            txt.Text = "_" & strCheck
        End If

        Return txt

    End Function

    Public Function SetCurrencyLostFocus(ByVal txt As MaskedTextBox, ByVal e As System.EventArgs)

        Dim str As String = ""

        str = OnlyNumberString(txt.Text)
        If str.Length > 0 Then str = (CInt(str)).ToString

        If Len(Trim(str)) = 3 AndAlso Not CDbl(str) <= 0 Then
            txt.Mask = "0.00"
            txt.Text = str
        ElseIf Len(Trim(str)) = 4 AndAlso Not CDbl(str) <= 0 Then
            txt.Mask = "00.00"
            txt.Text = str
        ElseIf Len(Trim(str)) = 5 AndAlso Not CDbl(str) <= 0 Then
            txt.Mask = "000.00"
            txt.Text = str
        ElseIf Len(Trim(str)) = 6 AndAlso Not CDbl(str) <= 0 Then
            txt.Mask = "0,000.00"
            txt.Text = str
        ElseIf Len(Trim(str)) = 7 AndAlso Not CDbl(str) <= 0 Then
            txt.Mask = "00,000.00"
            txt.Text = str
        ElseIf Len(Trim(str)) = 8 AndAlso Not CDbl(str) <= 0 Then
            txt.Mask = "000,000.00"
            txt.Text = str
        ElseIf Len(Trim(str)) = 9 AndAlso Not CDbl(str) <= 0 Then
            txt.Mask = "0,000,000.00"
            txt.Text = str
        Else
            txt.Clear()
            txt.Mask = "0,000,000.00"
            txt.SelectionStart = 4
        End If

        Return txt

    End Function

    Public Function SetCenter(ByVal Data As String, ByVal Spacing As Integer)

        'e.g 
        'Data=ZAMCELCO
        'total characters horizontally

        Dim LenStr As Integer
        Dim tmpSpace As Integer
        LenStr = Len(Trim(Data))
        tmpSpace = (Spacing / 2) - (LenStr / 2)
        'On Error GoTo err
        Data = Space(tmpSpace) & Trim(Data)
        Return Data
        Exit Function
        'Err:
        'MsgBox("Error in: " & vbNewLine & Data.Substring(0, Spacing))
        'Data = Data.Substring(0, Spacing)
        'Return Data

    End Function

    Public Function SetSpacing(ByVal Data As String, ByVal Spacing As Integer)

        Dim LenStr As Integer
        Dim tmpSapce As Integer
        LenStr = Len(Trim(Data))
        tmpSapce = Spacing - LenStr
        On Error GoTo Err
        Data = Trim(Data) & Space(tmpSapce)
        Return Data
        Exit Function
Err:
        'MsgBox("Error in: " & vbNewLine & Data.Substring(0, Spacing))
        Data = Data.Substring(0, Spacing)
        Return Data
    End Function

    Public Function CSQ(ByVal str)
        If IsDBNull(str) Then str = ""
        CSQ = Replace(str, "'", "''")

        'Function CSQ(byVal str)
        'If IsNull(str) Then str = ""
        'CSQ = Replace(str, "'", "''")
        'End Function

        'myvar = "Bob's Diner"

        'Sql = "INSERT INTO tablename (myvar, myvar2) VALUES ('" & CSQ(myvar) & "','" & CSQ(myvar2) & "')"
        'rs = Conn.Execute(Sql)

    End Function

    Public Function NoCharacter(ByVal Key As String) As Boolean
        NoCharacter = True
        'e.Handled = NoCharacter(Asc(e.KeyChar))
    End Function

    Public Function OnlyNumericWithPeriod(ByVal Key As String) As Boolean
        If (Key >= 48 And Key <= 57) Or Key = 8 Or Key = 46 Then
            OnlyNumericWithPeriod = False
        Else
            OnlyNumericWithPeriod = True
        End If
        'e.Handled = OnlyNumericWithPeriodMinus(Asc(e.KeyChar))
    End Function

    Public Function OnlyNumeric(ByVal Key As String) As Boolean
        'Allow only numeric
        If (Key >= 48 And Key <= 57) Or Key = 8 Then
            OnlyNumeric = False
        Else
            OnlyNumeric = True
        End If
        'e.Handled = OnlyNumeric(Asc(e.KeyChar))
    End Function

    Public Function SpecChar(ByVal key As String) As Boolean
        If (key >= 65 And key <= 90) Or (key >= 97 And key <= 122) Or key = 8 Or key = 32 Or key = 45 Or key = 44 Or key = 46 Or key = 47 Or (key >= 39 And key <= 41) Then
            SpecChar = False
        Else
            SpecChar = True
        End If
        'e.Handled = SpecChar(Asc(e.KeyChar))
    End Function

    Public Function FnumDate(ByVal Key As String) As Boolean
        'Allow only numeric
        If (Key = 48) Or Key = 49 Then
            FnumDate = True
        Else
            FnumDate = False
        End If
        'e.Handled = FnumDate(Asc(e.KeyChar))
    End Function

    Public Function KeyPressAll(ByVal txtN As MaskedTextBox, ByVal txtP As MaskedTextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ' MaskTextBox & MaskedTextBox
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            txtP.Focus()
            If txtP.Mask = "0,000,000.00" Then txtP.SelectionStart = 4
            If txtP.Mask = "0000.0" Then txtP.SelectionStart = 1
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            txtN.Focus()
            If txtN.Mask = "0,000,000.00" Then txtN.SelectionStart = 4
            If txtN.Mask = "0000.0" Then txtN.SelectionStart = 1
        End If
        Return Nothing

    End Function

    Public Function KeyPressAll(ByVal txtN As MaskedTextBox, ByVal txtP As ComboBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ' MaskTextBox & ComboBox
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            txtP.Focus()
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            txtN.Focus()
        End If

        Return Nothing

    End Function

    Public Function KeyPressAll(ByVal txtN As ComboBox, ByVal txtP As MaskedTextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ' ComboBox & MaskTextBox
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            txtP.Focus()
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            txtN.Focus()
        End If

        Return Nothing

    End Function

    Public Function KeyPressAll(ByVal txtN As ComboBox, ByVal txtP As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ' ComboBox & MaskTextBox
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            txtP.Focus()
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            txtN.Focus()
        End If

        Return Nothing

    End Function

    Public Function KeyPressAll(ByVal txtN As Button, ByVal txtP As MaskedTextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ' Button & MaskTextBox
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            txtP.Focus()
            If txtP.Mask = "0,000,000.00" Then txtP.SelectionStart = 4
            If txtP.Mask = "0000.0" Then txtP.SelectionStart = 1
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            txtN.Focus()
        End If

        Return Nothing

    End Function

    Public Function KeyPressAll(ByVal txtN As Button, ByVal txtP As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ' Button & MaskTextBox
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            txtP.Focus()
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            txtN.Focus()
        End If

        Return Nothing

    End Function

    Public Function KeyPressAll(ByVal txtN As Button, ByVal txtP As ComboBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ' Button & Combobox
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            txtP.Focus()
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            txtN.Focus()
        End If

        Return Nothing

    End Function

    Public Function KeyPressAll(ByVal txtN As ComboBox, ByVal txtP As Button, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ' Combobox & Button
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            txtP.Focus()
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            txtN.Focus()
        End If

        Return Nothing

    End Function

    Public Function KeyPressAll(ByVal txtN As MaskedTextBox, ByVal txtP As Button, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'MaskTextBox & Button
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            txtP.Focus()
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            txtN.Focus()
        End If

        Return Nothing

    End Function

    Public Function KeyPressAll(ByVal txtN As TextBox, ByVal txtP As MaskedTextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'TextBox & MaskTextBox
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            txtP.Focus()
            If txtP.Mask = "0,000,000.00" Then txtP.SelectionStart = 4
            If txtP.Mask = "0000.0" Then txtP.SelectionStart = 1
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            txtN.Focus()
        End If
        Return Nothing

    End Function

    Public Function KeyPressAll(ByVal txtN As TextBox, ByVal txtP As Button, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'TextBox & Button
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            txtP.Focus()
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            txtN.Focus()
        End If

        Return Nothing

    End Function

    '++++For checking+++++
    Public Function checkEmpty(ByVal txt As MaskedTextBox, ByVal str As String) As Boolean
        If Len(Trim(txt.Text)) <= 0 Then
            checkEmpty = False
            MsgBox(str, MsgBoxStyle.Exclamation, "empty")
            txt.Focus()
            txt.SelectionStart = 0
        Else
            checkEmpty = True
        End If
    End Function

    Public Function checkComplete(ByVal txt As MaskedTextBox, ByVal str As String) As Boolean
        If txt.MaskCompleted = False Then
            checkComplete = False
            MsgBox(str, MsgBoxStyle.Exclamation, "empty")
            txt.Focus()
            txt.SelectionStart = 0
        Else
            checkComplete = True
        End If
    End Function

    '++++For checking+++++
    Public Function checkEmpty(ByVal txt As TextBox, ByVal str As String) As Boolean
        If Len(Trim(txt.Text)) <= 0 Then
            checkEmpty = False
            MsgBox(str, MsgBoxStyle.Exclamation, "empty")
            txt.Focus()
            txt.SelectionStart = 0
        Else
            checkEmpty = True
        End If
    End Function

    Public Function checkDate(ByVal txt As MaskedTextBox, ByVal str As String) As Boolean
        If IsDate(txt.Text) = False Then
NotOK:
            checkDate = False
            MsgBox(str, MsgBoxStyle.Exclamation, "invalid date")
            txt.Focus()
            txt.SelectionStart = 0
        Else
            Dim f() As String

            f = (Split(txt.Text, "/"))

            If f(2) < 2000 Or f(1) > 32 Or f(0) > 12 Then
                GoTo NotOK
            Else
                checkDate = True
            End If
        End If
    End Function

    Public Function checkCombobox(ByVal cmbx As ComboBox, ByVal str As String) As Boolean
        If Trim(cmbx.Text) = "" Or cmbx.Text = "[select]" Then
            checkCombobox = False
            MsgBox(str, MsgBoxStyle.Exclamation, "no selection")
            cmbx.Focus()
        Else
            checkCombobox = True
        End If
    End Function

    Public Function checkTime(ByVal txt As MaskedTextBox, ByVal str As String) As Boolean

        Dim f() As String

        f = (Split(txt.Text, ":"))
        If Not (Trim(f(0)) = "" Or Trim(f(1)) = "") Then
            If CInt(Trim(f(0))) > 24 Or CInt(Trim(f(1))) > 60 Or CInt(Trim(f(0))) <= 0 Or CInt(Trim(f(1))) < 0 Then
                checkTime = False
                'MsgBox(str, MsgBoxStyle.Exclamation, "no selection")
                txt.Focus()
                txt.SelectionStart = 0
            Else
                checkTime = True
            End If
        Else
            checkTime = False
            'MsgBox(str, MsgBoxStyle.Exclamation, "no selection")
            txt.Focus()
        End If
    End Function

    'Search for the consumer name by Account id from finance database
    Public Function SearchData(ByVal sql As String, ByVal Data As String) As String

        Dim Val As String = ""

        CheckConnection(cn)

        Dim cmdSearch As New SqlCommand(sql, cn)
        Dim objReader As SqlDataReader = cmdSearch.ExecuteReader

        Try

            objReader.Read()

            If objReader.HasRows = True Then
                Try
                    Val = Trim(objReader(Data))
                    objReader.Close()
                    Return Val
                Catch ex As Exception
                    Return Val = 0
                End Try

            Else
                objReader.Close()
                Return Val
            End If

        Catch ex As Exception
            objReader.Close()
        End Try
        objReader.Close()
        Return Nothing

    End Function

    'Search for the data in the database if it exist
    ''' <summary>
    ''' General function in searching if record is existing or not in the specified table
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SearchData(ByVal sql As String) As Boolean

        CheckConnection(cn)

        Dim cmdSearch As New SqlCommand(sql, cn)
        Dim objReader As SqlDataReader = cmdSearch.ExecuteReader

        Try

            objReader.Read()

            If objReader.HasRows = True Then
                objReader.Close()
                Return True
            Else
                objReader.Close()
                Return False
            End If

        Catch ex As Exception
            objReader.Close()
            MsgBox(ex.Message & " Error. in connecting database.", MsgBoxStyle.Critical, "Required")
        End Try
        objReader.Close()
        Return Nothing

    End Function

    'Main Insert Function>>>>>>>>>>>>>>>
    Public Function InsertData(ByVal Table As String, ByVal Data As String, ByVal Val As String, ByVal msg As String)

        Dim SQL As String

        SQL = "INSERT INTO " & Table & "(" & Data & ")VALUES (" & Val & ")"

        CheckConnection(cn)

        Dim cmdSaveSQL As New SqlCommand(SQL, cn)

        'Try
        cmdSaveSQL.ExecuteNonQuery()
        If Not msg = "" Then
            MsgBox(msg, MsgBoxStyle.Information, "Saved")
        End If
        'Catch ex As Exception
        'MsgBox(ex.Message)
        'End Try

        Return Nothing

    End Function
    'Main Update Function>>>>>>>>>>>>>>>
    Public Function UpdateData(ByVal Table As String, ByVal Data As String, ByVal Where As String, ByVal WhereVal As String, ByVal msg As String)

        Dim SQL As String

        SQL = "UPDATE " & Table & " SET " & Data & " WHERE " & Where & "='" & WhereVal & "'"
        '"UPDATE tblUserAccount SET TimeOut='" & tmpTimeNow & "' , Status='" & Log & "'WHERE TellerID='" & Trim(TellerId) & "'"

        CheckConnection(cn)

        Dim cmdUpdateSQL As New SqlCommand(SQL, cn)

        'Try
        cmdUpdateSQL.ExecuteNonQuery()
        If Not msg = "" Then
            MsgBox(msg, MsgBoxStyle.Information, "Updated")
        End If
        'Catch ex As Exception
        'MsgBox(ex.Message)
        'End Try

        Return Nothing

    End Function
    'Main Update Function>>>>>>>>>>>>>>>
    Public Function UpdateData(ByVal Table As String, ByVal Data As String, ByVal Where As String, ByVal msg As String)

        Dim SQL As String

        SQL = "UPDATE " & Table & " SET " & Data & " WHERE " & Where & "'"
        '"UPDATE tblUserAccount SET TimeOut='" & tmpTimeNow & "' , Status='" & Log & "'WHERE TellerID='" & Trim(TellerId) & "'"

        CheckConnection(cn)

        Dim cmdUpdateSQL As New SqlCommand(SQL, cn)

        'Try
        cmdUpdateSQL.ExecuteNonQuery()
        If Not msg = "" Then
            MsgBox(msg, MsgBoxStyle.Information, "Updated")
        End If
        'Catch ex As Exception
        'MsgBox(ex.Message)
        'End Try

        Return Nothing

    End Function

    Public Function DeleteData(ByVal Table As String, ByVal Data As String, ByVal Where As String, ByVal WhereVal As String, ByVal msg As String)

        Dim StrSelect As String

        If MessageBox.Show("Are you sure you want to delete " & Data & "?", "confirm delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            StrSelect = "DELETE FROM " & Table & " WHERE " & Where & "= '" & WhereVal & "'"

            CheckConnection(cn)

            Dim cmd As New SqlCommand(StrSelect, cn)

            cmd.ExecuteNonQuery()
            MsgBox(msg, MsgBoxStyle.Information, "Deleted")

        End If
        Return Nothing
    End Function

    Public Function FindHoliday(ByVal tmpDays As TimeSpan) As Integer

        Dim SQL As String
        Dim TtlDays As Integer
        Dim x As Integer

        For x = 0 To CInt(tmpDays.Days)

            If (tmpDateDue.AddDays(x).DayOfWeek = DayOfWeek.Saturday Or tmpDateDue.AddDays(x).DayOfWeek = DayOfWeek.Sunday) Then
                GoTo WkDays
            End If

            SQL = "SELECT * FROM tblHoliday WHERE HDate='" & tmpDateDue.AddDays(x) & "'"

            CheckConnection(cn)

            Dim cmdS As New SqlCommand(SQL, cn)
            Dim objReaderS As SqlDataReader = cmdS.ExecuteReader


            objReaderS.Read()

            If objReaderS.HasRows = True Then
                'close the reader
                objReaderS.Close()
WkDays:
                TtlDays += 1
            Else
                'close the reader
                objReaderS.Close()
                GoTo Done
            End If

        Next
Done:
        Return TtlDays

    End Function

    Public Function OnlyNumberString(ByVal input As String) As String
        Dim StrChars As String = input.ToCharArray
        Dim outputStr As String = ""

        For Each s As String In StrChars
            If Char.IsDigit(s) = True Then
                outputStr &= s

                'Else
                '    'show invalid chars
                '    MessageBox.Show("This Charater is not a Number" & System.Environment.NewLine _
                '    & "'" & s & "'", "Invalid String", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Next
        Return outputStr
        ' Me.lblshow.Text = OnlyNumberString(Me.txtInput.Text)

    End Function

End Module
