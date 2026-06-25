namespace ProblemSolving._9_ReverseIntegerSol;

public static class ReverseInteger
{
    public static int Reverse(int x)
    {
        int result = 0;

        while (x != 0)
        {
            int digit = x % 10;
            x /= 10;

            if (result < int.MinValue / 10 || (result == int.MinValue / 10 && digit < -8))
                return 0;

            result = result * 10 + digit;
        }

        return result;
    }
}
