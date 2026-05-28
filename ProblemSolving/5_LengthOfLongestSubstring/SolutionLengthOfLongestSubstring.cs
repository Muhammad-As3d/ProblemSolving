namespace ProblemSolving._5_LengthOfLongestSubstring;

public static class SolutionLengthOfLongestSubstring
{
    public static int LengthOfLongestSubstring(string s)
    {
        HashSet<char> set = [];

        int left = 0;
        int maxLength = 0;

        for (int right = 0; right < s.Length; right++)
        {
            while (set.Contains(s[right]))
            {
                set.Remove(s[left]);
                left++;
            }

            set.Add(s[right]);

            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}