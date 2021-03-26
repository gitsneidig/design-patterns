namespace Instance 
{
    public sealed class ThreadSafeSingleton
    {

        private static ThreadSafeSingleton _instance = null;
        private static readonly object padlock = new object();

        public static ThreadSafeSingleton Instance
        {
            get {
                lock(padlock)
                {
                    if(_instance == null)
                    {
                        _instance = new ThreadSafeSingleton();
                    }
                }

                return _instance;
            }
        }

        private ThreadSafeSingleton()
        {

        }

    }
}