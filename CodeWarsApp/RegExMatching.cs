using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodeWars
{
    /*Regular Expression Matching
     * Given an input string s and a pattern p, implement regular expression matching with support for '.' and '*' where:

        '.' Matches any single character.​​​​
        '*' Matches zero or more of the preceding element.
        The matching should cover the entire input string (not partial).
     * 
     Example 1:

        Input: s = "aa", p = "a"
        Output: false
        Explanation: "a" does not match the entire string "aa".
        Example 2:

        Input: s = "aa", p = "a*"
        Output: true
        Explanation: '*' means zero or more of the preceding element, 'a'. Therefore, by repeating 'a' once, it becomes "aa".
        Example 3:

        Input: s = "ab", p = ".*"
        Output: true
        Explanation: ".*" means "zero or more (*) of any character (.)".
 

        Constraints:

        1 <= s.length <= 20
        1 <= p.length <= 20
        s contains only lowercase English letters.
        p contains only lowercase English letters, '.', and '*'.
        It is guaranteed for each appearance of the character '*', there will be a previous valid character to match.
    */
    internal static class RegExMatching
    {
        public static bool IsMatch(string s, string p)
        {


            StringBuilder sb = new StringBuilder();
            if (!p.Contains('*') && !p.Contains('.'))
            {
                return s.Equals(p); //если нет служебных '*' и '.', то проверяем на эквивалентность строк
            }
            else if (p.Contains('.')) //если только точка, то обрамляем начало и конец входной строки признаками начала и конца, иначе 
                //штатный регэкс будет лишнее пропускать
            {
                sb.Append('^').Append(p).Append('$');
            }
            else //в общем случае разделяем входную строку на массив и формируем рег выражение по частям.
            {
                var spl = p.Split('*',StringSplitOptions.RemoveEmptyEntries);
                sb.Append('^');
                string element;
                for (int i = 0; i < spl.Length; i++)
                {
                    element = spl[i];
                    if (element.Equals('.'))
                    {
                        sb.Append(@"\w");
                    }
                    else
                    {
                        sb.Append(element.Substring(0, element.Length - 1)).Append("[").Append(element.Last()).Append("]*");
                    }

                }
                if(!p.Last().Equals('*') && sb.ToString().Last().Equals('*')) sb.Length --; //в строке выше сразу приписывается *,
                //но если это конец входной строки и там нет *, то она лишняя
                sb.Append('$');
            }
            
            Regex regex = new Regex(sb.ToString());
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                return true;
            }
            return false;

        }
    }
}
