#include<iostream>
using namespace std;
class Student{
    public:
    string name;

    //default constructor
    Student(){
        name = "unknown";
    }

    void display(){
        cout<<"Name:" <<name;
    }
};
int main(){
    Student s;
    s.display();

    return 0;
}