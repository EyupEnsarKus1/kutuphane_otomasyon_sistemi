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
    public partial class Uye_form : Form
    {
        public Uye_form()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("SERVER=172.21.54.3;DATABASE=foursquare;UID=foursquare;password=P16052022!t");

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void ekle_button_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO `uye`(`okul_numara`, `ad`, `soyad`, `cinsiyet`, `telefon`, `email`) VALUES (@okul_numara,@ad,@soyad,@cinsiyet,@telefon,@email)", connection);
            command.Parameters.AddWithValue("@okul_numara",txtNumara.Text);
            command.Parameters.AddWithValue("@ad",txtAd.Text);
            command.Parameters.AddWithValue("@soyad",txtSoyad.Text);
            command.Parameters.AddWithValue("@cinsiyet",comboCinsiyet.Text);
            command.Parameters.AddWithValue("@telefon",txtTelefon.Text);
            command.Parameters.AddWithValue("@email",txtEmail.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Yeni Üye Eklendi");
        }

        private void Uye_form_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
