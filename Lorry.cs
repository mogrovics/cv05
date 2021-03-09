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

        public Lorry(double fuelAmount, FuelType fuelType)
            :base(fuelAmount, fuelType)
        {
            this.load = 0;
            this.maxLoad = 25;
            this.tankSize = 900;
        }

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
                if (value <= maxLoad)
                {
                    load = value;
                }

                else
                {
                    try
                    {
                        throw new Exception();
                    }
                    catch (Exception)
                    {

                        load = maxLoad;
                        Console.WriteLine("Load {0} is too high. Max load: {1}", value, maxLoad);
                    }
                }
               
            }
        }

        public override string ToString()
        {
            if (load == 1)
            {
                return String.Format($" Load: {load} tonne, Max load: {maxLoad} tonnes, Fuel amount: {fuelAmount} l, Fuel: {fuel}");
            }
            else
            {
                return String.Format($" Load: {load} tonnes, Max load: {maxLoad} tonnes, Fuel amount: {fuelAmount} l, Fuel: {fuel}");
            }
        }
    }
}
