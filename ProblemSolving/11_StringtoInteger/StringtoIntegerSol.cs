namespace ProblemSolving._11_StringtoInteger;

public class StringtoIntegerSol
{
    public static int MyAtoi(string s)
    {
        if (string.IsNullOrEmpty(s))
            return 0;

        int index = 0;
        int n = s.Length;

        while (index < n && s[index] == ' ')
            index++;

        int sign = 1;
        if (index < n && (s[index] == '+' || s[index] == '-'))
        {
            sign = s[index] == '-' ? -1 : 1;
            index++;
        }

        long result = 0;

        while (index < n && char.IsDigit(s[index]))
        {
            result = result * 10 + (s[index] - '0');

            if (sign * result > int.MaxValue)
                return int.MaxValue;

            if (sign * result < int.MinValue)
                return int.MinValue;

            index++;
        }

        return (int)(sign * result);
    }

}
