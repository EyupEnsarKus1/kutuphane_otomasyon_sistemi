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
    public partial class Kitap_Kayıt_Form : Form
    {
        private readonly Kitap_form _parent;
        public string id, ad, sayfaSayisi, barkodNo, raf, tur, kategori, yazar, yayinevi;

        private void Kitap_Kayıt_Form_Load(object sender, EventArgs e)
        {
            #region yazarekle
            MySqlConnection con =   new MySqlConnection("SERVER=172.21.54.3;DATABASE=foursquare;UID=foursquare;password=P16052022!t");
            con.Open();
            MySqlCommand yzrCommand = new MySqlCommand("SELECT * FROM yazar ORDER BY ad ASC", con);
            MySqlDataAdapter cYazar = new MySqlDataAdapter(yzrCommand);
            DataSet dYazar = new DataSet();
            cYazar.Fill(dYazar);
            yzrCommand.ExecuteNonQuery();
            con.Close();
            comboYazar.DataSource = dYazar.Tables[0];
            comboYazar.DisplayMember = "ad";
            comboYazar.ValueMember = "id";
            #endregion
            #region  kategoriEkle
            con.Open();
            MySqlCommand ktgrCommand = new MySqlCommand("SELECT * FROM kategori ORDER BY ad ASC", con);
            MySqlDataAdapter cKtgr = new MySqlDataAdapter(ktgrCommand);
            DataSet dKtgr = new DataSet();
            cKtgr.Fill(dKtgr);
            ktgrCommand.ExecuteNonQuery();
            con.Close();
            comboKategori.DataSource = dKtgr.Tables[0];
            comboKategori.DisplayMember = "ad";
            comboKategori.ValueMember = "id";
            #endregion
            #region yayineviEkle
            con.Open();
            MySqlCommand yayineviCommand = new MySqlCommand("SELECT * FROM kategori ORDER BY ad ASC", con);
            MySqlDataAdapter cYyn = new MySqlDataAdapter(yayineviCommand);
            DataSet dYyn = new DataSet();
            cYyn.Fill(dYyn);
            yayineviCommand.ExecuteNonQuery();
            con.Close();
            comboYayinevi.DataSource = dYyn.Tables[0];
            comboYayinevi.DisplayMember = "ad";
            comboYayinevi.ValueMember = "id";

            #endregion

        }

        public Kitap_Kayıt_Form(Kitap_form parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void updateInfo()
        {
            lblHead.Text = "Güncelle";
            btnKitapEkle.Text = "Güncelle";
            txtKitapAd.Text = ad;
            txtBarkodNo.Text = barkodNo;
            txtKategori.Text = kategori;
            txtKitapTur.Text = tur;
            txtSayfaSayisi.Text = sayfaSayisi;
            txtYazar.Text = yazar;
            txtYayinevi.Text = yayinevi;
            txtNumara.Text = raf;


        }
        public void saveInfo()
        {
            lblHead.Text = "Ekle";
            btnKitapEkle.Text = "Ekle";
        }
        public void clear()
        {
            txtKitapAd.Text = txtBarkodNo.Text = txtKategori.Text = txtKitapTur.Text = txtYazar.Text = txtSayfaSayisi.Text = txtNumara.Text = txtYayinevi.Text = string.Empty;
        }
        private void label4_Click(object sender, EventArgs e)
        {
            
        }
        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            if (btnKitapEkle.Text == "Ekle")
            {
                Kitap ktp = new Kitap(txtKitapAd.Text, txtKitapTur.Text, txtSayfaSayisi.Text, txtBarkodNo.Text, txtNumara.Text);
                KitapDatabase.addBook(ktp,comboYazar,comboKategori,comboYayinevi);
                clear();
            }
            if (btnKitapEkle.Text == "Güncelle")
            {
               // Kitap ktp = new Kitap(txtKitapAd.Text, txtKitapTur.Text, txtSayfaSayisi.Text, txtBarkodNo.Text, txtNumara.Text, txtKategori.Text, txtYazar.Text, txtYayinevi.Text);
               // KitapDatabase.updateBook(ktp, id);
            }
            _parent.display();
        }
    }
}
