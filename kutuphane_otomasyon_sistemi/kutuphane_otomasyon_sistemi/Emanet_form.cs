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
    public partial class Emanet_form : Form
    {
        public Emanet_form()
        {
            InitializeComponent();
        }

        public void uyeGoster()
        {
            UyeDatabase.displayAndSearch("SELECT uye_numara,ad,soyad,cinsiyet,telefon,email FROM uye", dataGridView1);


        }
        public void kitapGoster()
        {
            KitapDatabase.displayAndSearch("SELECT `id`, `ad`, `tur`, `sayfa_sayisi`, `barkod_no`, `raf`, `kategori_id`, `yazar_id`, `yayinevi_id` FROM `kitap` ", dataGridView2);

        }
        private void Emanet_form_Load(object sender, EventArgs e)
        {


          
        }

        private void Emanet_form_Shown(object sender, EventArgs e)
        {
            uyeGoster();
            kitapGoster();
        }

        private void txtOkuyucuAra_TextChanged(object sender, EventArgs e)
        {
            UyeDatabase.displayAndSearch("SELECT uye_numara,ad,soyad,cinsiyet,telefon,email FROM uye WHERE ad LIKE '%" + txtOkuyucuAra.Text + "%'", dataGridView1);

        }

        private void txtKitapAra_TextChanged(object sender, EventArgs e)
        {
            KitapDatabase.displayAndSearch("SELECT `id`, `ad`, `tur`, `sayfa_sayisi`, `barkod_no`, `raf`, `kategori_id`, `yazar_id`, `yayinevi_id` FROM `kitap` WHERE ad LIKE '%" + txtKitapAra.Text + "%'", dataGridView2);

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex>0)
            {
                DataGridViewRow dgvRow = dataGridView1.Rows[e.RowIndex];
                lblUyeNumara.Text = dgvRow.Cells[0].Value.ToString();
                lblUyeAd.Text = dgvRow.Cells[1].Value.ToString();
                lblUyeSoyad.Text = dgvRow.Cells[2].Value.ToString();
                lblUyeTelefon.Text = dgvRow.Cells[4].Value.ToString();

            }
            
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex > 0)
            {
                DataGridViewRow dgvRow = dataGridView2.Rows[e.RowIndex];
                lblKitapAd.Text = dgvRow.Cells[1].Value.ToString();
                lblYazar.Text = dgvRow.Cells[7].Value.ToString();
                lblYayinevi.Text = dgvRow.Cells[8].Value.ToString();
                lblKategori.Text = dgvRow.Cells[6].Value.ToString();
                lblSayfaSayisi.Text = dgvRow.Cells[3].Value.ToString();

            }
        }
    }
}
