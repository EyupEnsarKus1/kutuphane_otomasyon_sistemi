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
            KitapDatabase.displayAndSearch("SELECT kitap.id,kitap.ad,kitap.tur,kitap.sayfa_sayisi,kitap.barkod_no,kitap.raf,kitap.basim_yili,kategori.ad,yazar.ad,yayinevi.ad FROM kitap INNER JOİN  kategori ON kitap.kategori_id=kategori.id INNER JOİN yazar ON kitap.yazar_id = yazar.id INNER JOİN yayinevi ON kitap.yayinevi_id = yayinevi.id", dataGridView);
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
            KitapDatabase.displayAndSearch("SELECT kitap.id,kitap.ad,kitap.tur,kitap.sayfa_sayisi,kitap.barkod_no,kitap.raf,kitap.basim_yili,kategori.ad,yazar.ad,yayinevi.ad FROM kitap INNER JOİN  kategori ON kitap.kategori_id=kategori.id INNER JOİN yazar ON kitap.yazar_id = yazar.id INNER JOİN yayinevi ON kitap.yayinevi_id = yayinevi.id WHERE kitap.ad LIKE '%" + txtSearch.Text + "%'", dataGridView);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgvRow = dataGridView.Rows[e.RowIndex];
                txtKitapAd.Text = dgvRow.Cells[1].Value.ToString();
                txtSayfaSayisi.Text = dgvRow.Cells[3].Value.ToString();
                txtKitapTur.Text = dgvRow.Cells[2].Value.ToString();
                txtDemirBasNo.Text = dgvRow.Cells[5].Value.ToString();
                comboYayinevi.Text = dgvRow.Cells[9].Value.ToString();
                comboYazar.Text = dgvRow.Cells[8].Value.ToString();
                comboKategori.Text = dgvRow.Cells[7].Value.ToString();
                txtBarkodNo.Text = dgvRow.Cells[4].Value.ToString();
                txtBasimYili.Text = dgvRow.Cells[6].Value.ToString();
            }
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("SERVER=172.21.54.3;DATABASE=foursquare;UID=foursquare;password=P16052022!t");
            con.Open();
            string sql = "INSERT INTO kitap (ad,tur,sayfa_sayisi,barkod_no,raf,basim_yili,kategori_id,yazar_id,yayinevi_id) VALUES (@ad,@tur,@sayfa_sayisi,@barkod_no,@raf,@basim_yili,@kategori_id,@yazar_id,@yayinevi_id)";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@kategori_id", comboKategori.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@yayinevi_id", comboYayinevi.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@yazar_id", comboYazar.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@ad", txtKitapAd.Text);
            cmd.Parameters.AddWithValue("@tur", txtKitapTur.Text);
            cmd.Parameters.AddWithValue("@sayfa_sayisi", txtSayfaSayisi.Text);
            cmd.Parameters.AddWithValue("@basim_yili",txtBasimYili.Text);
            cmd.Parameters.AddWithValue("@barkod_no", txtBarkodNo.Text);
            cmd.Parameters.AddWithValue("@raf", txtDemirBasNo.Text);
            try
            {
                if(String.IsNullOrEmpty(txtKitapAd.Text) || String.IsNullOrEmpty(txtKitapTur.Text) || String.IsNullOrEmpty(txtSayfaSayisi.Text) || String.IsNullOrEmpty(txtBasimYili.Text) || String.IsNullOrEmpty(txtBarkodNo.Text) || String.IsNullOrEmpty(txtDemirBasNo.Text))
                {
                    MessageBox.Show("Lütfen Bütün Alanları Doldurduğunuzdan Emin Olun", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                }
                else
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Yeni Kitap Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtKitapAd.Text = txtKitapTur.Text = txtSayfaSayisi.Text = txtBasimYili.Text = txtBarkodNo.Text = txtDemirBasNo.Text = string.Empty;
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show("Kitap Ekleme Başarısız" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            display();
        }

        private void btnYazarEkle_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("SERVER=172.21.54.3;DATABASE=foursquare;UID=foursquare;password=P16052022!t");
            con.Open();
            string sql = "INSERT INTO `yazar`(`ad`) VALUES (@ad)";
            MySqlCommand cmd = new MySqlCommand(sql,con);
            cmd.Parameters.AddWithValue("@ad", txtYazarEkle.Text);
            try
            {
                if (String.IsNullOrEmpty(txtYazarEkle.Text))
                {
                    MessageBox.Show("Lütfen yazar adı giriniz.");
                } else
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Yeni Yazar Eklendi");
                    txtYazarEkle.Text = "";
                }
               

            }
            catch (Exception msj)
            {

                MessageBox.Show("Yazar Ekleme Başarısız"+msj.Message);
            }
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("SERVER=172.21.54.3;DATABASE=foursquare;UID=foursquare;password=P16052022!t");
            con.Open();
            string sql = "INSERT INTO `kategori`(`ad`) VALUES (@ad)";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ad", txtKategoriEkle.Text);
            try
            {
                if (String.IsNullOrEmpty(txtKategoriEkle.Text))
                {
                    MessageBox.Show("Lütfen kategori giriniz.");
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Yeni Kategori Eklendi");
                    txtKategoriEkle.Text = "";
                }

            }
            catch (Exception msj)
            {

                MessageBox.Show("Kategori Ekleme Başarısız" + msj.Message);
            }

        }

        private void btnYayineviEkle_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("SERVER=172.21.54.3;DATABASE=foursquare;UID=foursquare;password=P16052022!t");
            con.Open();
            string sql = "INSERT INTO `yayinevi`(`ad`) VALUES (@ad)";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ad", txtYayineviEkle.Text);
            try
            {
                if (String.IsNullOrEmpty(txtYayineviEkle.Text))
                {
                    MessageBox.Show("Lütfen Yayınevi giriniz.");
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Yeni Yayınevi Eklendi");
                    txtYayineviEkle.Text = "";
                }

            }
            catch (Exception msj)
            {

                MessageBox.Show("Yayınevi Ekleme Başarısız" + msj.Message);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtYazarAdiAra_TextChanged(object sender, EventArgs e)
        {
            Method.displayAndSearch("SELECT kitap.id,kitap.ad,kitap.tur,kitap.sayfa_sayisi,kitap.barkod_no,kitap.raf,kitap.basim_yili,kategori.ad,yazar.ad,yayinevi.ad FROM kitap INNER JOİN  kategori ON kitap.kategori_id=kategori.id INNER JOİN yazar ON kitap.yazar_id = yazar.id INNER JOİN yayinevi ON kitap.yayinevi_id = yayinevi.id WHERE yazar.ad LIKE '%" + txtYazarAdiAra.Text + "%'", dataGridView);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM kitap WHERE id =@id";
            MySqlConnection con = Method.GetConnection();
           
            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", dataGridView.CurrentRow.Cells[0].Value);
            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Kitap Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                display();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Kitap Silinirken Hata" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE kitap SET tur=@tur,sayfa_sayisi=@sayfa_sayisi,basim_yili=@basim_yili,barkod_no=@barkod_no,raf=@raf,kategori_id=@kategori_id,yazar_id=@yazar_id,yayinevi_id=@yayinevi_id WHERE ad=@ad";
            MySqlConnection con = Method.GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ad", txtKitapAd.Text);
            cmd.Parameters.AddWithValue("@sayfa_sayisi", txtSayfaSayisi.Text);
            cmd.Parameters.AddWithValue("@tur", txtKitapTur.Text);
            cmd.Parameters.AddWithValue("@basim_yili", txtBasimYili.Text);
            cmd.Parameters.AddWithValue("@yayinevi_id", comboYayinevi.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@yazar_id", comboYazar.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@kategori_id", comboKategori.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@raf", txtDemirBasNo.Text);
            cmd.Parameters.AddWithValue("@barkod_no", txtBarkodNo.Text);
            try
            {

                cmd.ExecuteNonQuery();
                MessageBox.Show("Kitap Bilgileri Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                display();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Kitap Güncelleme Başarısız" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    }
}
