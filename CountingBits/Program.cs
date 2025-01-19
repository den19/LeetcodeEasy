namespace CountingBits
{
    /*
    Given an integer n, return an array ans of length n + 1 such that for each i (0 <= i <= n),
    ans[i] is the number of 1's in the binary representation of i. 

    Input: n = 2
    Output: [0,1,1]
    Explanation:
    0 --> 0
    1 --> 1
    2 --> 10
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            Console.WriteLine("n = 2");
            var result = CountBits(n);
            Array.ForEach(result, x => Console.WriteLine(x));
            Console.ReadLine();
        }

        public static int[] CountBits(int num)
        {
            int[] dp = new int[num + 1];

            dp[0] = 0;

            for (int i = 1; i <= num; ++i)
            {
                dp[i] = dp[i >> 1] + (i & 1);
            }

            return dp;
        }
    }
}
