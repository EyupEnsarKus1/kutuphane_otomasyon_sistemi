using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kutuphane_otomasyon_sistemi
{
    class KitapDatabase
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "SERVER=172.21.54.3;DATABASE=foursquare;UID=foursquare;password=P16052022!t";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();

            }
            catch (MySqlException excep)
            {
                MessageBox.Show("MySqlConnection!! \n" + excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }
        public static void addBook(Kitap ktp)
        {
            string sql = "INSERT INTO kitap VALUES (NULL,@ad,@tur,@sayfa_sayisi,@barkod_no,@raf,@kategori_id,@yazar_id,@yayınevi_id)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ad", MySqlDbType.VarChar).Value = ktp.ad;
            cmd.Parameters.Add("@tur", MySqlDbType.VarChar).Value = ktp.tur;
            cmd.Parameters.Add("@sayfa_sayisi", MySqlDbType.Int32).Value = ktp.sayfa_sayisi;
            cmd.Parameters.Add("@barkod_no", MySqlDbType.VarChar).Value = ktp.barkod_no;
            cmd.Parameters.Add("@raf", MySqlDbType.VarChar).Value = ktp.raf;
            cmd.Parameters.Add("@kategori_id", MySqlDbType.Int32).Value = ktp.kategori_id;
            cmd.Parameters.Add("@yazar_id", MySqlDbType.Int32).Value = ktp.yazar_id;
            cmd.Parameters.Add("@yayınevi_id", MySqlDbType.Int32).Value = ktp.yayınevi_id;
            try
            {

                cmd.ExecuteNonQuery();
                MessageBox.Show("Yeni Kitap Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Kitap Ekleme Başarısız" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void updateKitap(Kitap ktp, string id)
        {
            string sql = "UPDATE kitap SET ad=@ad, tur=@tur, sayfa_sayisi=@sayfa_sayisi, barkod_no=@barkod_no, raf=@raf, kategori_id=@kategori_id, yazar_id=@yazar_id, yayınevi_id=@yayınevi_id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@kitap_id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@ad", MySqlDbType.VarChar).Value = ktp.ad;
            cmd.Parameters.Add("@tur", MySqlDbType.VarChar).Value = ktp.tur;
            cmd.Parameters.Add("@sayfa_sayisi", MySqlDbType.VarChar).Value = ktp.sayfa_sayisi;
            cmd.Parameters.Add("@barkod_no", MySqlDbType.VarChar).Value = ktp.barkod_no;
            cmd.Parameters.Add("@raf", MySqlDbType.VarChar).Value = ktp.raf;
            cmd.Parameters.Add("@kategori_id", MySqlDbType.VarChar).Value = ktp.kategori_id;
            cmd.Parameters.Add("@yazar_id", MySqlDbType.VarChar).Value = ktp.yazar_id;
            cmd.Parameters.Add("@yayınevi_id", MySqlDbType.VarChar).Value = ktp.yayınevi_id;
            try
            {

                cmd.ExecuteNonQuery();
                MessageBox.Show("Kitap Bilgileri Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Kitap Güncelleme Başarısız" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    }  
}
