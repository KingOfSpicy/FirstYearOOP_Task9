using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CheWeiHsu_Task9
{
    //Base class:
    class Car
    {
        public Car(string make, string model, int year, string color)
        {
            Console.WriteLine("Calling base class constructor.");
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return String.Format("{0}-{1}-{2}-{3}", Make, Model, Year, Color);
        }
    }
}
