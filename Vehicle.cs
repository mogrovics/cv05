using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    public class Vehicle
    {
        // max amount of fuel
        protected double tankSize;
        // current amount of fuel
        protected double fuelAmount;
        public enum FuelType { Gasoline, Diesel }
        protected FuelType fuel;
        private Radio radio = new Radio();
        
        public Vehicle(double fuelAmount, FuelType fuelType)
        {
            this.fuelAmount = fuelAmount;
            this.fuel = fuelType;
        }

        public double TankSize
        {
            get { return tankSize; }
            private set { tankSize = value; }
        }
        
        public double FuelAmount
        {
            get { return fuelAmount; }
            set { fuelAmount = value; }
        }

        public FuelType FuelUsed
        {
            get { return fuel; }
            protected set { fuel = value; }
        }

        public void Refuel(FuelType fuelType, double amount)
        {
            if ((fuelAmount + amount) <= tankSize && this.fuel == fuelType)
            {
                fuelAmount += amount;
            }
            
            else if (this.fuel != fuelType)
            {
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {
                    Console.WriteLine("Incorrect type of fuel.");
                }
            }
            else
            {
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {
                    Console.WriteLine("Fuel tank is full. Added {0} l of fuel.", tankSize-fuelAmount);
                }
            }
        }

        public void AddStation(int station, double frequency)
        {
            radio.AddRadioStations(station, frequency);
        }

        public void RadioSettings(int station)
        {
            if (radio != null)
            {
                radio.RadioSettings(station);
            }
            else
                Console.WriteLine("No radio stations in memory.");
        }

        public void RadioStatus(bool status)
        {
            radio.Status = status;
        }

        public string radioToString()
        {
            if (radio.Status && radio.Frequency != 0)
            {
                return String.Format($"Radio status: {radio.Status}, Radio freqency: {radio.Frequency}");
            }
            if (radio.Status && radio.Frequency == 0)
            {
                return String.Format("Radio is on, but no valid station is selected.");
            }
            else
            {
                return String.Format("Turn radio on to proceed.");
            }
        }
    }
}
