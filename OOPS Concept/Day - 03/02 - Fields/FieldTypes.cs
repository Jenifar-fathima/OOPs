using System.Xml.Linq;

namespace FieldTypesProblem
{
    class FieldTypes
    {
        public int Name1;
        private int Name2;
        public readonly int Name3 ;
        public static int Name4;
        public const int Name5 = 23;

        public FieldTypes()
        {
            Name3 = 21;
        }
        public void Method()
        {
            Name2 = 20;
            Console.WriteLine("This is the base class method. We can access private field within the class => Name2 :" + Name2);
        }
    }
    class DerivedField: FieldTypes
    {
        public new void Method()
        {
            Name1 = 19;
            Console.WriteLine("The public field value can be accessed by derived class => Name1: " + Name1);

            //Name3 = 22; read only cant reassign 
            //Name5 = 20; const field cant reassign
            Console.WriteLine("The read only field value can be accessed by derived class, can modify through constructor at once => Name3: " + Name3);
            Console.WriteLine("The const field value can be accessed by derived class, but cant modify => Name5: " + Name5);
            
        }
        
    }
    class MainProgramFieldTypes
    {
        public static void Solution()
        {
            FieldTypes fieldTypes = new FieldTypes();
            fieldTypes.Method();
            FieldTypes.Name4 = 24;
            Console.WriteLine("Static variable can be accessed without creating an instance => Name4 : " + FieldTypes.Name4);
            
            DerivedField derivedField = new DerivedField();
            derivedField.Method();
        }
    }

}
