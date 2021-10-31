using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.DesignPatterns
{
    public sealed class SingletonLazyLoading
    {
        private static SingletonLazyLoading _singleton;

        public static SingletonLazyLoading GetInstance()
        {
            if (_singleton is null)
            {
                _singleton = new SingletonLazyLoading();
            }

            return _singleton;
        }

        private SingletonLazyLoading()
        {
            Console.WriteLine("Instance created");
        }
    }

    public sealed class SingletonLazyLoadingUsingLazy
    {
        private static Lazy<SingletonLazyLoadingUsingLazy> instance = new Lazy<SingletonLazyLoadingUsingLazy>(() => new SingletonLazyLoadingUsingLazy());

        public static SingletonLazyLoadingUsingLazy GetInstance()
        {
            return instance.Value;
        }

        private SingletonLazyLoadingUsingLazy()
        {
            Console.WriteLine("Instance created");
        }
    }
}
