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
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;

        static string baglanti = veritabani.baglanti;

        private void KullaniciEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="" || textBox2.Text!="" || textBox3.Text != "")
            {
                cmd = new SqlCommand();
                string islem = "insert into Personel (Personel,Sifre,KayitTarihi,Eposta,Yetki) values (@user,@password,@date,@eposta,@yetki)";
                cmd.Parameters.AddWithValue("@user", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", veritabani.MD5Sifreleme(textBox2.Text));
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                cmd.Parameters.AddWithValue("@eposta", textBox3.Text);
                if (radioButton1.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@yetki", "Kullanıcı");
                }
                else if(radioButton2.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@yetki", "Yönetici");
                }
                veritabani.KomutYollaParametreli(islem, cmd);

                MessageBox.Show("Yeni Personel eklenmiştir.");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen tüm bilgileri eksiksiz bir şekilde doldurunuz!");
            }
          
            
        }
    }
}
