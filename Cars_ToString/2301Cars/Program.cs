using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2301Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Car lamburguini = new Car
            {
                brand = "Lamburgini",
                model = "Hurikan",
                km = 100,
                year = 2020
            };

            Car ferrari = new Car
            {
                brand = "Ferrari",
                model = "Range",
                km = 50.5,
                year = 2021
            };

            Car mitsubishi = new Car
            {
                brand = "Mitsubishi",
                model = "Outlander",
                km = 10002.4,
                year = 2017
            };

            //lamburguini.Start();
            //lamburguini.Drive();

            //Console.WriteLine( ferrari.TellMeYourKm() );
            //Console.WriteLine( mitsubishi.TellMeYourModel() );

            Console.WriteLine( mitsubishi ); // Console.WriteLine( mitsubishi.ToString() );
            Console.WriteLine(ferrari);
            Console.WriteLine(lamburguini);
        }
    }
}
