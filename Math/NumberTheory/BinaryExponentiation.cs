/* Calculating A power B where a and b both are positive number using Binary Exponentiation in O(logn) timev Primality Test i
 * 
 * 
 * 
 * 
 * 
 */
using System;
namespace Math.NumberTheory
{
    public class BinaryExponentiation
    {
        public BinaryExponentiation()
        {
        }


        public int CalAPowerB(int a, int b)
        {
            if (a == 0 || b == 0) return 1;

            int res = CalAPowerB(a, b / 2);

            res *= res;

            if (b % 2 == 1) res *= a;

            return res;

        }

        public int CalAPowerB_Iterative(int a, int b)
        {
            int ans = 1;

            while(b > 0)
            {
                if (b % 2 == 1) ans *= a;

                a *= a;

                b /= 2;
            }

            return ans;
        }
    }
}
