Public Class Menu
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Login.ShowDialog()
    End Sub

    Sub Terkunci()
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = True
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Terkunci()
    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TransaksiPembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiPembelianToolStripMenuItem.Click
        sembunyi()
        transaksi_pembelian.TopLevel = False
        Panel1.Controls.Add(transaksi_pembelian)
        transaksi_pembelian.Show()
    End Sub

    Private Sub TransaksiPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiPenjualanToolStripMenuItem.Click
        sembunyi()
        transaksi_penjualan.TopLevel = False
        Panel1.Controls.Add(transaksi_penjualan)
        transaksi_penjualan.Show()

    End Sub

    Private Sub LaporanPembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        sembunyi()
        LaporanPembelian.TopLevel = False
        Panel1.Controls.Add(LaporanPembelian)
        LaporanPembelian.Show()
    End Sub

    Sub sembunyi()
        transaksi_pembelian.Hide()
        transaksi_penjualan.Hide()
        LaporanPembelian.Hide()
        LaporanPenjualan.Hide()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        End
    End Sub

    Private Sub LaporanPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPenjualanToolStripMenuItem.Click
        sembunyi()
        LaporanPenjualan.TopLevel = False
        Panel1.Controls.Add(LaporanPenjualan)
        LaporanPenjualan.Show()
    End Sub

    Private Sub ObatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ObatToolStripMenuItem.Click
        sembunyi()
        Obat.TopLevel = False
        Panel1.Controls.Add(Obat)
        Obat.Show()
    End Sub
End Class