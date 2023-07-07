<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class transaksi_penjualan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transaksi_penjualan))
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Txtnamaobat = New System.Windows.Forms.TextBox()
        Me.LblTanggalPenjualan = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Cbxjenisobat = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Lbljumlah = New System.Windows.Forms.Label()
        Me.LblNamaObat = New System.Windows.Forms.Label()
        Me.LblJenisObat = New System.Windows.Forms.Label()
        Me.LblIDPenjualan = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtidpenjualan = New System.Windows.Forms.TextBox()
        Me.Lbladmin = New System.Windows.Forms.Label()
        Me.Lbltotalpembelanjaan = New System.Windows.Forms.Label()
        Me.Lbltotalpembayaran = New System.Windows.Forms.Label()
        Me.Lbltotalkembalian = New System.Windows.Forms.Label()
        Me.Txttotalkembalian = New System.Windows.Forms.TextBox()
        Me.Txttotalpembelanjaan = New System.Windows.Forms.TextBox()
        Me.Txttotalpembayaran = New System.Windows.Forms.TextBox()
        Me.Txtadmin = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dgvPenjualan = New System.Windows.Forms.DataGridView()
        Me.LblIDObat = New System.Windows.Forms.Label()
        Me.Txtidobat = New System.Windows.Forms.TextBox()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateTimePicker1.Location = New System.Drawing.Point(517, 225)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(181, 20)
        Me.DateTimePicker1.TabIndex = 61
        '
        'Txtnamaobat
        '
        Me.Txtnamaobat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txtnamaobat.Location = New System.Drawing.Point(518, 271)
        Me.Txtnamaobat.Name = "Txtnamaobat"
        Me.Txtnamaobat.Size = New System.Drawing.Size(181, 20)
        Me.Txtnamaobat.TabIndex = 60
        '
        'LblTanggalPenjualan
        '
        Me.LblTanggalPenjualan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblTanggalPenjualan.AutoSize = True
        Me.LblTanggalPenjualan.BackColor = System.Drawing.Color.Transparent
        Me.LblTanggalPenjualan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTanggalPenjualan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTanggalPenjualan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblTanggalPenjualan.Location = New System.Drawing.Point(372, 231)
        Me.LblTanggalPenjualan.Name = "LblTanggalPenjualan"
        Me.LblTanggalPenjualan.Size = New System.Drawing.Size(115, 15)
        Me.LblTanggalPenjualan.TabIndex = 59
        Me.LblTanggalPenjualan.Text = "Tanggal Penjualan"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NumericUpDown1.Location = New System.Drawing.Point(891, 228)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(181, 20)
        Me.NumericUpDown1.TabIndex = 58
        '
        'Cbxjenisobat
        '
        Me.Cbxjenisobat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cbxjenisobat.FormattingEnabled = True
        Me.Cbxjenisobat.Location = New System.Drawing.Point(518, 307)
        Me.Cbxjenisobat.Name = "Cbxjenisobat"
        Me.Cbxjenisobat.Size = New System.Drawing.Size(181, 21)
        Me.Cbxjenisobat.TabIndex = 57
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(458, 422)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(585, 38)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Lbljumlah
        '
        Me.Lbljumlah.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbljumlah.AutoSize = True
        Me.Lbljumlah.BackColor = System.Drawing.Color.Transparent
        Me.Lbljumlah.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbljumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbljumlah.Location = New System.Drawing.Point(754, 231)
        Me.Lbljumlah.Name = "Lbljumlah"
        Me.Lbljumlah.Size = New System.Drawing.Size(48, 15)
        Me.Lbljumlah.TabIndex = 52
        Me.Lbljumlah.Text = "Jumlah"
        '
        'LblNamaObat
        '
        Me.LblNamaObat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblNamaObat.AutoSize = True
        Me.LblNamaObat.BackColor = System.Drawing.Color.Transparent
        Me.LblNamaObat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNamaObat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamaObat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblNamaObat.Location = New System.Drawing.Point(373, 276)
        Me.LblNamaObat.Name = "LblNamaObat"
        Me.LblNamaObat.Size = New System.Drawing.Size(72, 15)
        Me.LblNamaObat.TabIndex = 47
        Me.LblNamaObat.Text = "Nama Obat"
        '
        'LblJenisObat
        '
        Me.LblJenisObat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblJenisObat.AutoSize = True
        Me.LblJenisObat.BackColor = System.Drawing.Color.Transparent
        Me.LblJenisObat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblJenisObat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJenisObat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblJenisObat.Location = New System.Drawing.Point(373, 310)
        Me.LblJenisObat.Name = "LblJenisObat"
        Me.LblJenisObat.Size = New System.Drawing.Size(69, 15)
        Me.LblJenisObat.TabIndex = 46
        Me.LblJenisObat.Text = "Jenis Obat"
        '
        'LblIDPenjualan
        '
        Me.LblIDPenjualan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblIDPenjualan.AutoSize = True
        Me.LblIDPenjualan.BackColor = System.Drawing.Color.Transparent
        Me.LblIDPenjualan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblIDPenjualan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIDPenjualan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblIDPenjualan.Location = New System.Drawing.Point(372, 157)
        Me.LblIDPenjualan.Name = "LblIDPenjualan"
        Me.LblIDPenjualan.Size = New System.Drawing.Size(82, 15)
        Me.LblIDPenjualan.TabIndex = 45
        Me.LblIDPenjualan.Text = "ID Penjualan"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Stencil", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(517, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(421, 42)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Transaksi Penjualan"
        '
        'Txtidpenjualan
        '
        Me.Txtidpenjualan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txtidpenjualan.Location = New System.Drawing.Point(517, 153)
        Me.Txtidpenjualan.Name = "Txtidpenjualan"
        Me.Txtidpenjualan.Size = New System.Drawing.Size(181, 20)
        Me.Txtidpenjualan.TabIndex = 48
        '
        'Lbladmin
        '
        Me.Lbladmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbladmin.AutoSize = True
        Me.Lbladmin.BackColor = System.Drawing.Color.Transparent
        Me.Lbladmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbladmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbladmin.Location = New System.Drawing.Point(754, 298)
        Me.Lbladmin.Name = "Lbladmin"
        Me.Lbladmin.Size = New System.Drawing.Size(43, 15)
        Me.Lbladmin.TabIndex = 62
        Me.Lbladmin.Text = "Admin"
        '
        'Lbltotalpembelanjaan
        '
        Me.Lbltotalpembelanjaan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbltotalpembelanjaan.AutoSize = True
        Me.Lbltotalpembelanjaan.BackColor = System.Drawing.Color.Transparent
        Me.Lbltotalpembelanjaan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbltotalpembelanjaan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltotalpembelanjaan.Location = New System.Drawing.Point(754, 158)
        Me.Lbltotalpembelanjaan.Name = "Lbltotalpembelanjaan"
        Me.Lbltotalpembelanjaan.Size = New System.Drawing.Size(121, 15)
        Me.Lbltotalpembelanjaan.TabIndex = 63
        Me.Lbltotalpembelanjaan.Text = "Total Pembelanjaan"
        '
        'Lbltotalpembayaran
        '
        Me.Lbltotalpembayaran.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbltotalpembayaran.AutoSize = True
        Me.Lbltotalpembayaran.BackColor = System.Drawing.Color.Transparent
        Me.Lbltotalpembayaran.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbltotalpembayaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltotalpembayaran.Location = New System.Drawing.Point(754, 195)
        Me.Lbltotalpembayaran.Name = "Lbltotalpembayaran"
        Me.Lbltotalpembayaran.Size = New System.Drawing.Size(111, 15)
        Me.Lbltotalpembayaran.TabIndex = 64
        Me.Lbltotalpembayaran.Text = "Total Pembayaran"
        '
        'Lbltotalkembalian
        '
        Me.Lbltotalkembalian.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbltotalkembalian.AutoSize = True
        Me.Lbltotalkembalian.BackColor = System.Drawing.Color.Transparent
        Me.Lbltotalkembalian.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbltotalkembalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltotalkembalian.Location = New System.Drawing.Point(754, 264)
        Me.Lbltotalkembalian.Name = "Lbltotalkembalian"
        Me.Lbltotalkembalian.Size = New System.Drawing.Size(100, 15)
        Me.Lbltotalkembalian.TabIndex = 65
        Me.Lbltotalkembalian.Text = "Total Kembalian"
        '
        'Txttotalkembalian
        '
        Me.Txttotalkembalian.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txttotalkembalian.Location = New System.Drawing.Point(891, 262)
        Me.Txttotalkembalian.Name = "Txttotalkembalian"
        Me.Txttotalkembalian.Size = New System.Drawing.Size(181, 20)
        Me.Txttotalkembalian.TabIndex = 66
        '
        'Txttotalpembelanjaan
        '
        Me.Txttotalpembelanjaan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txttotalpembelanjaan.Location = New System.Drawing.Point(891, 151)
        Me.Txttotalpembelanjaan.Name = "Txttotalpembelanjaan"
        Me.Txttotalpembelanjaan.Size = New System.Drawing.Size(181, 20)
        Me.Txttotalpembelanjaan.TabIndex = 67
        '
        'Txttotalpembayaran
        '
        Me.Txttotalpembayaran.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txttotalpembayaran.Location = New System.Drawing.Point(891, 189)
        Me.Txttotalpembayaran.Name = "Txttotalpembayaran"
        Me.Txttotalpembayaran.Size = New System.Drawing.Size(181, 20)
        Me.Txttotalpembayaran.TabIndex = 68
        '
        'Txtadmin
        '
        Me.Txtadmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txtadmin.Location = New System.Drawing.Point(891, 300)
        Me.Txtadmin.Name = "Txtadmin"
        Me.Txtadmin.Size = New System.Drawing.Size(181, 20)
        Me.Txtadmin.TabIndex = 69
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1088, 255)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(63, 36)
        Me.Button2.TabIndex = 70
        Me.Button2.Text = "Hitung"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'dgvPenjualan
        '
        Me.dgvPenjualan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvPenjualan.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgvPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPenjualan.Location = New System.Drawing.Point(458, 475)
        Me.dgvPenjualan.Name = "dgvPenjualan"
        Me.dgvPenjualan.Size = New System.Drawing.Size(585, 167)
        Me.dgvPenjualan.TabIndex = 71
        '
        'LblIDObat
        '
        Me.LblIDObat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblIDObat.AutoSize = True
        Me.LblIDObat.BackColor = System.Drawing.Color.Transparent
        Me.LblIDObat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblIDObat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIDObat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblIDObat.Location = New System.Drawing.Point(373, 194)
        Me.LblIDObat.Name = "LblIDObat"
        Me.LblIDObat.Size = New System.Drawing.Size(53, 15)
        Me.LblIDObat.TabIndex = 72
        Me.LblIDObat.Text = "ID Obat"
        '
        'Txtidobat
        '
        Me.Txtidobat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txtidobat.Location = New System.Drawing.Point(518, 190)
        Me.Txtidobat.Name = "Txtidobat"
        Me.Txtidobat.Size = New System.Drawing.Size(181, 20)
        Me.Txtidobat.TabIndex = 73
        '
        'transaksi_penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1513, 640)
        Me.Controls.Add(Me.LblIDObat)
        Me.Controls.Add(Me.Txtidobat)
        Me.Controls.Add(Me.dgvPenjualan)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Txtadmin)
        Me.Controls.Add(Me.Txttotalpembayaran)
        Me.Controls.Add(Me.Txttotalpembelanjaan)
        Me.Controls.Add(Me.Txttotalkembalian)
        Me.Controls.Add(Me.Lbltotalkembalian)
        Me.Controls.Add(Me.Lbltotalpembayaran)
        Me.Controls.Add(Me.Lbltotalpembelanjaan)
        Me.Controls.Add(Me.Lbladmin)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Txtnamaobat)
        Me.Controls.Add(Me.LblTanggalPenjualan)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Cbxjenisobat)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Lbljumlah)
        Me.Controls.Add(Me.LblNamaObat)
        Me.Controls.Add(Me.LblJenisObat)
        Me.Controls.Add(Me.LblIDPenjualan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txtidpenjualan)
        Me.Name = "transaksi_penjualan"
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Txtnamaobat As TextBox
    Friend WithEvents LblTanggalPenjualan As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Cbxjenisobat As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Lbljumlah As Label
    Friend WithEvents LblNamaObat As Label
    Friend WithEvents LblJenisObat As Label
    Friend WithEvents LblIDPenjualan As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Txtidpenjualan As TextBox
    Friend WithEvents Lbladmin As Label
    Friend WithEvents Lbltotalpembelanjaan As Label
    Friend WithEvents Lbltotalpembayaran As Label
    Friend WithEvents Lbltotalkembalian As Label
    Friend WithEvents Txttotalkembalian As TextBox
    Friend WithEvents Txttotalpembelanjaan As TextBox
    Friend WithEvents Txttotalpembayaran As TextBox
    Friend WithEvents Txtadmin As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents dgvPenjualan As DataGridView
    Friend WithEvents LblIDObat As Label
    Friend WithEvents Txtidobat As TextBox
End Class
