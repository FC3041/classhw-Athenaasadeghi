#include<iostream>
#include<stdlib.h>

using namespace std;
template<typename T>

class MyList
{
    public:
        int m_size;
        int m_capacity;
        T* m_pNums;

        MyList():m_size(0),m_capacity(0),m_pNums(nullptr){};

        MyList(int size, int capacity , const T* nums)
        :m_size(size), m_capacity(capacity)
        {
            m_pNums = (T *)malloc(sizeof(T)*capacity);
            for (int i=0; i<m_size;i++)
            {
                m_pNums[i] = nums[i];
            }
        }

        void print_list()
        {
            cout << "size:" << m_size << " capacity:" << m_capacity << endl;
            for(int i=0;i<m_size;i++)
            {
                cout << m_pNums[i] << ",";
            }
            cout << endl;

        }

        int len(){return m_size;}

        void append(int value)
        {
            if (m_size == m_capacity)
            {
                if (m_size ==0){resize(1);}
                else
                {
                    resize(m_capacity*2);
                }
            }
            m_pNums[m_size] = value;
            m_size ++;
        }

        void insert(int index, T value)
        {
            if (m_size==m_capacity)
            {
                if (m_size==0){resize(1);}
                else{resize(m_capacity*2);}
            }
            for(int i=m_size; i>=index ;i--)
            {
                m_pNums[i] = m_pNums[i-1]; 
            }
            m_pNums[index] = value;
            m_size++;
        }

        void clear()
        {
            m_size = 0;
            resize(1);
        }

        void erase(int index)
        {
            for(int i=index;i<m_size-1;i++)
            {
                m_pNums[i] = m_pNums[i+1];
            }

            m_size --;
        }
        void reverse()
        {
            for (int i=0;i<m_size/2;i++)
            {
                T temp = m_pNums[i];
                m_pNums[i] = m_pNums[m_size-1-i];
                m_pNums[m_size-1-i] = temp;
            }
        }
    


    private:
        void resize(int newsize)
        {
            T* newNums = (T*)malloc(sizeof(T)*(newsize));
            for(int i=0; i<m_size;i++)
            {
                newNums[i] = m_pNums[i];
            }
            free(m_pNums);
            m_pNums = newNums;
            m_capacity = newsize;

        }
};

int main()
{
    MyList <int> l1;

    double nums[5] = {1.2,3.4,5.6,7.8,9.1};
    MyList l2(5, 10, nums);

    l2.print_list();
    l2.append(19);

    l2.print_list();

    l2.insert(1, 55);
    l2.print_list();

    l2.erase(1);
    l2.print_list();
    l2.reverse();
    l2.print_list();

    return 0;
}