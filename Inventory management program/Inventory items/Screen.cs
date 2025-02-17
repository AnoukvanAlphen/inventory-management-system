using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_management
{
    /// <summary>
    /// represents a Screen inventory item
    /// </summary>
    internal class Screen: InventoryItem
    {
        public Screen( int quantity): base(nameof(Screen), quantity)
        {

        }
    }
}
