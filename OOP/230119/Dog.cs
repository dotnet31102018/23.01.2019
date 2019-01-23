using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230119
{
    class Dog
    {
        // DATA
        public string name;
        public string brand;
        public float height;

        // FUNCTIONS
        public void Bark()
        {
            Console.WriteLine($"{name} is barking haw haw");
        }

        public void Eat()
        {
            Console.WriteLine($"{name} is eating yammy yummy");
        }

        public string WhatsYourName()
        {
            Bark();
            return name;
        }
    }
}
