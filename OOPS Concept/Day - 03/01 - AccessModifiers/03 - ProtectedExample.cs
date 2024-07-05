namespace ProtectedExampleAccessModifiers
{
    class ProtectedExample
    {
        protected string Name;
        protected int Age;

        protected ProtectedExample(string name, int age)
        {
            Name = name;
            Age = age;
        }
        protected void Method()
        {
            Console.WriteLine($"{Name}, {Age}");
        }
    }

    class ProtectedExampleMain : ProtectedExample
    {
        public ProtectedExampleMain(string name, int age) : base(name, age)
        {
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"{Name} | {Age}");
        }

        public static void Solution()
        {
            ProtectedExampleMain protectedExample = new ProtectedExampleMain("Jenifar", 21);
            ProtectedExampleMain protectedExample1 = new ProtectedExampleMain("Azar", 25);
            protectedExample.Method(); // Accessing protected method
            protectedExample1.DisplayDetails(); // Accessing protected members via method
        }
    }
}
