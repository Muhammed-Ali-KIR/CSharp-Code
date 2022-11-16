using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class SepetManager
    {   
        //naming convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine(urun.Adi+" "+ "Sepete eklendi!");
        }

        //Hatalı kullanım-Aşağıdaki gibi parametre verirsek herhangi bir değişiklik yapmak gerektiğinde program.cs de tüm kodları değiştirmemiz gerekir
        //public void Ekle2(string UrunAdi,double fiyat,string aciklama,int stokAdedi)
        //{
        //    Console.WriteLine(UrunAdi + " " + "Sepete eklendi!");
        //}
    }
}
