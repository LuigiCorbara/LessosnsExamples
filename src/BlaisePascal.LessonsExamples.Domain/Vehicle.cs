using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.LessonsExamples.Domain
{
    public class Vehicle
    {   
        private int _odometerKm;
        private double _dailyRate;
        private double _fuelLevelPercentage;
        
        public string LicensePlate { get; private set; }

        public int OdometerKm
        {
            get
            { return _odometerKm; }
            private set
            {
                if (value < 0) throw new ArgumentExeption("illegal value");

                _odometerKm = value;
            }
        }

        public double DailyRate { get; private set; }

        public double FuelLevelPercentage { get; private set; }

        public Vehicle(string licensePlate) 
        {
            LicensePlate = licensePlate; // Chiamata al private set
        }
        // Overload costruttore

        public Vehicle(string licensePlate, int odometerKm, double dailyRate, double fuelLevelPercentage)
        {

        }
        
    }
}
