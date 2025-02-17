using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_management.locations
{
    internal class CampusCollection
    {
        public CampusCollection(Campus pretoria, Campus stellenbosch, Campus kempton)
        {
            Pretoria = pretoria;
            Stellenbosch = stellenbosch;
            Kempton = kempton;
        }
        //set this classes variables to the variables derived from the Campus class and in the constructor


        public Campus Pretoria{ get => pretoria; set => pretoria = value; }
        public Campus Stellenbosch { get => stellenbosch; set => stellenbosch = value; }
        public Campus Kempton { get => kempton; set => kempton = value; }

        
        public void PrintStock1()
        {
            pretoria.PrintStock();
            stellenbosch.PrintStock();
            kempton.PrintStock();

        }

        private Campus pretoria;
        private Campus stellenbosch;
        private Campus kempton;

        // create variables with type Campus class
      
    }
}
