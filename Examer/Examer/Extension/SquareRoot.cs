namespace Examer.Extension
{
    internal class SquareRoot
    {
        public static int Root(int number)
        {
            int num = 0;
            while (num * num < number)
            {
                num++;
            }

            return num;
        }
    }
}
