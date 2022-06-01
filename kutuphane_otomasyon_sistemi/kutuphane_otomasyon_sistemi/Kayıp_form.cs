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

        public void kayipListele()
        {
            Method.displayAndSearch("SELECT kayip.id,kitap.ad,kayip.kayipdurum FROM kayip INNER JOİN kitap ON  kayip.kitap_id=kitap.id ",dataGridView2);
        }

        private void Kayıp_form_Load(object sender, EventArgs e)
        {

        }

        private void Kayıp_form_Shown(object sender, EventArgs e)
        {
            bookDispaly();
            kayipListele();
        }

        private void btnKayipEkle_Click(object sender, EventArgs e)
        {
            MySqlConnection con = Method.GetConnection();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO kayip (kayip.kitap_id) VALUES (@kitap_id)",con);
            cmd.Parameters.AddWithValue("@kitap_id", dataGridView1.CurrentRow.Cells[0].Value);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıp Kitap Olarak Belirlendi");
                kayipListele();
            }
            catch (Exception hata)
            {

                MessageBox.Show("Kayıp kitap tablosuna eklenmedi"+hata.Message);
            }
            con.Close();
        }

        private void btnDurumDuzelt_Click(object sender, EventArgs e)
        {
            MySqlConnection con = Method.GetConnection();
            string sorgu = "UPDATE kayip SET kayipdurum='Kitap Bulundu' WHERE id =@id";
            MySqlCommand command = new MySqlCommand(sorgu, con);
            command.Parameters.AddWithValue("@id", dataGridView2.CurrentRow.Cells[0].Value);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Kitap Bulundu");
                kayipListele();
            }
            catch (Exception msj)
            {
                MessageBox.Show("Kitap geri alma başarısız " + msj.Message);

            }
            con.Close();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM kayip WHERE id = @id";
            MySqlConnection con = Method.GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", dataGridView2.CurrentRow.Cells[0].Value);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıp Kitap Veri Tabanından Silindi");
                kayipListele();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata" + ex.Message);
            }
            con.Close();
        }

        private void txtKitapAra_TextChanged(object sender, EventArgs e)
        {
            Method.displayAndSearch("SELECT `id`, `ad`, `tur`, `sayfa_sayisi`, `barkod_no`, `raf`, `kategori_id`, `yazar_id`, `yayinevi_id` FROM `kitap` WHERE ad LIKE '%" + txtKitapAra.Text + "%'", dataGridView1);

        }
    }
}
