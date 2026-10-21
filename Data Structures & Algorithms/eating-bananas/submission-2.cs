public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int minPossibleSpeed = 1;
        int maxPossibleSpeed = piles.Max();

        while (minPossibleSpeed <= maxPossibleSpeed)
        {
            int speed = minPossibleSpeed
                + (maxPossibleSpeed - minPossibleSpeed) / 2;

            if (CanFinish(piles, h, speed))
                maxPossibleSpeed = speed - 1;
            else
                minPossibleSpeed = speed + 1;
        }

        return minPossibleSpeed;
    }

    private bool CanFinish(int[] piles, int h, int speed)
    {
        long totalHours = 0;

        foreach(int pile in piles)
        {
            int hoursForPile = (int)Math.Ceiling((double)pile / speed);
            totalHours += hoursForPile;

            if(totalHours > h)
                return false;
        }

        return true;
    }
}
