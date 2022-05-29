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
        
        private void AnaSayfa_form_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToLongDateString();
        }

       

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Kitap_form frm = new Kitap_form();
            frm.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Kitap_form frm = new Kitap_form();
            frm.Show();
        }
    }
}
