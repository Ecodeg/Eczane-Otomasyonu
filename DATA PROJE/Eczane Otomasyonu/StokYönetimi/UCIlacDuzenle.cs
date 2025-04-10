using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Eczane_Otomasyonu.Database;

namespace Eczane_Otomasyonu.StokYönetimi
{
    public partial class UCIlacDuzenle : UserControl
    {
        public UCIlacDuzenle()
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
                        dgvIlacDuzenle.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvIlacDuzenle_CellClick(object sender, DataGridViewCellEventArgs e) // datagrid view'de bulunan tablomuzdan veriye tıkladığımızda textboxları doldurur
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvIlacDuzenle.Rows[e.RowIndex];
                txtIlacAdi.Text = row.Cells["IlacAdi"].Value.ToString();
                txtBarkodNo.Text = row.Cells["BarkodNo"].Value.ToString();
                txtStokMiktari.Text = row.Cells["StokMiktari"].Value.ToString();
                txtFiyat.Text = row.Cells["Fiyat"].Value.ToString();
                txtSonKullanimTarihi.Text = row.Cells["SonKullanmaTarihi"].Value.ToString();
                txtRafNo.Text = row.Cells["RafNo"].Value.ToString();
                txtEklenmeTarihi.Text = row.Cells["EklenmeTarihi"].Value.ToString();
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

        private bool CheckDuplicateBarkod(string barkodNo, string currentIlacAdi) // aynı barkod numarasına sahip veri seti var mı kontrolü
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Ilaclar WHERE BarkodNo = @BarkodNo AND IlacAdi != @CurrentIlacAdi";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BarkodNo", barkodNo);
                        cmd.Parameters.AddWithValue("@CurrentIlacAdi", currentIlacAdi);
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


        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            if (CheckDuplicateBarkod(txtBarkodNo.Text, txtIlacAdi.Text))
            {
                MessageBox.Show("Bu barkod numarasına sahip bir ilaç zaten mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("IlacGuncelle", conn)) // sql'de bulunan IlacGuncelle (SP) ile güncelleme işlemini gerçekleştirir
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

                MessageBox.Show("İlaç başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadIlaclar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBarkodNo.Text))
            {
                MessageBox.Show("Silmek için bir ilaç seçmelisiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Bu ilacı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = DatabaseConnection.GetConnection())
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("IlacSil", conn)) // sql'de bulunan IlacSil (SP) ile silme işlemini gerçekleştirir
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@BarkodNo", txtBarkodNo.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("İlaç başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadIlaclar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
