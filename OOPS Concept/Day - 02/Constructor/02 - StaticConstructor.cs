namespace StaticConstructorProblem
{
    //class with a static constructor and static property
    class StaticConstructor2
    {
        public static string Name { get; set; }

        // Static constructor initializes static property
        static StaticConstructor2()
        {
            Name = "Doremon"; // Sets the initial value of the static property
        }

        // Static method to display the current value of the static property
        public static void Display()
        {
            Console.WriteLine(Name); // Outputs the current value of the static property
        }
    }

    // Class inheriting from StaticConstructor2
    class StaticConstructorMain : StaticConstructor2
    {
        // Static method to demonstrate how static members are accessed
        public static void Solution()
        {
            Name = "Jenifar"; // Modifies the static property inherited from StaticConstructor2
            Console.WriteLine(Name); // Outputs the modified value ("Jenifar")
            Display(); // Calls the static method to display the current value ("Jenifar")
        }
    }
}
