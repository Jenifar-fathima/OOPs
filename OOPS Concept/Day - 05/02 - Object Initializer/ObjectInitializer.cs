namespace ObjectInitializerProblem
{
    class ObjectInitializer
    {
        public static void Solution()
        {
            ExampleClass exampleClass = new ExampleClass
            {
                Name = "Jenifar",
                Age = 21
            };
            Console.WriteLine($"Name: {exampleClass.Name}\nAge : {exampleClass.Age}");
        }
    }

    class ExampleClass
    {
        public string Name { get; set; } 
        public int Age { get; set; }

        private string _name;
        private int _age;

        public ExampleClass()
        {
            _name = Name;
            _age = Age; 
        }
    }
}
