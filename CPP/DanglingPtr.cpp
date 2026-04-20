#include<iostream>
using namespace std;
#include<string.h>
class string1{
    int len;
    char *ptr;

public:
        void stringdisplay()
        {
            cout<<"length is"<<len<<endl;
            cout<<"string is"<<ptr<<endl;

        }
        string1(char * sptr)
        {
            len=strlen(sptr);
            ptr=new char[len+1];
            strcpy(ptr,sptr);
        }
        ~string1()
        {
            cout<<"destructor is called\n";
            if(ptr!= NULL)
            delete[]ptr;
        }
    };
int main()
{
    string1 c1("rahul");
    c1.stringdisplay();
    {
        string1 c2(c1);
        c2.stringdisplay();


    }
    c1.stringdisplay();
}


