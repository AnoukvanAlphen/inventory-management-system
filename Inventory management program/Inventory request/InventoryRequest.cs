using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_management
{
    public class InventoryRequest
    {
        public InventoryRequest(string location, string _designation, string _classroomType, int _numberOfClassrooms, DateTime _date)
        {
            Location = location;
            designation = _designation;
            classroomType = _classroomType;
            numberOfClassrooms = _numberOfClassrooms;
            Date = _date;
        }

        public string Location
        {
            get => location;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException($"Invalid Location: {value}");
                
                location = value;
            }
        }

        public string Designation
        {
            get => designation;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException($"Invalid designation: {value}");

            }
        }

        public string classRoomType
        {
            get => classroomType;
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException($"Invalid classroom  type: {value}");
                if (value.ToLower() != "hybrid" || value.ToLower() != "hybeflex" || value.ToLower() != "normal" )
                    throw new ArgumentException("Please only enter Hybrid, Hybeflex or Normal");
            }

        }

        public int NumberOfClassrooms
        {
            get => numberOfClassrooms;
            set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                    throw new ArgumentException($"Invalid number of classrooms: {value}");
            }
        }

        public DateTime dateProp
        {
            get => Date;
            set
            {
                if (string.IsNullOrEmpty(value.ToLongTimeString()))
                    throw new ArgumentException($"Invalid date: {value}");
                string format = "yyyy-mm-dd";
                if ((DateTime.TryParse(format, out value)) == false)
                    throw new ArgumentException($"Invalid date format: {value}");
            }
        }

        public void DisplayInventoryRequest()
        {
            Console.WriteLine($"{location}, {designation}, {classRoomType}, {numberOfClassrooms}, {Date}");
        }

      

        private string location;
        private string designation;
        private string classroomType;
        private int numberOfClassrooms;
        private DateTime Date;

    }
}
