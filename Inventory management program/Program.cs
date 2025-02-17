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
            CaptureOperation CaptureOP = new CaptureOperation();
            SearchOperation SearchOP = new SearchOperation();
            DispatchOperation DispatchOP = new DispatchOperation();
            DisplayStock DisplayStock = new DisplayStock();
            DisplayItems DisplayItems = new DisplayItems();
            ExitOperation ExitOP = new ExitOperation();


            // COPIED TO INVENTORY TRANSFER CLASS TO BE USED

            //create new instances of class campus for each campus with their quantities
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
                        CaptureOP.Execute();
                        break;

                    case MainMenu.Menu.search:
                        SearchOP.Execute();
                        break;

                    case MainMenu.Menu.dispatch:
                        DispatchOP.Execute();
                        break;

                    case MainMenu.Menu.displayStock:
                        DisplayStock.Execute();
                        break;

                    case MainMenu.Menu.displayItems:
                        DisplayItems.Execute();
                        break;

                    case MainMenu.Menu.Exit:
                        ExitOP.Execute();
                        break;


                    default:
                        break;
                }
                Console.WriteLine("Do you want to display menu again? y/n");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "y")
                    continue;
                else ExitOP.Execute();

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
