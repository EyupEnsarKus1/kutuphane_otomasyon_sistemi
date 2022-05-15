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
    public partial class Personel_form : Form
    {
        personel_Kayıt_Form form; 

        
        public Personel_form()
        {
            InitializeComponent();
            form = new personel_Kayıt_Form(this);
           
        }
        
        MySqlConnection connection = new MySqlConnection("SERVER=172.21.54.3;DATABASE=foursquare;UID=foursquare;password=P16052022!t");

        private void Personel_form_Load(object sender, EventArgs e)
        {
           
            txtSifre.Text = "";
            txtSifre.PasswordChar = '*';
            txtSifre.MaxLength = 10;
        }   

        public void clear()
        {
            txtAd.Text = txtSoyad.Text = txtKadi.Text = txtSifre.Text = String.Empty;
        }

        public void display()
        {
            Database.displayAndSearch("SELECT personel_id, personel_ad, personel_soyad, k_adi,k_sifre FROM personel",dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            form.clear();
            form.saveInfo();
            form.ShowDialog();
        }

        private void Personel_form_Shown(object sender, EventArgs e)
        {
            display();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Database.displayAndSearch("SELECT personel_id, personel_ad, personel_soyad, k_adi,k_sifre FROM personel WHERE personel_ad LIKE '%"+txtSearch.Text+"%'", dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==0)
            {

                // Düzenleme İşlemi
                form.clear();
                form.id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.ad = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.soyad = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.kullaniciAdi = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.sifre = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.updateInfo();
                form.ShowDialog();

                return;
            }
            if (e.ColumnIndex==1)
            {
                //Silme İşlemi
                if (MessageBox.Show("Seçilen Personeli Silmek istediginize emin misiniz!!", "Bilgilendirme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)==DialogResult.Yes)
                {
                    Database.deletePersonel(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    display();
                }
                return;
             
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
