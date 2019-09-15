namespace DailyCodingProblem
{
    /*
     * This problem was asked by Facebook.
     * Write a function that rotates a list by k elements. 
     * For example, [1, 2, 3, 4, 5, 6] rotated by two becomes [3, 4, 5, 6, 1, 2]. 
     * Try solving this without creating a copy of the list. 
     * How many swap or move operations do you need?
     * 
     * MEDIUM
     */
    public static class Problem126
    {
        public static int[] RotateByReversal(int[] input, int k)
        {
            if(input == null || input.Length == 0)
            {
                return input;
            }
            if (k > input.Length)
            {
                k = k % input.Length;
            }
            if (k == input.Length)
            {
                return input;
            }
            Reverse(input, 0, k-1);
            Reverse(input, k, input.Length - 1);
            Reverse(input, 0, input.Length - 1);
            return input;
        }

        public static int[] RotateByJuggling(int[] input, int k)
        {
            if (input == null || input.Length == 0)
            {
                return input;
            }
            if (k > input.Length)
            {
                k = k % input.Length;
            }
            if (k == input.Length)
            {
                return input;
            }
            for(int i = 0; i < k; i++)
            {
                int temp = input[i];
                int p = i;
                while (true)
                {
                    int q = p + k;
                    if(q >= input.Length)
                    {
                        q = q - input.Length;
                    }
                    if(q == i)
                    {
                        break;
                    }
                    input[p] = input[q];
                    p = q;
                }
                input[p] = temp;
            }
            return input;
        }

        private static void Reverse(int[] input, int start, int end)
        {
            for(int i = start, j = end; i < j; i++, j--)
            {
                int temp = input[j];
                input[j] = input[i];
                input[i] = temp;
            }
        }
    }
}
