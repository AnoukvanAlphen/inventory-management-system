using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_management
{
    /// <summary>
    /// represents a Whiteboard inventory item
    /// </summary>
    internal class Whiteboard: InventoryItem
    {
        public Whiteboard( int quantity) : base(nameof(Whiteboard), quantity)
        { 
        }
    }
}
