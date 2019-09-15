namespace DailyCodingProblem
{
    /*
     * This problem was asked by Google.
     * Given a string of words delimited by spaces, 
     *  reverse the words in string. 
     *  For example, given "hello world here", return "here world hello"
     * Follow-up: given a mutable string representation, 
     *  can you perform this operation in-place?
     * 
     * MEDIUM
     */
    public static class Problem113
    {
        public static string ReverseWords(string input)
        {
            if(input == null || input.Length <= 1)
            {
                return input;
            }
            char[] chars = input.ToCharArray();
            int start = 0;
            for(int i = 0;i < chars.Length; i++)
            {
                if(chars[i] == ' ')
                {
                    Reverse(chars, start, i - 1);
                    start = i + 1;
                }
            }
            Reverse(chars, start, chars.Length - 1);
            Reverse(chars, 0, chars.Length - 1);
            return new string(chars);
        }

        private static void Reverse(char[] input, int start, int end)
        {
            for (int i = start, j = end;i < j; i++, j--)
            {
                char temp = input[i];
                input[i] = input[j];
                input[j] = temp;
            }
        }
    }
}
