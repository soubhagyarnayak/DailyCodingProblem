using System;
using System.Collections.Generic;
using System.Text;

/**
 * This problem was asked by Google.
 * Given a string which we can delete at most k, return whether you can make a palindrome.
 * For example, given 'waterrfetawx' and a k of 2, you could delete f and x to get 'waterretaw'.
 * 
 * HARD
 */

namespace DailyCodingProblem
{
    public class Problem121
    {
        public static bool IsPalindromeNaive(string input, int k)
        {
            if(string.IsNullOrWhiteSpace(input) || input.Length == 1)
            {
                return true;
            }
            if(input[0] == input[input.Length - 1])
            {
                return IsPalindromeNaive(input.Substring(1, input.Length - 2),k);
            }
            else
            {
                if (k != 0)
                {
                    return IsPalindromeNaive(input.Substring(0, input.Length - 1), k - 1)
                        || IsPalindromeNaive(input.Substring(1, input.Length - 1), k - 1);
                }
            }
            return false;
        }

        public static bool IsPalindromeDP(string input, int k)
        {
            if (string.IsNullOrWhiteSpace(input) || input.Length == 1)
            {
                return true;
            }
            int[,] data = new int[input.Length, input.Length];
            for(int i = 0; i < input.Length; i++)
            {
                data[i, 0] = i;
            }
            for(int j = 0; j < input.Length; j++)
            {
                data[0, j] = j;
            }
            for(int i = 1; i < input.Length; i++)
            {
                for(int j = 1; j < input.Length; j++)
                {
                    if(input[i] == input[input.Length - j - 1])
                    {
                        data[i, j] = data[i - 1, j - 1];
                    }
                    else
                    {
                        data[i, j] = 1 + Math.Min(data[i, j - 1], data[i - 1, j]); 
                    }
                }
            }
            return data[input.Length - 1, input.Length - 1] <= 2*k;
        }
    }
}
