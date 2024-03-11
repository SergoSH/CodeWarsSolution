using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal static class ZigzagConversion
    {
        public static string Convert(string s, int numRows)
        {
            if (numRows==1) return s;

            string[] tempArr = s.Select(x => x.ToString()).ToArray();
            var secondDimension = tempArr.Length;
            string[,] zigzag = new string [numRows, secondDimension];
            int multiplicator = -1;
            int i = 0, j = 0, n=0;
            while (n< tempArr.Length) 
            {
                if (i == 0 || i == numRows-1)
                {
                    multiplicator *= -1;
                }
                zigzag[i,j] = tempArr[n];
                 if (multiplicator < 0) j++;
                i+= multiplicator;
                n++;
            }
            
            StringBuilder stringBuilder = new StringBuilder();
            for (i=0; i<numRows; i++)
                for (j=0; j < secondDimension; j++)
                {
                    {
                        stringBuilder.Append(zigzag[i,j]);
                    }
                
            }
            return stringBuilder.ToString();
        }
    }
}
