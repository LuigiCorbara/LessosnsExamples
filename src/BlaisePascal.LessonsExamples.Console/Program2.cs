using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BlaisePascal.LessonsExamples.Domain;

namespace BlaisePascal.LessonsExamples.VehicleConsole
{
    internal class Program2
    {
        
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("abc");
            string license = vehicle.LicensePlate;

            Console.WriteLine(license);

            try
            {
                Vehicle vehicle1 = new Vehicle("xyz", -1, 50, 75);
                Console.WriteLine(vehicle1.LicensePlate);
                Console.WriteLine(vehicle1.OdometerKm);
                Console.WriteLine(vehicle1.DailyRate);
                Console.WriteLine(vehicle.FuelLevelPercentage);

            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);

            }


        }

    }

}
