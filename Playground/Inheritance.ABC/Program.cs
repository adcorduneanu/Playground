namespace Inheritance.ABC
{
    using Newtonsoft.Json;
    using System;

    class Program
    {
        static void Main()
        {
            //DoSomethingWith(new A());
            //DoSomethingWith(new B());     
            //DoSomethingWith(new C());     
            //DoSomethingWith(new D());
        }

        static void DoSomethingWith(B myType)
        {
            Console.WriteLine(JsonConvert.SerializeObject(myType));
        }

        internal class A
        {
            public int Id { get; private set; } = new Random().Next(0, int.MaxValue);
        }

        internal class B : A
        {
            public readonly DateTime CreationDate = DateTime.Now;
        }

        internal class C : B
        {
            public Guid Guid { get; } = Guid.NewGuid();
        }

        internal sealed class D : C
        {
            public string Name => nameof(D);
        }
    }
}
