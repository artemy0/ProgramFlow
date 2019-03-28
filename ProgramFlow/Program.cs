using System;

namespace ProgramFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the math statistics program.");


            //collection of items
            double[] numbers;
            do
            {
                //enter the number of items
                Console.Write("enter the amount of numbers to which the statistics will be applied: ");
                int size = Convert.ToInt32(Console.ReadLine());
                //creating an array with more than zero elements
                if (0 < size)
                {
                    numbers = new double[size];
                    break;
                }
                else
                {
                    //error
                    Console.Write("the number of elements must be greater than zero. ");
                    continue;
                }
            } while (true);

            //input of each element from the keyboard
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"enter {i + 1}th number: ");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }


            Console.WriteLine("press any key to continue");
            Console.ReadKey();
            Console.Clear();


            //the cycle that will constantly offer you to perform any action
            while (true)
            {
                //array
                DisplayArray(numbers);
                //menu
                DisplayMenu();

                //select a menu item
                Console.Write("select: ");
                ConsoleKeyInfo select = Console.ReadKey(false);
                Console.WriteLine();

                //perform any statistical operation.
                double result; //to store the result of any statistical operation
                switch (select.Key)
                {
                    case ConsoleKey.Escape:
                        return;

                    case ConsoleKey.D1:
                        result = MathStatisticsOperations.GetAverage(numbers);
                        Console.WriteLine($"Average value = {result}");
                        break;

                    case ConsoleKey.D2:
                        result = MathStatisticsOperations.GetMin(numbers);
                        Console.WriteLine($"Min value = {result}");
                        break;

                    case ConsoleKey.D3:
                        result = MathStatisticsOperations.GetMax(numbers);
                        Console.WriteLine($"Max value = {result}");
                        break;

                    //the determination of which part of a certain range is contained in the original data set
                    case ConsoleKey.D4:
                        Console.Write("initial value: ");
                        double initialValue = Convert.ToDouble(Console.ReadLine());
                        Console.Write("final value: ");
                        double finalValue = Convert.ToDouble(Console.ReadLine());
                        //in simple words, the belonging of some interval to another one
                        result = MathStatisticsOperations.GetPercentageOfItemsInInterval(numbers, initialValue, finalValue);
                        Console.WriteLine($"the percent of elements included in the interval [{initialValue}, {finalValue}] = {result:p}");
                        break;

                    default:
                        Console.WriteLine("this key doesn't exist.");
                        break;
                }


                //waiting for any key to repeat all actions
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("1. find average value");
            Console.WriteLine("2. find the minimum value");
            Console.WriteLine("3. find the maximum value");
            Console.WriteLine("4. find the percentage of the elements of a certain interval");
            Console.WriteLine("esc. to exit");
        }

        public static void DisplayArray(double[] numbers)
        {
            Console.Write("Array: ");
            foreach (double item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            //it will look like: Array: 34 18 98\n
        }


        //public static double[] CreateArray(int size)
        //{
        //    //determining whether the transferred size value is greater than 0
        //    if (size <= 0)
        //        throw new Exception("the number of elements must be greater than zero. ");

        //    double[] numbers = new double[size];

        //    //input of each element from the keyboard
        //    FillArrayManually(numbers);

        //    return numbers;
        //}

        //public static void FillArrayManually(double[] numbers)
        //{
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        Console.Write($"enter {i + 1}th number: ");
        //        numbers[i] = Convert.ToDouble(Console.ReadLine());
        //    }
        //}
    }
}
