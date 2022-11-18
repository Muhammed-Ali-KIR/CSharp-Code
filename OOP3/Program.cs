using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IkrediManager ihtiyacKrediManager = new IhtiyacKrediManager();           
            IkrediManager tasitKrediManager = new TasitKrediManager();           
            IkrediManager konutKrediManager = new KonutKrediManager();
            
            ILoggerService databaseLoggerService=new DatabaseLoggerService();
            ILoggerService fileLoggerService =new FilebaseLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseLoggerService);
            Console.WriteLine();
            basvuruManager.BasvuruYap(tasitKrediManager , fileLoggerService);
            Console.WriteLine();
            basvuruManager.BasvuruYap(konutKrediManager, databaseLoggerService);
            Console.WriteLine();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new SmsLoggerService());

            Console.WriteLine("***************************");

            List<IkrediManager> krediler = new List<IkrediManager>() { ihtiyacKrediManager, tasitKrediManager };


            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            Console.ReadLine();
        }
    }
}
