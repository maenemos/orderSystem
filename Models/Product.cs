using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affarssystemet.Models
{
   public class Product
    {
        public Guid? id { get; private set; }
        public int itemNumber { get; set; }
        public string itemName { get; set; }
        public double itemPrice { get; set; }
        public int totalInStorage { get; set; }

        public Product() { }
        [JsonConstructor]
        public Product(string _itemName, double _itemPrices, int _totalInStorage, int _itemNumber = 0, Guid? _id = null)
        {
            this.itemNumber = _itemNumber;
            this.itemName = _itemName;
            this.itemPrice = _itemPrices;
            this.totalInStorage = _totalInStorage;
            this.id = _id != null ? _id : Guid.NewGuid();
        }


        public override string ToString()
        {
            string s = "Product : \n";
            s += "Product ID : " + this.id + " \n";
            s += "Product Number: " + this.itemNumber + " \n";
            s += "Item price: " + this.itemPrice + " \n";
            s += "Total left in storage: " + this.totalInStorage + " \n";
           
            return s;
        }


    }
}
