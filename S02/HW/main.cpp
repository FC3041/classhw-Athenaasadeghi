#include<iostream>
#include <cmath>
using namespace std;
class Circle
{
    public:
          double x;
          double y;
          double r;
    Circle(double a, double b, double c)
    {
        x = a;
        y = b;
        r = c;
    }
    double p()
    {
        double p = M_PI * 2* r;
        return p;
    }
    double s()
    {
        double s = M_PI * r * r;
        return s;
    }
    bool is_in_circle(double a,double b)
    {
        double d = sqrt((x-a)*(x-a) + (y-b)*(y-b));
        if(d==r)
           return true;
        else
           return false;
    }
    double distance (double a,double b)
    {
        double d = sqrt((x-a)*(x-a) + (y-b)*(y-b));
        return d;
    }
};
int main()
{
    Circle c(0,0,2);
    cout<<c.distance(1,1)<<endl;
}