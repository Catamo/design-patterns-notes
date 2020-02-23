using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Basics.Inheritance;
using DesignPatterns.Test.TestUtilities;
using NUnit.Framework;

namespace DesignPatterns.Test.Basics
{
    public class PolymorphismTests
    {
        [Test]
        public void Animals_GetBarkIsDifferent_IsCorrect()
        {
            Animal doggy = new Dog();
            Animal kitty = new Cat();

            Assert.AreEqual(doggy.Sound, "Bark");
            Assert.AreEqual(kitty.Sound, "Meow");
        }

        [Test]
        public void Animals_ArrayGetBarkIsDifferent_IsCorrect()
        {
            Animal doggy = new Dog();
            Animal kitty = new Cat();

            Animal[] animals = new Animal[2];
            animals[0] = doggy;
            animals[1] = kitty;

            Assert.AreEqual(animals[0].Sound, "Bark");
            Assert.AreEqual(animals[1].Sound, "Meow");
        }

        [Test]
        public void Animals_SpeakAnimal_IsCorrect()
        {
            Action<Animal> speakAnimal = (animal) =>
            {
                Console.WriteLine("Kitty says: " + animal.Sound);
            };
            
            Animal kitty = new Cat();

            using (ConsoleOutput consoleOutput = new ConsoleOutput())
            {
                speakAnimal(kitty);
                Assert.AreEqual("Kitty says: Meow", consoleOutput.GetOuput());
            }
        }

        [Test]
        public void Animal_Extension_DigHoleWorks_IsCorrect()
        {
            Animal doggy = new Dog();

            using (ConsoleOutput consoleOutput = new ConsoleOutput())
            {
                ((Dog)doggy).DigHole();
                Assert.AreEqual("Dug a hole", consoleOutput.GetOuput());
            }
        }
    }
}
