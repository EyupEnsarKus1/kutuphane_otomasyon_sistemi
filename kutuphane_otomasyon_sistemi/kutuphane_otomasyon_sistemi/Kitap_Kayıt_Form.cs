using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane_otomasyon_sistemi
{
    public partial class Kitap_Kayıt_Form : Form
    {
        private readonly Kitap_form _parent;
        public string id, ad, sayfaSayisi, barkodNo, raf, tur, kategori, yazar, yayinevi;

        

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
                Kitap ktp = new Kitap(txtKitapAd.Text, txtKitapTur.Text, txtSayfaSayisi.Text, txtBarkodNo.Text, txtNumara.Text, txtKategori.Text, txtYazar.Text, txtYayinevi.Text);
                KitapDatabase.addBook(ktp);
                clear();
            }
            if (btnKitapEkle.Text == "Güncelle")
            {
                Kitap ktp = new Kitap(txtKitapAd.Text, txtKitapTur.Text, txtSayfaSayisi.Text, txtBarkodNo.Text, txtNumara.Text, txtKategori.Text, txtYazar.Text, txtYayinevi.Text);
                KitapDatabase.updateBook(ktp, id);
            }
            _parent.display();
        }
    }
}
