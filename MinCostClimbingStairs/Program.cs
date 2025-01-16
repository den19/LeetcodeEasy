namespace MinCostClimbingStairs
{
    /*
    You are given an integer array cost where cost[i] is the cost of ith step on a staircase. Once you pay the cost, you can either climb one or two steps.
    You can either start from the step with index 0, or the step with index 1.
    Return the minimum cost to reach the top of the floor. 
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            var cost = new[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 };
            Console.WriteLine("Input costs is:");
            Array.ForEach(cost, x => Console.WriteLine(x));
            Console.WriteLine(MinCostClimbingStairs(cost));
            Console.ReadLine();
        }

        public static int MinCostClimbingStairs(int[] cost)
        {
            int n = cost.Length;
            int[] dp = new int[n];

            // Базовые случаи
            dp[0] = cost[0];
            dp[1] = cost[1];

            // Заполнение массива dp
            for (int i = 2; i < n; i++)
            {
                dp[i] = Math.Min(dp[i - 1], dp[i - 2]) + cost[i];
            }

            // Минимальная стоимость для последней ступеньки
            return Math.Min(dp[n - 1], dp[n - 2]);
        }
    }
}
