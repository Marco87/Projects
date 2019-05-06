Imports System.Data
Imports System.Data.OleDb
Public Class frmDashBoard
    Dim dt As New DataTable
    Dim bAppClose As Boolean = False

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub picCinema1_MouseHover_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCinema1.MouseHover
        Me.Cursor = Cursors.Hand
    End Sub
    Private Sub picCinema1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCinema1.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub picCinema2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCinema2.MouseHover
        Me.Cursor = Cursors.Hand
    End Sub
    Private Sub picCinema2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCinema2.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub picCinema3_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCinema3.MouseHover
        Me.Cursor = Cursors.Hand
    End Sub
    Private Sub picCinema3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCinema3.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub picCinema4_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCinema4.MouseHover
        Me.Cursor = Cursors.Hand
    End Sub
    Private Sub picCinema4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCinema4.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub picCinema5_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCinema5.MouseHover
        Me.Cursor = Cursors.Hand
    End Sub
    Private Sub picCinema5_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCinema5.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub picCinema6_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCinema6.MouseHover
        Me.Cursor = Cursors.Hand
    End Sub
    Private Sub picCinema6_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCinema6.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub dtgResult_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgResult.DoubleClick
        If Me.dtgResult.Rows.Count > 0 Then
            Dim frm As New frmSeat
            frm.iSchedID = Me.dtgResult(0, Me.dtgResult.CurrentRow.Index).Value
            frm.ShowDialog()
            frm = Nothing
        End If

    End Sub

    Private Sub btnNewMovie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewMovie.Click
        Dim frm As New frmMovieList
        frm.ShowDialog()
        frm = Nothing
    End Sub

    Private Sub frmDashBoard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpMovieDate.Value = Format(Today, "MM/dd/yyyy")
        Load_Movies()
    End Sub
    Private Sub dtgResult_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles dtgResult.CellFormatting
        Me.dtgResult.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText = "Double click the the datagrid to view the seats reservation."
    End Sub
    Private Sub Load_Movies()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        Dim arrImage() As Byte
        Dim myMS As New IO.MemoryStream
        Dim sSQL As String = String.Empty
        Try
            sSQL = "SELECT b.movie_id, b.picture, a.cinema"
            sSQL = sSQL & " FROM schedule as a left join movies as b"
            sSQL = sSQL & " on a.movie_id = b.movie_id WHERE(a.[date] = @date) order by a.cinema"

            conn = New OleDbConnection(Get_Constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sSQL
            cmd.Parameters.Add("@date", OleDbType.DBDate).Value = Format(Me.dtpMovieDate.Value, "MM/dd/yyyy")

            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    If Not IsDBNull(dr("picture")) Then
                        myMS = New IO.MemoryStream
                        arrImage = dr("picture")
                        For Each ar As Byte In arrImage
                            myMS.WriteByte(ar)
                        Next
                    End If
                    Select Case dr("cinema")
                        Case 1
                            Me.picCinema1.Tag = dr("movie_id")
                            Me.picCinema1.Image = System.Drawing.Image.FromStream(myMS)
                        Case 2
                            Me.picCinema2.Tag = dr("movie_id")
                            Me.picCinema2.Image = System.Drawing.Image.FromStream(myMS)
                        Case 3
                            Me.picCinema3.Tag = dr("movie_id")
                            Me.picCinema3.Image = System.Drawing.Image.FromStream(myMS)
                        Case 4
                            Me.picCinema4.Tag = dr("movie_id")
                            Me.picCinema4.Image = System.Drawing.Image.FromStream(myMS)
                        Case 5
                            Me.picCinema5.Tag = dr("movie_id")
                            Me.picCinema5.Image = System.Drawing.Image.FromStream(myMS)
                        Case 6
                            Me.picCinema6.Tag = dr("movie_id")
                            Me.picCinema6.Image = System.Drawing.Image.FromStream(myMS)
                    End Select

                End While
            End If

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub picCinema1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCinema1.Click
        If Me.picCinema1.Tag > 0 Then
            Load_Schedule(Me.picCinema1.Tag, 1)
        End If
    End Sub
    Private Sub Load_Schedule(ByVal iMovieID As Integer, ByVal iCinemaNo As Short)
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        'Dim dt As New DataTable

        'try catch block is used to catch the error
        Try
            dt = New DataTable
            'get connection string declared in the Module1.vb and assing it to conn variable
            conn = New OleDbConnection(Get_Constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT a.sched_id, a.time_fr, a.time_to, a.remarks FROM schedule as a WHERE a.movie_id = @movie_id and a.cinema = @cinema and a.[date] = @date order by a.time_fr"
            cmd.Parameters.Add("@movie_id", OleDbType.BigInt).Value = iMovieID
            cmd.Parameters.Add("@cinema", OleDbType.BigInt).Value = iCinemaNo
            cmd.Parameters.Add("@date", OleDbType.DBDate).Value = Format(Me.dtpMovieDate.Value, "MM/dd/yyyy")
            da.SelectCommand = cmd
            da.Fill(dt)

            Me.dtgResult.DataSource = dt

            If dt.Rows.Count = 0 Then
                MsgBox("No record found!")
            End If

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnLoadMovie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadMovie.Click
        Clear()
        Load_Movies()
    End Sub
    Private Sub Clear()
        With Me
            .picCinema1.Tag = 0
            .picCinema1.ImageLocation = ""
            .picCinema1.Image = Nothing

            .picCinema2.Tag = 0
            .picCinema2.ImageLocation = ""
            .picCinema2.Image = Nothing

            .picCinema3.Tag = 0
            .picCinema3.ImageLocation = ""
            .picCinema3.Image = Nothing

            .picCinema4.Tag = 0
            .picCinema4.ImageLocation = ""
            .picCinema4.Image = Nothing

            .picCinema5.Tag = 0
            .picCinema5.ImageLocation = ""
            .picCinema5.Image = Nothing

            .picCinema6.Tag = 0
            .picCinema6.ImageLocation = ""
            .picCinema6.Image = Nothing

            If dt.Rows.Count > 0 Then
                dt.Rows.Clear()
            End If

        End With
    End Sub

    Private Sub picCinema2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCinema2.Click
        If Me.picCinema3.Tag > 0 Then
            Load_Schedule(Me.picCinema2.Tag, 2)
        End If
    End Sub

    Private Sub picCinema3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCinema3.Click
        If Me.picCinema3.Tag > 0 Then
            Load_Schedule(Me.picCinema3.Tag, 3)
        End If
    End Sub

    Private Sub picCinema4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCinema4.Click
        If Me.picCinema4.Tag > 0 Then
            Load_Schedule(Me.picCinema4.Tag, 4)
        End If
    End Sub

    Private Sub picCinema5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCinema5.Click
        If Me.picCinema5.Tag > 0 Then
            Load_Schedule(Me.picCinema5.Tag, 5)
        End If
    End Sub

    Private Sub picCinema6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCinema6.Click
        If Me.picCinema6.Tag > 0 Then
            Load_Schedule(Me.picCinema6.Tag, 6)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        bAppClose = False
        Me.Close()
        frmLogin.Close()
    End Sub

    Private Sub btnUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsers.Click
        Dim frm As New frmUserList
        frm.ShowDialog()
        frm = Nothing
    End Sub

    Private Sub btnSignOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignOut.Click
        bAppClose = True
        frmLogin.txtPassword.Text = strUser
        frmLogin.txtPassword.Text = ""
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub frmDashBoard_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If bAppClose = False Then
            frmLogin.Close()
        End If
    End Sub
End Class