using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affarssystemet.Models
{
    public class Customer
    {
        public Guid? id { get; private set; }
        public int customerNumber { get; set; }
        public string customerName { get; set; }
        public string streetAddress { get; set; }
        public string zipcode { get; set; }
        public string town { get; set; }

        public Customer() { }
        [JsonConstructor]
        public Customer(string _customerName, string _streetAddress, string _zipcode, string _town, int _customerNumber=0, Guid? _id = null)
        {
            this.customerNumber = _customerNumber;
            this.customerName = _customerName;
            this.streetAddress = _streetAddress;
            this.zipcode = _zipcode;
            this.town = _town;
            this.id = _id != null ? _id : Guid.NewGuid();
        }

        public override string ToString()
        {

            string s = "Customer Name: " + this.customerName + " \n";
            s += "Customer ID : " + this.id + " \n";
            s += "Customer Number: " + this.customerNumber + " \n";
            s += "Address: " + this.streetAddress + " \n";
            s += "zipcode: " + this.zipcode + " \n";
            s += "Town: " + this.town + " \n";
            return s;
                       
        }



    }
}
