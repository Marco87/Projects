Imports System.Data
Imports System.Data.OleDb
Public Class frmChangePass
    Public iUserID As Integer = 0
    Dim sMsg As String = String.Empty
    Dim objCryp As Crypt

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim sReq As String = Validate_Required_fields()

        If Len(Trim(sReq)) > 0 Then
            MsgBox(sReq)
        Else
            If Trim(Me.txtNewPass.Text) <> Trim(Me.txtConfPass.Text) Then
                MsgBox("Password does not match.")
            Else
                If Validate_Password() = True Then
                    Save_Password()
                    MsgBox("Password has been changed.")
                Else
                    MsgBox("Old password is wrong.")
                End If
            End If
        End If

    End Sub
    Function Validate_Required_fields()
        Dim sReqMsg As String = String.Empty

        If Len(Trim(Me.txtOldPass.Text)) = 0 Then
            sReqMsg = "Old password is required. " & vbCrLf
        End If

        If Len(Trim(Me.txtNewPass.Text)) = 0 Then
            sReqMsg = sReqMsg & "New password is required. " & vbCrLf
        End If

        If Len(Trim(Me.txtConfPass.Text)) = 0 Then
            sReqMsg = sReqMsg & "Confrim password is required. " & vbCrLf
        End If
        Return sReqMsg
    End Function
    Private Sub Save_Password()
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

            cmd.Parameters.Add("@password", OleDbType.VarChar).Value = objCryp.EncryptData(Me.txtNewPass.Text)
            cmd.Parameters.Add("@user_id", OleDbType.Numeric).Value = iUserID
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Function Validate_Password()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        Dim bValid As Boolean = False

        Try
            objCryp = New Crypt("pogisichris")

            conn = New OleDbConnection(Get_Constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select user_id from users where user_id = " & iUserID & " and [password] = '" & objCryp.EncryptData(Trim(Me.txtOldPass.Text)) & "'"

            dr = cmd.ExecuteReader
            If dr.HasRows Then
                bValid = True
            End If

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try

        Return bValid
    End Function
End Class