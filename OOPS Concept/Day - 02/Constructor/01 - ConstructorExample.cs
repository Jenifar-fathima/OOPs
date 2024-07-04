namespace ConstructorExampleProblem
{
    class ConstructorExample
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int PhoneNumber { get; set; }
        public ConstructorExample()
        {
            Name = "Jenifar";
            Age = 21;
        }

        public ConstructorExample(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public ConstructorExample(string name, int age, int phoneNumber) : this(name, age) //Constructor Chaining
        {
            PhoneNumber = phoneNumber;
        }

        public void Display()
        {
            Console.WriteLine($"Name :{Name}, Age :{Age}");
        }
        public void Display2()
        {
            Console.WriteLine($"Name :{Name}, Age :{Age},Phone Number: {PhoneNumber}");
        }
    }
    class MainClass
    {
        public static void Solution()
        {
            ConstructorExample constructorExample1 = new ConstructorExample();
            constructorExample1.Display();
            ConstructorExample constructorExample = new ConstructorExample("Shabeer",25);//PARAMETERIZED CONSTRUCTOR
            constructorExample.Display();
            ConstructorExample constructorExample2 = new ConstructorExample("Azar", 25, 12345678);
            constructorExample2.Display2();
        }
    }
}