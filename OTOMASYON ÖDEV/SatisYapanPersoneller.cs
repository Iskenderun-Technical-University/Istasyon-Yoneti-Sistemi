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
    public partial class SatisYapanPersoneller : Form
    {
        public SatisYapanPersoneller()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd,cmd1;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;

        static string baglanti = veritabani.baglanti;
        public int urunID;

        public string sqlSorgu;

        void GridDoldurStoredProcedure(string deger)
        {
            con = new SqlConnection(baglanti);
            //store prosedür ismi
            cmd1 = new SqlCommand("tablolar_birlestir", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.Add("perAd", SqlDbType.NVarChar, 50).Value = "%" + deger + "%";
            da = new SqlDataAdapter(cmd1);
            ds = new DataSet();
            con.Open();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        public void toplamfiyat()
        {
            double tutar = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                tutar = tutar + double.Parse(dataGridView1.Rows[i].Cells["BiletFiyati"].Value.ToString());
            }
            textBox7.Text = tutar.ToString();
        }

        public void BiletSayısıAktarma()
        {
            int çocuk = 0;
            int genc=0;
            int emekli=0;
            int yaslı = 0;

            for(int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells["İndirimler"].Value.ToString()== "Çocuk (7 - 12 yaş dahil)  %50")
                {
                    çocuk=çocuk+ 1;
                }
                else if (dataGridView1.Rows[i].Cells["İndirimler"].Value.ToString() == "Genç (13 - 26 yaş dahil) %15")
                {
                    genc=genc+ 1;
                }
                else if (dataGridView1.Rows[i].Cells["İndirimler"].Value.ToString() == "60 - 65 yaş dahil              %15")
                {
                    emekli = emekli + 1;
                }
                else if (dataGridView1.Rows[i].Cells["İndirimler"].Value.ToString() == "65 yaş ve üzeri                 %50")
                {
                    yaslı = yaslı + 1;
                }

            }
            textBox2.Text = çocuk.ToString();
            textBox4.Text = genc.ToString();
            textBox5.Text = emekli.ToString();
            textBox6.Text = yaslı.ToString();
            

        }

        void griddoldur(string sql)
        {
            con = new SqlConnection(baglanti);
            da = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, sql);
            dataGridView1.DataSource = ds.Tables[sql];
            con.Close();
        }

        private void SatisYapanPersoneller_Load(object sender, EventArgs e)
        {
            sqlSorgu = "select Biletler.*, TrenSaatleri.*from Biletler INNER JOIN TrenSaatleri ON Biletler.İstasyonAd = TrenSaatleri.İstasyonAd";
            griddoldur(sqlSorgu);
            textBox3.Text = (dataGridView1.Rows.Count - 1).ToString();
            toplamfiyat();

            BiletSayısıAktarma();
            dataGridView1.Columns[4].HeaderText = "Varış Saati";
            dataGridView1.Columns[6].HeaderText = "Bilet Fiyatı";
            dataGridView1.Columns[7].HeaderText = "Satış Personeli";
            dataGridView1.Columns[1].HeaderText = "Nereye";
            dataGridView1.Columns[2].HeaderText = "Tren No";
            dataGridView1.Columns[13].HeaderText = "Birim Fiyat";
            dataGridView1.RowHeadersVisible = false; //en baştaki boş kolonu gizler
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[5].Width = 240;//sutün genişliğini ayarlar.
            dataGridView1.Columns[7].Width = 120;//sutün genişliğini ayarlar.
            dataGridView1.Columns[4].Width = 120;//sutün genişliğini ayarlar.
            dataGridView1.Columns[6].Width = 120;//sutün genişliğini ayarlar.

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GridDoldurStoredProcedure(textBox1.Text);
            //sqlSorgu = "select Biletler.*, TrenSaatleri.*from Biletler INNER JOIN TrenSaatleri ON Biletler.İstasyonAd = TrenSaatleri.İstasyonAd where SatisPersonel like'" + textBox1.Text + "%'";
           // griddoldur(sqlSorgu);
            textBox3.Text = (dataGridView1.Rows.Count - 1).ToString();
            toplamfiyat();

            BiletSayısıAktarma();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciDetayliSatisYazdir a = new KullaniciDetayliSatisYazdir();
            a.kullanici = textBox1.Text;
            a.ds = ds;
            a.Show();
        }
    }
}
