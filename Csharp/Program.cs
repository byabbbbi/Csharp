internal class Program
{

    private static void Main(string[] args)
    {
        //테스트
        Solution sol = new Solution();
        Console.WriteLine(sol.Solution0711(30, 5));

        Csstudy csstudy = new Csstudy();
        csstudy.Listsample();
   MakeLotto();

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