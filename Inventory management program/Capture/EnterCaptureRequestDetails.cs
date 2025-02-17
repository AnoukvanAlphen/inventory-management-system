using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_management
{
    internal class EnterCaptureRequestDetails
    {
        public InventoryRequest GetRequestDetails()
        {

            Console.WriteLine("enter a location:");
            string location = Console.ReadLine();

            Console.WriteLine("Enter a designation:");
            string designation = Console.ReadLine();

            Console.WriteLine("Enter a classroom type (hybrid, hybeflex, normal)");
            string classroomType = Console.ReadLine();

            Console.WriteLine("Enter the number of classrooms needed:");
            int numOfClassrooms = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the date of request:");
            DateTime requestDate = DateTime.Parse(Console.ReadLine());
    
           return new InventoryRequest(location, designation, classroomType, numOfClassrooms, requestDate);
            
        }
    }
}
