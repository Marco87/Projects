Imports System.Data
Imports System.Data.OleDb

Public Class frmTimeSched
    Public iMovieID As Long
    Public sDate As String = String.Empty
    Dim dt As DataTable

    Private Sub frmTimeSched_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.dtpSchedDate.Tag = 0 Then
            Set_Button(1)
        Else
            Set_Button(2)
            Load_Record()
        End If
    End Sub
    Private Sub Load_Record()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        Dim i As Short = 1
        Try
            conn = New OleDbConnection(Get_Constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT sched_id, movie_id, [date], cinema, remarks, time_fr, time_to FROM schedule where movie_id = " & Me.dtpSchedDate.Tag & " and [date] = #" & sDate & "# order by time_fr"

            dr = cmd.ExecuteReader
            If dr.HasRows Then
                With Me
                    While dr.Read
                        .dtpSchedDate.Text = IIf(Not IsDBNull(dr("date")), dr("date"), "")
                        .cboCinema.Text = IIf(Not IsDBNull(dr("cinema")), dr("cinema"), "")
                        .txtRemarks.Text = IIf(Not IsDBNull(dr("remarks")), dr("remarks"), "")
                        Select Case i
                            Case 1
                                .dtpFr1.Format = DateTimePickerFormat.Time
                                .dtpTo1.Format = DateTimePickerFormat.Time
                                .dtpFr1.Value = IIf(Not IsDBNull(dr("time_fr")), Format(dr("date"), "MM/dd/yyyy") & " " & dr("time_fr"), "")
                                .dtpTo1.Value = IIf(Not IsDBNull(dr("time_to")), Format(dr("date"), "MM/dd/yyyy") & " " & dr("time_to"), "")
                                .dtpFr1.Tag = dr("sched_id")
                            Case 2
                                .dtpFr2.Format = DateTimePickerFormat.Time
                                .dtpTo2.Format = DateTimePickerFormat.Time
                                .dtpFr2.Value = IIf(Not IsDBNull(dr("time_fr")), Format(dr("date"), "MM/dd/yyyy") & " " & dr("time_fr"), "")
                                .dtpTo2.Value = IIf(Not IsDBNull(dr("time_to")), Format(dr("date"), "MM/dd/yyyy") & " " & dr("time_to"), "")
                                .dtpFr2.Tag = dr("sched_id")
                            Case 3
                                .dtpFr3.Format = DateTimePickerFormat.Time
                                .dtpTo3.Format = DateTimePickerFormat.Time
                                .dtpFr3.Value = IIf(Not IsDBNull(dr("time_fr")), Format(dr("date"), "MM/dd/yyyy") & " " & dr("time_fr"), "")
                                .dtpTo3.Value = IIf(Not IsDBNull(dr("time_to")), Format(dr("date"), "MM/dd/yyyy") & " " & dr("time_to"), "")
                                .dtpFr3.Tag = dr("sched_id")
                            Case 4
                                .dtpFr4.Format = DateTimePickerFormat.Time
                                .dtpTo4.Format = DateTimePickerFormat.Time
                                .dtpFr4.Value = IIf(Not IsDBNull(dr("time_fr")), Format(dr("date"), "MM/dd/yyyy") & " " & dr("time_fr"), "")
                                .dtpTo4.Value = IIf(Not IsDBNull(dr("time_to")), Format(dr("date"), "MM/dd/yyyy") & " " & dr("time_to"), "")
                                .dtpFr4.Tag = dr("sched_id")
                            Case 5
                                .dtpFr5.Format = DateTimePickerFormat.Time
                                .dtpTo5.Format = DateTimePickerFormat.Time
                                .dtpFr5.Value = IIf(Not IsDBNull(dr("time_fr")), Format(dr("date"), "MM/dd/yyyy") & " " & dr("time_fr"), "")
                                .dtpTo5.Value = IIf(Not IsDBNull(dr("time_to")), Format(dr("date"), "MM/dd/yyyy") & " " & dr("time_to"), "")
                                .dtpFr5.Tag = dr("sched_id")
                            Case 6
                                .dtpFr6.Format = DateTimePickerFormat.Time
                                .dtpTo6.Format = DateTimePickerFormat.Time
                                .dtpFr6.Value = IIf(Not IsDBNull(dr("time_fr")), Format(dr("date"), "MM/dd/yyyy") & " " & dr("time_fr"), "")
                                .dtpTo6.Value = IIf(Not IsDBNull(dr("time_to")), Format(dr("date"), "MM/dd/yyyy") & " " & dr("time_to"), "")
                                .dtpFr6.Tag = dr("sched_id")
                            Case 7
                                .dtpFr7.Format = DateTimePickerFormat.Time
                                .dtpTo7.Format = DateTimePickerFormat.Time
                                .dtpFr7.Value = IIf(Not IsDBNull(dr("time_fr")), Format(dr("date"), "MM/dd/yyyy") & " " & dr("time_fr"), "")
                                .dtpTo7.Value = IIf(Not IsDBNull(dr("time_to")), Format(dr("date"), "MM/dd/yyyy") & " " & dr("time_to"), "")
                                .dtpFr7.Tag = dr("sched_id")
                            Case 8
                                .dtpFr8.Format = DateTimePickerFormat.Time
                                .dtpTo8.Format = DateTimePickerFormat.Time
                                .dtpFr8.Value = IIf(Not IsDBNull(dr("time_fr")), Format(dr("date"), "MM/dd/yyyy") & " " & dr("time_fr"), "")
                                .dtpTo8.Value = IIf(Not IsDBNull(dr("time_to")), Format(dr("date"), "MM/dd/yyyy") & " " & dr("time_to"), "")
                                .dtpFr8.Tag = dr("sched_id")
                            Case 9
                                .dtpFr9.Format = DateTimePickerFormat.Time
                                .dtpTo9.Format = DateTimePickerFormat.Time
                                .dtpFr9.Value = IIf(Not IsDBNull(dr("time_fr")), Format(dr("date"), "MM/dd/yyyy") & " " & dr("time_fr"), "")
                                .dtpTo9.Value = IIf(Not IsDBNull(dr("time_to")), Format(dr("date"), "MM/dd/yyyy") & " " & dr("time_to"), "")
                                .dtpFr9.Tag = dr("sched_id")
                            Case 10
                                .dtpFr10.Format = DateTimePickerFormat.Time
                                .dtpTo10.Format = DateTimePickerFormat.Time
                                .dtpFr10.Value = IIf(Not IsDBNull(dr("time_fr")), Format(dr("date"), "MM/dd/yyyy") & " " & dr("time_fr"), "")
                                .dtpTo10.Value = IIf(Not IsDBNull(dr("time_to")), Format(dr("date"), "MM/dd/yyyy") & " " & dr("time_to"), "")
                                .dtpFr10.Tag = dr("sched_id")
                        End Select
                        i += 1
                    End While
                End With
            End If

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Save_Record()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim sSQL As String = String.Empty
        Dim bDelete As Boolean = False

        Try
            Fill_DataTable()
            'get connection string declared in the Module1.vb and assing it to conn variable
            conn = New OleDbConnection(Get_Constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            'I just use the textbox tag property to idetify if the data is new or existing.
            For Each row As DataRow In dt.Rows
                If row("sched_id") = 0 Then
                    sSQL = "INSERT INTO schedule (movie_id, [date], cinema, remarks, time_fr, time_to, entry_by, entry_date)"
                    sSQL = sSQL & "  VALUES(@movie_id, @date, @cinema, @remarks, @time_fr, @time_to, @entry_by, now)"
                    cmd.CommandText = sSQL
                    bDelete = False
                Else
                    If Trim(row("time_fr")) <> "" Then
                        sSQL = "UPDATE schedule set movie_id =  @movie_id, [date] =  @date, cinema =  @cinema, remarks =  @remarks,"
                        sSQL = sSQL & " time_fr =  @time_fr, time_to =  @time_to, updated_by =  @entry_by, updated_date =  now where sched_id = @sched_id"
                        bDelete = False
                    Else
                        sSQL = "DELETE from schedule where sched_id = " & row("sched_id")
                        bDelete = True
                    End If

                    cmd.CommandText = sSQL
                End If

                cmd.Parameters.Clear()
                cmd.Parameters.Add("@movie_id", OleDbType.BigInt).Value = row("movie_id")
                cmd.Parameters.Add("@date", OleDbType.DBDate).Value = row("date")
                cmd.Parameters.Add("@cinema", OleDbType.VarChar).Value = row("cinema")
                cmd.Parameters.Add("@remarks", OleDbType.VarChar).Value = row("remarks")
                cmd.Parameters.Add("@time_fr", OleDbType.VarChar).Value = row("time_fr")
                cmd.Parameters.Add("@time_to", OleDbType.VarChar).Value = row("time_to")
                cmd.Parameters.Add("@entry_by", OleDbType.VarChar).Value = strUser
                If row("sched_id") > 0 Then
                    cmd.Parameters.Add("@sched_id", OleDbType.BigInt).Value = row("sched_id")
                End If
                cmd.ExecuteNonQuery()

                If row("sched_id") = 0 Then
                    'If the record is new then we have to get its ID so that we can edit it right away after the insertion.
                    cmd.CommandText = "Select @@Identity"

                    'Set dattimepicker tag property with the ID of new record
                    Select Case row("dtpNo")
                        Case 1
                            Me.dtpFr1.Tag = cmd.ExecuteScalar()
                        Case 2
                            Me.dtpFr2.Tag = cmd.ExecuteScalar()
                        Case 3
                            Me.dtpFr3.Tag = cmd.ExecuteScalar()
                        Case 4
                            Me.dtpFr4.Tag = cmd.ExecuteScalar()
                        Case 5
                            Me.dtpFr5.Tag = cmd.ExecuteScalar()
                        Case 6
                            Me.dtpFr6.Tag = cmd.ExecuteScalar()
                        Case 7
                            Me.dtpFr7.Tag = cmd.ExecuteScalar()
                        Case 8
                            Me.dtpFr8.Tag = cmd.ExecuteScalar()
                        Case 9
                            Me.dtpFr9.Tag = cmd.ExecuteScalar()
                        Case 10
                            Me.dtpFr10.Tag = cmd.ExecuteScalar()
                    End Select

                    If bDelete = True Then
                        Select Case row("dtpNo")
                            Case 1
                                Me.dtpFr1.Tag = 0
                            Case 2
                                Me.dtpFr2.Tag = 0
                            Case 3
                                Me.dtpFr3.Tag = 0
                            Case 4
                                Me.dtpFr4.Tag = 0
                            Case 5
                                Me.dtpFr5.Tag = 0
                            Case 6
                                Me.dtpFr6.Tag = 0
                            Case 7
                                Me.dtpFr7.Tag = 0
                            Case 8
                                Me.dtpFr8.Tag = 0
                            Case 9
                                Me.dtpFr9.Tag = 0
                            Case 10
                                Me.dtpFr10.Tag = 0
                        End Select
                    End If
                End If
            Next

            MsgBox("Data has been save.")

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Fill_DataTable()
        dt = New DataTable

        With dt
            .Columns.Add("sched_id")
            .Columns.Add("movie_id")
            .Columns.Add("date")
            .Columns.Add("cinema")
            .Columns.Add("remarks")
            .Columns.Add("time_fr")
            .Columns.Add("time_to")
            .Columns.Add("dtpNo")
        End With

        If dtpFr1.Text = " " And dtpFr1.Tag = 0 Then
        Else
            Add_Row(dtpFr1, dtpTo1, 1)
        End If
        If dtpFr2.Text = " " And dtpFr2.Tag = 0 Then
        Else
            Add_Row(dtpFr2, dtpTo2, 2)
        End If
        If dtpFr3.Text = " " And dtpFr3.Tag = 0 Then
        Else
            Add_Row(dtpFr3, dtpTo3, 3)
        End If
        If dtpFr4.Text = " " And dtpFr4.Tag = 0 Then
        Else
            Add_Row(dtpFr4, dtpTo4, 4)
        End If
        If dtpFr5.Text = " " And dtpFr5.Tag = 0 Then
        Else
            Add_Row(dtpFr5, dtpTo5, 5)
        End If
        If dtpFr6.Text = " " And dtpFr6.Tag = 0 Then
        Else
            Add_Row(dtpFr6, dtpTo6, 6)
        End If
        If dtpFr7.Text = " " And dtpFr7.Tag = 0 Then
        Else
            Add_Row(dtpFr7, dtpTo7, 7)
        End If
        If dtpFr8.Text = " " And dtpFr8.Tag = 0 Then
        Else
            Add_Row(dtpFr8, dtpTo8, 8)
        End If
        If dtpFr9.Text = " " And dtpFr9.Tag = 0 Then
        Else
            Add_Row(dtpFr9, dtpTo9, 9)
        End If
        If dtpFr10.Text = " " And dtpFr10.Tag = 0 Then
        Else
            Add_Row(dtpFr10, dtpTo10, 10)
        End If

    End Sub
    Private Sub Add_Row(ByRef dtpFr As DateTimePicker, ByRef dtpTo As DateTimePicker, ByVal iNo As Short)
        Dim row As DataRow
        row = dt.NewRow
        row("sched_id") = dtpFr.Tag
        row("movie_id") = iMovieID
        row("date") = Me.dtpSchedDate.Text
        row("cinema") = Me.cboCinema.Text
        row("remarks") = Me.txtRemarks.Text
        row("time_fr") = dtpFr.Text
        row("time_to") = dtpTo.Text
        row("dtpNo") = iNo
        dt.Rows.Add(row)
    End Sub
    Private Sub Delete_Record()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim sSQL As String = String.Empty
        Dim bDelete As Boolean = False

        Try
            Fill_DataTable()
            'get connection string declared in the Module1.vb and assing it to conn variable
            conn = New OleDbConnection(Get_Constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sSQL = "delete from schedule where movie_id = @movie_id and [date] = @date"
            cmd.CommandText = sSQL

            cmd.Parameters.Clear()
            cmd.Parameters.Add("@movie_id", OleDbType.BigInt).Value = iMovieID
            cmd.Parameters.Add("@date", OleDbType.DBDate).Value = Me.dtpSchedDate.Text
            cmd.ExecuteNonQuery()

            MsgBox("Data has been deleted.")

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim res As New DialogResult

        res = MsgBox("Do you want to save data?", MsgBoxStyle.YesNo, "Address Book")
        If res = DialogResult.Yes Then
            Save_Record()
            Set_Button(2)
        End If
    End Sub
    Private Sub Set_Button(ByVal iMode As Short)
        Select Case iMode
            Case 1
                Me.btnNew.Enabled = False
                Me.btnSave.Enabled = True
                Me.btnDelete.Enabled = False
            Case 2
                Me.btnNew.Enabled = True
                Me.btnSave.Enabled = True
                Me.btnDelete.Enabled = True
            Case 3
                Me.btnNew.Enabled = True
                Me.btnSave.Enabled = False
                Me.btnDelete.Enabled = False
        End Select
    End Sub
    '-------------------------------------------------------------
    'The use of these procedures are the ff:
    '1. If the user click each empty datetimepicker we set its default time value and also apply it to the coresspoding datetimepicker in order to enforce our time format.
    '2. If the user left the datetimepicker( without setting its value or the value is equal to our default time value 
    '   we set its text to blank or empty by setting its format to DateTimePickerFormat.Custom and also apply it to the coresspoding datetimepicker.
    '   Take note the datetimepicker custom format value is single space or blank(" ").
    '3. To avoid procedure redundancy

    Private Sub dtp_Leave(ByRef dtpFrom As DateTimePicker, ByRef dtpTo As DateTimePicker)
        If dtpFrom.Value = Format(Today, "MM/dd/yyyy") & " 12:00:00 AM" And dtpTo.Value = Format(Today, "MM/dd/yyyy") & " 12:00:00 AM" Then
            dtpFrom.Format = DateTimePickerFormat.Custom
            dtpTo.Format = DateTimePickerFormat.Custom
        End If
    End Sub

    Private Sub dtp_MouseDown(ByRef dtpFrom As DateTimePicker, ByRef dtpTo As DateTimePicker)
        If dtpFrom.Format = DateTimePickerFormat.Custom Then
            dtpFrom.Format = DateTimePickerFormat.Time
            dtpFrom.Value = Format(Today, "MM/dd/yyyy") & " 12:00:00 AM"
            If dtpTo.Format = DateTimePickerFormat.Custom Then
                dtpTo.Format = DateTimePickerFormat.Time
                dtpTo.Value = Format(Today, "MM/dd/yyyy") & " 12:00:00 AM"
            End If
        End If
    End Sub
    Private Sub dtp_Erase(ByRef dtpFrom As DateTimePicker, ByRef dtpTo As DateTimePicker)
        dtpFrom.Format = DateTimePickerFormat.Custom
        dtpTo.Format = DateTimePickerFormat.Custom
    End Sub

    'End of procedures
    '-----------------------------------------------------------------------------------------------------

    Private Sub dtpFr1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFr1.Leave, dtpTo1.Leave
        dtp_Leave(dtpFr1, dtpTo1)
    End Sub

    Private Sub dtpFr1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpFr1.MouseDown, dtpTo1.MouseDown
        dtp_MouseDown(dtpFr1, dtpTo1)
    End Sub
    Private Sub dtpFr1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFr1.KeyDown, dtpTo1.KeyDown
        If e.KeyCode = 8 Or e.KeyCode = 46 Then
            dtp_Erase(dtpFr1, dtpTo1)
        End If
    End Sub

    Private Sub dtpFr2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFr2.Leave, dtpTo2.Leave
        dtp_Leave(dtpFr2, dtpTo2)
    End Sub

    Private Sub dtpFr2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpFr2.MouseDown, dtpTo2.MouseDown
        dtp_MouseDown(dtpFr2, dtpTo2)
    End Sub

    Private Sub dtpFr2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFr2.KeyDown, dtpTo2.KeyDown
        If e.KeyCode = 8 Or e.KeyCode = 46 Then
            dtp_Erase(dtpFr2, dtpTo2)
        End If
    End Sub

    Private Sub dtpFr3_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFr3.Leave, dtpTo3.Leave
        dtp_Leave(dtpFr3, dtpTo3)
    End Sub

    Private Sub dtpFr3_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpFr3.MouseDown, dtpTo3.MouseDown
        dtp_MouseDown(dtpFr3, dtpTo3)
    End Sub

    Private Sub dtpFr3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFr3.KeyDown, dtpTo3.KeyDown
        If e.KeyCode = 8 Or e.KeyCode = 46 Then
            dtp_Erase(dtpFr3, dtpTo3)
        End If
    End Sub

    Private Sub dtpFr4_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFr4.Leave, dtpTo4.Leave
        dtp_Leave(dtpFr4, dtpTo4)
    End Sub

    Private Sub dtpFr4_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpFr4.MouseDown, dtpTo4.MouseDown
        dtp_MouseDown(dtpFr4, dtpTo4)
    End Sub

    Private Sub dtpFr4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFr4.KeyDown, dtpTo4.KeyDown
        If e.KeyCode = 8 Or e.KeyCode = 46 Then
            dtp_Erase(dtpFr4, dtpTo4)
        End If
    End Sub

    Private Sub dtpFr5_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFr5.Leave, dtpTo5.Leave
        dtp_Leave(dtpFr5, dtpTo5)
    End Sub

    Private Sub dtpFr5_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpFr5.MouseDown, dtpTo5.MouseDown
        dtp_MouseDown(dtpFr5, dtpTo5)
    End Sub

    Private Sub dtpFr5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFr5.KeyDown, dtpTo5.KeyDown
        If e.KeyCode = 8 Or e.KeyCode = 46 Then
            dtp_Erase(dtpFr5, dtpTo5)
        End If
    End Sub

    Private Sub dtpFr6_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFr6.Leave, dtpTo6.Leave
        dtp_Leave(dtpFr6, dtpTo6)
    End Sub

    Private Sub dtpFr6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpFr6.MouseDown, dtpTo6.MouseDown
        dtp_MouseDown(dtpFr6, dtpTo6)
    End Sub

    Private Sub dtpFr6_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFr6.KeyDown, dtpTo6.KeyDown
        If e.KeyCode = 8 Or e.KeyCode = 46 Then
            dtp_Erase(dtpFr6, dtpTo6)
        End If
    End Sub

    Private Sub dtpFr7_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFr7.Leave, dtpTo7.Leave
        dtp_Leave(dtpFr7, dtpTo7)
    End Sub

    Private Sub dtpFr7_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpFr7.MouseDown, dtpTo7.MouseDown
        dtp_MouseDown(dtpFr7, dtpTo7)
    End Sub

    Private Sub dtpFr7_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFr7.KeyDown, dtpTo7.KeyDown
        If e.KeyCode = 8 Or e.KeyCode = 46 Then
            dtp_Erase(dtpFr7, dtpTo7)
        End If
    End Sub

    Private Sub dtpFr8_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFr8.Leave, dtpTo8.Leave
        dtp_Leave(dtpFr8, dtpTo8)
    End Sub

    Private Sub dtpFr8_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpFr8.MouseDown, dtpTo8.MouseDown
        dtp_MouseDown(dtpFr8, dtpTo8)
    End Sub

    Private Sub dtpFr8_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFr8.KeyDown, dtpTo8.KeyDown
        If e.KeyCode = 8 Or e.KeyCode = 46 Then
            dtp_Erase(dtpFr8, dtpTo8)
        End If
    End Sub

    Private Sub dtpFr9_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFr9.Leave, dtpTo9.Leave
        dtp_Leave(dtpFr9, dtpTo9)
    End Sub

    Private Sub dtpFr9_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpFr9.MouseDown, dtpTo9.MouseDown
        dtp_MouseDown(dtpFr9, dtpTo9)
    End Sub

    Private Sub dtpFr9_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFr9.KeyDown, dtpTo9.KeyDown
        If e.KeyCode = 8 Or e.KeyCode = 46 Then
            dtp_Erase(dtpFr9, dtpTo9)
        End If
    End Sub

    Private Sub dtpFr10_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFr10.Leave, dtpTo10.Leave
        dtp_Leave(dtpFr10, dtpTo10)
    End Sub

    Private Sub dtpFr10_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpFr10.MouseDown, dtpTo10.MouseDown
        dtp_MouseDown(dtpFr10, dtpTo10)
    End Sub

    Private Sub dtpFr10_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFr10.KeyDown, dtpTo10.KeyDown
        If e.KeyCode = 8 Or e.KeyCode = 46 Then
            dtp_Erase(dtpFr10, dtpTo10)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim res As New DialogResult

        res = MsgBox("Do you want to delete?", MsgBoxStyle.YesNo, "Address Book")
        If res = DialogResult.Yes Then
            Delete_Record()
            Clear_Field()
            Set_Button(3)
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Clear_Field()
    End Sub
    Private Sub Clear_Field()
        With Me
            .dtpSchedDate.Tag = 0
            .dtpSchedDate.Value = Format(Today, "MM/dd/yyyy")
            .txtRemarks.Text = ""
            .dtpFr1.Tag = 0
            .dtpFr1.Format = DateTimePickerFormat.Custom
            .dtpFr1.Value = Format(Today, "MM/dd/yyyy") & " 12:00:00 AM"
            .dtpTo1.Tag = 0
            .dtpTo1.Format = DateTimePickerFormat.Custom
            .dtpTo1.Value = Format(Today, "MM/dd/yyyy") & " 12:00:00 AM"

            .dtpFr2.Tag = 0
            .dtpFr2.Format = DateTimePickerFormat.Custom
            .dtpFr2.Value = Format(Today, "MM/dd/yyyy") & " 12:00:00 AM"
            .dtpTo2.Tag = 0
            .dtpTo2.Format = DateTimePickerFormat.Custom
            .dtpTo2.Value = Format(Today, "MM/dd/yyyy") & " 12:00:00 AM"

            .dtpFr3.Tag = 0
            .dtpFr3.Format = DateTimePickerFormat.Custom
            .dtpFr3.Value = Format(Today, "MM/dd/yyyy") & " 12:00:00 AM"
            .dtpTo3.Tag = 0
            .dtpTo3.Format = DateTimePickerFormat.Custom
            .dtpTo3.Value = Format(Today, "MM/dd/yyyy") & " 12:00:00 AM"
        End With
    End Sub
End Class