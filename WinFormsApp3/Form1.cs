using Microsoft.Data.SqlClient;
using otopark2;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HASÝBE\OneDrive\Documents\ArabaParkDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void fill()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select AraçSahibi,Plaka from ArabaKayitTbl", baglanti);
            SqlDataReader rdr;
            rdr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("AraçSahibi,Plaka", typeof(string));
            dt.Load(rdr);
            AracSahibiCb.ValueMember = "AraçSahibi";
            PlakaCb.ValueMember = "Plaka";
            AracSahibiCb.DataSource = dt;
            PlakaCb.DataSource = dt;
            baglanti.Close();
        }
        private void odemeler()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            string query = "select * from ÖdemeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            var ds = new DataSet();
            sda.Fill(ds);
            OdemeDgv.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void temizle()
        {
            AracSahibiCb.Text = "";
            PlakaCb.Text = "";
            TutarTb.Text = "";
            CikisTb.Text = "";
        }

        private void uyeler()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            string query = "select * from ArabaKayitTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            var ds = new DataSet();
            sda.Fill(ds);
            KayitDgv.DataSource = ds.Tables[0];
            baglanti.Close();

        }
        private void CiroHesapla()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                string query = "SELECT SUM(TRY_CAST(Tutar AS INT)) FROM ÖdemeTbl";

                using (SqlCommand komut = new SqlCommand(query, baglanti))
                {
                    object sonuc = komut.ExecuteScalar();

                    if (sonuc != DBNull.Value && sonuc != null)
                    {
                        label22.Text = "Günlük Ciro: " + sonuc.ToString() + " TL";
                    }
                    else
                    {
                        label22.Text = "Günlük Ciro: 0 TL";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ciro hesaplanýrken hata oluþtu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            uyeler();
            fill();
            odemeler();
            CiroHesapla();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void KayýtDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int AracKey;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (AraçSahibiTb.Text == "" || TelefonTb.Text == "" || TarihDtp.Text == "" || PlakaTb.Text == "" || GiriþTb.Text == "")
            {
                MessageBox.Show("Lütfen boþ alanlarý doldurunuz!");
            }
            else
            {

                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    string query = "INSERT INTO  ArabaKayitTbl (AraçSahibi, Telefon, Tarih, Plaka, Giriþ) values (@p1, @p2, @p3, @p4, @p5)";

                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@p1", AraçSahibiTb.Text);
                    komut.Parameters.AddWithValue("@p2", TelefonTb.Text);
                    komut.Parameters.AddWithValue("@p3", TarihDtp.Text);
                    komut.Parameters.AddWithValue("@p4", PlakaTb.Text);
                    komut.Parameters.AddWithValue("@p5", GiriþTb.Text);

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Araç Kaydý Baþarýyla Eklenmiþtir.");

                    baglanti.Close();
                    uyeler();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    if (baglanti.State == ConnectionState.Open)
                    {
                        baglanti.Close();
                    }
                }
            }
        }


        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if
                (guna2CircleButton1.FillColor == Color.LawnGreen)
            {
                guna2CircleButton1.FillColor = Color.Red;
                pictureBox1.Visible = true;
            }
            else
            {
                guna2CircleButton1.FillColor = Color.LawnGreen;
                pictureBox1.Visible = false;
            }
        }
        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            if
                (guna2CircleButton2.FillColor == Color.LawnGreen)
            {
                guna2CircleButton2.FillColor = Color.Red;
                pictureBox2.Visible = true;
            }
            else
            {
                guna2CircleButton2.FillColor = Color.LawnGreen;
                pictureBox2.Visible = false;
            }
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            if
                (guna2CircleButton3.FillColor == Color.LawnGreen)
            {
                guna2CircleButton3.FillColor = Color.Red;
                pictureBox3.Visible = true;
            }
            else
            {
                guna2CircleButton3.FillColor = Color.LawnGreen;
                pictureBox3.Visible = false;
            }
        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            if
                (guna2CircleButton4.FillColor == Color.LawnGreen)
            {
                guna2CircleButton4.FillColor = Color.Red;
                pictureBox4.Visible = true;
            }
            else
            {
                guna2CircleButton4.FillColor = Color.LawnGreen;
                pictureBox4.Visible = false;
            }
        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            if
                (guna2CircleButton5.FillColor == Color.LawnGreen)
            {
                guna2CircleButton5.FillColor = Color.Red;
                pictureBox5.Visible = true;
            }
            else
            {
                guna2CircleButton5.FillColor = Color.LawnGreen;
                pictureBox5.Visible = false;
            }
        }

        private void guna2CircleButton6_Click(object sender, EventArgs e)
        {

            if
                (guna2CircleButton6.FillColor == Color.LawnGreen)
            {
                guna2CircleButton6.FillColor = Color.Red;
                pictureBox6.Visible = true;
            }
            else
            {
                guna2CircleButton6.FillColor = Color.LawnGreen;
                pictureBox6.Visible = false;
            }
        }

        private void guna2CircleButton7_Click(object sender, EventArgs e)
        {
            if
                (guna2CircleButton7.FillColor == Color.LawnGreen)
            {
                guna2CircleButton7.FillColor = Color.Red;
                pictureBox7.Visible = true;
            }
            else
            {
                guna2CircleButton7.FillColor = Color.LawnGreen;
                pictureBox7.Visible = false;
            }
        }

        private void guna2CircleButton8_Click(object sender, EventArgs e)
        {
            if
                (guna2CircleButton8.FillColor == Color.LawnGreen)
            {
                guna2CircleButton8.FillColor = Color.Red;
                pictureBox8.Visible = true;
            }
            else
            {
                guna2CircleButton8.FillColor = Color.LawnGreen;
                pictureBox8.Visible = false;
            }
        }

        private void Form1_Load_2(object sender, EventArgs e)
        {
            uyeler();
            fill();
            odemeler();
            if (guna2CircleButton1.FillColor == Color.LawnGreen || guna2CircleButton2.FillColor == Color.LawnGreen || guna2CircleButton3.FillColor == Color.LawnGreen || guna2CircleButton4.FillColor == Color.LawnGreen || guna2CircleButton5.FillColor == Color.LawnGreen || guna2CircleButton6.FillColor == Color.LawnGreen || guna2CircleButton7.FillColor == Color.LawnGreen || guna2CircleButton8.FillColor == Color.LawnGreen)
            {
                label9.Text = "Boþ Yer Mevcut";
            }
            else
            {
                label9.Text = "Otopark Boþ";
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (AracKey == 0)
            {
                MessageBox.Show("Lütfen silmek istediðiniz aracý listeden seçin!");
                return;
            }
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                string query = "DELETE FROM ArabaKayitTbl where AKayýtID = @Key";
                using (SqlCommand komut = new SqlCommand(query, baglanti))
                {
                    komut.Parameters.AddWithValue("@Key", AracKey);
                    komut.ExecuteNonQuery();
                }
                MessageBox.Show("Araç Kaydý Baþarýyla Silindi.");
                baglanti.Close();
                uyeler();
                AracKey = 0;
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
                MessageBox.Show("Silme hatasý:" + ex.Message);
            }
        }


        private void KayitDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = KayitDgv.Rows[e.RowIndex];
                AracKey = Convert.ToInt32(row.Cells[0].Value);
                AraçSahibiTb.Text = row.Cells[1].Value?.ToString();
                TelefonTb.Text = row.Cells[2].Value?.ToString();
                TarihDtp.Text = row.Cells[3].Value?.ToString();
                PlakaTb.Text = row.Cells[4].Value?.ToString();
                GiriþTb.Text = row.Cells[5].Value?.ToString();
            }
        }



        private void KayitDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (AraçSahibiTb.Text == "" || TelefonTb.Text == "" || TarihDtp.Text == "" || PlakaTb.Text == "" || GiriþTb.Text == "")
            {
                MessageBox.Show("Silinecek Kaydý Seçiniz");
            }
            else
            {

                try
                {
                    {
                        baglanti.Open();
                    }
                    string query = "update ArabaKayitTbl set AraçSahibi = '" + AraçSahibiTb.Text + "', Telefon = '" + TelefonTb.Text + "', Tarih = '" + TarihDtp.Text + "', Plaka = '" + PlakaTb.Text + "', Giriþ = '" + GiriþTb.Text + "', where AKayýtID = '" + AracKey + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Araç Kaydý Baþarýyla Güncellenmiþtir.");
                    baglanti.Close();
                    uyeler();
                    fill();



                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AraçSahibiTb.Text = "";
            TelefonTb.Text = "";
            TarihDtp.Text = "";
            PlakaTb.Text = "";
            GiriþTb.Text = "";
        }
        double x, y, z;
        private void guna2Button5_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(GiriþTb.Text))
            {
                MessageBox.Show("Hata: Giriþ saati boþ! Lütfen yukarýdaki tablodan bir araç seçtiðinizden emin olun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(CikisTb.Text))
            {
                MessageBox.Show("Lütfen Araç Çýkýþ saatini yazýn!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double x, y;


            bool girisOk = double.TryParse(GiriþTb.Text.Replace(',', '.'), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out x);
            bool cikisOk = double.TryParse(CikisTb.Text.Replace(',', '.'), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out y);


            if (!girisOk)
            {
                MessageBox.Show("Giriþ saati formatý hatalý! Kutudaki deðer: '" + GiriþTb.Text + "'", "Format Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!cikisOk)
            {
                MessageBox.Show("Çýkýþ saati formatý hatalý! Lütfen sadece 19.00 veya 19,00 gibi yazýn.", "Format Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            double z = y - x;

            if (z <= 1)
            {
                TutarTb.Text = "10";
            }
            else if (z > 1 && z <= 3)
            {
                TutarTb.Text = "20";
            }
            else if (z > 3 && z <= 5)
            {
                TutarTb.Text = "35";
            }
            else if (z > 5)
            {
                TutarTb.Text = "100";
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (AraçSahibiTb.Text == "" || PlakaTb.Text == "" || TutarTb.Text == "")
            {
                MessageBox.Show("Silinecek Kaydý Seçiniz");
            }
            else
            {

                try
                {
                    {
                        baglanti.Open();
                    }
                    string query = "INSERT INTO ÖdemeTbl VALUES ('" + AracSahibiCb.Text + "' , '" + PlakaCb.Text + "', '" + TutarTb.Text + "')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Ödeme Ýþlemi Baþarýlý");
                    baglanti.Close();
                    odemeler();

                    CiroHesapla();




                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message);
                }

                string plaka = TutarTb.Text.Trim().ToUpper();

                if (AktifAboneMi(plaka))
                {

                    TutarTb.Text = "0";
                    MessageBox.Show("Bu araç AKTÝF ABONEDÝR. Abonelik tarifesi gereði ücret alýnmayacaktýr.", "Abone Geçiþi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                }
            }
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int toplamCiro = 0;


                foreach (DataGridViewRow row in OdemeDgv.Rows)
                {

                    if (row.Cells["Tutar"].Value != null && !string.IsNullOrWhiteSpace(row.Cells["Tutar"].Value.ToString()))
                    {

                        toplamCiro += Convert.ToInt32(row.Cells["Tutar"].Value);
                    }
                }


                label22.Text = "Günlük Ciro: " + toplamCiro.ToString() + " TL";
            }
            catch (Exception ex)
            {

            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            FormAbone aboneFormu = new FormAbone();
            aboneFormu.ShowDialog();
        }
        public bool AktifAboneMi(string plaka)
        {
            bool durum = false;
            string baglantiCumlesi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HASÝBE\OneDrive\Documents\ArabaParkDb.mdf;Integrated Security=True;";


            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                string sorgu = "SELECT COUNT(*) FROM Aboneler WHERE Plaka = @Plaka AND BitisTarihi >= GETDATE()";

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@Plaka", plaka.Trim().ToUpper());
                    try
                    {
                        baglanti.Open();
                        int sonuc = Convert.ToInt32(komut.ExecuteScalar());
                        if (sonuc > 0)
                        {
                            durum = true;
                        }
                    }
                    catch
                    {
                        durum = false;
                    }
                }
            }
            return durum;
        }

        private void CikisTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void cýroSýlButonu_Click(object sender, EventArgs e)
        {
            if (AracKey == 0)
            {
                MessageBox.Show("Lütfen silmek istediðiniz aracý listeden seçin!");
                return;
            }

            string baglantiCumlesi = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\Users\HASÝBE\OneDrive\Documents\ArabaParkDb.mdf;Integrated Security=True;";

            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
                {
                    string query = "DELETE FROM ÖdemeTbl WHERE ÖdemeID = @Key";

                    using (SqlCommand komut = new SqlCommand(query, baglanti))
                    {
                        komut.Parameters.AddWithValue("@Key", AracKey);

                        baglanti.Open();
                        int etkilenenSatir = komut.ExecuteNonQuery();

                        if (etkilenenSatir > 0)
                        {
                            MessageBox.Show("Ödeme Kaydý Baþarýyla Silindi.", "Baþarýlý");
                            uyeler();
                            AracKey = 0;
                        }
                        else
                        {
                            MessageBox.Show("Silinecek uygun bir kayýt bulunamadý. ID'yi kontrol edin.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme hatasý: " + ex.Message);
            }
        }

        private void OdemeDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = OdemeDgv.Rows[e.RowIndex];
                AracKey = Convert.ToInt32(row.Cells[0].Value);
                AraçSahibiTb.Text = row.Cells[1].Value?.ToString();
                TelefonTb.Text = row.Cells[2].Value?.ToString();
                PlakaTb.Text = row.Cells[3].Value?.ToString();
            }
        }

        private void CýroGoster_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buton þu an çalýþýyor!");
            try
            {
                int toplamCiro = 0;


                foreach (DataGridViewRow row in OdemeDgv.Rows)
                {

                    if (row.Cells["Tutar"].Value != null && !string.IsNullOrWhiteSpace(row.Cells["Tutar"].Value.ToString()))
                    {

                        toplamCiro += Convert.ToInt32(row.Cells["Tutar"].Value);
                    }
                }


                label22.Text = "Günlük Ciro: " + toplamCiro.ToString() + " TL";
            }
            catch (Exception ex)
            {
                CiroHesapla();
            }
        }

        private void CýroGoster_Click_1(object sender, EventArgs e)
        {
            CiroHesapla();
        }
    }
}




