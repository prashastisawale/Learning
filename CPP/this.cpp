/*
#include<iostream>
using namespace std;
class Complex
{
  int real,img;
  public:
    Complex(int r,int i)
    {
      real=r;
      img=i;
    }
    void display()
    {
      cout<<"address inside this  is "<<this<<endl;
      cout<<this->real<<"+"<<this->img<<"i"<<endl;
    }
};
int main()
{

  Complex c1(1,2);
  cout<<"address of object c1 is "<<&c1<<endl;
  c1.display();
  
  Complex c2(3,4);
    cout<<"address of object c1 is "<<&c2<<endl;
  c2.display();
  
  
}
  */

  /*
#include<iostream>
using namespace std;
class Complex
{
  int real,img;//instance variable
  public:
    Complex(int real,int img)//local variable
    {
      this->real=real;
      this->img=img;
    }
    void display()
    {
    
      cout<<real<<"+"<<this->img<<"i"<<endl;
    }
};
int main()
{

  Complex c1(1,2);
  c1.display();
}


*/
/*

#include<iostream>
using namespace std;
class Employee
{
  int id;
  char name[30];
  public:
    void getdata();
    void putdata();
};
void Employee::getdata()
{
  cout << "Enter Id : ";
  cin >> id;
  cout << "Enter Name : ";
  cin >> name;
}
void Employee::putdata()
{
  cout << id << " ";
  cout << name << " ";
  cout << endl;
}
int main()
{
  // This is an array of objects having maximum limit of 30 Employees
  Employee emp[30];
  int n, i;
  cout << "Enter Number of Employees present today ";
  cin >> n;
   
  // Accessing the function
  for(i = 0; i < n; i++)
    emp[i].getdata();
   
  cout << "Employee Data - " << endl;
   
  // Accessing the function
  for(i = 0; i < n; i++)
    emp[i].putdata();
}

*/


#include<iostream>
using namespace std;

class Test
{
public:
    void show()
    {
        cout << this ;
    }
};

int main()
{
    Test t1, t2;

    t1.show();
    t2.show();
}
