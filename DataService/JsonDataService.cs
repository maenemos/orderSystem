using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Affarssystemet.Models;
using Affarssystemet.DataLayer;
namespace Affarssystemet.DataService
{
   public class JsonDataService
    {
       // here we save data and read the saved data 
       public bool saveOrders()
       {
           return true;
       }

       public IList<Order> getSavedOrders()
       {
           return null;
       }



    }
}
