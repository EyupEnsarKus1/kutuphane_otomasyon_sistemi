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
    public class Database
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


        public static void addPersonel(Personel prsn)
        {
            string sql = "INSERT INTO personel VALUES (NULL,@personel_ad,@personel_soyad,@k_adi,@k_sifre)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@personel_ad", MySqlDbType.VarChar).Value = prsn.ad;
            cmd.Parameters.Add("@personel_soyad", MySqlDbType.VarChar).Value = prsn.soyad;
            cmd.Parameters.Add("@k_adi", MySqlDbType.VarChar).Value = prsn.k_adi;
            cmd.Parameters.Add("@k_sifre", MySqlDbType.VarChar).Value = prsn.k_sifre;
            try
            {

                cmd.ExecuteNonQuery();
                MessageBox.Show("Yeni Personel Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Personel Ekleme Başarısız" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void updatePersonel(Personel prsn, string id)
        {
            string sql = "UPDATE personel SET personel_ad=@personel_ad, personel_soyad=@personel_soyad,k_adi=@k_adi,k_sifre=@k_sifre WHERE personel_id=@personel_id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@personel_id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@personel_ad", MySqlDbType.VarChar).Value = prsn.ad;
            cmd.Parameters.Add("@personel_soyad", MySqlDbType.VarChar).Value = prsn.soyad;
            cmd.Parameters.Add("@k_adi", MySqlDbType.VarChar).Value = prsn.k_adi;
            cmd.Parameters.Add("@k_sifre", MySqlDbType.VarChar).Value = prsn.k_sifre;
            try
            {

                cmd.ExecuteNonQuery();
                MessageBox.Show("Personel Bilgileri Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Personel Güncelleme Başarısız" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    

        public static void deletePersonel(string id)
        {
            string sql = "DELETE FROM personel WHERE personel_id =@personel_id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@personel_id", MySqlDbType.VarChar).Value = id;
            try
            {

                cmd.ExecuteNonQuery();
                MessageBox.Show("Personel Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Personel Silinirken Hata" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


