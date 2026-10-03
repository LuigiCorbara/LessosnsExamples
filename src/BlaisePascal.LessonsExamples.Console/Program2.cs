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
        }

    }

}
