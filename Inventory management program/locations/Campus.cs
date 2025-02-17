using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Inventory_management.locations
{
    internal class Campus
    {
        public Campus(string name, int microphoneQuantity, int projectorQuantity, int screenQuantity, int whiteboardQuantity)
        {
            Name = name;
            microphone = new Microphone(microphoneQuantity);
            projector = new Projector(projectorQuantity);
            screen = new Screen(screenQuantity);
            whiteboard = new Whiteboard(whiteboardQuantity);
        }
        //set items to the quantity of each item class
        
        #region properties
        public string Name { get => name; set => name = value; }
        public Microphone Microphone { get => microphone; set => Microphone = value; }
        public Projector Projector { get => projector; set => Projector = value; }
        public Screen Screen { get => screen; set => Screen = value; }
        public Whiteboard Whiteboard { get => whiteboard; set => Whiteboard = value; }
        #endregion

        public void PrintStock()
        {
            Console.WriteLine(Name);
            Microphone.PrintStock2();
            Projector.PrintStock2();
            Screen.PrintStock2();
            Whiteboard.PrintStock2();
            Console.WriteLine("-------");
        }
        //call printstock method that is a virtual method in Inventory Item class


        private string name;
        private Microphone microphone;
        private Projector projector;
        private Screen screen;
        private Whiteboard whiteboard;
        /*items created of type item class*/

        //composition
    }
}
