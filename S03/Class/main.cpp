#include<iostream>
#include<string.h>
#include<stdlib.h>
class Student
{
    public:
        int m_stdNum;
        char m_Firstname[20];
        char m_LastName[20];
        int m_CourcedPassed;
        int m_Credits[40];
        double m_Grades[40];
        char* m_CourseNames[40];

        double GetGPA()
        {
            double sumGrades =0;
            int sumCredit =0;
            for(int i=0;i<m_CourcedPassed;i++)
            {
                sumGrades+=m_Credits[i] * m_Grades[i];
                sumCredit +=m_Credits[i];
            }
            return sumGrades / sumCredit;
         }
         void list_cources()
         {
            for(int i=0;i<m_CourcedPassed;i++)
            {
                std::cout<<m_CourseNames[i]<<":"
                    <<m_Credits[i]<<":"
                    <<m_Grades[i]<<std::endl;
            }
         }
         void register_cource(int credits,const char* name,double grade)
         {
            m_Credits[m_CourcedPassed] = credits;
            m_Grades[m_CourcedPassed] = grade;
            m_CourseNames[m_CourcedPassed] = name;
            m_CourcedPassed++;

         }

};

void main()
{
    Student s;
    s.m_CourcedPassed = 0;
    char bufc[20];
    while (true)
    {
        std::cout<< " cource name?";



    }

    s.list_cources();
    std::cout <<s.GetGPA() <<std::endl;
    return 0;


}// کامل شه