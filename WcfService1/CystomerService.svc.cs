using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CystomerService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CystomerService.svc or CystomerService.svc.cs at the Solution Explorer and start debugging.
    public class CystomerService : ICystomerService
    {
        public ICollection<CustomerDTO> GetCustomers()
        {
            using (var context = new NorthwindEntities())
            {
                return context.Customers
                    .Select(x => new CustomerDTO
                    {
                        CustomerID = x.CustomerID,
                        Address = x.Address,
                        City = x.City,
                        CompanyName = x.CompanyName,
                        Country = x.Country
                    }).ToArray();
            }
        }

        public CustomerDTO GetCustomer(string customerID)
        {
            using (var context = new NorthwindEntities())
            {

                return context.Customers
                    .Select(x => new CustomerDTO
                    {
                        CustomerID = x.CustomerID,
                        Address = x.Address,
                        City = x.City,
                        CompanyName = x.CompanyName,
                        Country = x.Country
                    }).FirstOrDefault(x => x.CustomerID == customerID);
            }
        }

        public bool AddCustomer(CustomerDTO customer)
        {
            using (var context = new NorthwindEntities())
            {
                try
                {
                    var newCustomer = new Customer
                    {
                        CustomerID = customer.CustomerID,
                        Address = customer.Address,
                        City = customer.City,
                        CompanyName = customer.CompanyName,
                        Country = customer.Country

                    };

                    context.Customers.Add(newCustomer);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    return false;
                }

                return true;
            }
        }
    }
}
