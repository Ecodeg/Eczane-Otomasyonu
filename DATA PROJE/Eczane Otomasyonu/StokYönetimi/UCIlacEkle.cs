using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Eczane_Otomasyonu.Database;

namespace Eczane_Otomasyonu.StokYönetimi
{
    public partial class UCIlacEkle : UserControl
    {
        public UCIlacEkle()
        {
            InitializeComponent();
            LoadIlaclar(); // sql'den veriler datagrid view'e getirilir.
        }

        private void LoadIlaclar()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Ilaclar";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvIlacEkle.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs() // textboxların boş olup olmadığını kontrol ediyor boşsa mesaj döndürüyor
        {
            if (string.IsNullOrWhiteSpace(txtIlacAdi.Text) ||
                string.IsNullOrWhiteSpace(txtBarkodNo.Text) ||
                string.IsNullOrWhiteSpace(txtStokMiktari.Text) ||
                string.IsNullOrWhiteSpace(txtFiyat.Text) ||
                string.IsNullOrWhiteSpace(txtSonKullanimTarihi.Text) ||
                string.IsNullOrWhiteSpace(txtRafNo.Text) ||
                string.IsNullOrWhiteSpace(txtEklenmeTarihi.Text))
            {
                MessageBox.Show("Tüm alanları doldurmanız gerekmektedir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!DateTime.TryParse(txtSonKullanimTarihi.Text, out _)) // tarih kontrolü gerçekleştirilir
            {
                MessageBox.Show("Son Kullanım Tarihi geçerli bir tarih olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!DateTime.TryParse(txtEklenmeTarihi.Text, out _))
            {
                MessageBox.Show("Eklenme Tarihi geçerli bir tarih olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool CheckDuplicateBarkod(string barkodNo) // aynı barkod numarasına sahip veri seti var mı kontrolü
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Ilaclar WHERE BarkodNo = @BarkodNo";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BarkodNo", barkodNo);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

        private void ClearInputs() // textboxların içini temizler
        {
            txtIlacAdi.Clear();
            txtBarkodNo.Clear();
            txtStokMiktari.Clear();
            txtFiyat.Clear();
            txtSonKullanimTarihi.Clear();
            txtRafNo.Clear();
            txtEklenmeTarihi.Clear();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            if (CheckDuplicateBarkod(txtBarkodNo.Text))
            {
                MessageBox.Show("Bu barkod numarasına sahip bir ilaç zaten mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("IlacEkle", conn)) // sql'de bulunan IlacEkle (SP) ile ekleme işlemini gerçekleştirir
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IlacAdi", txtIlacAdi.Text);
                        cmd.Parameters.AddWithValue("@BarkodNo", txtBarkodNo.Text);
                        cmd.Parameters.AddWithValue("@StokMiktari", int.Parse(txtStokMiktari.Text));
                        cmd.Parameters.AddWithValue("@Fiyat", decimal.Parse(txtFiyat.Text));
                        cmd.Parameters.AddWithValue("@SonKullanmaTarihi", DateTime.Parse(txtSonKullanimTarihi.Text));
                        cmd.Parameters.AddWithValue("@RafNo", txtRafNo.Text);
                        cmd.Parameters.AddWithValue("@EklenmeTarihi", DateTime.Parse(txtEklenmeTarihi.Text));
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("İlaç başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs(); // textboxların içini temizler
                LoadIlaclar(); // ekleme işlemi gerçekleştikten sonra güncel Ilaclar tablosunu getirir
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
