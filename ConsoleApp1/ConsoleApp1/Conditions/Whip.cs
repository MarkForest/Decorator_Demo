using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Components;

namespace ConsoleApp1.Conditions
{
    public class Whip : ConditionDecorator
    {
        public Whip(Bevarage bevarage) : base(bevarage) { }

        public override double cost()
        {
            return .20 + bevarage.cost();
        }

        public override string getDescription()
        {
            return bevarage.getDescription() + "| Whip";
        }
    }
}
