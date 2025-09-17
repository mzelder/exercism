class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => new int[] { 0, 2, 5, 3, 7, 8, 4 };
    
    public int Today() => birdsPerDay[birdsPerDay.Length - 1];

    public void IncrementTodaysCount() => birdsPerDay[birdsPerDay.Length - 1]++;

    public bool HasDayWithoutBirds()
    {
        foreach (int bird in birdsPerDay) {
            if (bird == 0) return true;
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int counter = 0;
        for (int i = 0; i < numberOfDays; i++) {
            counter += birdsPerDay[i];
        }
        return counter;
    }

    public int BusyDays()
    {
        int counter = 0;
        foreach (int bird in birdsPerDay) {
            if (bird >= 5) counter++;
        }
        return counter;
    }
}
