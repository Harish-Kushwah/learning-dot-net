namespace FirstProject
{
    internal class Functions
    {
        public static long Factorial(int n)
        {
            // Test for invalid input.
            if ((n < 0) || (n > 20))
            {
                return -1;
            }

            // Calculate the factorial iteratively rather than recursively.
            long tempResult = 1;
            for (int i = 1; i <= n; i++)
            {
                tempResult *= i;
            }
            return tempResult;
        }

        public static bool IsPrime(int n)
        {
            if (n < 0)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <=n/2; ++i)
                {
                    if (n % i == 0) return false;
                }
                return true;
            }

        }
    }
}
