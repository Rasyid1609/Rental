<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksi
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
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.txt_totalbiaya = New System.Windows.Forms.TextBox()
        Me.btn_proses = New System.Windows.Forms.Button()
        Me.ListViewKoleksi = New System.Windows.Forms.ListView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_keluarlist = New System.Windows.Forms.Button()
        Me.btn_masuklist = New System.Windows.Forms.Button()
        Me.PBfoto = New System.Windows.Forms.PictureBox()
        Me.txt_judul = New System.Windows.Forms.TextBox()
        Me.txt_idkoleksi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.txt_idanggota = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_tanggal = New System.Windows.Forms.TextBox()
        Me.txt_idtransaksi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PBfoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(393, 117)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(112, 29)
        Me.btn_clear.TabIndex = 17
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'txt_totalbiaya
        '
        Me.txt_totalbiaya.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalbiaya.Location = New System.Drawing.Point(578, 466)
        Me.txt_totalbiaya.Name = "txt_totalbiaya"
        Me.txt_totalbiaya.ReadOnly = True
        Me.txt_totalbiaya.Size = New System.Drawing.Size(187, 35)
        Me.txt_totalbiaya.TabIndex = 17
        '
        'btn_proses
        '
        Me.btn_proses.Location = New System.Drawing.Point(275, 117)
        Me.btn_proses.Name = "btn_proses"
        Me.btn_proses.Size = New System.Drawing.Size(112, 29)
        Me.btn_proses.TabIndex = 16
        Me.btn_proses.Text = "Proses"
        Me.btn_proses.UseVisualStyleBackColor = True
        '
        'ListViewKoleksi
        '
        Me.ListViewKoleksi.CheckBoxes = True
        Me.ListViewKoleksi.GridLines = True
        Me.ListViewKoleksi.Location = New System.Drawing.Point(38, 281)
        Me.ListViewKoleksi.Name = "ListViewKoleksi"
        Me.ListViewKoleksi.Size = New System.Drawing.Size(727, 179)
        Me.ListViewKoleksi.TabIndex = 15
        Me.ListViewKoleksi.UseCompatibleStateImageBehavior = False
        Me.ListViewKoleksi.View = System.Windows.Forms.View.Details
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_clear)
        Me.GroupBox1.Controls.Add(Me.btn_proses)
        Me.GroupBox1.Controls.Add(Me.btn_keluarlist)
        Me.GroupBox1.Controls.Add(Me.btn_masuklist)
        Me.GroupBox1.Controls.Add(Me.PBfoto)
        Me.GroupBox1.Controls.Add(Me.txt_judul)
        Me.GroupBox1.Controls.Add(Me.txt_idkoleksi)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_nama)
        Me.GroupBox1.Controls.Add(Me.txt_idanggota)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(38, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(727, 157)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Peminjaman"
        '
        'btn_keluarlist
        '
        Me.btn_keluarlist.Location = New System.Drawing.Point(157, 117)
        Me.btn_keluarlist.Name = "btn_keluarlist"
        Me.btn_keluarlist.Size = New System.Drawing.Size(112, 29)
        Me.btn_keluarlist.TabIndex = 15
        Me.btn_keluarlist.Text = "Keluar List"
        Me.btn_keluarlist.UseVisualStyleBackColor = True
        '
        'btn_masuklist
        '
        Me.btn_masuklist.Location = New System.Drawing.Point(39, 117)
        Me.btn_masuklist.Name = "btn_masuklist"
        Me.btn_masuklist.Size = New System.Drawing.Size(112, 29)
        Me.btn_masuklist.TabIndex = 14
        Me.btn_masuklist.Text = "Masuk List"
        Me.btn_masuklist.UseVisualStyleBackColor = True
        '
        'PBfoto
        '
        Me.PBfoto.Location = New System.Drawing.Point(605, 18)
        Me.PBfoto.Name = "PBfoto"
        Me.PBfoto.Size = New System.Drawing.Size(100, 128)
        Me.PBfoto.TabIndex = 13
        Me.PBfoto.TabStop = False
        '
        'txt_judul
        '
        Me.txt_judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_judul.Location = New System.Drawing.Point(254, 62)
        Me.txt_judul.Name = "txt_judul"
        Me.txt_judul.ReadOnly = True
        Me.txt_judul.Size = New System.Drawing.Size(267, 24)
        Me.txt_judul.TabIndex = 12
        '
        'txt_idkoleksi
        '
        Me.txt_idkoleksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idkoleksi.Location = New System.Drawing.Point(127, 62)
        Me.txt_idkoleksi.Name = "txt_idkoleksi"
        Me.txt_idkoleksi.Size = New System.Drawing.Size(121, 24)
        Me.txt_idkoleksi.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "ID Koleksi"
        '
        'txt_nama
        '
        Me.txt_nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nama.Location = New System.Drawing.Point(254, 32)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.ReadOnly = True
        Me.txt_nama.Size = New System.Drawing.Size(267, 24)
        Me.txt_nama.TabIndex = 9
        '
        'txt_idanggota
        '
        Me.txt_idanggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idanggota.Location = New System.Drawing.Point(127, 32)
        Me.txt_idanggota.Name = "txt_idanggota"
        Me.txt_idanggota.Size = New System.Drawing.Size(121, 24)
        Me.txt_idanggota.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ID Anggota"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(393, 472)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 25)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Total Biaya Sewa"
        '
        'txt_tanggal
        '
        Me.txt_tanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tanggal.Location = New System.Drawing.Point(237, 89)
        Me.txt_tanggal.Name = "txt_tanggal"
        Me.txt_tanggal.Size = New System.Drawing.Size(166, 24)
        Me.txt_tanggal.TabIndex = 13
        '
        'txt_idtransaksi
        '
        Me.txt_idtransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idtransaksi.Location = New System.Drawing.Point(165, 89)
        Me.txt_idtransaksi.Name = "txt_idtransaksi"
        Me.txt_idtransaksi.ReadOnly = True
        Me.txt_idtransaksi.Size = New System.Drawing.Size(66, 24)
        Me.txt_idtransaksi.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "No. Transaksi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(524, 31)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "FORM TRANSAKSI PEMINJAMAN BUKU"
        '
        'FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 509)
        Me.Controls.Add(Me.txt_totalbiaya)
        Me.Controls.Add(Me.ListViewKoleksi)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_tanggal)
        Me.Controls.Add(Me.txt_idtransaksi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormTransaksi"
        Me.Text = "FormTransaksi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PBfoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents txt_totalbiaya As System.Windows.Forms.TextBox
    Friend WithEvents btn_proses As System.Windows.Forms.Button
    Friend WithEvents ListViewKoleksi As System.Windows.Forms.ListView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_keluarlist As System.Windows.Forms.Button
    Friend WithEvents btn_masuklist As System.Windows.Forms.Button
    Friend WithEvents PBfoto As System.Windows.Forms.PictureBox
    Friend WithEvents txt_judul As System.Windows.Forms.TextBox
    Friend WithEvents txt_idkoleksi As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_nama As System.Windows.Forms.TextBox
    Friend WithEvents txt_idanggota As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_tanggal As System.Windows.Forms.TextBox
    Friend WithEvents txt_idtransaksi As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
