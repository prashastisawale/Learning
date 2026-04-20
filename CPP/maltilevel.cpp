#include<iostream>
using namespace std;
class person{
    public:

    string name;


    void getPerson(){
        cout<<"Enter Name:";
        cin>>name;
    }


};

class Employee:public person{
    public:
    int salary;

    void getEmployee(){
        cout<<"Enter salary";
        cin>>salary;
    }

};

class Manager: public Employee{
    public:
    int teamSize;

    void getManager(){
        cout<<"Enter team size";
        cin>>teamSize;
    }

    void display(){
        cout<<"Name: "<<name<<endl;
        cout<<salary<<endl;
        cout<<teamSize<<endl;
    }

};

int main(){
    Manager m;
    m.getPerson();
    m.getEmployee();
    m.getManager();
    m.display();
    return 0;
}
