Public Class formUtama

    Sub MenuTerkunci()
        FileToolStripMenuItem.Enabled = True
        FileToolStripMenuItem.Visible = True
        LoginToolStripMenuItem.Enabled = True
        LoginToolStripMenuItem.Visible = True
        LogoutToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Visible = True
        ProsesDataToolStripMenuItem.Enabled = True
        ProsesDataToolStripMenuItem.Visible = True
        CalonMahasiswaBaruToolStripMenuItem.Enabled = True
        CalonMahasiswaBaruToolStripMenuItem.Visible = True
        LaporanToolStripMenuItem.Enabled = True
        LaporanToolStripMenuItem.Visible = True
        DataCalonMahasiswaBaruToolStripMenuItem.Enabled = True
        DataCalonMahasiswaBaruToolStripMenuItem.Visible = True
        KeluarToolStripMenuItem.Enabled = True
        KeluarToolStripMenuItem.Visible = True

    End Sub
    Private Sub formUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mdi As Control
        For Each mdi In Me.Controls
            If TypeOf mdi Is MdiClient Then mdi.BackColor = Me.BackColor
        Next
        Call MenuTerkunci()

    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim keluar As String
        keluar = MsgBox("Apakah Anda ingin keluar dari Aplikasi?", vbQuestion +
vbYesNo, "Konfirmasi")
        If keluar = vbYes Then
            Me.Close()
        ElseIf keluar = vbNo Then
            Exit Sub
        End If

    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        formLogin.MdiParent = Me
        formLogin.Show()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Call MenuTerkunci()
        MsgBox("Anda telah berhasil Logout", MsgBoxStyle.Information, "Informasi")

    End Sub

    Private Sub CalonMahasiswaBaruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalonMahasiswaBaruToolStripMenuItem.Click

        formDaftarCMB.MdiParent = Me
        formDaftarCMB.Show()

    End Sub
End Class
