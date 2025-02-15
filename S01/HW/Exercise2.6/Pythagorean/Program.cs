namespace Pythagorean;

class Program
{
    static void find_pythagorean_triples()
    {
        for (int a=1;a<100;a++)
        {
            for (int b=a+1;b<100;b++)
            {
                for (int c = b+1;c<100;c++)
                    if (a*a+b*b==c*c)
                    {
                       Console.Write(" "+a);
                       Console.Write(" "+b);
                       Console.Write(" "+c);
                       Console.WriteLine();
                    }
            }
        }
    }
    static void Main(string[] args)
    {
        find_pythagorean_triples();
    }
}
