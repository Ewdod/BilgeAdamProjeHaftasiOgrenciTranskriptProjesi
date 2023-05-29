using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veriler.Class
{
    public class Ogrenci
    {
        public List<Ogrenci> Ogrenciler = new List<Ogrenci>();
        public Ogrenci(string ad, string soyad, List<Dersler> dersler, int kacDonem)
        {
            
            Ad = ad;
            Soyad = soyad;
            KacDonem = kacDonem;
            OgrenciDersleri = dersler;
            OgrenciListesi = new List<Ogrenci>();
            Ogrenciler.AddRange(OgrenciListesi);
        }

        public static List<Ogrenci> OgrenciListesi { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public List<Dersler> OgrenciDersleri { get; set; }
        public int KacDonem { get; set;}

        public override string ToString()
        {
            return ($"{Ad}, {Soyad}, {Ogrenciler} , {KacDonem}");
        }




    }
}
