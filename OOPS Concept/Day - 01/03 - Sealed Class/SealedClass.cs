namespace SealedClassProblem
{
    class BaseClass
    {
        public virtual void Solution1()
        {
            Console.WriteLine("BasE Class - 1");
        }
        public virtual void Solution2()
        {
            Console.WriteLine("BasE Class - 2");
        }
        public virtual void Solution3()
        {
            Console.WriteLine("BasE Class - 3");
        }
    }
    sealed class SealedClass : BaseClass
    {
        public override void Solution1()
        {
            Console.WriteLine("Sealed Class - 1");
        }
        public override void Solution2()
        {
            Console.WriteLine("Sealed Class - 2");
        }
    }
    class AnotherClass : BaseClass
    {
        sealed public override void Solution3()
        {
            Console.WriteLine("Sealed Method - 3");
        }
        public virtual void Method1()
        {
            Console.WriteLine("Another class method");
        }
    }
    class FourthMethod : AnotherClass
    {
        //public override void Solution3()
        //{
        //    Console.WriteLine("Sealed Method - 4");
        //}      Cannot inherited because it is sealed
        public override void Method1()
        {
            Console.WriteLine("Another class overrides method");
        }

    }
    class MainClass
    {
        public static void Solution()
        {
            BaseClass baseClass = new BaseClass();
            baseClass.Solution1();
            baseClass.Solution2();
            baseClass.Solution3();
            SealedClass sealedClass = new SealedClass();
            sealedClass.Solution1();
            sealedClass.Solution2();
            AnotherClass baseClass1 = new AnotherClass();
            baseClass1.Solution3();
            baseClass1.Method1();
            FourthMethod fourthMethod = new FourthMethod();
            fourthMethod.Method1();
        }
    }
}

