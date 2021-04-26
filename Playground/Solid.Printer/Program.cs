namespace Solid.Printer
{
    using System;
    using static System.Console;

    class Program
    {
        static void Main(string[] args)
        {
            IPrinter printerA = new Printer(new Configuration());
            Printer printerB = new Printer(new Configuration());

            WriteLine(printerA.Print("content"));
            WriteLine(printerB.Print("content"));


            Console.ReadKey();
        }
    }
}
