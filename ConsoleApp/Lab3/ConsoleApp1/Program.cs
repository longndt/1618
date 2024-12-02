public class Program
{
    //declare function (method) : hàm
    //type 1: no parameter, no return (void)
    public static void SayHello()
    {
        for (int i=1; i<=20; i++) {
            if (i%2==0)   //even number
             Console.WriteLine(i + " : Hello Greenwich");
        }
    }

    //type 2: have parameter, no return 
    public static void Welcome (string name, int age)  //name, age: parameter (tham số)
    {
        Console.WriteLine("Welcome " + name  + "(" + age + " year old) to Greenwich");    
    }

    //type 3: no parameter, have return (int, double, float, string, boolean,...)
    public static int GetCurrentYear()
    {
        int currentYear = DateTime.Now.Year;
        return currentYear;
    }

    //type 4: have parameter + return
    public static int CalculateTotal (int a, int b)
    {
        int c = a + b;
        return c;
    }

    public static void Main()
    {
        //call (revoke) function
        Console.Write("Input x: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Input y: ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(CalculateTotal(x, y));


        Welcome("Hoang", 20); //"Hoang" : argument (đối số)

        Console.WriteLine("We are living in " + GetCurrentYear());

        SayHello();


    }
}

