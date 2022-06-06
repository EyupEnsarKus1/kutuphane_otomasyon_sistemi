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
    public partial class hakkinda_Form : Form
    {
        public hakkinda_Form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public int Kontrol(string Sorgu)
        {
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=foursquare;UID=foursquare;password=P16052022!t");
            int control;
            baglanti.Open();
            MySqlCommand cmd = new MySqlCommand(Sorgu, baglanti);
            control = Convert.ToInt32(cmd.ExecuteScalar());
            baglanti.Close();
            return control;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UyeDatabase.displayAndSearch("SELECT uye_numara,ad,soyad,cinsiyet,telefon,email FROM uye WHERE uye_numara LIKE '%" + txtOkuyucuAra.Text + "%'", dataGridView2);
            Method.displayAndSearch("SELECT `id`, `odunc_tarih`, `teslim_tarih`, `kitap_id`, `uye_numara`, `teslim_durum` FROM `odunc_alma` WHERE uye_numara LIKE '%" + txtOkuyucuAra.Text + "%'", dataGridView1);

        }

        private void hakkinda_Form_Load(object sender, EventArgs e)
        {

        }

        private void uyeGoster()
        {
            UyeDatabase.displayAndSearch("SELECT uye_numara,ad,soyad,cinsiyet,telefon,email FROM uye", dataGridView2);
        }
        private void emanetListele()
        {
            Method.displayAndSearch("SELECT odunc_alma.id,odunc_alma.odunc_tarih,odunc_alma.teslim_tarih,kitap.ad,odunc_alma.uye_numara,odunc_alma.teslim_durum FROM odunc_alma INNER JOİN kitap ON odunc_alma.kitap_id=kitap.id", dataGridView1);
        }
        private void hakkinda_Form_Shown(object sender, EventArgs e)
        {
            uyeGoster();
            emanetListele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region Öğrenci Silme İşlemi 
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=foursquare;UID=foursquare;password=P16052022!t");
            int kontrolID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            if (Kontrol("SELECT COUNT('') FROM odunc_alma WHERE uye_numara = '" + kontrolID + "'") == 0)
            {
                baglanti.Open();
                MySqlCommand sil = new MySqlCommand("DELETE FROM uye where uye_numara=@uye_numara", baglanti);
                sil.Parameters.AddWithValue("@uye_numara", dataGridView2.CurrentRow.Cells[0].Value.ToString());
                sil.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Öğrenci Başarı İle Silindi.");

                foreach (Control item in Controls)
                {
                    if (item is TextBox & item is MaskedTextBox)
                    {
                        item.Text = null;
                    }
                }
            }
            else
            {
                MessageBox.Show("Öğrenci Emanet Listesinde Bulunduğu İçin Silinemez.");
            }
            uyeGoster();
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM odunc_alma WHERE id = @id";
            MySqlConnection con = Method.GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", dataGridView1.CurrentRow.Cells[0].Value);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Odünç Alma İşlemi Veri Tabanından Silindi");
                emanetListele();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata" + ex.Message);
            }
            con.Close();

        }
    }
}
