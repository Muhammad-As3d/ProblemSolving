namespace ProblemSolving._7_IsPalindromeSol;

public class IsPalindromeSol
{
    public static bool IsPalindrome(string s)
    {
        int i = 0;
        int j = s.Length - 1;

        while (i < j)
        {
            if (s[i] != s[j])
                return false;

            i++;
            j--;
        }

        return true;

    }
}
