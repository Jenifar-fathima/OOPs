namespace PropertiesBasicExampleProblem
{
    class PropertiesBasicExample
    {
        private string _name;
        private int _age;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 18)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Age should be greater than 18!!");
                }
            }
        }

        public void Display()
        {
            Console.WriteLine($"{Name} | {Age}");
        }
    }

    class PropertiesMain
    {
        public static void Solution()
        {
            PropertiesBasicExample propertiesBasicExample = new PropertiesBasicExample();

            Console.Write("Enter the name: ");
            string strName = Console.ReadLine();
            propertiesBasicExample.Name = strName;

            Console.Write("Enter the age: ");
            int.TryParse(Console.ReadLine(), out int nAge);
            propertiesBasicExample.Age = nAge;

            propertiesBasicExample.Display();
        }
    }
}
