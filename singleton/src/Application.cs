using System;

namespace singleton
{
    sealed class Application
    {
        private static readonly object mLock = new object();
        private static Application mApplication;

        static Application() {}
        private Application() {}

        public static Application GetInstance()
        {
            lock(mLock)
            {
                if(mApplication == null)
                {
                    mApplication = new Application();
                }
                return mApplication;
            }
        }

        public void Test()
        {
            Console.WriteLine("great success!");
        }
    }
}