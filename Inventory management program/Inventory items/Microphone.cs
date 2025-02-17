using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_management
{
    /// <summary>
    /// represents a Microphone inventory item
    /// </summary>
    internal class Microphone: InventoryItem
    {
        public Microphone( int quantity) : base(nameof(Microphone), quantity)
        {
        }

        public override void PrintStock2()
        {
            Console.WriteLine($"microphone is not like most classes :{Quantity}");
        }
        //microphone wants to be special with its name in the print function 
    }
}
