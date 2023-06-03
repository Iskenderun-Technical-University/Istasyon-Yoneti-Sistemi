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
    public partial class BiletleriGörüntüle : Form
    {
        public BiletleriGörüntüle()
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

        void griddoldur(string sql)
        {
            con = new SqlConnection(baglanti);
            da = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Biletler");
            dataGridView1.DataSource = ds.Tables["Biletler"];
            con.Close();
        }

        public void toplamfiyat()
        {
            double tutar = 0;
            for(int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                tutar=tutar+Convert.ToDouble(dataGridView1.Rows[i].Cells["BiletFiyati"].Value.ToString());
            }
            textBox5.Text = tutar.ToString();
        }

        private void SatılanBiletler_Load(object sender, EventArgs e)
        {      
            veritabani.gridtumunudoldur(dataGridView1, "select * from Biletler");
            //dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[4].HeaderText = "Varış Saati";
            dataGridView1.Columns[6].HeaderText = "Bilet Fiyatı";
            dataGridView1.Columns[7].HeaderText = "Satış Personeli";
            dataGridView1.Columns[1].HeaderText = "Nereye";
            dataGridView1.Columns[2].HeaderText = "Tren No";
            dataGridView1.Columns[4].Width = 120;//sutün genişliğini ayarlar.
            dataGridView1.Columns[6].Width = 120;//sutün genişliğini ayarlar.
            dataGridView1.RowHeadersVisible = false; //en baştaki boş kolonu gizler
            textBox4.Text = (dataGridView1.Rows.Count-1).ToString();
            dataGridView1.Columns[5].Width = 240;//sutün genişliğini ayarlar.
            dataGridView1.Columns[7].Width = 120;//sutün genişliğini ayarlar.
            toplamfiyat();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sqlSorgu = "select * from Biletler where TrenNo like '" + comboBox2.Text + "%' order by BiletNo ASC";
            //griddoldur(sqlSorgu);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //sqlSorgu = "select * from Biletler where BiletFiyati like '" + textBox2.Text + "%' order by BiletNo ASC";
            //griddoldur(sqlSorgu);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sqlSorgu = "select * from Biletler where İndirimler like '" + comboBox3.Text + "%' order by BiletNo ASC";
            //griddoldur(sqlSorgu);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //sqlSorgu = "select * from Biletler where Tarih like '" + dateTimePicker1.Text + "%' order by BiletNo ASC";
            //griddoldur(sqlSorgu);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BiletlerDetayliYazdir biletlerDetayliYazdir = new BiletlerDetayliYazdir();
            biletlerDetayliYazdir.Show();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
