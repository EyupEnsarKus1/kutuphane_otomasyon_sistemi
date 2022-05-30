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
        }
    }
}
