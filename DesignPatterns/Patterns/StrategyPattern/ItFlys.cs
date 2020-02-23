using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.StrategyPattern
{
    public class ItFlys : IFlys
    {
        public string Fly()
        {
            return "Flying High";
        }
    }
}
