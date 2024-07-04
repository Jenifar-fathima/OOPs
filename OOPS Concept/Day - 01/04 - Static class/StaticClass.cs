namespace StaticClassProblem
{
    class StaticClass
    {
        public static void Solution()
        {
            //static class members
            Console.WriteLine(StaticExample.Method1(10));
            StaticExample.nValue += 1;
            Console.WriteLine(StaticExample.nValue);

            //non static class but static member
            Console.WriteLine(StaticMethod.Method2(150));

            //non-static class and non static member
            StaticMethod s = new StaticMethod();
            Console.WriteLine(s.Method3(100));       //for non static member we need to create object for accessing it.
        }
    }
    static class StaticExample   
    {
        public static int Method1(int nNum)
        {
            return nNum+nNum;
        }
        public static int nValue = 11;
    }
    class StaticMethod
    {
        public static int Method2(int nNum) 
        {
            return nNum+nNum;
        }
        public int Method3(int nNum)
        {
            return nNum+nNum;
        }
    }
    //class AnotherClass : StaticExample
    //{
            //cannot derive from static class 'base class'
    //}



}
