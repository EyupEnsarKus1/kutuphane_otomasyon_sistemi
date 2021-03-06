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
    public partial class personel_Kayıt_Form : Form
    {

        private readonly Personel_form _parent;
        public string id, ad, soyad, kullaniciAdi,sifre;
        public personel_Kayıt_Form(Personel_form parent )
        {
            InitializeComponent();
            _parent = parent;
        }
        public void updateInfo()
        {
            lblHead.Text = "Bilgileri Güncelle";
            btnEkle.Text = "Güncelle";
            txtAd.Text = ad;
            txtSoyad.Text = soyad;
            txtKadi.Text = kullaniciAdi;
            txtSifre.Text = sifre;
        }

        private void lblHead_Click(object sender, EventArgs e)
        {

        }

        public void saveInfo()
        {
            lblHead.Text = "Personel Ekle";
            btnEkle.Text = "Ekle";
        }
        public void clear()
        {
            txtAd.Text = txtSoyad.Text = txtKadi.Text = txtSifre.Text = string.Empty;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(txtAd.Text.Trim().Length <= 0 )
            {
                MessageBox.Show("Adı Boş Bırakmayınız");
                return;

            }
            if(txtSoyad.Text.Trim().Length <=0)
            {
                MessageBox.Show("Boş Bırakmayınız");
                return;
            }
            if (txtKadi.Text.Trim().Length < 5)
            {
                MessageBox.Show("Personel kullanıcı adı 5 TEN BÜYÜK OLMALI");
                return;
            }
            if (txtSifre.Text.Trim().Length < 8)
            {
                MessageBox.Show("Personel şifre adı 8 denTEN BÜYÜK OLMALI");
                return;
            }
            if (btnEkle.Text == "Ekle")
            {
                Personel prsn = new Personel(txtAd.Text.Trim(),txtSoyad.Text.Trim(),txtKadi.Text.Trim(),txtSifre.Text.Trim());
                Database.addPersonel(prsn);
                clear();
            
            }
            if(btnEkle.Text == "Güncelle")
            {
                Personel prsn = new Personel(txtAd.Text.Trim(), txtSoyad.Text.Trim(), txtKadi.Text.Trim(), txtSifre.Text.Trim());
                Database.updatePersonel(prsn,id);
            }

            _parent.display();

        }

        private void personel_Kayıt_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
