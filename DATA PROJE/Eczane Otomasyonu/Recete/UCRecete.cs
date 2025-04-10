using Eczane_Otomasyonu.Database;
using Eczane_Otomasyonu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eczane_Otomasyonu.Recete
{
    public partial class UCRecete : UserControl
    {
        public UCRecete()
        {
            InitializeComponent();
        }

        string connectionString = "Server=DESKTOP-6J2MESC\\SQLEXPRESS;Database=Eczane Otomasyonu;Trusted_Connection=True;";


        public List<IlacKullanimiModel> GetIlaclarAndKullanimiByReceteID(int receteID)
        {
            List<IlacKullanimiModel> ilaclar = new List<IlacKullanimiModel>();

            string query = "SELECT * FROM dbo.GetIlaclarByReceteID(@ReceteID)"; // sql'de bulunan GetIlaclarByReceteID (Function) çalıştırır

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ReceteID", receteID);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        IlacKullanimiModel ilac = new IlacKullanimiModel
                        {
                            IlacID = Convert.ToInt32(reader["IlacID"]),
                            BarkodNo = reader["BarkodNo"].ToString(),
                            IlacAdi = reader["IlacAdi"].ToString(),
                            Fiyat = Convert.ToDecimal(reader["Fiyat"]),
                            GunlukDozaj = reader["GunlukDozaj"].ToString(),
                            Olcek = reader["Olcek"].ToString(),
                            ZamanAraliklari = reader["ZamanAraliklari"].ToString()
                        };
                        ilaclar.Add(ilac);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }

            return ilaclar;
        }



        private void btnSorgula_Click(object sender, EventArgs e)
        {
            int receteID;

            // ReceteID'nin geçerli bir sayı olup olmadığını kontrol eder
            if (int.TryParse(txtReceteID.Text, out receteID))
            {
                List<IlacKullanimiModel> ilaclar = GetIlaclarAndKullanimiByReceteID(receteID);

                // Eğer ilaç varsa, DataGridView'de gösterir
                if (ilaclar.Count > 0)
                {
                    dataGridViewIlaclar.DataSource = null;
                    dataGridViewIlaclar.DataSource = ilaclar;

                    // DataGridView sütun başlıklarını özelleştirme
                    dataGridViewIlaclar.Columns["IlacID"].HeaderText = "İlaç ID";
                    dataGridViewIlaclar.Columns["BarkodNo"].HeaderText = "Barkod";
                    dataGridViewIlaclar.Columns["IlacAdi"].HeaderText = "Ürün Adı";
                    dataGridViewIlaclar.Columns["Fiyat"].HeaderText = "Fiyat";
                    dataGridViewIlaclar.Columns["GunlukDozaj"].HeaderText = "Günlük Dozaj";
                    dataGridViewIlaclar.Columns["Olcek"].HeaderText = "Ölçek";
                    dataGridViewIlaclar.Columns["ZamanAraliklari"].HeaderText = "Zaman Aralıkları";

                    // Toplam fiyatı al
                    decimal toplamFiyat = GetToplamFiyatByReceteID(receteID);

                    // Toplam fiyatı ekranda göster
                    lblToplamFiyat.Text = "Toplam Fiyat: " + toplamFiyat.ToString("C2");
                }
                else
                {
                    MessageBox.Show("Bu reçeteye ait ilaç bulunmamaktadır.");
                }
            }
            else
            {
                // Hatalı giriş durumunda hata mesajı göster
                errorProviderReceteID.SetError(txtReceteID, "Geçerli bir ReceteID giriniz.");
            }
        }



        public decimal GetToplamFiyatByReceteID(int receteID)
        {
            decimal toplamFiyat = 0;

            string query = "SELECT dbo.ReceteToplamFiyat(@ReceteID)"; // sql'de bulunan ReceteToplamFiyat (Function) çalıştırır

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ReceteID", receteID);

                try
                {
                    conn.Open();
                    // Sadece bir değer dönecek (toplam fiyat)
                    toplamFiyat = Convert.ToDecimal(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }

            return toplamFiyat;
        }









        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            decimal toplamTutar = 0;

            // Reçete ID'sini al
            if (string.IsNullOrEmpty(txtReceteID.Text))
            {
                MessageBox.Show("Lütfen geçerli bir Reçete ID girin.");
                return;
            }

            int receteID = int.Parse(txtReceteID.Text);

            try
            {
                // Satış işlemleri
                foreach (DataGridViewRow row in dataGridViewIlaclar.Rows)
                {
                    if (row.IsNewRow) continue; 

                    int ilacID = Convert.ToInt32(row.Cells["IlacID"].Value);
                    decimal fiyat = Convert.ToDecimal(row.Cells["Fiyat"].Value);
                    toplamTutar += fiyat;

                    // Satış işlemini veritabanına ekle
                    AddSaleToDatabase(ilacID, fiyat, fiyat);
                }

                // Satış sonrası reçete ilaçlarını sil
                DeleteReceteIlaclari(receteID);

                // DataGridView'i temizle
                dataGridViewIlaclar.DataSource = null; // Bağlantıyı kes
                dataGridViewIlaclar.Rows.Clear(); // Satırları temizle

                MessageBox.Show($"Satış işlemi tamamlandı. Toplam Tutar: {toplamTutar:C}");
                MessageBox.Show("Kullanım Talimatları Yazdırılıyor.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        // ReceteIlaclari tablosundan reçete ilaçlarını sil
        private void DeleteReceteIlaclari(int receteID)
        {
            string query = "DELETE FROM ReceteIlaclari WHERE ReceteID = @ReceteID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ReceteID", receteID);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Reçete ilaçlarını silerken hata oluştu: " + ex.Message);
                }
            }
        }




        public void AddSaleToDatabase(int ilacID, decimal fiyat, decimal toplamTutar)
        {
            string query = "AddSaleToDatabase";  // sql'de bulunan AddSaleToDatabase (SP) ile Siparisler tablosuna ekleme işlemini gerçekleştirir

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Parametreleri ekle
                cmd.Parameters.AddWithValue("@IlacID", ilacID);
                cmd.Parameters.AddWithValue("@Fiyat", fiyat);
                cmd.Parameters.AddWithValue("@ToplamTutar", toplamTutar);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        Console.WriteLine("Satış işlemi gerçekleşmedi.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                }
            }
        }






    }
}
