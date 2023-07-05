Imports System.Data.SqlClient

Public Class transaksi_pembelian
    Public connectionString As String = "Data Source=ADITYA-PC\ADITSQLSERVER; " &
                "user id=sa; password=123456; Integrated Security=True; " & "database=Apotek"
    Dim connection As SqlConnection
    Dim command As SqlCommand
    Dim adapter As SqlDataAdapter
    Dim dataTable As DataTable

    Sub TampilObat()
        Cbxjenisobat.Items.Add("Sirup")
        Cbxjenisobat.Items.Add("Tablet")
        Cbxjenisobat.Items.Add("Pil")
        Cbxjenisobat.Items.Add("Capsul")
    End Sub


    Private Sub transaksi_pembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'connection.Open()
        LoadData()
        TampilObat()
        start()
    End Sub

    Private Sub LoadData()
        Dim query As String = "SELECT * FROM DataPembelian"
        command = New SqlCommand(query, connection)
        adapter = New SqlDataAdapter(command)
        dataTable = New DataTable()
        'adapter.Fill(dataTable)
        dgvpembelian.DataSource = dataTable
    End Sub
    Sub start()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT * FROM Tabel_Pembelian"
                Dim command As New SqlCommand(query, connection)
                Dim reader As SqlDataReader = command.ExecuteReader()
                Dim dataTable As New DataTable()
                dataTable.Load(reader)
                dgvpembelian.DataSource = dataTable
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub
    Private Sub ClearFields()
        Txtidpembelian.Clear()
        Txtidobat.Clear()
        Txtidsuplier.Clear()
        Txtnamaobat.Clear()
        Txthargaobat.Clear()
        'TextBoxJenisObat.Clear()
        'TxtJumlah.Clear()
        'DateTimePicker1.Clear()
    End Sub



    Private Sub Btnhapus_Click(sender As Object, e As EventArgs) Handles Btnhapus.Click
        ' Koneksi ke database
        Using conn As New SqlConnection(connectionString)
            conn.Open()

            ' Query SQL untuk menghapus data pembelian
            Dim query As String = "DELETE FROM Tabel_Pembelian WHERE ID_Pembelian = @IdPembelian"

            ' Membuat objek SqlCommand dengan parameter
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@IdPembelian", Txtidpembelian.Text)

                ' Eksekusi perintah SQL
                cmd.ExecuteNonQuery()

                ' Menampilkan pesan sukses
                MessageBox.Show("Data pembelian berhasil dihapus.")

                ' Mengosongkan input
                ClearInputFields()

                ' Refresh DataGridView
                RefreshDataGridView()
            End Using
        End Using
    End Sub

    Private Sub LoadDataPembelian()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT * FROM Tabel_Pembelian"
                Dim command As New SqlCommand(query, connection)
                Dim reader As SqlDataReader = command.ExecuteReader()
                Dim dataTable As New DataTable()
                dataTable.Load(reader)
                dgvpembelian.DataSource = dataTable
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub



    Private Sub RefreshDataGridView()
        ' Koneksi ke database
        Using conn As New SqlConnection(connectionString)
            conn.Open()

            ' Query SQL untuk mengambil semua data pembelian
            Dim query As String = "SELECT * FROM Tabel_Pembelian"

            ' Membuat objek SqlCommand
            Using cmd As New SqlCommand(query, conn)
                ' Membuat objek DataTable untuk menyimpan hasil query
                dataTable.Clear()
                dataTable.Load(cmd.ExecuteReader())

                ' Menghubungkan DataTable dengan DataGridView
                dgvpembelian.DataSource = dataTable
            End Using
        End Using
    End Sub


    Private Function conn() As SqlConnection
        Throw New NotImplementedException()
    End Function

    Private Sub Btntambah_Click(sender As Object, e As EventArgs) Handles Btntambah.Click
        Dim idPembelian As String = (Txtidpembelian.Text)
        Dim idObat As String = (Txtidobat.Text)
        Dim idsuplier As String = (Txtidobat.Text)
        Dim namaObat As String = Txtnamaobat.Text
        Dim HargaObat As String = (Txthargaobat.Text)
        Dim jenisObat As String = Cbxjenisobat.Text
        Dim jumlah As String = (TxtJumlah.Text)
        Dim tanggalPembelian As Date = DateTimePicker1.Value
        Dim jumlahhargaObat As Integer = Integer.Parse(Txthargaobat.Text)
        Txthargaobat.Text = jumlahhargaObat.ToString("N2")




        ' Cek apakah input jumlah valid, jika tidak, set nilai jumlah menjadi 0
        If Integer.TryParse(TxtJumlah.Text, jumlah) Then
            ' Hitung total pembelanjaan
            jumlahhargaObat = HargaObat * jumlah

            ' Tampilkan total pembelanjaan pada TextBox Total Pembelanjaan
            Txthargaobat.Text = jumlahhargaObat.ToString()
        Else
            Txthargaobat.Text = "0"
        End If

        ' Koneksi ke database
        Using conn As New SqlConnection(connectionString)
            conn.Open()

            ' Query SQL untuk menyimpan data pembelian
            Dim query As String = "INSERT INTO Tabel_Pembelian (ID_Pembelian, ID_Obat, ID_Suplier, Nama_Obat, Harga_Obat, Jenis_Obat, Jumlah, Tanggal_Pembelian, Total_Harga) " &
            "VALUES (@ID_Pembelian, @ID_Obat,  @ID_Suplier, @Nama_Obat, @Harga_Obat, @Jenis_Obat, @Jumlah, @Tanggal_Pembelian, @Total_Harga)"

            ' Membuat objek SqlCommand dengan parameter
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID_Pembelian", idPembelian)
                cmd.Parameters.AddWithValue("@ID_Obat", idObat)
                cmd.Parameters.AddWithValue("@ID_Suplier", idsuplier)
                cmd.Parameters.AddWithValue("@Nama_Obat", namaObat)
                cmd.Parameters.AddWithValue("@Harga_Obat", HargaObat)
                cmd.Parameters.AddWithValue("@Jenis_Obat", jenisObat)
                cmd.Parameters.AddWithValue("@Jumlah", jumlah)
                cmd.Parameters.AddWithValue("@Tanggal_Pembelian", tanggalPembelian)
                cmd.Parameters.AddWithValue("@Total_Harga", jumlahhargaObat)
                ' Eksekusi perintah SQL
                cmd.ExecuteNonQuery()

                ' Menampilkan pesan sukses
                MessageBox.Show("Data pembelian berhasil disimpan.")

                ' Mengosongkan input
                ClearInputFields()
            End Using
            conn.Close()
            LoadDataPembelian()
        End Using
    End Sub

    Private Sub ClearInputFields()
        Txtidpembelian.Text = ""
        Txtidobat.Text = ""
        DateTimePicker1.Value = DateTime.Now
        Txtnamaobat.Text = ""
        Cbxjenisobat.Text = ""

    End Sub

    Private Sub Cbxjenisobat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbxjenisobat.SelectedIndexChanged

    End Sub

    Private Sub TxtJumlah_ValueChanged(sender As Object, e As EventArgs) Handles TxtJumlah.ValueChanged
        ' Menghitung total pembelanjaan berdasarkan harga obat dan jumlah

    End Sub


    Private Sub dgvpembelian_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvpembelian.CellClick
        Dim njir As String
        If e.RowIndex Then
            njir = dgvpembelian.Rows(e.RowIndex).Cells(0).Value.ToString()
            Txtidpembelian.Text = njir
        End If
    End Sub

    Private Sub dgvpembelian_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvpembelian.CellContentClick

    End Sub
End Class