namespace VirtualPropertyProblem
{
    class VirtualProperty
    {
        public static void Solution()
        {
            Animal dog = new Dog();
            Animal cat = new Cat();

            Console.WriteLine($"Dog sound: {dog.Sound}");
            Console.WriteLine($"Cat sound: {cat.Sound}");
        }
    }
    public class Animal
    {
        public virtual string Sound => "Animal sound";
    }

    public class Dog : Animal
    {
        public override string Sound
        {
            get
            {
                return "Woof";
            }
        }
        
    }
    public class Cat : Animal
    {
        public override string Sound => "Meow";
    }


}
