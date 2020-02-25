using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.DecoratorPattern
{
    public interface IPizza
    {
        string GetDescription();

        double GetCost();
    }
}
