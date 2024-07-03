namespace PartialClassExampleProblem
{
     partial class PartialClassExample :BaseClass
    {
        public  void Solution()
        {
            //PartialClassExample partialClassExample = new SubClass();
            //Console.WriteLine(partialClassExample.AbstractMethod());
            Console.WriteLine("One");
            Solution1();
            Solution2();
            Solution4();
            Console.WriteLine(AbsMethod());
        }
    }
    partial class PartialClassExample
    {
        
        public static void Solution1()
        {
            Console.WriteLine("Two");
        }
    }
    partial class PartialClassExample
    {
        public static void Solution2()
        {
            Console.WriteLine("Three");
        }
    }

    //class SubClass : PartialClassExample   Cannot be inherit the sealed class even it is partial class
    //{
    //    body
    //}

    //class SubClass : PartialClassExample  
    //{
    //    public override string AbstractMethod()
    //    {
    //        return BaseMethod();
    //    }
    //}

    partial class PartialClassExample: BaseClass
    {
        public override string AbsMethod()
        {
            return $"Inheritance is applicable to partial class";
        }
    }
}
