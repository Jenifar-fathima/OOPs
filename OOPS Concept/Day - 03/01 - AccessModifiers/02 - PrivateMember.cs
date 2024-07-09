namespace PrivateMemberAccessModifiers
{
    class PrivateMember
    {
        // Private fields
        private string _Name;
        private int _Age;

        // Public setter method
        public void SetName(string Name)
        {
            if (_Name == null)
            {
                _Name = Name;
            }
        }

        // Public getter method
        public string GetName()
        {
            return _Name;
        }

        // Public method to demonstrate access to private members
        public void Display()
        {
            Console.WriteLine("The private field _Name can be accessed by the public methods getter and setter. The private field name is {0}", GetName());
            Method(); // Calling the private method
        }

        // Private method
        private void Method()
        {
            _Name = "Jenifar"; // Accessing private field
            _Age = 21;         // Accessing private field
            Console.WriteLine($"This is a private method. The members are Name :{_Name}, Age: {_Age}");
        }
    }

    class MainPrivateMethod
    {
        public static void Solution()
        {
            PrivateMember privateMember = new PrivateMember();
            // privateMember.Method(); - Method() is inaccessible due to its protection level

            Console.Write("Enter the name: ");
            string name = Console.ReadLine();

            privateMember.SetName(name);  // Set private field via public method
            privateMember.Display();  // Display private field via public method
        }
    }
}
