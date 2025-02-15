namespace FtoC;

class Program
{
    static void Main(string[] args)
    {
       
        float F = Convert.ToSingle(Console.ReadLine());
        float C = (F - 32) * 5 / 9;
        Console.WriteLine(C);
    }
}
