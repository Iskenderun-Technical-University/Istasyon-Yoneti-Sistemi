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
    public partial class KullaniciDetayliSatisYazdir : Form
    {
        public KullaniciDetayliSatisYazdir()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        public string kullanici;
        public DataSet ds = new DataSet();

        static string baglanti = veritabani.baglanti;

        private void KullaniciDetayliSatisYazdir_Load(object sender, EventArgs e)
        {
            kullaniciDetayRapor1.SetDataSource(ds.Tables[0]);
            kullaniciDetayRapor1.SetParameterValue("KullaniciAd", kullanici);
            crystalReportViewer1.ReportSource = kullaniciDetayRapor1;
        }
    }
}
