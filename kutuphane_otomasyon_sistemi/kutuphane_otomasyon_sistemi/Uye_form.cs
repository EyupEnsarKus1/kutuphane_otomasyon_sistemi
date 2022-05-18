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
    public partial class Uye_form : Form
    {
        Uye_Kayıt_Form form; 
        public Uye_form()
        {
            InitializeComponent();
            form = new Uye_Kayıt_Form(this);
        }
       
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void ekle_button_Click(object sender, EventArgs e)
        {
           
        }

        private void Uye_form_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
        public void display()
        {
            UyeDatabase.displayAndSearch("SELECT uye_numara,ad,soyad,cinsiyet,telefon,email FROM uye", dataGridView);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            form.clear();
            form.saveInfo();
            form.ShowDialog();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Uye_form_Shown(object sender, EventArgs e)
        {
            display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            UyeDatabase.displayAndSearch("SELECT uye_numara,ad,soyad,cinsiyet,telefon,email FROM uye WHERE ad LIKE '%"+txtSearch.Text+"%'", dataGridView);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                form.clear();
                form.uye_numara = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.ad = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.soyad = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.cinsiyet = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();

                form.telefon = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.email = dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.updateInfo();
                form.ShowDialog();
                return;

            }
            if(e.ColumnIndex == 1)
            {
                //Silme İşlemi
                if (MessageBox.Show("Seçilen Üyeyi Silmek istediginize emin misiniz!!", "Bilgilendirme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    UyeDatabase.deleteMember(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    display();
                }
                return;

            }

                
            }
        }
    }

