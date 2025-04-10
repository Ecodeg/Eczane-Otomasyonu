namespace Eczane_Otomasyonu.Recete
{
    partial class UCRecete
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
            this.txtReceteID = new System.Windows.Forms.TextBox();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.dataGridViewIlaclar = new System.Windows.Forms.DataGridView();
            this.errorProviderReceteID = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblToplamFiyat = new System.Windows.Forms.Label();
            this.btnSatisYap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIlaclar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderReceteID)).BeginInit();
            this.SuspendLayout();
            // 
            // txtReceteID
            // 
            this.txtReceteID.Location = new System.Drawing.Point(114, 26);
            this.txtReceteID.Name = "txtReceteID";
            this.txtReceteID.Size = new System.Drawing.Size(193, 22);
            this.txtReceteID.TabIndex = 0;
            // 
            // btnSorgula
            // 
            this.btnSorgula.Location = new System.Drawing.Point(28, 97);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(90, 36);
            this.btnSorgula.TabIndex = 1;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // dataGridViewIlaclar
            // 
            this.dataGridViewIlaclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIlaclar.Location = new System.Drawing.Point(0, 197);
            this.dataGridViewIlaclar.Name = "dataGridViewIlaclar";
            this.dataGridViewIlaclar.RowHeadersWidth = 51;
            this.dataGridViewIlaclar.RowTemplate.Height = 24;
            this.dataGridViewIlaclar.Size = new System.Drawing.Size(824, 292);
            this.dataGridViewIlaclar.TabIndex = 2;
            // 
            // errorProviderReceteID
            // 
            this.errorProviderReceteID.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reçete ID";
            // 
            // lblToplamFiyat
            // 
            this.lblToplamFiyat.AutoSize = true;
            this.lblToplamFiyat.Location = new System.Drawing.Point(528, 32);
            this.lblToplamFiyat.Name = "lblToplamFiyat";
            this.lblToplamFiyat.Size = new System.Drawing.Size(92, 16);
            this.lblToplamFiyat.TabIndex = 4;
            this.lblToplamFiyat.Text = "Toplam Fiyat: ";
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.Location = new System.Drawing.Point(676, 97);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(90, 36);
            this.btnSatisYap.TabIndex = 5;
            this.btnSatisYap.Text = "Satış Yap";
            this.btnSatisYap.UseVisualStyleBackColor = true;
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);

            // 
            // UCRecete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSatisYap);
            this.Controls.Add(this.lblToplamFiyat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewIlaclar);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.txtReceteID);
            this.Name = "UCRecete";
            this.Size = new System.Drawing.Size(824, 489);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIlaclar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderReceteID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReceteID;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.DataGridView dataGridViewIlaclar;
        private System.Windows.Forms.ErrorProvider errorProviderReceteID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToplamFiyat;
        private System.Windows.Forms.Button btnSatisYap;
    }
}
