using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public static class AnimalAge
    {
        public static IEnumerable<int> GetAnimalYears(int max, int[] arr)
        {
            for (int i = 0; i < max; i++)
            {
                if (i < arr.Length)
                {
                    yield return arr[i];
                }
                else
                {
                    yield return arr[arr.Length - 1];
                }
            }
        }
    }
}
