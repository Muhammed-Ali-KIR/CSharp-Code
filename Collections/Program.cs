using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{         //Koleksiyonlar
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            Console.WriteLine("**********");
            isimler = new string[5];    //Bu şekilde yaparsak dizinin adresi değişir ve elemenları sıfırlanır.
            isimler[4] = "İlker";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);

            Console.WriteLine("*******************");

            List<string> isimler2=new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);
            Console.ReadLine();
        }
    }
}
