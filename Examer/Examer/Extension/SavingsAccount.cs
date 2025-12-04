namespace Examer.Extension
{
    public static class SavingsAccount
    {
        public static float InterestRate(decimal balance)
        {
            if (balance < 0)
            {
                return ((float)3.213);
            }
            else if (balance < 1000)
            {
                return ((float)0.5);
            }
            else if (1000 <= balance && balance < 5000)
            {
                return ((float)1.621);
            }
            else
            {
                return ((float)2.475);
            }
        }

        public static decimal Interest(decimal balance)
        {
            decimal rate = (decimal)(InterestRate(balance) / 100);
            return balance * rate;
        }

        public static decimal AnnualBalanceUpdate(decimal balance)
        {
            decimal interest = Interest(balance);
            return balance + interest;
        }

        public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
        {
            int count = 0;
            while (balance < targetBalance)
            {
                balance = AnnualBalanceUpdate(balance);
                count++;
            }

            return count;
        }
    }
}
