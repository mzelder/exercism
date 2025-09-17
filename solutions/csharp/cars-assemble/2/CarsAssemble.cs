static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        float successRate = 0f;
        if ((1 <= speed) && (speed <= 4)) {
            successRate = 1f;
        } else if ((5 <= speed) && (speed <= 8)) {
            successRate = 0.90f;
        } else if (speed == 9) {
            successRate = 0.8f;
        } else if (speed == 10) {
            successRate = 0.77f;
        }

        return successRate;
    }
    
    public static double ProductionRatePerHour(int speed) => 221 * speed * SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed) => (int)(ProductionRatePerHour(speed) / 60.0);
}
