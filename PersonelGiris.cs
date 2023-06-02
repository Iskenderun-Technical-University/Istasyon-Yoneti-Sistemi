using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OTOMASYON_ÖDEV
{
    public partial class PersonelGiris : Form
    {
        public PersonelGiris()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;
        static string baglanti = veritabani.baglanti;
        public int denemeSayısı = 0;

        public static string kullanicimSession = " ";

        int sonuc =0;
        public void captchaOluştur()
        {
            Random r = new Random();
            int ilk = r.Next(0, 50);
            int ikinci = r.Next(0, 10);
            sonuc = ilk + ikinci;
            label1.Text = ilk.ToString() + "+" + ikinci.ToString() + "=";
            
        }
        private void PersonelGiriş_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(130, 0, 0, 0);
            captchaOluştur();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (veritabani.loginKontrol(textBox1.Text, textBox2.Text) == true)
            {
                if(textBox3.Text == sonuc.ToString())
                {
                    con = new SqlConnection(baglanti);
                    con.Open();
                    cmd = new SqlCommand("select * from Personel where Personel like '" + textBox1.Text + "'", con);
                    SqlDataReader oku = cmd.ExecuteReader();
                    while (oku.Read())
                    {
                        label2.Text = oku[5].ToString();
                    }
                    con.Close();
                    if (label2.Text == "Kullanıcı")
                    {
                        MessageBox.Show("Tebrikler Kullanıcı Olarak Başarılı Giriş Yaptınız..");
                        kullanicimSession = textBox1.Text;
                        KullaniciFormu kullaniciFormu = new KullaniciFormu();
                        kullaniciFormu.Show();
                        this.Hide();
                    }
                    else if (label2.Text == "Yönetici")
                    {
                        MessageBox.Show("Tebrikler Yönetici Olarak Başarılı Giriş Yaptınız..");
                        kullanicimSession = textBox1.Text;
                        YöneticiFormu yöneticiFormu=new YöneticiFormu();
                        yöneticiFormu.Show();
                        this.Hide();
                    }
                    else 
                    {
                        MessageBox.Show("TCDD'nin Sistemine Giriş Yetkiniz Yoktur!");
                    }


                }
                else
                {
                    MessageBox.Show("işlemi hatalı girdiniz!");
                    captchaOluştur();
                    textBox3.Text = "";

                }
                
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı !!!");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
                denemeSayısı++;
                if (denemeSayısı == 3)
                {
                    MessageBox.Show("3 defa hatalı Giriş yaptınız!!!");
                    Application.Exit();
                }
                captchaOluştur();
                textBox3.Text = "";

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifreUnuttum sifreUnuttum = new SifreUnuttum();
            sifreUnuttum.Show();
            this.Hide();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

