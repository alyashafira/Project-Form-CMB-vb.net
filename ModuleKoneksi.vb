Imports System.Data.OleDb
Module ModuleKoneksi
    Public CONN As OleDbConnection
    Public CMD As OleDbCommand
    Public DS As DataSet
    Public DA As OleDbDataAdapter
    Public RD As OleDbDataReader
    Public lokasiDB As String
    Public Sub koneksiDB()

        'area untuk data Sourcenya (data base)
        lokasiDB = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ASUS\Documents\Visual Studio 2015\crud-datamahasiswa.accdb"

        CONN = New OleDbConnection(lokasiDB)
        Try
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
                'MsgBox("Koneksi ke database berhasil", MsgBoxStyle.Information, "Informasi")
            Else
                MsgBox("Koneksi gagal")
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

End Module
