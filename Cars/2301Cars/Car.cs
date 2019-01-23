using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2301Cars
{
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
    }
}
