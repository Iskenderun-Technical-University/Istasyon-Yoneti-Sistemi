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
    public partial class SifreDegistir : Form
    {
        public SifreDegistir()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;

        static string baglanti = veritabani.baglanti;


        public bool EskiSifreKontrol()
        {
            string sorgu = "select Sifre from Personel where Personel = @user and Sifre = @pass";
            con = new SqlConnection(baglanti);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", PersonelGiris.kullanicimSession);
            cmd.Parameters.AddWithValue("@pass", veritabani.MD5Sifreleme(textBox1.Text));


            con.Open();
            dr = cmd.ExecuteReader();
            //kullanıcı adı ve şifre dogru girildiyse veri gelir.eger veri gelirse
            if (dr.Read())
            {
                //eski şifre dogruysa
                string islem = "update Personel set Sifre='" + veritabani.MD5Sifreleme(textBox2.Text) + "' where Personel='" +PersonelGiris.kullanicimSession+ "'";
                veritabani.KomutYolla(islem, cmd);
                MessageBox.Show("Şifreniz Değiştirildi.");

            }
            else
            {
                label6.Text = "Eski şifreniz hatalı!";
                textBox1.Text = "";
            }
            con.Close();

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="" || textBox2.Text == "" || textBox3.Text == "")
            {
                label6.Text = "Lütfen tüm alanları eksiksi bir şekilde doldurunuz.";

            }
            else
            {
                label6.Text = "";
                if (checkBox1.Checked == true)
                {
                    if (textBox2.Text == textBox3.Text)
                    {
                        EskiSifreKontrol();
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        checkBox1.Checked = false;
                    }
                    else
                    {
                        label6.Text = "Yeni şifre ve tekrarı aynı değil.Lütfen tekrar deneyiniz.";
                        textBox2.Clear();
                        textBox3.Clear();
                    }

                }
                else if (checkBox1.Checked == false)
                {
                    label6.Text = "Değişiklikleri onaylıyorum kısmını işaretlediğinize emin olunuz!";
                }
            }
        }

        private void SifreDegistir_Load(object sender, EventArgs e)
        {
            label6.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
