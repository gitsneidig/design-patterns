namespace Instance 
{
    public sealed class ThreadSafeConstructorOneSingleton
    {
        // resource: https://csharpindepth.com/articles/singleton

        private static readonly ThreadSafeConstructorOneSingleton _instance = new ThreadSafeConstructorOneSingleton();

        // reading this will initialize the _instance
        public static readonly string GREETING = "Hi!";

        static ThreadSafeConstructorOneSingleton()
        {

        }

        public static ThreadSafeConstructorOneSingleton Instance
        {
            get {
                return _instance;
            }
        }

    }
}