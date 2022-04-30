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
        public void  loadForm (object Form)
        {
            if (this.mainPanel.Controls.Count > 0) this.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
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
            loadForm(new Kitap_form());
        }

        private void uyeButton_Click(object sender, EventArgs e)
        {
            loadForm(new Uye_form());
        }

        private void emanetButton_Click(object sender, EventArgs e)
        {
            loadForm(new Emanet_form());
        }
    }
}
