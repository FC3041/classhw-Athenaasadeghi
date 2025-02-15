namespace Factorial;

class Program
{
    static int Factorial(int n)
    {
        int result = 1;
        for(int i=1;i<=n;i++)
        {
            result = result *i;
        }
        return result;

    }
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Factorial(n));
        for(int i=1;i<=20;i++)
        {
            Console.WriteLine(i+":"+Factorial(i));
            //Console.WriteLine(":");
            //Console.WriteLine(Factorial(i));
        }
    }
}
