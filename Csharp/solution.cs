class Solution
{
    /// <summary>
    /// 두 수를 나눈 나머지를 반환합니다.
    /// </summary>
    /// <param name="num1">첫 번째 정수</param>
    /// <param name="num2">두 번째 정수</param>

    public int Solution07092(int num1, int num2)
    {

        //소수 반영이 가능한 형 변환 필요
        double answer = ((double)num1 / num2) * 1000;
        // 다시 정수형으로
        return (int)answer;
    }

    public int Solution0709(int age)
    {

        int answer = 2022 - (age - 1);
        return answer;
    }

    public int Solution0704(int num1, int num2)
    {
        int answer = 0;
        answer = num1 % num2;
        return answer;
    }



}