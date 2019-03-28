using System;

namespace ProgramFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //menu
                Console.WriteLine("1. + operation");
                Console.WriteLine("2. - operation");
                Console.WriteLine("3. * operation");
                Console.WriteLine("4. / operation");
                Console.WriteLine("5. ! operation");
                Console.WriteLine("esc. to exit");

                //select a menu item
                Console.Write("select: ");
                ConsoleKeyInfo select = Console.ReadKey(false);
                Console.WriteLine();

                //exit?
                if (select.Key == ConsoleKey.Escape)
                    return;

                //array for the data in which the results will be stored
                double[] numbers;
                //calculation of results in accordance with the selected operation
                double result;
                switch (select.KeyChar)
                {
                    case '1':
                    case '+':
                        numbers = ManuallyFillDataArray();
                        result = MathOperations.Addition(numbers);
                        PrintOperation(numbers, '+', result);
                        break;
                    case '2':
                    case '-':
                        numbers = ManuallyFillDataArray();
                        result = MathOperations.Subtraction(numbers);
                        PrintOperation(numbers, '-', result);
                        break;
                    case '3':
                    case '*':
                        numbers = ManuallyFillDataArray();
                        result = MathOperations.Multiplection(numbers);
                        PrintOperation(numbers, '*', result);
                        break;
                    case '4':
                    case '/':
                        numbers = ManuallyFillDataArray();
                        result = MathOperations.Division(numbers);
                        PrintOperation(numbers, '/', result);
                        break;
                    case '5':
                    case '!':
                        Console.Write("enter the number: ");
                        ulong number = Convert.ToUInt64(Console.ReadLine());
                        result = MathOperations.Factorial(number);
                        Console.WriteLine($"Result: {number}! = {result}");
                        break;
                    default:
                        Console.WriteLine("this key doesn't exist.");
                        break;
                }

                //Waiting for any key to repeat all actions.
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
            }
        }

        //Что делать с данным методом? Лучше ли вывести данные в Main(). Как это сделать?
        public static double[] ManuallyFillDataArray()
        {
            //creating an array for the elements over which the operation will be performed
            double[] numbers;
            while (true)
            {
                Console.Write("enter the amount of numbers on which you want to perform the operation: ");
                int size = Convert.ToInt32(Console.ReadLine());
                //to perform an operation you need at least two elements
                if (size <= 1)
                {
                    Console.Write("The number of elements over which operations are performed cannot be less than one or one! ");
                    continue;
                }
                numbers = new double[size];
                break;
            }

            //input of each element from the keyboard
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"enter {i + 1}th number: ");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }

            return numbers;
        }

        //Что делать с данным методом? Лучше ли вывести данные в Main(). Как это сделать?
        public static void PrintOperation(double[] numbers, char operationSymbol, double result)
        {
            //sample output: Result: 54 + 34 + 8 = 96
            Console.Write("Result: ");
            int i;
            for (i = 0; i < numbers.Length - 1; i++)
            {
                Console.Write($"{numbers[i]} {operationSymbol} ");
            }
            Console.WriteLine($"{numbers[i]} = {result}");
        }
    }
}
