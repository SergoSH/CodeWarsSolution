using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal static class ValidParentheses
    {
        public static bool IsValid(string s)
        {
            Stack<char> chars = new Stack<char>();
            Dictionary<char, char> bigDic = new Dictionary<char, char>
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };

            foreach (char c in s)
            {
                switch (c)
                {
                    case '(':
                    case '{':
                    case '[':
                        chars.Push(c);
                        break;
                    case ')':
                    case '}':
                    case ']':
                        if(chars.Count > 0)
                        {
                            if(bigDic[chars.Pop()] != c) {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                        break;
                }
            }


            return chars.Count ==0;
        }
    }
}
