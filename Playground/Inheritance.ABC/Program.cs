namespace Inheritance.ABC
{
    using System;
    using System.Text.Json;

    partial class Program
    {
        static void Main()
        {
#if INTERVIEW
            DoSomethingWith(new A());
            DoSomethingWith(new B());     
            DoSomethingWith(new C());
            DoSomethingWith(new D());
#endif
        }

#if INTERVIEW
        static void DoSomethingWith(B myType)
        {
            Console.WriteLine(JsonSerializer.Serialize(myType));
        }

        internal class A
        {
            public int Id { get; private set; } = new Random().Next(0, int.MaxValue);
        }

        internal class B : A
        {
            public readonly DateTime CreationDate = DateTime.Now;
        }

        internal sealed class C : B
        {
            public Guid Guid { get; } = Guid.NewGuid();
        }
       
        internal class D : C
        {
            public string Name => nameof(D);
        }
#endif
    }
}
