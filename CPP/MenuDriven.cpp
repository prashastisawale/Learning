#include <iostream>
using namespace std;

int main() {
    int choice;
    float balance = 1000, amount;

    do {
        cout << "\n1.Check Balance\n2.Deposit\n3.Withdraw\n4.Exit\n";
        cin >> choice;

        switch(choice) {
        case 1:
            cout << "Balance = " << balance << endl;
            break;

        case 2:
            cout << "Enter amount: ";
            cin >> amount;
            balance += amount;
            break;

        case 3:
            cout << "Enter amount: ";
            cin >> amount;
            if(amount <= balance)
                balance -= amount;
            else
                cout << "Insufficient balance\n";
            break;

        case 4:
            cout << "Exit\n";
            break;
        }

    } while(choice != 4);

    return 0;
}