using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutuphane_otomasyon_sistemi
{
    public class Personel
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public string k_adi { get; set; }
        public string k_sifre { get; set; }

        public Personel(string ad, string soyad, string k_adi, string k_sifre)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.k_adi = k_adi;
            this.k_sifre = k_sifre;
        }
    }
}
