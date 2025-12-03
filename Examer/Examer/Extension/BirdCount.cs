namespace Examer.Extension;

public class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return [0, 2, 5, 3, 7, 8, 4];
    }

    public int Today()
    {
        return this.birdsPerDay.Length == 0 ? 0 : this.birdsPerDay[^1];
    }

    public void IncrementTodaysCount()
    {
        if (this.birdsPerDay.Length == 0)
        {
            return;
        }
        int count = this.birdsPerDay[^1];
        this.birdsPerDay[^1] = count + 1;
    }

    public bool HasDayWithoutBirds()
    {
        if (this.birdsPerDay.Length == 0)
        {
            return false;
        }
        int index = Array.IndexOf(this.birdsPerDay, 0);
        return index >= 0;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        if (numberOfDays is 0 or <= 1)
        {
            return 0;
        }
        
        int sum = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            sum += this.birdsPerDay[i];
        }
        return sum;
    }

    public int BusyDays()
    {
        return this.birdsPerDay.Length == 0 ? 0 : birdsPerDay.Count(birdCount => birdCount >= 5);
    }
}