
/*
 * Sieve of Eratosthenes for calculating prime number upto a range(10 ^ 6) in O(nlong(nlogn))
 * 
 * 
 * 
 * 
 * 
 */
using System;
namespace Math.NumberTheory
{
    public class SieveofEratosthenes
    {
        public SieveofEratosthenes()
        {
        }


        public void Sieve(int n)
        {
            int[] isPrime = new int[n+1];


            for (int i = 1; i <= n; i++) isPrime[i] = 1;

            isPrime[0] = 0;
            isPrime[1] = 0;

            for(int i = 2; i * i <= n; i++)
            {
                if(isPrime[i] == 1)
                {
                    for(int j = i * i; j <= n; j += i)
                    {
                        isPrime[j] = 0;
                    }
                }
            }
        }
    }
}
