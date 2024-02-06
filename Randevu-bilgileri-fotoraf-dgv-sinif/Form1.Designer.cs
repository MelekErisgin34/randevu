namespace Randevu_bilgileri_fotoraf_dgv_sinif
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblAdsoyad = new System.Windows.Forms.Label();
            this.chkSigorta = new System.Windows.Forms.CheckBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.dgpTarih = new System.Windows.Forms.DateTimePicker();
            this.lblPolikinlik = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.lblAdsoyad);
            this.groupBox1.Controls.Add(this.chkSigorta);
            this.groupBox1.Controls.Add(this.lblTelefon);
            this.groupBox1.Controls.Add(this.dgpTarih);
            this.groupBox1.Controls.Add(this.lblPolikinlik);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lblTarih);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevu Bilgileri";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Brown;
            this.btnGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btnGuncelle.Image = global::Randevu_bilgileri_fotoraf_dgv_sinif.Properties.Resources._001_refresh_güneelle_fotoraf;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuncelle.Location = new System.Drawing.Point(700, 55);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 63);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Gray;
            this.btnSil.ForeColor = System.Drawing.Color.Tomato;
            this.btnSil.Image = global::Randevu_bilgileri_fotoraf_dgv_sinif.Properties.Resources._003_bin_sil_fotoraf;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSil.Location = new System.Drawing.Point(619, 55);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 63);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "SİL";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(56, 32);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID:";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Black;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEkle.Image = global::Randevu_bilgileri_fotoraf_dgv_sinif.Properties.Resources._002_diskette__ekle_fotoraf;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEkle.Location = new System.Drawing.Point(538, 55);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 63);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // lblAdsoyad
            // 
            this.lblAdsoyad.AutoSize = true;
            this.lblAdsoyad.Location = new System.Drawing.Point(13, 58);
            this.lblAdsoyad.Name = "lblAdsoyad";
            this.lblAdsoyad.Size = new System.Drawing.Size(65, 13);
            this.lblAdsoyad.TabIndex = 2;
            this.lblAdsoyad.Text = "AD SOYAD:";
            // 
            // chkSigorta
            // 
            this.chkSigorta.AutoSize = true;
            this.chkSigorta.Location = new System.Drawing.Point(300, 58);
            this.chkSigorta.Name = "chkSigorta";
            this.chkSigorta.Size = new System.Drawing.Size(77, 17);
            this.chkSigorta.TabIndex = 11;
            this.chkSigorta.Text = "SİGORTA:";
            this.chkSigorta.UseVisualStyleBackColor = true;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(19, 81);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(59, 13);
            this.lblTelefon.TabIndex = 3;
            this.lblTelefon.Text = "TELEFON:";
            // 
            // dgpTarih
            // 
            this.dgpTarih.Location = new System.Drawing.Point(314, 26);
            this.dgpTarih.Name = "dgpTarih";
            this.dgpTarih.Size = new System.Drawing.Size(169, 20);
            this.dgpTarih.TabIndex = 10;
            // 
            // lblPolikinlik
            // 
            this.lblPolikinlik.AutoSize = true;
            this.lblPolikinlik.Location = new System.Drawing.Point(9, 107);
            this.lblPolikinlik.Name = "lblPolikinlik";
            this.lblPolikinlik.Size = new System.Drawing.Size(68, 13);
            this.lblPolikinlik.TabIndex = 4;
            this.lblPolikinlik.Text = "POLİKİNLİK:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(283, 29);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(34, 13);
            this.lblTarih.TabIndex = 5;
            this.lblTarih.Text = "Tarih:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(84, 78);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 243);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Randevu Bilgi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblAdsoyad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblPolikinlik;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dgpTarih;
        private System.Windows.Forms.CheckBox chkSigorta;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

