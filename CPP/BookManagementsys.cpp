#include <iostream>
using namespace std;

class Book
{
    int bookId;
    string title;
    string author;
    float price;

public:
   
    void input()
    {
        cout << "Enter Book ID: ";
        cin >> bookId;

        cout << "Enter Book Title: ";
        cin >> title;

        cout << "Enter Author Name: ";
        cin >> author;

        cout << "Enter Price: ";
        cin >> price;
    }

    // Function to display data
    void display()
    {
        cout << "\nBook ID: " << bookId << endl;
        cout << "Title: " << title << endl;
        cout << "Author: " << author << endl;
        cout << "Price: " << price << endl;
    }
};

int main()
{
    Book b[4];   

    cout << "Enter details of 4 books\n";

  
    for(int i = 0; i < 4; i++)
    {
        cout << "\nEnter details for Book " << i+1 << endl;
        b[i].input();
    }

   
    cout << "\n--- Book Details ---\n";
    for(int i = 0; i < 4; i++)
    {
        b[i].display();
    }

    return 0;
}