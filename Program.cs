using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(30, Vehicle.FuelType.Gasoline);
            Console.WriteLine("{0}:\n" + car, nameof(car));

            car.Passengers = 6;
            Console.WriteLine("{0}:\n" + car, nameof(car));

            Lorry lorry = new Lorry(400, Vehicle.FuelType.Diesel);
            Console.WriteLine("{0}:\n" + lorry, nameof(lorry));

            car.Refuel(Vehicle.FuelType.Gasoline, 50);
            Console.WriteLine("{0}:\n" + car, nameof(car));

            car.RadioStatus(false);
            car.AddStation(1, 99.6);
            car.RadioSettings(1);
            Console.WriteLine(car.radioToString());
            
            Console.ReadLine();
        }
    }
}
