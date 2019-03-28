namespace ProgramFlow
{
    static class MathOperations
    {
        public static double Addition(params double[] numbers)
        {
            double result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
                result += numbers[i];
            return result;
        }

        public static double Subtraction(params double[] numbers)
        {
            double result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
                result -= numbers[i];
            return result;
        }

        public static double Multiplection(params double[] numbers)
        {
            double result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
                result *= numbers[i];
            return result;
        }

        public static double Division(params double[] numbers)
        {
            double result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
                result /= numbers[i];
            return result;
        }
        
        public static ulong Factorial(ulong number)
        {
            if (number == 1 || number == 0)
                return 1;
            return number * Factorial(number - 1);
        }
    }
}
