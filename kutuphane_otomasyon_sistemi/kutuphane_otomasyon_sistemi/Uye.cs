using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutuphane_otomasyon_sistemi
{
    public class Uye
    {
        public string uye_numara { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string cinsiyet { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }

        public Uye(string uye_numara, string ad, string soyad, string cinsiyet, string telefon, string email)
        {
            this.uye_numara = uye_numara;
            this.ad = ad;
            this.soyad = soyad;
            this.cinsiyet = cinsiyet;
            this.telefon = telefon;
            this.email = email;

        }



    }
}

