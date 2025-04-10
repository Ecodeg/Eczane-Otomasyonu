namespace Eczane_Otomasyonu.StokYönetimi
{
    partial class UCKritikStokSeviyesi
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
            this.dgvKritikStok = new System.Windows.Forms.DataGridView();
            this.btnSiparisOnayla = new System.Windows.Forms.Button();
            this.txtSiparisAdedi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLogID = new System.Windows.Forms.TextBox();
            this.txtIlacID = new System.Windows.Forms.TextBox();
            this.txtIlacAdi = new System.Windows.Forms.TextBox();
            this.txtStokMiktari = new System.Windows.Forms.TextBox();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.btnSiparisler = new System.Windows.Forms.Button();
            this.btnKritikSeviyedekiIlaclar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKritikStok)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKritikStok
            // 
            this.dgvKritikStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKritikStok.Location = new System.Drawing.Point(0, 229);
            this.dgvKritikStok.Name = "dgvKritikStok";
            this.dgvKritikStok.RowHeadersWidth = 51;
            this.dgvKritikStok.RowTemplate.Height = 24;
            this.dgvKritikStok.Size = new System.Drawing.Size(824, 260);
            this.dgvKritikStok.TabIndex = 0;
            this.dgvKritikStok.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKritikStok_CellContentClick);
            // 
            // btnSiparisOnayla
            // 
            this.btnSiparisOnayla.Location = new System.Drawing.Point(675, 156);
            this.btnSiparisOnayla.Name = "btnSiparisOnayla";
            this.btnSiparisOnayla.Size = new System.Drawing.Size(113, 48);
            this.btnSiparisOnayla.TabIndex = 2;
            this.btnSiparisOnayla.Text = "Siparişi Onayla";
            this.btnSiparisOnayla.UseVisualStyleBackColor = true;
            this.btnSiparisOnayla.Click += new System.EventHandler(this.btnSiparisOnayla_Click);
            // 
            // txtSiparisAdedi
            // 
            this.txtSiparisAdedi.Location = new System.Drawing.Point(577, 103);
            this.txtSiparisAdedi.Name = "txtSiparisAdedi";
            this.txtSiparisAdedi.Size = new System.Drawing.Size(153, 22);
            this.txtSiparisAdedi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Log ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "İlaç ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "İlaç Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stok Miktarı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tarih";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sipariş Adedi";
            // 
            // txtLogID
            // 
            this.txtLogID.Location = new System.Drawing.Point(146, 17);
            this.txtLogID.Name = "txtLogID";
            this.txtLogID.Size = new System.Drawing.Size(153, 22);
            this.txtLogID.TabIndex = 10;
            // 
            // txtIlacID
            // 
            this.txtIlacID.Location = new System.Drawing.Point(146, 62);
            this.txtIlacID.Name = "txtIlacID";
            this.txtIlacID.Size = new System.Drawing.Size(153, 22);
            this.txtIlacID.TabIndex = 11;
            // 
            // txtIlacAdi
            // 
            this.txtIlacAdi.Location = new System.Drawing.Point(146, 103);
            this.txtIlacAdi.Name = "txtIlacAdi";
            this.txtIlacAdi.Size = new System.Drawing.Size(153, 22);
            this.txtIlacAdi.TabIndex = 12;
            // 
            // txtStokMiktari
            // 
            this.txtStokMiktari.Location = new System.Drawing.Point(577, 20);
            this.txtStokMiktari.Name = "txtStokMiktari";
            this.txtStokMiktari.Size = new System.Drawing.Size(153, 22);
            this.txtStokMiktari.TabIndex = 13;
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(577, 62);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(153, 22);
            this.txtTarih.TabIndex = 14;
            // 
            // btnSiparisler
            // 
            this.btnSiparisler.Location = new System.Drawing.Point(31, 156);
            this.btnSiparisler.Name = "btnSiparisler";
            this.btnSiparisler.Size = new System.Drawing.Size(113, 63);
            this.btnSiparisler.TabIndex = 15;
            this.btnSiparisler.Text = "Siparişler";
            this.btnSiparisler.UseVisualStyleBackColor = true;
            this.btnSiparisler.Click += new System.EventHandler(this.btnSiparisler_Click);
            // 
            // btnKritikSeviyedekiIlaclar
            // 
            this.btnKritikSeviyedekiIlaclar.Location = new System.Drawing.Point(162, 156);
            this.btnKritikSeviyedekiIlaclar.Name = "btnKritikSeviyedekiIlaclar";
            this.btnKritikSeviyedekiIlaclar.Size = new System.Drawing.Size(113, 63);
            this.btnKritikSeviyedekiIlaclar.TabIndex = 16;
            this.btnKritikSeviyedekiIlaclar.Text = "Kritik Seviyedeki İlaçlar";
            this.btnKritikSeviyedekiIlaclar.UseVisualStyleBackColor = true;
            this.btnKritikSeviyedekiIlaclar.Click += new System.EventHandler(this.btnKritikSeviyedekiIlaclar_Click);
            // 
            // UCKritikStokSeviyesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnKritikSeviyedekiIlaclar);
            this.Controls.Add(this.btnSiparisler);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.txtStokMiktari);
            this.Controls.Add(this.txtIlacAdi);
            this.Controls.Add(this.txtIlacID);
            this.Controls.Add(this.txtLogID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSiparisAdedi);
            this.Controls.Add(this.btnSiparisOnayla);
            this.Controls.Add(this.dgvKritikStok);
            this.Name = "UCKritikStokSeviyesi";
            this.Size = new System.Drawing.Size(824, 489);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKritikStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKritikStok;
        private System.Windows.Forms.Button btnSiparisOnayla;
        private System.Windows.Forms.TextBox txtSiparisAdedi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLogID;
        private System.Windows.Forms.TextBox txtIlacID;
        private System.Windows.Forms.TextBox txtIlacAdi;
        private System.Windows.Forms.TextBox txtStokMiktari;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.Button btnSiparisler;
        private System.Windows.Forms.Button btnKritikSeviyedekiIlaclar;
    }
}
