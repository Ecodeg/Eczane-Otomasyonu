using Eczane_Otomasyonu.Database;
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

namespace Eczane_Otomasyonu.KullanıcıYönetimi
{
    public partial class UCCalisanDuzenle : UserControl
    {
        public UCCalisanDuzenle()
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
                        dgvKullanicilar.DataSource = dt;
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




        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("CalisanGuncelle", conn)) // sql'de bulunan CalisanGuncelle (SP) ile güncelleme işlemini gerçekleştirir
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text);
                        cmd.Parameters.AddWithValue("@Sifre", txtSifre.Text);
                        cmd.Parameters.AddWithValue("@Rol", txtRol.Text);
                        cmd.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Çalışan başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKullanicilar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text))
            {
                MessageBox.Show("Silmek için bir çalışan seçmelisiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Bu çalışan silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = DatabaseConnection.GetConnection())
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("CalisanSil", conn)) // sql'de bulunan CalisanSil (SP) ile silme işlemini gerçekleştirir
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Çalışan başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKullanicilar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvKullanicilar_CellContentClick(object sender, DataGridViewCellEventArgs e) // datagrid view'de bulunan tablomuzdan veriye tıkladığımızda textboxları doldurur
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKullanicilar.Rows[e.RowIndex];
                txtKullaniciAdi.Text = row.Cells["KullanıcıAdı"].Value.ToString();
                txtSifre.Text = row.Cells["Sifre"].Value.ToString();
                txtRol.Text = row.Cells["Rol"].Value.ToString();
                txtTelefon.Text = row.Cells["Telefon"].Value.ToString();
            }
        }


    }
}
