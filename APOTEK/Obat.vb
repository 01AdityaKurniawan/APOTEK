Imports System.Data.SqlClient


Public Class Obat
    Dim connectionString As String = "Data Source=ADITYA-PC\ADITSQLSERVER; " &
                "user id=sa; password=123456; Integrated Security=True; " & "database=Apotek"

    Dim dataTable As New DataTable()
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Mengisi ComboBox dengan jenis obat
    End Sub

    Private Sub Obat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        TampilObat()
    End Sub
    Private Sub LoadData()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT * FROM Tabel_Obat"
                Dim command As New SqlCommand(query, connection)
                Dim reader As SqlDataReader = command.ExecuteReader()
                Dim dataTable As New DataTable()
                dataTable.Load(reader)
                DataGridView1.DataSource = dataTable
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim id_Obat As Integer = Integer.Parse(TextBox1.Text)
        Dim nama_Obat As String = (TextBox2.Text)
        Dim harga As Integer = Integer.Parse(TextBox3.Text)
        Dim stok As Decimal = Decimal.Parse(NumericUpDown1.Text)
        Dim jenisObat As String = ComboBox1.Text


        ' Koneksi ke database
        Using conn As New SqlConnection(connectionString)
            conn.Open()

            ' Query SQL untuk menyimpan data penjualan
            Dim query As String = "INSERT INTO Tabel_Obat (ID_Obat, Nama_Obat, Harga, Stok, Jenis_Obat) " &
            "VALUES (@ID_Obat, @Nama_Obat, @Harga, @Stok, @Jenis_Obat)"

            ' Membuat objek SqlCommand dengan parameter
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID_Obat", id_Obat)
                cmd.Parameters.AddWithValue("@Nama_Obat", nama_Obat)
                cmd.Parameters.AddWithValue("@Harga", harga)
                cmd.Parameters.AddWithValue("@Stok", stok)
                cmd.Parameters.AddWithValue("@Jenis_Obat", jenisObat)


                ' Eksekusi perintah SQL
                cmd.ExecuteNonQuery()

                ' Menampilkan pesan sukses
                MessageBox.Show("Data Obat berhasil disimpan.")

            End Using
            conn.Close()
            LoadData()
        End Using
    End Sub

    Sub TampilObat()
        ComboBox1.Items.Add("Sirup")
        ComboBox1.Items.Add("Tablet")
        ComboBox1.Items.Add("Pil")
        ComboBox1.Items.Add("Capsul")
    End Sub

End Class