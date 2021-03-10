using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    class Lorry : Vehicle
    {
        // max load capacity
        private double maxLoad;
        // current load capacity
        private double load;

        // constructor
        public Lorry(double fuelAmount, FuelType fuelType)
            :base(fuelAmount, fuelType)
        {
            this.load = 0; // lorry is "empty" by default
            this.maxLoad = 25;
            this.TankSize = 900;
        }

        // getters and setters for max load capacity and current load capacity
        public double MaxLoad
        {
            get { return maxLoad; }
            private set { maxLoad = value; }
        }

        public double Load
        {
            get { return load; }
            set 
            {
                // check if load value is within max load limit
                if (value <= MaxLoad)
                {
                    load = value;
                }

                else // throw exception with info about max possible load size
                {
                    try
                    {
                        throw new Exception();
                    }
                    catch (Exception)
                    {

                        load = maxLoad;
                        Console.WriteLine("Load {0} tonnes is too high. Max load: {1} tonnes.\n", value, MaxLoad);
                    }
                }
               
            }
        }

        public override string ToString()
        {
            if (load == 1)
            {
                return String.Format($"-------------------------------------------------------------------------------------------------------------\n" +
                                     $" Load: {Load} tonne, Max load: {MaxLoad} tonnes, Fuel amount: {FuelAmount} l, Fuel: {FuelUsed}\n" +
                                     $"-------------------------------------------------------------------------------------------------------------\n");
            }
            else
            {
                return String.Format($"-------------------------------------------------------------------------------------------------------------\n" +
                                     $" Load: {Load} tonnes, Max load: {MaxLoad} tonnes, Fuel amount: {FuelAmount} l, Fuel: {FuelUsed}\n" +
                                     $"-------------------------------------------------------------------------------------------------------------\n");
            }
        }
    }
}