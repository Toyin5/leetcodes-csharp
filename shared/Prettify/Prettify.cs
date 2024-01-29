namespace Prettify;
public static class Pretty
{
    public static string PrettifyArray<T>(T[] nums)
    {
        string result = "[";
        for (int i = 0; i < nums.Length; i++)
        {
            result += nums[i];

            // Add a comma and space if it's not the last element
            if (i < nums.Length - 1)
                result += ",";
        }
        result += "]";
        return result;
    }
}