# Singleton pattern

Is a software design pattern that restricts the instantiation of a class to one "single" instance. This is useful when exactly one object is needed to coordinate actions across the system. 

## When to use the Singleton Pattern

* It is used when you want to eliminate the option of instantiating more than one object
* An example is a class that hods all the potential Scrabble letters and spits out new ones upon request
	* Each player will share the same potential letter list
	* Each player has their own set of letters