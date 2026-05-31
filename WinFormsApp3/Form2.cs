using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otopark2
{
    public partial class FormAbone : Form
    {
        public FormAbone()
        {
            InitializeComponent();
            Listele();
        }
        private string baglantiCumlesi = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\Users\HASİBE\OneDrive\Documents\ArabaParkDb.mdf;Integrated Security=True;";
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPlaka.Text))
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz abonenin plakasını girin.");
                return;
            }         

            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                string sorgu = "UPDATE Aboneler SET AdSoyad=@AdSoyad, Telefon=@Telefon, BaslangicTarihi=@Baslangic, BitisTarihi=@Bitis, AboneTipi=@AboneTipi WHERE Plaka=@Plaka";

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@Plaka", txtPlaka.Text.Trim().ToUpper());
                    komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text.Trim());
                    komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text.Trim());
                    komut.Parameters.AddWithValue("@Baslangic", dtBaslangic.Value);
                    komut.Parameters.AddWithValue("@Bitis", dtBitis.Value);
                    komut.Parameters.AddWithValue("@AboneTipi", cmbAboneTipi.SelectedItem?.ToString() ?? "Aylık");

                    try
                    {
                        baglanti.Open();
                        int etkilenenSatir = komut.ExecuteNonQuery();

                        if (etkilenenSatir > 0)
                        {
                            MessageBox.Show("Abone bilgileri başarıyla güncellendi!", "Başarılı");
                            Listele(); 
                        }
                        else
                        {
                            MessageBox.Show("Bu plakaya ait bir abone bulunamadı.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Güncelleme hatası: " + ex.Message);
                    }
                }
            }
        } 

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPlaka.Text))
            {
                MessageBox.Show("Lütfen silmek istediğiniz abonenin plakasını yazın veya tablodan seçin.");
                return;
            }

            DialogResult onay = MessageBox.Show("Bu aracın aboneliğini iptal etmek istediğinize emin misiniz?", "Abonelik İptal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (onay == DialogResult.Yes)
            {              
                using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
                {
                    string sorgu = "DELETE FROM Aboneler WHERE Plaka = @Plaka";

                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@Plaka", txtPlaka.Text.Trim().ToUpper());

                        try
                        {
                            baglanti.Open();
                            komut.ExecuteNonQuery();
                            MessageBox.Show("Abonelik kaydı başarıyla silindi.", "Silindi");
                            Listele(); 

                           
                            txtPlaka.Clear();
                            txtAdSoyad.Clear();
                            txtTelefon.Clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Silme hatası: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Listele();

            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                string sorgu = "INSERT INTO Aboneler (Plaka, AdSoyad, Telefon, BaslangicTarihi, BitisTarihi, AboneTipi) " +
                               "VALUES (@Plaka, @AdSoyad, @Telefon, @Baslangic, @Bitis, @AboneTipi)";

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@Plaka", txtPlaka.Text);
                    komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
                    komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                    komut.Parameters.AddWithValue("@Baslangic", dtBaslangic.Value);
                    komut.Parameters.AddWithValue("@Bitis", dtBitis.Value);
                    komut.Parameters.AddWithValue("@AboneTipi", cmbAboneTipi.SelectedItem?.ToString() ?? "Aylık");

                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Yeni abone başarıyla kaydedildi!");

                }
            }
        }
        public void Listele()
        {        
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
                {
                    string sorgu = "SELECT * FROM Aboneler";
                    using (SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewAboneler.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler listelenirken hata oluştu: " + ex.Message);
            }

        }
    }
}
