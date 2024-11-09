using Inventory_management.locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_management
{
    public class Program
    {

        static void Main(string[] args)
        {
            CaptureOperation operation1 = new CaptureOperation();
            SearchOperation operation2 = new SearchOperation();
            DispatchOperation operation3 = new DispatchOperation();
            DisplayStock operation4 = new DisplayStock();
            DisplayItems operation5 = new DisplayItems();
            ExitOperation operation6 = new ExitOperation();

            //create new instances of class campus for each campus wiht their quantities
            Campus pret = new Campus("Pretoria", 10, 10, 10, 10);
            Campus stel = new Campus("Stellenbosch", 0, 0, 0, 0);
            Campus kempt = new Campus("Kempton park", 0, 0, 0, 0);

            //create new campus collection containing the campus objects created
            CampusCollection Campuses = new CampusCollection(pret, stel, kempt);
            Campuses.PrintStock1();




            MainMenu m1 = new MainMenu();
            MainMenu.Menu mainMenuSelection;



            do
            {
                m1.DisplayMainMenu();
                mainMenuSelection = m1.GetMenuSelection();


                switch (mainMenuSelection)
                {
                    case MainMenu.Menu.capture:
                        operation1.Execute();
                        break;

                    case MainMenu.Menu.search:
                        operation2.Execute();
                        break;

                    case MainMenu.Menu.dispatch:
                        operation3.Execute();
                        break;

                    case MainMenu.Menu.displayStock:
                        operation4.Execute();
                        break;

                    case MainMenu.Menu.displayItems:
                        operation5.Execute();
                        break;

                    case MainMenu.Menu.Exit:
                        operation6.Execute();
                        break;


                    default:
                        break;
                }
                Console.WriteLine("Do you want to display menu again? y/n");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "y")
                    continue;
                else operation6.Execute();

            } while (mainMenuSelection != MainMenu.Menu.Exit);


            try
            {
                InventoryRequest r = new InventoryRequest("Stellenbosch", "  ", "test", 1, DateTime.Now);


            }
            catch (Exception exc)
            {
                Console.WriteLine($"error: {exc.Message}");
            }


            Console.ReadLine();

            return;





        }
    }
}

//polymorphism
