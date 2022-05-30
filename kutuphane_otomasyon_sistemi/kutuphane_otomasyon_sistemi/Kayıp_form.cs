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
    public partial class Kayıp_form : Form
    {
        public Kayıp_form()
        {
            InitializeComponent();
        }

        public void bookDispaly()
        {
            KitapDatabase.displayAndSearch("SELECT kitap.id,kitap.ad,kitap.tur,kitap.sayfa_sayisi,kitap.barkod_no,kitap.raf,kategori.ad,yazar.ad,yayinevi.ad FROM kitap INNER JOİN  kategori ON kitap.kategori_id=kategori.id INNER JOİN yazar ON kitap.yazar_id = yazar.id INNER JOİN yayinevi ON kitap.yayinevi_id = yayinevi.id", dataGridView1);
        }

        private void Kayıp_form_Load(object sender, EventArgs e)
        {

        }

        private void Kayıp_form_Shown(object sender, EventArgs e)
        {
            bookDispaly();
        }

        private void btnKayipEkle_Click(object sender, EventArgs e)
        {
            MySqlConnection con = Method.GetConnection();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO kayıp (kayıp.kitap_id) VALUES (@kitap_id)",con);
            cmd.Parameters.AddWithValue("@kitap_id", dataGridView1.CurrentRow.Cells[0].Value);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıp Kitap Olarak Belirlendi");
            }
            catch (Exception hata)
            {

                MessageBox.Show("Kayıp kitap tablosuna eklenmedi"+hata.Message);
            }
            con.Close();
        }
    }
}
