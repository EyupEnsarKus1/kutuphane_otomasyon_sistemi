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
    public partial class Uye_Kayıt_Form : Form
    {
        private readonly Uye_form _parent;

        public string uye_numara, ad, soyad,cinsiyet, telefon, email;
        public Uye_Kayıt_Form(Uye_form parent )
        {
            InitializeComponent();
            _parent = parent;
        }
        public void updateInfo()
        {
            lblHead.Text = "Güncelle";
            btnEkle.Text = "Güncelle";
            txtUyeNumara.Text = uye_numara;
            txtAd.Text = ad;
            txtSoyad.Text = soyad;
            comboCinsiyet.Text = cinsiyet;
            txtTelefon.Text = telefon;
            txtEMail.Text = email;

        }
        public void saveInfo()
        {
            lblHead.Text = "Ekle";
            btnEkle.Text = "Ekle";
        }
        public void clear()
        {
            txtAd.Text = txtSoyad.Text = txtTelefon.Text = txtEMail.Text  = txtUyeNumara.Text = comboCinsiyet.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Uye_Kayıt_Form_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
        
            if (txtUyeNumara.Text.Trim().Length< 9)
            {
                MessageBox.Show("Uye Numara 10 haneden buyuk olmaldır");
                return;
            }
           if(txtAd.Text.Trim().Length < 1)
            {
                MessageBox.Show("Ad 1 haften kucuk olamaz");
                return;
            }
            if (txtSoyad.Text.Trim().Length < 1)
            {
                MessageBox.Show("SoyadAd 1 haften kucuk olamaz");
                return;
            }
            if(comboCinsiyet.Text == "")
            {
                MessageBox.Show("Lütfen Cinsiyet Seçiniz");
                return;
            }
            if (txtTelefon.Text.Trim().Length < 10)
            {
                MessageBox.Show("Telefon Numarasını Doğru Girdiginden Emin Ol");
                return;
            }
            if (txtEMail.Text.Trim().Length < 5)
            {
                MessageBox.Show("Email Doğru Girdiginden Emin Ol");
                return;
            }
            if (btnEkle.Text == "Ekle")
            {
                Uye uye = new Uye(txtUyeNumara.Text.Trim(), txtAd.Text.Trim(), txtSoyad.Text.Trim(), comboCinsiyet.Text.Trim(), txtTelefon.Text.Trim(), txtEMail.Text.Trim());
                UyeDatabase.addMember(uye);
                clear();
            }
            if(btnEkle.Text == "Güncelle")
            {
                Uye uye = new Uye(txtUyeNumara.Text.Trim(), txtAd.Text.Trim(), txtSoyad.Text.Trim(), comboCinsiyet.Text.Trim(), txtTelefon.Text.Trim(), txtEMail.Text.Trim());
                UyeDatabase.updateMember(uye,uye_numara);
            }
            _parent.display();
        }
    }
}
