# Singleton pattern

Define a family of algorithms, encapsulate each one, and make them interchangeable. It lets the algorithm vary independently from clients that use it

## When to use the Singleton Pattern

* It is used when you want to eliminate the option of instantiating more than one object
* An example is a class that hods all the potential Scrabble letters and spits out new ones upon request
	* Each player will share the same potential letter list
	* Each player has their own set of letters