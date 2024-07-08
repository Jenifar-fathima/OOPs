namespace InterfacePropertyProblem
{
    interface IProperty
    {
        string Name { get; set; }
        int Age { get; set; }
    }

    class InterfaceProperty : IProperty
    {
        private string _name;
        private int _age;

        public string Name
        {
            get => _name;
            set => _name = value; 
        }

        public int Age
        {
            get => _age;
            set => _age = value; 
        }
    }

    class MainInterfaceProperty
    {
        public static void Solution()
        {
            InterfaceProperty interfaceProperty = new InterfaceProperty();

            Console.Write("Enter name: ");
            interfaceProperty.Name = Console.ReadLine();

            Console.Write("Enter age: ");
            _ = int.TryParse(Console.ReadLine(), out int age);
            interfaceProperty.Age = age;

            Console.WriteLine($"Name: {interfaceProperty.Name}, Age: {interfaceProperty.Age}");
        }
    }
}
