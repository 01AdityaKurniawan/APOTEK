<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanPenjualan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LaporanPenjualan))
        Me.DateTimePickerTanggalAwal = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerTanggalAkhir = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonBuatLaporan = New System.Windows.Forms.Button()
        Me.DataGridViewLaporan = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePickerTanggalAwal
        '
        Me.DateTimePickerTanggalAwal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateTimePickerTanggalAwal.Location = New System.Drawing.Point(427, 223)
        Me.DateTimePickerTanggalAwal.Name = "DateTimePickerTanggalAwal"
        Me.DateTimePickerTanggalAwal.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerTanggalAwal.TabIndex = 0
        '
        'DateTimePickerTanggalAkhir
        '
        Me.DateTimePickerTanggalAkhir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateTimePickerTanggalAkhir.Location = New System.Drawing.Point(859, 223)
        Me.DateTimePickerTanggalAkhir.Name = "DateTimePickerTanggalAkhir"
        Me.DateTimePickerTanggalAkhir.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerTanggalAkhir.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(729, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 2
        '
        'ButtonBuatLaporan
        '
        Me.ButtonBuatLaporan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonBuatLaporan.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonBuatLaporan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBuatLaporan.Location = New System.Drawing.Point(690, 263)
        Me.ButtonBuatLaporan.Name = "ButtonBuatLaporan"
        Me.ButtonBuatLaporan.Size = New System.Drawing.Size(106, 23)
        Me.ButtonBuatLaporan.TabIndex = 3
        Me.ButtonBuatLaporan.Text = "Buat Laporan"
        Me.ButtonBuatLaporan.UseVisualStyleBackColor = False
        '
        'DataGridViewLaporan
        '
        Me.DataGridViewLaporan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridViewLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewLaporan.Location = New System.Drawing.Point(412, 353)
        Me.DataGridViewLaporan.Name = "DataGridViewLaporan"
        Me.DataGridViewLaporan.Size = New System.Drawing.Size(688, 180)
        Me.DataGridViewLaporan.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Stencil", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(580, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(385, 42)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Laporan Penjualan"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(424, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tanggal Awal"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(856, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tanggal Akhir"
        '
        'LaporanPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1521, 641)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridViewLaporan)
        Me.Controls.Add(Me.ButtonBuatLaporan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePickerTanggalAkhir)
        Me.Controls.Add(Me.DateTimePickerTanggalAwal)
        Me.Name = "LaporanPenjualan"
        Me.Text = "Laporan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridViewLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePickerTanggalAwal As DateTimePicker
    Friend WithEvents DateTimePickerTanggalAkhir As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonBuatLaporan As Button
    Friend WithEvents DataGridViewLaporan As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
