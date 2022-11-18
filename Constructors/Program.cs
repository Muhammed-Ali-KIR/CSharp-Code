using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {Id=1,FirstName="Muhammed",LastName="KIR",City="Kocaeli"};
            Customer customer2 = new Customer ( 2, "Engin", "Demiroğ", "Ankara" );

            Console.WriteLine(customer1.Id);
            Console.WriteLine(customer1.FirstName);
            Console.WriteLine(customer1.LastName);
            Console.WriteLine(customer1.City);
            Console.ReadLine();
        }
    }
    class Customer
    {
        //default constructor
        public Customer()
        {

        }
        public Customer(int id,string firstName,string lastName,string city) //Constructor
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
