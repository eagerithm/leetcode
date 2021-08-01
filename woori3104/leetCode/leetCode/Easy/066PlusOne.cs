
using System.Collections.Generic;
using System.Linq;

public class PlusOneClass
{
    /*
    * Given a non-empty array of decimal digits representing a non-negative integer, increment one to the integer.
    *
    *   The digits are stored such that the most significant digit is at the head of the list, and each element in the array contains a single digit.
    *
    *   You may assume the integer does not contain any leading zero, except the number 0 itself.
    *
    *
    *
    *   Example 1:
    *
    *   Input: digits = [1,2,3]
    *   Output: [1,2,4]
    *   Explanation: The array represents the integer 123.
    *   Example 2:
    *
    *   Input: digits = [4,3,2,1]
    *   Output: [4,3,2,2]
    *   Explanation: The array represents the integer 4321.
    *   Example 3:
    *
    *   Input: digits = [0]
    *   Output: [1]
    *
    *
    *   Constraints:
    *
    *   1 <= digits.length <= 100
    *   0 <= digits[i] <= 9
    *
    */

    // Runtime: 232 ms, faster than 81.67% of C# online submissions for Plus One.
    // Memory Usage: 30.8 MB, less than 45.02% of C# online submissions for Plus One.
    public int[] PlusOne(int[] digits)
    {
        // 배열을 List로 변환 (데이터를 추가하게 되는 경우를 위해)
        List<int> results = digits.ToList();

        // 기존 마지막 인덱스를 취득
        int last = digits.Length - 1;
        // 마지막 값에 1을 더함
        results[last] = results[last] + 1;

        // 마지막 값이 10을 넘는 경우 
        while (results[last] > 9)
        {
            // 10이 넘는 값이 마지막 값이 아닌경우
            if (last > 0 && results[last] > 9)
            {
                results[last] = results[last] - 10;
                results[last - 1] = results[last - 1] + 1;
            }
            // 10이 넘는 경우 값이 마지막 값인 경우
            else if (results[last] > 9)
            {
                results[last] = results[last] - 10;
                // 리스트의 첫번째의 1을 추가해줌
                results.Insert(0, 1);
                last++;
            }
            last--;
        }
        return results.ToArray();
    }
}