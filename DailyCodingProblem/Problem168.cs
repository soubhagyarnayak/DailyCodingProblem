using System;

/***
 * This problem was asked by Facebook.
 * Given an N by N matrix, rotate it by 90 degrees clockwise.
 * 
 * For example, given the following matrix:
 [[1, 2, 3],
 [4, 5, 6],
 [7, 8, 9]]
 you should return:
 [[7, 4, 1],
 [8, 5, 2],
 [9, 6, 3]]
 * Follow-up: What if you couldn't use any extra space?
 */
namespace DailyCodingProblem
{
    public static class Problem168
    {
        public static void RotateBy90Degrees(int[][] matrix)
        {
            if(matrix == null || matrix.Length < 2)
            {
                throw new ArgumentException("The specified matrix is not valid.");
            }
            if(matrix.Length != matrix[0].Length)
            {
                throw new ArgumentException("The specified input is not a NxN matrix");
            }
            int n = matrix.Length;
            for(int i = 0; i < n / 2; i++)
            {
                for(int j = i; j < n-i-1; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[n -j -1][i];
                    matrix[n -j -1][i] = matrix[n -i -1][n -j -1];
                    matrix[n -i -1][n -j -1] = matrix[j][n -i -1];
                    matrix[j][n -i -1] = temp;
                }
            }
        }
    }
}
