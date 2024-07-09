namespace PartialMethodExample
{
    partial class PartialMethod1
    {
        public partial void Method1(int x);//partial method declaration
    }
    
    class MainPartialMethod
    {
        public static void Solution()
        {
            {
                PartialMethod1 partialMethod = new PartialMethod1();
                partialMethod.Method1(21);
            }
        }
    }
}
