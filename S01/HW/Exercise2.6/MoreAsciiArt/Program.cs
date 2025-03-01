namespace MoreAsciiArt;

class Program
{
    static void print_left_triangle(int base1)

    {
        for(int i =1;i<=base1;i++)
        {
            if (i%2==0)
            {
                for(int j=0;j<i;j++)
                {
                    Console.Write("*");
                }
            }
            else
            {
                for(int z=0;z<i;z++)
                {
                    Console.Write("%");
                }

            }
            Console.WriteLine();
        }
    }
    static void PrintCone(int baseSize)
        {
            int k = (baseSize / 2) + 1;
            if (baseSize % 2 != 0)
            {
                PrintSpaces(k);
                Console.WriteLine("^");
                for (int i = 1; i < k; i++)
                {
                    PrintSpaces(k - i);
                    PrintSlashes(i);
                    Console.Write("|");
                    PrintSlashes1(i);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("just odd");
            }
        }
        static void PrintSpaces(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(" ");
            }
        }
        static void PrintSlashes(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("/");
            }
        }
        static void PrintSlashes1(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("\\");
            }
        }
    static void Main(string[] args)
    {
        print_left_triangle(10);
        PrintCone(7);
        for(int i=1;i<10;i++)
        {
            if (i%2==1)
                PrintCone(i);
        }
    }
}
