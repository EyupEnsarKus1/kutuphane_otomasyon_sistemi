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
    public partial class Personel_form : Form
    {
        Database method = new Database();
        public Personel_form()
        {
            InitializeComponent();
        }
        
        MySqlConnection connection = new MySqlConnection("SERVER=172.21.54.3;DATABASE=foursquare;UID=foursquare;password=P16052022!t");

        private void Personel_form_Load(object sender, EventArgs e)
        {
            txtSifre.Text = "";
            txtSifre.PasswordChar = '*';
            txtSifre.MaxLength = 10;
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            #region
            connection.Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO `personel`( `personel_ad`, `personel_soyad`, `k_adi`, `k_sifre`) VALUES (@personel_ad,@personel_soyad,@k_adi,@k_sifre)",connection);
            command.Parameters.AddWithValue("@personel_ad",txtAd.Text);
            command.Parameters.AddWithValue("@personel_soyad",txtSoyad.Text);
            command.Parameters.AddWithValue("@k_adi",txtKadi.Text);
            command.Parameters.AddWithValue("@k_sifre",txtSifre.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("YENİ PERSONEL EKLENDİ");
            #endregion*/
            Database.addPersonel(txtAd.Text, txtSoyad.Text, txtKadi.Text, txtSifre.Text);




        }
    }
}
