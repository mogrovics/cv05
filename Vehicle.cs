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
        private double tankSize;
        // current amount of fuel
        private double fuelAmount;
        // types of fuel
        public enum FuelType { Gasoline, Diesel }
        // fuel parameter of a vehicle
        private FuelType fuel;
        // initialization of the radio class
        private Radio radio = new Radio();
        
        // constructor
        public Vehicle(double fuelAmount, FuelType fuelType)
        {
            this.fuelAmount = fuelAmount;
            this.fuel = fuelType;
        }

        // getters and setters for tank size, fuel in the tank and type of fuel
        public double TankSize
        {
            get { return tankSize; }
            protected set { tankSize = value; }
        }
        
        public double FuelAmount
        {
            get { return fuelAmount; }
            protected set { fuelAmount = value; }
        }

        public FuelType FuelUsed
        {
            get { return fuel; }
            protected set { fuel = value; }
        }

        // method for refueling
        public void Refuel(FuelType fuelType, double amount)
        {
            /*
             * if the amount of fuel in the tank and amount of fuel for refueling matches or is lower then tank capacity
             * AND the fuel type is correct, the tank is refueled
             */
            if ((FuelAmount + amount) <= TankSize && this.fuel == fuelType)
            {
                FuelAmount += amount;
            }
            
            else if (this.fuel != fuelType) // if the fuel type is not correct, throw exception regardless of fuel amount
            {
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {
                    Console.WriteLine("Incorrect type of fuel.\n");
                }
            }
            /* 
             * if the amount of fuel for refueling is larger then tank capacity, the tank is refueled to maximum capacity
             * and the fuel surplus is not used
             * 
             * exception is thrown with information about amount of fuel actually added
             */
            else
            {
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {
                    Console.WriteLine("Fuel tank is full. Added {0} l of fuel.\n", TankSize-FuelAmount);
                    FuelAmount = TankSize;
                }
            }
        }

        /* 
         * method that adds radio station to radio memory
         * 
         * station   ... number of a selection (1, 2, 3...)
         * frequency ... radio freqency of a given station 
         */
        public void AddStation(int station, double frequency)
        {
            radio.AddRadioStations(station, frequency);
        }

        /*
         * method to select a station
         * 
         * checks if there are any radio stations saved
         * in case there 
         */
        public void RadioSettings(int station)
        {
            if (radio != null)
            {
                radio.RadioSettings(station);
            }
            else
                Console.WriteLine("No radio stations in memory.\n");
        }

        // method for switching radio on and off
        public void RadioStatus(bool status)
        {
            radio.Status = status;
        }

        public string radioToString()
        {
            // checks if radio is on and a valid frequency is selected
            if (radio.Status && radio.Frequency != 0)
            {
                return String.Format($"Radio status: {radio.Status}, Radio freqency: {radio.Frequency} Hz.\n");
            }
            
            // no valid frequency, but radio is on
            if (radio.Status && radio.Frequency == 0)
            {
                return String.Format("Radio is on, but no valid station is selected.\n");
            }
            else
            {
                return String.Format("Turn radio on to proceed.\n");
            }
        }
    }
}