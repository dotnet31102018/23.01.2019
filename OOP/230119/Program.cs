using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230119
{

    class Program
    {

        static void Main(string[] args)
        {
            Random r = new Random();

            /*
             
            Dog shoko = new Dog();
            shoko.name = "Shoko";
            shoko.height = 0.9f;
            shoko.brand = "Pintchuer";

            */
            
            Dog shoko = new Dog
            {
                name = "Shoko",
                height = 0.9f,
                brand = "Pintchuer"
            };

            Console.WriteLine($"Dog name is {shoko.name}");

            Console.WriteLine(shoko.WhatsYourName());

            Dog lavany = new Dog
            {
                name = "Lavani",
                height = 0.5f,
                brand = "Labrador"
            };

            Console.WriteLine(lavany.WhatsYourName());

            int number  = 9;


        }
    }
}
