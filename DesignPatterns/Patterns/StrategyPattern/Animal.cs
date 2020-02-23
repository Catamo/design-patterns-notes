using DesignPatterns.Patterns.StrategyPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Basics.Inheritance
{
    public partial class Animal
    {
        public IFlys FlyingType;

        public string TryToFly()
        {
            return FlyingType.Fly();
        }

        public void SetFlyingAbility(IFlys newFlyType)
        {
            FlyingType = newFlyType;
        }
    }
}
