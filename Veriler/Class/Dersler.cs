using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veriler.Enum;

namespace Veriler.Class
{
    public class Dersler 
    {
        

        public Dersler(string dersAdi , int kredi, Donem donemi)
        {
            DersAdi = dersAdi;
            Kredi = kredi;
            Donemi = donemi;
            OgrenciDersleri = new List<Dersler>();
        }
        //List<Dersler> TumDersler = new List<Dersler>();
        public List<Dersler> OgrenciDersleri { get; set; }
        public string DersAdi { get; set; }
        public int Kredi { get; set; }
        public Donem Donemi { get; set; }
        //public override string ToString()
        //{
        //    return ($"Ders Adi: {DersAdi} , Kredi Degeri: {Kredi}, Donemi: {Donemi}");
        //}



    }
}
