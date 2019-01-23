using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2301Cars
{
    //[DebuggerDisplay("{brand} {(km*2)}")]
    class Car
    {
        // --------------------------------------- DATA
        public int year;
        public double km;
        public string brand;
        public string model;


        // --------------------------------------- FUNCTIONS
        public string TellMeYourModel()
        {
            return model;
        }

        public void Drive()
        {
            Console.WriteLine($"Driving {brand} {model}");
        }

        public void Start()
        {
            Console.WriteLine($"Starting {brand} {model} {km}");
        }

        public double TellMeYourKm()
        {
            return km;
        }

        public override string ToString()
        {
            return $"Brand = {brand} Model = {model} KM = {km} Year = {year}";
        }
    }
}
