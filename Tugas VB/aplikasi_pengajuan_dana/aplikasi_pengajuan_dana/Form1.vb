Imports System.Data.SqlClient
Public Class Form1
    Dim cmd_gl As SqlCommand    Dim dr_gl As SqlDataReader
    Dim query_gl As String

    Private Sub BtSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtSave.Click
        Dim query As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        
       
        Call OpenKoneksi()
        Try

            query = "INSERT INTO initabel (id_org,nama_pelaksana,bidang,jml_permintaan,bentukdana,keperluan,tanggal) VALUES ('" & tbid.Text & "','" & TBnama.Text & "','" & Cbbidang.Text & "','" & Tbpermintaan.Text & "','" & Tbbentuk.Text & "','" & TBkeperluan.Text & "','" & DateTimePicker1.Text & "')"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Close()
            LV1.Clear()
            hapus()
            tampil()
            auto()

            MsgBox("Data pengajuan '" + TBnama.Text + "' Berhasil Tersimpan")
            Call CloseKoneksi()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub auto()
        Dim query As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim uid As String
        Dim number As Integer
        Try
            Call OpenKoneksi()
            Dim query_id As String = "SELECT MAX(id_org)+1 AS MXID FROM initabel"
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
            Call CloseKoneksi()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Tbbentuk.Text = "Tunai"
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Tbbentuk.Text = "Cek Bank"
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Tbbentuk.Text = "Giro"
    End Sub

    Private Sub tampil()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader


        LV1.View = View.Details
        LV1.Columns.Add("No", 50)
        LV1.Columns.Add("Nama Pelaksana", 300)
        LV1.Columns.Add("Bidang", 150)
        LV1.Columns.Add("Jumlah Permintaan", 200)
        LV1.Columns.Add("Bentuk Dana", 200)
        LV1.Columns.Add("Keperluan", 200)



        Call OpenKoneksi()
        Dim query_id As String = "select * from initabel"
        cmd = New SqlCommand(query_id, conn)
        dr = cmd.ExecuteReader

        Do While dr.Read
            LV1.Items.Add(dr("id_org"))
            LV1.Items(LV1.Items.Count - 1).SubItems.Add(dr("nama_pelaksana"))
            LV1.Items(LV1.Items.Count - 1).SubItems.Add(dr("bidang"))
            LV1.Items(LV1.Items.Count - 1).SubItems.Add(dr("jml_permintaan"))
            LV1.Items(LV1.Items.Count - 1).SubItems.Add(dr("bentukdana"))
            LV1.Items(LV1.Items.Count - 1).SubItems.Add(dr("keperluan"))



        Loop
        dr.Close()
        Call CloseKoneksi()

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tampil()
        DateTimePicker1.Visible = False
        auto()
        Tbbentuk.Visible = False
        tbid.Visible = False
        btedit.Enabled = False
        


    End Sub

    Private Sub hapus()
        TBnama.Text = ""
        TBkeperluan.Text = ""
        Cbbidang.Text = ""
        Tbpermintaan.Text = ""
        Tbbentuk.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False

    End Sub

  
    
    Private Sub LV1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles LV1.SelectedIndexChanged
        btedit.Enabled = True
    End Sub

    Private Sub btedit_Click(sender As System.Object, e As System.EventArgs) Handles btedit.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim idorg As String


        Try
            idorg = LV1.SelectedItems(0).Text
            Call OpenKoneksi()
            Dim query As String = "select * from initabel where id_org='" + idorg + "'"

            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader

            dr.Read()

            tbid.Text = dr("id_org")
            TBnama.Text = dr("nama_pelaksana")
            Cbbidang.Text = dr("bidang")
            Tbpermintaan.Text = dr("jml_permintaan")
            TBkeperluan.Text = dr("keperluan")
            Tbbentuk.Text = dr("bentukdana")



            If dr("bentukdana").ToString.Trim() = "Tunai" Then
                RadioButton1.Checked = True
            ElseIf dr("bentukdana").ToString.Trim() = "Cek Bank" Then
                RadioButton2.Checked = True
            ElseIf dr("bentukdana").ToString.Trim() = "Giro" Then
                RadioButton3.Checked = True
            End If
            dr.Close()
            Call CloseKoneksi()

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub


    
    Private Sub Btapus_Click(sender As System.Object, e As System.EventArgs) Handles Btapus.Click
        Dim Idorg As String
        Dim cmd As SqlCommand        Dim dr As SqlDataReader

        Try
            Idorg = LV1.SelectedItems(0).Text

            Call OpenKoneksi()
            Dim query As String = "delete from initabel where id_org='" + Idorg + "'"            cmd = New SqlCommand(query, conn)            dr = cmd.ExecuteReader
            Call CloseKoneksi()
            dr.Close()
            MsgBox("data berhasil di hapus")
            LV1.Clear()
            tampil()
            hapus()

            auto()

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub Btupdate_Click(sender As System.Object, e As System.EventArgs) Handles Btupdate.Click

        Try
            Call OpenKoneksi()
            query_gl = "UPDATE initabel SET nama_pelaksana = '" & TBnama.Text & "',bidang ='" & Cbbidang.Text & "',jml_permintaan = '" & Tbpermintaan.Text & "',bentukdana = '" & Tbbentuk.Text & "',keperluan = '" & TBkeperluan.Text & "' WHERE id_org = '" & tbid.Text & "'"
            cmd_gl = New SqlCommand(query_gl, conn)            dr_gl = cmd_gl.ExecuteReader
            dr_gl.Close()
            Call CloseKoneksi()
            hapus()
            LV1.Clear()
            tampil()
            auto()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
