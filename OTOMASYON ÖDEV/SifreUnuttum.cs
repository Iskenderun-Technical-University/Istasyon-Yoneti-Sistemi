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
    public partial class SifreUnuttum : Form
    {
        public SifreUnuttum()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;

        static string baglanti = veritabani.baglanti;
        public bool KullanıcıKontrol()
        {
            string sorgu = "select Personel,Eposta from Personel where Personel = @user and Eposta = @eposta";
            con = new SqlConnection(baglanti);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@eposta", textBox2.Text);


            con.Open();
            dr = cmd.ExecuteReader();
            //kullanıcı adı ve şifre dogru girildiyse veri gelir.eger veri gelirse
            if (dr.Read())
            {
                //eski şifre dogruysa
                string islem = "update Personel set Sifre='" + veritabani.MD5Sifreleme(textBox3.Text) + "' where Personel='"+textBox1.Text+"'";
                veritabani.KomutYolla(islem, cmd);
                MessageBox.Show("Şifreniz Değiştirildi.");

                PersonelGiris personelGiris = new PersonelGiris();
                personelGiris.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Kullanıcı bilgileriniz hatalı!");
                textBox1.Text = "";
                textBox2.Text = "";
            }
            con.Close();

            return true;
        }

        private void SifreUnuttum_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(120, 0, 0, 0);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Text =="" || textBox2.Text=="" || textBox3.Text=="" || textBox4.Text == "")
            {
                MessageBox.Show("Lütfen tüm bilgileri eksiksiz bir şekilde doldurunuz!");
            }
            else
            {
                if (textBox3.Text == textBox4.Text)
                {
                    KullanıcıKontrol();
                }
                else
                {
                    MessageBox.Show("Yeni şifre ve tekrarı aynı değil.Lütfen tekrar deneyiniz.");
                    textBox3.Clear();
                    textBox4.Clear();
                }
            }

        }
    }
}
