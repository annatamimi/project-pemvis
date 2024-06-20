namespace aplikasi_penjualan.GUI
{
    partial class FormBarang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            dateTime = new DateTimePicker();
            textBoxNomor = new TextBox();
            textBoxEmail = new TextBox();
            textBoxNama = new TextBox();
            textBoxKode = new TextBox();
            hariTanggal = new Label();
            nomorMeja = new Label();
            email = new Label();
            namaPelanggan = new Label();
            kodePemesanan = new Label();
            groupBox2 = new GroupBox();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonSave = new Button();
            buttonNew = new Button();
            dgvPelanggan = new DataGridView();
            kode_pemesanan = new DataGridViewTextBoxColumn();
            nama_pelanggan = new DataGridViewTextBoxColumn();
            nomor_meja = new DataGridViewTextBoxColumn();
            email_pelanggan = new DataGridViewTextBoxColumn();
            tanggal = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPelanggan).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTime);
            groupBox1.Controls.Add(textBoxNomor);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(textBoxNama);
            groupBox1.Controls.Add(textBoxKode);
            groupBox1.Controls.Add(hariTanggal);
            groupBox1.Controls.Add(nomorMeja);
            groupBox1.Controls.Add(email);
            groupBox1.Controls.Add(namaPelanggan);
            groupBox1.Controls.Add(kodePemesanan);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Sienna;
            groupBox1.Location = new Point(33, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(426, 223);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = ":: Form Pelanggan ::";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dateTime
            // 
            dateTime.CalendarTitleBackColor = SystemColors.ControlText;
            dateTime.CalendarTitleForeColor = SystemColors.ButtonHighlight;
            dateTime.Enabled = false;
            dateTime.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTime.Location = new Point(150, 186);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(252, 25);
            dateTime.TabIndex = 16;
            // 
            // textBoxNomor
            // 
            textBoxNomor.Enabled = false;
            textBoxNomor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxNomor.Location = new Point(150, 142);
            textBoxNomor.Multiline = true;
            textBoxNomor.Name = "textBoxNomor";
            textBoxNomor.Size = new Size(252, 32);
            textBoxNomor.TabIndex = 15;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Enabled = false;
            textBoxEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxEmail.Location = new Point(150, 103);
            textBoxEmail.Multiline = true;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(252, 32);
            textBoxEmail.TabIndex = 14;
            // 
            // textBoxNama
            // 
            textBoxNama.Enabled = false;
            textBoxNama.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxNama.Location = new Point(150, 64);
            textBoxNama.Multiline = true;
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(252, 32);
            textBoxNama.TabIndex = 13;
            // 
            // textBoxKode
            // 
            textBoxKode.Enabled = false;
            textBoxKode.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxKode.Location = new Point(150, 26);
            textBoxKode.Multiline = true;
            textBoxKode.Name = "textBoxKode";
            textBoxKode.Size = new Size(252, 32);
            textBoxKode.TabIndex = 12;
            // 
            // hariTanggal
            // 
            hariTanggal.AutoSize = true;
            hariTanggal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            hariTanggal.ForeColor = Color.Sienna;
            hariTanggal.Location = new Point(6, 186);
            hariTanggal.Name = "hariTanggal";
            hariTanggal.Size = new Size(110, 21);
            hariTanggal.TabIndex = 5;
            hariTanggal.Text = "Hari/Tanggal";
            // 
            // nomorMeja
            // 
            nomorMeja.AutoSize = true;
            nomorMeja.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            nomorMeja.ForeColor = Color.Sienna;
            nomorMeja.Location = new Point(6, 148);
            nomorMeja.Name = "nomorMeja";
            nomorMeja.Size = new Size(106, 21);
            nomorMeja.TabIndex = 4;
            nomorMeja.Text = "Nomor Meja";
            nomorMeja.Click += label4_Click;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            email.ForeColor = Color.Sienna;
            email.Location = new Point(6, 109);
            email.Name = "email";
            email.Size = new Size(53, 21);
            email.TabIndex = 3;
            email.Text = "Email";
            // 
            // namaPelanggan
            // 
            namaPelanggan.AutoSize = true;
            namaPelanggan.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            namaPelanggan.ForeColor = Color.Sienna;
            namaPelanggan.Location = new Point(6, 70);
            namaPelanggan.Name = "namaPelanggan";
            namaPelanggan.Size = new Size(142, 21);
            namaPelanggan.TabIndex = 2;
            namaPelanggan.Text = "Nama Pelanggan";
            namaPelanggan.Click += label2_Click;
            // 
            // kodePemesanan
            // 
            kodePemesanan.AutoSize = true;
            kodePemesanan.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            kodePemesanan.ForeColor = Color.Sienna;
            kodePemesanan.Location = new Point(6, 32);
            kodePemesanan.Name = "kodePemesanan";
            kodePemesanan.Size = new Size(141, 21);
            kodePemesanan.TabIndex = 1;
            kodePemesanan.Text = "Kode Pemesanan";
            kodePemesanan.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonDelete);
            groupBox2.Controls.Add(buttonUpdate);
            groupBox2.Controls.Add(buttonSave);
            groupBox2.Controls.Add(buttonNew);
            groupBox2.FlatStyle = FlatStyle.System;
            groupBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(33, 282);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(424, 137);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = ":: Proses ::";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Wheat;
            buttonDelete.Enabled = false;
            buttonDelete.ForeColor = Color.Sienna;
            buttonDelete.Location = new Point(218, 78);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(170, 40);
            buttonDelete.TabIndex = 16;
            buttonDelete.Text = "Hapus";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.Wheat;
            buttonUpdate.Enabled = false;
            buttonUpdate.ForeColor = Color.Sienna;
            buttonUpdate.Location = new Point(47, 78);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(165, 40);
            buttonUpdate.TabIndex = 15;
            buttonUpdate.Text = "Ubah";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Wheat;
            buttonSave.Enabled = false;
            buttonSave.ForeColor = Color.Sienna;
            buttonSave.Location = new Point(218, 32);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(170, 40);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Simpan";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonNew
            // 
            buttonNew.BackColor = Color.Wheat;
            buttonNew.ForeColor = Color.Sienna;
            buttonNew.Location = new Point(47, 32);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(165, 40);
            buttonNew.TabIndex = 13;
            buttonNew.Text = "Input";
            buttonNew.UseVisualStyleBackColor = false;
            buttonNew.Click += buttonNew_Click;
            // 
            // dgvPelanggan
            // 
            dgvPelanggan.BackgroundColor = Color.Wheat;
            dgvPelanggan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPelanggan.Columns.AddRange(new DataGridViewColumn[] { kode_pemesanan, nama_pelanggan, nomor_meja, email_pelanggan, tanggal });
            dgvPelanggan.Location = new Point(19, 32);
            dgvPelanggan.Name = "dgvPelanggan";
            dgvPelanggan.ReadOnly = true;
            dgvPelanggan.Size = new Size(733, 333);
            dgvPelanggan.TabIndex = 0;
            dgvPelanggan.Visible = false;
            dgvPelanggan.CellClick += dataGridView1_CellContentClick;
            dgvPelanggan.CellContentClick += dataGridView1_CellContentClick;
            // 
            // kode_pemesanan
            // 
            kode_pemesanan.DataPropertyName = "kode_pemesanan";
            kode_pemesanan.HeaderText = "Kode";
            kode_pemesanan.Name = "kode_pemesanan";
            kode_pemesanan.ReadOnly = true;
            kode_pemesanan.Width = 125;
            // 
            // nama_pelanggan
            // 
            nama_pelanggan.DataPropertyName = "nama_pelanggan";
            nama_pelanggan.HeaderText = "Nama Customer";
            nama_pelanggan.Name = "nama_pelanggan";
            nama_pelanggan.ReadOnly = true;
            nama_pelanggan.Width = 250;
            // 
            // nomor_meja
            // 
            nomor_meja.DataPropertyName = "nomor_meja";
            nomor_meja.HeaderText = "Nomor Meja";
            nomor_meja.Name = "nomor_meja";
            nomor_meja.ReadOnly = true;
            nomor_meja.Width = 125;
            // 
            // email_pelanggan
            // 
            email_pelanggan.DataPropertyName = "email";
            email_pelanggan.HeaderText = "Email";
            email_pelanggan.Name = "email_pelanggan";
            email_pelanggan.ReadOnly = true;
            email_pelanggan.Width = 125;
            // 
            // tanggal
            // 
            tanggal.DataPropertyName = "tanggal";
            tanggal.HeaderText = "Tanggal";
            tanggal.Name = "tanggal";
            tanggal.ReadOnly = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvPelanggan);
            groupBox3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            groupBox3.Location = new Point(507, 35);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(758, 384);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = ":: Data Pelanggan ::";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // FormBarang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1277, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            ForeColor = Color.BurlyWood;
            Name = "FormBarang";
            Text = "Form_pelanggan";
            Load += FormPelanggan_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPelanggan).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label hariTanggal;
        private Label nomorMeja;
        private Label email;
        private Label namaPelanggan;
        private Label kodePemesanan;
        private GroupBox groupBox2;
        private TextBox textBoxKode;
        private DataGridView dgvPelanggan;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonSave;
        private Button buttonNew;
        private GroupBox groupBox3;
        private TextBox textBoxNomor;
        private TextBox textBoxEmail;
        private TextBox textBoxNama;
        private DateTimePicker dateTime;
        private DataGridViewTextBoxColumn kode_pemesanan;
        private DataGridViewTextBoxColumn nama_pelanggan;
        private DataGridViewTextBoxColumn nomor_meja;
        private DataGridViewTextBoxColumn email_pelanggan;
        private DataGridViewTextBoxColumn tanggal;
    }
}