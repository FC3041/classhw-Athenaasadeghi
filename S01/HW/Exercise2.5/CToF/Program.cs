namespace CToF;

class Program
{
    static void Main(string[] args)
    {
        float C = Convert.ToSingle(Console.ReadLine());
        float F = (C*9/5) + 32;
        Console.WriteLine(F);
    }
}
