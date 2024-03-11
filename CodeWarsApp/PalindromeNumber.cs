using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal static class PalindromeNumber
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            int[] tmpArr = new int[32];
            int i = 0;
            int inputValue = x;
            while (x >= 10) 
            {
                tmpArr[i] = Convert.ToInt32(x % 10);
                x = x / 10;
                i += 1;
            }
            tmpArr[i] = x;
            int palindrome = 0;
            for (int j = 0; j<=i; j++)
            {
                palindrome += tmpArr[j] * (int)Math.Pow(10,i-j);
            }
            return palindrome == inputValue;
        }
    }
}
