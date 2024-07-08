namespace AbstractPropertyProblem
{
    public class AbstractProperty
    {
        public static void Main()
        {
            Shape square = new Square { Side = 5 };
            Shape circle = new Circle { Radius = 3 };

            Console.WriteLine($"Square Area: {square.Area}");
            Console.WriteLine($"Circle Area: {circle.Area}");
        }
    }

    public abstract class Shape
    {
        public abstract double Area { get; }
    }

    public class Square : Shape
    {
        public double Side { get; set; }
        public override double Area => Side * Side;
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area 
        {
            get 
            {
                return Math.PI * Radius * Radius; 
            }
        } //public override double Area => Math.PI * Radius * Radius; ==> minimal code
    }
}