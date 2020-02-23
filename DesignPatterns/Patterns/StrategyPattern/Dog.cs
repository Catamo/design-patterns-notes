using DesignPatterns.Patterns.StrategyPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Basics.Inheritance
{
    public partial class Dog : Animal
    {
        partial void SetFieldValues()
        {
            FlyingType = new CannotFly();
        }
    }
}
