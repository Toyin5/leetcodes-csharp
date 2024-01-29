namespace twoSums.src;
public static class Solution
{
    public static string TwoSum(int[] nums, int target)
    {
        //This implements two sum in O(n^2) time
        int[] result = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if ((nums[i] + nums[j]) == target)
                {
                    result = [i, j];
                }
            }
        }
        return Prettify(result);
    }

    private static string Prettify(int[] nums)
    {
        string result = "[";
        for (int i = 0; i < nums.Length; i++)
        {
            result += nums[i];

            // Add a comma and space if it's not the last element
            if (i < nums.Length - 1)
            {
                result += ",";
            }
        }
        result += "]";
        return result;
    }
}