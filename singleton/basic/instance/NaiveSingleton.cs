namespace Instance 
{
#nullable enable
    public sealed class NaiveSingleton
    {
        private static NaiveSingleton? _instance;
        public static NaiveSingleton Instance
        {
            get {

                return _instance ??= new NaiveSingleton();
            }
        }

    }
}