﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeRefereansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int,decimal,float,double,bool=değer tip
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);
            //sayi1=? sayi1=30 olur.

            Console.WriteLine("*********");

            // array,class,interface=referans tip alır.
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);
            //sayilar1[0]=?? sayilar[0]=999 olur

            
            
            Console.Read();
        }
    }
}
