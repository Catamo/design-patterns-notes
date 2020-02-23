using System;
using System.Collections.Generic;
using DesignPatterns.Basics.AbstractClassesAndInterfaces;
using DesignPatterns.Test.TestUtilities;
using NUnit.Framework;

namespace DesignPatterns.Test.Basics
{
    public class AbstractClassesAndInterfacesTests
    {
        [Test]
        public void Creature_SetName_IsCorrect()
        {
            Creature creature = new Giraffe();
            creature.setName("Frank");

            Assert.AreEqual(creature.getName(), "Frank");
        }

        [Test]
        public void ILiving_SetName_IsCorrect()
        {
            ILiving living = new Monkey();
            living.setName("Son Goku");

            Assert.AreEqual(living.getName(), "Son Goku");
        }
    }
}
