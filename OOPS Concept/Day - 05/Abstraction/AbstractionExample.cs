namespace AbstractionExampleProblem
{
    class AbstractionExample
    {
        public static void Solution()
        {
            AbstractClass myObject = new SubClass();
            myObject.Method();
        }
    } 
    abstract class AbstractClass
    {
        public abstract void Method();
    }

    class SubClass : AbstractClass
    {
        public override void Method()
        {
            Console.WriteLine("This is the implementation of the abstract method in the subclass.");
        }
    }
}