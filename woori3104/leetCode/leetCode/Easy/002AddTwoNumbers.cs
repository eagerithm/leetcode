using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public class AddTwoNumbersClass
    {
        /*
         *   You may assume the two numbers do not contain any leading zero, except the number 0 itself.
         *
         *   ** Example 1:**
         *
         *   ![https://assets.leetcode.com/uploads/2020/10/02/addtwonumber1.jpg](https://assets.leetcode.com/uploads/2020/10/02/addtwonumber1.jpg)
         *
         *   ```
         *   Input: l1 = [2,4,3], l2 = [5,6,4]
         *           Output: [7,0,8]
         *           Explanation: 342 + 465 = 807.
         *
         *   ```
         *
         *   **Example 2:**
         *
         *   ```
         *   Input: l1 = [0], l2 = [0]
         *           Output: [0]
         *
         *   ```
         *
         *   **Example 3:**
         *
         *   ```
         *   Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
         *           Output: [8,9,9,9,0,0,0,1]
         *
         *   ```
         *
         *   **Constraints:**
         *
         *   - The number of nodes in each linked list is in the range `[1, 100]`.
         *   - `0 <= Node.val <= 9`
         *   - It is guaranteed that the list represents a number that does not have leading zeros.
         *
         *
         */


        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode(0);
            ListNode head = result;
            int carry = 0;
            while (l1 != null || l2 != null) {
                int sum = carry;

                if (l1 != null) {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)  {
                    sum += l2.val;
                    l2 = l2.next;
                }
                if (sum >= 10)  {
                    carry = sum / 10;
                    sum = sum % 10;
                } else {
                    carry = 0;
                }
                result.next = new ListNode(sum);
                result = result.next;
            }

            if (carry > 0) { 
                result.next = new ListNode(carry);
            }
            return head.next;
        }
    }
}
