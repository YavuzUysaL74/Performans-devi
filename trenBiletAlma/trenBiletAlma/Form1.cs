using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace trenBiletAlma
{
    public partial class Form1 : Form
    {
        public string loginAd;
        public string loginSoyad;

        public void Listele(string tabloİsim)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\hackk\\OneDrive\\Masaüstü\\Performans Ödevi\\SQL\\userData.db");
            conn.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select * From '"+tabloİsim+"' ",conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, tabloİsim);
            dataGridView1.DataSource = ds.Tables[tabloİsim];
            conn.Close();
            
        }
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxAd.Visible = false;
            textBoxSoyad.Visible = false;
            textBoxMail.Visible = false;
            textBoxPassword.Visible = false;
            label11.Visible = false;
            label10.Visible = false;
            label8.Visible = false;
            label7.Visible = false;
            adminPanel.Visible = false;
            systemRegisterButton.Visible = false;
            accessButton.Visible = false;
            aktarButton.Enabled = false;
            groupBox1.Visible = false;

            seferNoAdmin.ReadOnly = true; // Read Only Texboxt oluşturma
            seferNoAdmin.BackColor = System.Drawing.SystemColors.Window;
            tarihAdmin.ReadOnly = true; 
            tarihAdmin.BackColor = System.Drawing.SystemColors.Window;
            saatAdmin.ReadOnly = true; 
            saatAdmin.BackColor = System.Drawing.SystemColors.Window;
            kalkisAdmin.ReadOnly = true;
            kalkisAdmin.BackColor = System.Drawing.SystemColors.Window;
            varisAdmin.ReadOnly = true;
            varisAdmin.BackColor = System.Drawing.SystemColors.Window;
            groupBox2.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string kalkis = kalisDuragi.Text;
            string istikamet = varisDuragi.Text;
            string tarih = kaklisTarihi.Text;
            string saat = kalkisSaati.Text;
            string yolcuSayısı = yolcuSayı.Text;

            SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\hackk\\OneDrive\\Masaüstü\\Performans Ödevi\\SQL\\userData.db");
            conn.Open();

            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO tren(kalkis,istikamet,tarih,saat,yolcuSayısı) VALUES( '" + kalkis + "' , '" + istikamet + "' , '" +tarih+ "' , '" + saat + "' , '" + yolcuSayı + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void seferListele_Click(object sender, EventArgs e)
        {
            aktarButton.Enabled = true;
            string kalkis = comboBox1.Text;
            string varis = comboBox2.Text;

            if (kalkis != varis)
            {
                SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\hackk\\OneDrive\\Masaüstü\\Performans Ödevi\\SQL\\userData.db");
                conn.Open();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select * From tren WHERE kalkis='" + kalkis + "' and istikamet ='" + varis + "' ", conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "tren");
                dataGridView1.DataSource = ds.Tables["tren"];
                conn.Close();
            }
            else if (kalkis == varis)
            {
                MessageBox.Show("Trenin kalktığı istasyon ile ulaşıcağı istasyon aynı olamaz...");
            }

            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (groupBox1.Visible == true)
            {
                groupBox1.Visible = false;
            }
            else if (groupBox1.Visible == false)
            {
                groupBox1.Visible = true;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            textBoxAd.Visible = false;
            textBoxSoyad.Visible = false;
            textBoxMail.Visible = true;
            textBoxPassword.Visible = true;
            label11.Visible = false;
            label10.Visible = false;
            label8.Visible = true;
            label7.Visible = true;
            accessButton.Visible = true;
            systemRegisterButton.Visible = false;
            
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            textBoxAd.Visible = true;
            textBoxSoyad.Visible = true;
            textBoxMail.Visible = true;
            textBoxPassword.Visible = true;
            label11.Visible = true;
            label10.Visible = true;
            label8.Visible = true;
            label7.Visible = true;
            systemRegisterButton.Visible = true;
            accessButton.Visible = false;
            
        }

        private void accessButton_Click(object sender, EventArgs e)
        {
            string mail = textBoxMail.Text;
            string password = textBoxPassword.Text;
            string mailGelen;
            string passwordGelen;         

            try
            {
                SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\hackk\\OneDrive\\Masaüstü\\Performans Ödevi\\SQL\\userData.db");
                conn.Open();

                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM users WHERE mail= '" + mail + "' and password= '" + password + "' ";
                SQLiteDataReader reader = cmd.ExecuteReader();
                reader.Read();

                mailGelen = reader["mail"].ToString().Trim();
                passwordGelen = reader["password"].ToString().Trim();

                string Yetki = reader["yetki"].ToString().Trim();
                loginAd = reader["Ad"].ToString();

                
                



                if (mailGelen == mail & passwordGelen == password)
                {

                    if (Yetki == "admin")
                    {
                        adminPanel.Visible = true;
                        MessageBox.Show($"Hoşgeldiniz {reader["ad"]} bey. Admin paneli aktifleştirildi!");
                    }
                    else if (Yetki == "user")
                    {
                        adminPanel.Visible = false;
                        MessageBox.Show($"Hoşgeldiniz {reader["ad"]} bey.");
                        groupBox1.Visible = false;
                        groupBox2.Visible = true;
                    }
                }
                reader.Close();
                conn.Close();

                textBoxAd.Visible = false;
                textBoxSoyad.Visible = false;
                textBoxMail.Visible = false;
                textBoxPassword.Visible = false;
                label11.Visible = false;
                label10.Visible = false;
                label8.Visible = false;
                label7.Visible = false;
                systemRegisterButton.Visible = false;
                accessButton.Visible = false;

                

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş başarısız. Lütfen bilgileri doğru girdiğinizden emin olun hesabınız yok ise hesap oluşturun!");
            }
            
        }

        private void systemRegisterButton_Click(object sender, EventArgs e)
        {
            string mail = textBoxMail.Text;
            string password = textBoxPassword.Text;
            string ad = textBoxAd.Text;
            string soyad = textBoxSoyad.Text;
            string yetki = "user";

            try
            {
                SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\hackk\\OneDrive\\Masaüstü\\Performans Ödevi\\SQL\\userData.db");
                conn.Open();

                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO users(ad,soyad,mail,password,yetki) VALUES ('" + ad + "' , '" + soyad + "' , '" + mail + "' , '" + password + "' , '" + yetki + "' )";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Hesap Başarıyla oluşturuldu! Giriş Ekranına yönlendiriliyorsunuz...");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aynı E-Mail'e sahip bir hesap zaten var!");
            }
            
        }

        private void ticketCreateButton_Click(object sender, EventArgs e)
        {
            string ad = adTextAdmin.Text;
            string soyad = soyadTextAdmin.Text;
            int seferNo = Convert.ToInt32(seferNoAdmin.Text);
            int koltukNo = Convert.ToInt32(koltukNoAdmin.Text);
            string kalis = kalkisAdmin.Text;
            string varis = varisAdmin.Text;
            string tarih = tarihAdmin.Text;
            string saat = saatAdmin.Text;
            SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\hackk\\OneDrive\\Masaüstü\\Performans Ödevi\\SQL\\userData.db");
            conn.Open();

            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM ticketSell WHERE koltukNo= '" + koltukNo + "' ";
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Read();



            if(koltukNo < 100)
            { 
                if (Convert.ToInt32(reader["koltukNo"]) == koltukNo)
                {
                    MessageBox.Show("Seçtiğiniz koltuk dolu");

                }
                else
                {
                SQLiteCommand biletAl = new SQLiteCommand();
                biletAl.Connection = conn;
                biletAl.CommandText = "INSERT INTO ticketSell VALUES('" + ad + "' , '" + soyad + "' , '" + seferNo + "' , '" + koltukNo + "' , '" + tarih + "' , '" + saat + "')";
                biletAl.ExecuteNonQuery();

                }
            }
            else
            {
                MessageBox.Show("Geçerli bir koltuk numarası giriniz.");
                koltukNoAdmin.Clear();
            }

            adTextAdmin.Clear();
            soyadTextAdmin.Clear();

            reader.Close();


            conn.Close();
        }

        private void aktarButton_Click(object sender, EventArgs e)
        {
            seferNoAdmin.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();    // Data grid view veri çekme   
            tarihAdmin.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();    
            saatAdmin.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            kalkisAdmin.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            varisAdmin.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\hackk\\OneDrive\\Masaüstü\\Performans Ödevi\\SQL\\userData.db");
            conn.Open();



            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }



        private void koltukNoAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void koltukNoAdmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void userSeferYazdır_Click(object sender, EventArgs e)
        {
            
            string kalkis = comboBox3.Text;
            string varis = comboBox4.Text;

            if (kalkis != varis)
            {
                SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\hackk\\OneDrive\\Masaüstü\\Performans Ödevi\\SQL\\userData.db");
                conn.Open();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select * From tren WHERE kalkis='" + kalkis + "' and istikamet ='" + varis + "' ", conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "tren");
                dataGridView2.DataSource = ds.Tables["tren"];
                conn.Close();
            }
            else if (kalkis == varis)
            {
                MessageBox.Show("Trenin kalktığı istasyon ile ulaşıcağı istasyon aynı olamaz...");
            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            MessageBox.Show("Bilet almak için öncelikle sisteme giriş yaptıktan sonra tren seferlerini kontrol etmek. Sonrasında ise tren garındaki yetkili kişeye istdeğiniz trenin bilgilerini söylere bilet alım işleminizi tamamlıyabilirsiniz.");
        }
    }
}
