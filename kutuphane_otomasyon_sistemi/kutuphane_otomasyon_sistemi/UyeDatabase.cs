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
    class UyeDatabase
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
        public static void addMember(Uye uye,TextBox txtBox)
        {
            string sql = "INSERT INTO uye VALUES (@uye_numara,@ad,@soyad,@cinsiyet,@telefon,@email)";
            MySqlConnection con = GetConnection();
            MySqlCommand chk = new MySqlCommand("select uye_numara from uye where uye_numara='" + txtBox.Text + "'", con);
            string ktg = (string)chk.ExecuteScalar();
            if (ktg == txtBox.Text)
            {
                MessageBox.Show("Üye Zaten Var.");
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@uye_numara", MySqlDbType.VarChar).Value = uye.uye_numara;
                cmd.Parameters.Add("@ad", MySqlDbType.VarChar).Value = uye.ad;
                cmd.Parameters.Add("@soyad", MySqlDbType.VarChar).Value = uye.soyad;
                cmd.Parameters.Add("@cinsiyet", MySqlDbType.VarChar).Value = uye.cinsiyet;
                cmd.Parameters.Add("@telefon", MySqlDbType.VarChar).Value = uye.telefon;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = uye.email;
                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Yeni Üye Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Üye Ekleme Başarısız" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
            
            con.Close();
        }
        public static void updateMember(Uye uye, string id)
        {
            string sql = "UPDATE uye SET ad=@ad, soyad=@soyad,cinsiyet=@cinsiyet,telefon=@telefon, email=@email WHERE uye_numara=@uye_numara";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@uye_numara", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@ad", MySqlDbType.VarChar).Value = uye.ad;
            cmd.Parameters.Add("@soyad", MySqlDbType.VarChar).Value = uye.soyad;
            cmd.Parameters.Add("@cinsiyet", MySqlDbType.VarChar).Value = uye.cinsiyet;
            cmd.Parameters.Add("telefon", MySqlDbType.VarChar).Value = uye.telefon;
            cmd.Parameters.Add("email", MySqlDbType.VarChar).Value = uye.email;

            try
            {

                cmd.ExecuteNonQuery();
                MessageBox.Show("Üye Bilgileri Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Üye Güncelleme Başarısız" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }
        public static void deleteMember(string id)
        {
            string sql = "DELETE FROM uye WHERE uye_numara=@uye_numara";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@uye_numara", MySqlDbType.VarChar).Value = id;
            try
            {

                cmd.ExecuteNonQuery();
                MessageBox.Show("Üye Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Üye Silinirken Hata" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
