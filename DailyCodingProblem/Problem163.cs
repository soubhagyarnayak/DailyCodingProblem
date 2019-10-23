using System;
using System.Collections.Generic;

/*
 * This problem was asked by Jane Street.
 * Given an arithmetic expression in Reverse Polish Notation, write a program to evaluate it.
 * The expression is given as a list of numbers and operands. For example: [5, 3, '+'] should return 5 + 3 = 8.
 * or example, [15, 7, 1, 1, '+', '-', '/', 3, '*', 2, 1, 1, '+', '+', '-'] should return 5, since it is equivalent to ((15 / (7 - (1 + 1))) * 3) - (2 + (1 + 1)) = 5.
 * You can assume the given expression is always valid.
 * 
 * HARD
 * 
 */

namespace DailyCodingProblem
{
    public static class Problem163
    {
        public static double EvaluateReversePolishNotation(string[] input)
        {
            if(input == null || input.Length == 0)
            {
                throw new ArgumentException("The specified input to evaluate is null or empty");
            }
            
            Stack<double> operands = new Stack<double>();
            for (int i = 0; i <input.Length; i++)
            {
                string data = input[i];
                switch (data)
                {
                    case "+":
                        double right = operands.Pop();
                        double left = operands.Pop();
                        operands.Push(left + right);
                        break;
                    case "-":
                        right = operands.Pop();
                        left = operands.Pop();
                        operands.Push(left - right);
                        break;
                    case "*":
                        right = operands.Pop();
                        left = operands.Pop();
                        operands.Push(left * right);
                        break;
                    case "/":
                        right = operands.Pop();
                        left = operands.Pop();
                        operands.Push(left / right);
                        break;
                    default:
                        operands.Push(Convert.ToDouble(data));
                        break;
                }
            }
            return operands.Pop();
        }
    }
}
