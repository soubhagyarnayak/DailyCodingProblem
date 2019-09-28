
/*
 * This problem was asked by Google. 
 * Find the minimum number of coins required to make n cents.
 * You can use standard American denominations, that is, 1¢, 5¢, 10¢, and 25¢.
 * For example, given n = 16, return 3 since we can make it with a 10¢, a 5¢, and a 1¢.
 * 
 * HARD
 */
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DailyCodingProblem
{
    public static class Problem138
    {
        public static int FindMinCoins(int[] coins, int target)
        {
            Dictionary<int, int> cache = new Dictionary<int, int>();
            int result = FindMinCoins(coins, target, cache);
            if(result == int.MaxValue)
            {
                result = -1; //impossible scenario
            }
            return result;
        }

        private static int FindMinCoins(int[] coins, int target, Dictionary<int,int> cache)
        {
            if (target == 0)
            {
                return 0;
            }
            if (!cache.ContainsKey(target))
            {
                int min = int.MaxValue;
                foreach(int coin in coins)  
                {
                    if(coin <= target)
                    {
                        int result = FindMinCoins(coins, target - coin, cache);
                        if (result != int.MaxValue && min > result+1)
                        {
                            min = result+1;
                        }
                    }
                }
                cache[target] = min;
            }
            return cache[target];
        }
    }
}
