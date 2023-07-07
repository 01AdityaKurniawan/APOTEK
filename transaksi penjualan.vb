Imports System.Data.SqlClient

Public Class transaksi_penjualan

    Sub TampilObat()
        Cbxjenisobat.Items.Add("Sirup")
        Cbxjenisobat.Items.Add("Tablet")
        Cbxjenisobat.Items.Add("Pil")
        Cbxjenisobat.Items.Add("Capsul")
    End Sub

    Public connectionString As String = "Data Source=ADITYA-PC\ADITSQLSERVER; " &
                "user id=sa; password=123456; Integrated Security=True; " & "database=Apotek"

    Dim dataTable As New DataTable()
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles LblIDPenjualan.Click

    End Sub

    Private Sub transaksi_penjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataPenjualan()
        TampilObat()
    End Sub

    Private Sub LoadDataPenjualan()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT * FROM Tabel_Penjualan"
                Dim command As New SqlCommand(query, connection)
                Dim reader As SqlDataReader = command.ExecuteReader()
                Dim dataTable As New DataTable()
                dataTable.Load(reader)
                dgvPenjualan.DataSource = dataTable
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Sub StokObat()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT COUNT(*) FROM Tabel_Obat WHERE ID_Obat = @ID_Obat"
            Dim command As New SqlCommand(query, connection)
            Dim reader As SqlDataReader = command.ExecuteReader()
            Dim count As Integer = CInt(command.ExecuteScalar())
            ' Memasukkan data ke dalam tabel obat
            While reader.Read()
                Dim obatID As Integer = CInt(reader("ID_Obat"))
                command.Parameters.AddWithValue("@ID_Obat", obatID)
            End While
            If count > 0 Then
                ' ID Obat sudah ada dalam tabel Obat, lakukan tindakan yang sesuai
                MessageBox.Show("ID Obat sudah ada dalam tabel Obat.")
            Else
                ' ID Obat belum ada dalam tabel Obat, lanjutkan dengan memasukkan data ke dalam tabel
                ' ...
            End If
            connection.Close()

        End Using
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim idPenjualan As Integer = Integer.Parse(Txtidpenjualan.Text)
        Dim idObat As String = (Txtidobat.Text)
        Dim tanggalPenjualan As Date = DateTimePicker1.Value
        Dim namaObat As String = Txtnamaobat.Text
        Dim jenisObat As String = Cbxjenisobat.Text
        Dim jumlahTotalPembelanjaan As Decimal = Decimal.Parse(NumericUpDown1.Text)
        Dim totalPembayaran As Decimal = Decimal.Parse(s:=Txttotalpembayaran.Text)
        Dim totalKembalian As Decimal = Decimal.Parse(Txttotalkembalian.Text)

        ' Koneksi ke database
        Using conn As New SqlConnection(connectionString)
            conn.Open()

            ' Query SQL untuk menyimpan data penjualan
            Dim query As String = "INSERT INTO Tabel_Penjualan (ID_Penjualan, ID_Obat, Tanggal_Penjualan, Nama_Obat, Jenis_Obat, Total_Pembelanjaan, Total_Pembayaran, Total_Kembalian) " &
            "VALUES (@ID_Penjualan, @ID_Obat, @Tanggal_Penjualan,  @Nama_Obat, @Jenis_Obat, @Total_Pembelanjaan, @Total_Pembayaran, @Total_Kembalian)"

            ' Membuat objek SqlCommand dengan parameter
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID_Penjualan", idPenjualan)
                cmd.Parameters.AddWithValue("@ID_Obat", idObat)
                cmd.Parameters.AddWithValue("@Tanggal_Penjualan", tanggalPenjualan)
                cmd.Parameters.AddWithValue("@Nama_Obat", namaObat)
                cmd.Parameters.AddWithValue("@Jenis_Obat", jenisObat)
                cmd.Parameters.AddWithValue("@Total_Pembelanjaan", jumlahTotalPembelanjaan)
                cmd.Parameters.AddWithValue("@Total_Pembayaran", totalPembayaran)
                cmd.Parameters.AddWithValue("@Total_Kembalian", totalKembalian)

                ' Eksekusi perintah SQL
                cmd.ExecuteNonQuery()

                ' Menampilkan pesan sukses
                MessageBox.Show("Data penjualan berhasil disimpan.")

                ' Mengosongkan input
                ClearInputFields()
            End Using
            conn.Close()
            LoadDataPenjualan()
        End Using
    End Sub

    Private Sub ClearInputFields()
        Txtidpenjualan.Text = ""
        Txtidobat.Text = ""
        DateTimePicker1.Value = DateTime.Now
        Txtnamaobat.Text = ""
        Cbxjenisobat.Text = ""
        NumericUpDown1.Text = ""
        Txttotalpembayaran.Text = ""
        Txttotalkembalian.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim jumlahTotalPembelanjaan As Integer = Integer.Parse(Txttotalpembelanjaan.Text)
        Dim totalPembayaran As Integer = Integer.Parse(Txttotalpembayaran.Text)

        Dim totalKembalian As Integer = totalPembayaran - jumlahTotalPembelanjaan
        Txttotalkembalian.Text = totalKembalian.ToString("N2")
    End Sub

    Private Sub Cbxjenisobat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbxjenisobat.SelectedIndexChanged
        ' Mengisi ComboBox dengan jenis obat

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

        ' Menghitung total pembelanjaan berdasarkan harga obat dan jumlah
        Dim jumlahTotalPembelanjaan As String = (Txttotalpembelanjaan.Text)
        Dim jumlah As Integer

        ' Cek apakah input jumlah valid, jika tidak, set nilai jumlah menjadi 0
        If Integer.TryParse(NumericUpDown1.Text, jumlah) Then
            ' Hitung total pembelanjaan
            Dim totalPembelanjaan As Integer = jumlahTotalPembelanjaan * jumlah

            ' Tampilkan total pembelanjaan pada TextBox Total Pembelanjaan
            Txttotalpembelanjaan.Text = totalPembelanjaan.ToString()
        Else
            Txttotalpembelanjaan.Text = "0"
        End If


    End Sub

    Private Sub dgvPenjualan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPenjualan.CellContentClick

    End Sub
End Class
