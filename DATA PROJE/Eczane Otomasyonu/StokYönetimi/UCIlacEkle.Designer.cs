namespace Eczane_Otomasyonu.StokYönetimi
{
    partial class UCIlacEkle
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIlacAdi = new System.Windows.Forms.TextBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.txtStokMiktari = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtSonKullanimTarihi = new System.Windows.Forms.TextBox();
            this.txtRafNo = new System.Windows.Forms.TextBox();
            this.txtEklenmeTarihi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dgvIlacEkle = new System.Windows.Forms.DataGridView();
            this.eczane_OtomasyonuDataSet = new Eczane_Otomasyonu.Eczane_OtomasyonuDataSet();
            this.ılaclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ilaclarTableAdapter = new Eczane_Otomasyonu.Eczane_OtomasyonuDataSetTableAdapters.IlaclarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIlacEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczane_OtomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ılaclarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlaç Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Barkod No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stok Miktarı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Son Kullanma Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(493, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Raf No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(445, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Eklenme Tarihi";
            // 
            // txtIlacAdi
            // 
            this.txtIlacAdi.Location = new System.Drawing.Point(181, 17);
            this.txtIlacAdi.Name = "txtIlacAdi";
            this.txtIlacAdi.Size = new System.Drawing.Size(153, 22);
            this.txtIlacAdi.TabIndex = 7;
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(181, 52);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(153, 22);
            this.txtBarkodNo.TabIndex = 8;
            // 
            // txtStokMiktari
            // 
            this.txtStokMiktari.Location = new System.Drawing.Point(181, 89);
            this.txtStokMiktari.Name = "txtStokMiktari";
            this.txtStokMiktari.Size = new System.Drawing.Size(153, 22);
            this.txtStokMiktari.TabIndex = 9;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(181, 129);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(153, 22);
            this.txtFiyat.TabIndex = 10;
            // 
            // txtSonKullanimTarihi
            // 
            this.txtSonKullanimTarihi.Location = new System.Drawing.Point(628, 17);
            this.txtSonKullanimTarihi.Name = "txtSonKullanimTarihi";
            this.txtSonKullanimTarihi.Size = new System.Drawing.Size(153, 22);
            this.txtSonKullanimTarihi.TabIndex = 11;
            // 
            // txtRafNo
            // 
            this.txtRafNo.Location = new System.Drawing.Point(628, 52);
            this.txtRafNo.Name = "txtRafNo";
            this.txtRafNo.Size = new System.Drawing.Size(153, 22);
            this.txtRafNo.TabIndex = 12;
            // 
            // txtEklenmeTarihi
            // 
            this.txtEklenmeTarihi.Location = new System.Drawing.Point(628, 89);
            this.txtEklenmeTarihi.Name = "txtEklenmeTarihi";
            this.txtEklenmeTarihi.Size = new System.Drawing.Size(153, 22);
            this.txtEklenmeTarihi.TabIndex = 13;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(652, 135);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(105, 58);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dgvIlacEkle
            // 
            this.dgvIlacEkle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIlacEkle.Location = new System.Drawing.Point(0, 229);
            this.dgvIlacEkle.Name = "dgvIlacEkle";
            this.dgvIlacEkle.RowHeadersWidth = 51;
            this.dgvIlacEkle.RowTemplate.Height = 24;
            this.dgvIlacEkle.Size = new System.Drawing.Size(824, 260);
            this.dgvIlacEkle.TabIndex = 15;
            // 
            // eczane_OtomasyonuDataSet
            // 
            this.eczane_OtomasyonuDataSet.DataSetName = "Eczane_OtomasyonuDataSet";
            this.eczane_OtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ılaclarBindingSource
            // 
            this.ılaclarBindingSource.DataMember = "Ilaclar";
            this.ılaclarBindingSource.DataSource = this.eczane_OtomasyonuDataSet;
            // 
            // ilaclarTableAdapter
            // 
            this.ilaclarTableAdapter.ClearBeforeFill = true;
            // 
            // UCIlacEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvIlacEkle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtEklenmeTarihi);
            this.Controls.Add(this.txtRafNo);
            this.Controls.Add(this.txtSonKullanimTarihi);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtStokMiktari);
            this.Controls.Add(this.txtBarkodNo);
            this.Controls.Add(this.txtIlacAdi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCIlacEkle";
            this.Size = new System.Drawing.Size(824, 489);
            //this.Load += new System.EventHandler(this.UCIlacEkle_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIlacEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczane_OtomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ılaclarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIlacAdi;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.TextBox txtStokMiktari;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtSonKullanimTarihi;
        private System.Windows.Forms.TextBox txtRafNo;
        private System.Windows.Forms.TextBox txtEklenmeTarihi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dgvIlacEkle;
        private System.Windows.Forms.BindingSource ılaclarBindingSource;
        private Eczane_OtomasyonuDataSet eczane_OtomasyonuDataSet;
        private Eczane_OtomasyonuDataSetTableAdapters.IlaclarTableAdapter ilaclarTableAdapter;
    }
}
