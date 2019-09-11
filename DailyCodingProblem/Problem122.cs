using System;
using System.Collections.Generic;
using System.Text;

/*
 * This question was asked by Zillow.
 * You are given a 2-d matrix where each cell represents number of coins in that cell. 
 * Assuming we start at matrix[0][0], and can only move right or down, 
 * find the maximum number of coins you can collect by the bottom right corner.
 * 
 * MEDIUM
 */

namespace DailyCodingProblem
{
    public class Problem122
    {
        public static int FindMaxCoins(int[,] input)
        {
            int[,] data = new int[input.GetLength(0), input.GetLength(1)];
            for(int i = 0; i < input.GetLength(0); i++)
            {
                data[i, 0] = input[i, 0];
            }
            for(int j = 0; j < input.GetLength(1); j++)
            {
                data[0, j] = input[0, j];
            }
            for(int i = 1; i < input.GetLength(0); i++)
            {
                for(int j=1; j < input.GetLength(1); j++)
                {
                    data[i, j] = input[i,j]+ Math.Max(data[i - 1, j], data[i, j - 1]);
                }
            }
            return data[data.GetLength(0) - 1, data.GetLength(1) - 1];
        }
    }
}
