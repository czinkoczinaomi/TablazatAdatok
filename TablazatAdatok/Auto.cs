using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablazatAdatok
{
    class Auto
    {
        public string Nev { get; set; }
        public string Szin { get; set; }
        public string Gyarto { get; set; }


        public Auto(string nev, string szin, string gyarto)
        {
            this.Nev = nev;
            this.Szin = szin;
            this.Gyarto = gyarto;
        }
       
    }
}
