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
    public partial class Form1 : Form

    {
        Method mtt = new Method();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mtt.kullaniciKontol(combo_uyeler.SelectedItem.ToString(), txt_kSifre.Text) == 1)
            {
                AnaSayfa_form anaSayfa = new AnaSayfa_form();
                anaSayfa.lblKullanici.Text = this.combo_uyeler.SelectedItem.ToString();
                this.Hide();
                anaSayfa.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı", "Giriş Yapılamadı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region ComboBox Uyelerini Cek
            string conStr = "SERVER=172.21.54.3;DATABASE=foursquare;UID=foursquare;password=P16052022!t";
            using(var baglan = new MySqlConnection(conStr))
            {
                using(var komut = new MySqlCommand("SELECT k_adi FROM personel ORDER BY k_adi ASC", baglan))
                {
                    try
                    {
                        komut.Connection.Open();
                        MySqlDataReader dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            combo_uyeler.Items.Add(dr["k_adi"]).ToString();
                        }
                        combo_uyeler.SelectedIndex = 0;

                    }
                    catch (Exception hata)
                    {

                        MessageBox.Show("Hatalı Veri" + hata.Message);
                    }
                }
                
            }
            #endregion
        }
    }
}
