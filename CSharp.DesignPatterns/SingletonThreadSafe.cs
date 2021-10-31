using System;

namespace CSharp.DesignPatterns
{
    public sealed class SingletonThreadSafe
    {
        private static SingletonThreadSafe _singleton = new SingletonThreadSafe();
        private static object _lock = new object();

        public static SingletonThreadSafe GetInstance()
        {
            lock (_lock)
            {
                if (_singleton is null)
                {
                    _singleton = new SingletonThreadSafe();
                }
                return _singleton;
            }
        }

        private SingletonThreadSafe()
        {
            Console.WriteLine("Instance created");
        }
    }
}
