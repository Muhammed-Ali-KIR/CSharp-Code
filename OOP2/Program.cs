using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ALİ KIR
            IndıvidualCustomer customer1 = new IndıvidualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.FirstName = "Ali";
            customer1.LastName = "KIR";
            customer1.TcNo = "4141414141";

            //Kodlama.io
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "123456789";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            Customer customer3=new IndıvidualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager=new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            Console.ReadLine();
        }
    }
}
