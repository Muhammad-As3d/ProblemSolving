namespace ProblemSolving._6_LongestPalindromicSubstring;

public class LongestPalindromicSubstringSol
{
    public static string LongestPalindrome(string s) //ccc
    {
        string result = s[0].ToString();

        for (int left = 0; left < s.Length - 1; left++)
        {
            for (int right = s.Length - 1; right > left; right--)
            {
                if (s[left] == s[right])
                {
                    string sub = s[left..(right + 1)];
                    {
                        if (IsPalindrome(sub) && sub.Length > result.Length)
                            result = sub;
                    }
                }
            }
        }

        return result;
    }

    private static bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (s[left] != s[right])
                return false;

            left++;
            right--;
        }

        return true;

    }
}
