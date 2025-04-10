namespace Eczane_Otomasyonu.StokYönetimi
{
    partial class UCSonKullanmaTarihi
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
            this.dgvSonKullanma = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonKullanma)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSonKullanma
            // 
            this.dgvSonKullanma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSonKullanma.Location = new System.Drawing.Point(0, 0);
            this.dgvSonKullanma.Name = "dgvSonKullanma";
            this.dgvSonKullanma.RowHeadersWidth = 51;
            this.dgvSonKullanma.RowTemplate.Height = 24;
            this.dgvSonKullanma.Size = new System.Drawing.Size(824, 489);
            this.dgvSonKullanma.TabIndex = 0;
            // 
            // UCSonKullanmaTarihi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvSonKullanma);
            this.Name = "UCSonKullanmaTarihi";
            this.Size = new System.Drawing.Size(824, 489);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonKullanma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSonKullanma;
    }
}
