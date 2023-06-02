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
    public partial class PersonelGüncelle : Form
    {
        public PersonelGüncelle()
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                con = new SqlConnection(baglanti);
                string islem = "update Personel set Eposta=@eposta,Personel=@user,KayitTarihi=@tarih,Yetki=@yetki where Pid=@idm ";
                cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@user", textBox2.Text);
                //cmd.Parameters.AddWithValue("@password", veritabani.MD5Sifreleme(textBox3.Text));
                cmd.Parameters.AddWithValue("@eposta", textBox4.Text);
                cmd.Parameters.AddWithValue("@idm", Convert.ToInt32(label6.Text));
                cmd.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                if (radioButton1.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@yetki", "Kullanıcı");
                }
                else if (radioButton2.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@yetki", "Yönetici");
                }
                veritabani.KomutYollaParametreli(islem, cmd);
                MessageBox.Show(textBox2.Text + " Adlı kişinin bilgileri güncellenmiştir...");
                veritabani.gridtumunudoldur(dataGridView1, "select * from Personel");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox4.Text = "";
                checkBox1.Checked=false;
            }
            else
            {
                MessageBox.Show("Güncellemeyi onaylıyorum kısmını işaretlediğinize emin olun!");
            }
            
        }

        private void KullaniciGüncelle_Load(object sender, EventArgs e)
        {
            veritabani.gridtumunudoldur(dataGridView1, "select * from Personel");
            dataGridView1.RowHeadersVisible = false; //en baştaki boş kolonu gizler.
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            label6.Text=dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[5].Value.ToString() == "Kullanıcı")
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            else if(dataGridView1.CurrentRow.Cells[5].Value.ToString() == "Yönetici")
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sqlSorgu = "select * from Personel where Personel like '" + textBox1.Text + "%' order by Personel ASC";
            griddoldur(sqlSorgu);
        }
    }
}
