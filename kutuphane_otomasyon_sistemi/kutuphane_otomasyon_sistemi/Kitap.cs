using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutuphane_otomasyon_sistemi
{
    public class Kitap
    {
        public string ad { get; set; }
        public string tur { get; set; }
        public string sayfa_sayisi { get; set; }
        public string barkod_no { get; set; }
        public string raf { get; set; }
        public string kategori_ad{ get; set; }
        
        public string yazar_ad{ get; set; }
        public string yayinevi_ad { get; set; }

        public Kitap(string ad, string tur, string sayfa_sayisi, string barkod_no, string raf, string kategori_ad, string yazar_ad, string yayinevi_ad)
        {
            this.ad = ad;
            this.tur = tur;
            this.sayfa_sayisi = sayfa_sayisi;
            this.barkod_no = barkod_no;
            this.raf = raf;
            this.kategori_ad = kategori_ad;
            this.yazar_ad = yazar_ad;
            this.yayinevi_ad = yayinevi_ad;
        }

    }
}
