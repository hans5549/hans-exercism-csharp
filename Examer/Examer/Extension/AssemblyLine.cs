namespace Examer.Extension
{
    public static class AssemblyLine
    {
        public static double SuccessRate(int speed)
        {
            if (speed < 0 || speed > 10)
            {
                throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
            }

            if (speed == 0)
            {
                return 0.00;
            }
            else if (1 <= speed && speed <= 4)
            {
                return 1.00;
            }
            else if (5 <= speed && speed <= 8)
            {
                return 0.90;
            }
            else if (9 == speed)
            {
                return 0.80;
            }
            else if (10 == speed)
            {
                return 0.77;
            }
            else
            {
                throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
            }
        }

        public static double ProductionRatePerHour(int speed)
        {
            if (speed < 0 || speed > 10)
            {
                throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
            }

            double successRate = SuccessRate(speed);

            return speed * 221 * successRate;
        }

        public static int WorkingItemsPerMinute(int speed)
        {
            return (int)(ProductionRatePerHour(speed) / 60);
        }
    }
}
