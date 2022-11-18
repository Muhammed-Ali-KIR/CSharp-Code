using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //tüzel müşteri
    internal class CorporateCustomer:Customer 
        
       
    {       
        public string CompanyName { get; set; } //Company:şirket

        public string TaxNo { get; set; } //Tax:vergi

    }
}
