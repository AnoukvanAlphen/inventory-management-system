using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_management
{

    public class MainMenu
    {
        public enum Menu
        {
            capture = 1,
            search,
            dispatch,
            displayStock,
            displayItems,
            Exit
        }
        public void DisplayMainMenu()
        {
            Console.WriteLine(@"Please choose an option below:
1. Capture request details
2. Search for stock
3. Dispatch items
4. Display available stock
5. Display dispatched items
6. Exit
 ");
          
        }
        public Menu GetMenuSelection()
        {
            while (true)
            {
                Console.WriteLine("Enter selection:");
                int userInput = int.Parse(Console.ReadLine());
                bool isValidInput = userInput >= (int)Menu.capture && userInput <= (int)Menu.Exit;
                if (isValidInput)
                {   
                    return (Menu)userInput;
                }
                Console.WriteLine("Invalid input");

                DisplayMainMenu();

            }

            //displays menu and does validation on the input
        }


    }
}
