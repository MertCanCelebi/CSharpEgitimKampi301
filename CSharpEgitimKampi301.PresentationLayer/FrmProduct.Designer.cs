namespace CSharpEgitimKampi301.PresentationLayer
{
    partial class FrmProduct
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
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetir = new System.Windows.Forms.Button();
            this.rtbAciklama = new System.Windows.Forms.RichTextBox();
            this.btnListele2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(146, 156);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(222, 21);
            this.cmbKategori.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 192);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Ürün Açıklaması:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 156);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Ürün Kategori:";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(146, 120);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(220, 20);
            this.txtFiyat.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Ürün Fiyat:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(146, 334);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(222, 29);
            this.btnEkle.TabIndex = 43;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(146, 371);
            this.btnSil.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(222, 29);
            this.btnSil.TabIndex = 42;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(146, 409);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(222, 29);
            this.btnGuncelle.TabIndex = 41;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(146, 84);
            this.txtStok.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(220, 20);
            this.txtStok.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Ürün Stok Sayısı:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(146, 48);
            this.txtAd.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(220, 20);
            this.txtAd.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Ürün Ad:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(414, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(608, 472);
            this.dataGridView1.TabIndex = 36;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(146, 291);
            this.btnListele.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(94, 29);
            this.btnListele.TabIndex = 35;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(146, 17);
            this.txtId.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(220, 20);
            this.txtId.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Ürün Id:";
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(146, 451);
            this.btnGetir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(222, 29);
            this.btnGetir.TabIndex = 52;
            this.btnGetir.Text = "ID İle Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // rtbAciklama
            // 
            this.rtbAciklama.Location = new System.Drawing.Point(146, 192);
            this.rtbAciklama.Name = "rtbAciklama";
            this.rtbAciklama.Size = new System.Drawing.Size(220, 88);
            this.rtbAciklama.TabIndex = 53;
            this.rtbAciklama.Text = "";
            // 
            // btnListele2
            // 
            this.btnListele2.Location = new System.Drawing.Point(277, 291);
            this.btnListele2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnListele2.Name = "btnListele2";
            this.btnListele2.Size = new System.Drawing.Size(91, 29);
            this.btnListele2.TabIndex = 54;
            this.btnListele2.Text = "Listele 2";
            this.btnListele2.UseVisualStyleBackColor = true;
            this.btnListele2.Click += new System.EventHandler(this.btnListele2_Click);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1054, 516);
            this.Controls.Add(this.btnListele2);
            this.Controls.Add(this.rtbAciklama);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Name = "FrmProduct";
            this.Text = "FrmProduct";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.RichTextBox rtbAciklama;
        private System.Windows.Forms.Button btnListele2;
    }
}