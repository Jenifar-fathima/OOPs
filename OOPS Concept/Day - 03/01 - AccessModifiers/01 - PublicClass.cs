namespace AccessModifierExample
{
    public class PublicClass
    {
        public string Name;
        public int Age;
        public void Method()
        {
            Console.WriteLine("This is public method");
        }
    }
    class MainPublicClass
    {
        public static void Solution()
        {
            PublicClass publicClass = new PublicClass();
            publicClass.Name = "Jenifar";
            publicClass.Age = 21;
            Console.WriteLine($"Name:{publicClass.Name}\nAge:{publicClass.Age}");
            publicClass.Method();
        }
    }
}