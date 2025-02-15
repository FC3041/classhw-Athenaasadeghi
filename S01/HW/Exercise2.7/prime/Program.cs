namespace prime;

class Program
{
    static bool IsDivisible(int a, int b)
    {
        if(a%b==0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static bool Is_Prime(int n)
    {
        if (n==1)
        {
            return false;
        }
        else if (n==2)
        {
            return true;
        }
        else
        {
            for (int i=2;i<n;i++)
            {
                if (IsDivisible(n,i))
                   return false;
            }
            return true;
        }
        
        
    }

    static void Main(string[] args)
    {
        for(int i=1;i<101;i++)
        {
            if (Is_Prime(i))
               Console.WriteLine(i);
        }
    }
}
