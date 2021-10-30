using System;

namespace CSharp.AdvanceTopics
{
    abstract class Parent
    {
        public virtual void Method()
        {
            Console.WriteLine("Method from Parent");
        }
    }

    class Derived : Parent
    {
        public override void Method()
        {
            Console.WriteLine("Method from Derived");
        }
    }


    class VirtualOverrideMethodCall
    {
        static void Main(string[] args)
        {
            Derived parent = new Derived();
            parent.Method();
            //Method from Derived
            Console.ReadLine();
        }
    }
}
