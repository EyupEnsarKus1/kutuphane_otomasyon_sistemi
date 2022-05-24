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
        private static int getLastInsertedId(MySqlConnection baglanti)
        {

            MySqlCommand lastInsertedIdCmd = new MySqlCommand("SELECT LAST_INSERT_ID();", baglanti);
            var lastInsertedIdValue = lastInsertedIdCmd.ExecuteScalar().ToString();
            return int.Parse(lastInsertedIdValue);

        }

        public static void addBook(Kitap ktp)
        {


            MySqlConnection con = GetConnection();

            MySqlCommand yazar = new MySqlCommand("INSERT INTO yazar (ad) values (@ad)", con);
            yazar.Parameters.Add("@ad", MySqlDbType.VarChar).Value = ktp.yazar_ad;
            yazar.ExecuteNonQuery();
            int lastInsertedYazarIdValue = getLastInsertedId(con);


            MySqlCommand kategori = new MySqlCommand("insert into kategori (ad) values (@ad)", con);
            kategori.Parameters.Add("@ad", MySqlDbType.VarChar).Value = ktp.kategori_ad;
            kategori.ExecuteNonQuery();
            int lastInsertedKategoriId = getLastInsertedId(con);

            MySqlCommand yayin = new MySqlCommand("insert into yayinevi (ad) values (@ad)", con);
            yayin.Parameters.Add("@ad", MySqlDbType.VarChar).Value = ktp.yayinevi_ad;
            yayin.ExecuteNonQuery();
            int lastInsertedYayinEviId = getLastInsertedId(con);


            string sql = "INSERT INTO kitap VALUES (NULL,@ad,@tur,@sayfa_sayisi,@barkod_no,@raf,@kategori_id,@yazar_id,@yayinevi_id)";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@kategori_id", lastInsertedKategoriId);
            cmd.Parameters.AddWithValue("@yayinevi_id", lastInsertedYayinEviId);
            cmd.Parameters.AddWithValue("@yazar_id", lastInsertedYazarIdValue);
            cmd.Parameters.Add("@ad", MySqlDbType.VarChar).Value = ktp.ad;
            cmd.Parameters.Add("@tur", MySqlDbType.VarChar).Value = ktp.tur;
            cmd.Parameters.Add("@sayfa_sayisi", MySqlDbType.VarChar).Value = ktp.sayfa_sayisi;
            cmd.Parameters.Add("@barkod_no", MySqlDbType.VarChar).Value = ktp.barkod_no;
            cmd.Parameters.Add("@raf", MySqlDbType.VarChar).Value = ktp.raf;
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
        public static void updateBook(Kitap ktp, string id)
        {
            string sql = "UPDATE kitap SET ad=@ad, tur=@tur, sayfa_sayisi=@sayfa_sayisi, barkod_no=@barkod_no, raf=@raf, kategori_id=@kategori_id, yazar_id=@yazar_id, yayinevi_id=@yayınevi_id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@ad", MySqlDbType.VarChar).Value = ktp.ad;
            cmd.Parameters.Add("@tur", MySqlDbType.VarChar).Value = ktp.tur;
            cmd.Parameters.Add("@sayfa_sayisi", MySqlDbType.Int32).Value = ktp.sayfa_sayisi;
            cmd.Parameters.Add("@barkod_no", MySqlDbType.VarChar).Value = ktp.barkod_no;
            cmd.Parameters.Add("@raf", MySqlDbType.VarChar).Value = ktp.raf;
            cmd.Parameters.Add("@kategori_id", MySqlDbType.VarChar).Value = ktp.kategori_ad;
            cmd.Parameters.Add("@yazar_id", MySqlDbType.VarChar).Value = ktp.yazar_ad;
            cmd.Parameters.Add("@yayınevi_id", MySqlDbType.VarChar).Value = ktp.yayinevi_ad;
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
        public static void deleteBook(string id)
        {
            string sql = "DELETE FROM kitap WHERE id =@id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            try
            {

                cmd.ExecuteNonQuery();
                MessageBox.Show("Kitap Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Kitap Silinirken Hata" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void displayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }
    }
}
