using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.DecoratorPattern
{
    public class PlainPizza : IPizza
    {
        public PlainPizza()
        {
            Console.WriteLine("Adding Dough");
        }

        public double GetCost()
        {
            return 4.00;
        }

        public string GetDescription()
        {
            return "Thin Dough";
        }
    }
}
