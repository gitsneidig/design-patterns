namespace Instance 
{
    public sealed class ThreadSafeConstructorOneSingleton
    {

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