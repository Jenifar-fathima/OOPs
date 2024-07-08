namespace StaticPropertyProblem
{
    public class StaticProperty
    {
        public static void Solution()
        {
            Console.WriteLine($"Value of Pi: {MathUtility.Pi}");
            Console.WriteLine($"Value of E: {MathUtility.E}");
        }
    }
    public class MathUtility
    {
        public static double Pi => 3.14159;
        public static double E => 2.71828;
    }
}