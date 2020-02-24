using System;

namespace DesignPatterns.Patterns.ObserverPattern
{
    public class StockObserver : IObserver
    {
        private double _ibmPrice;
        private double _aaplPrice;
        private double _googPrice;

        private static int _observerIDTracker = 0;

        private int _observerID;

        private ISubject _stockGrabber;

        public StockObserver(ISubject stockGrabber)
        {
            _stockGrabber = stockGrabber;

            _observerID = ++_observerIDTracker;

            System.Console.WriteLine($"New IObserver { _observerID }");

            _stockGrabber.Register(this);
        }

        public void Update(double ibmPrice, double aaplPrince, double googPrice)
        {
            _ibmPrice = ibmPrice;
            _aaplPrice = aaplPrince;
            _googPrice = googPrice;

            PrintThePrices();
        }

        public static void ResetObserverIdTracker()
        {
            _observerIDTracker = 0;
        }

        private void PrintThePrices()
        {
            System.Console.WriteLine($"{_observerID} \nIBM: {_ibmPrice}\nAAPL: {_aaplPrice}\nGOOG: {_googPrice}\n");
        }
    }
}
