<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class transaksi_pembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transaksi_pembelian))
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Txthargaobat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtJumlah = New System.Windows.Forms.NumericUpDown()
        Me.Btnhapus = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvpembelian = New System.Windows.Forms.DataGridView()
        Me.Txtnamaobat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtidpembelian = New System.Windows.Forms.TextBox()
        Me.Btntambah = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txtidobat = New System.Windows.Forms.TextBox()
        Me.Txtidsuplier = New System.Windows.Forms.TextBox()
        Me.Cbxjenisobat = New System.Windows.Forms.ComboBox()
        CType(Me.TxtJumlah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvpembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateTimePicker1.Location = New System.Drawing.Point(908, 279)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(183, 20)
        Me.DateTimePicker1.TabIndex = 42
        '
        'Txthargaobat
        '
        Me.Txthargaobat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txthargaobat.Location = New System.Drawing.Point(908, 154)
        Me.Txthargaobat.Name = "Txthargaobat"
        Me.Txthargaobat.Size = New System.Drawing.Size(183, 20)
        Me.Txthargaobat.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(782, 284)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 15)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Tanggal Pembelian"
        '
        'TxtJumlah
        '
        Me.TxtJumlah.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtJumlah.Location = New System.Drawing.Point(908, 238)
        Me.TxtJumlah.Name = "TxtJumlah"
        Me.TxtJumlah.Size = New System.Drawing.Size(183, 20)
        Me.TxtJumlah.TabIndex = 39
        '
        'Btnhapus
        '
        Me.Btnhapus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btnhapus.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btnhapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnhapus.Location = New System.Drawing.Point(468, 339)
        Me.Btnhapus.Name = "Btnhapus"
        Me.Btnhapus.Size = New System.Drawing.Size(160, 29)
        Me.Btnhapus.TabIndex = 34
        Me.Btnhapus.Text = "Hapus"
        Me.Btnhapus.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(782, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 15)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Jumlah"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(782, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 15)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Harga Obat"
        '
        'dgvpembelian
        '
        Me.dgvpembelian.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvpembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpembelian.Location = New System.Drawing.Point(422, 399)
        Me.dgvpembelian.Name = "dgvpembelian"
        Me.dgvpembelian.Size = New System.Drawing.Size(666, 226)
        Me.dgvpembelian.TabIndex = 31
        '
        'Txtnamaobat
        '
        Me.Txtnamaobat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txtnamaobat.Location = New System.Drawing.Point(507, 279)
        Me.Txtnamaobat.Name = "Txtnamaobat"
        Me.Txtnamaobat.Size = New System.Drawing.Size(183, 20)
        Me.Txtnamaobat.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(422, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Nama Obat"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(782, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 15)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Jenis Obat"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(422, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "ID Pembelian"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Stencil", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(564, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(404, 41)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Transaksi Pembelian"
        '
        'Txtidpembelian
        '
        Me.Txtidpembelian.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txtidpembelian.Location = New System.Drawing.Point(507, 161)
        Me.Txtidpembelian.Name = "Txtidpembelian"
        Me.Txtidpembelian.Size = New System.Drawing.Size(183, 20)
        Me.Txtidpembelian.TabIndex = 29
        '
        'Btntambah
        '
        Me.Btntambah.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btntambah.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btntambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btntambah.Location = New System.Drawing.Point(892, 339)
        Me.Btntambah.Name = "Btntambah"
        Me.Btntambah.Size = New System.Drawing.Size(160, 29)
        Me.Btntambah.TabIndex = 43
        Me.Btntambah.Text = "Tambah"
        Me.Btntambah.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(422, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 15)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "ID Suplier"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(422, 199)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 15)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "ID Obat"
        '
        'Txtidobat
        '
        Me.Txtidobat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txtidobat.Location = New System.Drawing.Point(507, 197)
        Me.Txtidobat.Name = "Txtidobat"
        Me.Txtidobat.Size = New System.Drawing.Size(183, 20)
        Me.Txtidobat.TabIndex = 47
        '
        'Txtidsuplier
        '
        Me.Txtidsuplier.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txtidsuplier.Location = New System.Drawing.Point(507, 243)
        Me.Txtidsuplier.Name = "Txtidsuplier"
        Me.Txtidsuplier.Size = New System.Drawing.Size(183, 20)
        Me.Txtidsuplier.TabIndex = 48
        '
        'Cbxjenisobat
        '
        Me.Cbxjenisobat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cbxjenisobat.FormattingEnabled = True
        Me.Cbxjenisobat.Location = New System.Drawing.Point(908, 193)
        Me.Cbxjenisobat.Name = "Cbxjenisobat"
        Me.Cbxjenisobat.Size = New System.Drawing.Size(183, 21)
        Me.Cbxjenisobat.TabIndex = 49
        '
        'transaksi_pembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1518, 637)
        Me.Controls.Add(Me.Cbxjenisobat)
        Me.Controls.Add(Me.Txtidsuplier)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Txtidobat)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Btntambah)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Txthargaobat)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtJumlah)
        Me.Controls.Add(Me.Btnhapus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvpembelian)
        Me.Controls.Add(Me.Txtnamaobat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txtidpembelian)
        Me.Name = "transaksi_pembelian"
        Me.Text = "transaksi_pembelian"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TxtJumlah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvpembelian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Txthargaobat As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtJumlah As NumericUpDown
    Friend WithEvents Btnhapus As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvpembelian As DataGridView
    Friend WithEvents Txtnamaobat As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Txtidpembelian As TextBox
    Friend WithEvents Btntambah As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Txtidobat As TextBox
    Friend WithEvents Txtidsuplier As TextBox
    Friend WithEvents Cbxjenisobat As ComboBox
End Class
