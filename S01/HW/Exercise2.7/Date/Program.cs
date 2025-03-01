namespace Date;

class Program
{
    static bool is_leap_year(int year)
    {
        if(year%400==0)
          return true;
        else if (year%4 ==0 & year%100!=0)
          return true;
        else
        {
            return false;
        }
    }
    static int days_in_month(int monthnumber,int year)
    {
        if (monthnumber ==1|monthnumber ==3|monthnumber ==5|monthnumber ==7|monthnumber ==8|monthnumber ==10|monthnumber ==12)
            return 31;
        else if (monthnumber ==4|monthnumber ==6|monthnumber ==9|monthnumber ==11)
           return 30;
        else if (monthnumber ==2& is_leap_year(year)==false)
                return 28;
        else if(monthnumber ==2& is_leap_year(year))
        {
            return 29;
        }
        else 
            return 0;    
    }
    static int days_before_date(int year,int monthNumber,int dayNumber)
    {
        int days = 0;
        for(int i=1;i<monthNumber;i++)
        {
            days = days + days_in_month(i,year);
        }
        days = days + (dayNumber-1);
        return days;
    }
    static string day_of_the_week(int year , int monthNumber,int dayNumber)
    {
        string[] daynumber = {"Monday","Tuesday","Wendsday","Thursday","Friday","Saturday","sunday"};
        for(int i=0;i<7;i++)
        {
            if( days_before_date(year,monthNumber,dayNumber)%7 ==i)
               return daynumber[i];
        }
        return "Invalid date";
    }

    static void Main(string[] args)
    {
        Console.WriteLine(days_in_month(2,2000));
        Console.WriteLine(days_before_date(2014, 1, 1));
        Console.WriteLine(days_before_date(2014, 12, 31));
        Console.WriteLine(day_of_the_week(2024, 11, 29));
        
    }
}
