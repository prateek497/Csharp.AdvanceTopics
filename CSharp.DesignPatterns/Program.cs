using System;
using System.Threading.Tasks;

namespace CSharp.DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //SingletonEarelyLoading singleton = SingletonEarelyLoading.GetInstance();
            //SingletonEarelyLoading newsingleton = SingletonEarelyLoading.GetInstance();

            //var singleton = SingletonLazyLoadingUsingLazy.GetInstance();
            //var newsingleton = SingletonLazyLoadingUsingLazy.GetInstance();

            var singleton = SingletonThreadSafe.GetInstance();
            var newsingleton = SingletonThreadSafe.GetInstance();

            Parallel.Invoke(
                () => SingletonThreadSafe.GetInstance(),
                () => SingletonThreadSafe.GetInstance(),
                () => SingletonThreadSafe.GetInstance());
            Console.ReadLine();
        }
    }
}
