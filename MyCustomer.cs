public class MyCustomer
{
    // 필드
    private string name;
    private int age;

    // 이벤트 
    public event EventHandler NameChanged;

    // 생성자 (Constructor)
    public MyCustomer()
    {
        name = string.Empty;
        age = -1;
    }

    // 속성
    public string Name
    {
        get
        {
            Console.WriteLine("이름 넘김");
            return this.name;
        }
        set
        {
            if (this.name != value)
            {
                this.name = value;
                if (NameChanged != null)
                {
                    NameChanged(this, EventArgs.Empty);
                }
            }
        }
    }
    public int Age
    {
        get { return this.age; }
        set
        {

            if (value < 0)
            {
                Console.WriteLine("음수 안됨");
            }
            else
            {
                this.age = value;
            }
        }
    }

    public void SetAge(int value)
    {
        if (value < 0)
        {
            Console.WriteLine("음수 안됨");
        }
        else
        {
            age = value;
        }
    }
    // 메서드
    public string GetCustomerData()
    {
        string data = string.Format($"Name: {Name} (Age: {Age})");
        return data;
    }

    public int CalAge(int val)
    {
        Age = Age - val;
        return Age;
    }
}