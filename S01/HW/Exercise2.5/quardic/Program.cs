namespace quardic;

class Program
{
    static void quardic(double A , double B, double C)
    {
        double delta = B*B-4*A*C;
        if(delta>0)
        {
            double x1 = (-B+Math.Sqrt(delta))/(2*A);
            double x2 = (-B-Math.Sqrt(delta))/(2*A);
            Console.WriteLine("x1="+x1);
            Console.WriteLine("x2="+x2);
        }
        else if (delta ==0)
        {
            double x1 = -B/(2*A);
            Console.WriteLine("x1="+x1);
        }
        else
        {
            Console.WriteLine("no real x");
        }

    }

    static void Main(string[] args)
    {
       double A = Convert.ToDouble(Console.ReadLine());
       double B = Convert.ToDouble(Console.ReadLine());
       double C = Convert.ToDouble(Console.ReadLine());
       quardic(A,B,C);
    
    }
}
