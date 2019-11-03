
/*
 * This problem was asked by Facebook.
 * Given a start word, an end word, and a dictionary of valid words, find the shortest transformation sequence from start to end such that only one letter is changed at each step of the sequence, and each transformed word exists in the dictionary. If there is no possible transformation, return null. Each word in the dictionary have the same length as start and end and is lowercase.
 * For example, given start = "dog", end = "cat", and dictionary = {"dot", "dop", "dat", "cat"}, return ["dog", "dot", "dat", "cat"].
 * Given start = "dog", end = "cat", and dictionary = {"dot", "tod", "dat", "dar"}, return null as there is no possible transformation from dog to cat.
 * 
 * MEDIUM
 */

using System;
using System.Collections.Generic;

namespace DailyCodingProblem
{
    public static class Problem170
    {
        public static List<string> FindTransformPath(string start, string end, HashSet<string> dictionary)
        {
            var result = new List<string>();
            if (start.Equals(end))
            {
                return result;
            }
            result.Add(start);
            HashSet<string> visited = new HashSet<string>();
            var entriesToProcess = new Queue<Tuple<string, List<string>>>();
            entriesToProcess.Enqueue(Tuple.Create<string,List<string>>(start,result));
            while (entriesToProcess.Count > 0 )
            {
                var currentEntry = entriesToProcess.Dequeue();
                string current = currentEntry.Item1;
                for (int i = 0; i < current.Length; i++)
                {
                    for (char j = 'a'; j <= 'z'; j++)
                    {
                        if (start[i] != j)
                        {
                            var temp = current.ToCharArray();
                            temp[i] = j;
                            string tempString = new string(temp);
                            if (end.Equals(tempString))
                            {
                                currentEntry.Item2.Add(tempString);
                                return currentEntry.Item2;
                            }
                            if (dictionary.Contains(tempString) && !visited.Contains(tempString))
                            {
                                var tempPath = new List<string>(currentEntry.Item2);
                                tempPath.Add(tempString);
                                visited.Add(tempString);
                                entriesToProcess.Enqueue(Tuple.Create(tempString, tempPath));
                            }
                        }
                    }
                }
            }
            return null;
        }
    }
}
