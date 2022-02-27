using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CheWeiHsu_Task9
{
    //Derived class:
    class Truck:Car
    {
        public Truck(string make, string model, int year, string color, int towingCapacity) : base(make, model, year, color)
        {
            Console.WriteLine("Calling derived class constructor.");
            TowingCapacity = towingCapacity;
        }

        public int TowingCapacity { get; set; }

        public override string ToString()
        {
            return base.ToString()+String.Format("-{0}", TowingCapacity);
        }
    }
}
