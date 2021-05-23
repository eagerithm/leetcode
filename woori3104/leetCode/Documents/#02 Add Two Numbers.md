# #02 Add Two Numbers

Category: Algorithms
CreatedDate: May 18, 2021 2:09 PM
Difficulty: Medium
language: c#
url: https://leetcode.com/problems/add-two-numbers/

## Question

You are given two **non-empty** linked lists representing two non-negative integers. The digits are stored in **reverse order**, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

**Example 1:**

![https://assets.leetcode.com/uploads/2020/10/02/addtwonumber1.jpg](https://assets.leetcode.com/uploads/2020/10/02/addtwonumber1.jpg)

```
Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [7,0,8]
Explanation: 342 + 465 = 807.

```

**Example 2:**

```
Input: l1 = [0], l2 = [0]
Output: [0]

```

**Example 3:**

```
Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
Output: [8,9,9,9,0,0,0,1]

```

**Constraints:**

- The number of nodes in each linked list is in the range `[1, 100]`.
- `0 <= Node.val <= 9`
- It is guaranteed that the list represents a number that does not have leading zeros.

## Answer

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
       public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode result = new ListNode(0);
        ListNode head = result;
        int carry = 0;
        int i = 0; int j =0;
        while(l1 != null || l2 != null){
            int sum = carry;
            
            if(l1 != null){
                sum += l1.val;
                l1 = l1.next;
                
            }
            
            if(l2 != null){
                sum += l2.val;
                l2 = l2.next;
            }
            
            if(sum >= 10){
                carry = sum / 10;
                sum = sum % 10;
            }else{
                carry = 0;
            }

            result.next = new ListNode(sum);
            result = result.next;
        }
        
        if(carry > 0){
            result.next = new ListNode(carry);
        }
        
        return head.next;
    }
}
```

 

## Submissions

Runtime: 96 ms, faster than 96.82% of C# online submissions for Add Two Numbers.

Memory Usage: 28.1 MB, less than 83.12% of C# online submissions for Add Two Numbers.

### Answer

처음에 풀었던 꽤 무식한방법. 

런타임에러가 났었지만 초반에는 링크드리스트를 순회하면서 값을 받아오고 

각 링크드리스트에서 받아온 밸류룰 다시 리버스해서 링크드리스트에 넣는 방식으로해서 

런타임에러가 났다ㅎㅎㅎ

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
    private ListNode results;
    
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {

        String num1 = "";
        ListNode node = l1;
        while(node!=null) {
            num1 += node.val;
            node = node.next;
        }
        String num2="";
        node = l2;
        while(node!=null) {
            num2 += node.val;
            node = node.next;
        }
        num1 = new String(num1.ToCharArray().Reverse().ToArray());
        num2 = new String(num2.ToCharArray().Reverse().ToArray());
        Int32  sum =  Convert.ToInt32(num1) + Convert.ToInt32(num2);
        System.Console.WriteLine(sum);
        char[] reverseSum = sum.ToString().ToCharArray();

        int i = reverseSum.Length-1;
        while(i>-1) {
            //System.Console.WriteLine(int.Parse(reverseSum[i].ToString()));
            
            insertNode(Convert.ToInt32(reverseSum[i].ToString()));
            i--;
        }

        //System.Console.WriteLine(results.next.val);
        return results;
    }
    
     public void insertNode(int data) {
        
        ListNode newNode = new ListNode();    // 새로운 노드 생성
        newNode.val=data;
        if(results == null) {
            // head 노드가 null인 경우 새로운 노드를 참조하도록 함
            this.results = newNode;
        } else {
            
            // head 노드가 null이 아닌 경우 temp 노드가 head를 참조.
            // tempNode는 마지막 노드를 찾아서 참조하기 위해 사용.
            ListNode tempNode = results;
            // temp 노드의 link가 null이 아닐 때까지 다음 노드를 참조.
            // tempNode.link는 다음 노드를 참조하고 있으므로,
            // tempNode = tempNode.link는 tempNode에 다음 노드를 참조하도록 하는 것.
            // while문이 모두 실행되면 tempNode는 가장 마지막 노드를 참조하게 됨.
            while(tempNode.next != null) {
                tempNode = tempNode.next;    // 다음 노드를 참조
                
            }
            // tempNode(마지막 노드)의 link가 다음 노드를 참조하도록 함. 
            tempNode.next = newNode;
        }
    }
}
```

## comment

### LinkedList(연결리스트)

연결 리스트, 링크드 리스트(linked list)는 각 노드가 데이터와 포인터를 가지고 한 줄로 연결되어 있는 방식으로 데이터를 저장하는 자료 구조이다. 이름에서 말하듯이 데이터를 담고 있는 노드들이 연결되어 있는데, 노드의 포인터가 다음이나 이전의 노드와의 연결을 담당하게 된다.

### **단일 연결 리스트[[편집](https://ko.wikipedia.org/w/index.php?title=%EC%97%B0%EA%B2%B0_%EB%A6%AC%EC%8A%A4%ED%8A%B8&action=edit&section=3)]**

![https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Single_linked_list.png/400px-Single_linked_list.png](https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Single_linked_list.png/400px-Single_linked_list.png)

단일 연결 리스트의 구조

단일 연결 리스트는 각 노드에 자료 공간과 한 개의 포인터 공간이 있고, 각 노드의 포인터는 다음 노드를 가리킨다.

### **이중 연결 리스트[[편집](https://ko.wikipedia.org/w/index.php?title=%EC%97%B0%EA%B2%B0_%EB%A6%AC%EC%8A%A4%ED%8A%B8&action=edit&section=4)]**

![https://upload.wikimedia.org/wikipedia/commons/thumb/c/ca/Doubly_linked_list.png/400px-Doubly_linked_list.png](https://upload.wikimedia.org/wikipedia/commons/thumb/c/ca/Doubly_linked_list.png/400px-Doubly_linked_list.png)

이중 연결 리스트의 구조

이중 연결 리스트의 구조는 단일 연결 리스트와 비슷하지만, 포인터 공간이 두 개가 있고 각각의 포인터는 앞의 노드와 뒤의 노드를 가리킨다.

### **원형 연결 리스트[[편집](https://ko.wikipedia.org/w/index.php?title=%EC%97%B0%EA%B2%B0_%EB%A6%AC%EC%8A%A4%ED%8A%B8&action=edit&section=5)]**

![https://upload.wikimedia.org/wikipedia/commons/thumb/9/98/Circurlar_linked_list.png/400px-Circurlar_linked_list.png](https://upload.wikimedia.org/wikipedia/commons/thumb/9/98/Circurlar_linked_list.png/400px-Circurlar_linked_list.png)

단순 원형 연결 리스트의 구조

원형 연결 리스트는 일반적인 연결 리스트에 마지막 노드와 처음 노드를 연결시켜 원형으로 만든 구조이다.