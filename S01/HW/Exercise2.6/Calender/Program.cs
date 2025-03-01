namespace Calender;

class Program
{
    static void PrintMonth(int monthnumber)
    {
        string[] months = {"Jan", "Feb", "Mar", "Apr", "May", "Jun","Jul", "Aug", "Sep", "Oct", "Nov", "Dec"};
        if(monthnumber>=1 && monthnumber<=12)
        {
            Console.WriteLine(months[monthnumber-1]);
        }
    }
    static void Main(string[] args)
    {
        for(int i=1;i<13;i++)
        {
            Console.Write("monthnumber");
            Console.Write(i);
            Console.Write(": ");
            PrintMonth(i);
        }
    }
}
