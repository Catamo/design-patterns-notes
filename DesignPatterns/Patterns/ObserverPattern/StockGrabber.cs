using System.Collections.Generic;

namespace DesignPatterns.Patterns.ObserverPattern
{
    public class StockGrabber : ISubject
    {
        private List<IObserver> _observers;
        private double _ibmPrice;
        private double _aaplPrice;
        private double _googPrice;

        public StockGrabber()
        {
            _observers = new List<IObserver>();
        }

        public void NotifyObserver()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(_ibmPrice, _aaplPrice, _googPrice);
            }
        }

        public void Register(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            int observerIndex = _observers.IndexOf(observer);

            System.Console.WriteLine($"Observer { observerIndex + 1 } deleted");

            _observers.RemoveAt(observerIndex);
        }

        public void SetIBMPrince(double newIBMPrice)
        {
            _ibmPrice = newIBMPrice;
            NotifyObserver();
        }

        public void SetAaplPrince(double newAaplPrice)
        {
            _aaplPrice = newAaplPrice;
            NotifyObserver();
        }

        public void SetGoogPrince(double newGoogPrice)
        {
            _googPrice= newGoogPrice;
            NotifyObserver();
        }
    }
}
