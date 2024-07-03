## Class

- Reference type
- Blueprint for creating object
- Declaration of class: [access modifier] [classname] :public Program
- default access modifier of the class - internal
- default access modifier of the method - private
### Types:
 #### Abstract class: 
 - Abstract class cannot be instantiated
 - keyword: *abstract* class Classname{ }
 - Abtract class contains both abstract and non abstract methods
 - Method inside abstract class cannot be private
 - If there is at least one method abstract in a class, then the class must be abstract.
 - Abstract class cannot have sealed keyword because *sealed* has opposite meaning of the abstract which memebers of sealed class cannot be inherited.
 - Abstract method is implicitly a virtual method
 #### Partial Class:
 - Used to divide properties, methods, and events into multiple partial classes that are joined in a single class at compile time.
 - KeyWord: *partial* at the prefix of the class keyword
 - If you seal a specific part of a partial class, the entire class is sealed, the same as for an abstract class.
#### Sealed Class
- When applied to a class, the sealed modifier prevents other classes from inheriting from it
- KeyWord: *sealed*
- You can also use the sealed modifier on a method or property that overrides a virtual method or property in a base class
#### Static class
- Contains only static members.
- Can't be instantiated.
- Is sealed.
- Creating a static class is therefore basically the same as creating a class that contains only static members and a private constructor
- Can't contain Instance Constructors.