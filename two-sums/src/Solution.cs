namespace twoSums.src;
public static class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        //This implements two sum in O(n^2) time
        int[] result = new int[2];
        for (int i = 0; i < nums.Length; i++)
            for (int j = i + 1; j < nums.Length; j++)
                if ((nums[i] + nums[j]) == target)
                {
                    result = [i, j];
                    break;
                }
        return result;
    }

    public static int[] TwoSumAdvanced(int[] nums, int target)
    {
        //define a hashmap of integers
        Dictionary<int, int> hashMap = [];
        int[] result = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];
            if (hashMap.TryGetValue(diff, out int value))
                result = [value, i];
            else
                hashMap.TryAdd(nums[i], i);
        }

        return result;
    }

}