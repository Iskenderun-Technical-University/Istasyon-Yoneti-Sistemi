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
    public partial class YöneticiFormu : Form
    {
        public YöneticiFormu()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;

        static string baglanti = veritabani.baglanti;


        private void yeniKullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void YöneticiFormu_Load(object sender, EventArgs e)
        {

        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            İstasyonEkle istasyonEkle = new İstasyonEkle();
            istasyonEkle.Show();
        }

        private void şifreDegiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SifreDegistir sifreDegistir = new SifreDegistir();
            sifreDegistir.Show();  
        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelEkle kullaniciEkle = new PersonelEkle();
            kullaniciEkle.Show();

        }

        private void personelleriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void şifreDeğiştirmeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void yöneticiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelSil kullaniciSil = new PersonelSil();
            kullaniciSil.Show();
        }

        private void yöneticiEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void kullanıcıGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelGüncelle kullaniciGüncelle=new PersonelGüncelle();
            kullaniciGüncelle.Show();
        }

        private void kullanıcılarıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelleriGörüntüle kullanicilariGörüntüle=new PersonelleriGörüntüle();
            kullanicilariGörüntüle.Show();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelGiris personelGiris = new PersonelGiris();
            personelGiris.Show();
            this.Hide();
        }

        private void işlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void personelEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            BiletleriGörüntüle biletleriGörüntüle = new BiletleriGörüntüle();
            biletleriGörüntüle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            İstasyonGüncelle istasyonBilgileri = new İstasyonGüncelle();
            istasyonBilgileri.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SatisYapanPersoneller satisYapanPersoneller = new SatisYapanPersoneller();
            satisYapanPersoneller.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BilgileregöreBiletler bilgileregöreBiletler=new BilgileregöreBiletler();
            bilgileregöreBiletler.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            İstasyonSil istasyonSil = new İstasyonSil();
            istasyonSil.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PersonelGiris personelGiris = new PersonelGiris();
            personelGiris.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
