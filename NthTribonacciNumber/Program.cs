namespace NthTribonacciNumber
{
    /*
     The Tribonacci sequence Tn is defined as follows: 

     T0 = 0, T1 = 1, T2 = 1, and Tn+3 = Tn + Tn+1 + Tn+2 for n >= 0.

     Given n, return the value of Tn.

 
     Example 1:

     Input: n = 4
     Output: 4
     Explanation:
     T_3 = 0 + 1 + 1 = 2
     T_4 = 1 + 1 + 2 = 4
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tribonacci number");
            Console.WriteLine("Input n:");
            var n = Console.ReadLine();
            Console.WriteLine(Tribonacci(Convert.ToInt32(n)));
            Console.ReadLine();
        }

        public static int Tribonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n <= 2)
            {
                return 1;
            }

            int a = 0, b = 1, c = 1;
            for (int i = 3; i <= n; ++i)
            {
                int next = a + b + c;
                a = b;
                b = c;
                c = next;
            }

            return c;
        }
    }
}
