using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class LongestPalindrome
    {
        public static string getLongestPalindrome(string s)
        {

            if (s.Length == 1) return s;
            string[] arr = s.ToCharArray().Select(x => x.ToString()).ToArray();
            string[] palindromes = new string[s.Length];
            string[] palindromesEven = new string[s.Length];
            for (int i = 1; i< s.Length; i++)
            {
                palindromes[i] = getOddPalindrome(s, i);
                palindromesEven[i] = getEvenPalindrome(s, i);
            }


            var res = palindromes.Concat(palindromesEven).Where(x => x != null && x != string.Empty);
            if (res.Count() == 0) 
                return s.Substring(0, 1);
            else
                return res.OrderByDescending(s => s.Length).First();
        }

        private static string getOddPalindrome(string s, int position){
            int leftPosition = position - 1, rightPosition = position +1;
            while(leftPosition>=0 && rightPosition < s.Length && 
                s.Substring(leftPosition, 1) == s.Substring(rightPosition, 1))
            {
                leftPosition--;
                rightPosition++;
            }
            if(leftPosition == position - 1 && rightPosition == position + 1)
            {
                return s.Substring(position, 1);
            }
            else
            {
                return s.Substring(leftPosition+1, rightPosition - leftPosition-1);
            }
            

        }

        private static string getEvenPalindrome(string s, int position)
        {
            int leftPosition = position - 1, rightPosition = position;
            while (leftPosition >= 0 && rightPosition < s.Length &&
                s.Substring(leftPosition, 1) == s.Substring(rightPosition, 1))
            {
                leftPosition--;
                rightPosition++;
            }
            if (leftPosition == position - 1 && rightPosition == position)
            {
                return "";
            }
            else
            {
                return s.Substring(leftPosition + 1, rightPosition - leftPosition-1);
            }


        }

    }
}
