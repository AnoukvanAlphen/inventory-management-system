using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_management
{
    internal class CaptureOperation
    {
        public void Execute()
        {
            Console.WriteLine("capture");
            EnterCaptureRequestDetails RequestDetails = new EnterCaptureRequestDetails();
            InventoryRequest printout = RequestDetails.GetRequestDetails();
            Console.WriteLine(printout);

        }

    }
}
