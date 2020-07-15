using System;

namespace HelloCSharp

{
    class Program
    {
        static void Main()
        
        {

            Console.Write("Enter first name: ");
            string inputA = Console.ReadLine(); //eager, datatype is explicit prior to content of Readline
            Console.Write("Enter last name: ");
            var inputB = Console.ReadLine(); //lazy, datatype is given based oncontent of ReadLine

            Console.WriteLine("Yo " + inputA + " " + inputB + ", how are you?");
            Console.WriteLine("{0} {1}", inputA, inputB);
            Console.WriteLine($"{inputA} {inputB}");

            Console.ReadLine();

        }
    }
}