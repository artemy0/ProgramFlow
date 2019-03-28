namespace ProgramFlow
{
    static class MathStatisticsOperations
    {
        public static double GetAverage(double[] numbers)
        {
            double result = 0;
            for (int i = 0; i < numbers.Length; i++)
                result += numbers[i];
            double average = result / numbers.Length;
            return average;
        }

        public static double GetMin(double[] numbers)
        {
            double min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
                if (min > numbers[i])
                    min = numbers[i];
            return min;
        }

        public static double GetMax(double[] numbers)
        {
            double max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
                if (max < numbers[i])
                    max = numbers[i];
            return max;
        }

        public static double GetPercentageOfItemsInInterval(double[] numbers, double initialValue, double finalValue)
        {
            //the number of elements included in this interval
            int IncludedInInterval = 0;
            foreach (double item in numbers)
                if (initialValue <= item && item <= finalValue)
                    IncludedInInterval++;
            double percent = IncludedInInterval / (double)numbers.Length;
            return percent;
        }
    }
}
