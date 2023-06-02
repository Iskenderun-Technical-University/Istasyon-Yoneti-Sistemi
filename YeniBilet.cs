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
    public partial class YeniBilet : Form
    {
        public YeniBilet()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;

        static string baglanti = veritabani.baglanti;
        public void VarisSaati()
        {
            if (comboBox3.SelectedIndex == 0)
            {
                for (int i = 0; i < comboBox2.Items.Count; i++)
                {
                    if (comboBox2.SelectedIndex == i)
                    {
                        con = new SqlConnection(baglanti);
                        con.Open();
                        cmd = new SqlCommand("select * from TrenSaatleri where İstasyonAd like '" + comboBox2.Text + "'", con);
                        SqlDataReader oku = cmd.ExecuteReader();
                        while (oku.Read())
                        {
                            textBox2.Text = oku[2].ToString();
                        }
                    }
                }
            }
            else if (comboBox3.SelectedIndex == 1)
            {
                for (int i = 0; i < comboBox2.Items.Count; i++)
                {
                    if (comboBox2.SelectedIndex == i)
                    {
                        con = new SqlConnection(baglanti);
                        con.Open();
                        cmd = new SqlCommand("select * from TrenSaatleri where İstasyonAd like '" + comboBox2.Text + "'", con);
                        SqlDataReader oku = cmd.ExecuteReader();
                        while (oku.Read())
                        {
                            textBox2.Text = oku[3].ToString();
                        }
                    }
                }
            }
            else if (comboBox3.SelectedIndex == 2)
            {
                for (int i = 0; i < comboBox2.Items.Count; i++)
                {
                    if (comboBox2.SelectedIndex == i)
                    {
                        con = new SqlConnection(baglanti);
                        con.Open();
                        cmd = new SqlCommand("select * from TrenSaatleri where İstasyonAd like '" + comboBox2.Text + "'", con);
                        SqlDataReader oku = cmd.ExecuteReader();
                        while (oku.Read())
                        {
                            textBox2.Text = oku[4].ToString();
                        }
                    }
                }
            }


        }

        public void KalkısSaati()
        {
            if(comboBox3.SelectedIndex == 0)
            {
                con = new SqlConnection(baglanti);
                con.Open();
                cmd = new SqlCommand("select * from TrenSaatleri where İstasyonAd like 'Mersin%'", con);
                SqlDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    textBox3.Text = oku[2].ToString();
                }
            }
            else if (comboBox3.SelectedIndex == 1)
            {
                con = new SqlConnection(baglanti);
                con.Open();
                cmd = new SqlCommand("select * from TrenSaatleri where İstasyonAd like 'Mersin%'", con);
                SqlDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    textBox3.Text = oku[3].ToString();
                }
            }
            else if (comboBox3.SelectedIndex == 2)
            {
                con = new SqlConnection(baglanti);
                con.Open();
                cmd = new SqlCommand("select * from TrenSaatleri where İstasyonAd like 'Mersin%'", con);
                SqlDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    textBox3.Text = oku[4].ToString();
                }
            }

        }

        public void Biletfiyati()
        {
            double fiyat;

            con = new SqlConnection(baglanti);
            con.Open();
            cmd = new SqlCommand("select * from TrenSaatleri where İstasyonAd like '" + comboBox2.Text + "'", con);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                if (comboBox4.SelectedIndex == 0)
                {
                    fiyat = Convert.ToInt32(oku[5]);
                    textBox1.Text = (fiyat = fiyat - fiyat * (0.5)).ToString();
                }
                else if (comboBox4.SelectedIndex == 1)
                {
                    fiyat = Convert.ToInt32(oku[5]);
                    textBox1.Text = (fiyat = fiyat - fiyat * (0.15)).ToString();
                }
                else if (comboBox4.SelectedIndex == 2)
                {
                    fiyat = Convert.ToInt32(oku[5]);
                    textBox1.Text = (fiyat = fiyat - fiyat * (0.15)).ToString();
                }
                else if (comboBox4.SelectedIndex == 3)
                {
                    fiyat = Convert.ToInt32(oku[5]);
                    textBox1.Text = (fiyat = fiyat - fiyat * (0.5)).ToString();
                }
                else
                {
                    fiyat = Convert.ToInt32(oku[5]);
                    textBox1.Text = fiyat.ToString();
                }
            }


        }
        private void YeniBilet_Load(object sender, EventArgs e)
        {
            //comboBox2.Items.RemoveAt(1);
            //comboBox2.Items.Clear();
            con = new SqlConnection(baglanti);
            con.Open();
            cmd = new SqlCommand("Select * from TrenSaatleri", con);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                
                comboBox2.Items.Add(oku["İstasyonAd"].ToString());

            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox2.Text == "" || comboBox3.Text == "" || textBox2.Text=="" || textBox3.Text == "")
            {
                MessageBox.Show("Lütfen tüm boşlukları doldurunuz.");
            }
            else
            {
                cmd = new SqlCommand();
                string sorgu = "insert into Biletler(İstasyonAd,TrenNo,Tarih,KalkisSaati,İndirimler,BiletFiyati,SatisPersonel) values (@İstasyonAd,@trenno,@tarih,@kalkissaati,@indirimler,@biletfiyati,@satici)";
                cmd.Parameters.AddWithValue("@İstasyonAd", comboBox2.Text);
                cmd.Parameters.AddWithValue("@trenno", comboBox3.Text);
                cmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Value.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@kalkissaati", textBox3.Text);
                cmd.Parameters.AddWithValue("@indirimler", comboBox4.Text);
                cmd.Parameters.AddWithValue("@biletfiyati",Convert.ToDouble(textBox1.Text));
                cmd.Parameters.AddWithValue("@satici", PersonelGiris.kullanicimSession);
                veritabani.KomutYollaParametreli(sorgu, cmd);

                MessageBox.Show(comboBox2.Text + "'e Biletiniz Kesilmiştir. Hayırlı Yolculuklar Dileriz.");

                textBox2.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                textBox3.Text = "";
                comboBox4.Text = "";
                textBox1.Text = "";
            }
            
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            VarisSaati();
            KalkısSaati();
            Biletfiyati();
        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            VarisSaati();
            KalkısSaati();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox3.Text = "";
            comboBox4.Text = "";
            textBox1.Text = "";
        }

        private void comboBox4_TextChanged(object sender, EventArgs e)
        {
            Biletfiyati();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            KullaniciFormu kullaniciFormu = new KullaniciFormu();
            kullaniciFormu.Show();
            this.Hide();
        }
    }
}
