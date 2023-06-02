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
    public partial class BilgileregöreBiletler : Form
    {
        public BilgileregöreBiletler()
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
            da.Fill(ds, sql);
            dataGridView1.DataSource = ds.Tables[sql];
            con.Close();
        }

        private void BilgilereBiletler_Load(object sender, EventArgs e)
        {
            veritabani.gridtumunudoldur(dataGridView1, "select * from Biletler");
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dataGridView1.Columns[4].HeaderText = "Varış Saati";
            dataGridView1.Columns[6].HeaderText = "Bilet Fiyatı";
            dataGridView1.Columns[7].HeaderText = "Satış Personeli";
            dataGridView1.Columns[1].HeaderText = "Nereye";
            dataGridView1.Columns[2].HeaderText = "Tren No";
            dataGridView1.RowHeadersVisible = false; //en baştaki boş kolonu gizler
            dataGridView1.Columns[5].Width = 240;//sutün genişliğini ayarlar.
            dataGridView1.Columns[7].Width = 120;//sutün genişliğini ayarlar.
            dataGridView1.Columns[4].Width = 120;//sutün genişliğini ayarlar.
            dataGridView1.Columns[6].Width = 120;//sutün genişliğini ayarlar.
            dateTimePicker1.Visible = false;
            label3.Visible = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                griddoldur("select * from Biletler");
            }
            else
            {
                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_ParentChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton7.Checked == true)
            {
                label1.Visible = false;
                textBox1.Visible = false;
                dateTimePicker1.Visible = true;
                label3.Visible = true;
            }
            else
            {
                label1.Visible = true;
                textBox1.Visible=true;
                dateTimePicker1.Visible=false;
                label3.Visible = false;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                sqlSorgu = "select * from Biletler where İstasyonAd like '" + textBox1.Text + "%' order by BiletNo ASC";
                griddoldur(sqlSorgu);

            }
            else if (radioButton2.Checked == true)
            {
                sqlSorgu = "select * from Biletler where TrenNo like '" + textBox1.Text + "%' order by BiletNo ASC";
                griddoldur(sqlSorgu);
            }
            else if (radioButton3.Checked == true)
            {
                sqlSorgu = "select * from Biletler where KalkisSaati like '" + textBox1.Text + "%' order by BiletNo ASC";
                griddoldur(sqlSorgu);
            }
            else if (radioButton4.Checked == true)
            {
                sqlSorgu = "select * from Biletler where İndirimler like '" + textBox1.Text + "%' order by BiletNo ASC";
                griddoldur(sqlSorgu);
            }
            else if (radioButton5.Checked == true)
            {
                sqlSorgu = "select * from Biletler where BiletFiyati like '" + textBox1.Text + "%' order by BiletNo ASC";
                griddoldur(sqlSorgu);
            }
            else if (radioButton6.Checked == true)
            {
                sqlSorgu = "select * from Biletler where SatisPersonel like '" + textBox1.Text + "%' order by BiletNo ASC";
                griddoldur(sqlSorgu);
            }
            else
            {
                sqlSorgu = "select * from Biletler where Tarih like '" + dateTimePicker1.Text + "%' order by BiletNo ASC";
                griddoldur(sqlSorgu);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
