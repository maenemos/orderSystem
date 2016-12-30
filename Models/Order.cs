using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affarssystemet.Models
{
    public class Order
    {
        public Guid? id { get; private set; }
        public int orderNumber { get; set; }
        public Customer orderCustomer { get; set; }
        public IEnumerable<orderRow> orderRows { get; set; }
        public DateTime? dileveryDate { get; set; }

        public Order()
        {
            this.id = Guid.NewGuid();
        }
        [JsonConstructor]
        public Order(Customer _customer, IEnumerable<orderRow> _orderRows, DateTime? _dileveryDate = null, int _orderNumber = 0, Guid? _id = null)
        {

            this.orderCustomer = _customer;
            this.orderRows = _orderRows;
            this.orderNumber = _orderNumber;
            this.dileveryDate = _dileveryDate != null ? _dileveryDate : DateTime.Today;
            this.id = _id != null ? _id : Guid.NewGuid();

        }

        public override string ToString()
        {
            string s = "Order  Number: " + this.orderNumber +"\n"; 
            s +="Order ID: " + this.id + "\n";
            s += "Order Customer: \n" + this.orderCustomer.ToString();
            s +="Order rows:\n";
             foreach(var row in this.orderRows)
             {
                 s += row.product.ToString() ;
                 s += "Total: " + row.count.ToString() +" \n";
             }
                        
            return s;
        }


    }
    public class orderRow
    {
        public Guid? id { get; private set; }
        public Product product { get; set; }
        public int count { get; set; }

        public orderRow()
        {
            this.id = Guid.NewGuid();
        }
        public orderRow(Product _product, int count, Guid? _id = null)
        {
            this.product = _product;
            this.count = count;
            this.id = _id != null ? _id : Guid.NewGuid();
        }

       

    }
}
