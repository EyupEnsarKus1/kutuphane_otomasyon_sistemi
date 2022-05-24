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
    public partial class Kitap_form : Form
    {
        Kitap_Kayıt_Form form; 

        
        public Kitap_form()
        {
            InitializeComponent();
            form = new kitap_Kayıt_Form(this);
        }
        public void display()
        {
            KitapDatabase.displayAndSearch("SELECT `id`, `ad`, `tur`, `sayfa_sayisi`, `barkod_no`, `raf`, `kategori_id`, `yazar_id`, `yayinevi_id` FROM `kitap` ", dataGridView);
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Kitap_form_Load(object sender, EventArgs e)
        {

        }

        private void txtKaydet_Click(object sender, EventArgs e)
        {
            //MySqlCommand command = new MySqlCommand("INSERT INTO `kitap`(`ad`, `tur`, `sayfa_sayisi`, `barkod_no`, `raf`, `kategori_id`, `yazar_id`, `yayınevi_id`) VALUES (@kitapadi, @)
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.SaveInfo();
            form.ShowDialog();

        }

        private void Kitap_form_Shown(object sender, EventArgs e)
        {
            display();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            KitapDatabase.displayAndSearch("SELECT `id`, `ad`, `tur`, `sayfa_sayisi`, `barkod_no`, `raf`, `kategori_id`, `yazar_id`, `yayinevi_id` FROM `kitap` WHERE ad LIKE '%" + txtSearch.Text + "%'", dataGridView);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                form.clear();
                form.id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.ad = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.tur = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.sayfaSayisi = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.barkodNo = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.raf = dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.kategori = dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                form.yazar = dataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
                form.yayinevi = dataGridView.Rows[e.RowIndex].Cells[10].Value.ToString();
                form.updateInfo();
                form.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Kitabı Silmek İstediğinizden Emin miniz", "Bilgilendirme", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    KitapDatabase.deleteBook(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    display();
                }
                return;
            }
        }
    }
}
