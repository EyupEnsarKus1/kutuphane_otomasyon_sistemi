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
    public partial class AnaSayfa_form : Form
    {
        public AnaSayfa_form()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AnaSayfa_form_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Uye_form uyeForm = new Uye_form();
            uyeForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Emanet_form emanetForm = new Emanet_form();
            emanetForm.Show();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Kitap_form kitapForm = new Kitap_form();
            kitapForm.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Personel_form personelForm = new Personel_form();
            personelForm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Kayıp_form kayıpForm = new Kayıp_form();
            kayıpForm.Show();
        }
    }
}
