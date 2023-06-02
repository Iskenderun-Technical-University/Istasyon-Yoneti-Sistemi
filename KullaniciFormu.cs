using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTOMASYON_ÖDEV
{
    public partial class KullaniciFormu : Form
    {
        public KullaniciFormu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YeniBilet yeniBilet = new YeniBilet();
            yeniBilet.Show();
            this.Hide();
        }

        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SifreDegistir sifreDegistir = new SifreDegistir();
            sifreDegistir.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Biletİptal biletİptal =new Biletİptal();
            biletİptal.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SattiginBiletler sattiginBiletler =new SattiginBiletler();
            sattiginBiletler.Show();
            this.Hide();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PersonelGiris personelGiris =new PersonelGiris();
            personelGiris.Show();
            this.Hide();
        }

        private void çıkışYapToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PersonelGiris personelGiris = new PersonelGiris();
            personelGiris.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TrenSaatleri trenSaatleri = new TrenSaatleri(); 
            trenSaatleri.Show();
            this.Hide();
        }

        private void KullaniciFormu_Load(object sender, EventArgs e)
        {

        }
    }
}
