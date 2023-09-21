using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    /*
     найти в заданном массиве 2 числа, дающих заданную сумму.
     
     */
    internal class LeetTwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] temp = new int[nums.Length];
            Array.Copy(nums, temp, nums.Length);
            Array.Sort(temp);
            int i = nums.Length - 1;
            int j = 0;

            while (j < i)
            {
                if (temp[i] + temp[j] == target)
                {
                    var IdxI = Array.IndexOf(nums, temp[i]);
                    var IdxJ = Array.IndexOf(nums, temp[j]);
                    if (IdxJ == IdxI)
                    {
                        IdxI = Array.IndexOf(nums, temp[i], IdxI + 1);
                    }
                    return new int[] { IdxJ, IdxI };
                }
                else if (temp[i] + temp[j] < target)
                {
                    j++;
                }
                else if (temp[i] + temp[j] > target)
                {
                    i--;
                    j = 0;
                }
            }


            return null;
        }
    }
}
