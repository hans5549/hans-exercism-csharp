namespace Examer.Extension
{
    public static class DifferenceOfSquares
    {
        public static int CalculateSquareOfSum(int max)
        {
            if (max == 0) return 0;

            int sum = (1 + max) * max / 2;

            return sum * sum;
        }

        public static int CalculateSumOfSquares(int max)
        {
            int sum = 0;
            for (int number = 1; number <= max; number++)
            {
                sum += (number * number);
            }

            return sum;
        }

        public static int CalculateDifferenceOfSquares(int max)
        {
            int num01 = CalculateSquareOfSum(max);
            int num02 = CalculateSumOfSquares(max);

            return num01 - num02;
        }
    }
}
