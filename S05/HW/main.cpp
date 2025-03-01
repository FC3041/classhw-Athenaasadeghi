#include <iostream>
using namespace std;

class vector_int {
public:
    int* m_data;
    int m_capacity;
    int m_size = 0;
    int get_size()
    {
        for (int i = 0; m_data[i] == 0; i++)
        {
            m_size ++;
        }
        return m_size;
        
    }

    void resize()
    {
        if (m_capacity ==0)
        {
            m_capacity = 1;
        }
        else
        {
            m_capacity = 2 * m_capacity;
        }
        
        int* newData = new int[m_capacity];
        for (int i = 0; i < m_size; i++) {
            newData[i] = m_data[i];
        }
        delete[]m_data;
        m_data = newData;
    }
    int capacity()
    {
        return m_capacity;
    }


    vector_int() : m_data(nullptr), m_capacity(0), m_size(0) {}

    ~vector_int() {
        delete[] m_data;
    }

    void push_back(int value) {
        if (m_size == m_capacity) {
            resize();
        }
        m_data[m_size++] = value;
    }
    void begin (int value)
    {
        

    }

    void pop_back() {
        if (m_size > 0) {
            m_size--;
        }
    }

    int at(int index) 
    {
        if (index >= m_size) {
            throw out_of_range("Index out of range");
        }
        return m_data[index];
    }
    int* begin()
    {
        return m_data;
    }
    void insert(int* position, int value)
   {
    if (m_size == m_capacity)
    {
        resize();
    }
    for (int i = m_size; i > position - m_data; i--) 
    {
        m_data[i] = m_data[i - 1]; 
    }
    *position = value;
    m_size++;
   }
   void erase(int* array)
   {
    for (int i = 0; i < m_size-1; i++)
    {
       array[i] = array[i+1];
    }
    array[m_size - 1] = 0;
    m_size--;
   }


   
};

int main() {
    vector_int nums;
    nums.push_back(10);
    nums.push_back(20);
    nums.push_back(30);
    nums.push_back(40);

    for (size_t i = 0; i < nums.get_size(); i++) {
        cout << nums.at(i) << " ";
    }
    cout << endl;
    
    nums.pop_back();
    for (size_t i = 0; i < nums.get_size(); i++) {
        cout << nums.at(i) << " ";
    }
    cout << endl;
    nums.insert(nums.begin(), 2);
    for (size_t i = 0; i < nums.get_size(); i++) {
        cout << nums.at(i) << " ";
    }
    cout << endl;
    nums.erase(nums.begin()); 
    for (size_t i = 0; i < nums.get_size(); i++) {
        cout << nums.at(i) << " ";
    }
    
    return 0;
}
