using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Eczane_Otomasyonu.Database; // Veritabanı bağlantısı için namespace

namespace Eczane_Otomasyonu
{
    public partial class GirişFormu : Form
    {
        public GirişFormu()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifre boşsa uyarı göster
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                // Veritabanı bağlantısını oluştur
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    // Kullanıcı adı ve şifreyi kontrol etmek için sorgu
                    string query = "SELECT Rol FROM Kullanıcılar WHERE KullanıcıAdı = @KullanıcıAdı AND Sifre = @Sifre";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@KullanıcıAdı", txtKullaniciAdi.Text);
                        cmd.Parameters.AddWithValue("@Sifre", txtSifre.Text); 

                        // Kullanıcı adı ve şifre doğruysa, kullanıcı rolünü al
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string rol = result.ToString();
                            MessageBox.Show($"Giriş başarılı! Hoş geldiniz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Başarılı giriş sonrası ana forma yönlendirme
                            this.Hide();
                            AnaForm mainForm = new AnaForm();
                            mainForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
