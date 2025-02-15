#include<iostream>
#include <math.h>
using namespace std;


class Point
{
    public:
        double x;
        double y;
        Point(double r, double t)
        {
            x = r;
            y = t;
            cout << "x in d :"<<x<<"y in d :"<<y<<endl;
        }
        Point(double w)
        {
            x = w;
            y = w;
        }
        Point()
        {
            x =0;
            y = 0;
        }
        // Point (Point* p1)
        // {
        //     x = p1->x;
        //     y = p1->y;
        // }
        Point(const Point& q) //const corrections
        {
            x = q.x;
            //q.y +=1;
            y = q.y;
        }
    
        void print_point()
        {
          cout<<"x: " <<x<<" y: "<<y<<endl;
        }
        double distance_points(Point w)
        {
           double x_d = x - w.x;
           double y_d = y - w.y;
           return sqrt(x_d*x_d + y_d*y_d);
        }
        ~Point()
        {
            cout << "x in d :"<<x<<"y in d :"<<y<<endl;
        }


};
//void print_point(Point p)
//{
    //cout<<"x: " <<p.x<<" y: "<<p.y<<endl;
//}
//double distance_points(Point q , Point w)
//{
    //double x_d = q.x - w.x;
    //double y_d = q.y - w.y;
    //return sqrt(x_d*x_d + y_d*y_d);
//}
int main1()
{
    //Point p1;
    Point p1(4,5);
    //p1.x =4;
    //p1.y =5;
    //Point p2;
    Point p2(3,2);

    //p2.x =3;
    //p2.y =2;
    p1.print_point();
    p2.print_point();
    cout << p1.x<<endl;
    cout <<p1.y<<endl;
    cout << p2.x<<endl;
    cout <<p2.y<<endl;
    double r= p1.distance_points(p2);
    cout<< r<<endl;
    int a;
    cin>>a;
    cout<<"a:"<<a<<endl;
    Point p3(p2);
    p3.print_point();
    return 0;
}
int main()
{
    Point p1(1,1);
    int c = 5;
    if(c>3)
    {
        Point p2(2,2);
    }
    else
    {
        Point p3(3,3);
    }
}
