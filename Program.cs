using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Affarssystemet.DataLayer;
using Affarssystemet.Models;

namespace Affarssystemet
{
    class Program
    {
        static void Main(string[] args)
        {

            // this is only a first step or a prototype to know what we are going to do ...
            // Nothing will be placed in this void ... just for a test
            // initiate datalayers
            var _Storage = new Storage<Product>();
            var _customers = new Customers<Customer>();
            var _orders = new Orders<Order>();
           


            // add default customers
            Customer c = new Customer("Maen emos", "Lofotengatan 26", "16433", "Kista", 101);
            Customer c1 = new Customer("Daniel Funke", "gatuadress 15", "11122", "Stockholm");
            _customers.AddCustomer(c);
            _customers.AddCustomer(c1);

           // add default products

            Product p = new Product("PC",5000,20);
            Product p1 = new Product("Play-Station",3000,8);
            Product p2 = new Product("Labtop",8000,10);
            _Storage.AddProduct(p);
            _Storage.AddProduct(p1);
            _Storage.AddProduct(p2);
            
            // create an order
            var orderCustomer = _customers.getCustomerByNumber(101);

            var row1 = new orderRow(_Storage.getProductByNumber(1),2);
            var row2 = new orderRow(_Storage.getProductByNumber(2),3);
            
            List<orderRow> orderRows =  new List<orderRow>();
            orderRows.Add(row1);
            orderRows.Add(row2);


            Order _order = new Order(_customers.getCustomerByNumber(101),orderRows , DateTime.Today);

            _orders.AddOrder(_order);


            Console.WriteLine( _orders.getOrdersList());
                    

            Console.ReadLine();


        }
    }
}
