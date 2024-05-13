using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class MedianOfTwoSortedArrays
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int i1 = 0 , i2 = 0, i=0;
            bool odd = Convert.ToBoolean((nums1.Length + nums2.Length) % 2);
            int lastIndex = (nums1.Length + nums2.Length) / 2;
            int[] resNums = new int[lastIndex+1];
            while (i1 + i2 < lastIndex+1)
            {
                if (i1 >= nums1.Length)
                {
                    resNums[i] = nums2[i2];
                    i2++;
                    i++;
                }else if (i2 >= nums2.Length)
                {
                    resNums[i] = nums1[i1];
                    i1++;
                    i++;
                }
                else
                {
                    if (nums1[i1] < nums2[i2])
                    {
                        resNums[i] = nums1[i1];
                        i1++;
                        i++;
                    }
                    else
                    {
                        resNums[i] = nums2[i2];
                        i2++;
                        i++;
                    }
                }
            }

            return odd? resNums[lastIndex]: Convert.ToDouble(resNums[lastIndex]+ resNums[lastIndex-1])/2;
        }
    }
}
