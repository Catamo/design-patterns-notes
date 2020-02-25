using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.DecoratorPattern
{
    public class Mozzarella : ToppingDecorator
    {
        public Mozzarella(IPizza newPizza) : base(newPizza)
        {
            Console.WriteLine("Adding Moz");
        }

        public override double GetCost()
        {
            return _tempPizza.GetCost() + 0.50;
        }

        public override string GetDescription()
        {
            return _tempPizza.GetDescription() + ", Mozzarella";
        }
    }
}
