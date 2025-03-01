namespace SUM;

class Program
{
    static int compute_sum(int n)
    {
        int sum =0;
        for (int i=1;i<n+1;i++)
        {
            sum = sum +i;
        }
        return sum;

    }
    static void Main(string[] args)
    {
        Console.WriteLine("N    |    Compute_Sum(N)");
        Console.WriteLine("----------------------");
        for (int i=9;i>0;i--)
        {
             Console.Write(i);
             Console.Write("       ");
             Console.WriteLine(compute_sum(i));}
        

    }
}
