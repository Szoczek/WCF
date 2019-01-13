﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp1.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomerDTO", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class CustomerDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CustomerIDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CompanyName {
            get {
                return this.CompanyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyNameField, value) != true)) {
                    this.CompanyNameField = value;
                    this.RaisePropertyChanged("CompanyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Country {
            get {
                return this.CountryField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryField, value) != true)) {
                    this.CountryField = value;
                    this.RaisePropertyChanged("Country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomerID {
            get {
                return this.CustomerIDField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerIDField, value) != true)) {
                    this.CustomerIDField = value;
                    this.RaisePropertyChanged("CustomerID");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ICystomerService")]
    public interface ICystomerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICystomerService/GetCustomers", ReplyAction="http://tempuri.org/ICystomerService/GetCustomersResponse")]
        ConsoleApp1.ServiceReference1.CustomerDTO[] GetCustomers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICystomerService/GetCustomers", ReplyAction="http://tempuri.org/ICystomerService/GetCustomersResponse")]
        System.Threading.Tasks.Task<ConsoleApp1.ServiceReference1.CustomerDTO[]> GetCustomersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICystomerService/GetCustomer", ReplyAction="http://tempuri.org/ICystomerService/GetCustomerResponse")]
        ConsoleApp1.ServiceReference1.CustomerDTO GetCustomer(string customerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICystomerService/GetCustomer", ReplyAction="http://tempuri.org/ICystomerService/GetCustomerResponse")]
        System.Threading.Tasks.Task<ConsoleApp1.ServiceReference1.CustomerDTO> GetCustomerAsync(string customerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICystomerService/AddCustomer", ReplyAction="http://tempuri.org/ICystomerService/AddCustomerResponse")]
        bool AddCustomer(ConsoleApp1.ServiceReference1.CustomerDTO customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICystomerService/AddCustomer", ReplyAction="http://tempuri.org/ICystomerService/AddCustomerResponse")]
        System.Threading.Tasks.Task<bool> AddCustomerAsync(ConsoleApp1.ServiceReference1.CustomerDTO customer);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICystomerServiceChannel : ConsoleApp1.ServiceReference1.ICystomerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CystomerServiceClient : System.ServiceModel.ClientBase<ConsoleApp1.ServiceReference1.ICystomerService>, ConsoleApp1.ServiceReference1.ICystomerService {
        
        public CystomerServiceClient() {
        }
        
        public CystomerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CystomerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CystomerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CystomerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ConsoleApp1.ServiceReference1.CustomerDTO[] GetCustomers() {
            return base.Channel.GetCustomers();
        }
        
        public System.Threading.Tasks.Task<ConsoleApp1.ServiceReference1.CustomerDTO[]> GetCustomersAsync() {
            return base.Channel.GetCustomersAsync();
        }
        
        public ConsoleApp1.ServiceReference1.CustomerDTO GetCustomer(string customerID) {
            return base.Channel.GetCustomer(customerID);
        }
        
        public System.Threading.Tasks.Task<ConsoleApp1.ServiceReference1.CustomerDTO> GetCustomerAsync(string customerID) {
            return base.Channel.GetCustomerAsync(customerID);
        }
        
        public bool AddCustomer(ConsoleApp1.ServiceReference1.CustomerDTO customer) {
            return base.Channel.AddCustomer(customer);
        }
        
        public System.Threading.Tasks.Task<bool> AddCustomerAsync(ConsoleApp1.ServiceReference1.CustomerDTO customer) {
            return base.Channel.AddCustomerAsync(customer);
        }
    }
}