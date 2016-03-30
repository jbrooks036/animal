using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace animal
{
    public class Animal
    {
        public string name;
    }

    public class AnimalAttributes
    {
        static void Main()
        {
            Animal a1 = new Animal();
            a1.name = "Aardvark";

            Animal a2 = new Animal();
            a2.name = "Zebra";

            Console.WriteLine(a1.name);
            Console.WriteLine(a2.name);
        }
    }
}
