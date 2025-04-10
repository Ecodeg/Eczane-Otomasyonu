using Eczane_Otomasyonu.Database;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;
using System.Windows.Forms;

namespace Eczane_Otomasyonu.KullanıcıYönetimi
{
    public partial class UCCalisanEkle : UserControl
    {
        public UCCalisanEkle()
        {
            InitializeComponent();
            LoadKullanicilar(); // sql'den veriler datagrid view'e getirilir.
        }

        private void LoadKullanicilar()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Kullanıcılar";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvCalisanEkle.DataSource = dt;
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
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) ||
                string.IsNullOrWhiteSpace(txtSifre.Text) ||
                string.IsNullOrWhiteSpace(txtRol.Text) ||
                string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                MessageBox.Show("Tüm alanları doldurmanız gerekmektedir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearInputs() // textboxların içini temizler
        {
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
            txtRol.Clear();
            txtTelefon.Clear();
        }

        

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("CalisanEkle", conn)) // sql'de bulunan CalisanEkle (SP) ile ekleme işlemini gerçekleştirir
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text);
                        cmd.Parameters.AddWithValue("@Sifre", txtSifre.Text);
                        cmd.Parameters.AddWithValue("@Rol", txtRol.Text);
                        cmd.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Kullanıcı başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs(); // textboxların içini temizler
                LoadKullanicilar(); // ekleme işlemi gerçekleştikten sonra güncel Kullanıcılar tablosunu getirir
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }

}
