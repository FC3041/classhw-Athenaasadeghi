namespace ComputeChanges;

class Program
{
    static void compute_change(int n)
    {
        int quarters =0;
        int dime=0;
        int nickels=0;
        int pennies=0;
        if(n<100)
        {
            n = 100-n;
            quarters = n/25;
            n = n%25;
            dime = n/10;
            n = n%10;
            nickels= n/5;
            n = n%5;
            pennies=n/1;
        }
        Console.WriteLine(quarters+"quarters");
        Console.WriteLine(dime+"dime");
        Console.WriteLine(nickels+"nickels");
        Console.WriteLine(pennies+"pennies");

    }
    static void Main(string[] args)
    {
        compute_change(8);
    }
}
