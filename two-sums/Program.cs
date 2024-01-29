using Prettify;
using twoSums.src;

int[] arr = new int[2];
int target;

//First example
arr = [2, 7, 11, 15]; target = 9;
Console.WriteLine("First example: " + Pretty.PrettifyArray<int>(Solution.TwoSumAdvanced(arr, target)));

//Second example
arr = [3, 2, 4]; target = 6;
Console.WriteLine("Second example: " + Pretty.PrettifyArray(Solution.TwoSumAdvanced(arr, target)));