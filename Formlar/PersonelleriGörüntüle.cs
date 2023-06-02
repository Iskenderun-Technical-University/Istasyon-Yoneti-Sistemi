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
    public partial class PersonelleriGörüntüle : Form
    {
        public PersonelleriGörüntüle()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;

        static string baglanti = veritabani.baglanti;
        public void VeriNavigasyon()
        {
            con = new SqlConnection(baglanti);
            da = new SqlDataAdapter("select * from Personel", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds);
            con.Close();

            bindingSource1.DataSource = ds.Tables[0];
            bindingNavigator1.BindingSource = bindingSource1;

            //label5.DataBindings.Add(new Binding("Text", bindingSource1, "Pid"));
            textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "Personel"));
            textBox2.DataBindings.Add(new Binding("Text", bindingSource1, "Sifre"));
            textBox3.DataBindings.Add(new Binding("Text", bindingSource1, "Eposta"));
            dateTimePicker1.DataBindings.Add(new Binding("Text", bindingSource1, "KayitTarihi"));
            label7.DataBindings.Add(new Binding("Text", bindingSource1, "Yetki"));
        }

        private void KullanicilariGörüntüle_Load(object sender, EventArgs e)
        {
            VeriNavigasyon();
            veritabani.gridtumunudoldur(dataGridView1, "select * from Personel");
            dataGridView1.RowHeadersVisible = false; //en baştaki boş kolonu gizler.
            dataGridView1.Columns[2].Visible = false;
        }

        private void bindingNavigator1_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            label7.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
