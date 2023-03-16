# Introduction

Observer Pattern is a design pattern that defines a one-to-many dependency between 
objects so that when one object changes state, all its dependents are notified and 
updated automatically.

## Code Structure
The classes and/or objects in this pattern are: 
* Subject (Stock)
  * knows its observers. Any number of Observer objects may observe a
  subject 
  * provides an interface for attaching and detaching Observer objects. 
* ConcreteSubject (CloudCoverStock)
  * stores state of interest to ConcreteObserver 
  * sends a notification to its observers when its state changes 
* Observer (IInvestor)
  * defines an updating interface for objects that should be notified of
    changes in a subject. 
* ConcreteObserver (Investor)
  * maintains a reference to a ConcreteSubject object 
  * stores state that should stay consistent with the subject's
  * implements the Observer updating interface to keep its state consistent
    with the subject's

## Use Cases

The Observer design pattern is commonly applied when programming a web application or a
desktop application where you often work with events and event handlers. Events and
Delegates are first class language features that act as the Subject and Observers
respectively as defined in the Observer pattern.

The Observer pattern facilitates good object-oriented designs as it promotes loose
coupling. Observers register and unregister themselves with subjects that maintain a list
of interested observers. The subject does not depend on any particular observer, as
long as the delegates are of the correct type for the event. 