using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.DesignPatterns
{
    sealed class SingletonEarelyLoading
    {
        private static SingletonEarelyLoading _singleton = new SingletonEarelyLoading();

        public static SingletonEarelyLoading GetInstance()
        {
            if (_singleton is null)
            {
                _singleton = new SingletonEarelyLoading();
            }

            return _singleton;
        }

        private SingletonEarelyLoading()
        {
            Console.WriteLine("Instance created");
        }
    }
}
