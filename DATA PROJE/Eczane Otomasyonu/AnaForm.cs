using Eczane_Otomasyonu.StokYönetimi;
using Eczane_Otomasyonu.KullanıcıYönetimi;
using Eczane_Otomasyonu.Recete;
using Eczane_Otomasyonu.Raporlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eczane_Otomasyonu
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }


        private void ShowUserControl(UserControl uc)
        {
            // Paneli temizle
            panelContent.Controls.Clear();

            // Yeni UserControl'ü ekle
            uc.Dock = DockStyle.Fill; // Paneli tam kaplasın
            panelContent.Controls.Add(uc);
        }


        private void AnaForm_Load(object sender, EventArgs e)
        {
            LoadAnaSayfa(); // Uygulama ilk açıldığında ana sayfa yüklenir
        }


        private void ilaçEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UCIlacEkle()); // UCIlacEkle'yi göster
        }


        private void ilaçDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UCIlacDuzenle()); // UCIlacDuzenle'yi göster
        }


        private void kritikStokSeviyesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UCKritikStokSeviyesi()); // UCKritikStokSeviyesi'ni göster
        }


        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAnaSayfa(); // Ana sayfa yükleme fonksiyonunu çağır
        }


        // panelContent'e dışarıdan erişim sağlayan bir metot
        public Panel MainPanelContent
        {
            get { return panelContent; }
        }


        private void LoadAnaSayfa()
        {
            panelContent.Controls.Clear(); // Paneli temizle

            UCAnaSayfa ucAnaSayfa = new UCAnaSayfa(); // Yeni Ana Sayfa oluştur
            ucAnaSayfa.Dock = DockStyle.Fill; // Paneli tamamen kapla
            panelContent.Controls.Add(ucAnaSayfa); // Panel'e ekle
        }

        private void çalışanEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UCCalisanEkle()); // UCCalisanEkle'yi göster
        }

        private void çalışanDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UCCalisanDuzenle()); // UCCalisanDuzenle'yi göster
        }

        private void sonKullanmaTarihiGeçmişİlaçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UCSonKullanmaTarihi()); // UCSonKullanmaTarihi'ni göster
        }

        private void reçeteOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UCRecete()); // UCRecete'yi göster
        }

        private void satışRaporlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UCGunSonuRaporu()); // UCGunSonuRaporu'nu göster
        }

    }
}
