namespace power;

class Program
{
    static int power(int x, int y)
    {
        int result = 1;
        if(y>=0)
        {
           for(int i=1;i<=y;i++)
           {
                 result = result * x;
            }
        return result;
        }
        else
        {
            return 0;

        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine(power(5,2));

    }
}
