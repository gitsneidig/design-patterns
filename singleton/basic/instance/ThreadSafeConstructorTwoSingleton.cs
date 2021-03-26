namespace Instance 
{
    public sealed class ThreadSafeConstructorTwoSingleton
    {
        // resource: https://csharpindepth.com/articles/singleton

        private static readonly ThreadSafeConstructorOneSingleton _instance = new ThreadSafeConstructorOneSingleton();

        // reading this will initialize the _instance
        public static readonly string GREETING = "Hi!";

        static ThreadSafeConstructorTwoSingleton()
        {

        }

        public static ThreadSafeConstructorTwoSingleton Instance
        {
            get {
                return Nested._instance;
            }
        }

        private class Nested
        {
            static Nested()
            {

            }

            internal static readonly ThreadSafeConstructorTwoSingleton _instance = new ThreadSafeConstructorTwoSingleton();
        }

    }


}