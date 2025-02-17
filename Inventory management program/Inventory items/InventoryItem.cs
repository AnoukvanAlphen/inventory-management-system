using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_management
{
    /// <summary>
    /// represents a base class for Inventory items
    /// </summary>
    internal class InventoryItem
    {
       

        public string Type{ get => type; set => type = value;}

        

        public int Quantity { get => quantity; set => quantity = value; }

        public InventoryItem(string inventoryType, int inventoryQuantity)
        {
            Type = inventoryType;
            Quantity = inventoryQuantity;
        }

        public virtual void PrintStock2()
        {
            Console.WriteLine($"{Type}: {Quantity}");
            

        }

        public int DecreaseQuantity(int amount) 
        {
            Quantity = Quantity - amount;
            return Quantity;

        }

        public int IncreaseQuantity(int amount)
        {
            Quantity = quantity + amount;
            return Quantity;
        }

      /*  public List getAvailableStock()
        {
            
        }*/

        /*public List searchItem()
        {

        }*/


        private string type;
        private int quantity;

    }
}
