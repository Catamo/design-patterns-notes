using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Basics.Inheritance;
using NUnit.Framework;
using DesignPatterns.Test.TestUtilities;

namespace DesignPatterns.Test.Basics
{
    public class InheritanceTests
    {
        [Test]
        public void Dog_SetName_IsCorrect()
        {
            Dog fido = new Dog();
            fido.Name = "Fido";

            Assert.AreEqual(fido.Name, "Fido");
        }

        [Test]
        public void Dog_SetWeight_LessThanZero_ThrowsError()
        {
            Dog fido = new Dog();

            Assert.Throws<Exception>(() => fido.Weight = -1);
        }

        [Test]
        public void Dog_DigHole_OutputsToConsole_IsCorrect()
        {
            Dog fido = new Dog();

            using (ConsoleOutput consoleOutput = new ConsoleOutput())
            {
                fido.DigHole();

                Assert.AreEqual("Dug a hole", consoleOutput.GetOuput());
            }
        }

        [Test]
        public void Dog_ChangeVar_ValueParameterDontChange_IsCorrect()
        {
            Dog fido = new Dog();

            using (ConsoleOutput consoleOutput = new ConsoleOutput())
            {
                int randNum = 10;

                fido.ChangeVar(randNum);
                Assert.AreEqual("randNum in method: 12", consoleOutput.GetOuput());

                Assert.AreEqual(randNum, 10);
            }
        }

        [Test]
        public void Dog_ChangeVar_ObjectParameterChange_IsCorrect()
        {
            Dog fido = new Dog();
            fido.Name = "Fido";

            Action<Dog> changeDogName = (dog) =>
            {
                dog.Name = "Marcus";
            };
            
            Assert.AreEqual(fido.Name, "Fido");

            changeDogName(fido);

            Assert.AreEqual(fido.Name, "Marcus");
        }
    }
}
