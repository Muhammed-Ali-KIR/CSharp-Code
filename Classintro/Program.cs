using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classintro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.İzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C++";
            kurs2.Egitmen = "Muhammed Ali";
            kurs2.İzlenmeOrani = 36;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "Kerem Varış";
            kurs3.İzlenmeOrani = 64;

            Console.WriteLine(kurs1.KursAdi + ": " + kurs1.Egitmen + " " + kurs1.İzlenmeOrani);
            Console.WriteLine(kurs2.KursAdi + ": " + kurs2.Egitmen + " " + kurs2.İzlenmeOrani);
            Console.WriteLine(kurs3.KursAdi + ": " + kurs3.Egitmen + " " + kurs3.İzlenmeOrani);

            Console.WriteLine("**************");

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+": "+kurs.Egitmen+" "+kurs.İzlenmeOrani);
            }

            Console.ReadLine();
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }
    }
}
