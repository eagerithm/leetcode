# #01 Two Sum

Category: Algorithms
CreatedDate: May 14, 2021 7:59 PM
Difficulty: Easy
language: c#
url: https://leetcode.com/problems/two-sum/

## 1. Two Sum

Given an array of integers `nums` and an integer `target`, return *indices of the two numbers such that they add up to `target`*.

You may assume that each input would have ***exactly* one solution**, and you may not use the *same* element twice.

You can return the answer in any order.

### Example 1:

```csharp
Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Output: Because nums[0] + nums[1] == 9, we return [0, 1].
```

### Example 2:

```csharp
Input: nums = [3,2,4], target = 6
Output: [1,2]
```

### Answer : C#

```csharp
public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        var dic = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            var cur = nums[i];
            if (dic.ContainsKey(cur)) {
                return new int[] {dic[cur], i};
            } else {
                dic[target - cur] = i;
            }
        }

        return new int[] {  };
    }
}
```

## Result

Runtime: 244 ms, faster than 44.01% of C# online submissions for Two Sum.

Memory Usage: 31.6 MB, less than 88.70% of C# online submissions for Two Sum.

### Answer : C#

```csharp
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // 결과반환용 변수 선언
        int[] result = new int[2];
        
        for (int i = 0; i < nums.Length; i++) {
            for (int j = i+1; j< nums.Length; j++) {
                // 두개의 수를 더해서 target과 일치하는 경우, 결과값에 저장
                if (nums[i] + nums[j] == target) {
                    result[0] = i;
                    result[1] = j;
                    break;
                }
            }
        }
        return result;
    }
}

```

## Result

Runtime: 248 ms, faster than 24.47% of C# online submissions for Two Sum.

Memory Usage: 31.8 MB, less than 36.32% of C# online submissions for Two Sum.

## Comment

# **자료 구조별 시간복잡도**

[Untitled](#01%20Two%20Sum%202200a0785f774947a9775fadb22e624c/Untitled%20Database%206bc710dd3e2649d8bd7be38ba6425acb.csv)

여러가지 자료구조를 쓸때 사용하는 목적에 따라 알맞는 자료구조를 선택해서 사용해야 효율을 높일 수 있다.

**List<T>**

빈틈없이 데이터의 적재하는 장점

insert메서드를 사용하면 특정 위치에 원소를 추가할 수 있는데 그렇게 되면 특정 원소 뒤에 있는 모든 원소는 뒤로 밀려난다. 그렇기 때문에 O(n)의 시간이 걸리게된다. Add는 단순히 맨마지막에 추가하는 것이기 때문에 O(1)이다.

**LinkedList<T>**

자료의 삽입과 삭제가 용이하다.

값을 들고있는 노드들과 다음/이전 노드의 포인터를 갖고있는 자료구조이며, 특정 노드에서 노드를 삽입,삭제하기에 편리하다. 특정 값을 검색하기 위해서는 전체 노드를 검사해야 하므로 효율적이지 않음

**Dictionary<K,T>**

검색,삭제,추가가 상수시간의 시간복잡도를 가진다.

헤쉬테이블과 비슷하지만 자료형을 명확하게 설정하기에 보다 효율이 좋을 경우가 많다.