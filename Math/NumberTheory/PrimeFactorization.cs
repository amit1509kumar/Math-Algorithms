/*Prime Factorization in O(sqrt(N))
 * 
 * 
 * 
 * 
 * 
 */

using System;
namespace Math.NumberTheory
{
    public class PrimeFactorization
    {
        public PrimeFactorization()
        {
        }


        public void PrimeFactor(int n)
        {

            for(int i = 2; i * i <= n; i++)
            {

                if(n % i == 0)
                {
                    int cnt = 0;
                    while(n%i == 0)
                    {
                        cnt++;

                        n /= i;

                    }

                    Console.WriteLine($"{i} ^ {cnt}");
                }

                
            }

            if (n > 1)
                Console.WriteLine($"{n}^1");
        }
    }
}
