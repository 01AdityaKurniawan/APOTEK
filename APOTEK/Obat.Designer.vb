<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Obat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Obat))
        Me.LblObat = New System.Windows.Forms.Label()
        Me.Lblnama_obat = New System.Windows.Forms.Label()
        Me.Lblharga = New System.Windows.Forms.Label()
        Me.Lblstok = New System.Windows.Forms.Label()
        Me.LblJenisobat = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnTambah = New System.Windows.Forms.Button()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblObat
        '
        Me.LblObat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblObat.AutoSize = True
        Me.LblObat.Location = New System.Drawing.Point(63, 67)
        Me.LblObat.Name = "LblObat"
        Me.LblObat.Size = New System.Drawing.Size(44, 13)
        Me.LblObat.TabIndex = 0
        Me.LblObat.Text = "ID Obat"
        '
        'Lblnama_obat
        '
        Me.Lblnama_obat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lblnama_obat.AutoSize = True
        Me.Lblnama_obat.Location = New System.Drawing.Point(63, 109)
        Me.Lblnama_obat.Name = "Lblnama_obat"
        Me.Lblnama_obat.Size = New System.Drawing.Size(61, 13)
        Me.Lblnama_obat.TabIndex = 1
        Me.Lblnama_obat.Text = "Nama Obat"
        '
        'Lblharga
        '
        Me.Lblharga.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lblharga.AutoSize = True
        Me.Lblharga.Location = New System.Drawing.Point(63, 155)
        Me.Lblharga.Name = "Lblharga"
        Me.Lblharga.Size = New System.Drawing.Size(36, 13)
        Me.Lblharga.TabIndex = 2
        Me.Lblharga.Text = "Harga"
        '
        'Lblstok
        '
        Me.Lblstok.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lblstok.AutoSize = True
        Me.Lblstok.Location = New System.Drawing.Point(63, 200)
        Me.Lblstok.Name = "Lblstok"
        Me.Lblstok.Size = New System.Drawing.Size(29, 13)
        Me.Lblstok.TabIndex = 3
        Me.Lblstok.Text = "Stok"
        '
        'LblJenisobat
        '
        Me.LblJenisobat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblJenisobat.AutoSize = True
        Me.LblJenisobat.Location = New System.Drawing.Point(63, 243)
        Me.LblJenisobat.Name = "LblJenisobat"
        Me.LblJenisobat.Size = New System.Drawing.Size(57, 13)
        Me.LblJenisobat.TabIndex = 4
        Me.LblJenisobat.Text = "Jenis Obat"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Stencil", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(243, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 41)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "STOK OBAT"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.Location = New System.Drawing.Point(216, 67)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(240, 20)
        Me.TextBox1.TabIndex = 27
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2.Location = New System.Drawing.Point(216, 106)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(240, 20)
        Me.TextBox2.TabIndex = 28
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox3.Location = New System.Drawing.Point(216, 148)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(240, 20)
        Me.TextBox3.TabIndex = 29
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NumericUpDown1.Location = New System.Drawing.Point(216, 198)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(239, 20)
        Me.NumericUpDown1.TabIndex = 30
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(216, 240)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(240, 21)
        Me.ComboBox1.TabIndex = 31
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(66, 373)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(554, 204)
        Me.DataGridView1.TabIndex = 32
        '
        'BtnTambah
        '
        Me.BtnTambah.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnTambah.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnTambah.Location = New System.Drawing.Point(216, 300)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(142, 23)
        Me.BtnTambah.TabIndex = 33
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'Obat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(743, 592)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblJenisobat)
        Me.Controls.Add(Me.Lblstok)
        Me.Controls.Add(Me.Lblharga)
        Me.Controls.Add(Me.Lblnama_obat)
        Me.Controls.Add(Me.LblObat)
        Me.Name = "Obat"
        Me.Text = "Obat"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblObat As Label
    Friend WithEvents Lblnama_obat As Label
    Friend WithEvents Lblharga As Label
    Friend WithEvents Lblstok As Label
    Friend WithEvents LblJenisobat As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnTambah As Button
End Class
