using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAInCSharp.DynamicProgramming;

internal static class DynamicProgrammingProblems
{
    /// <summary>
    /// Find the length of the longest increasing subsequence in an array of integers.
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public static int FindLIS(int[] numbers)
    {
        if(numbers.Length == 0) return 0;
        int[] dp = new int[numbers.Length];
        Array.Fill(dp, 1);
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 1; j < i + 1; j++)
            {
                if (numbers[i] < numbers[j])
                {
                    dp[i] = 0;
                }
            }
        }

        return dp.Max();
    }
}
