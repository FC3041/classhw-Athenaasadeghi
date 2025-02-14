using System;
namespace Exercise2._2;

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
        Console.WriteLine(" +*******+  ");
        Console.WriteLine(" +*******+  ");
        Console.WriteLine(" +*******+  ");
        Console.WriteLine(" +*******+  ");

    }
    static void Line()
    {
        Console.WriteLine(" +-------+  ");
    }
    static void Main()
    {
        Head();
        Line();
        Body();
        Line();
        Body();
        Line();
        Head();
    }
}
