Imports System.Data.SqlClient
Public Class Form1

  
    
    Private Sub btsend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsend.Click
        Dim query As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim tang As String = DateTime.Now.ToString("YYYY-MM-DD hh:mm:ss")

        tang = DateTimePicker1.Value




        Call bukakoneksi()
        query = "INSERT INTO kendaraan (requestid,namerequestor,dateissue,requestorid)VALUES ('" & tbid.Text & "','" & tbname.Text & "','" & tang & "','" & tbidnum.Text & "')"
        cmd = New SqlCommand(query, conn)
        dr = cmd.ExecuteReader

        Call tutupKoneksi()
        auto()
        LVReq.Clear()
        muncul()



        MsgBox("Send Request by " + tbname.Text + " Berhasil di simpan")

        
    End Sub

    Private Sub auto()
        Dim query As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim uid As String
        Dim number As Integer
        Try
            Call bukakoneksi()
            Dim query_id As String = "SELECT MAX(requestid)+1 AS MXID FROM kendaraan"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader
            dr.Read()

            If dr("MXID") Is DBNull.Value Then
                number = 1
            Else
                uid = CType(dr("MXID"), String)
                number = CType(uid, String)
                number = number

            End If

            dr.Close()
            tbid.Text = number
            Call tutupKoneksi()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
   
    Private Sub muncul()
        Dim cmd As SqlCommand        Dim dr As SqlDataReader        LVReq.View = View.Details        LVReq.Columns.Add("NO", 50)        LVReq.Columns.Add("Name OF Requestor", 100)

        Try            Call bukakoneksi()            Dim query_id As String = "select * from kendaraan"            cmd = New SqlCommand(query_id, conn)            dr = cmd.ExecuteReader            Do While dr.Read                LVReq.Items.Add(dr("requestid"))                LVReq.Items(LVReq.Items.Count - 1).SubItems.Add(dr("namerequestor"))                           Loop            dr.Close()            Call tutupKoneksi()        Catch ex As Exception            MsgBox(ex.ToString)        End Try
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        muncul()

        auto()


    End Sub

   
    
    Private Sub DdToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DdToolStripMenuItem1.Click
        Dim id As String
        Dim cmd As SqlCommand        Dim dr As SqlDataReader

        Try
            id = LVReq.SelectedItems(0).Text

            Call bukakoneksi()
            Dim query As String = "delete from kendaraan where requestid='" + id + "'"            cmd = New SqlCommand(query, conn)            dr = cmd.ExecuteReader
            Call tutupKoneksi()
            dr.Close()
            MsgBox("data berhasil di hapus")
            LVReq.Clear()


            auto()

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

        muncul()
    End Sub

    Private Sub DdToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DdToolStripMenuItem.Click
        Dim Id As String
        Dim cmd As SqlCommand        Dim dr As SqlDataReader

        Try
            Id = LVReq.SelectedItems(0).Text

            Call bukakoneksi()
            Dim query As String = "select * from kendaraan where requestid='" + Id + "'"            cmd = New SqlCommand(query, conn)            dr = cmd.ExecuteReader

            dr.Read()
            tbid.Text = dr("requestid")
            tbname.Text = dr("namerequestor")
            tbid.Text = dr("requestid")
            tbid.Text = dr("requestid")

           

            dr.Close()

            Call tutupKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim query As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
      
        Dim uid As String
        Dim cekStok As Boolean = False
        Try
            Call bukakoneksi()
            query = " Update kendaraan SET namerequestor='" & tbname.Text & "' where requestid='" & tbid.Text & "'"


            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Close()

            MsgBox("Data buku '" + tbname.Text + "' Berhasil Tersimpan")

            Call tutupKoneksi()
            LVReq.Clear()
            muncul()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
