class Solution
{
    /// <summary>
    /// 양꼬치
    /// </summary>
    /// <param name="n">양꼬치 인분</param>
    /// <param name="k">음료수 개수</param>


public int[] Solution07142(int[] num_list)
    {
       int[] answer = new int[num_list.Length];
        
        for (int i = 0; i < num_list.Length; i++) {
            answer[i] = num_list[num_list.Length - 1 - i];
        }

        return answer;
    }

    public double Solution0714(int[] numbers)
    {
        double sum = 0;
        double answer = 0;

        //for
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     sum += numbers[i];
        // }

        //foreach

        foreach (int num in numbers)
        {
            sum += num;
        }

        answer = sum / numbers.Length;
        return answer;
    }

    public int Solution07112(int n)
    {
        int answer = 0;


        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                answer += i;
            }
        }

        return answer;
    }


    public int Solution0711(int n, int k)
    {
        int answer = 0;

        int freeDrinks = n / 10; //무료음료수
        int paidDrinks = k - freeDrinks; //유료음료수


        answer = (n * 12000) + (paidDrinks * 2000);
        return answer;
    }
    public int Solution07102(int angle)
    {

        int answer = 0;
        String str = "";
        Console.Write(angle + "도는 ");

        if (angle > 0 && angle < 90)
        {
            str = "예";
            answer = 1;
        }
        else if (angle == 90)
        {
            str = "직";
            answer = 2;

        }
        else if (angle > 90 && angle < 180)
        {
            str = "둔";
            answer = 3;


        }
        else if (angle == 180)
        {
            str = "평";
            answer = 4;

        }
        Console.WriteLine(str + "각입니다");

        return answer;

    }

    public int Solution0710(int num1, int num2)
    {

        int answer = num1 + num2;
        return answer;
    }

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