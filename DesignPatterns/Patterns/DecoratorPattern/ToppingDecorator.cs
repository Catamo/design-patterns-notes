using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.DecoratorPattern
{
    public abstract class ToppingDecorator : IPizza
    {
        protected IPizza _tempPizza;

        protected ToppingDecorator(IPizza newPizza)
        {
            _tempPizza = newPizza;
        }

        public virtual double GetCost()
        {
            return _tempPizza.GetCost();
        }

        public virtual string GetDescription()
        {
            return _tempPizza.GetDescription();
        }
    }
}
