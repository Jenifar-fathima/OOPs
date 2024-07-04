namespace PrivateConstructorProblem
{
    class PrivateConstructor
    {
        private static PrivateConstructor _instance;
        private PrivateConstructor() { }
        public static PrivateConstructor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PrivateConstructor();
                }
                return _instance;
            }
        }
    }
    class MainPrivateConstructor
    {
        public static void Solution()
        {
            PrivateConstructor instance1 = PrivateConstructor.Instance;
            PrivateConstructor instance2 = PrivateConstructor.Instance;

            Console.WriteLine(instance1 == instance2);
        }
    }
}