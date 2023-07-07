Imports System.Data.SqlClient

Public Class LaporanPembelian
    Dim connString As String = "Data Source=ADITYA-PC\ADITSQLSERVER; " &
                "user id=sa; password=123456; Integrated Security=True; " & "database=Apotek"
    Dim conn As SqlConnection

    Private Sub LaporanPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mengatur tanggal awal dan akhir default pada komponen DateTimePicker
        DateTimePickerTanggalAwal.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
        DateTimePickerTanggalAkhir.Value = DateTime.Now
    End Sub

    Private Sub ButtonBuatLaporan_Click(sender As Object, e As EventArgs) Handles ButtonBuatLaporan.Click
        ' Menghubungkan ke database
        conn = New SqlConnection(connString)
        conn.Open()

        ' Membuat perintah SQL untuk mengambil data pembelian
        Dim query As String = "SELECT * FROM Tabel_Pembelian WHERE Tanggal_Pembelian >= @TanggalAwal AND Tanggal_Pembelian <= @TanggalAkhir"
        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@TanggalAwal", DateTimePickerTanggalAwal.Value)
        cmd.Parameters.AddWithValue("@TanggalAkhir", DateTimePickerTanggalAkhir.Value)

        ' Membuat adapter dan dataset
        Dim adapter As New SqlDataAdapter(cmd)
        Dim dataset As New DataSet()

        ' Mengisi dataset dengan data dari database
        adapter.Fill(dataset, "Tabel_Pembelian")

        ' Menutup koneksi ke database
        conn.Close()

        ' Menampilkan data pada DataGridView
        DataGridViewLaporan.DataSource = dataset.Tables("Tabel_Pembelian")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
