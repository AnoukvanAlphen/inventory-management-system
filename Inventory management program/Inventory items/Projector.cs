using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_management
{
    /// <summary>
    /// represents a projector inventory item
    /// </summary>
    internal class Projector: InventoryItem
    {
        public Projector( int quantity) : base(nameof(Projector), quantity)
        { 
        }
    }
}
