namespace PropertiesRequiredProblem
{
    abstract class PropertiesRequired
    {
        public  abstract int age { get; set; }
        public  string Name { get; set; }
        public int Id { get; set; }

        public PropertiesRequired(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    class SubClass : PropertiesRequired
    {
        public SubClass(int id, string name) : base(id, name)
        {
            Console.WriteLine($"Entered Name: {Name}, ID: {Id}");
        }
        public override int age { get; set; }
    }
    class MainPropertiesRequired 
    {
        public static void Solution()
        {
            Console.Write("Enter the name: ");
            string strName = Console.ReadLine();

            Console.Write("Enter the ID: ");
            _ = int.TryParse(Console.ReadLine(), out int nId);

            SubClass subClass = new SubClass(nId, strName);

        }
    }
}
