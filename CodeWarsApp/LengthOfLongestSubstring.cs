using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class LengthOfLongestSubstring
    {
        public static int getLengthOfLongestSubstring (string s) //bacdaef
        {
            if (s.Length == 0) return 0;
            string[] arr = s.ToCharArray().Select(c => c.ToString()).ToArray();
            string tempStr = arr[0];
            int indexOfRepeatingLetter;
            int firstSymbolOfSubString = 0;
            List<string> lst= new();

            for (int i = 1;i<arr.Length; i++)
            {
                indexOfRepeatingLetter = s.IndexOf(arr[i], firstSymbolOfSubString);
                if (indexOfRepeatingLetter == -1 || indexOfRepeatingLetter>=i)
                {
                    tempStr += arr[i];
                }
                else
                {
                    lst.Add(tempStr);
                    firstSymbolOfSubString = indexOfRepeatingLetter + 1;
                    tempStr = s.Substring(firstSymbolOfSubString, i- indexOfRepeatingLetter);
                }
            }
            lst.Add(tempStr);
            var res = lst.Where(s=>s.Length == lst.Max(x => x.Length)).FirstOrDefault();
            return lst.Max(x => x.Length);
        }
    }
}
