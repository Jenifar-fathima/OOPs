namespace HiddenPropertiesProblem
{
    public class TestHiddenProperties
    {
        public static void Solution()
        {
            Employee emp = new Employee { Name = "ManiRaj" };
            Manager mgr = new Manager { Name = "BS" };
            Ceo ceo = new Ceo { Role = "CEO" };

            
            Console.WriteLine("Employee Name: " + emp.Name);  
            Console.WriteLine("Manager Name: " + mgr.Name);
            Console.WriteLine("Role :" + ceo.Role);
            mgr.Name = "Sekar";
            Console.WriteLine("Modified Manager Name: " + mgr.Name);   
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public string Role { get; set; }
    }

   
    public class Manager : Employee
    {
        public new string Name
        {
            get { return base.Name + ", Manager"; }
            set { base.Name = value; }
        }
    }
    public class Ceo : Employee
    {
        public new string Role
        {
            get 
            {
                return base.Role + ", M&S Software solution private limited"; 
            }
            set
            {
                base.Role = value;
            }
        }
    }

}