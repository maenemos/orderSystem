using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Affarssystemet.Models;
using Affarssystemet.DataLayer;
namespace Affarssystemet.DataService
{
  public  class DataService
    {
        // here we are going to initiate datalayers 6 add all required functions to do the job 
        // It is a middle layer between data and user intrface
        
        private Storage<Product> _Storage {get; set;}
        private Customers<Customer> _Orders { get; set; }
        private Orders<Order> _Customers { get; set; }










    }
}
