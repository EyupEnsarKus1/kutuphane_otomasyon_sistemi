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
       public static  MySqlConnection GetConnection()
        {
            string sql = "SERVER=172.21.54.3;DATABASE=foursquare;UID=foursquare;password=P16052022!t";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();

            }
            catch (MySqlException excep)
            {
                MessageBox.Show("MySqlConnection!! \n"+excep.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return con;
        }

        public static void addPersonel(String ad,String soyad,String kAdi,String sifre)
        {
            string sql = $"INSERT INTO `personel`( `personel_ad`, `personel_soyad`, `k_adi`, `k_sifre`) VALUES(@personel_ad='{ad}', @personel_soyad='{soyad}', @k_adi='{kAdi}', @k_sifre='{sifre}')";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql,con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@personel_ad", ad);
            cmd.Parameters.AddWithValue("@personel_soyad", soyad);
            cmd.Parameters.AddWithValue("@k_adi", kAdi);
            cmd.Parameters.AddWithValue("@k_sifre", sifre);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Yeni Üye Eklendi");

            }
            catch (Exception)
            {

                MessageBox.Show("Hata Var");
            }
            con.Close();





        }
    }
}
