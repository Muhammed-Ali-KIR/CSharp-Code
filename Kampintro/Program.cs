using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //array-dizi

            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı", "Programlamaya başlangıç kursu", "Java","Python" };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("**** * ****");

            foreach (string kurs  in kurslar)
            {
                Console.WriteLine(kurs);
            }




            Console.ReadLine();
        }
    }
}
