using ConsoleApp1.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Conditions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bevarage bevarage = new Espresso();
            Console.WriteLine($"{bevarage.getDescription()} {bevarage.cost()}");
            Console.WriteLine("==============");

            Bevarage bevarage2 = new Espresso();
            bevarage2 = new Whip(bevarage2);
            bevarage2 = new Mocha(bevarage2);
            Console.WriteLine($"{bevarage2.getDescription()} {bevarage2.cost()}");
            Console.WriteLine("==============");

            Bevarage bevarage3 = new Whip(new Mocha(new Mocha(new Espresso())));
            Console.WriteLine($"{bevarage3.getDescription()} {bevarage3.cost()}");
            Console.WriteLine("==============");

            Console.ReadKey();
        }
    }
}
