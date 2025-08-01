// Util을 사용하기 위해 필요한 namespace의 사용선언
using Zinine;

internal class Program
{
    /// <summary>
    /// Main 함수
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        var intArray = new int[] {1, 2, 7, 10, 11 };
        var strArr1 = new string[] { "ab", "b", "c" };
        var strArr2 = new string[] { "m", "dot" };
        Solution sol = new Solution();
        Console.WriteLine(sol.Solution08012(intArray));
        //Util.PrintIntArray(sol.Solution07282(strArr1));

        CSStudy study = new CSStudy();
        //study.ArrayExample();

        MyCustomer mc = new MyCustomer();
        mc.Name = "Kim";
        mc.Age = 20;
        // mc.SetAge(-23);
        Console.WriteLine(mc.GetCustomerData());
        Console.WriteLine(mc.CalAge(30));
    }
}