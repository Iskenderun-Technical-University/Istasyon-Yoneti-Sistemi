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
    public partial class PersonelSil : Form
    {
        public PersonelSil()
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
            da.Fill(ds, "Personel");
            dataGridView1.DataSource = ds.Tables["Personel"];
            con.Close();
        }

        private void KullaniciSil_Load(object sender, EventArgs e)
        {
            veritabani.gridtumunudoldur(dataGridView1, "select * from Personel");
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.RowHeadersVisible = false; //en baştaki boş kolonu gizler.
            dataGridView1.MultiSelect = false; // birden fazla satır seçilemez.
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //seçtiğimiz satırı tamamen seçilmiş gösterir.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                try
                {
                    con = new SqlConnection(baglanti);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from Personel where Pid='" +
                        dataGridView1.CurrentRow.Cells["Pid"].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Silme İşlemi Başarıyla Tamamlandı.");
                    con.Close();
                    veritabani.gridtumunudoldur(dataGridView1, "select * from Personel");
                    textBox1.Text = "";
                    checkBox1.Checked = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Silmeyi Onaylıyorum Kısmını işaretlediğinize emin olun!");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sqlSorgu = "select * from Personel where Personel like '" + textBox1.Text + "%' order by Personel ASC";
            veritabani.gridtumunudoldur(dataGridView1,sqlSorgu);
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
