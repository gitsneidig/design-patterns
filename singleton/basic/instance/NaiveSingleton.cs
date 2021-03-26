namespace Instance 
{
    public sealed class NaiveSingleton
    {
        private static NaiveSingleton _instance;
        public static NaiveSingleton Instance
        {
            get { 
                
                if(_instance == null)
                {
                    _instance = new NaiveSingleton();
                }
                return _instance; 
            }
        }

    }
}