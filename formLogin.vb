Imports System.Data.OleDb

Public Class formLogin
    Private Sub formLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call koneksiDB()

    End Sub

    Private Sub formLogin_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        txtUsername.Focus()

    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.TextChanged

        If e.KeyChar = Chr(13) Then txtPassword.Focus() End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.TextChanged

        If e.KeyChar = Chr(13) Then btnLogin.Focus()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Data login belum lengkap")
            txtUsername.Focus()
            Exit Sub
        Else
            CMD = New OleDbCommand("select * from tbl_user where username='" &
txtUsername.Text & "' and password='" & txtPassword.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                MsgBox("Username atau Password salah !")
                txtUsername.Clear()
                txtPassword.Clear()
                txtUsername.Focus()
            Else
                MsgBox("Anda telah berhasil Login", MsgBoxStyle.Information,
"Informasi")
                Me.Close()
                'status strip
                formUtama.StatusStrip1.Text = RD.Item("Level")
                If formUtama.StatusStrip1.Text = "ADMIN" Then
                    formUtama.FileToolStripMenuItem.Enabled = True
                    formUtama.FileToolStripMenuItem.Visible = True
                    formUtama.LoginToolStripMenuItem.Enabled = False
                    formUtama.LoginToolStripMenuItem.Visible = False
                    formUtama.LogoutToolStripMenuItem.Enabled = True
                    formUtama.LogoutToolStripMenuItem.Visible = True
                    formUtama.ProsesDataToolStripMenuItem.Enabled = True
                    formUtama.ProsesDataToolStripMenuItem.Visible = True
                    formUtama.CalonMahasiswaBaruToolStripMenuItem.Enabled = True
                    formUtama.CalonMahasiswaBaruToolStripMenuItem.Visible = True
                    formUtama.LaporanToolStripMenuItem.Enabled = True
                    formUtama.LaporanToolStripMenuItem.Visible = True
                    formUtama.DataCalonMahasiswaBaruToolStripMenuItem.Enabled = True
                    formUtama.DataCalonMahasiswaBaruToolStripMenuItem.Visible = True
                    formUtama.KeluarToolStripMenuItem.Enabled = False
                    formUtama.KeluarToolStripMenuItem.Visible = False
                ElseIf formUtama.StatusStrip1.Text = "USER" Then
                    formUtama.FileToolStripMenuItem.Enabled = True
                    formUtama.FileToolStripMenuItem.Visible = True
                    formUtama.LoginToolStripMenuItem.Enabled = False
                    formUtama.LoginToolStripMenuItem.Visible = False
                    formUtama.LogoutToolStripMenuItem.Enabled = True
                    formUtama.LogoutToolStripMenuItem.Visible = True
                    formUtama.ProsesDataToolStripMenuItem.Enabled = False
                    formUtama.ProsesDataToolStripMenuItem.Visible = False
                    formUtama.CalonMahasiswaBaruToolStripMenuItem.Enabled = False
                    formUtama.CalonMahasiswaBaruToolStripMenuItem.Visible = False
                    formUtama.LaporanToolStripMenuItem.Enabled = True
                    formUtama.LaporanToolStripMenuItem.Visible = True
                    formUtama.DataCalonMahasiswaBaruToolStripMenuItem.Enabled = True
                    formUtama.DataCalonMahasiswaBaruToolStripMenuItem.Visible = True
                    formUtama.KeluarToolStripMenuItem.Enabled = False
                    formUtama.KeluarToolStripMenuItem.Visible = False
                End If
            End If
        End If
    End Sub
End Class