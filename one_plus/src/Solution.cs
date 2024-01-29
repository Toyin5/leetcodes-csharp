using System.Numerics;

namespace two_plus.src;

public static class Solution
{
    public static int[] PlusOne(int[] digits)
    {
        List<int> result = [];
        //turn the array to longeger
        var num = BigInteger.Parse(string.Join("", digits));
        num++;
        foreach (char digit in num.ToString())
        {
            result.Add(int.Parse(digit.ToString()));
        }
        return [.. result];
    }
}