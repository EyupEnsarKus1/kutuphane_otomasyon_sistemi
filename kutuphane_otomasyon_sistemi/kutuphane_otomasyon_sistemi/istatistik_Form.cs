using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace kutuphane_otomasyon_sistemi
{
    public partial class istatistik_Form : Form
    {
        public istatistik_Form()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void istatistik_Form_Load(object sender, EventArgs e)
        {
            MySqlConnection con = Method.GetConnection();

            #region toplamKitap

            MySqlCommand cmd1 = new MySqlCommand("SELECT COUNT() FROM kitap", con);
            MySqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                lblKtp.Text = dr1[0].ToString();

            }
            con.Close();
            #endregion
            #region toplamÜye
            con.Open();
            MySqlCommand cmd2 = new MySqlCommand("SELECT COUNT() FROM uye", con);
            MySqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                lblUye.Text = dr2[0].ToString();

            }
            con.Close();

            #endregion
            #region AktifEmanet
            con.Open();
            MySqlCommand cmd3 = new MySqlCommand("SELECT COUNT() FROM odunc_alma WHERE teslim_durum='Teslim Edilmedi'", con);
            MySqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                lblEmnt.Text = dr3[0].ToString();
            }
            con.Close();
            #endregion
            #region yazarSayısı
            con.Open();
            MySqlCommand cmd4 = new MySqlCommand("SELECT COUNT() FROM yazar", con);
            MySqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                lblYzr.Text = dr4[0].ToString();
            }
            con.Close();
            #endregion
            #region kategoriSayısı
            con.Open();
            MySqlCommand cmd5 = new MySqlCommand("SELECT COUNT() FROM kategori", con);
            MySqlDataReader dr5 = cmd5.ExecuteReader();
            while (dr5.Read())
            {
                lblKtgri.Text = dr5[0].ToString();
            }
            con.Close();
            #endregion
            #region yayıneviSayısı
            con.Open();
            MySqlCommand cmd6 = new MySqlCommand("SELECT COUNT() FROM yayinevi", con);
            MySqlDataReader dr6 = cmd6.ExecuteReader();
            while (dr6.Read())
            {
                lblYyn.Text = dr6[0].ToString();
            }
            con.Close();
            #endregion
            #region enCokKitapOkuyan
            con.Open();
            MySqlCommand cmd8 = new MySqlCommand("SELECT CONCAT(uye.ad,' ',uye.soyad), COUNT(uye.uye_numara) FROM odunc_alma INNER JOIN uye ON odunc_alma.uye_numara = uye.uye_numara GROUP BY uye.uye_numara LIMIT 20 ", con);
            MySqlDataReader dr8 = cmd8.ExecuteReader();
            while (dr8.Read())
            {
                lblOkuyucu.Text = dr8[0].ToString();
            }
            con.Close();
            #endregion
            #region enCokOkunanKitap
            con.Open();
            MySqlCommand cmd7 = new MySqlCommand("SELECT kitap.ad,COUNT(kitap.ad) FROM odunc_alma INNER JOIN kitap ON odunc_alma.kitap_id = kitap.id GROUP BY odunc_alma.kitap_id ORDER BY COUNT(kitap.ad) DESC LIMIT 20", con);
            MySqlDataReader dr7 = cmd7.ExecuteReader();
            while (dr7.Read())
            {
                lblKitap.Text = dr7[0].ToString();
            }
            #endregion

        }
    }
}
