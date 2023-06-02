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
    public partial class Biletİptal : Form
    {
        public Biletİptal()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;
        static string baglanti = veritabani.baglanti;

        public static string sqlSorgu;
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Bilet numarasını giriniz lütfen.");
            }
            else
            {
                cmd = new SqlCommand();
                string sorgu = "delete from Biletler where BiletNo=@biletno";
                cmd.Parameters.AddWithValue("@biletno", textBox1.Text);
                
                veritabani.KomutYollaParametreli(sorgu, cmd);

                MessageBox.Show(textBox1.Text+"'nolu bilet iptal edilmiştir.");
                textBox1.Text = "";

                veritabani.gridtumunudoldur(dataGridView1, "select * from Biletler");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlSorgu = "select * from Biletler where BiletNo like '" + textBox1.Text + "%' order by BiletNo ASC";
            veritabani.gridtumunudoldur(dataGridView1,sqlSorgu);
        }

        private void Biletİptal_Load(object sender, EventArgs e)
        {
            veritabani.gridtumunudoldur(dataGridView1, "select * from Biletler");
            dataGridView1.Columns[7].Width = 110;//sutün genişliğini ayarlar.
            //dataGridView1.Columns[8].Visible = false;
            dataGridView1.RowHeadersVisible = false; //en baştaki boş kolonu gizler.
            dataGridView1.MultiSelect = false; // birden fazla satır seçilemez.
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //seçtiğimiz satırı tamamen seçilmiş gösterir.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KullaniciFormu kullaniciFormu = new KullaniciFormu();
            kullaniciFormu.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                veritabani.gridtumunudoldur(dataGridView1, "select * from Biletler");
            }
        }
    }
}
