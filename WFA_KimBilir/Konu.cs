using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_KimBilir
{
    public class Konu
    {

        public string KonuAdi { get; set; }

        public static List<Konu> konuListesi = new List<Konu>()
        {new Konu{KonuAdi="If/Else"},
         new Konu{KonuAdi="Switch Case"},
         new Konu{KonuAdi="While"},
         new Konu{KonuAdi="DoWhile"},
         new Konu{KonuAdi="For"},
         new Konu{KonuAdi="Arrays"},
         new Konu{KonuAdi="Foreach"},
         new Konu{KonuAdi="Runtime"},
         new Konu{KonuAdi="Methods"},
         new Konu{KonuAdi="Encapsulation"},
         new Konu{KonuAdi="Inheritance"},
         new Konu{KonuAdi="Polymorphism"},
         new Konu{KonuAdi="Abstraction"},
         new Konu{KonuAdi="Enum"},
         new Konu{KonuAdi="Interface"},
        };

        public override string ToString()
        {
            return KonuAdi;
        }
    }
}
