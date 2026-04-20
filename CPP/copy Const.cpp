#include<iostream>
using namespace std;
#include<string.h>
class string1
{
	int len;
	char *ptr;
public:
	void stringdisplay()
	{
	cout<<"length is "<<len<<endl;
	cout<<"string is "<<ptr<<endl;
	}
	string1(char * sptr)
	{
		len=strlen(sptr);
		ptr=new char[len+1];
		strcpy(ptr,sptr);
	}
	~string1()
	{
		cout<<"destuctor is called\n";
		if(ptr!=NULL)
		delete[]ptr;
	}
	//userdefined copy constructor to avoid dangling pointer situation
	string1(string1& c1_new)
	{
		cout<<"copy constructor is called\n";
		this->len=c1_new.len;
		this->ptr=new char[this->len+1];
		strcpy(this->ptr,c1_new.ptr);
		
	}
	
};
int main()
{	
	string1 c1("rahul");
	c1.stringdisplay();
	{
	
	string1 c2(c1);//COPY CONSTRUCTOR
	c2.stringdisplay();
	}
	c1.stringdisplay();
}
