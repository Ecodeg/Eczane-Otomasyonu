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
using Eczane_Otomasyonu.Models;

namespace Eczane_Otomasyonu.Raporlar
{
    public partial class UCGunSonuRaporu : UserControl
    {
        public UCGunSonuRaporu()
        {
            InitializeComponent();
        }

        string connectionString = "Server=DESKTOP-6J2MESC\\SQLEXPRESS;Database=Eczane Otomasyonu;Trusted_Connection=True;";

        public decimal GetToplamSatis()
        {
            decimal toplamSatis = 0;

            string query = "SELECT dbo.ToplamSatisHesapla()"; // sql'de bulunan ToplamSatisHesapla (Function) çalıştırır

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    toplamSatis = Convert.ToDecimal(cmd.ExecuteScalar());
                }
                catch (Exception)
                {
                    // Hata oluştuğunda hiçbir işlem yapılmaz, hata gizlenir ve kaydedilmez.
                }
            }

            return toplamSatis;
        }



        public List<SatisRaporuModel> GetSatisRaporuModel()
        {
            List<SatisRaporuModel> satisRaporuListesi = new List<SatisRaporuModel>();

            string query = "SELECT SatisID, IlacAdi, Miktar, Fiyat, ToplamTutar, SatisTarihi FROM SatisRaporu"; // sql'de bulunan SatisRaporu (View) çalıştırır

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        SatisRaporuModel satis = new SatisRaporuModel
                        {
                            SatisID = reader["SatisID"] != DBNull.Value ? Convert.ToInt32(reader["SatisID"]) : 0,
                            IlacAdi = reader["IlacAdi"] != DBNull.Value ? reader["IlacAdi"].ToString() : string.Empty,
                            Miktar = reader["Miktar"] != DBNull.Value ? Convert.ToInt32(reader["Miktar"]) : 0,
                            Fiyat = reader["Fiyat"] != DBNull.Value ? Convert.ToDecimal(reader["Fiyat"]) : 0,
                            ToplamTutar = reader["ToplamTutar"] != DBNull.Value ? Convert.ToDecimal(reader["ToplamTutar"]) : 0,
                            SatisTarihi = reader["SatisTarihi"] != DBNull.Value ? Convert.ToDateTime(reader["SatisTarihi"]) : DateTime.MinValue
                        };
                        satisRaporuListesi.Add(satis);
                    }
                }
                catch (Exception)
                {
                    // Hata oluştuğunda hiçbir işlem yapılmaz, hata gizlenir ve kaydedilmez.
                }
            }

            return satisRaporuListesi;
        }



            public DataTable GetSatisRaporuDataTable()
        {
            DataTable dt = new DataTable();

            string query = "SELECT * FROM SatisRaporu";  // View'tan veri al

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                try
                {
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }

            return dt;
        }

        private void btnGunSonuRaporu_Click(object sender, EventArgs e)
        {
            // Toplam satış tutarını al
            decimal toplamSatis = GetToplamSatis();
            lblToplamSatis.Text = "Bugün Toplam Satış: " + toplamSatis.ToString("C2");

            // Satış raporunu al
            DataTable satisRaporu = GetSatisRaporuDataTable();

            // DataGridView'de satış raporunu göster
            dataGridViewSatisRaporu.DataSource = satisRaporu;

            // Toplam tutarı hesapla
            decimal toplamTutar = 0;
            foreach (DataRow row in satisRaporu.Rows)
            {
                // Satıştaki her satır için ToplamTutar hesapla
                toplamTutar += row["ToplamTutar"] != DBNull.Value ? Convert.ToDecimal(row["ToplamTutar"]) : 0;
            }

            // Toplam tutarı ekrana yazdır
            lblToplamSatis.Text = "Toplam Tutar: " + toplamTutar.ToString("C2");
        }




    }
}
