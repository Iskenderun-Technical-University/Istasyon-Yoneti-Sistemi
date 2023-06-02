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
    public partial class İstasyonGüncelle : Form
    {
        public İstasyonGüncelle()
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
            
        }

        private void İstasyonBilgileri_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            string sorgu = "update TrenSaatleri set İstasyonAd=@iad,Tren1=@tren1,Tren2=@tren2,Tren3=@tren3,BiletFiyat=@biletfiyat  where İstasyonİd=@idm ";
            cmd.Parameters.AddWithValue("@idm", textBox1.Text);
            cmd.Parameters.AddWithValue("@iad", textBox2.Text);
            cmd.Parameters.AddWithValue("@tren1", textBox3.Text);
            cmd.Parameters.AddWithValue("@tren2", textBox5.Text);
            cmd.Parameters.AddWithValue("@tren3", textBox6.Text);
            cmd.Parameters.AddWithValue("@biletfiyat", textBox4.Text);

            veritabani.KomutYollaParametreli(sorgu, cmd);

            MessageBox.Show(textBox2.Text + " Adlı istasyon bilgileri güncellenmiştir.");
            veritabani.gridtumunudoldur(dataGridView1, "select * from TrenSaatleri");
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
