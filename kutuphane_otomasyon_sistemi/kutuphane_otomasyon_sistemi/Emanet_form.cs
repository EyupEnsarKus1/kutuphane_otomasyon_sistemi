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
    public partial class Emanet_form : Form
    {
        public Emanet_form()
        {
            InitializeComponent();
        }
        public static MySqlConnection GetConnection()
        {
            string sql = "SERVER=172.21.54.3;DATABASE=foursquare;UID=foursquare;password=P16052022!t";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();

            }
            catch (MySqlException excep)
            {
                MessageBox.Show("MySqlConnection!! \n" + excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        public void uyeGoster()
        {
            UyeDatabase.displayAndSearch("SELECT uye_numara,ad,soyad,cinsiyet,telefon,email FROM uye", dataGridView1);


        }
        public void kitapGoster()
        {
            KitapDatabase.displayAndSearch("SELECT kitap.id,kitap.ad,kitap.tur,kitap.sayfa_sayisi,kitap.barkod_no,kitap.raf,kategori.ad,yazar.ad,yayinevi.ad FROM kitap INNER JOİN  kategori ON kitap.kategori_id=kategori.id INNER JOİN yazar ON kitap.yazar_id = yazar.id INNER JOİN yayinevi ON kitap.yayinevi_id = yayinevi.id", dataGridView2);

        }
        private void Emanet_form_Load(object sender, EventArgs e)
        {
            MySqlConnection con = GetConnection();
            string sqlQueryUye = "SELECT uye_numara  FROM uye ORDER BY uye_numara ASC";
            MySqlCommand sqlComamndUye = new MySqlCommand(sqlQueryUye,con);
            MySqlDataAdapter sdrUye = new MySqlDataAdapter(sqlComamndUye);
            DataTable dt = new DataTable();
            sdrUye.Fill(dt);
            comboOkuyucu.DisplayMember = "uye_numara";
            comboOkuyucu.ValueMember = "uye_numara";
            comboOkuyucu.DataSource = dt;
            dataGridView1.DataSource = dt;
            comboOkuyucu.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboOkuyucu.AutoCompleteSource = AutoCompleteSource.ListItems;
            con.Close();

            con.Open();
            string sqlquery = "SELECT * FROM kitap ORDER BY id ASC";
            MySqlCommand sqlComamndKitap = new MySqlCommand(sqlquery, con);
            MySqlDataAdapter sdrKitap = new MySqlDataAdapter(sqlComamndKitap);
            DataTable dtKitap = new DataTable();
            sdrKitap.Fill(dtKitap);
            comboKitap.DisplayMember = "ad";
            comboKitap.ValueMember = "id";
            comboKitap.DataSource = dtKitap;
            dataGridView2.DataSource = dtKitap;
            comboKitap.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboKitap.AutoCompleteSource = AutoCompleteSource.ListItems;
            con.Close();










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
            if(e.RowIndex >=-1)
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
            if(e.RowIndex >=-1  )
            {
                DataGridViewRow dgvRow = dataGridView2.Rows[e.RowIndex];
                lblKitapAd.Text = dgvRow.Cells[1].Value.ToString();
                lblYazar.Text = dgvRow.Cells[7].Value.ToString();
                lblYayinevi.Text = dgvRow.Cells[8].Value.ToString();
                lblKategori.Text = dgvRow.Cells[6].Value.ToString();
                lblSayfaSayisi.Text = dgvRow.Cells[3].Value.ToString();

            }
        }



        private void button1_Click(object sender, EventArgs e)
        {


            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `odunc_alma`(`odunc_tarih`, `teslim_tarih`, `kitap_id`, `uye_numara`) VALUES (@odunc_tarih,@teslim_tarih,@kitap_id,@uye_numara)", con);
            cmd.Parameters.AddWithValue("@odunc_tarih", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@teslim_tarih", dateTimePicker2.Text);
            cmd.Parameters.AddWithValue("@kitap_id", dataGridView2.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@uye_numara",dataGridView1.CurrentRow.Cells[0].Value);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Emanet Verme İşelmi Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception msg )
            {

                MessageBox.Show("Emanet Verme İşlemi Başarısız\n"+ msg.Message);
            }

            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
