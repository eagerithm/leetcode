/**
 * Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.

    Assume the environment does not allow you to store 64-bit integers (signed or unsigned).

    Example 1:

    Input: x = 123
    Output: 321
    Example 2:

    Input: x = -123
    Output: -321
    Example 3:

    Input: x = 120
    Output: 21
    Example 4:

    Input: x = 0
    Output: 0
 

    Constraints:

    -231 <= x <= 231 - 1
 * 
 **/



public class Solution
{
    public int Reverse(int x)
    {

        // �Է¹��� ������ �ڸ����� ����
        int digit = x.ToString().Length;
        if (x < 0)
            digit -= 1;
        // �ӽ� ������ �Է¹��� ���ڸ� ����
        int temp = x;
        // ��� ��ȯ�� ���� ����
        double result = 0;
        int j = 0;
        // �Է¹��� ������ �ڸ�����ŭ ����
        for (int i = digit - 1; i > -1; i--)
        {
            int div = (int)Math.Pow(10, i);
            int share = temp / div;
            temp = x % div;
            result += share * Math.Pow(10, j);

            j++;
        }
        if (result > Math.Pow(2, 31) || result < Math.Pow(-2, 31) - 1)
        {
            return 0;
        }
        return (int)result;
    }
}