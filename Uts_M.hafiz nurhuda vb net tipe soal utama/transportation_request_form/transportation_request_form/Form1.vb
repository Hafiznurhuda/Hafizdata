Imports System.Data.SqlClient
Public Class Form1

  
    Private Sub apus()
        tbname.Text = ""
        tbdes.Text = ""
        tbidnum.Text = ""
        tbins.Text = ""
        tbphone.Text = ""
        tbunit.Text = ""
        tbac.Text = ""
        cbtrabs.Text = ""
        tbother.Text = ""

    End Sub
    Private Sub btsend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsend.Click
        Dim query As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim tang As String = DateTime.Now.ToString("dd")

        tang = DateTimePicker1.Value




        Call bukakoneksi()
        If cbtrabs.Text = "Other" Then

       
            query = "INSERT INTO kendaraan (requestid,namerequestor,dateissue,requestorid,unit,unitdestination,acregist,transportation,phone,instructuion)VALUES ('" & tbid.Text & "','" & tbname.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & tbidnum.Text & "','" & tbunit.Text & "','" & tbdes.Text & "','" & tbac.Text & "','" & tbother.Text & "','" & tbphone.Text & "','" & tbins.Text & "')"

        Else
            query = "INSERT INTO kendaraan (requestid,namerequestor,dateissue,requestorid,unit,unitdestination,acregist,transportation,phone,instructuion)VALUES ('" & tbid.Text & "','" & tbname.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & tbidnum.Text & "','" & tbunit.Text & "','" & tbdes.Text & "','" & tbac.Text & "','" & cbtrabs.Text & "','" & tbphone.Text & "','" & tbins.Text & "')"
        End If
        cmd = New SqlCommand(query, conn)
        dr = cmd.ExecuteReader

        Call tutupKoneksi()
        apus()

        LVReq.Clear()
        muncul()
        auto()



        MsgBox("Send Request by " + tbname.Text + " Berhasil di simpan")


    End Sub

    Private Sub auto()

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
        Dim cmd As SqlCommand        Dim dr As SqlDataReader        LVReq.View = View.Details        LVReq.Columns.Add("NO", 50)        LVReq.Columns.Add("Name OF Requestor", 100)        LVReq.Columns.Add("Unit From", 100)
        LVReq.Columns.Add("Unit To", 100)
        LVReq.Columns.Add("Request Date", 100)
        LVReq.Columns.Add("Transportation", 100)

        Try            Call bukakoneksi()            Dim query_id As String = "select * from kendaraan"            cmd = New SqlCommand(query_id, conn)            dr = cmd.ExecuteReader            Do While dr.Read                LVReq.Items.Add(dr("requestid"))                LVReq.Items(LVReq.Items.Count - 1).SubItems.Add(dr("namerequestor"))                LVReq.Items(LVReq.Items.Count - 1).SubItems.Add(dr("unit"))                LVReq.Items(LVReq.Items.Count - 1).SubItems.Add(dr("unitdestination"))                LVReq.Items(LVReq.Items.Count - 1).SubItems.Add(dr("dateissue"))                LVReq.Items(LVReq.Items.Count - 1).SubItems.Add(dr("transportation"))                           Loop            dr.Close()            Call tutupKoneksi()        Catch ex As Exception            MsgBox(ex.ToString)        End Try
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        muncul()
        tbid.Visible = False

        Button1.Visible = False
        Btcan.Visible = False

        auto()
        tbother.Visible = False


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
            tbidnum.Text = dr("requestorid")
            tbunit.Text = dr("unit")
            tbdes.Text = dr("unitdestination")
            tbac.Text = dr("acregist")
            tbac.Text = dr("acregist")
            cbtrabs.Text = dr("transportation")
            tbphone.Text = dr("phone")
            tbins.Text = dr("instructuion")
            dr.Close()
            Button1.Visible = True
            Btcan.Visible = True
            btsend.Visible = False

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
            If cbtrabs.Text = "Other" Then
                query = " Update kendaraan SET namerequestor='" & tbname.Text & "',requestorid='" & tbidnum.Text & "',unit='" & tbunit.Text & "',unitdestination='" & tbdes.Text & "',acregist='" & tbac.Text & "',transportation='" & tbother.Text & "',phone='" & tbphone.Text & "',instructuion='" & tbins.Text & "' where requestid='" & tbid.Text & "'"
            Else
                query = " Update kendaraan SET namerequestor='" & tbname.Text & "',requestorid='" & tbidnum.Text & "',unit='" & tbunit.Text & "',unitdestination='" & tbdes.Text & "',acregist='" & tbac.Text & "',transportation='" & cbtrabs.Text & "',phone='" & tbphone.Text & "',instructuion='" & tbins.Text & "' where requestid='" & tbid.Text & "'"
            End If
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Close()

            MsgBox("Data buku '" + tbname.Text + "' Berhasil Tersimpan")

            Call tutupKoneksi()
            LVReq.Clear()
            muncul()
            auto()
            apus()
            btsend.Visible = True
            Button1.Visible = False
            Btcan.Visible = False

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cbtrabs_TextChanged(sender As System.Object, e As System.EventArgs) Handles cbtrabs.TextChanged
        If cbtrabs.Text = "Other" Then
            tbother.Visible = True
        Else
            tbother.Visible = False
        End If
    End Sub

   
    Private Sub Btcan_Click(sender As System.Object, e As System.EventArgs) Handles Btcan.Click
        apus()
        Button1.Visible = False
        Btcan.Visible = False
        btsend.Visible = True
    End Sub
End Class
