using ConsoleApp1.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Conditions
{
    public abstract class ConditionDecorator: Bevarage
    {
     
        protected Bevarage bevarage = null;
        public ConditionDecorator(Bevarage bevarage)
        {
            this.bevarage = bevarage;
        }
        
    }
}
