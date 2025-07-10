class Csstudy
{
    public void ArrayExample()
    {
        int sum = 0;
        int[] nums = new int[10];

        // for (int i = 0; i < nums.Length; i++)
        // {
        //     nums[i] = i + 1;
        // }

        // Console.WriteLine(string.Join(", ", nums));

        Random rand = new Random();
    

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = rand.Next() % 100;
            Console.WriteLine(nums[i]); // 각각의 수 출력
        }

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }

        Console.WriteLine("sum= " + sum);

    }

    public void Datatype()
    {

        bool b = true; // bool 타입
        short sh = -32768;
        int i = 2147483647;
        long l = 12345L;
        float f = 123.95F;
        double d1 = 123.45;
        double d2 = 123.45D;
        decimal d = 123.45M;

        Console.WriteLine(f);
        i = (int)f;
        Console.WriteLine(i);

        char c = 'A';
        string s = "HELLO";
        string s2 = null;
        string s3 = "";
        string s4 = string.Empty;

        DateTime dt = new DateTime(2025, 7, 9, 11, 16, 00);

        if (i > int.MaxValue)
        {

        }
    }
}