using ConsoleApp1.Conditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Components
{
    public class Espresso : Bevarage
    {
        public Espresso()
        {
            description = "Espresso";
        }
        public override double cost()
        {
            return 1.99;
        }
    }
}
