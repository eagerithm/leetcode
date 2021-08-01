
using System.Collections.Generic;
using System.Linq;

public class PlusOneClass
{
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