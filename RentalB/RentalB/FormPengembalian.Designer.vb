<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPengembalian
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
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_cek = New System.Windows.Forms.Button()
        Me.btn_proses = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_namaanggota = New System.Windows.Forms.TextBox()
        Me.ListViewKoleksi = New System.Windows.Forms.ListView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_semua = New System.Windows.Forms.CheckBox()
        Me.txt_totaldenda = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_idanggota = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_close
        '
        Me.btn_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.Location = New System.Drawing.Point(632, 148)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(112, 34)
        Me.btn_close.TabIndex = 24
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'btn_cek
        '
        Me.btn_cek.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cek.Location = New System.Drawing.Point(316, 47)
        Me.btn_cek.Name = "btn_cek"
        Me.btn_cek.Size = New System.Drawing.Size(112, 34)
        Me.btn_cek.TabIndex = 14
        Me.btn_cek.Text = "CEK"
        Me.btn_cek.UseVisualStyleBackColor = True
        '
        'btn_proses
        '
        Me.btn_proses.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_proses.Location = New System.Drawing.Point(493, 148)
        Me.btn_proses.Name = "btn_proses"
        Me.btn_proses.Size = New System.Drawing.Size(112, 34)
        Me.btn_proses.TabIndex = 22
        Me.btn_proses.Text = "Proses"
        Me.btn_proses.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(131, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(560, 31)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "FORM TRANSAKSI PENGEMBALIAN BUKU"
        '
        'txt_namaanggota
        '
        Me.txt_namaanggota.Enabled = False
        Me.txt_namaanggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_namaanggota.Location = New System.Drawing.Point(127, 69)
        Me.txt_namaanggota.Name = "txt_namaanggota"
        Me.txt_namaanggota.Size = New System.Drawing.Size(166, 24)
        Me.txt_namaanggota.TabIndex = 11
        '
        'ListViewKoleksi
        '
        Me.ListViewKoleksi.CheckBoxes = True
        Me.ListViewKoleksi.GridLines = True
        Me.ListViewKoleksi.Location = New System.Drawing.Point(43, 264)
        Me.ListViewKoleksi.Name = "ListViewKoleksi"
        Me.ListViewKoleksi.Size = New System.Drawing.Size(727, 179)
        Me.ListViewKoleksi.TabIndex = 21
        Me.ListViewKoleksi.UseCompatibleStateImageBehavior = False
        Me.ListViewKoleksi.View = System.Windows.Forms.View.Details
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nama Anggota"
        '
        'cb_semua
        '
        Me.cb_semua.AutoSize = True
        Me.cb_semua.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_semua.Location = New System.Drawing.Point(43, 236)
        Me.cb_semua.Name = "cb_semua"
        Me.cb_semua.Size = New System.Drawing.Size(103, 22)
        Me.cb_semua.TabIndex = 26
        Me.cb_semua.Text = "Pilih semua"
        Me.cb_semua.UseVisualStyleBackColor = True
        '
        'txt_totaldenda
        '
        Me.txt_totaldenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totaldenda.Location = New System.Drawing.Point(583, 449)
        Me.txt_totaldenda.Name = "txt_totaldenda"
        Me.txt_totaldenda.ReadOnly = True
        Me.txt_totaldenda.Size = New System.Drawing.Size(187, 35)
        Me.txt_totaldenda.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(451, 455)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 25)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Total denda"
        '
        'txt_idanggota
        '
        Me.txt_idanggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idanggota.Location = New System.Drawing.Point(127, 39)
        Me.txt_idanggota.Name = "txt_idanggota"
        Me.txt_idanggota.Size = New System.Drawing.Size(166, 24)
        Me.txt_idanggota.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ID Anggota"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_cek)
        Me.GroupBox1.Controls.Add(Me.txt_namaanggota)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_idanggota)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(43, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 127)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Anggota"
        '
        'FormPengembalian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 495)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_proses)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListViewKoleksi)
        Me.Controls.Add(Me.cb_semua)
        Me.Controls.Add(Me.txt_totaldenda)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormPengembalian"
        Me.Text = "FormPengembalian"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_cek As System.Windows.Forms.Button
    Friend WithEvents btn_proses As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_namaanggota As System.Windows.Forms.TextBox
    Friend WithEvents ListViewKoleksi As System.Windows.Forms.ListView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cb_semua As System.Windows.Forms.CheckBox
    Friend WithEvents txt_totaldenda As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_idanggota As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
