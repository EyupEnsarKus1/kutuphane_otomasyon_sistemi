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
    public partial class personel_Login : Form
    {
        public personel_Login()
        {
            InitializeComponent();
        }
        Method mtt = new Method();

        private void personel_Login_Load(object sender, EventArgs e)
        {
            txt_kSifre.Text = "";
            txt_kSifre.PasswordChar = '*';
            txt_kSifre.MaxLength = 10;
            #region ComboBox Uyelerini Cek
            string conStr = "SERVER=172.21.54.3;DATABASE=foursquare;UID=foursquare;password=P16052022!t";
            using (var baglan = new MySqlConnection(conStr))
            {
                using (var komut = new MySqlCommand("SELECT k_adi FROM personel ORDER BY k_adi ASC", baglan))
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (mtt.kullaniciKontol(combo_uyeler.SelectedItem.ToString(), txt_kSifre.Text) == 1)
            {
                Personel_form personel = new Personel_form();
                this.Hide();
                personel.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı", "Giriş Yapılamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
