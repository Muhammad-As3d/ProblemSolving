namespace ProblemSolving._3_ContainerWithMostWater;

public static class SolutionMaxArea
{
    public static int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;

        int maxArea = 0;

        while (left < right)
        {
            int width = right - left;

            int minHeight = Math.Min(height[left], height[right]);

            int area = width * minHeight;

            maxArea = Math.Max(maxArea, area);

            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }
}
