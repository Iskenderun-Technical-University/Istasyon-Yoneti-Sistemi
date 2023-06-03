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
    public partial class SattiginBiletler : Form
    {
        public SattiginBiletler()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;

        static string baglanti = veritabani.baglanti;
        public static string sqlSorgu;

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
            int genc = 0;
            int emekli = 0;
            int yaslı = 0;

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells["İndirimler"].Value.ToString() == "Çocuk (7 - 12 yaş dahil)  %50")
                {
                    çocuk = çocuk + 1;
                }
                else if (dataGridView1.Rows[i].Cells["İndirimler"].Value.ToString() == "Genç (13 - 26 yaş dahil) %15")
                {
                    genc = genc + 1;
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
        private void SattiginBiletler_Load(object sender, EventArgs e)
        {
            
            sqlSorgu = "select * from Biletler where SatisPersonel like '"+PersonelGiris.kullanicimSession+"%' order by BiletNo ASC";
            veritabani.gridtumunudoldur(dataGridView1, sqlSorgu);
            dataGridView1.Columns[4].HeaderText = "Varış Saati";
            dataGridView1.Columns[6].HeaderText = "Bilet Fiyatı";
            dataGridView1.Columns[7].HeaderText = "Satış Personeli";
            dataGridView1.RowHeadersVisible = false; //en baştaki boş kolonu gizler
            //dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[5].Width = 240;//sutün genişliğini ayarlar.
            dataGridView1.Columns[7].Width = 120;//sutün genişliğini ayarlar.
            textBox3.Text = (dataGridView1.Rows.Count - 1).ToString();
            toplamfiyat();
            BiletSayısıAktarma();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            KullaniciFormu kullaniciFormu = new KullaniciFormu();
            kullaniciFormu.Show();
            this.Hide();
        }
    }
}
