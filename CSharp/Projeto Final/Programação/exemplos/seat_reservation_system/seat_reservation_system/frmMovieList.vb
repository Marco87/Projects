Imports System.Data
Imports System.Data.OleDb

Public Class frmMovieList

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim frm As New frmMovie
        frm.txtTitle.Tag = 0
        frm.ShowDialog()
        frm = Nothing
    End Sub
    Private Sub Load_Record()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable
        Dim sSQL As String = String.Empty

        'try catch block is used to catch the error
        Try
            'get connection string declared in the Module1.vb and assing it to conn variable
            conn = New OleDbConnection(Get_Constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            sSQL = "SELECT  top 1000 movie_id, title, rating FROM movies where title like '%" & Me.txtSearch.Text & "%' order by movie_id desc"

            cmd.CommandText = sSQL
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

    Private Sub frmMovieList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Record()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Load_Record()
    End Sub

    Private Sub dtgResult_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgResult.DoubleClick
        If Me.dtgResult.SelectedRows.Count > 0 Then
            Dim frm As New frmMovie
            frm.txtTitle.Tag = Me.dtgResult.Item(0, Me.dtgResult.CurrentRow.Index).Value
            frm.ShowDialog()
            frm = Nothing
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Load_Record()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class