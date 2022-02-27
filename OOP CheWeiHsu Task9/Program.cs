using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CheWeiHsu_Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testing the base class:
            //Car baseCar = new Car("VW", "Jetta 1.6", 2007, "Blue");
            //Console.WriteLine(baseCar);

            //Truck truckCar = new Truck("Volvo", "FMX", 2006, "Black and White", 1200);
            //Console.WriteLine(truckCar);
            //Next time: make it interactive!
            //Ask all the information from the user of the program

            //Making it interactive
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            bool stillMore = false;
            do
            {
                Console.Write("Would you like to enter car or truck info (C/T)?:");
                string receivedInfo = Console.ReadLine().ToUpper();
                if (receivedInfo.StartsWith("C"))
                {
                    //Console.Write("Car");
                    Console.Write("Enter the Make, please: ");
                    string make = Console.ReadLine();
                    Console.Write("Enter the Model, please: ");
                    string model = Console.ReadLine();
                    Console.Write("Enter the Year, please: ");
                    string valueReceived = Console.ReadLine();
                    int year = 0;
                    while (!Int32.TryParse(valueReceived, out year))
                    {
                        Console.Write("Not valid, try again: ");
                        valueReceived = Console.ReadLine();
                    }
                    Console.Write("Enter the Color, please: ");
                    string color = Console.ReadLine();
                    cars.Add(new Car(make, model, year, color));
                }
                else if (receivedInfo.StartsWith("T"))
                {
                    //Console.Write("Car");
                    Console.Write("Enter the Make, please: ");
                    string make = Console.ReadLine();
                    Console.Write("Enter the Model, please: ");
                    string model = Console.ReadLine();
                    Console.Write("Enter the Year, please: ");
                    string valueReceived = Console.ReadLine();
                    int year = 0;
                    while (!Int32.TryParse(valueReceived, out year))
                    {
                        Console.Write("Not valid, try again: ");
                        valueReceived = Console.ReadLine();
                    }
                    Console.Write("Enter the Color, please: ");
                    string color = Console.ReadLine();
                    cars.Add(new Car(make, model, year, color));
                    Console.Write("Enter the Towing Capacity, please: ");
                    valueReceived = Console.ReadLine();
                    int towingCapacity = 0;
                    while (!Int32.TryParse(valueReceived, out towingCapacity))
                    {
                        Console.Write("Not valid, try again: ");
                        valueReceived = Console.ReadLine();
                    }
                    trucks.Add(new Truck(make, model, year, color, towingCapacity));

                }
                else
                    break;
                Console.Write("More vehicle info to process (Y/N)?: ");
                string moreOfThis = Console.ReadLine().ToUpper();
                if (moreOfThis.StartsWith("Y"))
                {
                    stillMore = true;
                }
                else
                {
                    stillMore = false;
                }
            } while (stillMore);

            //What was received?
            bool isEmpty1 = !cars.Any(); //true, if there are no cars
            bool isEmpty2 = !trucks.Any(); //true, if there are no trucks
            if (isEmpty1 && isEmpty2)
            {
                Console.WriteLine("Whhhhat, you entered nothing.");
            }

            //if(!isEmpty1)
            //    ...
            //if(!isEmpty2)
            //    ...
            else
            {
                if (!isEmpty1)
                {
                    Console.WriteLine("Cars entered were: ");
                    foreach (var c in cars)
                        Console.WriteLine(c);
                    Console.WriteLine();
                }
                if (!isEmpty2)
                {
                    Console.WriteLine("Trucks entered were: ");
                    foreach (var t in trucks)
                        Console.WriteLine(t);
                    Console.WriteLine();
                }
            }
        }
    }
}
