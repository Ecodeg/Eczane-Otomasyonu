namespace Eczane_Otomasyonu
{
    partial class AnaForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anaSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reçetelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reçeteOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışRaporlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kritikStokSeviyesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sonKullanmaTarihiGeçmişİlaçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContent = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaSayfaToolStripMenuItem,
            this.reçetelerToolStripMenuItem,
            this.raporlarToolStripMenuItem,
            this.stokYönetimiToolStripMenuItem,
            this.kullanıcıYönetimiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(857, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anaSayfaToolStripMenuItem
            // 
            this.anaSayfaToolStripMenuItem.Name = "anaSayfaToolStripMenuItem";
            this.anaSayfaToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.anaSayfaToolStripMenuItem.Text = "Ana Sayfa";
            this.anaSayfaToolStripMenuItem.Click += new System.EventHandler(this.anaSayfaToolStripMenuItem_Click);
            // 
            // reçetelerToolStripMenuItem
            // 
            this.reçetelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reçeteOluşturToolStripMenuItem});
            this.reçetelerToolStripMenuItem.Name = "reçetelerToolStripMenuItem";
            this.reçetelerToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.reçetelerToolStripMenuItem.Text = "Reçete";
            // 
            // reçeteOluşturToolStripMenuItem
            // 
            this.reçeteOluşturToolStripMenuItem.Name = "reçeteOluşturToolStripMenuItem";
            this.reçeteOluşturToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.reçeteOluşturToolStripMenuItem.Text = "Reçete Görüntüle";
            this.reçeteOluşturToolStripMenuItem.Click += new System.EventHandler(this.reçeteOluşturToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satışRaporlarıToolStripMenuItem});
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // satışRaporlarıToolStripMenuItem
            // 
            this.satışRaporlarıToolStripMenuItem.Name = "satışRaporlarıToolStripMenuItem";
            this.satışRaporlarıToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.satışRaporlarıToolStripMenuItem.Text = "Gün Sonu Raporu";
            this.satışRaporlarıToolStripMenuItem.Click += new System.EventHandler(this.satışRaporlarıToolStripMenuItem_Click);
            // 
            // stokYönetimiToolStripMenuItem
            // 
            this.stokYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ilaçEkleToolStripMenuItem,
            this.ilaçDüzenleToolStripMenuItem,
            this.kritikStokSeviyesiToolStripMenuItem,
            this.sonKullanmaTarihiGeçmişİlaçlarToolStripMenuItem});
            this.stokYönetimiToolStripMenuItem.Name = "stokYönetimiToolStripMenuItem";
            this.stokYönetimiToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.stokYönetimiToolStripMenuItem.Text = "Stok Yönetimi";
            // 
            // ilaçEkleToolStripMenuItem
            // 
            this.ilaçEkleToolStripMenuItem.Name = "ilaçEkleToolStripMenuItem";
            this.ilaçEkleToolStripMenuItem.Size = new System.Drawing.Size(318, 26);
            this.ilaçEkleToolStripMenuItem.Text = "İlaç Ekle";
            this.ilaçEkleToolStripMenuItem.Click += new System.EventHandler(this.ilaçEkleToolStripMenuItem_Click);
            // 
            // ilaçDüzenleToolStripMenuItem
            // 
            this.ilaçDüzenleToolStripMenuItem.Name = "ilaçDüzenleToolStripMenuItem";
            this.ilaçDüzenleToolStripMenuItem.Size = new System.Drawing.Size(318, 26);
            this.ilaçDüzenleToolStripMenuItem.Text = "İlaç Düzenle";
            this.ilaçDüzenleToolStripMenuItem.Click += new System.EventHandler(this.ilaçDüzenleToolStripMenuItem_Click);
            // 
            // kritikStokSeviyesiToolStripMenuItem
            // 
            this.kritikStokSeviyesiToolStripMenuItem.Name = "kritikStokSeviyesiToolStripMenuItem";
            this.kritikStokSeviyesiToolStripMenuItem.Size = new System.Drawing.Size(318, 26);
            this.kritikStokSeviyesiToolStripMenuItem.Text = "Kritik Stok Seviyesi";
            this.kritikStokSeviyesiToolStripMenuItem.Click += new System.EventHandler(this.kritikStokSeviyesiToolStripMenuItem_Click);
            // 
            // sonKullanmaTarihiGeçmişİlaçlarToolStripMenuItem
            // 
            this.sonKullanmaTarihiGeçmişİlaçlarToolStripMenuItem.Name = "sonKullanmaTarihiGeçmişİlaçlarToolStripMenuItem";
            this.sonKullanmaTarihiGeçmişİlaçlarToolStripMenuItem.Size = new System.Drawing.Size(318, 26);
            this.sonKullanmaTarihiGeçmişİlaçlarToolStripMenuItem.Text = "Son Kullanma Tarihi Geçmiş İlaçlar";
            this.sonKullanmaTarihiGeçmişİlaçlarToolStripMenuItem.Click += new System.EventHandler(this.sonKullanmaTarihiGeçmişİlaçlarToolStripMenuItem_Click);
            // 
            // kullanıcıYönetimiToolStripMenuItem
            // 
            this.kullanıcıYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çalışanEkleToolStripMenuItem,
            this.çalışanDüzenleToolStripMenuItem});
            this.kullanıcıYönetimiToolStripMenuItem.Name = "kullanıcıYönetimiToolStripMenuItem";
            this.kullanıcıYönetimiToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.kullanıcıYönetimiToolStripMenuItem.Text = "Kullanıcı Yönetimi";
            // 
            // çalışanEkleToolStripMenuItem
            // 
            this.çalışanEkleToolStripMenuItem.Name = "çalışanEkleToolStripMenuItem";
            this.çalışanEkleToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.çalışanEkleToolStripMenuItem.Text = "Çalışan Ekle";
            this.çalışanEkleToolStripMenuItem.Click += new System.EventHandler(this.çalışanEkleToolStripMenuItem_Click);
            // 
            // çalışanDüzenleToolStripMenuItem
            // 
            this.çalışanDüzenleToolStripMenuItem.Name = "çalışanDüzenleToolStripMenuItem";
            this.çalışanDüzenleToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.çalışanDüzenleToolStripMenuItem.Text = "Çalışan Düzenle";
            this.çalışanDüzenleToolStripMenuItem.Click += new System.EventHandler(this.çalışanDüzenleToolStripMenuItem_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 28);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(857, 504);
            this.panelContent.TabIndex = 1;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 532);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reçetelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reçeteOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışRaporlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kritikStokSeviyesiToolStripMenuItem;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.ToolStripMenuItem anaSayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sonKullanmaTarihiGeçmişİlaçlarToolStripMenuItem;
    }
}