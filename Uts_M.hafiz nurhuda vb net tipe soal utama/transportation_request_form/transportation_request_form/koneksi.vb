Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient


Module koneksi

    Public comSQL As New SqlClient.SqlCommand
    Public sql As String
    Public conn As New SqlConnection

    Public str As String = "Data Source=DESKTOP-84E601A;" & _
                            "Initial Catalog=transportasi;" & _
                            "Persist Security Info=True;" & _
                            "UID=ff;PWD=admin"
    Public Sub bukakoneksi()
        If conn.State = ConnectionState.Closed Then

            conn.ConnectionString = str

            Try
                conn.Open()
            Catch ex As Exception
                MsgBox("Koneksi Gagal: " & ex.ToString)
            End Try
        End If
    End Sub

    Public Sub tutupKoneksi()
        If conn.State = ConnectionState.Open Then
            Try
                conn.Close()
            Catch ex As Exception
                MsgBox("Erorr " & ex.ToString)
            End Try
        End If

    End Sub



End Module
