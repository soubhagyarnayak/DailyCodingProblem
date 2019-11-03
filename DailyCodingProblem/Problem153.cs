using System;
/*
 * Find an efficient algorithm to find the smallest distance (measured in number of words) between any two given words in a string.
 * For example, given words "hello", and "world" and a text content of "dog cat hello cat dog dog hello cat world", return 1 because there's only one word "cat" in between the two words.
 * 
 * HARD
 */

namespace DailyCodingProblem
{
    public static class Problem153
    {
        public static int FindSmallestDistance(string word1, string word2, string sentence)
        {
            string[] words = sentence.Split(" ");
            int result = int.MaxValue;
            bool findWord2 = false;
            int start = -1;
            int end = -1;
            int i = 0;
            for(; i < words.Length; i++)
            {
                if (words[i].Equals(word1))
                {
                    start = i;
                    findWord2 = true;
                    break;
                }
                if (words[i].Equals(word2))
                {
                    start = i;
                    findWord2 = false;
                    break;
                }
            }
            if (start == -1) // both words are missing
            {
                throw new ArgumentException("The sentence does not have any of the words");
            }
            for (; i < words.Length; i++)
            {
                if (findWord2)
                {
                    if (words[i].Equals(word2))
                    {
                        end = i;
                        int temp = end - start - 1;
                        if (temp < result) result = temp;
                        start = i;
                        findWord2 = false;
                    }
                    else if(words[i].Equals(word1))
                    {
                        start = i;
                    }
                }
                else
                {
                    if (words[i].Equals(word1))
                    {
                        end = i;
                        int temp = end - start - 1;
                        if (temp < result) result = temp;
                        start = i;
                        findWord2 = true;
                    }
                    else if (words[i].Equals(word2))
                    {
                        start = i;
                    }
                }
            }
            if (end == -1) //one of the words is missing
            {
                throw new ArgumentException("The sentence does not have one of the words");
            }
            return result;
        }
    }
}
