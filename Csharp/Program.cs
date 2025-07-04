internal class Program
{
    private static void Main(string[] args)
    {
        //테스트
        Console.WriteLine(Solution0704(1342343420, 5342));
    }

    public static int Solution0704(int num1, int num2)
    {
        int answer = 0;
        answer = num1 % num2;
        return answer;
    }
}