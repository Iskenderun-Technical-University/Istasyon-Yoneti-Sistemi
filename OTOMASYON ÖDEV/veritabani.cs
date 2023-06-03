using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Security.Cryptography;


namespace OTOMASYON_ÖDEV
{
    class veritabani
    {
        veritabani()
        {

        }

        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataAdapter da;
        static SqlDataReader dr;
        static DataSet ds;

        public static string baglanti = "Data Source = localhost\\SQLEXPRESS;Initial Catalog=TrenOtomasyonu;Integrated Security=True";

        public static bool loginKontrol(string kullaniciAdi, string sifre)
        {
            string sorgu = "select * from Personel where Personel=@user and Sifre=@password";
            con = new SqlConnection(baglanti);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", kullaniciAdi);
            cmd.Parameters.AddWithValue("@password", veritabani.MD5Sifreleme(sifre));
            con.Open();
            dr = cmd.ExecuteReader();
            //kullanıcı adı ve şifre dogru girildiyse veri gelir.eger veri gelirse
            if (dr.Read())
            {
                // MessageBox.Show("Tebrikler Başarılı Giriş Yaptınız...");
                return true;
                con.Close();
            }
            else
            {
                // MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı !!!");
                return false;
                con.Close();

            }
            con.Close();
        }

        public static DataGridView gridtumunudoldur(DataGridView gridim, string sqlSelectSorgu)
        {
            con = new SqlConnection(baglanti);
            ds = new DataSet();
            da = new SqlDataAdapter(sqlSelectSorgu, con);
            con.Open();
            da.Fill(ds, sqlSelectSorgu);
            gridim.DataSource = ds.Tables[sqlSelectSorgu];
            con.Close();

            return gridim;
        }


        public static string MD5Sifreleme(string sifrelenecekMetin)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            // encoding kütüphanesi kullanılarak şifrenin türkçe karakterleri algılamasını sağlar.
            Byte[] dizi = Encoding.UTF8.GetBytes(sifrelenecekMetin);

            //bütün şifrelemeler bir hash üzerinden gider 
            //burada dizinin hash değeri çıkarılıyor.

            dizi = md5.ComputeHash(dizi);

            StringBuilder sb = new StringBuilder();
            foreach (byte item in dizi)
                //küçük karakterlere dönüştürülür.
                //x2 md5 sifrelemede 2 erli 2 erli alır.
                sb.Append(item.ToString("x2").ToLower());

            return sb.ToString();
        }

        public static void KomutYolla(string islem, SqlCommand cmd)
        {
            con = new SqlConnection(baglanti);
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = islem;
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public static void KomutYollaParametreli(string islem, SqlCommand cmd)
        {
            con = new SqlConnection(baglanti);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = islem;
            cmd.ExecuteNonQuery();
            con.Close();

        }


    }

}
