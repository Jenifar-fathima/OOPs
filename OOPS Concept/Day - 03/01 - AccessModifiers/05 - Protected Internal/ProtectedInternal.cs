namespace ExampleNamespace
{
    // Base class in the same assembly
    public class BaseClass
    {
        // protected internal member
        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("Protected Internal Method in BaseClass");
        }
    }

    // Derived class in the same assembly
    public class DerivedClass : BaseClass
    {
        public void CallProtectedInternal()
        {
            // Can access the protected internal method
            ProtectedInternalMethod();
        }
    }

    // Non-derived class in the same assembly
    public class AnotherClass
    {
        public void CallProtectedInternal()
        {
            BaseClass baseObj = new BaseClass();
            // Can access the protected internal method
            baseObj.ProtectedInternalMethod();
        }
    }
   
}

namespace DifferentNamespace
{
    using ExampleNamespace;

    // Derived class in a different assembly
    public class ExternalDerivedClass : BaseClass
    {
        public void CallProtectedInternal()
        {
            // Can access the protected internal method
            ProtectedInternalMethod();
        }
    }

    // Non-derived class in a different assembly
    public class ExternalNonDerivedClass
    {
        public void AttemptAccess()
        {
            BaseClass baseObj = new BaseClass();
            // Cannot access the protected internal method
            // baseObj.ProtectedInternalMethod(); // This line would cause a compile error
        }
    }
}
