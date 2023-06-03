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
    public partial class TrenSaatleri : Form
    {
        public TrenSaatleri()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;

        static string baglanti = veritabani.baglanti;


        private void TrenSaatleri_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciFormu kullaniciFormu=new KullaniciFormu();
            kullaniciFormu.Show();
            this.Hide();
        }
    }
}
