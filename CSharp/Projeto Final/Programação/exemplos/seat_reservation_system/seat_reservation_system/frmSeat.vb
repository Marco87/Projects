Imports System.Data
Imports System.Data.OleDb
Public Class frmSeat
    Public iSchedID As Long = 0
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Is_Exist() = False Then
            Insert_Sched()
        End If
        Load_Record()
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
            cmd.CommandText = "select * from seats where sched_id = " & iSchedID

            dr = cmd.ExecuteReader
            If dr.HasRows Then
                With Me
                    While dr.Read
                        .btn1.Image = ImageList1.Images(dr("seat1"))
                        .btn2.Image = ImageList1.Images(dr("seat2"))
                        .btn3.Image = ImageList1.Images(dr("seat3"))
                        .btn4.Image = ImageList1.Images(dr("seat4"))
                        .btn5.Image = ImageList1.Images(dr("seat5"))
                        .btn6.Image = ImageList1.Images(dr("seat6"))
                        .btn7.Image = ImageList1.Images(dr("seat7"))
                        .btn8.Image = ImageList1.Images(dr("seat8"))
                        .btn9.Image = ImageList1.Images(dr("seat9"))
                        .btn10.Image = ImageList1.Images(dr("seat10"))
                        .btn11.Image = ImageList1.Images(dr("seat11"))
                        .btn12.Image = ImageList1.Images(dr("seat12"))
                        .btn13.Image = ImageList1.Images(dr("seat13"))
                        .btn14.Image = ImageList1.Images(dr("seat14"))
                        .btn15.Image = ImageList1.Images(dr("seat15"))
                        .btn16.Image = ImageList1.Images(dr("seat16"))
                        .btn17.Image = ImageList1.Images(dr("seat17"))
                        .btn18.Image = ImageList1.Images(dr("seat18"))
                        .btn19.Image = ImageList1.Images(dr("seat19"))
                        .btn20.Image = ImageList1.Images(dr("seat20"))
                        .btn21.Image = ImageList1.Images(dr("seat21"))
                        .btn22.Image = ImageList1.Images(dr("seat22"))
                        .btn23.Image = ImageList1.Images(dr("seat23"))
                        .btn24.Image = ImageList1.Images(dr("seat24"))
                        .btn25.Image = ImageList1.Images(dr("seat25"))
                        .btn26.Image = ImageList1.Images(dr("seat26"))
                        .btn27.Image = ImageList1.Images(dr("seat27"))
                        .btn28.Image = ImageList1.Images(dr("seat28"))
                        .btn29.Image = ImageList1.Images(dr("seat29"))
                        .btn30.Image = ImageList1.Images(dr("seat30"))
                        .btn31.Image = ImageList1.Images(dr("seat31"))
                        .btn32.Image = ImageList1.Images(dr("seat32"))
                        .btn33.Image = ImageList1.Images(dr("seat33"))
                        .btn34.Image = ImageList1.Images(dr("seat34"))
                        .btn35.Image = ImageList1.Images(dr("seat35"))
                        .btn36.Image = ImageList1.Images(dr("seat36"))
                        .btn37.Image = ImageList1.Images(dr("seat37"))
                        .btn38.Image = ImageList1.Images(dr("seat38"))
                        .btn39.Image = ImageList1.Images(dr("seat39"))
                        .btn40.Image = ImageList1.Images(dr("seat40"))
                        .btn41.Image = ImageList1.Images(dr("seat41"))
                        .btn42.Image = ImageList1.Images(dr("seat42"))
                        .btn43.Image = ImageList1.Images(dr("seat43"))
                        .btn44.Image = ImageList1.Images(dr("seat44"))
                        .btn45.Image = ImageList1.Images(dr("seat45"))
                        .btn46.Image = ImageList1.Images(dr("seat46"))
                        .btn47.Image = ImageList1.Images(dr("seat47"))
                        .btn48.Image = ImageList1.Images(dr("seat48"))
                        .btn49.Image = ImageList1.Images(dr("seat49"))
                        .btn50.Image = ImageList1.Images(dr("seat50"))
                        .btn51.Image = ImageList1.Images(dr("seat51"))
                        .btn52.Image = ImageList1.Images(dr("seat52"))
                        .btn53.Image = ImageList1.Images(dr("seat53"))
                        .btn54.Image = ImageList1.Images(dr("seat54"))
                        .btn55.Image = ImageList1.Images(dr("seat55"))
                        .btn56.Image = ImageList1.Images(dr("seat56"))
                        .btn57.Image = ImageList1.Images(dr("seat57"))
                        .btn58.Image = ImageList1.Images(dr("seat58"))
                        .btn59.Image = ImageList1.Images(dr("seat59"))
                        .btn60.Image = ImageList1.Images(dr("seat60"))
                        .btn61.Image = ImageList1.Images(dr("seat61"))
                        .btn62.Image = ImageList1.Images(dr("seat62"))
                        .btn63.Image = ImageList1.Images(dr("seat63"))
                        .btn64.Image = ImageList1.Images(dr("seat64"))
                        .btn65.Image = ImageList1.Images(dr("seat65"))
                        .btn66.Image = ImageList1.Images(dr("seat66"))
                        .btn67.Image = ImageList1.Images(dr("seat67"))
                        .btn68.Image = ImageList1.Images(dr("seat68"))
                        .btn69.Image = ImageList1.Images(dr("seat69"))
                        .btn70.Image = ImageList1.Images(dr("seat70"))
                        .btn71.Image = ImageList1.Images(dr("seat71"))
                        .btn72.Image = ImageList1.Images(dr("seat72"))
                        .btn73.Image = ImageList1.Images(dr("seat73"))
                        .btn74.Image = ImageList1.Images(dr("seat74"))
                        .btn75.Image = ImageList1.Images(dr("seat75"))
                        .btn76.Image = ImageList1.Images(dr("seat76"))
                        .btn77.Image = ImageList1.Images(dr("seat77"))
                        .btn78.Image = ImageList1.Images(dr("seat78"))
                        .btn79.Image = ImageList1.Images(dr("seat79"))
                        .btn80.Image = ImageList1.Images(dr("seat80"))
                        .btn81.Image = ImageList1.Images(dr("seat81"))
                        .btn82.Image = ImageList1.Images(dr("seat82"))
                        .btn83.Image = ImageList1.Images(dr("seat83"))
                        .btn84.Image = ImageList1.Images(dr("seat84"))
                        .btn85.Image = ImageList1.Images(dr("seat85"))
                        .btn86.Image = ImageList1.Images(dr("seat86"))
                        .btn87.Image = ImageList1.Images(dr("seat87"))
                        .btn88.Image = ImageList1.Images(dr("seat88"))
                        .btn89.Image = ImageList1.Images(dr("seat89"))
                        .btn90.Image = ImageList1.Images(dr("seat90"))
                        .btn91.Image = ImageList1.Images(dr("seat91"))
                        .btn92.Image = ImageList1.Images(dr("seat92"))
                        .btn93.Image = ImageList1.Images(dr("seat93"))
                        .btn94.Image = ImageList1.Images(dr("seat94"))
                        .btn95.Image = ImageList1.Images(dr("seat95"))
                        .btn96.Image = ImageList1.Images(dr("seat96"))
                        .btn97.Image = ImageList1.Images(dr("seat97"))
                        .btn98.Image = ImageList1.Images(dr("seat98"))
                        .btn99.Image = ImageList1.Images(dr("seat99"))
                        .btn100.Image = ImageList1.Images(dr("seat100"))
                        .btn101.Image = ImageList1.Images(dr("seat101"))
                        .btn102.Image = ImageList1.Images(dr("seat102"))
                        .btn103.Image = ImageList1.Images(dr("seat103"))
                        .btn104.Image = ImageList1.Images(dr("seat104"))
                        .btn105.Image = ImageList1.Images(dr("seat105"))
                        .btn106.Image = ImageList1.Images(dr("seat106"))
                        .btn107.Image = ImageList1.Images(dr("seat107"))
                        .btn108.Image = ImageList1.Images(dr("seat108"))
                        .btn109.Image = ImageList1.Images(dr("seat109"))
                        .btn110.Image = ImageList1.Images(dr("seat110"))
                        .btn111.Image = ImageList1.Images(dr("seat111"))
                        .btn112.Image = ImageList1.Images(dr("seat112"))
                        .btn113.Image = ImageList1.Images(dr("seat113"))
                        .btn114.Image = ImageList1.Images(dr("seat114"))
                        .btn115.Image = ImageList1.Images(dr("seat115"))
                        .btn116.Image = ImageList1.Images(dr("seat116"))
                        .btn117.Image = ImageList1.Images(dr("seat117"))
                        .btn118.Image = ImageList1.Images(dr("seat118"))
                        .btn119.Image = ImageList1.Images(dr("seat119"))
                        .btn120.Image = ImageList1.Images(dr("seat120"))
                        .btn121.Image = ImageList1.Images(dr("seat121"))
                        .btn122.Image = ImageList1.Images(dr("seat122"))
                        .btn123.Image = ImageList1.Images(dr("seat123"))
                        .btn124.Image = ImageList1.Images(dr("seat124"))
                        .btn125.Image = ImageList1.Images(dr("seat125"))
                        .btn126.Image = ImageList1.Images(dr("seat126"))
                        .btn127.Image = ImageList1.Images(dr("seat127"))
                        .btn128.Image = ImageList1.Images(dr("seat128"))
                        .btn129.Image = ImageList1.Images(dr("seat129"))
                        .btn130.Image = ImageList1.Images(dr("seat130"))
                        .btn131.Image = ImageList1.Images(dr("seat131"))
                        .btn132.Image = ImageList1.Images(dr("seat132"))
                        .btn133.Image = ImageList1.Images(dr("seat133"))
                        .btn134.Image = ImageList1.Images(dr("seat134"))
                        .btn135.Image = ImageList1.Images(dr("seat135"))
                        .btn136.Image = ImageList1.Images(dr("seat136"))
                        .btn137.Image = ImageList1.Images(dr("seat137"))
                        .btn138.Image = ImageList1.Images(dr("seat138"))
                        .btn139.Image = ImageList1.Images(dr("seat139"))
                        .btn140.Image = ImageList1.Images(dr("seat140"))
                        .btn141.Image = ImageList1.Images(dr("seat141"))
                        .btn142.Image = ImageList1.Images(dr("seat142"))
                        .btn143.Image = ImageList1.Images(dr("seat143"))
                        .btn144.Image = ImageList1.Images(dr("seat144"))

                        .btn1.Image.Tag = dr("seat1")
                        .btn2.Image.Tag = dr("seat2")
                        .btn3.Image.Tag = dr("seat3")
                        .btn4.Image.Tag = dr("seat4")
                        .btn5.Image.Tag = dr("seat5")
                        .btn6.Image.Tag = dr("seat6")
                        .btn7.Image.Tag = dr("seat7")
                        .btn8.Image.Tag = dr("seat8")
                        .btn9.Image.Tag = dr("seat9")
                        .btn10.Image.Tag = dr("seat10")
                        .btn11.Image.Tag = dr("seat11")
                        .btn12.Image.Tag = dr("seat12")
                        .btn13.Image.Tag = dr("seat13")
                        .btn14.Image.Tag = dr("seat14")
                        .btn15.Image.Tag = dr("seat15")
                        .btn16.Image.Tag = dr("seat16")
                        .btn17.Image.Tag = dr("seat17")
                        .btn18.Image.Tag = dr("seat18")
                        .btn19.Image.Tag = dr("seat19")
                        .btn20.Image.Tag = dr("seat20")
                        .btn21.Image.Tag = dr("seat21")
                        .btn22.Image.Tag = dr("seat22")
                        .btn23.Image.Tag = dr("seat23")
                        .btn24.Image.Tag = dr("seat24")
                        .btn25.Image.Tag = dr("seat25")
                        .btn26.Image.Tag = dr("seat26")
                        .btn27.Image.Tag = dr("seat27")
                        .btn28.Image.Tag = dr("seat28")
                        .btn29.Image.Tag = dr("seat29")
                        .btn30.Image.Tag = dr("seat30")
                        .btn31.Image.Tag = dr("seat31")
                        .btn32.Image.Tag = dr("seat32")
                        .btn33.Image.Tag = dr("seat33")
                        .btn34.Image.Tag = dr("seat34")
                        .btn35.Image.Tag = dr("seat35")
                        .btn36.Image.Tag = dr("seat36")
                        .btn37.Image.Tag = dr("seat37")
                        .btn38.Image.Tag = dr("seat38")
                        .btn39.Image.Tag = dr("seat39")
                        .btn40.Image.Tag = dr("seat40")
                        .btn41.Image.Tag = dr("seat41")
                        .btn42.Image.Tag = dr("seat42")
                        .btn43.Image.Tag = dr("seat43")
                        .btn44.Image.Tag = dr("seat44")
                        .btn45.Image.Tag = dr("seat45")
                        .btn46.Image.Tag = dr("seat46")
                        .btn47.Image.Tag = dr("seat47")
                        .btn48.Image.Tag = dr("seat48")
                        .btn49.Image.Tag = dr("seat49")
                        .btn50.Image.Tag = dr("seat50")
                        .btn51.Image.Tag = dr("seat51")
                        .btn52.Image.Tag = dr("seat52")
                        .btn53.Image.Tag = dr("seat53")
                        .btn54.Image.Tag = dr("seat54")
                        .btn55.Image.Tag = dr("seat55")
                        .btn56.Image.Tag = dr("seat56")
                        .btn57.Image.Tag = dr("seat57")
                        .btn58.Image.Tag = dr("seat58")
                        .btn59.Image.Tag = dr("seat59")
                        .btn60.Image.Tag = dr("seat60")
                        .btn61.Image.Tag = dr("seat61")
                        .btn62.Image.Tag = dr("seat62")
                        .btn63.Image.Tag = dr("seat63")
                        .btn64.Image.Tag = dr("seat64")
                        .btn65.Image.Tag = dr("seat65")
                        .btn66.Image.Tag = dr("seat66")
                        .btn67.Image.Tag = dr("seat67")
                        .btn68.Image.Tag = dr("seat68")
                        .btn69.Image.Tag = dr("seat69")
                        .btn70.Image.Tag = dr("seat70")
                        .btn71.Image.Tag = dr("seat71")
                        .btn72.Image.Tag = dr("seat72")
                        .btn73.Image.Tag = dr("seat73")
                        .btn74.Image.Tag = dr("seat74")
                        .btn75.Image.Tag = dr("seat75")
                        .btn76.Image.Tag = dr("seat76")
                        .btn77.Image.Tag = dr("seat77")
                        .btn78.Image.Tag = dr("seat78")
                        .btn79.Image.Tag = dr("seat79")
                        .btn80.Image.Tag = dr("seat80")
                        .btn81.Image.Tag = dr("seat81")
                        .btn82.Image.Tag = dr("seat82")
                        .btn83.Image.Tag = dr("seat83")
                        .btn84.Image.Tag = dr("seat84")
                        .btn85.Image.Tag = dr("seat85")
                        .btn86.Image.Tag = dr("seat86")
                        .btn87.Image.Tag = dr("seat87")
                        .btn88.Image.Tag = dr("seat88")
                        .btn89.Image.Tag = dr("seat89")
                        .btn90.Image.Tag = dr("seat90")
                        .btn91.Image.Tag = dr("seat91")
                        .btn92.Image.Tag = dr("seat92")
                        .btn93.Image.Tag = dr("seat93")
                        .btn94.Image.Tag = dr("seat94")
                        .btn95.Image.Tag = dr("seat95")
                        .btn96.Image.Tag = dr("seat96")
                        .btn97.Image.Tag = dr("seat97")
                        .btn98.Image.Tag = dr("seat98")
                        .btn99.Image.Tag = dr("seat99")
                        .btn100.Image.Tag = dr("seat100")
                        .btn101.Image.Tag = dr("seat101")
                        .btn102.Image.Tag = dr("seat102")
                        .btn103.Image.Tag = dr("seat103")
                        .btn104.Image.Tag = dr("seat104")
                        .btn105.Image.Tag = dr("seat105")
                        .btn106.Image.Tag = dr("seat106")
                        .btn107.Image.Tag = dr("seat107")
                        .btn108.Image.Tag = dr("seat108")
                        .btn109.Image.Tag = dr("seat109")
                        .btn110.Image.Tag = dr("seat110")
                        .btn111.Image.Tag = dr("seat111")
                        .btn112.Image.Tag = dr("seat112")
                        .btn113.Image.Tag = dr("seat113")
                        .btn114.Image.Tag = dr("seat114")
                        .btn115.Image.Tag = dr("seat115")
                        .btn116.Image.Tag = dr("seat116")
                        .btn117.Image.Tag = dr("seat117")
                        .btn118.Image.Tag = dr("seat118")
                        .btn119.Image.Tag = dr("seat119")
                        .btn120.Image.Tag = dr("seat120")
                        .btn121.Image.Tag = dr("seat121")
                        .btn122.Image.Tag = dr("seat122")
                        .btn123.Image.Tag = dr("seat123")
                        .btn124.Image.Tag = dr("seat124")
                        .btn125.Image.Tag = dr("seat125")
                        .btn126.Image.Tag = dr("seat126")
                        .btn127.Image.Tag = dr("seat127")
                        .btn128.Image.Tag = dr("seat128")
                        .btn129.Image.Tag = dr("seat129")
                        .btn130.Image.Tag = dr("seat130")
                        .btn131.Image.Tag = dr("seat131")
                        .btn132.Image.Tag = dr("seat132")
                        .btn133.Image.Tag = dr("seat133")
                        .btn134.Image.Tag = dr("seat134")
                        .btn135.Image.Tag = dr("seat135")
                        .btn136.Image.Tag = dr("seat136")
                        .btn137.Image.Tag = dr("seat137")
                        .btn138.Image.Tag = dr("seat138")
                        .btn139.Image.Tag = dr("seat139")
                        .btn140.Image.Tag = dr("seat140")
                        .btn141.Image.Tag = dr("seat141")
                        .btn142.Image.Tag = dr("seat142")
                        .btn143.Image.Tag = dr("seat143")
                        .btn144.Image.Tag = dr("seat144")
                    End While
                End With
            End If

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Function Is_Exist()
        Dim bExist As Boolean = False
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader

        Try
            conn = New OleDbConnection(Get_Constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select sched_id from seats where sched_id = " & iSchedID

            dr = cmd.ExecuteReader
            If dr.HasRows Then
                bExist = True
            End If

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
        Return bExist
    End Function
    Private Sub Insert_Sched()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand

        Try

            'get connection string declared in the Module1.vb and assing it to conn variable
            conn = New OleDbConnection(Get_Constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "INSERT INTO seats (sched_id) VALUES(@sched_id)"
            cmd.Parameters.Add("@sched_id", OleDbType.BigInt).Value = iSchedID

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn10.Click, _
        btn11.Click, btn12.Click, btn13.Click, btn14.Click, btn15.Click, btn16.Click, btn17.Click, btn18.Click, btn19.Click, btn20.Click, btn21.Click, btn22.Click, btn23.Click, btn24.Click, btn25.Click, btn26.Click, _
        btn27.Click, btn28.Click, btn29.Click, btn30.Click, btn31.Click, btn32.Click, btn33.Click, btn34.Click, btn35.Click, btn36.Click, btn37.Click, btn38.Click, btn39.Click, btn40.Click, btn41.Click, btn42.Click, _
        btn43.Click, btn44.Click, btn45.Click, btn46.Click, btn47.Click, btn48.Click, btn49.Click, btn50.Click, btn51.Click, btn52.Click, btn53.Click, btn54.Click, btn55.Click, btn56.Click, btn57.Click, btn58.Click, _
        btn59.Click, btn60.Click, btn61.Click, btn62.Click, btn63.Click, btn64.Click, btn65.Click, btn66.Click, btn67.Click, btn68.Click, btn69.Click, btn70.Click, btn71.Click, btn72.Click, btn73.Click, btn74.Click, _
        btn75.Click, btn76.Click, btn77.Click, btn78.Click, btn79.Click, btn80.Click, btn81.Click, btn82.Click, btn83.Click, btn84.Click, btn85.Click, btn86.Click, btn87.Click, btn88.Click, btn89.Click, btn90.Click, _
        btn91.Click, btn92.Click, btn93.Click, btn94.Click, btn95.Click, btn96.Click, btn97.Click, btn98.Click, btn99.Click, btn100.Click, btn101.Click, btn102.Click, btn103.Click, btn104.Click, btn105.Click, btn106.Click, _
        btn107.Click, btn108.Click, btn109.Click, btn110.Click, btn111.Click, btn112.Click, btn113.Click, btn114.Click, btn115.Click, btn116.Click, btn117.Click, btn118.Click, btn119.Click, btn110.Click, btn111.Click, btn112.Click, _
        btn113.Click, btn114.Click, btn115.Click, btn116.Click, btn117.Click, btn118.Click, btn119.Click, btn120.Click, btn121.Click, btn122.Click, btn123.Click, btn124.Click, btn125.Click, btn126.Click, btn127.Click, btn128.Click, _
        btn129.Click, btn130.Click, btn131.Click, btn132.Click, btn133.Click, btn134.Click, btn135.Click, btn136.Click, btn137.Click, btn138.Click, btn139.Click, btn140.Click, btn141.Click, btn142.Click, btn143.Click, btn144.Click

        Dim frm As New frmMarkSeat
        frm.iSched_ID = iSchedID
        frm.Set_Control(sender)
        frm.ShowDialog()
        frm = Nothing
    End Sub
End Class
