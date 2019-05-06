Imports System.Data
Imports System.Data.OleDb
Public Class frmUserList

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim frm As New frmUsers
        frm.txtUserName.Tag = 0
        frm.ShowDialog()
        frm = Nothing
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
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
            sSQL = "SELECT user_id, [user_name], last_name + ', ' + first_name + ' ' + mid_name as name FROM users where last_name + ', ' + first_name + ' ' + mid_name like '%" & Me.txtSearch.Text & "%' or [user_name] = '" & Me.txtSearch.Text & "'"

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

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Load_Record()
    End Sub

    Private Sub dtgResult_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgResult.DoubleClick
        If Me.dtgResult.SelectedRows.Count > 0 Then
            Dim frm As New frmUsers
            frm.txtUserName.Tag = Me.dtgResult.Item(0, Me.dtgResult.CurrentRow.Index).Value
            frm.ShowDialog()
            frm = Nothing
        End If
    End Sub
End Class