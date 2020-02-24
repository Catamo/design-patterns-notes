using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Basics.Inheritance;
using DesignPatterns.Patterns.StrategyPattern;
using NUnit.Framework;

namespace DesignPatterns.Test.Patterns
{
    public class StrategyPatternTests
    {
        [Test]
        public void Animals_DifferentFlyingTypes_IsCorrect()
        {
            Animal sparky = new Dog();
            Animal tweety = new Bird();

            Assert.AreEqual(sparky.TryToFly(), "I can't fly");
            Assert.AreEqual(tweety.TryToFly(), "Flying High");
        }

        [Test]
        public void Animals_ChangeFlyingType_IsCorrect()
        {
            Animal sparky = new Dog();
            sparky.SetFlyingAbility(new ItFlys());

            Assert.AreEqual(sparky.TryToFly(), "Flying High");
        }
    }
}
