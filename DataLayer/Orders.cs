using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Affarssystemet.Models;
using System.Collections;
namespace Affarssystemet.DataLayer
{
    class Orders<T> : IEnumerable where T : Order
    {

        private readonly List<T> _orders;
        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)_orders).GetEnumerator();
        }

        public Orders()
        {
            _orders = new List<T>();
        }


        public bool AddOrder(T order)
        {

            if (order.orderNumber == 0)
            {
                order.orderNumber = getNextOrderNumber();
            }
            else
            {
                if (getOrderByNumber(order.orderNumber) != null)
                {
                    Console.WriteLine("An order with number: " + order.orderNumber + " is already exists !");
                    return false;
                }
            }


            _orders.Add(order);
            return true;
        }

        public Order getOrderByNumber(int orderNumber)
        {
            return _orders.SingleOrDefault(x => x.orderNumber == orderNumber);
        }
        public int getNextOrderNumber()
        {

            if (_orders.Count == 0) return 1501;
            int next = _orders.Max(x => x.orderNumber);
            return next + 1;
        }

        public string getOrdersList()
        {
            string result = "";
            foreach (Order o in _orders)
            {
                if (o != null) result += o.ToString() + "Total order price :" + claculateOrderTotalPrice(o) + "\n";
            }
            return result;

        }

        private double claculateOrderTotalPrice(Order order)
        {
            double price = 0;
            foreach (var row in order.orderRows)
            {
                price += row.product.itemPrice * row.count;
            }

            return price;
        }




    }
}
