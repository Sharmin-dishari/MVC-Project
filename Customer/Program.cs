using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nexus.BLL.BLL;
using Nexus.Model.Model;

namespace CustomerUI
{
    class Program
    {
        public static void Main(string[] args)
        {
            CustomerManager _customerManager = new CustomerManager();
            Customer customer = new Customer()
            {
               Code=0001,
               Name="Sharmin",
               Address="Khilgaon",
               Contact="01714200070",
               Email="sharminakter@gmail.com",
               LoyalityPoint=0
          
            };
            //Add
            //if (_customerManager.Add(customer))
            //{
            //    Console.WriteLine(value:"Saved");
            //}
            //else
            //{
            //    Console.WriteLine(value:"Not Saved");
            //}

            //Delete
            //if (_studentManager.Delete(1))
            //{
            //    Console.WriteLine("Deleted");
            //}
            //else
            //{
            //    Console.WriteLine("Not Deleted");
            //}

            //Update
            customer.Id = 4;
            customer.Name = "Md Yusuf";
            customer.Contact = "003";
            customer.Address = "Mohakhali";
            customer.Email = "easin@gmail";


            if (_customerManager.Update(customer))
            {
                Console.WriteLine("Updated");
            }
            else
            {
                Console.WriteLine("Not Updated");
            }

            //var  students = _studentManager.GetAll();
            //var astudent = _studentManager.GetById(4);

            Console.ReadKey();
        }
    }
}
