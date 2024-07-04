namespace AbstractClassExampleProblem
{
    // Abstract class with an abstract method
    abstract class AbstractClassExample
    {
        public abstract int AbstractMethod(); // Abstract method must be implemented by subclasses

        public void NormalMethod()
        {
            Console.WriteLine("This is a normal method in an abstract class");
        }
    }

    // Interface with a method
    interface IAbstractClassExample2
    {
        int AbstractMethod2(); // Interfaces don't use 'public' in method declarations
    }

    // Subclass implementing both the abstract class and the interface
    class SubClass : AbstractClassExample, IAbstractClassExample2
    {
        // Override the abstract method from the abstract class
        public override int AbstractMethod()
        {
            int nNum1 = 2 + 3;
            return nNum1;
        }

        // Implement the method from the interface
        public int AbstractMethod2()
        {
            return 21;
        }
    }

    // Another subclass implementing only the abstract class
    class SubClass2 : AbstractClassExample
    {
        // Override the abstract method from the abstract class
        public override int AbstractMethod()
        {
            int nNum2 = 8 + 3;
            return nNum2;
        }
    }

    // Main program to demonstrate the use of the above classes
    class AbstractProgram
    {
        public static void Solution()
        {
            // Create an instance of SubClass and use its methods
            SubClass subClass = new SubClass();
            int nResult = subClass.AbstractMethod();
            Console.WriteLine(nResult); // Outputs: 5

            // Create an instance of SubClass2 and use its method
            SubClass2 subClass2 = new SubClass2();
            int nResult2 = subClass2.AbstractMethod();
            Console.WriteLine(nResult2); // Outputs: 11

            // Use the method from the interface implemented by SubClass
            int result3 = subClass.AbstractMethod2();
            Console.WriteLine(result3); // Outputs: 21
        }
    }
}
