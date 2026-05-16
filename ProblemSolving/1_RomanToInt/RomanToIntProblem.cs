namespace ProblemSolving._1_RomanToInt;

public static class RomanToIntProblem
{
    public static int RomanToInt(string s)
    {
        var symbols = new Dictionary<char, int>()
        {
            ['I'] = 1,
            ['V'] = 5,
            ['X'] = 10,
            ['L'] = 50,
            ['C'] = 100,
            ['D'] = 500,
            ['M'] = 1000,
        };

        int result = 0;

        for (int i = 0; i < s.Length - 1; i++)
        {
            Console.WriteLine($" symbol => {s[i]}");

            int value = symbols[s[i]];
            int nextValue = symbols[s[i + 1]];

            if (value < nextValue)
                result -= value;

            else
                result += value;
        }

        result += symbols[s[s.Length - 1]];

        Console.WriteLine(result);

        return result;
    }
}
