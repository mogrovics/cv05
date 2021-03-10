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

        // constructor
        public Car(double fuelAmount, FuelType fuelType)
            :base(fuelAmount, fuelType)
        {
            this.passengers = 0; // given car has zero passengers by default
            this.maxPassengers = 5;
            this.TankSize = 45;

        }

        // getters and setters for max number of passengers and current number of passengers
        public int MaxPassengers
        {
            get { return maxPassengers; }
            private set { maxPassengers = value; }
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
                        Console.WriteLine("Vehicle capacity does not support this number of passengers: {0}\n", value);
                    }
                }
            }
        }

        public override string ToString()
        {
            return String.Format($"-------------------------------------------------------------------------------------------------------------\n" +
                                 $" Passengers: {Passengers}, Max passengers: {MaxPassengers}, Fuel amount: {FuelAmount} l, Fuel: {FuelUsed}\n" +
                                 $"-------------------------------------------------------------------------------------------------------------\n");
        }
    }
}