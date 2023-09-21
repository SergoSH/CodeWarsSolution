using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    /*
     * You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Example 1:
Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [7,0,8]
Explanation: 342 + 465 = 807.

Example 2:
Input: l1 = [0], l2 = [0]
Output: [0]

Example 3:
Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
Output: [8,9,9,9,0,0,0,1]
 
Constraints:
The number of nodes in each linked list is in the range [1, 100].
0 <= Node.val <= 9
It is guaranteed that the list represents a number that does not have leading zeros.

    */
    
    static internal class LeetAddTwoNumbers
    {
        static public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int remainder = 0;
            ListNode ans = new ListNode();
            ListNode cur1 = l1;
            ListNode cur2 = l2;
            //int val1, val2;
            ListNode curAns = ans;



            do
            {

                remainder = Calc(cur1, cur2, ans, remainder);
                if (cur1?.next != null || cur2?.next != null)
                {
                    ans.next = new ListNode();
                    ans = ans.next;
                   
                }
                cur1 = cur1?.next;
                cur2 = cur2?.next;
            }
            while (cur1 != null || cur2 != null);

            if (remainder > 0)
            {
                ans.next = new ListNode();
                ans = ans.next;
                ans.val = remainder;
            }
    
            return curAns;
        }

        public static int Calc(ListNode cur1, ListNode cur2, ListNode ans, int remainder)
        {
            int val1, val2, newRemainder;
            if (cur1 == null) val1 = 0; else val1 = cur1.val;
            if (cur2 == null) val2 = 0; else val2 = cur2.val;

            if (val1 + val2 + remainder >= 10)
            {
                newRemainder = 1;
            }
            else
            {
                newRemainder = 0;
            }
            ans.val = val1 + val2 + remainder - newRemainder * 10;
            return newRemainder;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }


}
