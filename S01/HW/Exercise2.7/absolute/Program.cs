namespace absolute;

class Program
{
    static void absolute(int n)
    {
        if(n>=0)
          Console.WriteLine(n);
        else
           Console.WriteLine(-n);
          
    }
    static void Main(string[] args)
    {
        absolute(-100);
        absolute(-1);
        absolute(0);
        absolute(1);
        absolute(1000);
    }
}
