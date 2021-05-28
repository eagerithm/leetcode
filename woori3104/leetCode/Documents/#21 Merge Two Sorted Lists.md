# #21 Merge Two Sorted Lists

Category: Algorithms
CreatedDate: May 21, 2021 1:07 AM
Difficulty: Easy
language: c#
url: https://leetcode.com/problems/merge-two-sorted-lists/

Merge two sorted linked lists and return it as a **sorted** list. The list should be made by splicing together the nodes of the first two lists.

**Example 1:**

![https://assets.leetcode.com/uploads/2020/10/03/merge_ex1.jpg](https://assets.leetcode.com/uploads/2020/10/03/merge_ex1.jpg)

```
Input: l1 = [1,2,4], l2 = [1,3,4]
Output: [1,1,2,3,4,4]

```

**Example 2:**

```
Input: l1 = [], l2 = []
Output: []

```

**Example 3:**

```
Input: l1 = [], l2 = [0]
Output: [0]

```

**Constraints:**

- The number of nodes in both lists is in the range `[0, 50]`.
- `100 <= Node.val <= 100`
- Both `l1` and `l2` are sorted in **non-decreasing** order.

```csharp
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
         if (l1 == null)
            return l2;
        else if (l2 == null)
            return l1;
        
        ListNode result = new ListNode(),
                 cur = result;
        
        while(l1 != null && l2 != null) {
            if (l1.val < l2.val) {
                cur.next = l1;
                l1 = l1.next;
            } else {
                cur.next = l2;
                l2 = l2.next;
            }
            cur = cur.next;
                        
        }
        if (l1 != null)
            cur.next = l1;
        
        if (l2 != null)
            cur.next = l2;
        return result.next;  
    }
}
```

### Submissions

Runtime: 88 ms, faster than 90.25% of C# online submissions for Merge Two Sorted Lists.

Memory Usage: 26.3 MB, less than 62.05% of C# online submissions for Merge Two Sorted Lists.