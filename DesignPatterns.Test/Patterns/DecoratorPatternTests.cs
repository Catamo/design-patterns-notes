using DesignPatterns.Patterns.DecoratorPattern;
using DesignPatterns.Test.TestUtilities;
using NUnit.Framework;

namespace DesignPatterns.Test.Patterns
{
    public class DecoratorPatternTests
    {
        [Test]
        public void Decorator_PizzaWithAllToppingsProcessOutputWorks_IsCorrect()
        {
            using (ConsoleOutput consoleOutput = new ConsoleOutput())
            {
                IPizza basicPizza = new Mozzarella(new TomatoSauce(new PlainPizza()));

                string expectedConsoleOutput = "Adding Dough\nAdding Sauce\nAdding Moz\n";

                Assert.AreEqual(expectedConsoleOutput, consoleOutput.GetOuput(false));
            }
        }

        [Test]
        public void Decorator_PizzaWithAllToppingsIngredientsAndCostWorks_IsCorrect()
        {
            IPizza basicPizza = new Mozzarella(new TomatoSauce(new PlainPizza()));

            Assert.AreEqual("Thin Dough, Tomato Sauce, Mozzarella", basicPizza.GetDescription());
            Assert.AreEqual(4.85, basicPizza.GetCost());
        }

        [Test]
        public void Decorator_PizzaWithCheeseProcessOutputWorks_IsCorrect()
        {
            using (ConsoleOutput consoleOutput = new ConsoleOutput())
            {
                IPizza basicPizza = new Mozzarella(new PlainPizza());

                string expectedConsoleOutput = "Adding Dough\nAdding Moz\n";

                Assert.AreEqual(expectedConsoleOutput, consoleOutput.GetOuput(false));
            }
        }

        [Test]
        public void Decorator_PizzaWithCheeseIngredientsAndCostWorks_IsCorrect()
        {
            IPizza basicPizza = new Mozzarella(new PlainPizza());

            Assert.AreEqual("Thin Dough, Mozzarella", basicPizza.GetDescription());
            Assert.AreEqual(4.5, basicPizza.GetCost());
        }
    }
}
