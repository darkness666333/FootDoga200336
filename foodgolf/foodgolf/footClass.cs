using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foodgolf
{
    class footClass
    {
        public String nev { get; set; }
        public bool kategoria{ get; set; }
        public String egyesulet { get; set; }
        public int szazalek { get; set; }
        public int pontok { get; set; }
        public footClass(string s)
        {
            var d = s.Split(';');
            nev = d[0];
            kategoria = d[1] == "Felnott ferfi";
            egyesulet = d[2];
            pontok = int.Parse(d[3]); int.Parse(d[4]); int.Parse(d[4]);
            int.Parse(d[5]); int.Parse(d[6]); int.Parse(d[7]); int.Parse(d[8]); int.Parse(d[9]);
        }
    }
}
