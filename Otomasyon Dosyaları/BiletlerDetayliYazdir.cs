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
    public partial class BiletlerDetayliYazdir : Form
    {
        public BiletlerDetayliYazdir()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        public DataSet ds = new DataSet();

        static string baglanti = veritabani.baglanti;
        public void RaporDoldur(string sql)
        {
            con = new SqlConnection(baglanti);
            da = new SqlDataAdapter(sql, con);
            ds = new DataSet();

            con.Open();
            da.Fill(ds);
            raporBiletler1.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = raporBiletler1;
            con.Close();

        }

        private void BiletlerDetayliYazdir_Load(object sender, EventArgs e)
        {
            RaporDoldur("select * from Biletler");
        }
    }
}
