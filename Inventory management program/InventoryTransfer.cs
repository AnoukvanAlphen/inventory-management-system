using Inventory_management.locations;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_management
{
    internal class InventoryTransfer
    {
        public InventoryTransfer(InventoryRequest request)
        {
            this.request = request;
        }
        public InventoryRequest Request { get => request; set => request = value; }

        //create new instances of class campus for each campus with their quantities
        Campus pret = new Campus("Pretoria", 10, 10, 10, 10);
        Campus stel = new Campus("Stellenbosch", 0, 0, 0, 0);
        Campus kempt = new Campus("Kempton park", 0, 0, 0, 0);

        

        public void Transfer(InventoryRequest requestForTransfer)
        {
            switch (requestForTransfer.Location)
            {
                case "stellenbosch":
                    break;

                case "kempton":
                    break;

                default:
                    break;
            }
        }

        public void ItemTransfer(InventoryRequest requestForTransfer)
        {
            //create new campus collection containing the campus objects created
            CampusCollection Campuses = new CampusCollection(pret, stel, kempt);
            string classType = requestForTransfer.classRoomType;
           
            switch (classType)
            {
                case "hybrid":
                    //set items needed for class type
                    Screen hybridScreen = new Screen(3);
                    Microphone hybridMicrophone = new Microphone(1);
                    Projector hybrdProjector = new Projector(1);
                    break;

                case "hybeflex":
                    Screen hybeflexScreen = new Screen(3);
                    Microphone hybeflexMicrophone = new Microphone(1);
                    break;

                case "normal":
                    Projector normalProjector = new Projector(1);
                    Whiteboard normalWhiteBoa = new Whiteboard(1);
                    break;

                default:
                    break;
            }

            
            while (pret.)
            {
            }
        }

        public test()
        {

        }

        private InventoryRequest request;
    }
}
