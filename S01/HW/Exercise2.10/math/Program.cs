namespace math;

class Program
{
   static double factorial(int n)
    {
        double result = 1;
        for (int i=1;i<=n;i++)
        {
            result *= i;
        }
        return result;
    }

    static double eulersconstant(double precision)
    {
        double sum = 1.0;
        double term = 0;
        int n = 1;
        while (term > precision)
        {
            term = 1.0 / factorial(n);
            sum += term;
            n++;
        } 
        return sum;
    }

    static double power(double x, double y)
    {
        double result = 1;
        for (int i = 0; i < y; i++)
        {
            result *= x;
        }
        return result;
    }

    static double exp(double x, double precision)
    {
        double sum = 1.0;
        double term = 0;
        int n = 1;
        while (term > precision)
        {
            term = power(x, n) / factorial(n);
            sum += term;
            n++;
        } 
        return sum;
    }

    static double exp2(double x, double precision)
    {
        double sum = 1.0;
        double term = 1.0;
        int n = 1;
        while (term > precision)
        {
            term *= x / n;
            sum += term;
            n++;
        } 
        return sum;
    }

    static double abs(double x)
    {
        double result = 0;
        if (x>=0)
            result = x;
        else
            result = -x;
        return result;
             
    }

    static bool near(double x, double y, double closeness = 0.001)
    {
     x = abs(x);
     y = abs(y);
    double max;
    if (x > y)
        max = x;
    else
        max = y;
    double d =abs(x - y);
    if (d < closeness * max)
        return true;
    else
        return false;
    }


    static double Sin(double x, double precision)
    {
        double radian = x * Math.PI / 180;
        double sum = radian;
        double term = radian;
        int n = 1;
        while (abs(term) > precision)
        {
            term *= -1 * radian * radian / ((2 * n) * (2 * n + 1));
            sum += term;
            n++;
        } 
        return sum;
    }

    static double SquareRoot(double x, double precision)
    {
        double low = 0;
        double high = x;
        double mid;
        while (high - low > precision)
        {
            mid = (low + high) / 2;
            if (mid * mid < x)
                low = mid;
            else
                high = mid;
        }
        return (low + high) / 2;
    }

    static double root(double x, int n, double precision)
    {
        double low = 0, high = x, mid;
        while (high - low > precision)
        {
            mid = (low + high) / 2;
            if (power(mid, n) < x)
                low = mid;
            else
                high = mid;
        }
        return (low + high) / 2;
    }

    static double ln(double x, double precision)
    {
        double low = 0;
        double high = x;
        double mid;
        while (high - low > precision)
        {
            mid = (low + high) / 2;
            if (exp(mid, precision) < x)
                low = mid;
            else
                high = mid;
        }
        return (low + high) / 2;
    }
}

class Stats
{
    static void Main()
    {
        double num;
        double sum = 0;
        double min = double.MaxValue;
        double max = double.MinValue;
        int count = 0;
        Console.WriteLine("enter number");
        while (true)
        {
            num = Convert.ToDouble(Console.ReadLine());
            if (num == -1) break;
            sum += num;
            if (num < min) min = num;
            if (num > max) max = num;
            count++;
        }
        Console.WriteLine($"Count: {count}, Average: {sum / count}, Min: {min}, Max: {max}");
    }
}
