namespace InheritanceProgram
{
    class Superclass
    {
        private int number;
        public Superclass(int number)
        {
            this.number = number;
            Console.WriteLine($"Superclass constructor invoked with number: {number}");
        }

        public void Display()
        {
            Console.WriteLine($"Number: {number}");
        }
    }

    class Subclass : Superclass
    {
        private string name;
        public Subclass(int number, string name) : base(number)
        {
            this.name = name;
            Console.WriteLine($"Subclass constructor invoked with name: {name}");
        }

        public void DisplayName()
        {
            Console.WriteLine($"Name: {name}");
        }
    }

    class MainInheritanceClass
    {
        public static void Solution()
        {
            Subclass obj = new Subclass(21, "Jenifar");            
            obj.Display();
            obj.DisplayName();
        }
    }

}
