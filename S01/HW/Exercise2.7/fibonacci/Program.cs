namespace fibonacci;

class Program
{
    static int fibonacci(int n)
    {
        if(n<=0)
          return 0;
        else if (n==1 | n==2)
           return 1;
        else
        {
            return fibonacci(n-2) + fibonacci(n-1);
        }
    }
    static void Main(string[] args)
    {
        for(int i=1;i<21;i++)
        {
            Console.Write(i+":");
            Console.WriteLine(fibonacci(i));
        }
    }
}
