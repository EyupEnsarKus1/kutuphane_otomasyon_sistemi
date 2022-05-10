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
        private Form activeForm;
        public AnaSayfa_form()
        {
            InitializeComponent();
        }
        public void  loadForm (Form childForm, object btnSender)
        {
           if(activeForm!= null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(childForm);
            this.mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

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

       

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kitapButton_Click(object sender, EventArgs e)
        {
            loadForm(new Kitap_form(),sender);
           
            
        }

        private void uyeButton_Click(object sender, EventArgs e)
        {
            loadForm(new Uye_form(),sender);
        }

        private void emanetButton_Click(object sender, EventArgs e)
        {
            loadForm(new Emanet_form(),sender);
        }

        private void personelButton_Click(object sender, EventArgs e)
        {
            loadForm(new Personel_form(),sender);
        }

        private void kayipButton_Click(object sender, EventArgs e)
        {
            loadForm(new Kayıp_form(),sender);
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void statisticButton_Click(object sender, EventArgs e)
        {
            loadForm(new istatistik_Form(), sender);
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            loadForm(new hakkinda_Form(), sender);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loadForm(new odunc_Form(), sender);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
