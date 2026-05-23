namespace ProblemSolving._2_FindMedianSortedArrays;

public class FindMedianSortedArraysProblem
{
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int[] result = [.. nums1, .. nums2];

        result.Sort();

        if (result.Length % 2 != 0)
            return result[(result.Length - 1) / 2];

        double median = result[(result.Length / 2) - 1] + result[(result.Length / 2)];

        return median / 2;
    }
}
