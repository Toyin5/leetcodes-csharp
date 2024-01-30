namespace valid_parenteses.src;
public static class Solution
{
    public static bool IsValid(string s)
    {
        string[] openings = ["(", "{", "["];
        string[] closings = [")", "}", "]"];
        int i = 0;
        foreach (char c in s)
        {
            if (openings.Contains(c.ToString())) i++;
            if (closings.Contains(c.ToString())) i--;
        }
        return i == 0;
    }
}