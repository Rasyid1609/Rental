<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUser
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
        Me.btn_pilihfoto = New System.Windows.Forms.Button()
        Me.cekpass = New System.Windows.Forms.CheckBox()
        Me.PBFoto = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ODBukaFoto = New System.Windows.Forms.OpenFileDialog()
        Me.cekid = New System.Windows.Forms.CheckBox()
        Me.txt_repassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_cari = New System.Windows.Forms.TextBox()
        Me.dgv_user = New System.Windows.Forms.DataGridView()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_status = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_namauser = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_iduser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_pilihfoto
        '
        Me.btn_pilihfoto.Location = New System.Drawing.Point(368, 160)
        Me.btn_pilihfoto.Name = "btn_pilihfoto"
        Me.btn_pilihfoto.Size = New System.Drawing.Size(75, 23)
        Me.btn_pilihfoto.TabIndex = 17
        Me.btn_pilihfoto.Text = "Pilih Foto"
        Me.btn_pilihfoto.UseVisualStyleBackColor = True
        '
        'cekpass
        '
        Me.cekpass.AutoSize = True
        Me.cekpass.Enabled = False
        Me.cekpass.Location = New System.Drawing.Point(287, 126)
        Me.cekpass.Name = "cekpass"
        Me.cekpass.Size = New System.Drawing.Size(15, 14)
        Me.cekpass.TabIndex = 15
        Me.cekpass.UseVisualStyleBackColor = True
        '
        'PBFoto
        '
        Me.PBFoto.Location = New System.Drawing.Point(361, 34)
        Me.PBFoto.Name = "PBFoto"
        Me.PBFoto.Size = New System.Drawing.Size(90, 120)
        Me.PBFoto.TabIndex = 16
        Me.PBFoto.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(278, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "FORM USER"
        '
        'ODBukaFoto
        '
        Me.ODBukaFoto.FileName = "OpenFileDialog1"
        '
        'cekid
        '
        Me.cekid.AutoSize = True
        Me.cekid.Enabled = False
        Me.cekid.Location = New System.Drawing.Point(287, 36)
        Me.cekid.Name = "cekid"
        Me.cekid.Size = New System.Drawing.Size(15, 14)
        Me.cekid.TabIndex = 14
        Me.cekid.UseVisualStyleBackColor = True
        '
        'txt_repassword
        '
        Me.txt_repassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_repassword.Location = New System.Drawing.Point(135, 121)
        Me.txt_repassword.Name = "txt_repassword"
        Me.txt_repassword.Size = New System.Drawing.Size(146, 24)
        Me.txt_repassword.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 18)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Re-Password"
        '
        'txt_cari
        '
        Me.txt_cari.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cari.Location = New System.Drawing.Point(82, 296)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(260, 24)
        Me.txt_cari.TabIndex = 11
        '
        'dgv_user
        '
        Me.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_user.Location = New System.Drawing.Point(47, 326)
        Me.dgv_user.Name = "dgv_user"
        Me.dgv_user.Size = New System.Drawing.Size(631, 202)
        Me.dgv_user.TabIndex = 10
        '
        'btn_delete
        '
        Me.btn_delete.Enabled = False
        Me.btn_delete.Location = New System.Drawing.Point(331, 210)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 11
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Enabled = False
        Me.btn_update.Location = New System.Drawing.Point(250, 210)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 10
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(169, 210)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_clear.TabIndex = 9
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.Location = New System.Drawing.Point(88, 210)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(75, 23)
        Me.btn_insert.TabIndex = 8
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_pilihfoto)
        Me.GroupBox1.Controls.Add(Me.PBFoto)
        Me.GroupBox1.Controls.Add(Me.cekpass)
        Me.GroupBox1.Controls.Add(Me.cekid)
        Me.GroupBox1.Controls.Add(Me.txt_repassword)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btn_delete)
        Me.GroupBox1.Controls.Add(Me.btn_update)
        Me.GroupBox1.Controls.Add(Me.btn_clear)
        Me.GroupBox1.Controls.Add(Me.btn_insert)
        Me.GroupBox1.Controls.Add(Me.cb_status)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_password)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_namauser)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_iduser)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(117, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(490, 249)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data User"
        '
        'cb_status
        '
        Me.cb_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_status.FormattingEnabled = True
        Me.cb_status.Items.AddRange(New Object() {"Admin", "Staff"})
        Me.cb_status.Location = New System.Drawing.Point(135, 151)
        Me.cb_status.Name = "cb_status"
        Me.cb_status.Size = New System.Drawing.Size(146, 26)
        Me.cb_status.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Status"
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(135, 91)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(146, 24)
        Me.txt_password.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Password"
        '
        'txt_namauser
        '
        Me.txt_namauser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_namauser.Location = New System.Drawing.Point(135, 61)
        Me.txt_namauser.Name = "txt_namauser"
        Me.txt_namauser.Size = New System.Drawing.Size(146, 24)
        Me.txt_namauser.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama User"
        '
        'txt_iduser
        '
        Me.txt_iduser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_iduser.Location = New System.Drawing.Point(135, 31)
        Me.txt_iduser.Name = "txt_iduser"
        Me.txt_iduser.Size = New System.Drawing.Size(146, 24)
        Me.txt_iduser.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID User"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(44, 299)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 18)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Cari"
        '
        'FormUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 554)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_cari)
        Me.Controls.Add(Me.dgv_user)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Name = "FormUser"
        Me.Text = "FormUser"
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_pilihfoto As System.Windows.Forms.Button
    Friend WithEvents cekpass As System.Windows.Forms.CheckBox
    Friend WithEvents PBFoto As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ODBukaFoto As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cekid As System.Windows.Forms.CheckBox
    Friend WithEvents txt_repassword As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_cari As System.Windows.Forms.TextBox
    Friend WithEvents dgv_user As System.Windows.Forms.DataGridView
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btn_insert As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_status As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_namauser As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_iduser As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
