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
    public partial class Kitap_form : Form
    {
        Kitap_Kayıt_Form form; 

        
        public Kitap_form()
        {
            InitializeComponent();
            form = new Kitap_Kayıt_Form(this);
        }
        public void display()
        {
            KitapDatabase.displayAndSearch("SELECT kitap.id,kitap.ad,kitap.tur,kitap.sayfa_sayisi,kitap.barkod_no,kitap.raf,kategori.ad,yazar.ad,yayinevi.ad FROM kitap INNER JOİN  kategori ON kitap.kategori_id=kategori.id INNER JOİN yazar ON kitap.yazar_id = yazar.id INNER JOİN yayinevi ON kitap.yayinevi_id = yayinevi.id", dataGridView);
        }

        private void Kitap_form_Load(object sender, EventArgs e)
        {

            #region yazarekle
            MySqlConnection con = new MySqlConnection("SERVER=172.21.54.3;DATABASE=foursquare;UID=foursquare;password=P16052022!t");
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
            MySqlCommand yayineviCommand = new MySqlCommand("SELECT * FROM yayinevi ORDER BY ad ASC", con);
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

        private void txtKaydet_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            form.clear();
            form.saveInfo();
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

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("SERVER=172.21.54.3;DATABASE=foursquare;UID=foursquare;password=P16052022!t");
            con.Open();
            string sql = "INSERT INTO kitap (ad,tur,sayfa_sayisi,barkod_no,raf,kategori_id,yazar_id,yayinevi_id) VALUES (@ad,@tur,@sayfa_sayisi,@barkod_no,@raf,@kategori_id,@yazar_id,@yayinevi_id)";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@kategori_id", comboKategori.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@yayinevi_id", comboYayinevi.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@yazar_id", comboYazar.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@ad", txtKitapAd.Text);
            cmd.Parameters.AddWithValue("@tur", txtKitapTur.Text);
            cmd.Parameters.AddWithValue("@sayfa_sayisi", txtSayfaSayisi.Text);
            cmd.Parameters.AddWithValue("@barkod_no", txtBarkodNo.Text);
            cmd.Parameters.AddWithValue("@raf", txtBarkod.Text);
            try
            {

                cmd.ExecuteNonQuery();
                MessageBox.Show("Yeni Kitap Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Kitap Ekleme Başarısız" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            display();
        }
    }
}
