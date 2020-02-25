using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.DecoratorPattern
{
    public class TomatoSauce : ToppingDecorator
    {
        public TomatoSauce(IPizza newPizza) : base(newPizza)
        {
            Console.WriteLine("Adding Sauce");
        }

        public override double GetCost()
        {
            return _tempPizza.GetCost() + 0.35;
        }

        public override string GetDescription()
        {
            return _tempPizza.GetDescription() + ", Tomato Sauce";
        }
    }
}
