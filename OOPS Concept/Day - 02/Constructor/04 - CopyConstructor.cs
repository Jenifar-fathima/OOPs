namespace CopyConstructorProblem
{
    class CopyConstructor
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public CopyConstructor(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public CopyConstructor(CopyConstructor copy)
        {
            Name = copy.Name;
            Age = copy.Age;
        }
    }
    class MainCopyConstructor
    {
        public static void Solution()
        {
            CopyConstructor c1 = new CopyConstructor("Jenifar", 21);
            CopyConstructor c2 = new CopyConstructor(c1);

            Console.WriteLine($"Name: {c2.Name}\nAge: {c2.Age}");
        }
    }
}
