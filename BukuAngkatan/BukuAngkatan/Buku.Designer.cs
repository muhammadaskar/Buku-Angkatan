namespace BukuAngkatan
{
    partial class Buku
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgMhs = new System.Windows.Forms.DataGridView();
            this.buttonCekKoneksi = new System.Windows.Forms.Button();
            this.buttonTampilData = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxNim = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxJk = new System.Windows.Forms.ComboBox();
            this.textBoxProdi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgMhs)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "DAFTAR DATA MAHASIWA FAKULTAS ILMU KOMPUTER \r\n           UNIVERSITAS BRAWIJAYA AN" +
    "GKATAN 2018\r\n";
            // 
            // dgMhs
            // 
            this.dgMhs.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgMhs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMhs.GridColor = System.Drawing.SystemColors.MenuBar;
            this.dgMhs.Location = new System.Drawing.Point(12, 85);
            this.dgMhs.Name = "dgMhs";
            this.dgMhs.RowHeadersWidth = 70;
            this.dgMhs.Size = new System.Drawing.Size(524, 267);
            this.dgMhs.TabIndex = 1;
            this.dgMhs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMhs_CellContentClick);
            // 
            // buttonCekKoneksi
            // 
            this.buttonCekKoneksi.Location = new System.Drawing.Point(12, 389);
            this.buttonCekKoneksi.Name = "buttonCekKoneksi";
            this.buttonCekKoneksi.Size = new System.Drawing.Size(104, 61);
            this.buttonCekKoneksi.TabIndex = 2;
            this.buttonCekKoneksi.Text = "Cek Koneksi";
            this.buttonCekKoneksi.UseVisualStyleBackColor = true;
            this.buttonCekKoneksi.Click += new System.EventHandler(this.buttonCekKoneksi_Click);
            // 
            // buttonTampilData
            // 
            this.buttonTampilData.Location = new System.Drawing.Point(436, 389);
            this.buttonTampilData.Name = "buttonTampilData";
            this.buttonTampilData.Size = new System.Drawing.Size(100, 60);
            this.buttonTampilData.TabIndex = 3;
            this.buttonTampilData.Text = "Tampilkan Data";
            this.buttonTampilData.UseVisualStyleBackColor = true;
            this.buttonTampilData.Click += new System.EventHandler(this.buttonTampilData_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxProdi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxJk);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.textBoxNim);
            this.panel1.Controls.Add(this.textBoxNama);
            this.panel1.Location = new System.Drawing.Point(559, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 267);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Porgram Studi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Jenis Kelamin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nama";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(292, 228);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(32, 228);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "UPDATE";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxNim
            // 
            this.textBoxNim.Location = new System.Drawing.Point(120, 63);
            this.textBoxNim.Name = "textBoxNim";
            this.textBoxNim.Size = new System.Drawing.Size(265, 20);
            this.textBoxNim.TabIndex = 1;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(120, 96);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(265, 20);
            this.textBoxNama.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(240, 388);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(91, 61);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxJk
            // 
            this.textBoxJk.FormattingEnabled = true;
            this.textBoxJk.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.textBoxJk.Location = new System.Drawing.Point(120, 130);
            this.textBoxJk.Name = "textBoxJk";
            this.textBoxJk.Size = new System.Drawing.Size(265, 21);
            this.textBoxJk.TabIndex = 5;
            // 
            // textBoxProdi
            // 
            this.textBoxProdi.FormattingEnabled = true;
            this.textBoxProdi.Items.AddRange(new object[] {
            "Teknik Informatika",
            "Teknik Komputer",
            "Sistem Informasi",
            "Teknologi Informasi",
            "Pendidikan Teknologi Informasi"});
            this.textBoxProdi.Location = new System.Drawing.Point(120, 173);
            this.textBoxProdi.Name = "textBoxProdi";
            this.textBoxProdi.Size = new System.Drawing.Size(265, 21);
            this.textBoxProdi.TabIndex = 6;
            // 
            // Buku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(980, 468);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonTampilData);
            this.Controls.Add(this.buttonCekKoneksi);
            this.Controls.Add(this.dgMhs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Name = "Buku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "DAFTAR DATA MAHASISWA";
            this.Load += new System.EventHandler(this.Buku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMhs)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgMhs;
        private System.Windows.Forms.Button buttonCekKoneksi;
        private System.Windows.Forms.Button buttonTampilData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxNim;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.ComboBox textBoxJk;
        private System.Windows.Forms.ComboBox textBoxProdi;
    }
}