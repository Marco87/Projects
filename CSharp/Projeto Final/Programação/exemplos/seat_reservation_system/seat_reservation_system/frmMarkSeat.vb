Imports System.Data
Imports System.Data.OleDb
Public Class frmMarkSeat
    Dim btnSeat As New Button
    Public iSched_ID As Long = 0
    Private Sub frmMarkSeat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Seat No. " & btnSeat.Text
        Me.lblSeatNo.Text = btnSeat.Text

        If btnSeat.Image.Tag = 0 Then
            rbAvailable.Checked = True
        Else
            rbOccupied.Checked = True
        End If
    End Sub
    Public Sub Set_Control(ByRef bSeat As Button)
        btnSeat = bSeat
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim res As New DialogResult
        Dim sMsg As String = String.Empty

        If Me.rbAvailable.Checked Then
            sMsg = "Make seat available?"
        Else
            sMsg = "Make seat occupied?"
        End If
        res = MsgBox(sMsg, MsgBoxStyle.YesNo)
        If res = Windows.Forms.DialogResult.Yes Then
            If Me.rbAvailable.Checked Then
                btnSeat.Image = ImageList1.Images(0)
                btnSeat.Image.Tag = 0
            Else
                btnSeat.Image = ImageList1.Images(1)
                btnSeat.Image.Tag = 1
            End If
            Save_Record(btnSeat.Image.Tag)
        End If

    End Sub
    Private Sub Save_Record(ByVal iTag As Integer)
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim sSQL As String = String.Empty

        Try

            'get connection string declared in the Module1.vb and assing it to conn variable
            conn = New OleDbConnection(Get_Constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sSQL = "UPDATE seats set " & btnSeat.Tag & " = " & iTag & " where sched_id = " & iSched_ID
            cmd.CommandText = sSQL

            cmd.ExecuteNonQuery()
            If Me.rbAvailable.Checked Then
                MsgBox("Seat has been available.")
            Else
                MsgBox("Seat has been occupied.")
            End If

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
