using System;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Calculate Something.");
            var stay = true;

            do
            {
                Console.WriteLine("Menu");
                System.Console.WriteLine("Press 1 for Addition");
                System.Console.WriteLine("Press 2 for Subtraction");
                System.Console.WriteLine("Press 3 for Multiplication");
                System.Console.WriteLine("Press 4 for Division");
                System.Console.WriteLine("Press 5 forExit");

                var choice = Console.ReadLine();

                // var operatorInput = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // var input1 = (double)Console.ReadLine(); //explicit casting with exception
                        // var input2 = ()Console.ReadLine() as double; // explicint casting with null

                        var input1 = double.Parse(Console.ReadLine()); //explicit parsing with 0
                        double input2;
                        double.TryParse(Console.ReadLine(), out input2); // explicint parsing with exception

                        Add(input1, input2);
                        break;

                    case "2":
                        var input3 = double.Parse(Console.ReadLine()); //explicit parsing with 0
                        var input4 = double.Parse(Console.ReadLine()); //explicit parsing with 0


                        if (double.TryParse(Console.ReadLine(), out input1))
                        {
                            System.Console.WriteLine("valid");
                        }
                        else
                        {
                            System.Console.WriteLine("not valid");
                        }
                        Subtract(input3, input4);
                        break;

                    case "3":
                        var input5 = double.Parse(Console.ReadLine()); //explicit parsing with 0
                        var input6 = double.Parse(Console.ReadLine()); //explicit parsing with 0


                        if (double.TryParse(Console.ReadLine(), out input1))
                        {
                            System.Console.WriteLine("valid");
                        }
                        else
                        {
                            System.Console.WriteLine("not valid");
                        }
                        Multiply(input5, input6);
                        break;

                    default:
                        stay = false;
                        break;
                }
            } while (stay);
        }

        static void Add(double operand1, double operand2)
        {
            var addresult = operand1 + operand2;
            System.Console.WriteLine($"The answer is: {addresult}");
        }

        static void Subtract(double operand1, double operand2)
        {
            var addresult = operand1 - operand2;
            System.Console.WriteLine($"The answer is: {addresult}");
        }

        static void Multiply(double operand1, double operand2)
        {
            var addresult = operand1 * operand2;
            System.Console.WriteLine($"The answer is: {addresult}");
        }
    }
}