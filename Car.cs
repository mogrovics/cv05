using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    class Car : Vehicle
    {
        // max passengers in a vehicle
        private int maxPassengers;
        // current number of passengers
        private int passengers;

        public Car(double fuelAmount, FuelType fuelType)
            :base(fuelAmount, fuelType)
        {
            this.passengers = 0;
            this.maxPassengers = 5;
            this.tankSize = 45;

        }

        public int MaxPassengers
        {
            get { return maxPassengers; }
            protected set { maxPassengers = value; }
        }

        public int Passengers
        {
            get { return passengers; }
            set
            {
                if (value <= maxPassengers)
                {
                    passengers = value;
                }
                else
                {
                    try
                    {
                        throw new Exception();
                    }
                    catch (Exception)
                    {
                        passengers = maxPassengers;
                        Console.WriteLine("Vehicle capacity does not support this number of passengers: {0}", value);
                    }
                }
            }
        }

        public override string ToString()
        {
            return String.Format($" Passengers: {passengers}, Max passengers: {maxPassengers} Fuel amount: {fuelAmount} l, Fuel: {fuel}");
        }
    }
}
