﻿using System;
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
        public Uye_form()
        {
            InitializeComponent();
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

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Uye_Kayıt_Form form = new Uye_Kayıt_Form();
            form.ShowDialog();


        }
    }
}
