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
    public partial class odunc_Form : Form
    {
        public odunc_Form()
        {
            InitializeComponent();
        }

        private void emanetListele() {
            Method.displayAndSearch("SELECT odunc_alma.id,odunc_alma.odunc_tarih,odunc_alma.teslim_tarih,kitap.ad,odunc_alma.uye_numara,odunc_alma.teslim_durum FROM odunc_alma INNER JOİN kitap ON odunc_alma.kitap_id=kitap.id",dataGridView1);
        }

        private void odunc_Form_Shown(object sender, EventArgs e)
        {
            emanetListele();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            Method.displayAndSearch("SELECT `id`, `odunc_tarih`, `teslim_tarih`, `kitap_id`, `uye_numara`, `teslim_durum` FROM `odunc_alma` WHERE uye_numara LIKE '%"+txtAra.Text+"%'", dataGridView1);
        }

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            MySqlConnection con = Method.GetConnection();
            string sorgu = "UPDATE odunc_alma SET teslim_durum='Teslim Edildi' WHERE id =@id";
            MySqlCommand command = new MySqlCommand(sorgu, con);
            command.Parameters.AddWithValue("@id",dataGridView1.CurrentRow.Cells[0].Value);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Teslim İşlemi Başarılı");
                emanetListele();
            }
            catch (Exception msj )
            {
                MessageBox.Show("Teslim İşlemi Başarısız"+msj.Message);
              
            }
            con.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           
            
        }

        private void odunc_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM odunc_alma WHERE id = @id";
            MySqlConnection con = Method.GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql,con);
            cmd.Parameters.AddWithValue("id",dataGridView1.CurrentRow.Cells[0].Value);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Odünç Alma İşlemi Veri Tabanından Silindi");
                emanetListele();

            }
            catch (Exception ex )
            {

                MessageBox.Show("Hata"+ex.Message);
            }
            con.Close();
        }
    }
}
