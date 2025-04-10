using Eczane_Otomasyonu.Database;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Eczane_Otomasyonu.StokYönetimi
{
    public partial class UCKritikStokSeviyesi : UserControl
    {
        public UCKritikStokSeviyesi()
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
                    string query = "SELECT * FROM KritikStokLog"; // Sql'de bulunan KritikStokLog tablosunu getirir
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvKritikStok.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvKritikStok_CellContentClick(object sender, DataGridViewCellEventArgs e) // datagrid view'de bulunan tablomuzdan veriye tıkladığımızda textboxları doldurur
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKritikStok.Rows[e.RowIndex];
                txtLogID.Text = row.Cells["LogID"].Value.ToString();
                txtIlacID.Text = row.Cells["IlacID"].Value.ToString();
                txtIlacAdi.Text = row.Cells["IlacAdi"].Value.ToString();
                txtStokMiktari.Text = row.Cells["StokMiktari"].Value.ToString();
                txtTarih.Text = row.Cells["Tarih"].Value.ToString();
            }
        }




        private bool ValidateInputs() // textboxların boş olup olmadığını kontrol ediyor boşsa mesaj döndürüyor
        {
            if (string.IsNullOrWhiteSpace(txtLogID.Text) ||
                string.IsNullOrWhiteSpace(txtIlacID.Text) ||
                string.IsNullOrWhiteSpace(txtIlacAdi.Text) ||
                string.IsNullOrWhiteSpace(txtStokMiktari.Text) ||
                string.IsNullOrWhiteSpace(txtTarih.Text) ||
                string.IsNullOrWhiteSpace(txtSiparisAdedi.Text))
            {
                MessageBox.Show("Tüm alanları doldurmanız gerekmektedir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!DateTime.TryParse(txtTarih.Text, out _))
            {
                MessageBox.Show("Tarih alanında geçerli bir tarih olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }




        private void btnSiparisOnayla_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SiparisEkle", conn)) // sql'de bulunan SiparisEkle (SP) ile Siparisler tablosuna ekleme işlemini gerçekleştirir
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IlacID", int.Parse(txtIlacID.Text));
                        cmd.Parameters.AddWithValue("@SiparisAdedi", int.Parse(txtSiparisAdedi.Text));
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




        private void btnSiparisler_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Siparisler"; // Siparisler tablosunu datagrid view'e getirir
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvKritikStok.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnKritikSeviyedekiIlaclar_Click(object sender, EventArgs e) // yeniden KritikStokLog tablosunu getirir
        {
            LoadIlaclar();
        }
    }
}
