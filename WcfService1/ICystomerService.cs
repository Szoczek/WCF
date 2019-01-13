using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICystomerService" in both code and config file together.
    [ServiceContract]
    public interface ICystomerService
    {
        [OperationContract]
        ICollection<CustomerDTO> GetCustomers();

        [OperationContract]
        CustomerDTO GetCustomer(string customerID);

        [OperationContract]
        bool AddCustomer(CustomerDTO customer);


    }

    [DataContract]
    public class CustomerDTO
    {
        [DataMember]
        public string CustomerID { get; set; }
        [DataMember]
        public string CompanyName { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string Country { get; set; }
    }
}
