Imports System.Data
Imports System.Data.OleDb
Public Class frmUsers
    Dim objCryp As Crypt
    Dim sCurrUser As String = String.Empty

    Private Sub frmUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.txtUserName.Tag = 0 Then
            If strUserLvl <> "administrator" Then
                Set_Button(4)
            Else
                Set_Button(1)
            End If
        Else
            Load_Record()
            If strUserLvl <> "administrator" Then
                Set_Button(4)
            End If
            Me.txtPassword.Visible = False
            Me.Label6.Visible = False
        End If
    End Sub

    Private Sub tsbSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSave.Click
        Dim res As New DialogResult

        res = MsgBox("Do you want to save data?", MsgBoxStyle.YesNo, "Address Book")
        If res = DialogResult.Yes Then
            If Len(Trim(Me.txtUserName.Text)) > 0 Then
                Save_Record()
                Set_Button(2)
            Else
                MsgBox("User Name is required.")
            End If

        End If
    End Sub

    Private Sub Save_Record()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim sSQL As String = String.Empty

        Try
            objCryp = New Crypt("pogisichris")
            'get connection string declared in the Module1.vb and assing it to conn variable
            conn = New OleDbConnection(Get_Constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            'I just use the textbox tag property to idetify if the data is new or existing.
            If Me.txtUserName.Tag = 0 Then
                sSQL = "INSERT INTO users ( [user_name], last_name, first_name, mid_name, user_level, [password])"
                sSQL = sSQL & "  VALUES (@user_name, @last_name, @first_name, @mid_name, @user_level, @password)"
                cmd.CommandText = sSQL
            Else
                sSQL = "UPDATE users set [user_name] = @user_name, last_name =  @last_name, first_name =  @first_name, mid_name = @mid_name, user_level = @user_level where [user_id] = @user_id"
                cmd.CommandText = sSQL
            End If

            cmd.Parameters.Add("@user_name", OleDbType.VarChar).Value = IIf(Len(Trim(Me.txtUserName.Text)) > 0, Me.txtUserName.Text, DBNull.Value)
            cmd.Parameters.Add("@last_name", OleDbType.VarChar).Value = IIf(Len(Trim(Me.txtLname.Text)) > 0, Me.txtLname.Text, "")
            cmd.Parameters.Add("@first_name", OleDbType.VarChar).Value = IIf(Len(Trim(Me.txtFname.Text)) > 0, Me.txtFname.Text, "")
            cmd.Parameters.Add("@mid_name", OleDbType.VarChar).Value = IIf(Len(Trim(Me.txtMname.Text)) > 0, Me.txtMname.Text, "")
            cmd.Parameters.Add("@user_level", OleDbType.VarChar).Value = IIf(Len(Trim(Me.cboLevel.Text)) > 0, Me.cboLevel.Text, DBNull.Value)
            If Me.txtUserName.Tag = 0 Then
                cmd.Parameters.Add("@password", OleDbType.VarChar).Value = IIf(Len(Trim(Me.txtPassword.Text)) > 0, objCryp.EncryptData(Trim(Me.txtPassword.Text)), DBNull.Value)
            End If

            cmd.Parameters.Add("@user_id", OleDbType.Numeric).Value = Me.txtUserName.Tag
            cmd.ExecuteNonQuery()

            If Me.txtUserName.Tag = 0 Then
                cmd.CommandText = "Select @@Identity"
                Me.txtUserName.Tag = cmd.ExecuteScalar()
            Else
                Me.txtPassword.Visible = False
                Me.Label6.Visible = False
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

        Try
            conn = New OleDbConnection(Get_Constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select user_id, [user_name], last_name, first_name, mid_name, user_level from users where user_id = " & Me.txtUserName.Tag

            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    Me.txtUserName.Tag = dr("user_id")
                    Me.txtUserName.Text = IIf(Not IsDBNull(dr("user_name")), dr("user_name"), "")
                    sCurrUser = IIf(Not IsDBNull(dr("user_name")), dr("user_name"), "")
                    Me.txtFname.Text = IIf(Not IsDBNull(dr("first_name")), dr("first_name"), "")
                    Me.txtMname.Text = IIf(Not IsDBNull(dr("mid_name")), dr("mid_name"), "")
                    Me.txtLname.Text = IIf(Not IsDBNull(dr("last_name")), dr("last_name"), "")
                    Me.cboLevel.Text = IIf(Not IsDBNull(dr("user_level")), dr("user_level"), "")
                End While
            End If

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

            cmd.CommandText = "delete from users where [user_id] = @id"

            cmd.Parameters.Add("@id", OleDbType.Numeric).Value = Me.txtUserName.Tag
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
                btnReset.Enabled = False
                Me.tsbChangePass.Enabled = False
            Case 2
                Me.tsbNew.Enabled = True
                Me.tsbSave.Enabled = True
                Me.tsbDelete.Enabled = True
                If sCurrUser <> strUser Then
                    Me.tsbChangePass.Enabled = False
                Else
                    Me.tsbChangePass.Enabled = True
                End If
                If strUserLvl <> "administrator" Then
                    btnReset.Enabled = False
                Else
                    btnReset.Enabled = True
                End If
            Case 3
                Me.tsbNew.Enabled = True
                Me.tsbSave.Enabled = False
                Me.tsbDelete.Enabled = False
                Me.tsbChangePass.Enabled = False
                btnReset.Enabled = False
            Case 4
                Me.tsbNew.Enabled = False
                Me.tsbSave.Enabled = False
                Me.tsbDelete.Enabled = False
                If sCurrUser <> strUser Then
                    Me.tsbChangePass.Enabled = False
                End If
                If strUserLvl <> "administrator" Then
                    btnReset.Enabled = False
                Else
                    btnReset.Enabled = True
                End If
        End Select
    End Sub
    Private Sub Clear_Fields()
        With Me
            .txtUserName.Tag = 0
            .txtUserName.Text = ""
            .txtFname.Text = ""
            .txtMname.Text = ""
            .txtLname.Text = ""
            .txtPassword.Text = ""
            .cboLevel.SelectedIndex = 1
        End With
    End Sub

    Private Sub tsbNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNew.Click
        Clear_Fields()
        Set_Button(1)
    End Sub


    Private Sub tsbClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbClose.Click
        Me.Close()
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

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Dim res As New DialogResult

        res = MsgBox("Do you want to reset password?", MsgBoxStyle.YesNo, "Address Book")
        If res = DialogResult.Yes Then
            Reset_Password()
        End If
    End Sub
    Private Sub Reset_Password()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim sSQL As String = String.Empty

        Try
            objCryp = New Crypt("pogisichris")
            'get connection string declared in the Module1.vb and assing it to conn variable
            conn = New OleDbConnection(Get_Constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sSQL = "UPDATE users set [password] = @password where [user_id] = @user_id"
            cmd.CommandText = sSQL

            cmd.Parameters.Add("@password", OleDbType.VarChar).Value = objCryp.EncryptData("12345678")
            cmd.Parameters.Add("@user_id", OleDbType.Numeric).Value = Me.txtUserName.Tag
            cmd.ExecuteNonQuery()

            MsgBox("Password has been reset.")

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub tsbChangePass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbChangePass.Click
        Dim frm As New frmChangePass
        frm.iUserID = Me.txtUserName.Tag
        frm.ShowDialog()
        frm = Nothing
    End Sub
End Class