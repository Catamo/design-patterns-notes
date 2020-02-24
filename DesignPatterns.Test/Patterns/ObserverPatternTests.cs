using DesignPatterns.Patterns.ObserverPattern;
using DesignPatterns.Test.TestUtilities;
using NUnit.Framework;

namespace DesignPatterns.Test.Patterns
{
    public class ObserverPatternTests
    {
        [Test]
        public void StockGrabber_UpdatesObserver_IsCorrect()
        {
            StockGrabber stockGrabber = new StockGrabber();

            StockObserver.ResetObserverIdTracker();
            StockObserver observer1 = new StockObserver(stockGrabber);

            using (ConsoleOutput consoleOutput = new ConsoleOutput())
            {
                const string consoleOutputFormat = "{0} \nIBM: {1}\nAAPL: {2}\nGOOG: {3}\n\n";
                string consoleOutputExpected = string.Empty;

                stockGrabber.SetIBMPrince(197.00);
                consoleOutputExpected += string.Format(consoleOutputFormat, 1, 197.00, 0, 0);
                Assert.AreEqual(consoleOutputExpected, consoleOutput.GetOuput(false));

                stockGrabber.SetAaplPrince(677.00);
                consoleOutputExpected += string.Format(consoleOutputFormat, 1, 197.00, 677.00, 0);
                Assert.AreEqual(consoleOutputExpected, consoleOutput.GetOuput(false));

                stockGrabber.SetGoogPrince(676.00);
                consoleOutputExpected += string.Format(consoleOutputFormat, 1, 197.00, 677.00, 676.00);
                Assert.AreEqual(consoleOutputExpected, consoleOutput.GetOuput(false));
            }
        }

        [Test]
        public void StockGrabber_UpdatesMultipleObservers_IsCorrect()
        {
            StockGrabber stockGrabber = new StockGrabber();

            StockObserver.ResetObserverIdTracker();
            StockObserver observer1 = new StockObserver(stockGrabber);
            StockObserver observer2 = new StockObserver(stockGrabber);

            using (ConsoleOutput consoleOutput = new ConsoleOutput())
            {
                const string consoleOutputFormat = "{0} \nIBM: {1}\nAAPL: {2}\nGOOG: {3}\n\n";
                string consoleOutputExpected = string.Empty;

                stockGrabber.SetIBMPrince(197.00);
                consoleOutputExpected += string.Format(consoleOutputFormat, 1, 197.00, 0, 0);
                consoleOutputExpected += string.Format(consoleOutputFormat, 2, 197.00, 0, 0);
                Assert.AreEqual(consoleOutputExpected, consoleOutput.GetOuput(false));

                stockGrabber.SetAaplPrince(677.00);
                consoleOutputExpected += string.Format(consoleOutputFormat, 1, 197.00, 677.00, 0);
                consoleOutputExpected += string.Format(consoleOutputFormat, 2, 197.00, 677.00, 0);
                Assert.AreEqual(consoleOutputExpected, consoleOutput.GetOuput(false));

                stockGrabber.SetGoogPrince(676.00);
                consoleOutputExpected += string.Format(consoleOutputFormat, 1, 197.00, 677.00, 676.00);
                consoleOutputExpected += string.Format(consoleOutputFormat, 2, 197.00, 677.00, 676.00);
                Assert.AreEqual(consoleOutputExpected, consoleOutput.GetOuput(false));
            }
        }

        [Test]
        public void StockGrabber_UnregisterObserver_IsCorrect()
        {
            StockGrabber stockGrabber = new StockGrabber();

            StockObserver.ResetObserverIdTracker();
            StockObserver observer1 = new StockObserver(stockGrabber);
            StockObserver observer2 = new StockObserver(stockGrabber);

            using (ConsoleOutput consoleOutput = new ConsoleOutput())
            {
                const string consoleOutputFormat = "{0} \nIBM: {1}\nAAPL: {2}\nGOOG: {3}\n\n";
                string consoleOutputExpected = string.Empty;

                stockGrabber.SetIBMPrince(197.00);
                consoleOutputExpected += string.Format(consoleOutputFormat, 1, 197.00, 0, 0);
                consoleOutputExpected += string.Format(consoleOutputFormat, 2, 197.00, 0, 0);
                Assert.AreEqual(consoleOutputExpected, consoleOutput.GetOuput(false));

                stockGrabber.Unregister(observer2);
                consoleOutputExpected += "Observer 2 deleted\n";
                Assert.AreEqual(consoleOutputExpected, consoleOutput.GetOuput(false));

                stockGrabber.SetAaplPrince(677.00);
                consoleOutputExpected += string.Format(consoleOutputFormat, 1, 197.00, 677.00, 0);
                Assert.AreEqual(consoleOutputExpected, consoleOutput.GetOuput(false));

                stockGrabber.SetGoogPrince(676.00);
                consoleOutputExpected += string.Format(consoleOutputFormat, 1, 197.00, 677.00, 676.00);
                Assert.AreEqual(consoleOutputExpected, consoleOutput.GetOuput(false));
            }
        }
    }
}
