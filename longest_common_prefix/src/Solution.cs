using System.Text;

namespace longest_common_prefix.src;
public static class Solution
{
    public static string LongestCommonPrefix(string[] strs)
    {
        StringBuilder result = new();
        Array.Sort(strs);
        var firstString = strs.First();
        var lastString = strs.Last();
        for (int i = 0; i < firstString.Length; i++)
        {
            if (firstString[i] == lastString[i])
            {
                result.Append(lastString[i]);
            }
            else
            {
                break;
            }
        }
        return result.ToString();
    }
}