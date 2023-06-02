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
    public partial class İstasyonEkle : Form
    {
        public İstasyonEkle()
        {
            InitializeComponent();
        }


        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;

        static string baglanti = veritabani.baglanti;


        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "" || textBox3.Text=="" || textBox4.Text=="" || textBox5.Text=="" || textBox6.Text == "")
            {
                MessageBox.Show("Lütfen tüm boşlukları eksiksiz bir şekilde doldurunuz...");
            }
            else
            {
                cmd = new SqlCommand();
                string sorgu = "insert into TrenSaatleri(İstasyonAd,Tren1,Tren2,Tren3,BiletFiyat) values (@iad,@tren1,@tren2,@tren3,@biletfiyat)";
                cmd.Parameters.AddWithValue("@iad", textBox2.Text);
                cmd.Parameters.AddWithValue("@Tren1", textBox3.Text);
                cmd.Parameters.AddWithValue("@Tren2", textBox5.Text);
                cmd.Parameters.AddWithValue("@Tren3", textBox6.Text);
                cmd.Parameters.AddWithValue("@biletfiyat", textBox4.Text);


                veritabani.KomutYollaParametreli(sorgu, cmd);

                MessageBox.Show("İstasyon Eklenmiştir!");
                veritabani.gridtumunudoldur(dataGridView1, "select * from TrenSaatleri");
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            
            
        }

        private void İstasyonEkle_Load(object sender, EventArgs e)
        {
            veritabani.gridtumunudoldur(dataGridView1, "select * from TrenSaatleri");
            dataGridView1.RowHeadersVisible = false; //en baştaki boş kolonu gizler.
            dataGridView1.Columns[0].Width = 120;//sutün genişliğini ayarlar.
            dataGridView1.Columns[5].Width = 120;//sutün genişliğini ayarlar.
            dataGridView1.Columns[1].Width = 120;//sutün genişliğini ayarlar.
            dataGridView1.Columns[0].HeaderText = "İstasyon No";
            dataGridView1.Columns[1].HeaderText = "İstasyon Ad";
            dataGridView1.Columns[2].HeaderText = "1.Tren";
            dataGridView1.Columns[3].HeaderText = "2.Tren";
            dataGridView1.Columns[4].HeaderText = "3.Tren";
            dataGridView1.Columns[5].HeaderText = "Bilet Fiyat";
        }
    }
}
