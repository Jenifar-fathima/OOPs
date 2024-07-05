using AnotherInternalClassExampleAccessModifiers;

namespace InternalClassExampleAccessModifiers
{
    internal class MainInternalClass : InternalClassExample 
    {
        public static void Solution()
        {
            InternalClassExample internalClassExample = new InternalClassExample();

            Console.WriteLine("The name that can be accessed form another file using internal keyword => Name:" + internalClassExample.Name);
            Console.WriteLine("internal Method Calling :");
            internalClassExample.Method();
        }
    }
}
namespace AnotherInternalClassExampleAccessModifiers
{
    internal class InternalExample
    {
        internal void InternalMethod()
        {
            Console.WriteLine("Internal method");
        }
    }
}
