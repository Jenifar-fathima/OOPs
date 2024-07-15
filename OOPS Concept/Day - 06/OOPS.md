## Abstraction 

- Process of hiding certain details and show the necessary details
- In *Abstract class*, we cant create object. Implementation can be done through its subclass
- *Abstract method* doesn't have body. The functionality is provided by derived class 
- Using abstract and interface, we can implement abstraction

## Encapsulation

- Bundling related data into single unit
- Expose what necessary for the outside world

## Inheritance

- Subclass inherit the properties and methods of the parent class
- new properties and methods can be added on its own
- A subclass inherits all the members (fields, methods) from its superclass. Constructors are not members, so they are not inherited by subclasses, but the constructor of the superclass can be invoked from the subclass using base() method.


## PolyMorphism

- allows to perform single action (method) in different ways.
- virtual: Allows a method to be overridden in derived classes.
- override: Provides a new implementation of a virtual or abstract method inherited from a base class.
- new: Hides a member from a base class, providing a new implementation specific to the derived class without overriding the base class member.


