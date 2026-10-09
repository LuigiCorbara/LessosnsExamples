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
                if (value < 0)
                    throw new Exception($"Value not allowed {nameof(_odometerKm)}");

                _odometerKm = value;
            }
        }

        public double DailyRate { get; private set; }

        public double FuelLevelPercentage { get; private set; }

        public Vehicle(string licensePlate)   // Overload costruttore
        {
            LicensePlate = licensePlate; // Chiamata al private set
        }
      

        public Vehicle(string licensePlate, int odometerKm, double dailyRate, double fuelLevelPercentage)
        {
            LicensePlate = licensePlate;
            OdometerKm = odometerKm;
            DailyRate = dailyRate;
            FuelLevelPercentage = fuelLevelPercentage;
        }

        public void RegisterData(int consumedKm, double consumedFuel) 
        {
            //controlli sui parametri
            if (consumedKm <= 0)
                throw new Exception($"value not allowed {nameof(consumedKm)} : {consumedKm}");
            if (consumedFuel <= 0)
                throw new Exception($"value not allowed {nameof(consumedFuel)} : {consumedFuel}");

            //aggiorno i valori
            OdometerKm += consumedKm; //chiamata al set
            FuelLevelPercentage -= consumedFuel; //chiamata al set
        }
        
    }
}
