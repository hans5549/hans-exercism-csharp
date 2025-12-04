namespace Examer.Extension
{
    public static class Darts
    {
        public static int Score(double x, double y)
        {
            double distance = Math.Sqrt(x * x + y * y);
            if (distance <= 1)
            {
                return 10;
            }
            else if (1 < distance && distance <= 5)
            {
                return 5;
            }
            else if (5 < distance && distance <= 10)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
