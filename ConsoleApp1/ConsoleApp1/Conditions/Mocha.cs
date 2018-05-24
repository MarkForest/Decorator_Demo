using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Components;

namespace ConsoleApp1.Conditions
{
    public class Mocha : ConditionDecorator
    {
        public Mocha(Bevarage bevarage) : base(bevarage)
        {
        }

        public override double cost()
        {
            return .31 + bevarage.cost();
        }

        public override string getDescription()
        {
            return bevarage.getDescription() + "| Mocha";
        }
    }
}
