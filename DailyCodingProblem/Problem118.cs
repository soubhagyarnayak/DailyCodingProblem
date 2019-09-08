using System;
using System.Collections.Generic;
using System.Text;
/*
 * This problem was asked by Google.
 * Given a sorted list of integers, square the elements and give the output in sorted order.
 * For example, given [-9, -2, 0, 2, 3], return [0, 4, 4, 9, 81].
 * [Easy]
 */

namespace DailyCodingProblem
{
    public static class Problem118
    {
        public static List<int> ReturnSortedSquares(List<int> input)
        {
            if(input == null || input.Count == 0)
            {
                return input;
            }
            List<int> result = new List<int>();
            int pointOfChange = FindPointOfSignChange(input);
            int i = pointOfChange;
            int j = pointOfChange - 1;
            while(i < input.Count && j >= 0)
            {
                if (Math.Abs(input[i]) < Math.Abs(input[j]))
                {
                    result.Add(input[i] * input[i]);
                    i++;
                }
                else
                {
                    result.Add(input[j] * input[j]);
                    j--;
                }
            }
            while (j >= 0)
            {
                result.Add(input[j] * input[j]);
                j--;
            }
            while (i < input.Count)
            {
                result.Add(input[i] * input[i]);
                i++;
            }
            return result;
        }

        private static int FindPointOfSignChange(List<int> input)
        {
            if (input[0] > 0)
            {
                return 0;
            }
            if (input[input.Count - 1] < 0)
            {
                return input.Count - 1;
            }
            int pointOfChange = 0;
            for (int index = 1; index < input.Count; index++)
            {
                if (input[index] >= 0)
                {
                    pointOfChange = index;
                    break;
                }
            }
            return pointOfChange;
        }
    }
}
