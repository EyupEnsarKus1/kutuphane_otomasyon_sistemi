using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace kutuphane_otomasyon_sistemi
{
     public class Method
    {
        string conStr = "SERVER=172.21.54.3;DATABASE=foursquare;UID=foursquare;password=P16052022!t";

        #region Kullanıcı Kontrol
        public int kullaniciKontol(string kAdi,string kSifre)
        {
            int sonuc = 0;
            using(var connection = new MySqlConnection(conStr))
            {
                using(var command = new MySqlCommand($"SELECT k_adi,k_sifre FROM personel WHERE k_adi='{kAdi}' AND k_sifre='{kSifre}'", connection))
                {
                    try
                    {
                        command.Connection.Open();
                        MySqlDataReader dtr = command.ExecuteReader();
                        if (dtr.Read())
                        {
                            string d_k = dtr["k_adi"].ToString();
                            string d_s = dtr["k_sifre"].ToString();
                            if(d_k==kAdi && d_s == kSifre)
                            {
                                sonuc = 1;
                            }
                            else
                            {
                                sonuc = 0;
                            }

                        }

                    }
                    catch 
                    {

                        sonuc=  0;
                    }
                }
            }






            return sonuc;
        }
        #endregion


    }
}
