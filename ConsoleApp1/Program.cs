using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.ServiceReference1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var proxy = new CystomerServiceClient();

            var result = proxy.GetCustomers();

            foreach (var item in result)
            {
                Console.WriteLine($"{item?.CompanyName} \n {item?.Address}");
            }
                Console.ReadKey();

            var customer = proxy.GetCustomer("CENTC");
            Console.WriteLine(customer?.CompanyName);
            Console.ReadKey();

            var newCustomer = new CustomerDTO
            {
                CustomerID = "1245",
                CompanyName = "ATH",
                City = "Bielsko_Biala",
                Country = "Poland"
            };

            Console.WriteLine(proxy.AddCustomer(newCustomer));
            Console.ReadKey();
        }
    }
}
