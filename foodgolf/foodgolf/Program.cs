using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foodgolf
{
    class Program
    {
        static List<footClass> versenyzok;
        static void Main(string[] args)
        {
            Beolvas();
            feladat3();
            feladat4();
            Console.ReadKey();
        }

        

        private static void feladat4()
        {
            var sz = versenyzok.Count(f => !f.kategoria && f.szazalek == 100);
            Console.WriteLine($"4.feladat: {sz}");
        }

        private static void feladat3()
        {
            Console.WriteLine($"3.feladat: {versenyzok.Count}");
        }

        private static void Beolvas()
        {
            versenyzok = new List<footClass>();
            var sr = new StreamReader(@"C:\Users\Merci\source\repos\foodgolf\fob2016.txt", Encoding.UTF8);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                versenyzok.Add(new footClass(sr.ReadLine()));
            }
            sr.Close();
        }
    }
}
