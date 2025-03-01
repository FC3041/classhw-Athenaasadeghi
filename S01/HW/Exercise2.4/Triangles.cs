using System;
namespace Exercise2._4;

class Program
{
    static void print_right_triangles(int base1, char charecter)
    {
        for (int i = 1; i <= base1; i++)
        {
            for (int j = 0; j < base1 - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < i; j++)
            {
                Console.Write(charecter);
            }
            Console.WriteLine();}
    }
    
    static void print_left_triangles(int base1 , char charecter)
    {
        for (int i = 1; i <= base1; i++)
        {

            for (int j = 0; j < i; j++)
            {
                Console.Write(charecter);
            }
            Console.WriteLine();
        }
        
    }
    static void Main(string[] args)
    {
        int base1 = 20;
        char charecter = '*';
        print_right_triangles(base1,charecter);
        print_left_triangles(base1,charecter);
        
    }
}


