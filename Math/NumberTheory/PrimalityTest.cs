using System;
namespace Math.NumberTheory
{
    public class PrimalityTest
    {
        public PrimalityTest()
        {
        }

        public bool IsPrime(int n)
        {
            if (n == 1) return false;

            for(int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
    }
}
