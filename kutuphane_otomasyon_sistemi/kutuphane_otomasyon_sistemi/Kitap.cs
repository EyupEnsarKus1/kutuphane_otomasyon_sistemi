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
        public int sayfa_sayisi { get; set; }
        public string barkod_no { get; set; }
        public string raf { get; set; }
        public int kategori_id { get; set; }
        
        public int yazar_id { get; set; }
        public int yayınevi_id { get; set; }

        public Kitap(string ad, string tur, int sayfa_sayisi, string barkod_no, string raf, int kategori_id, int yazar_id, int yayınevi_id)
        {
            this.ad = ad;
            this.tur = tur;
            this.sayfa_sayisi = sayfa_sayisi;
            this.barkod_no = barkod_no;
            this.raf = raf;
            this.kategori_id = kategori_id;
            this.yazar_id = yazar_id;
            this.yayınevi_id = yayınevi_id;
        }

    }
}
