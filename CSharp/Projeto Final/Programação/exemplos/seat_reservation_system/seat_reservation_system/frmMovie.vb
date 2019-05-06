Imports System.Data
Imports System.Data.OleDb
Public Class frmMovie
    Public iMovieID As Integer
    Dim dt As New DataTable
    Private Sub dtpTimeFr_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.dtpTimeFr.Format = DateTimePickerFormat.Time
    End Sub

    Private Sub frmMovie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.txtTitle.Tag = 0 Then
            Set_Button(1)
        Else
            Load_Record()
            Load_Schedule()
        End If
    End Sub

    Private Sub Save_Record()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim sSQL As String = String.Empty
        Dim arrImage() As Byte
        Dim myMs As New IO.MemoryStream
        Dim bSaveImage As Boolean = False
        Dim strImg As String = String.Empty

        Try
            If Not IsNothing(Me.pbMoviePic.Image) Then
                Me.pbMoviePic.Image.Save(myMs, Me.pbMoviePic.Image.RawFormat)
                arrImage = myMs.GetBuffer
            Else
                arrImage = Nothing
            End If
            'get connection string declared in the Module1.vb and assing it to conn variable
            conn = New OleDbConnection(Get_Constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            'I just use the textbox tag property to idetify if the data is new or existing.
            If Me.txtTitle.Tag = 0 Then
                sSQL = "INSERT INTO movies ( title, rating, picture)"
                sSQL = sSQL & "  VALUES(@title, @rating, @picture)"
                cmd.CommandText = sSQL
            Else
                sSQL = "UPDATE movies set title = @title, rating =  @rating, picture =  @picture where movie_id = @id"
                cmd.CommandText = sSQL
            End If


            cmd.Parameters.Add("@title", OleDbType.VarChar).Value = IIf(Len(Trim(Me.txtTitle.Text)) > 0, Me.txtTitle.Text, DBNull.Value)
            cmd.Parameters.Add("@rating", OleDbType.VarChar).Value = IIf(Len(Trim(Me.cboRating.Text)) > 0, Me.cboRating.Text, DBNull.Value)
            cmd.Parameters.Add("@picture", OleDbType.Binary).Value = IIf(Not IsNothing(arrImage), arrImage, DBNull.Value)
            cmd.Parameters.Add("@id", OleDbType.Numeric).Value = Me.txtTitle.Tag
            cmd.ExecuteNonQuery()

            'If the record is new then we have to get its ID so that we can edit it rightaway after the insertion.
            If Me.txtTitle.Tag = 0 Then
                cmd.CommandText = "Select @@Identity"
                'Set textbox tag property with the ID of new record
                Me.txtTitle.Tag = cmd.ExecuteScalar()
            End If
            MsgBox("Data has been save.")

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Load_Record()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        Dim arrImage() As Byte
        Dim myMS As New IO.MemoryStream

        Try
            conn = New OleDbConnection(Get_Constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select movie_id, title, rating, picture from movies where movie_id = " & Me.txtTitle.Tag

            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    Me.txtTitle.Tag = dr("movie_id")
                    Me.txtTitle.Text = IIf(Not IsDBNull(dr("title")), dr("title"), "")
                    Me.cboRating.Text = IIf(Not IsDBNull(dr("rating")), dr("rating"), "")
                    If Not IsDBNull(dr("picture")) Then
                        arrImage = dr("picture")
                        For Each ar As Byte In arrImage
                            myMS.WriteByte(ar)
                        Next
                        Me.pbMoviePic.Image = System.Drawing.Image.FromStream(myMS)
                    End If
                End While
            End If

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Load_Schedule()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim sQuery As String = String.Empty

        Try
            dt.Rows.Clear()
            sQuery = "SELECT a.movie_id, a.date, a.cinema, a.remarks FROM schedule as a"
            sQuery = sQuery & " left join movies as b"
            sQuery = sQuery & " on a.movie_id = b.movie_id"
            sQuery = sQuery & " where a.movie_id = " & Me.txtTitle.Tag
            sQuery = sQuery & " group by a.movie_id, a.date, a.cinema, a.remarks"

            conn = New OleDbConnection(Get_Constring)
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sQuery
            da.SelectCommand = cmd
            da.Fill(dt)

            Me.dtgSched.DataSource = dt

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Delete_Record()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim sSQL As String = String.Empty


        Try
            'get connection string declared in the Module1.vb and assing it to conn variable
            conn = New OleDbConnection(Get_Constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "delete from movies where movie_id = @id"

            cmd.Parameters.Add("@id", OleDbType.Numeric).Value = Me.txtTitle.Tag
            cmd.ExecuteNonQuery()

            MsgBox("Data has been deleted.")

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Set_Button(ByVal iMode As Short)
        Select Case iMode
            Case 1
                Me.tsbNew.Enabled = False
                Me.tsbSave.Enabled = True
                Me.tsbDelete.Enabled = False
                Sched_Buttons(False)
            Case 2
                Me.tsbNew.Enabled = True
                Me.tsbSave.Enabled = True
                Me.tsbDelete.Enabled = True
                Sched_Buttons(True)
            Case 3
                Me.tsbNew.Enabled = True
                Me.tsbSave.Enabled = False
                Me.tsbDelete.Enabled = False
                Sched_Buttons(False)
        End Select
    End Sub
    Private Sub Sched_Buttons(ByVal bEnable As Boolean)
        Me.btnNew.Enabled = bEnable
        Me.btnRefresh.Enabled = bEnable
    End Sub
    Private Sub tsbSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSave.Click
        Dim res As New DialogResult

        res = MsgBox("Do you want to save data?", MsgBoxStyle.YesNo, "Address Book")
        If res = DialogResult.Yes Then
            If Len(Trim(Me.txtTitle.Text)) > 0 Then
                Save_Record()
                Set_Button(2)
            Else
                MsgBox("Title is required.")
            End If

        End If
    End Sub

    Private Sub Clear_Fields()
        With Me
            .txtTitle.Tag = 0
            .txtTitle.Text = ""
            .cboRating.SelectedIndex = -1
            .pbMoviePic.ImageLocation = ""
            .pbMoviePic.Image = Nothing
            .lblPath.Text = ""
        End With
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPEG files (*.jpg)|*.jpg|GIF files (*.gif)|*.gif|All files (*.*)|*.*"
        OpenFileDialog1.ShowDialog()
        Me.lblPath.Text = OpenFileDialog1.FileName
        Me.pbMoviePic.ImageLocation = Me.lblPath.Text
    End Sub

    Private Sub tsbNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNew.Click
        Clear_Fields()
        Set_Button(1)
    End Sub

    Private Sub tsbDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbDelete.Click
        Dim res As New DialogResult

        res = MsgBox("Do you want to delete data?", MsgBoxStyle.YesNo, "Address Book")
        If res = DialogResult.Yes Then
            Delete_Record()
            Clear_Fields()
            Set_Button(3)
        End If
    End Sub

    Private Sub tsbClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbClose.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim frm As New frmTimeSched
        frm.iMovieID = Me.txtTitle.Tag
        frm.dtpSchedDate.Tag = 0
        frm.ShowDialog()
        frm = Nothing
    End Sub

    Private Sub dtgSched_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgSched.DoubleClick
        Dim frm As New frmTimeSched
        frm.iMovieID = Me.txtTitle.Tag
        frm.dtpSchedDate.Tag = Me.txtTitle.Tag
        frm.sDate = Me.dtgSched.Item(1, Me.dtgSched.CurrentRow.Index).Value
        frm.ShowDialog()
        frm = Nothing
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Load_Schedule()
    End Sub
End Class