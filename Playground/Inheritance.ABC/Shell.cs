using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using static System.Console;

namespace Inheritance.ABC
{
    internal partial class Program
    {
#if INTERVIEW
        private static void DoSomethingWith(A a)
        {
            WriteLine("AAAAAAAAAAAAAAA");
        }

        private static void DoSomethingWith(D d)
        {
            WriteLine("DDDDDDDDDDDDDDD");
        }
#endif
    }
}
