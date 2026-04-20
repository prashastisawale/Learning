#include <iostream>
using namespace std;

class Analyzer {
    int *arr, n;

public:
    void accept() {
        cout << "Enter number of elements: ";
        cin >> n;

        arr = new int[n];   // dynamic allocation

        cout << "Enter elements:\n";
        for(int i = 0; i < n; i++) {
            cin >> arr[i];
        }
    }

    void analyze() {
        int max = arr[0], min = arr[0], sum = 0;

        for(int i = 0; i < n; i++) {
            if(arr[i] > max) max = arr[i];
            if(arr[i] < min) min = arr[i];
            sum += arr[i];
        }

        cout << "Maximum = " << max << endl;
        cout << "Minimum = " << min << endl;
        cout << "Average = " << (float)sum / n << endl;
    }

    ~Analyzer() {
        delete[] arr;   // free memory
    }
};

int main() {
    Analyzer a;
    a.accept();
    a.analyze();
    return 0;
}