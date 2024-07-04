namespace PartialClassExampleProblem
{
    partial class PartialClassExample
    {
        public static void Solution4()
        {
            Console.WriteLine("Four");
        }
    }
    abstract class BaseClass
    {
        public abstract string AbsMethod();
        public static string BaseMethod() 
        {
            return $"Base class method";
        }
    }
}
