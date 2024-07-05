namespace PrivateProtectedExampleProblem
{
    class BasePrivateProtectedExample
    {
        private protected int nValue = 21;
        private protected void Method()
        {
            Console.WriteLine("This is a private protected method.");
        }
    }

    class Derived : BasePrivateProtectedExample
    {
        public void AccessMethod()
        {
            // Accessing the private protected method from the base class
            Method();
        }

        public void Solution()
        {
            Console.WriteLine("This is private protected field value :" + nValue);
        }
    }

    class PrivateProtectedProgram
    {
        public static void MainMethod()
        {
            Derived b = new Derived();
            b.Solution();
            b.AccessMethod();
        }
    }
}
