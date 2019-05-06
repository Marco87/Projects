Imports System.Data
Imports System.Data.OleDb
Public Class frmLogin
    Dim objCryp As Crypt

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If Validate_User() Then
            strUserLvl = GetUserLevel()
            strUser = Trim(Me.txtUserName.Text).ToLower
            Dim frm As New frmDashBoard
            Me.Hide()
            frm.ShowDialog()

        Else
            MsgBox("Wrong password or user name.")
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Function Validate_User()
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
            cmd.CommandText = "select user_id from users where [user_name] = '" & Me.txtUserName.Text & "' and [password] = '" & objCryp.EncryptData(Trim(Me.txtPassword.Text)) & "'"

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

    Function GetUserLevel()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        Dim bUserLvl As String = String.Empty

        Try
            objCryp = New Crypt("pogisichris")

            conn = New OleDbConnection(Get_Constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select user_id, [user_level] from users where [user_name] = '" & Me.txtUserName.Text & "'"

            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    bUserLvl = dr("user_level")
                End While
            End If

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try

        Return bUserLvl.ToLower
    End Function
End Class
