namespace Exercise2._3;

class Program
{
    static void Head()
    {
        Console.WriteLine("     ^      ");
        Console.WriteLine("    /|\\     ");
        Console.WriteLine("   //|\\\\   ");
        Console.WriteLine("  ///|\\\\\\   ");

    }
     static void Body()
    {
        for(int i=0;i<6;i++)
            Console.WriteLine(" +*******+  ");
    }
    static void Line()
    {
        Console.WriteLine(" +-------+  ");
    }


    static void Main(string[] args)
    {
        Head();
        Line();
        for(int j=0;j<4;j++)
        {
            Body();
            Line();
        }
        Head();
        
    }
}
