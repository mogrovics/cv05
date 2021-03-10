using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    class Radio
    {
        private double frequency;
        private bool status;
        // dictionary in which the radio selection and frequency are stored
        private Dictionary<int, double> radioStation = new Dictionary<int, double>();

        // getters and setters for radio frequency and status
        public double Frequency
        {
            get { return frequency; }
            protected set { frequency = value; }
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        // method to add new radio stations to radio memory using selection number and frequency
        public void AddRadioStations(int station, double frequency)
        { 
            radioStation.Add(station, frequency);
        }

        // method to set radio to a particular station
        public void RadioSettings(int station)
        {
            // checks if desired selection is in memory and if the radio is on
            if (radioStation.ContainsKey(station) && status)
            {
                Frequency = radioStation[station];
            }
            // check if radio is off
            else if (!status)
            {
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {
                    Console.WriteLine("Radio is turned off.\n");
                }
            }
        }
    }
}
