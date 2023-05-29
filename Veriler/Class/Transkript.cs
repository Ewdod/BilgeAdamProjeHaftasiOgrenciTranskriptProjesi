using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veriler.Class
{
    public class Transkript
    {
        public Transkript(Ogrenci ogrenci)
        {
            Ogrenci = ogrenci;
            
        }
        public Ogrenci Ogrenci { get; set; }
        public List<Dersler> dersler { get; set; } 

    }
}
