namespace AverageOfSquare;

class Program
{
    static double average_of_squeres0(int n)
    {
        double sum =0;
        for(int i=0;i<n;i++)
        {
            sum = sum + (i*i);
        }
        return sum/n;
    }
    static double average_of_squeres1(int n)
    {
        double sum =0;
        for(int i=1;i<=n;i++)
        {
            sum = sum + (i*i);
        }
        return sum/n;
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine(average_of_squeres0(5));
        Console.WriteLine(average_of_squeres1(4));
        Console.WriteLine(average_of_squeres1(5));
    }
}
