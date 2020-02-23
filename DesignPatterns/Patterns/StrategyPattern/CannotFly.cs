using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.StrategyPattern
{
    public class CannotFly : IFlys
    {
        public string Fly()
        {
            return "I can't fly";
        }
    }
}
