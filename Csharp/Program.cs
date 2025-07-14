internal class Program
{

    private static void Main(string[] args)
    {
        //테스트
        Solution sol = new Solution();
        int[] sampleInput = { 1, 4, 3, 6, 5 };
        Console.WriteLine(string.Join(", ", sol.Solution07142(sampleInput)));


        Csstudy csstudy = new Csstudy();
        csstudy.LinkedListsample();
        //    MakeLotto();

    }

    public static void MakeLotto()
    {
        var nums = new HashSet<int>();
        var rand = new Random();
        while (nums.Count < 6)
            nums.Add(rand.Next(1, 46));
        Console.WriteLine("[" + string.Join(", ", nums.OrderBy(n => n)) + "]");
    }



}