using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_KimBilir
{
    public class Sinif
    {
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public int Puan { get; set; }

        public static List<Sinif> SinifList = new List<Sinif>()
        {
            new Sinif{Ad="Mert",Soyad="Atalay",Puan=0},
            new Sinif{Ad="Azad",Soyad="Majidli", Puan = 0},
            new Sinif{Ad="Umut",Soyad="Yilbas",Puan=0},
            new Sinif{Ad="Sila",Soyad="Sirin",Puan=0},
            new Sinif{Ad="Saruhan Mert",Soyad="Demiray",Puan=0},
            new Sinif{Ad="Onur",Soyad="Dogru", Puan = 0},
            new Sinif{Ad="Emre",Soyad="Bektasoglu", Puan = 0},
            new Sinif{Ad="Enes",Soyad="Serenli",Puan=0},
            new Sinif{Ad="Furkan",Soyad="Gunes",Puan=0},
            new Sinif{Ad="Bahadir",Soyad="Arda",Puan=0},
            new Sinif{Ad="Burak",Soyad="Uysal", Puan = 0},
            new Sinif{Ad="Caner",Soyad="Tatli",Puan=0},
            new Sinif{Ad="Tuba",Soyad="Karadut Bugday",Puan=0},
            new Sinif{Ad="Mahmure",Soyad="Okan",Puan=0 },
            new Sinif{Ad="Arya",Soyad="Kapikiran", Puan = 0},
            new Sinif{Ad="Berk",Soyad="Basat",Puan=0}
        };
        public override string ToString()
        {
            return Ad + " "  +Soyad;

        }

    }
}
