using Affarssystemet.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affarssystemet.DataLayer
{


    /* There are many function should be added to this class such as:
     * update customer ... but definatly no-remove because there might be some orders contain the customer  
     * 
     */

    class Customers<T>: IEnumerable where T: Customer
    {
        private readonly List<T> _customers;
        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)_customers).GetEnumerator();
        }

        public Customers()
        {
            _customers = new List<T>();
         }
        public bool AddCustomer(T customer)
        {

            if (customer.customerNumber == 0)
            {
               customer.customerNumber = getNextCustomerNumber();
            }
            else
            {
                if (getCustomerByNumber(customer.customerNumber) != null)
                {
                    Console.WriteLine("A customer with number: " + customer.customerNumber + " is already exists !");
                    return false;
                }
            }
                     
           
            _customers.Add(customer);
             return true;
        }

        public bool UpdateCustomer(T customer, Guid customer_id)
        {
            if(_customers.Count == 0) 
            _customers.Add(customer);
            return true;
        }

        public string  getCustomersList()
        {
            string result = "";
            foreach (Customer c in _customers)
            {
                if (c != null) result += c.ToString() + "\n";
            }
            return result;
           
        }

        public Customer getCustomerByNumber(int customerNumber)
        {
            return _customers.SingleOrDefault(x => x.customerNumber== customerNumber);
        }

        public int getNextCustomerNumber()
        {
            if (_customers.Count == 0) return 101;
            int next = _customers.Max(x => x.customerNumber);
            return next + 1;
        }



    }
}
