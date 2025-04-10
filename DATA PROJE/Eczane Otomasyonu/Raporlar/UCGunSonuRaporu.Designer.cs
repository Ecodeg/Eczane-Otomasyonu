namespace Eczane_Otomasyonu.Raporlar
{
    partial class UCGunSonuRaporu
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
            this.lblToplamSatis = new System.Windows.Forms.Label();
            this.dataGridViewSatisRaporu = new System.Windows.Forms.DataGridView();
            this.btnGunSonuRaporu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSatisRaporu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblToplamSatis
            // 
            this.lblToplamSatis.AutoSize = true;
            this.lblToplamSatis.Location = new System.Drawing.Point(34, 421);
            this.lblToplamSatis.Name = "lblToplamSatis";
            this.lblToplamSatis.Size = new System.Drawing.Size(134, 16);
            this.lblToplamSatis.TabIndex = 0;
            this.lblToplamSatis.Text = "Bugün Toplam Satış: ";
            // 
            // dataGridViewSatisRaporu
            // 
            this.dataGridViewSatisRaporu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSatisRaporu.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSatisRaporu.Name = "dataGridViewSatisRaporu";
            this.dataGridViewSatisRaporu.RowHeadersWidth = 51;
            this.dataGridViewSatisRaporu.RowTemplate.Height = 24;
            this.dataGridViewSatisRaporu.Size = new System.Drawing.Size(824, 377);
            this.dataGridViewSatisRaporu.TabIndex = 1;
            // 
            // btnGunSonuRaporu
            // 
            this.btnGunSonuRaporu.Location = new System.Drawing.Point(647, 409);
            this.btnGunSonuRaporu.Name = "btnGunSonuRaporu";
            this.btnGunSonuRaporu.Size = new System.Drawing.Size(123, 54);
            this.btnGunSonuRaporu.TabIndex = 2;
            this.btnGunSonuRaporu.Text = "Gün Sonu Raporu";
            this.btnGunSonuRaporu.UseVisualStyleBackColor = true;
            this.btnGunSonuRaporu.Click += new System.EventHandler(this.btnGunSonuRaporu_Click);
            // 
            // UCGunSonuRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGunSonuRaporu);
            this.Controls.Add(this.dataGridViewSatisRaporu);
            this.Controls.Add(this.lblToplamSatis);
            this.Name = "UCGunSonuRaporu";
            this.Size = new System.Drawing.Size(824, 489);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSatisRaporu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblToplamSatis;
        private System.Windows.Forms.DataGridView dataGridViewSatisRaporu;
        private System.Windows.Forms.Button btnGunSonuRaporu;
    }
}
