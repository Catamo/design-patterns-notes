# Observer Pattern

Is a software design pattern in which an object, called the subject, maintains a list of its dependents, called observers, and notifies them automatically of any state changes, usually by calling one of their methods.

## When to use the Observer Pattern

* When you need many other objects to receive an update when another object changes
	* Stock market with thousands of stock needs to send updates to objec representing individual stocks
	* The Subject (publisher) sends many stocks to the Observers
	* The Observers (subscribers) takes the ones they want and use them
	* Loose coupling is a benefit
	* The Subject (publisher) doesn't need to know anythin about the Observers (subscribers)
*Negatives: The Subject (publisher) may send updates that don't matter to the Observer (subscriber)

![ObserverPattern](../../Assets/ObserverPattern.png)