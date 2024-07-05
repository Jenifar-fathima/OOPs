### Default Access Specifiers in C#

#### **1. Top-Level Types (Classes)**

- **Default**: `internal`
- **Scope**: Accessible within the same assembly only.
- **Example**:
  ```
  // Default is internal
  class Person
  {
      // Members
  }
  ```

#### **2. Nested Types (Classes)**

- **Default**: `private`
- **Scope**: Accessible only within the containing class.
- **Example**:
  ```
  public class Container
  {
      // Default is private
      class Nested
      {
          // Members
      }
  }
  ```

#### **3. Fields**

- **Default**: `private`
- **Scope**: Accessible only within the containing class.
- **Example**:
  ```
  class Example
  {
      // Default is private
      int number;
  }
  ```

#### **4. Properties**

- **Default**: `private`
- **Scope**: Accessible only within the containing class.
- **Example**:
  ```
  class Example
  {
      // Default is private
      string Name { get; set; }
  }
  ```

#### **5. Methods**

- **Default**: `private`
- **Scope**: Accessible only within the containing class.
- **Example**:
  ```
  class Example
  {
      // Default is private
      void Show()
      {
          // Implementation
      }
  }
  ```

#### **6. Constructors**

- **Default**: Constructors inherit the default access level of private if no access modifier is specified.
- **Scope**: 
  - private by default, regardless of the class's access level.
  - Must be explicitly specified if a different access level is desired.
- **Example**:
```
    public class Example
    {
       // Constructor is implicitly private
       Example() { }
    }

    internal class ExampleInternal
    {
        // Constructor is implicitly private
        ExampleInternal() { }
    }
 ```

### Detailed Example

#### Top-Level Class (Default `internal`)
```
// Default is internal
class Person
{
    // Class members
}
```

#### Nested Class (Default `private`)
```
public class Outer
{
    // Default is private
    class Inner
    {
        // Nested class members
    }
}
```

#### Fields (Default `private`)
```
class Example
{
    // Default is private
    int count;
}
```

#### Properties (Default `private`)
```
class Example
{
    // Default is private
    string Name { get; set; }
}
```

#### Methods (Default `private`)
```
class Example
{
    // Default is private
    void Show()
    {
        // Implementation
    }
}
```

#### Constructors (Accessible only within the containing class)
```
    public class Example
    {
       // Constructor is implicitly private
       Example() { }
    }

    internal class ExampleInternal
    {
        // Constructor is implicitly private
        ExampleInternal() { }
    }
 ```

### Quick Reference Table

| **Member**               | **Default Access Specifier** | **Scope**                             |
|--------------------------|------------------------------|---------------------------------------|
| **Top-Level Types**      | `internal`                   | Accessible within the same assembly.  |
| **Nested Types**         | `private`                    | Accessible only within the containing class. |
| **Fields**               | `private`                    | Accessible only within the containing class. |
| **Properties**           | `private`                    | Accessible only within the containing class. |
| **Methods**              | `private`                    | Accessible only within the containing class. |
| **Constructors**         | `private`   | Accessible only within the containing class. |
