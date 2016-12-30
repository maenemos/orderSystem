using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Affarssystemet.Models;

namespace Affarssystemet.DataLayer
{
    class Storage <T> : IEnumerable where T : Product
    {

        private readonly List<T> _products;
        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)_products).GetEnumerator();
        }

        public Storage()
        {
            _products = new List<T>();
        }

        public bool AddProduct(T product)
        {

            if (product.itemNumber == 0)
            {
                product.itemNumber = getNextItemNumber();
            }
            else
            {
                if (getProductByNumber(product.itemNumber) != null)
                {
                    Console.WriteLine("A customer with number: " + product.itemNumber + " is already exists !");
                    return false;
                }
            }
            
            _products.Add(product);
            return true;
        }

        public Product getProductByNumber(int itemNumber)
        {
            return _products.SingleOrDefault(x => x.itemNumber == itemNumber);
        }
        public int getNextItemNumber()
        {
            if (_products.Count == 0) return 1;
            int next = _products.Max(x => x.itemNumber);
            return next + 1;
        }



    }
}
